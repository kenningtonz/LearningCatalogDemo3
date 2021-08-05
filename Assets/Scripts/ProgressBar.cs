using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{

    private int max;
    private int current = 0;
    int temp = 0;
    public Slider fill;
    public GameObject tasks;
    
    // Start is called before the first frame updates
    void Start()
    {
        max = tasks.GetComponent<Tasks>().tasksList.Length;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < max; i++)
        {
            if(tasks.GetComponent<Tasks>().tasksList[i].transform.GetChild(0).gameObject.activeSelf)
            {
                temp++;
            }

        }
       // Debug.Log(temp);
        current = temp;
        temp = 0;
        getcurrentfill();
    }


    void getcurrentfill()
    {
        float fillamount = (float)current / (float)max;
        fill.value = fillamount;
    }
}
