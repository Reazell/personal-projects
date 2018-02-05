<%@ page import="java.io.*"%>
<html>
<table>
<tr><th>File Name</th><th>Download File</th>
<%
File f = new File("C:/Users/sprzybyszewski/Desktop/ver2/apache-tomcat-8.0.45/webapps/camunda/WEB-INF/classes/bpmn/");
        File[] files = f.listFiles();
        for(int i=0;i<files.length;i++)
        {
            String name=files[i].getName();
            String path=files[i].getPath();
%>
<tr><td><%=name%></td><td><a href="download.jsp?f=C:/Users/sprzybyszewski/Desktop/ver2/apache-tomcat-8.0.45/webapps/camunda/WEB-INF/classes/bpmn/<%=name%>">Download File</a></td></tr>
     <%
        }
%>
</table>
      <br>
      <a href="UploadDownload.html">Go Back</a>
</html>