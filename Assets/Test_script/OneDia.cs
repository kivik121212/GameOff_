using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OneDia : MonoBehaviour
{
    public GameObject Dialog, Dialognext;
    public GameObject FonD6;
    public GameObject FonGG;
    public GameObject primo;
    public GameObject trichetiri;

    public AudioSource zvuk;

    public string[] message;
    private int index = 0;
    public int numberdialog = 0;
    public Button knopka;
    private float speedtext = 0.1f;
    public TextMeshProUGUI textDialog;
    private string fullText;

    private bool wait;
    private int nazhal = 0;

    public int[] WhenGgSpeak;
    public GameObject SistemDia, SistemDia2;

    void Start()
    {
        FonD6.SetActive(true);
        FonGG.SetActive(true);
        wait = true;
        Dialognext.SetActive(false);
        SistemDia2.SetActive(false);

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
            primo.GetComponent<Animator>().Play("dia1");
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
            zvuk.Play();
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

            StartCoroutine(skan());
            IEnumerator skan()
            {
                primo.GetComponent<Animator>().Play("skan");
                yield return new WaitForSeconds(6.4f);
                Dialognext.SetActive(true);
                SistemDia2.SetActive(true);
                SistemDia.SetActive(false);

            }
        }

        if (numberdialog == WhenGgSpeak[0] | numberdialog == WhenGgSpeak[1] | numberdialog == WhenGgSpeak[2])
        {
            FonD6.SetActive(false);
        }
        else
        {
            FonD6.SetActive(true);
        }

        if (numberdialog == 2)
        {
            primo.GetComponent<Animator>().Play("dia2");
        }

        if (numberdialog == 3)
        {
            primo.SetActive(false);
            trichetiri.SetActive(true);

            trichetiri.GetComponent<Animator>().Play("idle_2");
        }

        if (numberdialog == 4)
        {
            trichetiri.GetComponent<Animator>().Play("di1");
        }

        if (numberdialog == 5)
        {
            trichetiri.GetComponent<Animator>().Play("di3");
        }

        if (numberdialog == 6)
        {
            trichetiri.SetActive(false);
            primo.SetActive(true);

            primo.GetComponent<Animator>().Play("dia2");
        }

        if (numberdialog == 7)
        {
            primo.GetComponent<Animator>().Play("idle_1");
        }

        if (numberdialog == 8)
        {
            primo.GetComponent<Animator>().Play("idle_1");
        }

        if (numberdialog == 9)
        {
            primo.GetComponent<Animator>().Play("dia4");
        }
    }
}
