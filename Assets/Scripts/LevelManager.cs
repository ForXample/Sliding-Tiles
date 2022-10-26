using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject playerCam;
    public GameObject tileCam;

    public GameObject rm01;
    public GameObject rm02;
    public GameObject rm03;
    public GameObject rm04;
    public GameObject rm05;
    public GameObject rm06;
    public GameObject rm07;
    public GameObject rm08;
    public GameObject rm09;

    public bool rm01Selected = false;
    public bool rm02Selected = false;
    public bool rm03Selected = false;
    public bool rm04Selected = false;
    public bool rm05Selected = false;
    public bool rm06Selected = false;
    public bool rm07Selected = false;
    public bool rm08Selected = false;
    public bool rm09Selected = false;
    
    public bool isSelected = false;


    void Awake()
    {
        playerCam.SetActive(true);
        tileCam.SetActive(false);
    }

    void Update()
    {
        CheckInput();
        MoveTile();
        CheckOverBoundary();
    }

    void CheckInput()
    {
        //Activate tile slider
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("Tab.");
            playerCam.SetActive(false);
            tileCam.SetActive(true);
        }


        if (Input.GetKeyDown(KeyCode.Keypad1))
        {

            isSelected = true;
            rm01Selected = true;
            rm02Selected = false;
            rm03Selected = false;
            rm04Selected = false;
            rm05Selected = false;
            rm06Selected = false;
            rm07Selected = false;
            rm08Selected = false;
            rm09Selected = false;

            Debug.Log("Room 1 Selected.");
        }

        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            rm01Selected = false;
            rm02Selected = true;
            isSelected = true;
            rm03Selected = false;
            rm04Selected = false;
            rm05Selected = false;
            rm06Selected = false;
            rm07Selected = false;
            rm08Selected = false;
            rm09Selected = false;

            Debug.Log("Room 2 Selected.");
        }

        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            isSelected = true;
            rm01Selected = false;
            rm02Selected = false;
            rm03Selected = true;
            rm04Selected = false;
            rm05Selected = false;
            rm06Selected = false;
            rm07Selected = false;
            rm08Selected = false;
            rm09Selected = false;

            Debug.Log("Room 3 Selected.");
        }

        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            isSelected = true;
            rm01Selected = false;
            rm02Selected = false;
            rm03Selected = false;
            rm04Selected = true;
            rm05Selected = false;
            rm06Selected = false;
            rm07Selected = false;
            rm08Selected = false;
            rm09Selected = false;

            Debug.Log("Room 4 Selected.");
        }

        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            isSelected = true;
            rm01Selected = false;
            rm02Selected = false;
            rm03Selected = false;
            rm04Selected = false;
            rm05Selected = true;
            rm06Selected = false;
            rm07Selected = false;
            rm08Selected = false;
            rm09Selected = false;

            Debug.Log("Room 5 Selected.");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            isSelected = true;
            rm01Selected = false;
            rm02Selected = false;
            rm03Selected = false;
            rm04Selected = false;
            rm05Selected = false;
            rm06Selected = true;
            rm07Selected = false;
            rm08Selected = false;
            rm09Selected = false;

            Debug.Log("Room 6 Selected.");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            isSelected = true;
            rm01Selected = false;
            rm02Selected = false;
            rm03Selected = false;
            rm04Selected = false;
            rm05Selected = false;
            rm06Selected = false;
            rm07Selected = true;
            rm08Selected = false;
            rm09Selected = false;

            Debug.Log("Room 7 Selected.");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            isSelected = true;
            rm01Selected = false;
            rm02Selected = false;
            rm03Selected = false;
            rm04Selected = false;
            rm05Selected = false;
            rm06Selected = false;
            rm07Selected = false;
            rm08Selected = true;
            rm09Selected = false;

            Debug.Log("Room 8 Selected.");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            isSelected = true;
            rm01Selected = false;
            rm02Selected = false;
            rm03Selected = false;
            rm04Selected = false;
            rm05Selected = false;
            rm06Selected = false;
            rm07Selected = false;
            rm08Selected = false;
            rm09Selected = true;

            Debug.Log("Room 9 Selected.");
        }
    }

    void MoveTile()
    {
        if (rm01Selected)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rm01.transform.position = rm01.transform.position + new Vector3(4, 0, 0);
                rm04.transform.position = rm04.transform.position + new Vector3(4, 0, 0);
                rm07.transform.position = rm07.transform.position + new Vector3(4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rm01.transform.position = rm01.transform.position + new Vector3(-4, 0, 0);
                rm04.transform.position = rm04.transform.position + new Vector3(-4, 0, 0);
                rm07.transform.position = rm07.transform.position + new Vector3(-4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rm01.transform.position = rm01.transform.position + new Vector3(0, 0, 4);
                rm02.transform.position = rm02.transform.position + new Vector3(0, 0, 4);
                rm03.transform.position = rm03.transform.position + new Vector3(0, 0, 4);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rm01.transform.position = rm01.transform.position + new Vector3(0, 0, -4);
                rm02.transform.position = rm02.transform.position + new Vector3(0, 0, -4);
                rm03.transform.position = rm03.transform.position + new Vector3(0, 0, -4);
            }
        }

        if (rm02Selected)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rm02.transform.position = rm02.transform.position + new Vector3(4, 0, 0);
                rm05.transform.position = rm05.transform.position + new Vector3(4, 0, 0);
                rm08.transform.position = rm08.transform.position + new Vector3(4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rm02.transform.position = rm02.transform.position + new Vector3(-4, 0, 0);
                rm05.transform.position = rm05.transform.position + new Vector3(-4, 0, 0);
                rm08.transform.position = rm08.transform.position + new Vector3(-4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rm01.transform.position = rm01.transform.position + new Vector3(0, 0, 4);
                rm02.transform.position = rm02.transform.position + new Vector3(0, 0, 4);
                rm03.transform.position = rm03.transform.position + new Vector3(0, 0, 4);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rm01.transform.position = rm01.transform.position + new Vector3(0, 0, -4);
                rm02.transform.position = rm02.transform.position + new Vector3(0, 0, -4);
                rm03.transform.position = rm03.transform.position + new Vector3(0, 0, -4);
            }
        }

        if (rm03Selected)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rm03.transform.position = rm03.transform.position + new Vector3(4, 0, 0);
                rm06.transform.position = rm06.transform.position + new Vector3(4, 0, 0);
                rm09.transform.position = rm09.transform.position + new Vector3(4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rm03.transform.position = rm03.transform.position + new Vector3(-4, 0, 0);
                rm06.transform.position = rm06.transform.position + new Vector3(-4, 0, 0);
                rm09.transform.position = rm09.transform.position + new Vector3(-4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rm01.transform.position = rm01.transform.position + new Vector3(0, 0, 4);
                rm02.transform.position = rm02.transform.position + new Vector3(0, 0, 4);
                rm03.transform.position = rm03.transform.position + new Vector3(0, 0, 4);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rm01.transform.position = rm01.transform.position + new Vector3(0, 0, -4);
                rm02.transform.position = rm02.transform.position + new Vector3(0, 0, -4);
                rm03.transform.position = rm03.transform.position + new Vector3(0, 0, -4);
            }
        }

        if (rm04Selected)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rm01.transform.position += new Vector3(4, 0, 0);
                rm04.transform.position += new Vector3(4, 0, 0);
                rm07.transform.position += new Vector3(4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rm01.transform.position += new Vector3(-4, 0, 0);
                rm04.transform.position += new Vector3(-4, 0, 0);
                rm07.transform.position += new Vector3(-4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rm04.transform.position += new Vector3(0, 0, 4);
                rm05.transform.position += new Vector3(0, 0, 4);
                rm06.transform.position += new Vector3(0, 0, 4);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rm04.transform.position += new Vector3(0, 0, -4);
                rm05.transform.position += new Vector3(0, 0, -4);
                rm06.transform.position += new Vector3(0, 0, -4);
            }
        }

        if (rm05Selected)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rm02.transform.position += new Vector3(4, 0, 0);
                rm05.transform.position += new Vector3(4, 0, 0);
                rm08.transform.position += new Vector3(4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rm02.transform.position += new Vector3(-4, 0, 0);
                rm05.transform.position += new Vector3(-4, 0, 0);
                rm08.transform.position += new Vector3(-4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rm04.transform.position += new Vector3(0, 0, 4);
                rm05.transform.position += new Vector3(0, 0, 4);
                rm06.transform.position += new Vector3(0, 0, 4);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rm04.transform.position += new Vector3(0, 0, -4);
                rm05.transform.position += new Vector3(0, 0, -4);
                rm06.transform.position += new Vector3(0, 0, -4);
            }
        }

        if (rm06Selected)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rm03.transform.position += new Vector3(4, 0, 0);
                rm06.transform.position += new Vector3(4, 0, 0);
                rm09.transform.position += new Vector3(4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rm03.transform.position += new Vector3(-4, 0, 0);
                rm06.transform.position += new Vector3(-4, 0, 0);
                rm09.transform.position += new Vector3(-4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rm04.transform.position += new Vector3(0, 0, 4);
                rm05.transform.position += new Vector3(0, 0, 4);
                rm06.transform.position += new Vector3(0, 0, 4);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rm04.transform.position += new Vector3(0, 0, -4);
                rm05.transform.position += new Vector3(0, 0, -4);
                rm06.transform.position += new Vector3(0, 0, -4);
            }
        }

        if (rm07Selected)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rm01.transform.position += new Vector3(4, 0, 0);
                rm04.transform.position += new Vector3(4, 0, 0);
                rm07.transform.position += new Vector3(4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rm01.transform.position += new Vector3(-4, 0, 0);
                rm04.transform.position += new Vector3(-4, 0, 0);
                rm07.transform.position += new Vector3(-4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rm07.transform.position += new Vector3(0, 0, 4);
                rm08.transform.position += new Vector3(0, 0, 4);
                rm09.transform.position += new Vector3(0, 0, 4);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rm07.transform.position += new Vector3(0, 0, -4);
                rm08.transform.position += new Vector3(0, 0, -4);
                rm09.transform.position += new Vector3(0, 0, -4);
            }
        }

        if (rm08Selected)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rm02.transform.position += new Vector3(4, 0, 0);
                rm05.transform.position += new Vector3(4, 0, 0);
                rm08.transform.position += new Vector3(4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rm02.transform.position += new Vector3(-4, 0, 0);
                rm05.transform.position += new Vector3(-4, 0, 0);
                rm08.transform.position += new Vector3(-4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rm07.transform.position += new Vector3(0, 0, 4);
                rm08.transform.position += new Vector3(0, 0, 4);
                rm09.transform.position += new Vector3(0, 0, 4);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rm07.transform.position += new Vector3(0, 0, -4);
                rm08.transform.position += new Vector3(0, 0, -4);
                rm09.transform.position += new Vector3(0, 0, -4);
            }
        }

        if (rm09Selected)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rm03.transform.position += new Vector3(4, 0, 0);
                rm06.transform.position += new Vector3(4, 0, 0);
                rm09.transform.position += new Vector3(4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rm03.transform.position += new Vector3(-4, 0, 0);
                rm06.transform.position += new Vector3(-4, 0, 0);
                rm09.transform.position += new Vector3(-4, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rm07.transform.position += new Vector3(0, 0, 4);
                rm08.transform.position += new Vector3(0, 0, 4);
                rm09.transform.position += new Vector3(0, 0, 4);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rm07.transform.position += new Vector3(0, 0, -4);
                rm08.transform.position += new Vector3(0, 0, -4);
                rm09.transform.position += new Vector3(0, 0, -4);
            }
        }
    }

    void CheckOverBoundary()
    {
        if (rm01.transform.position.z > 4)
            rm01.transform.position = new Vector3(-4, 0, -4);
        if (rm01.transform.position.z < -4)
            rm01.transform.position = new Vector3(-4, 0, 4);
        if (rm01.transform.position.x > 4)
            rm01.transform.position = new Vector3(-4, 0, 4);
        if (rm01.transform.position.x < -4)
            rm01.transform.position = new Vector3(4, 0, 4);

        if (rm02.transform.position.z > 4)
            rm02.transform.position = new Vector3(-4, 0, -4);
        if (rm02.transform.position.z < -4)
            rm02.transform.position = new Vector3(-4, 0, 4);
        if (rm02.transform.position.x > 4)
            rm02.transform.position = new Vector3(-4, 0, 0);
        if (rm02.transform.position.x < -4)
            rm02.transform.position = new Vector3(4, 0, 0);

        if (rm03.transform.position.z > 4)
            rm03.transform.position = new Vector3(-4, 0, -4);
        if (rm03.transform.position.z < -4)
            rm03.transform.position = new Vector3(-4, 0, 4);
        if (rm03.transform.position.x > 4)
            rm03.transform.position = new Vector3(-4, 0, -4);
        if (rm03.transform.position.x < -4)
            rm03.transform.position = new Vector3(4, 0, -4);

        if (rm04.transform.position.z > 4)
            rm04.transform.position = new Vector3(0, 0, -4);
        if (rm04.transform.position.z < -4)
            rm04.transform.position = new Vector3(0, 0, 4);
        if (rm04.transform.position.x > 4)
            rm04.transform.position = new Vector3(-4, 0, 4);
        if (rm04.transform.position.x < -4)
            rm04.transform.position = new Vector3(4, 0, 4);

        if (rm05.transform.position.z > 4)
            rm05.transform.position = new Vector3(0, 0, -4);
        if (rm05.transform.position.z < -4)
            rm05.transform.position = new Vector3(0, 0, 4);
        if (rm05.transform.position.x > 4)
            rm05.transform.position = new Vector3(-4, 0, 0);
        if (rm05.transform.position.x < -4)
            rm05.transform.position = new Vector3(4, 0, 0);

        if (rm06.transform.position.z > 4)
            rm06.transform.position = new Vector3(0, 0, -4);
        if (rm06.transform.position.z < -4)
            rm06.transform.position = new Vector3(0, 0, 4);
        if (rm06.transform.position.x > 4)
            rm06.transform.position = new Vector3(-4, 0, -4);
        if (rm06.transform.position.x < -4)
            rm06.transform.position = new Vector3(4, 0, -4);

        if (rm07.transform.position.z > 4)
            rm07.transform.position = new Vector3(4, 0, -4);
        if (rm07.transform.position.z < -4)
            rm07.transform.position = new Vector3(4, 0, 4);
        if (rm07.transform.position.x > 4)
            rm07.transform.position = new Vector3(-4, 0, 4);
        if (rm07.transform.position.x < -4)
            rm07.transform.position = new Vector3(4, 0, 4);

        if (rm08.transform.position.z > 4)
            rm08.transform.position = new Vector3(4, 0, -4);
        if (rm08.transform.position.z < -4)
            rm08.transform.position = new Vector3(4, 0, 4);
        if (rm08.transform.position.x > 4)
            rm08.transform.position = new Vector3(-4, 0, 0);
        if (rm08.transform.position.x < -4)
            rm08.transform.position = new Vector3(4, 0, 0);

        if (rm09.transform.position.z > 4)
            rm09.transform.position = new Vector3(4, 0, -4);
        if (rm09.transform.position.z < -4)
            rm09.transform.position = new Vector3(4, 0, 4);
        if (rm09.transform.position.x > 4)
            rm09.transform.position = new Vector3(-4, 0, -4);
        if (rm09.transform.position.x < -4)
            rm09.transform.position = new Vector3(4, 0, -4);
    }

    
}
