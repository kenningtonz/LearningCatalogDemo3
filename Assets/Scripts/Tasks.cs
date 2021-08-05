using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasks : MonoBehaviour
{
    public GameObject[] tasksList;

    //The child of a task is the complete strickthrough line


    //Toggles the finished task and the next one
    public void toggleFinishedTask(int taskNum)
    {
       
            tasksList[taskNum].transform.GetChild(0).gameObject.SetActive(false);
      
         

            tasksList[taskNum + 1].SetActive(false);
      
    }



    //finishes the task and shows the next one
    public void finishTask(int taskNum)
    {
        if (taskNum == 0 || tasksList[taskNum - 1].transform.GetChild(0).gameObject.activeSelf)
        {
            tasksList[taskNum].transform.GetChild(0).gameObject.SetActive(true);
            tasksList[taskNum + 1].SetActive(true);
        }
        
    }

  

}
