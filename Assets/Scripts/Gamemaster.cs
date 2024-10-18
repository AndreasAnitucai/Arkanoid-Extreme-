using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemaster : MonoBehaviour
{
    public GameObject block;
    private int level = 1;
    public int gridElementWidth = 32;
    public int gridElementHeight = 16;
    void Start()
    {
        //Camera cam = Camera.main;

        //float H = cam.orthographicSize;
        //float W = cam.aspect;

        //float Wd = W / H;
        //float Hd = H / 13;
        //Debug.Log("Hd: " + Hd +" H: " +H+" W: "+W);

        //for (int j = 0; j < 6; j++)
        //{
        //    for (int i = 0; i < 13; i++)
        //    {
        //        float x = (Wd * i)-W/2;
        //        float y = Hd * j;
        //        Debug.Log("x: " + x + " y: " + y);
        //        Vector3 blockPos = new Vector3(x+0.25f, y, 0);
        //        GameObject placedBlock = Instantiate(block, blockPos, transform.rotation);
        //        placedBlock.transform.localScale = new Vector3(2, 2, 1);

            //}
            //CreateGrid();
        }
    //void CreateGrid()
    //{
    //    // Get the screen width and height in world units (using the main camera)
    //    float screenWidth = Camera.main.orthographicSize * 2 * Camera.main.aspect;
    //    float screenHeight = Camera.main.orthographicSize * 2;

    //    // Set the grid to take up the top half of the screen
    //    float gridHeight = screenHeight / 2;
    //    float gridWidth = screenWidth;

    //    // Calculate how many elements fit in the grid
    //    int columns = Mathf.FloorToInt(gridWidth / (gridElementWidth / 100f));
    //    int rows = Mathf.FloorToInt(gridHeight / (gridElementHeight / 100f));

    //    // Loop through rows and columns and instantiate the prefab at the correct position
    //    for (int y = 0; y < rows; y++)
    //    {
    //        for (int x = 0; x < columns; x++)
    //        {
    //            Vector2 position = new Vector2(
    //                (x * (gridElementWidth / 100f)) - (gridWidth / 2) + (gridElementWidth / 200f),
    //                (y * (gridElementHeight / 100f))
    //            );

    //            Instantiate(block, position, Quaternion.identity);
    //        }
    //    }
    //}

    // Update is called once per frame
    void Update()
        {
            //if (Input.GetMouseButtonDown(0)/*GameObject.FindGameObjectsWithTag("Blocks").Length <= 0*/)
            //{
            //    Debug.Log("Cake " + level);
            //    level++;
            //    Debug.Log("Cake " + level);
            //    SceneManager.LoadScene("Level" + level);
            //}
        }
    }
