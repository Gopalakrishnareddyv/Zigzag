using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeadScript : MonoBehaviour
{
    public GameObject deathui;
    PlayerMovement playermove;

    // Start is called before the first frame update
    void Start()
    {
        playermove = GetComponent<PlayerMovement>();
        /*if (transform.position.y != 1.0f)
        {
            print("Game Over");
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        //print(transform.position.y);
        if (transform.position.y== 1.0f)
        {
            //print("Game Over");

            
            
        }
        else
        {
            deathui.SetActive(true);
            transform.position = new Vector3(-1.5f, 1, -2);
            playermove.playerspeed = 0;
        }
        
    }
}
