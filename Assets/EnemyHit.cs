using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{

    public GameObject gameOver;

    public GameObject cam;

    public GameObject self;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name == "Main Char")
        {
            GameObject e = Instantiate(gameOver);
            e.transform.position = cam.transform.position;
            FindObjectOfType<GameManager>().EndGame();

            Time.timeScale = 0;
        }

        if (other.gameObject.name == "Tax(Clone)")
        {
            scoreScript.scoreValue += 100;
            Destroy(self);
        }


    }
}
