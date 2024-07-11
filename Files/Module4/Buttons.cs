using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Buttons : MonoBehaviour
{

    public TMP_Dropdown dropdown;
    public TMP_Text button;
    public Toggle toggle;

    private bool fullscreen = false;
    private void Start()
    {
        Screen.SetResolution(600, 400, fullscreen);
    }
    // Start is called before the first frame update
    public void ChangeResolution()
    {
        if (dropdown.value == 0) Screen.SetResolution(600, 400, fullscreen);
        if (dropdown.value == 1) Screen.SetResolution(1024, 820, fullscreen);
        if (dropdown.value == 2) Screen.SetResolution(1420, 960, fullscreen);
        if (dropdown.value == 3) Screen.SetResolution(1920, 1080, fullscreen);
    }

    public void ChangeFullScreen()
    {
        if (toggle.isOn)
        {
            Screen.fullScreen = true;
            fullscreen = true;
        }
        else
        {
            Screen.fullScreen = false;
            fullscreen = false;
        }
    }

    public void CloseApplication()
    {
        Application.Quit();
    }
}
