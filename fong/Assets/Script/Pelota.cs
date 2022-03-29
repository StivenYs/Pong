using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public float speed;
    private float  moveX, MoveY;
    float Tim;
    float Predi;

    void Start()
    {
        moveX = Random.Range(0.1f, 1);
        MoveY = Random.Range(0.1f, 1);
        //transform.position += new Vector3(Random.Range())

        Distancia();
    } 
    void Update()
    {
        limitesPelotas();
        

        if (Tim >= Predi)
        {
            return;
        }

        Tim += Time.deltaTime;

        MoverPelota();




    }

    void MoverPelota()
    {
        transform.position += new Vector3(moveX, MoveY) * speed * Time.deltaTime;
    }
    void limitesPelotas()
    {
        float disx1 = GameManager.Instance.ariDere.x;

        if (transform.position.x >= disx1 && moveX > 0)
        {
            moveX *= -1;
        }

        float disX2 = GameManager.Instance.ariQui.x;
        if (transform.position.x < disX2 && moveX < 0)
        {
            moveX *= -1;
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

        Predi = Dis / speed;

        Predi = Mathf.Abs(Predi);





    }
   
}
