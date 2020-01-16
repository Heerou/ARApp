using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowInstructions : MonoBehaviour
{
    public Image InstructionImg;
    public Button CloseInstructionsBtn;

    private void Start()
    {
        InstructionImg.gameObject.SetActive(false);
        CloseInstructionsBtn.gameObject.SetActive(false);
    }

    public void StartFadeImg()
    {
        InstructionImg.gameObject.SetActive(true);
        CloseInstructionsBtn.gameObject.SetActive(true);
    }

    public void EndFadeImg()
    {
        InstructionImg.gameObject.SetActive(false);
        CloseInstructionsBtn.gameObject.SetActive(false);
    }
}
