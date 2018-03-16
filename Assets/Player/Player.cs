using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print(CrossPlatformInputManager.GetAxis("Horizontal"));

        if (CrossPlatformInputManager.GetButton("Horizontal")) // reports every frame
        {
            print("One of the Horizontal inputs pressed");

        }
	}
}
