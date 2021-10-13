using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject player;
    public int cubeRange = 10;
    public int renderDistance;
    public Material material;
    public GameObject[] cubes;
    private GameObject plane;
    private Color mycolor;
    // Start is called before the first frame update
    void Start()
    {
        //material.color = mycolor;
        cubes = new GameObject[cubeRange];
        plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        plane.GetComponent<Renderer>().material = material;
        plane.transform.position = new Vector3(player.transform.position.x, plane.transform.position.y, player.transform.position.z);
        plane.transform.localScale = new Vector3(renderDistance / 3, 1, renderDistance / 3);
        for (int i = 0; i < cubeRange; i++)
        {
            cubes[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubes[i].transform.position = new Vector3(Random.Range(plane.transform.position.x - renderDistance, plane.transform.position.x + renderDistance), 1, Random.Range(plane.transform.position.z - renderDistance, plane.transform.position.z + renderDistance));
            cubes[i].transform.localScale = new Vector3(1, Random.Range(1, 10), 1);
            cubes[i].GetComponent<Renderer>().material = material;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        if (player.transform.position.x > plane.transform.position.x + renderDistance || player.transform.position.z > plane.transform.position.z + renderDistance || player.transform.position.x < plane.transform.position.x - renderDistance || player.transform.position.z < plane.transform.position.z - renderDistance)
        {
            plane.transform.position = new Vector3(player.transform.position.x, plane.transform.position.y, player.transform.position.z);
            for (int i = 0; i < cubeRange; i++)
            {
                cubes[i].transform.position = new Vector3(Random.Range(plane.transform.position.x - renderDistance, plane.transform.position.x + renderDistance), 1, Random.Range(plane.transform.position.z - renderDistance, plane.transform.position.z + renderDistance));
                cubes[i].transform.localScale = new Vector3(1, Random.Range(1, 10), 1);
            }
        }
        //if (player.transform.position.x > plane.transform.position.x + renderDistance)
        //{
        //    plane.transform.position = new Vector3(player.transform.position.x - renderDistance, plane.transform.position.y, player.transform.position.z);
        //    for (int i = 0; i < cubeRange; i++)
        //    {
        //        cubes[i].transform.position = new Vector3(Random.Range(plane.transform.position.x - renderDistance, plane.transform.position.x + renderDistance), 1, Random.Range(plane.transform.position.z - renderDistance, plane.transform.position.z + renderDistance));
        //        cubes[i].transform.localScale = new Vector3(1, Random.Range(1, 10), 1);
        //    }
        //}
        //if (player.transform.position.x > plane.transform.position.x - renderDistance)
        //{
        //    plane.transform.position = new Vector3(player.transform.position.x + renderDistance, plane.transform.position.y, player.transform.position.z);
        //    for (int i = 0; i < cubeRange; i++)
        //    {
        //        cubes[i].transform.position = new Vector3(Random.Range(plane.transform.position.x - renderDistance, plane.transform.position.x + renderDistance), 1, Random.Range(plane.transform.position.z - renderDistance, plane.transform.position.z + renderDistance));
        //        cubes[i].transform.localScale = new Vector3(1, Random.Range(1, 10), 1);
        //    }
        //}
        //if (player.transform.position.z > plane.transform.position.z - renderDistance)
        //{
        //    plane.transform.position = new Vector3(player.transform.position.x, plane.transform.position.y, player.transform.position.z + renderDistance);
        //    for (int i = 0; i < cubeRange; i++)
        //    {
        //        cubes[i].transform.position = new Vector3(Random.Range(plane.transform.position.x - renderDistance, plane.transform.position.x + renderDistance), 1, Random.Range(plane.transform.position.z - renderDistance, plane.transform.position.z + renderDistance));
        //        cubes[i].transform.localScale = new Vector3(1, Random.Range(1, 10), 1);
        //    }
        //}
        //if (player.transform.position.z > plane.transform.position.z + renderDistance)
        //{
        //    plane.transform.position = new Vector3(player.transform.position.x, plane.transform.position.y, player.transform.position.z - renderDistance);
        //    for (int i = 0; i < cubeRange; i++)
        //    {
        //        cubes[i].transform.position = new Vector3(Random.Range(plane.transform.position.x - renderDistance, plane.transform.position.x + renderDistance), 1, Random.Range(plane.transform.position.z - renderDistance, plane.transform.position.z + renderDistance));
        //        cubes[i].transform.localScale = new Vector3(1, Random.Range(1, 10), 1);
        //    }
        //}
    }
}
