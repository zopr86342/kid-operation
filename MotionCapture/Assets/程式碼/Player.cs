using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Animator robot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.R)){
            robot.SetBool("跑步開關", true);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            robot.SetBool("跑步開關", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            robot.SetTrigger("跳舞觸發");
        }

    }
}
