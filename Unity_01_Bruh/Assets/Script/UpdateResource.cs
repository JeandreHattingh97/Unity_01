using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateResource : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int resourceTotal = 0;

        GameObject[] resource = GameObject.FindGameObjectsWithTag("Reasource");

        foreach(GameObject o in resource)
        {
            resourceTotal += o.GetComponent<Resource>().numResource;
        }

        Text resourceBox1 = GameObject.Find("ResourceText").GetComponent<Text>();
        resourceBox1.text = "Resources: " + resourceTotal;
    }
}
