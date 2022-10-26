using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GridElement : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    // on indices within the grid so we can forward thm to method calls later
    private int _currentRow;
    private int _currentColumn;

    // a mathematical XZ plane we will use for the dragging input
    // you could as well just use physics raycasts 
    // but for now just wanted to keep it simple
    private static Plane _dragPlane = new Plane(Vector3.up, 1f);

    // reference to the grid to forward invoke methods
    private Grid _grid;

    // the world position where the current draggin was started
    private Vector3 _startDragPoint;

    // camera used to convert screenspace mouse position to ray
    [SerializeField]
    private Camera _camera;

    public void Initialize(Grid grid)
    {
        // assign the camera 
        if (!_camera) _camera = Camera.main;

        // store the grid reference to later forward the input calls
        _grid = grid;
    }

    // plain set the indices to the new values
    public void UpdateIndices(int currentRow, int currentColumn)
    {
        _currentRow = currentRow;
        _currentColumn = currentColumn;
    }

    // called by the EventSystem when starting to drag this object
    public void OnBeginDrag(PointerEventData eventData)
    {
        // get a ray for the current mouse position
        var ray = _camera.ScreenPointToRay(eventData.position);

        // shoot a raycast against the mathemtical XZ plane
        // You could as well use Physics.Raycast and get the exact hit point on the collider etc 
        // but this should be close enough especially in top-down views
        if (_dragPlane.Raycast(ray, out var distance))
        {
            // store the world space position of the cursor hit point
            _startDragPoint = ray.GetPoint(distance);
        }
    }

    // Called by the EventSystem while dragging this object
    public void OnDrag(PointerEventData eventData)
    {
        var ray = _camera.ScreenPointToRay(eventData.position);

        if (_dragPlane.Raycast(ray, out var distance))
        {
            // get the dragged delta against the start position
            var currentDragPoint = ray.GetPoint(distance);
            var delta = currentDragPoint - _startDragPoint;

            // we either only drag vertically or horizontally
            if (Mathf.Abs(delta.x) > Mathf.Abs(delta.z))
            {
                // clamp the delta between -1 and 1
                delta.x = Mathf.Clamp(delta.x, -1f, 1f);

                // and tell the grid to move this entire row
                _grid.MoveRow(_currentRow, delta.x);
            }
            else
            {
                delta.z = Mathf.Clamp(delta.z, -1f, 1f);

                // accordingly tell the grid to move this entire column
                _grid.MoveColumn(_currentColumn, delta.z);
            }
        }
    }

    // Called by the EventSystem when stop dragging this object
    public void OnEndDrag(PointerEventData eventData)
    {
        var ray = _camera.ScreenPointToRay(eventData.position);

        if (_dragPlane.Raycast(ray, out var distance))
        {
            // as before get the final delta
            var currentDragPoint = ray.GetPoint(distance);
            var delta = currentDragPoint - _startDragPoint;

            // Check against a threashold - if simply went with more then the half of one step
            // and shift the grid into the according direction
            if (delta.x > 0.5f)
            {
                _grid.ShiftRowRight(_currentRow);
            }
            else if (delta.x < -0.5f)
            {
                _grid.ShiftRowLeft(_currentRow);
            }
            else if (delta.z > 0.5f)
            {
                _grid.ShiftColumnUp(_currentColumn);
            }
            else if (delta.z < -0.5f)
            {
                _grid.ShiftColumnDown(_currentColumn);
            }
            else
            {
                // if no direction matched at all just make sure to reset the positions
                _grid.RefreshIndices();
            }
        }
    }
}