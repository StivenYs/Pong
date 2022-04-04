using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ui : MonoBehaviour
{
    [SerializeField]
    private Text TexPuntajeJugador1;
    [SerializeField]
    private Text TexPuntajeJugador2;

    void Update()
    {
        TexPuntajeJugador1.text = "" + GameManager.Instance.PuntajeJugador1;
        TexPuntajeJugador2.text = "" + GameManager.Instance.PuntajeJugador2;


    }

    public void starGameVsIA()
    {
        GameManager.Instance.isBot = true;
        GameManager.isPause = false;
       
    }
    public void VsPlayer()
    {
        GameManager.Instance.isBot = false;
        GameManager.isPause = false;
        
    }
    public void Exit()
    {
        Application.Quit();
    }

}
