using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Vector3 Direction;

    public GameObject winui;
    PlayerMovement playermove;

    public float playerspeed;
    public GameObject particleprefab;
    [SerializeField]
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        playermove = GetComponent<PlayerMovement>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Direction == Vector3.forward)
            {
                Direction = Vector3.left;
            }
            else
            {
                Direction = Vector3.forward;

            }
            score = score + 1;
        }
        transform.Translate(Direction * playerspeed * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            score = score + 10;
            print(score);
            other.gameObject.SetActive(false);
            Instantiate(particleprefab, transform.position, Quaternion.identity);
            if (score >=20)
            {
                winui.SetActive(true);
                transform.position = new Vector3(-1.5f, 1, -2);
                playermove.playerspeed = 0;
            }
        }
    }
   


}
