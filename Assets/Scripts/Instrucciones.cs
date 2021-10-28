using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Instrucciones : MonoBehaviour
{

    public GameObject instrucciones;
    public GameObject botoninstrucciones;
    public GameObject botonatras;
    public GameObject botonsalida;
    // Start is called before the first frame update
    void Start()
    {
        instrucciones.SetActive(false);
        botonatras.SetActive(false);
        
    }

    public void mostrarinstrucciones()
    {
        botoninstrucciones.SetActive(false);
        instrucciones.SetActive(true);
        botonatras.SetActive(true);


    }

    public void esconderinstrucciones()
    {
        botoninstrucciones.SetActive(true);
        instrucciones.SetActive(false);
        botonatras.SetActive(false);

    }

    public void salir()
    {
        SceneManager.LoadScene("Menu");
    }
}
