using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercolisions : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Obstacle")
        {
            gameObject.SetActive(false);
            GameMgr.Instance.GameOver();
            Debug.Log("we collided with obsticle");
            // connect this to a game manager and trigger GameOver():
        }
    }
}