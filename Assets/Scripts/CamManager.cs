using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour
{
    public GameObject _cam;


    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void CheckInput()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            _cam.transform.Rotate (0f, Time.deltaTime * -50f, 0f, Space.World);
        }

        if (Input.GetKey(KeyCode.E))
        {
            _cam.transform.Rotate (0f, Time.deltaTime * 50f, 0f, Space.World);
        }
    }
}
