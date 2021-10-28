using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Map;
using Lean;

namespace ControlCamera { 
public class ControlCamara : MonoBehaviour
{
    public GameObject jugador;
    public Vector3 offset;

    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;
    public float cameraSpeed = 10f;

    public bool zoomIn;
    public bool zoomOut;

    private void Awake()
    {
        offset = transform.position - jugador.transform.position;
        transform.position = jugador.transform.position + offset;
    }



    void Update()
    {
        Swipe();


    }


    public void zoomInOut()
    {
            AbstractMap _map = GameObject.FindGameObjectWithTag("Map").GetComponent<AbstractMap>();
            Debug.Log(_map.Zoom);           
            _map.SetZoom(_map.Zoom + 0.5f);
            _map.UpdateMap();
           

    }

    public void Swipe()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //save began touch 2d point
            firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            //save ended touch 2d point
            secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            //create vector from the two points
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

            //normalize the 2d vector
            currentSwipe.Normalize();

            //swipe upwards
            if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
            {
                Debug.Log("up swipe");
                transform.Translate(Vector3.down * Time.deltaTime * cameraSpeed);

            }
            //swipe down
            if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
            {
                Debug.Log("down swipe");
                transform.Translate(Vector3.up * Time.deltaTime * cameraSpeed);

            }
            //swipe left
            if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
            {
                Debug.Log("left swipe");
                transform.Translate(Vector3.right * Time.deltaTime * cameraSpeed);

            }
            //swipe right
            if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
            {
                Debug.Log("right swipe");
                transform.Translate(Vector3.left * Time.deltaTime * cameraSpeed);

            }
        }
    }


    //public void zoomIn()
    //{

    //        if (Input.touchCount >= 2)
    //        {
    //            var pos1 = (Input.GetTouch(0).position);
    //            var pos2 = (Input.GetTouch(1).position);
    //            var pos1b = (Input.GetTouch(0).position - Input.GetTouch(0).deltaPosition);
    //            var pos2b = (Input.GetTouch(1).position - Input.GetTouch(1).deltaPosition);

    //            //calc zoom
    //            var zoom = Vector3.Distance(pos1, pos2) /
    //                       Vector3.Distance(pos1b, pos2b);


    //            //edge case
    //            if (zoom == 0 || zoom > 10)
    //                return;

    //            //Move cam amount the mid ray
    //            Camera.transform.position = Vector3.LerpUnclamped(pos1, Camera.transform.position, 1 / zoom);
    //            //edge case
    //            if (zoom == 0 || zoom > 10)
    //            return;

    //        }
    //}
}
}