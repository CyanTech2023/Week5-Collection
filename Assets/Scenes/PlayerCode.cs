using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCode : MonoBehaviour
{
    bool letMove = true;
    public GameObject[] enemies;

    public float speed;
    public GameManager myManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collect")
        {
            myManager.allCollectables.Remove(other.gameObject);
            Destroy(other.gameObject);
        }

        for(int i = 0; i < myManager.enemyNum; i++)
        {
            if(other.gameObject == myManager.enemies[i])
            {
                letMove = false;
                Debug.Log("Hit!");
            }
        }



    }


    // Update is called once per frame
    void Update()
    {
        if (letMove)
        {

            Vector3 newPos = transform.position;

            if (Input.GetKey(KeyCode.W))
            {
                newPos.z = newPos.z + 5 * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.S))
            {
                newPos.z = newPos.z - 5 * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.A))
            {
                newPos.x = newPos.x - 5 * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.D))
            {
                newPos.x = newPos.x + 5 * Time.deltaTime;
            }

            transform.position = newPos;

        }


    }
}
