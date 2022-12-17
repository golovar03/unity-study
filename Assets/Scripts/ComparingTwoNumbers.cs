using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ComparingTwoNumbers : MonoBehaviour
{

    public InputField firstNumber;
    public InputField secondNumber;
    public Text answer;
    public Text symbol;
   
    public void CompareTwoNumbers()
    {
        if (firstNumber.text != "" && secondNumber.text != "")
        {
            if (float.Parse(firstNumber.text) > float.Parse(secondNumber.text))
            {
                answer.text = $"Первое число {firstNumber.text} больше";
                symbol.text = ">";
            }
            else if (float.Parse(firstNumber.text) < float.Parse(secondNumber.text))
            {
                answer.text = $"Второе число {secondNumber.text} больше";
                symbol.text = "<";
            }
            else
            {
                answer.text = "Числа равны между собой!";
                symbol.text = "=";
            }
        }
        else
        {
            answer.text = "Нельзя сравнивать пустые значения. Пожалуйста, заполните оба поля.";
        }
    }
}
