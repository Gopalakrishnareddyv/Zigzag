using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesScrpt : MonoBehaviour
{
    Rigidbody rbtemp;
    // Start is called before the first frame update
    void Start()
    {
        rbtemp = GetComponentInParent<Rigidbody>();

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
                StartCoroutine(nameof(TileFall));
                //print("triggered");
            }
            


        }
    }
    IEnumerator TileFall()
    {
        //yield return "Coroutine";
        yield return new WaitForSeconds(3);
        rbtemp.isKinematic = false;
        yield return new WaitForSeconds(1);
        rbtemp.isKinematic = true;
        if (rbtemp.gameObject.name =="Farwardtile")
        {
            TileManagerScript.Instance.AddFarwardTilePool(rbtemp.gameObject);
            //print("added to farward tile");
        }else if (rbtemp.gameObject.name == "Lefttile")
        {
            TileManagerScript.Instance.AddLeftTilePool(rbtemp.gameObject);
            //print("Added to left tile");
        }
    }
    
}
