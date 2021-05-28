using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesScrpt : MonoBehaviour
{
    //Rigidbody tofall;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="player")
        {
            for(int i = 0; i < 5; i++)
            {
                TileManagerScript.Instance.TileSpawn();
                
                
                //Rigidbody tofall = GameObject.FindGameObjectWithTag("tile").AddComponent<Rigidbody>();

            }
            StartCoroutine("TileFall");


        }
    }
    IEnumerable TileFall()
    {
        yield return new WaitForSeconds(5);
        print("Waited");
        //tofall.useGravity = true;
    }
    
}
