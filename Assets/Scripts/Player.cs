using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] Vector3 axis;
    [SerializeField] float gravity = -9f;
    [SerializeField] float force = 5f;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        axis.y += gravity * Time.deltaTime;
        transform.position += axis * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){

            axis = Vector2.up * force;

        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        
        if(collision.CompareTag("Obstacles")){
            gameManager.GameOver();
        }

        if(collision.CompareTag("Scoring")){
            gameManager.Scoring();
        }
    }
}
