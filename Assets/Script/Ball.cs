using System.Timers;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float velocidadex = 10.0f;
    float velocidadey = 5.0f;

    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;
    void Start()
    {
        transform.position = Vector3.zero;
    }

    void Update()
    {

        transform.Translate(velocidadex * Time.deltaTime, velocidadey * Time.deltaTime, 0.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if((collision.collider.tag == "Player1" || collision.collider.tag == "Player2") || 
          (collision.collider.tag =="Parede") || ((collision.collider.tag =="ParedeLateral1") || (collision.collider.tag =="ParedeLateral2")))
        {
            velocidadex = velocidadex * -1;

            if ((collision.collider.tag == "ParedeLateral1") || (collision.collider.tag == "ParedeLateral2"))
            {
                transform.position = Vector2.zero;

                if (collision.collider.tag == "ParedeLateral2")
                {
                    scorePlayer1++;
                }
                else if (collision.collider.tag == "ParedeLateral1")
                {
                    scorePlayer2++;
                }

                if(Random.Range(1, 10) % 2 == 0)
                {
                    velocidadex *= 1;
                }

                if (scorePlayer1 == 5 || scorePlayer2 ==5)
                {
                    transform.position = Vector2.zero;
                    velocidadex = 0;
                    velocidadey = 0;

                    if(scorePlayer1 == 5)
                    {
                        print("PLAYER 1 VENCEU!");
                    }
                    else
                    {
                        print("PLAYER 2 VENCEU!");
                    }

                    print("Fim de Jogo!");
                }
                else
                {
                    transform.position = Vector2.zero;

                    if (Random.Range(1, 10) % 2 == 0)
                    {
                        velocidadex *= 1;
                    }
                }

                    ShowScore();
            }
        }

    }

    void ShowScore()
    {
        print("Score Player 1: " + scorePlayer1);
        print("Score Plauer 2: " + scorePlayer2);
    }
}
