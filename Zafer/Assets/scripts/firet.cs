using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class firet : MonoBehaviour
{
    

   RaycastHit hit;
    
    void Update()
    {
      if (Input.GetMouseButton(0))
      {     
            if(Physics.Raycast(Camera.main.transform.position,transform.TransformDirection(Vector3.forward),out hit, Mathf.Infinity))
            {
                Debug.DrawRay(Camera.main.transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                if (hit.collider.gameObject.tag == "enemyy" )
                {
                    Destroy(hit.collider.gameObject);
                    
                }
                if (hit.collider.gameObject.tag == "polygon")
                {
                    Destroy(hit.collider.gameObject);

                }
            }
      }
    }
}