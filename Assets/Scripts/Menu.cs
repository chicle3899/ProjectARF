using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{

    public GameObject menuobject;
    public GameObject botonatras;
    public GameObject botonsalir;
    public GameObject instrucciones;
    public GameObject botoninstrucciones;
    public GameObject botonok;
    public GameObject sobrelproyecto;
    public GameObject quierohacerun;


    public void Start()
    {
        botonatras.SetActive(false);
        instrucciones.SetActive(false);
        botonok.SetActive(false);
        sobrelproyecto.SetActive(false);
        quierohacerun.SetActive(false);

    }

    public void clickButton1()
    {
        Screen.orientation = ScreenOrientation.AutoRotation;
        //SceneManager.LoadScene("Informacion");
        botonatras.SetActive(true);
        menuobject.SetActive(false);
        sobrelproyecto.SetActive(true);
        botonsalir.SetActive(true);
        quierohacerun.SetActive(true);


    }

    public void clickButton2()
    {
        Screen.orientation = ScreenOrientation.AutoRotation;
        SceneManager.LoadScene("Mapa");
    }

    public void clickButton3()
    {
        menuobject.SetActive(true);
        botonatras.SetActive(false);
        sobrelproyecto.SetActive(false);
        quierohacerun.SetActive(false);
    }

    public void clickButton4()
    {
        Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLScfm67ndq51bKaiw9pBQ-Y57f6v5DP3lif7vXd06dQlRcxrkQ/viewform");
        Debug.Log("is this working?");
    }


    public void mostrarinstrucciones()
    {
        menuobject.SetActive(false);
        botoninstrucciones.SetActive(false);
        instrucciones.SetActive(true);
        botonok.SetActive(true);
        sobrelproyecto.SetActive(false);
        quierohacerun.SetActive(false);


    }

    public void esconderinstrucciones()
    {
        menuobject.SetActive(true);
        botoninstrucciones.SetActive(true);
        instrucciones.SetActive(false);
        botonatras.SetActive(false);
        botonok.SetActive(false);
        sobrelproyecto.SetActive(false);
        quierohacerun.SetActive(false);

    }



    public void salir()
    {
        Application.Quit();
    }

}