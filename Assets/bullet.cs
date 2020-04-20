using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject self;
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.name == "Grid")
        {
            Destroy(self);
        }

        if (other.gameObject.name == "Rich Oil Guy")
        {
            Destroy(self);
        }
        Destroy(self);

    }

}
