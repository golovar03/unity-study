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
                answer.text = $"������ ����� {firstNumber.text} ������";
                symbol.text = ">";
            }
            else if (float.Parse(firstNumber.text) < float.Parse(secondNumber.text))
            {
                answer.text = $"������ ����� {secondNumber.text} ������";
                symbol.text = "<";
            }
            else
            {
                answer.text = "����� ����� ����� �����!";
                symbol.text = "=";
            }
        }
        else
        {
            answer.text = "������ ���������� ������ ��������. ����������, ��������� ��� ����.";
        }
    }
}
