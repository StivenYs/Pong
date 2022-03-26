using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    
    public Camera came;


    [HideInInspector] public Vector3 ariQui;
    [HideInInspector] public Vector3 ariDere;
    [HideInInspector] public Vector3 AbajIzq;
    [HideInInspector] public Vector3 AbajoDere;

    public float Dis;



    private void Awake()
    {
       /* if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
       */
    }

    private void Update()
    {
        
    }

    void UbicarLimites()
    {
        Vector3 vector1t = new Vector3(0, 0, Dis);
        AbajIzq = came.ScreenToWorldPoint(vector1t);

        Vector3 vector2t = new Vector3(0, Screen.height, Dis);
        ariQui = came.ScreenToWorldPoint(vector2t);

        Vector3 vector3t = new Vector3(Screen.width, 0, Dis);
        AbajoDere = came.ScreenToWorldPoint(vector3t);

        Vector3 vector4t = new Vector3(Screen.width,Screen.height, Dis);
        ariDere = came.ScreenToWorldPoint(vector4t);


    }
    private void OnDrawGizmos()
    {
        UbicarLimites();

        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(AbajIzq,1);

        Gizmos.DrawWireSphere(AbajoDere, 1);
        Gizmos.DrawWireSphere(ariQui, 1);
        Gizmos.DrawWireSphere(ariDere, 1);


    }

}
