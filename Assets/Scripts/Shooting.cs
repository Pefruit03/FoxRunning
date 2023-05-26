using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float speed;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * transform.localScale.x * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            return;

        if (collision.GetComponent<ShootingAction>())
            collision.GetComponent<ShootingAction>().Action();

        Destroy(gameObject);
    }
}
