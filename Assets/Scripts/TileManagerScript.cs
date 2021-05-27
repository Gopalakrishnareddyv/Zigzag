using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManagerScript : MonoBehaviour
{
    public GameObject[] tiles;
    public GameObject currenttile;

    PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        //print(player.touch);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.touch)
        {
            TileSpawn();
            player.touch = false;
        }
    }
    void TileSpawn()
    {
        for(int i = 0; i < 20; i++)
        {
            int index = Random.Range(0, tiles.Length);
            currenttile = (GameObject)Instantiate(tiles[index], currenttile.transform.GetChild(index).position, Quaternion.identity);
            
        }
       
    }
}
