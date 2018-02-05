using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCLNet;
using System.Runtime.InteropServices;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < OpenCL.NumberOfPlatforms; ++i)
            {
                Platform clPlatformTemp = OpenCL.GetPlatform(i);
                Console.WriteLine("Platform {0} -> {1}, {2}",
                    i, clPlatformTemp.Vendor, clPlatformTemp.Name);

                Device[] clDevicesTemp = clPlatformTemp.QueryDevices(DeviceType.ALL);
                foreach (Device clDeviceTemp in clDevicesTemp)
                    Console.WriteLine("-----> {0}, {1}, {2} Bytes, {3}",
                        clDeviceTemp.Name, clDeviceTemp.DeviceType,
                        clDeviceTemp.GlobalMemSize, clDeviceTemp.OpenCL_C_Version);


            }


            Platform clPlatform = null;
            Device clDevice = null;
            for (int i = 0; i < OpenCL.NumberOfPlatforms; ++i)
            {
                clPlatform = OpenCL.GetPlatform(i);
                if (!clPlatform.Name.Contains("AMD") && !clPlatform.Name.Contains("NVIDIA") && !clPlatform.Name.Contains("INTEL"))
                    continue;


                Device[] clDevices = clPlatform.QueryDevices(DeviceType.GPU);

                clDevice = clDevices[0];

                break;
            }

            Console.WriteLine();

            Context clContext = null;
            clContext = clPlatform.CreateDefaultContext();

            CommandQueue clCommandQueue = null;
            clCommandQueue = clContext.CreateCommandQueue(clDevice, CommandQueueProperties.NONE);


            int[] ArrayA = { 1, 2 };
            int[] ArrayB = { 2, 3 };
            int[] ArrayC = new int[2];

            int N = 100;
            float[] array = new float[N];


            for (int i = 0; i < N; ++i)
                array[i] = 1.0f * i / N;


            GCHandle arrayHandle;
            arrayHandle = GCHandle.Alloc(array, GCHandleType.Pinned);

            GCHandle ArrayAHandle;
            ArrayAHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
            GCHandle ArrayBHandle;
            ArrayBHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
            GCHandle ArrayCHandle;
            ArrayCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);





            Mem arrayBuffer = null;
            arrayBuffer = clContext.CreateBuffer(MemFlags.COPY_HOST_PTR,
                array.Length * sizeof(float), arrayHandle.AddrOfPinnedObject());


            Mem ArrayABuffer = null;
            ArrayABuffer = clContext.CreateBuffer(MemFlags.COPY_HOST_PTR,
                ArrayA.Length * sizeof(int), ArrayAHandle.AddrOfPinnedObject());

            Mem ArrayBBuffer = null;
            ArrayBBuffer = clContext.CreateBuffer(MemFlags.COPY_HOST_PTR,
                ArrayB.Length * sizeof(int), ArrayBHandle.AddrOfPinnedObject());

            Mem ArrayCBuffer = null;
            ArrayCBuffer = clContext.CreateBuffer(MemFlags.COPY_HOST_PTR,
                ArrayC.Length * sizeof(int), ArrayCHandle.AddrOfPinnedObject());

            //cos


            clCommandQueue.EnqueueReadBuffer(arrayBuffer, true, 0,
                array.Length * sizeof(float), arrayHandle.AddrOfPinnedObject());

            OpenCLNet.Program clProgram = null;
            clProgram = clContext.CreateProgramWithSource(File.ReadAllText("openCLkernels.cl"));
            clProgram.Build();

            Kernel clKernel = null;
            clKernel = clProgram.CreateKernel("Multiply");
            clKernel.SetArg(0, arrayBuffer);
            clKernel.SetArg(1, 25);

            Kernel clKernel2 = null;
            clKernel2 = clProgram.CreateKernel("Add");
            clKernel2.SetArg(0, ArrayABuffer);
            clKernel2.SetArg(1, ArrayBBuffer);
            clKernel2.SetArg(2, ArrayCBuffer);


            clCommandQueue.EnqueueNDRangeKernel(clKernel, 1, null, new int[] { N }, null);

            clCommandQueue.EnqueueReadBuffer(arrayBuffer, true, 0,
                array.Length * sizeof(float), arrayHandle.AddrOfPinnedObject());


            clCommandQueue.EnqueueNDRangeKernel(clKernel2, 1, null, new int[] { 2 }, null);
            clCommandQueue.EnqueueReadBuffer(ArrayABuffer, true, 0,
    ArrayA.Length * sizeof(int), ArrayAHandle.AddrOfPinnedObject());
            clCommandQueue.EnqueueReadBuffer(ArrayBBuffer, true, 0,
    ArrayB.Length * sizeof(int), ArrayBHandle.AddrOfPinnedObject());
            clCommandQueue.EnqueueReadBuffer(ArrayCBuffer, true, 0,
    ArrayC.Length * sizeof(int), ArrayCHandle.AddrOfPinnedObject());


            //    for (int i = 0; i < N; ++i)
            //      Console.Write("{0} ", array[i]);


            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
                Console.WriteLine("{0}", ArrayC[i]);

        }
    }
}



