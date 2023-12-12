using System.Collections;
using System.Collections.Generic;
using Unity.Editor.Tasks.Logging;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwadInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwadInput = Input.GetAxis("Vertical");

        // Nous allons faire avancer le véhicule.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwadInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
