using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Button cameraButton;
    public Button exitButton;
    public Button howToButton;
    public Button backButton;

    public CanvasGroup mainGroup;
    public CanvasGroup howToGroup;

    // Start is called before the first frame update
    void Start()
    {
        //bind function to button
        cameraButton.onClick.AddListener(OnCameraButton);
        exitButton.onClick.AddListener(OnExitButton);
        howToButton.onClick.AddListener(OnHowToButton);
        backButton.onClick.AddListener(BackToMain);

        mainGroup.alpha = 1;
        mainGroup.interactable = true;
        howToGroup.alpha = 0;
        howToGroup.interactable = false;
    }

    public void OnHowToButton()
    {
        mainGroup.alpha = 0;
        mainGroup.interactable = false;
        howToGroup.alpha = 1;
        howToGroup.interactable = true;
    }

    public void BackToMain()
    {
        mainGroup.alpha = 1;
        mainGroup.interactable = true;
        howToGroup.alpha = 0;
        howToGroup.interactable = false;
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
