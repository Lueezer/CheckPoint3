using UnityEngine;

public class Player2 : MonoBehaviour
{
    private int velocidade = 10;
    void Update()
    {
        if (Input.GetButton("Vertical"))
        {
            float y = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
            transform.Translate(0.0f, y, velocidade * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ParedeCima")
        {
            transform.position = new Vector3(7.42f, 3.67f, 0.0f);
        }

        if (collision.gameObject.tag == "ParedeBaixo")
        {
            transform.position = new Vector3(7.42f, -3.73f, 0.0f);
        }
    }
}
