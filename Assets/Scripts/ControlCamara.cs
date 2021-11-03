using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Map;
using Lean;

public class ControlCamara : MonoBehaviour
{
    public GameObject jugador;

    public float cameraSpeed = 10f;

    public bool zoomIn;
    public bool zoomOut;

    Vector3 touchStart;


    private void Start()
    {
        transform.position = new Vector3(jugador.transform.position.x, 160, jugador.transform.position.z);

    }


    void Update()
    {

            if (Input.GetMouseButtonDown(0))
            {
                touchStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            if (Input.touchCount == 2)
            {
                Touch touchZero = Input.GetTouch(0);
                Touch touchOne = Input.GetTouch(1);

                Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
                Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

                float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
                float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

                float difference = currentMagnitude - prevMagnitude;
            Debug.Log(difference);

                zoom(difference);
            }
            else if (Input.GetMouseButton(0))
            {
                Vector3 direction = touchStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Camera.main.transform.position += direction;
            }
            zoom(Input.GetAxis("Mouse ScrollWheel"));


        Debug.Log(Input.GetAxis("Mouse ScrollWheel"));


        }

    void zoom(float increment)
    {
        if (increment > 0) { 
            AbstractMap _map = GameObject.FindGameObjectWithTag("Map").GetComponent<AbstractMap>();
            Debug.Log(_map.Zoom);           
            _map.SetZoom(_map.Zoom+0.03f);
            _map.UpdateMap();
        }
        else if(increment<0)
        {
            AbstractMap _map = GameObject.FindGameObjectWithTag("Map").GetComponent<AbstractMap>();
            Debug.Log(_map.Zoom);
            _map.SetZoom(_map.Zoom - 0.03f);
            _map.UpdateMap();
        }

    }

}
