using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    
    public float jumpHight = 0;
    public float xspeed = 0;
    public float xspeedSprint = 0;
    public float zspeed = 0;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) && (Input.GetKey(KeyCode.LeftShift)))
        {
            this.transform.Translate(new Vector3(xspeedSprint, 0, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector3(xspeed, 0, 0)* Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(-xspeed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector3(0, 0, zspeed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector3(0, 0, -zspeed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.Translate(new Vector3(0, jumpHight, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector3(xspeed, 0, zspeed) * Time.deltaTime);
        }
    }
}
