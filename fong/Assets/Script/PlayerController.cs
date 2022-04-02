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
            m_playerMovement.MoviJugador((int)Input.GetAxisRaw("Vertical2q"));
        }
    }
}
