using UnityEngine;
using UnityEngine.Tilemaps;

[ExecuteInEditMode]
public class GridSizeSetter : MonoBehaviour
{
    public Grid grid;
    public Tilemap tilemap;
    public GameObject targetObject;

    void OnValidate()
    {
        // Update the grid size when something changes in the editor
        UpdateGridSize();
        AlignGrid();
        ScaleTilesToGrid();
    }

    void UpdateGridSize()
    {
        if (grid != null && targetObject != null)
        {
            // Get the size of the target object
            Vector3 objectSize = targetObject.GetComponent<SpriteRenderer>().bounds.size;

            // Set the grid's cell size to the object size
            grid.cellSize = objectSize;
        }
    }
    void AlignGrid()
    {
        if (grid != null)
        {
            // Get the main camera
            Camera mainCamera = Camera.main;

            // Get the top-right corner of the screen in world space
            Vector3 topRightScreen = new Vector3(Screen.width, Screen.height, 0);
            Vector3 topRightWorld = mainCamera.ScreenToWorldPoint(topRightScreen);

            // Set the z-axis position of the grid (same as grid's current position)
            topRightWorld.z = grid.transform.position.z;

            // Align the grid's position to the top-right corner
            grid.transform.position = topRightWorld;
        }
    }
    void ScaleTilesToGrid()
    {
        if (grid != null && tilemap != null)
        {
            // Get the grid's cell size
            Vector3 cellSize = grid.cellSize;

            // Loop through each tile in the tilemap
            foreach (var position in tilemap.cellBounds.allPositionsWithin)
            {
                TileBase tile = tilemap.GetTile(position);
                if (tile != null)
                {
                    // Get the sprite size of the tile (if the tile has a sprite)
                    Sprite sprite = (tile as Tile)?.sprite;
                    if (sprite != null)
                    {
                        Vector3 spriteSize = sprite.bounds.size;

                        // Calculate the scale factor needed to fit the tile within the grid cell
                        Vector3 scale = new Vector3(
                            cellSize.x / spriteSize.x,
                            cellSize.y / spriteSize.y,
                            1);  // Keep z as 1 since it's a 2D tilemap

                        // Apply this scale factor to the tilemap's transform
                        tilemap.transform.localScale = scale;
                    }
                }
            }
        }
    }
}