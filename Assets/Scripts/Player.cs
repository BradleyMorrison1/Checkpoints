using System.Collections;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject respawnPoint;
    Vector3 respawnPosition;
    public GameObject[] checkpoint;
    public GameObject[] trigger;

    private void Start()
    {
        respawnPosition = respawnPoint.transform.position;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.transform.position = respawnPosition;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Killbox"))
        {
            gameObject.transform.position = respawnPosition; 
            Debug.Log("Test");
        }

        if(other.CompareTag("trigger"))
        {
            if (other.gameObject == trigger[0])
            {
                respawnPosition = checkpoint[0].transform.position;
                trigger[0].SetActive(false);

            }
            else if (other.gameObject == trigger[1])
            {
                respawnPosition = checkpoint[1].transform.position;
                trigger[1].SetActive(false);
            }

            else if (other.gameObject == trigger[2])
            {
                respawnPosition = checkpoint[2].transform.position;
                trigger[2].SetActive(false);
            }

            else if (other.gameObject == trigger[3])
            {
                respawnPosition = checkpoint[3].transform.position;
                trigger[3].SetActive(false);
            }
        }
    }
}
