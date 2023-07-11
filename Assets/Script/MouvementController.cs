using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementController : MonoBehaviour
{
    public float actualSpeed = 0.5f;

    private float yaw;

    private float yawAmount = 120;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //delta time enables 
        transform.position += transform.forward * actualSpeed * Time.deltaTime;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        yaw += horizontalInput * yawAmount * Time.deltaTime;
        float pitch = Mathf.Lerp(0, 20, Mathf.Abs(verticalInput))*Mathf.Sign(verticalInput);
        
        transform.localRotation = Quaternion.Euler(Vector3.up * yaw + Vector3.right*pitch);

    }
}
