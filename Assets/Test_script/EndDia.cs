using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class EndDia : MonoBehaviour
{
    public AudioSource zvuk;
    public string scenename;
    public float timeendanim;

    public GameObject Dialog, canvasik;
    public GameObject FonD6;
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

    // Start is called before the first frame update
    void Start()
    {
       
        Dialog.SetActive(false);
        wait = true;

        StartCoroutine(animidet());
        IEnumerator animidet()
        {
            yield return new WaitForSeconds(timeendanim);
            canvasik.SetActive(false);
            Dialog.SetActive(true);
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
                trichetiri.GetComponent<Animator>().Play("di3");
            }
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
            SceneManager.LoadScene(scenename);
        }

        if (numberdialog == 2)
        {
            trichetiri.GetComponent<Animator>().Play("di3");
        }

        if (numberdialog == 3)
        {
            trichetiri.GetComponent<Animator>().Play("di1");
        }

        if (numberdialog == 4)
        {
            trichetiri.GetComponent<Animator>().Play("di3");
        }

        if (numberdialog == 5)
        {
            trichetiri.GetComponent<Animator>().Play("di1");
        }
        if (numberdialog == 6)
        {
            trichetiri.GetComponent<Animator>().Play("di1");
        }
        if (numberdialog == 7)
        {
            trichetiri.GetComponent<Animator>().Play("di3");
        }
    }

}
