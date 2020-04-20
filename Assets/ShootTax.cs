using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTax : MonoBehaviour
{
    public Transform point;

    public GameObject Tax;

    public float force = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject taxShot = Instantiate(Tax, point.position, point.rotation);
        Rigidbody2D rb = taxShot.GetComponent<Rigidbody2D>();
        rb.AddForce(point.up * force, ForceMode2D.Impulse);
    }
}
