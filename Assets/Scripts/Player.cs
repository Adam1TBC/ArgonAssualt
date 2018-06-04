using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    [SerializeField] float xSpeed = 1f;
    [SerializeField] float xRange = 6f;

    [SerializeField] float ySpeed = 1f;
    [SerializeField] float yRange = 4f;
	
	// Update is called once per frame
	void Update () {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = xThrow * xSpeed;
        float rawXPos = transform.localPosition.x + xOffset;


        float yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = yThrow * ySpeed;
        float rawYPos = transform.localPosition.y + yOffset;

        transform.localPosition = new Vector3(
            Mathf.Clamp(rawXPos, -xRange, xRange),
            Mathf.Clamp(rawYPos, -yRange, yRange), 
            transform.localPosition.z
            );
    }
}
