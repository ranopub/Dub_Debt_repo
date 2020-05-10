using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HitJudge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 SpherePos = this.transform.position;
        Vector3 CubePos = GameObject.Find("Cube").transform.position;
        CriAtomSource audio = (CriAtomSource)GetComponent("CriAtomSource");
        if(Vector3.Distance( SpherePos, CubePos) < 0.75f )
        {
            Debug.Log("!!");
            
            audio.Play();   

            Destroy (this.gameObject, 1.0f);
        }
    }
}
