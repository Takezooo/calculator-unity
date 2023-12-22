using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Operations : MonoBehaviour
{
    public static Operations Instance;
    public string operation;
    public Text newtext;

    public bool selectedOp = false;
    public int chosenOp;

    private void Awake()
    {
        Instance = this;
    }

    public void Add()
    {
        chosenOp = 0;
        selectedOp = true;
        newtext.text = "0";
    }

    public void Subtract()
    {
        chosenOp = 1;
        selectedOp = true;
        newtext.text = "0";
    }
    public void Multiply()
    {
        chosenOp = 2;
        selectedOp = true;
        newtext.text = "0";
    }
    public void Divide()
    {
        chosenOp = 3;
        selectedOp = true;
        newtext.text = "0";
    }

    public void resetOperation()
    {
        selectedOp = false;
    }

}
