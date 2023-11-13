using System.collections;
using System.Collections.Generic;
using UnityEngine;

public class player_health : MonoBehaviour  {
    public int Health = 1;
    public bool isDead = false;

    // Use this for initialization
    void start () {
        Health = 1;
        isDead = false;
    }

    // update is called  once per frame
    void update () {
        if (gameObject.transform.position.y < -7) {
            Debug.Log("Player Has Died");
            isDead = true;
        }

        // Can be used to check if player is dead if it has more than 1 health
        /*if (Health <= 0) {
            isDead = true;
        }*/
    }
    
}