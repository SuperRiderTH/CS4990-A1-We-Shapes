using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    // We want to use this to rotate the camera later.
    public Transform cameraTransform;
    private Rigidbody playerRigidbody;

    // Player Movement Vector
    private Vector3 inputVector;

    public bool playerInControl = true;

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

        // Attempt to get the camera's transform if we don't already have it.
        if (cameraTransform == null)
        {
            Debug.LogWarning("Camera was not assigned, attempting to find it.");

            var _tempObject = GameObject.Find("Main Camera");

            if (_tempObject != null)
            {
                cameraTransform = _tempObject.transform;
                Debug.Log("Camera found and assigned.");
            }
            else
            {
                Debug.LogError("Unable to get the Camera!");
            }            
        }

        playerRigidbody = GetComponent<Rigidbody>();


    }

    void PlayerMovement()
    {
        // If this isn't the controlled object, stop.
        if ( !playerInControl ) { return; }
/*
        // Get the input of the player.
        float _inputH = Input.GetAxis("Horizontal");
        float _inputV = Input.GetAxis("Vertical");

        Vector3 _inputs = new Vector3(_inputH, 0, _inputV);

        // Get the rotation of the camera.
        float _cameraAngle = cameraTransform.eulerAngles.y;

        // Create the final rotation from what we have.
        Vector3 _finalRotation = Quaternion.Euler(0, _cameraAngle, 0) * _inputs;

        // Move the rigidbody.
        playerRigidbody.MovePosition(transform.position + ( _finalRotation * speed * Time.deltaTime ) );

        // NOTE: This will not rotate the player object, this will be replaced later.
        */


        //Another way to do Character Movement that does not take into account the Camera Angle. Might be easier to use - Lin

        inputVector = new Vector3(Input.GetAxis("Horizontal") * speed, playerRigidbody.velocity.y, Input.GetAxis("Vertical") * speed);
        playerRigidbody.velocity = inputVector;


    }

    // Update is called once per frame
    void Update()
    {

        PlayerMovement();

        // TODO: Shape Transformation

    }
}
