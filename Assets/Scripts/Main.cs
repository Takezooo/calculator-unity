using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public static Main Instance;
    public Text newtext;
    private float num1;
    private float num2;
    public float answer;

    private void Awake()
    {
        Instance = this;
    }

    public void equals()
    {
        num1 = float.Parse(Number.Instance?.numOne);
        num2 = float.Parse(Number.Instance?.numTwo);
        switch (Operations.Instance?.chosenOp)
        {
            case 0:
                answer = num1 + num2;
                newtext.text = answer.ToString();
                Number.Instance?.continueOperation();
                break;
            case 1:
                answer = num1 - num2;
                newtext.text = answer.ToString();
                Number.Instance?.continueOperation();
                break;
            case 2:
                answer = num1 * num2;
                newtext.text = answer.ToString();
                Number.Instance?.continueOperation();
                break;
            case 3:
                answer = num1 / num2;
                newtext.text = answer.ToString();
                Number.Instance?.continueOperation();
                break;
            default:
                newtext.text = "Invalid Input!";
                break;
        }
    }

    public void clear()
    {
        newtext.text = "0";
        Number.Instance?.resetNumbers();
        Operations.Instance?.resetOperation();
    }
}
