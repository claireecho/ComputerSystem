using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalpelScript : MonoBehaviour
{
    public GameObject restPosition;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = restPosition.transform.position;
        transform.rotation = restPosition.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
