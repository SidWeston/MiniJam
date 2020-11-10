using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    public GameObject Character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d")) {
            Character.transform.Translate(Time.deltaTime * -5, 0 , 0);
        }

		if (Input.GetKey("a")) {
            Character.transform.Translate(Time.deltaTime * 5, 0, 0);
		}
    }
}
