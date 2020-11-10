using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceTravelled : MonoBehaviour
{

    [SerializeField]
    public GameObject disTravelledText;
    public int disTravelled = 0;

    [SerializeField]
    private Transform checkpoint;

    private float distance;

    [SerializeField]
    private Text distanceText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        distanceText.text = "Distance travelled: " + distance.ToString("F1") + "m";
        distance = (checkpoint.transform.position - transform.position).magnitude;
    }
}
