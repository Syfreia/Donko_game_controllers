using System.collections;
using System.Collections.Generic;
using UnityEngine;

public class rabbit_controls : MonoBehaviour {

    public int playerSpeed = 10;
    public bool facingRight = true;
    public int playerJumpPower = 1250;
    public float moveX;
    

    // update is called  once per frame

    void update () {

        playerMove();
    }

    void playerMove() {
        // controls
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump")) {
            jump();
        }
        // animations
        // player direction
        if (moveX < 0.0f && facingRight == false) {
            flipPlayer();
        } else if (moveX > 0.0f && facingRight == true) {
            flipPlayer();
        }
        // physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void flipPlayer() {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    
}
    