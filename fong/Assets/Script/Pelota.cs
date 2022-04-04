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
        renderBolita.GetComponent<Renderer>();

    }
    void Update()
    {
       



        if (GameManager.isPause)
        {
            return;
        }

        PowerUp();

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
        MoveY = 1;//Random.Range(0.1f, 1);

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
            speed = 15;


        }

        float disX2 = GameManager.Instance.ariQui.x;
        if (transform.position.x < disX2 && moveX < 0)
        {
            // moveX *= -1;

            GameManager.Instance.PuntosJugadores(2);
            nuevoRaud = true;


            moveX = Random.Range(0.1f, 1);
            MoveY = Random.Range(0.1f, 1);
            speed = 15;


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
            speed += 1;
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
        

        if (nuevoRaud)
        {
            if (Tim > GameManager.Instance.Tiempo && nuevoRaud == true)
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

    //variables de el power up solo estaran disponibles Player vs Player

    public Renderer renderBolita;

    float TIn = 0;
    float Tem = 0;
    float isPowe = 0;
    float FalPowe = 0;
    float StarPo = 0;
    private void PowerUp()
    {
        if (GameManager.Instance.PowerUp)
        {
            StarPo = 0;

            if (isPowe > 3)
            {
                renderBolita.enabled = false;

                if (FalPowe > 0.6f)
                {
                    GameManager.Instance.PowerUp = false;
                }
                FalPowe += Time.deltaTime;
            }
            else
            {
               if (TIn > 0.2f)
                {
                    renderBolita.material.color = Color.red;
                    TIn = 0;
                }
                else if (Tem > 0.3)
                {
                    renderBolita.material.color = Color.green;
                    Tem = 0;
                }

                TIn += Time.deltaTime;
                Tem += Time.deltaTime;
                isPowe += Time.deltaTime;

            }
           


        }
        else 
        {    
            Tem = 0;
            TIn = 0;
            renderBolita.enabled = true;
            FalPowe = 0;
            isPowe = 0;


            if (StarPo > 4)
            {
                GameManager.Instance.PowerUp = true;
            }

            StarPo += Time.deltaTime;
        }





    }

}
