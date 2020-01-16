using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PhoneCamera : MonoBehaviour
{
    public Button BtnPhoto;

    public Sprite ImgPhoto;

    private Color trasnparent;
    private Color notTrasnparent;

    private void Start()
    {
        trasnparent = new Color(255f, 255f, 255f, 0f);
        notTrasnparent = new Color(255f, 255f, 255f, 255f);
    }

    public void TakeShot()
    {
        BtnPhoto.image.color = trasnparent;
        StartCoroutine("TakePhoto");
    }

    IEnumerator TakePhoto()
    {
        yield return new WaitForEndOfFrame();

        Texture2D screenImage = new Texture2D(Screen.width, Screen.height);
        //Get Image from screen
        screenImage.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        screenImage.Apply();
        //Convert to png
        byte[] imageBytes = screenImage.EncodeToPNG();
        string fileName = "Navidad BuenaVista" + System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".png";

        BtnPhoto.image.color = notTrasnparent;

        //Save image to gallery
        NativeGallery.SaveImageToGallery(imageBytes, "Navidad Buenavista", fileName, null);
    }
}
