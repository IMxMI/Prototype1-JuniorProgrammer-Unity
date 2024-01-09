using System.Collections;
using System.Collections.Generic;
using Unity.Editor.Tasks.Logging;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwadInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame.
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwadInput = Input.GetAxis("Vertical");

        //  Le v�hicule avance bas� des des entr�s verticales.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwadInput);
        // Tourne le v�hicule bas� les des entr�s horizontales.
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
