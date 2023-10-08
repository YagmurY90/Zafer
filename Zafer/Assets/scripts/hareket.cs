using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    float speed=10;
    float maxspeed=15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"),0, Input.GetAxisRaw("Vertical"));
        Vector3 hýzeklentisi = playerInput * Time.fixedDeltaTime * speed;
        this.GetComponent<Rigidbody>().AddForce(hýzeklentisi);
        this.GetComponent<Rigidbody>().velocity = new Vector3(Mathf.Clamp(this.GetComponent<Rigidbody>().velocity.z, -10, 10), Mathf.Clamp(this.GetComponent<Rigidbody>().velocity.z, -10, 10), Mathf.Clamp(this.GetComponent<Rigidbody>().velocity.z, -10,10));
    }
}
