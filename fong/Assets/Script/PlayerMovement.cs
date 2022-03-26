using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
   // [SerializeField] private Vector2 m_playerMovement;
    [SerializeField] private float m_playerSpeed;

    private void Update()
    {
        // transform.Translate(m_playerMovement * (m_playerSpeed * Time.deltaTime));

        transform.Translate( new Vector2(0, Input.GetAxis("Vertical") * m_playerSpeed * Time.deltaTime));

        //GameManager.Instance.Var
            

    }
    
}
