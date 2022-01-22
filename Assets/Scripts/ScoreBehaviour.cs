using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider coll)
        {
            // First check if we collided with the player 
            if (coll.gameObject.GetComponent<PlayerBehaviour>())
            {
                GameController.instance.AddToScore(5);
            }
        }
}
