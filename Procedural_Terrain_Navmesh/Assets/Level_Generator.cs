using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Level_Generator : MonoBehaviour
{

    public int width;
    public int height;

    public GameObject wall;

    public NavMeshSurface surface;

    // Start is called before the first frame update
    void Start()
    {
        GenerateLevel();

        surface.BuildNavMesh();
    }

    void GenerateLevel()
    {
        for (int x = 0; x < width; x+=2)
        {
            for (int y = 0; y < height; y+=2)
            {
                if (Random.value > .7f)
                {
                    Vector3 pos = new Vector3(x - width / 2f, 1f, y - height / 2f);
                    Instantiate(wall, pos, Quaternion.identity, transform);
                }
            }
        }
    }
}
