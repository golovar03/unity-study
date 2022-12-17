using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    [SerializeField] private GameObject calculatorScreen;
    [SerializeField] private GameObject compareScreen;

    private GameObject currentScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        calculatorScreen.SetActive(true);
        currentScreen = calculatorScreen;
    }

    public void ChageState(GameObject state)
    {
        if (currentScreen != null)
        {
            currentScreen.SetActive(false);
            state.SetActive(true);
            currentScreen = state;
        }
    }

}
