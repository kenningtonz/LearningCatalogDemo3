using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour , IPointerEnterHandler
{
    // Start is called before the first frame update
    public GameObject tasks;
    public int task;

    void Start()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tasks.GetComponent<Tasks>().finishTask(task);
      
        
    }


}
