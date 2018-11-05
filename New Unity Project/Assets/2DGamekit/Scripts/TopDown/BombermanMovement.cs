using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombermanMovement : MonoBehaviour {
    public float maxSpeed = 10;
    private Rigidbody2D rb;
    private Animator animator;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
	}

    private void FixedUpdate() {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * maxSpeed, Input.GetAxis("Vertical") * maxSpeed);
        Animate();
    }

    public void Animate() {
        animator.SetBool("moving", (rb.velocity.x != 0 || rb.velocity.y != 0));
    }
}
