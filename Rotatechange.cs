using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatechange : MonoBehaviour
{
    public Vector3 RotateChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.Rotate(RotateChange);

        
    }

}

