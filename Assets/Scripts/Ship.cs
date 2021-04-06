using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    [SerializeField]
    GameObject fire;

    [SerializeField]
    Transform nozzle; 

    [SerializeField]
    float velocidade = 5f;

    [SerializeField]
    private int vida;

    float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        minX = Camera.main.ViewportToWorldPoint(Vector2.zero).x + 0.5f;
        maxX = Camera.main.ViewportToWorldPoint(Vector2.one).x - 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(fire, nozzle.position, nozzle.rotation);
        }

        MoveShip();

    }

    void MoveShip()
    {
        float hMov = Input.GetAxis("Horizontal");

        transform.position += hMov * velocidade * Vector3.right * Time.deltaTime;

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, minX, maxX);
        transform.position = position;
    }

public void LevarDano(int quantidade)
    {
        vida -= quantidade;
        if(vida <= 0)
        {
            Morrer();
        }
    }
 private void Morrer()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("Jogo");
    }
}
