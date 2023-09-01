using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroi : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f; // velocidade de movimento
    public GameObject vida1, vida2, vida3;
    public int vida;


    private void Awake()
    {
        vida = 3;
    }
    void Update()
    {
        // Movimenta��o horizontal
        float horizontal = Input.GetAxisRaw("Horizontal"); // retorna -1 se a seta esquerda ou A forem pressionados, 1 se a seta direita ou D forem pressionados, 0 caso contr�rio
        Vector2 position = transform.position; // posi��o atual do personagem
        position.x += horizontal * speed * Time.deltaTime; // move o personagem horizontalmente

        // Movimenta��o vertical
        float vertical = Input.GetAxisRaw("Vertical"); // retorna -1 se a seta para baixo ou S forem pressionados, 1 se a seta para cima ou W forem pressionados, 0 caso contr�rio
        position.y += vertical * speed * Time.deltaTime; // move o personagem verticalmente

        transform.position = position; // atualiza a posi��o do personagem


        if(vida == 2)
        {
            vida3.SetActive(false);
        }
        if(vida == 1)
        {
            vida2.SetActive(false);
        }
        if(vida == 0)
        {
            vida1.SetActive(false);

        }
            

        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bala"))
        {
            vida--;
            
        }
    }

}
