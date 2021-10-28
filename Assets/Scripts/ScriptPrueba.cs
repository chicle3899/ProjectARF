using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScriptPrueba : MonoBehaviour
{

    public GameObject volver;
        
    // Start is called before the first frame update
    void Start()
    {
        volver.SetActive(true);
    }

   public void volveratras()
    {
        SceneManager.LoadScene("Mapa");
    }

  }