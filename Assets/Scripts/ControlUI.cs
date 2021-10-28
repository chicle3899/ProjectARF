using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControlUI : MonoBehaviour
{

    public GameObject instrucciones;
    public GameObject botoninstrucciones;
    public GameObject botonatras;
    public GameObject botonsalida;
    public GameObject botoncamara;

    // Start is called before the first frame update
    void Start()
    {
        instrucciones.SetActive(false);
        botonatras.SetActive(false);
        botoncamara.SetActive(true);
    }

    public void mostrarinstrucciones()
    {
        botoninstrucciones.SetActive(false);
        instrucciones.SetActive(true);
        botonatras.SetActive(true);
        botoncamara.SetActive(false);
       
    }

    public void esconderinstrucciones()
    {
        botoninstrucciones.SetActive(true);
        instrucciones.SetActive(false);
        botonatras.SetActive(false);
        botoncamara.SetActive(true);
    }

    public void memorialprueba()
    {
        SceneManager.LoadScene("Prueba");
    }

    public void salir()
    {
        SceneManager.LoadScene("Menu");
    }

  }