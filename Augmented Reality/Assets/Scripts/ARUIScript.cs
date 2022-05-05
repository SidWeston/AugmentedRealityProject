using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ARUIScript : MonoBehaviour
{
    public Button backButton;

    // Start is called before the first frame update
    void Start()
    {
        //bind function to button
        backButton.onClick.AddListener(OnBackButton);
    }

    public void OnBackButton()
    {
        //load back to the menu screen on button pressed
        //assume menu scene will always have the index 0
        SceneManager.LoadScene(0);
    }
}
