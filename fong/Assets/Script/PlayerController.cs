using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement m_playerMovement;

    [SerializeField]
    private bool Player1;

    void Awake()
    {
        m_playerMovement.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isPause)
        {
            return;
        }

        Controlador();
    }
    private void Controlador()
    {
        if (Player1)
        {
            m_playerMovement.MoviJugador((int)Input.GetAxisRaw("Vertical"));
        }
        else
        {
            if (GameManager.Instance.isBot == false)
            {
                m_playerMovement.MoviJugador((int)Input.GetAxisRaw("Vertical2"));
            }
           
        }
    }
}
