using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{

  
    public GameObject task;
    //public GameObject inputField;
    //public int[] inputFieldTasks;
    //public string courseNumberString = "3840U";

    private Color32 White = new Color32(255, 255, 255, 255);
    private Color32 Green = new Color32(229, 227, 255, 255);


    //Restarts the Program
    public void restart()
    {
        //Reloads the Scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void selectbutton()
    {

    }

    public void back()
    {

    }

    //Turns off Object (Sets it to inactive)
    public void objectOff(GameObject gameObject)
    {
            gameObject.SetActive(false);
    }


    //Turns on the object, if it is a button then it sets it to interactable
    public void objectOn(GameObject gameObject)
    {
        gameObject.SetActive(true);
        if (gameObject.tag == "Button")
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
    }

    //Toggles the button's interactable
    public void buttonToggle(GameObject gameObject)
    {
        if (!gameObject.GetComponent<Button>().interactable)
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = false;
        }

    }

    //Toggles the button's interactable
    public void toggleOff(GameObject gameObject)
    {
   
            gameObject.GetComponent<Toggle>().interactable = false;


    }

    public void toggleON(GameObject gameObject)
    {

        gameObject.GetComponent<Toggle>().interactable = true;


    }

    //Sets the Objects colour to Green
    public void buttongreen(GameObject button)
    {

        button.GetComponent<Image>().color = Green;

    }


    //Toggles the colour of the button from green and white
    public void toggleButtonColour(GameObject button)
    {
        if (button.GetComponent<Image>().color == White)
        {
            button.GetComponent<Image>().color = Green;
        }
        else
        {
            button.GetComponent<Image>().color = White;
        }
    }

    //Sets the Objects colour to white
    public void buttonwhite(GameObject button)
    {
        button.GetComponent<Image>().color = White;

    }


    //Course number function
    //public void courseNumber(GameObject gameobject)
    //{
    //    //inputField is the input object, inputFieldTasks[0] is the first task, [1] is the second task
    //    //gameobject is button
    //    //if the course number is correct:
    //    if (inputField.GetComponent<InputField>().text.ToUpper() == courseNumberString)
    //    {
    //        //finish the task
    //        task.GetComponent<Tasks>().finishTask(inputFieldTasks[0]);

    //        //set the button to green
    //        buttongreen(gameobject);

    //        //set the input field to white
    //        buttonwhite(inputField);
          
    //        //turn on the button
    //        objectOn(gameobject);
           

    //    }
    //    //if the course number is not correct
    //    else
    //    {
    //        //turn off the button
    //        objectOff(gameobject);
            
    //        //unfinish the task and dont show the next one
    //        task.GetComponent<Tasks>().tasksList[inputFieldTasks[0]].transform.GetChild(0).gameObject.SetActive(false);
    //        task.GetComponent<Tasks>().tasksList[inputFieldTasks[1]].SetActive(false);

    //        //set the inputfield to green
    //        buttongreen(inputField);
    //        //set the button to white
    //        buttonwhite(gameobject);
    //    }
    //}


    //Sets the scroll bar's value to 1
    public void setScrollto1(GameObject scrollBar)
    {
        scrollBar.GetComponent<Scrollbar>().value = 1;
    }

}
