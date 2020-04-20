using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
     public float speed = 5f;

    public Rigidbody2D rb;
    public Camera cam;
     // Start is called before the first frame update
     void Start()
    {
        Time.timeScale = 1;

    }

    Vector2 mousePos;

     // Update is called once per frame

        
     void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
          {
            Debug.Log("movement");
            transform.position += Vector3.left * speed * Time.deltaTime;
          }
          if (Input.GetKey(KeyCode.UpArrow))
          {
               transform.position += Vector3.up * speed * Time.deltaTime;
          }
          if (Input.GetKey(KeyCode.DownArrow))
          {
               transform.position += Vector3.down * speed * Time.deltaTime;
          }
          if (Input.GetKey(KeyCode.RightArrow))
          {
               transform.position += Vector3.right * speed * Time.deltaTime;
          }

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
     }
    private void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
