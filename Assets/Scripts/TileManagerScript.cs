using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManagerScript : MonoBehaviour
{
    public GameObject[] tiles;
    public GameObject currenttile;
    // Start is called before the first frame update
    private static TileManagerScript instance;

    public static TileManagerScript Instance 
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<TileManagerScript>();
            }
            return instance;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TileSpawn()
    {
        int index = Random.Range(0, tiles.Length);
        currenttile = (GameObject)Instantiate(tiles[index], currenttile.transform.GetChild(index).position , Quaternion.identity);

    }
}
