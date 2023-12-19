using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayerr : MonoBehaviour
{
    public float speed= 3;
    public Light flashlight;
    public AudioSource linternaSound;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        flashlight.enabled = false;
        linternaSound = GetComponent<AudioSource>();
        linternaSound.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        float movementVer = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float movementHor = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(movementHor, 0, movementVer);

        Run();
    }

    void Run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 5;
        }
        else
        {
            speed = 3;
        }
    }

    private void LateUpdate()
    {
        if(Input.GetMouseButtonDown(1))
        {
            flashlight.enabled = !flashlight.enabled;
            linternaSound.Play();
        }
    }

}
