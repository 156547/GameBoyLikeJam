using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Fields
    CharacterController controller;

    // Mono methods
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();

    }
    void Update()
    {
        HandleInput();
        Debug.Log(transform.position);
    }

    // Methods
    // Get player input
    void HandleInput(){
        // WASD
        if(Input.GetKeyDown("w")){
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        if(Input.GetKeyDown("a")){
            Debug.Log("a");
        }
        if(Input.GetKeyDown("s")){
            Debug.Log("s");
        }
        if(Input.GetKeyDown("d")){
            Debug.Log("d");
        }
    }
    // Move player 
}
