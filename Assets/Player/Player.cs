using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] float speed = 5f;
    Rigidbody2D playerRigidBody;

	// Use this for initialization
	void Start () {
        playerRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float controlThrow = CrossPlatformInputManager.GetAxis("Horizontal"); // value between -1 and +1

        if (CrossPlatformInputManager.GetButton("Horizontal")) // reports every frame
        {
            Vector2 playerVelocity = new Vector2(controlThrow * speed, 0f);
            playerRigidBody.velocity = playerVelocity;
        }
	}
}
