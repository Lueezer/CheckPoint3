using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{
    private float velocidade = 10.0f;
    [SerializeField] private string inputName;

    void Update()
    {
        if (Input.GetButton(inputName))
        {
            float y = Input.GetAxisRaw(inputName) * velocidade * Time.deltaTime;
            transform.Translate(0.0f, y, velocidade * Time.deltaTime);
        }
    }
}
