using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCode : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collect")
        {
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            newPos.z = newPos.z + 10 * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            newPos.z = newPos.z - 10 * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            newPos.x = newPos.x - 10 * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            newPos.x = newPos.x + 10 * Time.deltaTime;
        }

        transform.position = newPos;




    }
}
