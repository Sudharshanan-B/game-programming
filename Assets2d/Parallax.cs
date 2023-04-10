using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Parallax : MonoBehaviour {
    public float parallaxSpeed = 0.02f;
    public Transform cameraTransform;
    private Vector3 lastCameraPosition;
    void Start() {
        lastCameraPosition = cameraTransform.position;
    }
    void FixedUpdate() {
        float deltaMovement = cameraTransform.position.x - lastCameraPosition.x;
        Vector3 backgroundPosition = transform.position;
        backgroundPosition.x += deltaMovement * parallaxSpeed;
        transform.position = backgroundPosition;
        if (cameraTransform.position == lastCameraPosition) {
            Vector3 simulatedMovement = new Vector3(parallaxSpeed *
            Time.fixedDeltaTime, 0, 0);
            transform.position -= simulatedMovement;
        }
        lastCameraPosition = cameraTransform.position;
    }
}