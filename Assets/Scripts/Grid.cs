using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Grid : MonoBehaviour
{
    // To make things simple for the demo I simply have 9 "GridElement" objects and place them later based on their index
    [SerializeField]
    private GridElement[] elements = new GridElement[9];

    // stores the current grid state
    private readonly GridElement[,] _grid = new GridElement[3, 3];

    private void Awake()
    {
        // go through the grid and assign initial elements to their positions and initialize them
        for (var column = 0; column < 3; column++)
        {
            for (var row = 0; row < 3; row++)
            {
                _grid[column, row] = elements[row * 3 + column];

                _grid[column, row].Initialize(this);
            }
        }

        RefreshIndices();
    }

    // Shifts the given column one step up with wrap around
    // => top element becomes new bottom
    public void ShiftColumnUp(int column)
    {
        var temp = _grid[column, 2];
        _grid[column, 2] = _grid[column, 1];
        _grid[column, 1] = _grid[column, 0];
        _grid[column, 0] = temp;

        RefreshIndices();
    }

    // Shifts the given column one step down with wrap around
    // => bottom element becomes new top
    public void ShiftColumnDown(int column)
    {
        var temp = _grid[column, 0];
        _grid[column, 0] = _grid[column, 1];
        _grid[column, 1] = _grid[column, 2];
        _grid[column, 2] = temp;

        RefreshIndices();
    }

    // Shifts the given row one step right with wrap around
    // => right element becomes new left
    public void ShiftRowRight(int row)
    {
        var temp = _grid[2, row];
        _grid[2, row] = _grid[1, row];
        _grid[1, row] = _grid[0, row];
        _grid[0, row] = temp;

        RefreshIndices();
    }

    // Shifts the given row one step left with wrap around
    // => left element becomes new right
    public void ShiftRowLeft(int row)
    {
        var temp = _grid[0, row];
        _grid[0, row] = _grid[1, row];
        _grid[1, row] = _grid[2, row];
        _grid[2, row] = temp;

        RefreshIndices();
    }

    // Iterates through all grid elements and updates their current row and column indices
    // and applies according positions
    public void RefreshIndices()
    {
        for (var column = 0; column < 3; column++)
        {
            for (var row = 0; row < 3; row++)
            {
                _grid[column, row].UpdateIndices(row, column);
                _grid[column, row].transform.position = new Vector3(4 * (column - 1), 0, 4* (row - 1));
            }
        }
    }

    // Called while dragging an element
    // Moves the entire row according to given delta (+/- 1)
    public void MoveRow(int targetRow, float delta)
    {
        for (var column = 0; column < 3; column++)
        {
            for (var row = 0; row < 3; row++)
            {
                _grid[column, row].transform.position = new Vector3(4 * (column - 1) + (row == targetRow ? delta : 0), 0, 4 * (row - 1));
            }
        }
    }

    // Called while dragging an element
    // Moves the entire column according to given delta (+/- 1)
    public void MoveColumn(int targetColumn, float delta)
    {
        for (var column = 0; column < 3; column++)
        {
            for (var row = 0; row < 3; row++)
            {
                _grid[column, row].transform.position = new Vector3(4 * (column - 1), 0, 4 * (row - 1) + (column == targetColumn ? delta : 0));
            }
        }
    }
}
