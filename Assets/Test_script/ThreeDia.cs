using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ThreeDia : MonoBehaviour
{
    public AudioSource zvuk;
    public AudioSource zvuk2;
    public GameObject Dialog, testik, Dialognext, DiaSisThis, DiaSis2;
    public GameObject anim;
    public GameObject FonD6;
    public GameObject FonGG;

    public GameObject primo;
    public GameObject trichetiri;

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

    void Start()
    {
        primo.SetActive(true);
        anim.SetActive(false);
        Dialognext.SetActive(false);
        DiaSis2.SetActive(false);

        StartCoroutine(menushka());
        IEnumerator menushka()
        {
            yield return new WaitForSeconds(0.1f);
            testik.SetActive(true);
            yield return new WaitForSeconds(3.5f);
            Dialog.SetActive(true);
            testik.SetActive(false);

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

        FonD6.SetActive(true);
        FonGG.SetActive(true);
        wait = true;

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
        
        IEnumerator MASS()
        {
            yield return new WaitForSeconds(2.15f);
            zvuk2.Play();
            yield return new WaitForSeconds(2f);
            zvuk2.Play();
            yield return new WaitForSeconds(2f);
            zvuk2.Play();
            yield return new WaitForSeconds(2f);
            zvuk2.Play();
            yield return new WaitForSeconds(2f);
            zvuk2.Play();
        }

        if (numberdialog == message.Length)
        {
            Dialog.SetActive(false);
            numberdialog = 0;
            knopka.onClick.RemoveAllListeners();
            primo.SetActive(false);
            trichetiri.SetActive(false);

            StartCoroutine(animat());
            IEnumerator animat()
            {
                anim.SetActive(true);
                StartCoroutine(MASS());
                yield return new WaitForSeconds(13.1f);
                anim.SetActive(false);
                DiaSis2.SetActive(true);
                Dialognext.SetActive(true);
                primo.SetActive(true);
                DiaSisThis.SetActive(false);
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
            primo.GetComponent<Animator>().Play("idle_1");
        }

        if (numberdialog == 3)
        {
            primo.SetActive(false);
            trichetiri.SetActive(true);

            trichetiri.GetComponent<Animator>().Play("di2");
        }

        if (numberdialog == 4)
        {
            trichetiri.GetComponent<Animator>().Play("di3");
        }

        if (numberdialog == 5)
        {
            trichetiri.GetComponent<Animator>().Play("idle_2");
        }
    }
}
