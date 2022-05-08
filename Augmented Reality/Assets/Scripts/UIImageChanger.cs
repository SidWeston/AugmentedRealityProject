using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIImageChanger : MonoBehaviour
{

    public bool active = false;

    public Button nextImage;
    public Button prevImage;

    //use materials instead of images to make it easier in 3D space for Vuforia
    //get a gameobject as the object to change as that way we can effect an object in the scene
    public GameObject imageToChange;
    public List<Material> imageList;
    private int imageIndex = 0;

    public Text currentIndexUI;

    private void Start()
    {
        //bind buttons to functions
        nextImage.onClick.AddListener(GoNextImage);
        prevImage.onClick.AddListener(GoPrevImage);

        //ensure the image always starts at the first image in the list
        imageToChange.GetComponent<MeshRenderer>().material = imageList[0];
        UpdateIndexUI();
    }

    private void GoNextImage()
    {
        if(active)
        {
            //check if array index is below max value, if above dont change image as there wont be anything to change to
            if (imageIndex < imageList.Count)
            {
                //increment the index before changing
                imageIndex++;
                if (imageList[imageIndex] == null)
                {
                    //if there is no image in that space in the array, re-decrement the index and get an early out
                    imageIndex--;
                    return;
                }
                imageToChange.GetComponent<MeshRenderer>().material = imageList[imageIndex];
                UpdateIndexUI();
            }
        }
    }

    private void GoPrevImage()
    {
        if(active)
        {
            //check if the array is above 0, if not dont change the image as there wont be an image at index -1
            if (imageIndex > 0)
            {
                //decrement the index before changing
                imageIndex--;
                if (imageList[imageIndex] == null)
                {
                    //if there is no image in that space in the array, re-increment the index and get an early out
                    imageIndex++;
                    return;
                }
                imageToChange.GetComponent<MeshRenderer>().material = imageList[imageIndex];
                UpdateIndexUI();
            }
        }
    }

    private void UpdateIndexUI()
    {
        //set some text to show the current image, and how many images there are to view
        currentIndexUI.text = (imageIndex + 1).ToString() + " / " + imageList.Count;
    }

}
