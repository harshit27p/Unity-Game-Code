using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        //Debug.Log("Bumped into a wall");
        if(other.gameObject.tag == "Player")
        {
        GetComponent<MeshRenderer>().material.color = Color.gray;
        gameObject.tag = "Hit";
        }
    }
}

