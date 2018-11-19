using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    [SerializeField]
    private Rigidbody2D playerRigidbody2D;
    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private Text countText;
    [SerializeField]
    private Text winText;

    private int collectableCount = 0;
    void Start()
    {
        collectableCount = 0;
        winText.text = "";
        SetCountText();
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
            collectableCount = collectableCount + 1;
            SetCountText();

        }

    }

    private void SetCountText()
    {
        countText.text = "Count: " + collectableCount.ToString();
        if (collectableCount >= 12)
        {
            winText.text = "You Win!!";

        }
    }
}
