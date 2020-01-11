using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_script : MonoBehaviour
{
    public GameManager gameManager;
    public float speedMultiplier = 1;
    private Rigidbody2D birdBody;
    // Start is called before the first frame update
    void Start()
    {
        birdBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            birdBody.velocity = Vector2.up * speedMultiplier;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.EndGame();
    }
}
