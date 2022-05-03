using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Vector3 direction;
    public float gravedad = -9.8f;
    public float fuerza = 5f;
    private SpriteRenderer spriteRenderer;


    private void Awake()
    {
        
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction = Vector3.up * fuerza;
        }

        direction.y += gravedad * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

}
