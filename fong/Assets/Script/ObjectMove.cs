using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] private Camera came;
    [SerializeField] private float positionZ;
    [SerializeField] private float Radius;

    




    private void OnDrawGizmos()
    {
        
        

        Vector3[] positions = {

            new Vector3(Screen.width,0,positionZ),
            new Vector3(Screen.width, Screen.height, positionZ),
            new Vector3(0,Screen.height,positionZ),
            new Vector3(0,0,positionZ),       
            
            
            

        };

        for (int i = 0; i < positions.Length; i++)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(came.ScreenToWorldPoint(positions[i]),Radius);


            Gizmos.color = Color.blue;

            if (i > 0)
            {
                Gizmos.DrawLine(came.ScreenToWorldPoint(positions[i]), came.ScreenToWorldPoint(positions[i - 1]));
            }
            else
            {
                Gizmos.DrawLine(came.ScreenToWorldPoint(positions[i]), came.ScreenToWorldPoint(positions[positions.Length - 1]));
            }
        }

        
        
            
            
            
        


    }
  
}
