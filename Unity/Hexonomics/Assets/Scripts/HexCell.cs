using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexCell : MonoBehaviour
{
    public HexCoordinates coordinates;

    public Color color;

    public int Elevation
    {
        get { return elevation; }
        set
        {
            elevation = value;
            Vector3 position = transform.localPosition;
            position.y = value * HexMetrics.elevationStep;
            transform.localPosition = position;
        }
    }

    int elevation;

    [SerializeField] HexCell[] neighbours;

    public HexCell GetNeighbour(HexDirection direction)
    {
        return neighbours[(int) direction];
    }

    public void SetNeighbour(HexDirection direction, HexCell cell)
    {
        neighbours[(int) direction] = cell;
        cell.neighbours[(int) direction.Opposite()] = this;
    }
}
