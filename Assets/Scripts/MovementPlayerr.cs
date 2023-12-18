using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayerr : MonoBehaviour
{
    public float speed= 3;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
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

}
