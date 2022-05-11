using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Vector3 direction;
    public float gravedad = -9.8f;
    public float fuerza = 5f;
    private SpriteRenderer spriteRenderer;
    public AudioSource jump;
    public AudioSource score;
    public AudioSource crash;


    private void Awake()
    {
        
    }

    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0;
        transform.position = position;
        direction = Vector3.zero;
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction = Vector3.up * fuerza;
            jump.Play();
        }

        direction.y += gravedad * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "obstaculo")
        {
            FindObjectOfType<GameManager>().Gameover();
            crash.Play();
        }

        else if(collision.gameObject.tag == "score")
        {
            FindObjectOfType<GameManager>().increasscore();
            score.Play();

        }
    }


}
