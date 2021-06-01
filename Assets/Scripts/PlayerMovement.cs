using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Vector3 Direction;

    public float playerspeed;
    public GameObject particleprefab;
    // Start is called before the first frame update
    void Start()
    {

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
        }
        transform.Translate(Direction * playerspeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            other.gameObject.SetActive(false);
            Instantiate(particleprefab, transform.position, Quaternion.identity);
        }
    }
}
