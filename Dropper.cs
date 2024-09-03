using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Droper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {  //GetComponent<MeshRenderer>().enabled =false;
       renderer= GetComponent<MeshRenderer>();
       rigidbody = GetComponent<Rigidbody>();

       renderer.enabled=false;
       rigidbody.useGravity =false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);
        if(Time.time > timeToWait)
        {
            //Debug.Log("3 Second has elapsed");
            renderer.enabled=true;
       rigidbody.useGravity =true;
        }
    }
}
