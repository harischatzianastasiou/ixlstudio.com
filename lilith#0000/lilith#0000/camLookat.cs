
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camLookat : MonoBehaviour
{
    public Transform player;
    public Transform cameraTrans;
    public float followSpeed = 0.1f; // Adjust this value to control the delay
    public float returnSpeed = 0.05f; // Speed at which the camera returns to its original position
    public Vector3 offset; // Offset to maintain a fixed distance from the player

    private Vector3 initialPosition;
    private bool isPlayerMoving;

    void Start()
    {
        // Store the initial position of the camera
        initialPosition = cameraTrans.position;
        // Calculate the initial offset
        offset = initialPosition - player.position;
    }

    void Update()
    {
        // Check if the player is moving
        isPlayerMoving = player.hasChanged;

        if (isPlayerMoving)
        {
            // Smoothly interpolate the camera's position towards the player's position with the offset
            Vector3 targetPosition = player.position + offset;
            cameraTrans.position = Vector3.Lerp(cameraTrans.position, targetPosition, followSpeed);
        }
        else
        {
            // Smoothly interpolate the camera's position back to its initial position
            cameraTrans.position = Vector3.Lerp(cameraTrans.position, initialPosition, returnSpeed);
        }
    }
}
