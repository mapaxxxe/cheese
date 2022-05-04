using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class troncos : MonoBehaviour
{
    public float speed = 5f;
    private float esquina;


    private void Start()
    {
        esquina = Camera.main.ScreenToWorldPoint(Vector3.zero).x -1f;
    }



    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        
        if (transform.position.x < esquina)
        {
            Destroy(gameObject);
        } 
        

        

    }

}
