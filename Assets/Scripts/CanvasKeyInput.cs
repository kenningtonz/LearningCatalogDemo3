using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasKeyInput : MonoBehaviour
{

    public List<GameObject> buttons;

    private int selectedbutton = 0;
    public int numberofbuttons;
    private bool firsttab;
    public bool registerpage;
    public List<GameObject> registerbuttons;

    // Start is called before the first frame update
    void Start()
    {
      
        numberofbuttons = buttons.Count - 1;
        if (registerpage)
        {
            numberofbuttons = 1;
            registerbuttons = new List<GameObject>( buttons);
        }
        

    }

    private void OnDisable()
    {
        firsttab = false;
        selectedbutton = 0;

        if (registerpage)
        {
            buttons = new List<GameObject>(registerbuttons);
        }
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.Tab))
        {
            firsttab = true;
        }

        if (firsttab)
        {
            if (buttons[selectedbutton].GetComponent<Toggle>() != null)
            {
                buttons[selectedbutton].GetComponent<Toggle>().Select();
            }
            else
                buttons[selectedbutton].GetComponent<Button>().Select();


            if (Input.GetKeyDown(KeyCode.Tab))
            {
                if (selectedbutton + 1 > numberofbuttons)
                    selectedbutton = 0;
                else
                    selectedbutton++;
            }




            if (Input.GetKey(KeyCode.KeypadEnter))
            {

                if (buttons[selectedbutton].GetComponent<Toggle>() != null)
                {
                    buttons[selectedbutton].GetComponent<Toggle>().isOn = true;
                }
                else
                    buttons[selectedbutton].GetComponent<Button>().onClick.Invoke();

            }


            if (registerpage)
            {
                if (buttons[1].GetComponent<Toggle>() != null)
                {
                    if (!(buttons[1].GetComponent<Toggle>().interactable))
                    {
                        //Debug.Log("toggle is not interactle");
                        buttons.RemoveAt(1);

                    }
                }
            }
        }
    }

}
