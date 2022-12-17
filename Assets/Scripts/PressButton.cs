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
            statusText.text = "Вы угадали!";
        }
        else if (Convert.ToInt32(InputField.text) < secretNumber)
        {
            statusText.text = "Ваше число меньше загаданного. Попробуйте еще раз!";
            InputField.text = "";
        }
        else
        {
            statusText.text = "Ваше число больше загаданного. Попробуйте еще раз!";
            InputField.text = "";
        }
    }
}
