using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Button cameraButton;
    public Button exitButton;

    // Start is called before the first frame update
    void Start()
    {
        //bind function to button
        cameraButton.onClick.AddListener(OnCameraButton);
        exitButton.onClick.AddListener(OnExitButton);
    }

    public void OnCameraButton()
    {
        //load ar camera scene
        //assume scene will always have index 1 in build settings
        SceneManager.LoadScene(1);
    }

    public void OnExitButton()
    {
        //exit application when button is pressed
        Application.Quit();
    }
}
