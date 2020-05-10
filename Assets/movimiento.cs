using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
	public float movementSpeed = 2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetKey("w")){

    		print("Apretaste W");
    		transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed * 2.5f;

    	}
    	if(Input.GetKey("a")){

    		print("Apretaste A");
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed * 2.5f;

        }
    	if(Input.GetKey("s")){

    		print("Apretaste S");
    		transform.position += transform.TransformDirection(Vector3.back) * Time.deltaTime * movementSpeed * 2.5f;

    	}
    	if(Input.GetKey("d")){

    		print("Apretaste D");
    		transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * movementSpeed * 2.5f;

    	}

        if (Input.GetKey(KeyCode.Space))
        {
            print("Apretaste espacio");

            transform.position += transform.TransformDirection(Vector3.up) * Time.deltaTime * movementSpeed * 2.5f;

        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            print("Apretaste dasd");

            transform.position += transform.TransformDirection(Vector3.down) * Time.deltaTime * movementSpeed * 2.5f;

        }

    }
}
