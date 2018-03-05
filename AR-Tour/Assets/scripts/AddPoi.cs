using Mapbox.Unity.Map;
using Mapbox.Unity.Utilities;
using Mapbox.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AddPoi : MonoBehaviour
{
    public AbstractMap Map;
    public string Lat;
    public string Lon;
    public GameObject poiObject;
    public TileManager tile;
    public static Vector3 poiPos;



    void Start()
    {
        Map.OnInitialized += () =>
       
        {

            var llpos = new Vector2d(double.Parse(Lat), double.Parse(Lon));
            var pos = Conversions.GeoToWorldPosition(llpos, Map.CenterMercator, Map.WorldRelativeScale);

            //create a sphere as the POI object
            //   var gg = GameObject.CreatePrimitive(PrimitiveType.Sphere);


            //because of tile size, positions are multipled by a factor of 25
            //also makes it faster to place them
            poiObject.transform.position = new Vector3((float)pos.x * 25, 0, (float)pos.y * 25);
            poiPos = poiObject.transform.position;
          

            //unc finishes last
            //destroy loading screen
            if (poiObject.name.Contains("unc"))
            {
                GameObject loadingScreen = GameObject.Find("LoadingScreen");
                Destroy(loadingScreen);
            }

        };
    }

    IEnumerator load()
    {
        yield return null;
    }
}