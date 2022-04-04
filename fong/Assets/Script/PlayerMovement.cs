using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // [SerializeField] private Vector2 m_playerMovement;

    [SerializeField] private float m_playerSpeed;

    Vector2 VectorMovimiento;

    private float Offset;

    [SerializeField]
    private float DistanceDe; 

    [SerializeField]
    private bool JugadorIzq;

   

    private void Start()
    {
        LugarPo();
    }
    private void Update()
    {
       

    }

    private void LugarPo()
    {
        if (JugadorIzq /*transform.position.x < 0*/)
        {
            transform.position = new Vector3(GameManager.Instance.ariQui.x + DistanceDe, 0, 0);
        }
        else
        {
            transform.position = new Vector3(GameManager.Instance.ariDere.x - DistanceDe, 0,0);
        }
       
    }
    public void MoviJugador( int NuJugador)
    {
        

        
            Offset = transform.localScale.y / 2f;



            VectorMovimiento.y = NuJugador;

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
