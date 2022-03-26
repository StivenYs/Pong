using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
   // [SerializeField] private Vector2 m_playerMovement;

    [SerializeField] private float m_playerSpeed;
    Vector2 VectorMovimiento;

    private float Offset;
  

    private void Update()
    {

        Offset = transform.localScale.y / 2f;

        VectorMovimiento.y = Input.GetAxisRaw("Vertical");

        if (transform.position.y + Offset >= GameManager.Instance.ariDere.y && Input.GetAxisRaw("Vertical") > 0)
        {
            VectorMovimiento.y = 0;
        }
        if (transform.position.y - Offset<= GameManager.Instance.AbajIzq.y && Input.GetAxisRaw("Vertical") <0)
        {
            VectorMovimiento.y = 0;
        }


        transform.Translate( new Vector2(0,VectorMovimiento.y * m_playerSpeed * Time.deltaTime));

    }
    
}
