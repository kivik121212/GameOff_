using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueFirst : MonoBehaviour
{
    public GameObject Dialog;
    public GameObject FonD6;
    public GameObject FonGG;

    public string[] message;
    public int index = 0;
    public int numberdialog = 0;
    public Button knopka;
    private float speedtext = 0.1f;
    public TextMeshProUGUI textDialog;
    private string fullText;

    public bool wait;
    public int nazhal = 0;

    public int[] WhenGgSpeak;

    void Start()
    {
        FonD6.SetActive(true);
        FonGG.SetActive(true);
        wait = true;

        if (numberdialog == message.Length - 1)
        {
            knopka.gameObject.SetActive(false);
        }
        else
        {
            knopka.gameObject.SetActive(true);
            knopka.onClick.AddListener(NextDialog);
        }

        if (wait == true)
        {
            textDialog.text = "";
            index = 0;
            wait = false;
            StartCoroutine(TextPechataetsi());
        }
    }

    public void NextDialog()
    {

        if (wait == true)
        {
            textDialog.text = "";
            index = 0;
            wait = false;
            StartCoroutine(TextPechataetsi());
        }

    }

    IEnumerator TextPechataetsi()
    {
        fullText = message[numberdialog];
        numberdialog++;
        wait = false;


        while (index < fullText.Length)
        {
            textDialog.text += fullText[index];
            index++;
            yield return new WaitForSeconds(speedtext);  
        }

        if (index == fullText.Length)
        {
            wait = true;
            nazhal = 0;
            speedtext = 0.1f;
        }

        
    }
    public void nazhali()
    {
        nazhal++;
        if (nazhal == 2)
        {
            speedtext = 0;
        }
    }

    void Update()
    {
        if (numberdialog == message.Length)
        {
            Dialog.SetActive(false);
            numberdialog = 0;
            knopka.onClick.RemoveAllListeners();
        }

        if (numberdialog == WhenGgSpeak[0] | numberdialog == WhenGgSpeak[1] | numberdialog == WhenGgSpeak[2])
        {
            FonD6.SetActive(false);
        }
        else
        {
            FonD6.SetActive(true);
        }

    }

}
