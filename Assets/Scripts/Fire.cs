using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    [SerializeField]
    float force = 100f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        Destroy(gameObject, 10);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ship ship = collision.transform.GetComponent<Ship>();
        if(ship != null)
        {
            ship.LevarDano(1);
            Destroy(gameObject);
        }

    }

}
