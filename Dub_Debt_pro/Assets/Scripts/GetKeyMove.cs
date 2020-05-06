using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform Transform = this.transform;
        Vector3 pos = Transform.position;
        
        if (Input.GetKey(KeyCode.D))
        {    
            pos.x += 0.05f;
        }
        if (Input.GetKey(KeyCode.A))
        {    
            pos.x -= 0.05f;
        }
        if (Input.GetKey(KeyCode.W))
        {    
            pos.y += 0.05f;
        }
        if (Input.GetKey(KeyCode.S))
        {    
            pos.y -= 0.05f;
        }
        Transform.position = pos;
    }
}
