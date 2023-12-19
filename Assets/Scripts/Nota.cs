using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nota : MonoBehaviour
{
    public GameObject notaInGame;
    private bool active;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && active == true)
        {
            notaInGame.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && active == true)
        {
            notaInGame.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            active = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            active = false;
            notaInGame.SetActive(false);
        }
    }
}
