using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public Camera came;


    [HideInInspector] public Vector3 ariQui;
    [HideInInspector] public Vector3 ariDere;
    [HideInInspector] public Vector3 AbajIzq;
    [HideInInspector] public Vector3 AbajoDere;

    public float Dis;

    
    public GameObject Pelota;

    //Direccion Para Donde va la pelota
     
    public int Tiempo = 5;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        UbicarLimites();

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
        //UbicarLimites();

        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(AbajIzq,1);

        Gizmos.DrawWireSphere(AbajoDere, 1);
        Gizmos.DrawWireSphere(ariQui, 1);
        Gizmos.DrawWireSphere(ariDere, 1);


    }


    //Contador de Puntajes de Jugadores

    [HideInInspector]
    public int PuntajeJugador1;
    [HideInInspector]
    public int PuntajeJugador2;


    public void PuntosJugadores(int JugadorQueAnoto)
    {
        if (JugadorQueAnoto == 1)
        {
            PuntajeJugador1 += 1;
            RaroundNext(1);
            
        }
        if (JugadorQueAnoto == 2)
        {
            PuntajeJugador2 += 1;
            RaroundNext(2);
        }
    }

    float dirX = 1;
    private void RaroundNext(int Ganador)
    {
        Pelota.transform.position = new Vector2(0, 0);
        Pelota.GetComponent<Pelota>().moveX *= -1;
   
    }


}
