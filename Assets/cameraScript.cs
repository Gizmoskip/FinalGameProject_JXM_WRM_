using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{


     private Vector3 offset;
     // Start is called before the first frame update

     public GameObject MainChar;
     void Start()
    {
          offset = transform.position - MainChar.transform.position;
     }

    // Update is called once per frame
    void Update()
    {
          transform.position = MainChar.transform.position + offset;
     }
}
