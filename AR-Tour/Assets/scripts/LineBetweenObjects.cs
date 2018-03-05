using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBetweenObjects : MonoBehaviour {

    public GameObject start;
    public GameObject mid1;
    public GameObject mid2;
    public GameObject mid3;
    public GameObject mid4;
    public GameObject end;

    void Start()
    {
        var lr = end.AddComponent<LineRenderer>();

        lr.SetPosition(0, start.transform.position);
        lr.SetPosition(1, mid1.transform.position);
        lr.SetPosition(2, mid2.transform.position);
        lr.SetPosition(3, mid3.transform.position);
        lr.SetPosition(4, mid4.transform.position);
        lr.SetPosition(5, end.transform.position);
    }

}
