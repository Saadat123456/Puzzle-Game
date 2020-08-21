using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float MovementSpeed = 1;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        var movementx = Input.GetAxis("Horizontal");
        transform.position = new Vector3(movementx,0,0) * Time.deltaTime * MovementSpeed;

    }

    
}
