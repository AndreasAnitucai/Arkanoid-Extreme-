using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemaster : MonoBehaviour
{
    public GameObject block;
    private int level = 1;
    void Start()
    {
        Camera cam = Camera.main;

        float H = 2f * cam.orthographicSize;
        float W = H * cam.aspect;

        float Wd = W / H;
        float Hd = H / 13;
        Debug.Log("Hd: " + Hd);

        for (int j = 0; j < 6; j++)
        {
            for (int i = 0; i < 13; i++)
            {
                float x = (Wd * i)-W/2;
                float y = Hd * j;
                Debug.Log("x: " + x + " y: " + y);
                Vector3 blockPos = new Vector3(x+0.25f, y, 0);
                GameObject placedBlock = Instantiate(block, blockPos, transform.rotation);
                placedBlock.transform.localScale = new Vector3(2, 2, 1);

            }
        }


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
}
