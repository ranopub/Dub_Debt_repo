using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
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

        if(pos.x > 5 )
        {
            pos.x = 5;
        }
        if(pos.x < -5 )
        {
            pos.x = -5;
        }
        if(pos.y > 5 )
        {
            pos.y = 5;
        }
        if(pos.y < -5 )
        {
            pos.y = -5;
        }

        Transform.position = pos;
    }
}
