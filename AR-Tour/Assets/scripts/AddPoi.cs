using Mapbox.Unity.Map;
using Mapbox.Unity.Utilities;
using Mapbox.Utils;
using System.Collections.Generic;
using UnityEngine;

public class AddPoi : MonoBehaviour
{
    public AbstractMap Map;
    public string Lat;
    public string Lon;

    void Start()
    {
        Map.OnInitialized += () =>
        {
                
                var llpos = new Vector2d(double.Parse(Lat), double.Parse(Lon));
                var pos = Conversions.GeoToWorldPosition(llpos, Map.CenterMercator, Map.WorldRelativeScale);
                var gg = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            //because of tile size, positions are multipled by a factor of 25
            //also makes it faster to place them
                gg.transform.position = new Vector3((float)pos.x*25, 0, (float)pos.y*25);
            
        };
    }
}