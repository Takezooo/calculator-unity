using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    public static Number Instance;
    public string numOne;
    public string numTwo;
    public Text newtext;
    private void Awake()
    {
        Instance = this;
    }

    public void resetNumbers()
    {
        numOne = "";
        numTwo = "";
    }

    public void continueOperation()
    {
        numOne = Main.Instance?.answer.ToString(); 
        numTwo = "";
    }

    public void zero()
    {
        if (Operations.Instance?.selectedOp == false)
        {
            numOne += "0";
            newtext.text = numOne;
        }
        if (Operations.Instance?.selectedOp == true)
        {
            numTwo += "0";
            newtext.text = numTwo;
        }
    }

    public void one()
    {
        if (Operations.Instance?.selectedOp == false)
        {
            numOne += "1";
            newtext.text = numOne;
        }
        if (Operations.Instance?.selectedOp == true)
        {
            numTwo += "1";
            newtext.text = numTwo;
        }
    }

    public void two()
    {
        if (Operations.Instance?.selectedOp == false)
        {
            numOne += "2";
            newtext.text = numOne;
        }
        if (Operations.Instance?.selectedOp == true)
        {
            numTwo += "2";
            newtext.text = numTwo;
        }
    }

    public void three()
    {
        if (Operations.Instance?.selectedOp == false)
        {
            numOne += "3";
            newtext.text = numOne;
        }
        if (Operations.Instance?.selectedOp == true)
        {
            numTwo += "3";
            newtext.text = numTwo;
        }
    }

    public void four()
    {
        if (Operations.Instance?.selectedOp == false)
        {
            numOne += "4";
            newtext.text = numOne;
        }
        if (Operations.Instance?.selectedOp == true)
        {
            numTwo += "4";
            newtext.text = numTwo;
        }
    }
    public void five()
    {
        if (Operations.Instance?.selectedOp == false)
        {
            numOne += "5";
            newtext.text = numOne;
        }
        if (Operations.Instance?.selectedOp == true)
        {
            numTwo += "5";
            newtext.text = numTwo;
        }
    }

    public void six()
    {
        if (Operations.Instance?.selectedOp == false)
        {
            numOne += "6";
            newtext.text = numOne;
        }
        if (Operations.Instance?.selectedOp == true)
        {
            numTwo += "6";
            newtext.text = numTwo;
        }
    }

    public void seven()
    {
        if (Operations.Instance?.selectedOp == false)
        {
            numOne += "7";
            newtext.text = numOne;
        }
        if (Operations.Instance?.selectedOp == true)
        {
            numTwo += "7";
            newtext.text = numTwo;
        }
    }

    public void eight()
    {
        if (Operations.Instance?.selectedOp == false)
        {
            numOne += "8";
            newtext.text = numOne;
        }
        if (Operations.Instance?.selectedOp == true)
        {
            numTwo += "8";
            newtext.text = numTwo;
        }
    }

    public void nine()
    {
        if (Operations.Instance?.selectedOp == false)
        {
            numOne += "9";
            newtext.text = numOne;
        }
        if (Operations.Instance?.selectedOp == true)
        {
            numTwo += "9";
            newtext.text = numTwo;
        }
    }
}
