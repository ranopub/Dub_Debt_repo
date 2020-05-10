using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerSpin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform Transform = this.transform;
        
        
        //if (Input.GetKey(KeyCode.D))
        //{    
        //    pos.x += 0.05f;
        //}
        if (Input.GetKey(KeyCode.A))
        {    
            Transform.Rotate(0,0.05f,0);
        }
        if (Input.GetKey(KeyCode.D))
        {    
            Transform.Rotate(0,-0.05f,0);
        }
        //if (Input.GetKey(KeyCode.S))
        //{    
        //    pos.y -= 0.05f;
        //}
        //Transform.position = pos;
    }
}
