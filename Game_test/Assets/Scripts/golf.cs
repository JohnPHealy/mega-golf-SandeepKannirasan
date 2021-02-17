using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golf : MonoBehaviour
{
    float xRot, yRot = 0f;
    public Rigidbody ball;
    public float rotationspeed = 2f;
    public float shootPower = 5f;
    public float zforce = 0;
    public LineRenderer line;



    // Start is called before the first frame update
    void Update ()
    {
        transform.position = ball.position;
        if (Input.GetMouseButton(0))
        {
            xRot += Input.GetAxis("Mouse X") * rotationspeed;
            yRot += Input.GetAxis("Mouse Y") * rotationspeed;
            if (yRot < -35f)
            {
                yRot = -35f;
            }
            transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
            line.gameObject.SetActive(true);
            line.transform.position = ball.position;
            //line.SetPosition(1, transform.position + transform.forward);


        }




        if (Input.GetMouseButtonUp(0))
        {
            ball.velocity = transform.forward * shootPower;
            line.gameObject.SetActive(false);
            
        }
    }


}
