using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player1 : MonoBehaviour
{
    private int velocidade = 10;

    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            float y = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
            transform.Translate(0.0f, y, velocidade * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ParedeCima")
        {
            transform.position = new Vector3(-7.77f, 3.67f, 0.0f);
        }

        if (collision.gameObject.tag == "ParedeBaixo")
        {
            transform.position = new Vector3(-7.77f, -3.73f, 0.0f);
        }
    }
}
