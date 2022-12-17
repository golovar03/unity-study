using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField firstNumber;
    public InputField secondNumber;
    public InputField totalNumber;
    public Text OperationText;

    private void Start()
    {
        firstNumber.text = "0";
        secondNumber.text = "0";
    }
    public void SumTwoNumbers()
    {
        totalNumber.text = Convert.ToString(int.Parse(firstNumber.text) + int.Parse(secondNumber.text));
        OperationText.text = "+";
    }

    public void CalculateDifferenceOfNumbers()
    {
        totalNumber.text = Convert.ToString(int.Parse(firstNumber.text) - int.Parse(secondNumber.text));
        OperationText.text = "-";
    }

    public void MultiplyTwoNumbers()
    {
        totalNumber.text = Convert.ToString(int.Parse(firstNumber.text) * int.Parse(secondNumber.text));
        OperationText.text = "*";
    }

    public void CalculateDivision()
    {
        if (float.Parse(secondNumber.text) != 0)
        {
            totalNumber.text = Convert.ToString(float.Parse(firstNumber.text) / float.Parse(secondNumber.text));
            OperationText.text = "/";
        }
        else totalNumber.text = "На ноль делать нельзя!";
    }
}
