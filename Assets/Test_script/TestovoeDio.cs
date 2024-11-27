using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestovoeDio : MonoBehaviour
{
    public TextMeshProUGUI textDialog;
    private string fullText = "This is the full text that will gradually appear.";
    private int index = 0;
    public float letterDelay = 0.1f;

    public void OnClick()
    {
        StartCoroutine(ShowTextGradually());
    }

    IEnumerator ShowTextGradually()
    {
        while (index < fullText.Length)
        {
            textDialog.text += fullText[index];
            index++;
            yield return new WaitForSeconds(letterDelay);
        }
    }
}
