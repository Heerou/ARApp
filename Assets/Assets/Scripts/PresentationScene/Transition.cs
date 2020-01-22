using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transition : MonoBehaviour
{
    [SerializeField]
    Image imgTransition;
    [SerializeField]
    int duration;
    // Start is called before the first frame update
    void Start()
    {
        imgTransition.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        float counter = 0;
        //Get current color
        Color spriteColor = imgTransition.material.color;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            //Fade from 1 to 0
            float alpha = Mathf.Lerp(1, 0, counter / duration);
            Debug.Log(alpha);

            //Change alpha only
            imgTransition.color = new Color(spriteColor.r, spriteColor.g, spriteColor.b, alpha);
            imgTransition.enabled = false;
            //Wait for a frame
            yield return null;
        }
    }
}
