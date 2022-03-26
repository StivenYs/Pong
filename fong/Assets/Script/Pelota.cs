using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public float speed;
    private float  moveX, MoveY;

    public GameManager Instance;

    void Start()
    {
        moveX = Random.Range(0.1f, 1);
        MoveY = Random.Range(0.1f, 1);
        //transform.position += new Vector3(Random.Range())
    } 
    void Update()
    {
        MoverPelota();
        limitesPelotas();
    }

    void MoverPelota()
    {
        transform.position += new Vector3(moveX, MoveY) * speed * Time.deltaTime;
    }
    void limitesPelotas()
    {
        float disx1 = Instance.ariDere.x;

        if (transform.position.x >= disx1)
        {
            moveX *= -1;
        }

        float disX2 = Instance.ariQui.x;
        if (transform.position.x < disX2)
        {
            moveX *= -1;
        }

        float DisY1 = Instance.ariQui.y;
        if (transform.position.y >= DisY1)
        {
            MoveY *= -1;
        }

        float disY2 = Instance.AbajoDere.y;
        if (transform.position.y <= disY2)
        {
            MoveY *= -1;
        }


    }
    
}
