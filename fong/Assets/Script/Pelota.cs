using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public float speed;

    float Tim;
    float Predi;
    public float moveX, MoveY;

    private bool nuevoRaud;

    void Start()
    {
        nuevoRaud = false;
        RandomInicial();
        Distancia();
    }
    void Update()
    {
        limitesPelotas();


        /* if (Tim >= Predi)
         {
             //return;

         }
        */


        tiempo();
        MoverPelota();

        


    }
    private void RandomInicial()
    {
        moveX = Random.Range(0.1f, 1);
        MoveY = Random.Range(0.1f, 1);

    }

    void MoverPelota()
    {
        if (nuevoRaud == false)
        {
            transform.Translate(new Vector3(moveX, MoveY) * speed * Time.deltaTime);

        }

    }

    void limitesPelotas()
    {


        float disx1 = GameManager.Instance.ariDere.x;

        if (transform.position.x >= disx1 && moveX > 0)
        {
            //moveX *= -1;
            GameManager.Instance.PuntosJugadores(1);
            nuevoRaud = true;
            
            moveX = Random.Range(-1, -1.0f);
            MoveY = Random.Range(0.1f, 1);

            

        }

        float disX2 = GameManager.Instance.ariQui.x;
        if (transform.position.x < disX2 && moveX < 0)
        {
            // moveX *= -1;

            GameManager.Instance.PuntosJugadores(2);
            nuevoRaud = true;
            
            
            moveX = Random.Range(0.1f, 1);
            MoveY = Random.Range(0.1f, 1);

            
        }

        float DisY1 = GameManager.Instance.ariQui.y;
        if (transform.position.y >= DisY1 && MoveY > 0)
        {
            MoveY *= -1;
        }

        float disY2 = GameManager.Instance.AbajoDere.y;
        if (transform.position.y <= disY2 && MoveY < 0)
        {
            MoveY *= -1;
        }



        //tiempo 




    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            moveX *= -1;
        }
    }

    private void Distancia()
    {

        float Dis = transform.position.x - GameManager.Instance.ariDere.x;


        Predi = Dis / (speed * moveX);

        Predi = Mathf.Abs(Predi);





    }
    private void tiempo()
    {
        print(nuevoRaud);

        if (nuevoRaud)
        {
            if (Tim >GameManager.Instance.Tiempo && nuevoRaud == true)
            {
                nuevoRaud = false;               
            }

            Tim += Time.deltaTime;
        }
        else
        {
            Tim = 0;
        }
       
        

    }
    
}
