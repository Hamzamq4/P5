using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCarRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0 * Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}
