using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField]
    private Rigidbody2D playerRigidbody2D;
    [SerializeField]
    private float speed = 1f;
    

	void Update ()
    {
		
	}
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        playerRigidbody2D.AddForce(movement * speed);
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag ("PickUp"))
        {
           
            other.gameObject.SetActive(false);

        }

    }
}
