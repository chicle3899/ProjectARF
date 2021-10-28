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


    public void Start()
    {
        botonatras.SetActive(false);
        instrucciones.SetActive(false);
        botonok.SetActive(false);
        
    }

    public void clickButton1()
    {
        Screen.orientation = ScreenOrientation.AutoRotation;
        //SceneManager.LoadScene("Informacion");
            botonatras.SetActive(true);
            menuobject.SetActive(false);

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
    }


    public void mostrarinstrucciones()
    {
        menuobject.SetActive(false);
        botoninstrucciones.SetActive(false);
        instrucciones.SetActive(true);
        botonok.SetActive(true);
        

    }

    public void esconderinstrucciones()
    {
        menuobject.SetActive(true);
        botoninstrucciones.SetActive(true);
        instrucciones.SetActive(false);
        botonatras.SetActive(false);
        botonok.SetActive(false);

    }

        public void salir()
    {
        Application.Quit();
    }

}