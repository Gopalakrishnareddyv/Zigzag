using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManagerScript : MonoBehaviour
{
    public GameObject[] tiles;
    public GameObject currenttile;
    Stack<GameObject> farwardTilePool = new Stack<GameObject>();
    Stack<GameObject> leftTilePool = new Stack<GameObject>();

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
        CreateTiles(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateTiles(int value)
    {
        for (int i=0; i < value; i++)
        {
            farwardTilePool.Push(Instantiate(tiles[0]));
            leftTilePool.Push(Instantiate(tiles[1]));
            farwardTilePool.Peek().SetActive(false);
            leftTilePool.Peek().SetActive(false);
        }
        
    }
    public void TileSpawn()
    {
        if (farwardTilePool.Count==0 || leftTilePool.Count == 0)
        {
            CreateTiles(5);
        }
        int index = Random.Range(0, tiles.Length);
        if (index == 0)
        {
            GameObject temp = farwardTilePool.Pop();
            temp.SetActive(true);
            temp.transform.position = currenttile.transform.GetChild(index).position;
            currenttile = temp;
        }
        else if (index == 1)
        {
            GameObject temp = leftTilePool.Pop();
            temp.SetActive(true);
            temp.transform.position = currenttile.transform.GetChild(index).position;
            currenttile = temp;
        }
        

    }
}
