using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello there magic cube");
        Debug.Log("how you doing ....");
        Debug.Log("ready for the stage show ?");

        Debug.LogWarning("if you press the space nothing happenes");
        Debug.LogError("if you smash keyboared nothing happese its currently not that active");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            print("up arrow is pressed");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)){
            print("down arrow is pressed");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            print("left arrow is pressed");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)){
            print("right arrow is pressed");
        }
    }
}
