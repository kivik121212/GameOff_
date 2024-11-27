using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class FiveDia : MonoBehaviour
{
    public GameObject animStol, animCamera;
    public string scenename;

    public AudioSource zvuk;

    public GameObject Dialog;
    public GameObject odezhda, tg, vk, testik, diary;
    public GameObject FonD6;
    public GameObject FonGG;

    public GameObject primo;
    public GameObject trichetiri;
    public GameObject Big_girl;

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
    private bool proshlo;

    public void kringe()
    {
        primo.SetActive(true);
        odezhda.SetActive(false);
        Dialog.SetActive(true);
        FonD6.SetActive(true);
        FonGG.SetActive(true);
        wait = true;
        proshlo = false;

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
            primo.GetComponent<Animator>().Play("dia4");
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
            if(numberdialog <= 8)
            {
                zvuk.Play();
            }
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
            SceneManager.LoadScene(scenename);
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

            trichetiri.GetComponent<Animator>().Play("di2");
        }

        if (numberdialog == 4)
        {
            trichetiri.GetComponent<Animator>().Play("idle_3");
        }

        if (numberdialog == 5)
        {
            trichetiri.GetComponent<Animator>().Play("di1");
        }
        if (numberdialog == 6)
        {
            trichetiri.GetComponent<Animator>().Play("di2");
        }
        if (numberdialog == 7)
        {
            trichetiri.GetComponent<Animator>().Play("idle_3");
        }
        if (numberdialog == 8)
        {
            trichetiri.GetComponent<Animator>().Play("di3");
        }

        if (numberdialog == 9)
        {
            odezhda.SetActive(false);
            tg.SetActive(false);
            vk.SetActive(false);
            testik.SetActive(false);
            diary.SetActive(false);

            StartCoroutine(night());
            IEnumerator night()
            {
                if (proshlo == false)
                {
                    proshlo = true;
                    Dialog.SetActive(false);
                    zvuk.Stop();
                    trichetiri.SetActive(false);
                    animStol.GetComponent<Animator>().Play("utro");
                    animCamera.GetComponent<Animator>().Play("new");
                    //trichetiri.GetComponent<Animator>().Play("di1");
                    yield return new WaitForSeconds(6.5f);
                    Big_girl.SetActive(true);
                    Big_girl.GetComponent<Animator>().Play("morning");
                    Dialog.SetActive(true);
                }
                
            }

        }


    }

    public void ready()
    {
        StartCoroutine(rea());
        IEnumerator rea()
        {
            trichetiri.SetActive(true);
            trichetiri.GetComponent<Animator>().Play("smotri");
            yield return new WaitForSeconds(4.23f);
            kringe();
        }
    }

}
