using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public Pelota pelota;


    [SerializeField] private float m_playerSpeed;

    Vector2 VectorMovimiento;

    private float Offset;

    
    



    void Start()
    {
        
    }

    
    void Update()
    {

        if (GameManager.isPause)
        {
            return;
        }

        MoveBoot();

    }

   
    private void MoveBoot()
    {
        if (GameManager.Instance.isBot)
        {
            if (GameManager.Instance.Pelota.transform.position.x >= 0)
            {
                Offset = transform.localScale.y / 2f;

                VectorMovimiento.y = pelota.MoveY;

                if (transform.position.y + Offset >= GameManager.Instance.ariDere.y && VectorMovimiento.y > 0)
                {
                    VectorMovimiento.y = 0;
                }
                if (transform.position.y - Offset <= GameManager.Instance.AbajIzq.y && VectorMovimiento.y < 0)
                {
                    VectorMovimiento.y = 0;
                }

                transform.Translate(new Vector2(0, VectorMovimiento.y * m_playerSpeed * Time.deltaTime));
            }
        }
        
       
       
    }

}
