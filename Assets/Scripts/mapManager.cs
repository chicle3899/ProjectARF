using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Location;
using Mapbox.Utils;
using Mapbox.Unity.Map;



public class mapManager : MonoBehaviour
{
    public GameObject locationMark;
    Location Location = new Location();
    AbstractMap _map= new AbstractMap();




    // Start is called before the first frame update
    void Start()
    {
        Vector2d vector = new Vector2d();
        vector.x = -34.6179;
        vector.y=-58.4333595;

        Location.LatitudeLongitude = vector;
       var vector3 = _map.GeoToWorldPosition(Location.LatitudeLongitude, true);

        Instantiate(locationMark, new Vector3(vector3.x, vector3.y, vector3.z), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {

    }

}
        
    