using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PressButton : MonoBehaviour
{
    [SerializeField] private Text statusText;
    [SerializeField] private InputField InputField;
    private int secretNumber = 0;

    private void Start()
    {
        secretNumber = UnityEngine.Random.Range(0, 101);
    }

    public void GuesNumber()
    {
        if (InputField.text.Equals(secretNumber.ToString()))
        {
            statusText.text = "�� �������!";
        }
        else if (Convert.ToInt32(InputField.text) < secretNumber)
        {
            statusText.text = "���� ����� ������ �����������. ���������� ��� ���!";
            InputField.text = "";
        }
        else
        {
            statusText.text = "���� ����� ������ �����������. ���������� ��� ���!";
            InputField.text = "";
        }
    }
}
