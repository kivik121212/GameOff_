using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartCatscene : MonoBehaviour
{
    // если активен подложка для теста то начинается набивание  на 0.5 секунды появляется диалог из 2 сообщений и выскакивает приложение плюс анимация их
    public GameObject dialog;

    public string[] message;
    private int index = 0;
    public int numberdialog = 0;
    private float speedtext = 0.1f;
    public float wait_time;
    public float start_time;
    public TextMeshProUGUI textDialog;
    private string fullText;
    private bool wait;

    public bool IsActive;

    public string scenename;

   

    void Start()
    {
        dialog.SetActive(false);
        wait = true;
        StartCoroutine(wstart());
        StartCoroutine(dia());

        IEnumerator dia()
        {
            yield return new WaitForSeconds(4);
            dialog.SetActive(true);
            dialogue();
        }

        IEnumerator wstart()
        {
            yield return new WaitForSeconds(start_time);
            SceneManager.LoadScene(scenename);
        }
    }

    public void dialogue()
    {
        if (wait == true)
        {
            textDialog.text = "";
            index = 0;
            wait = false;
            StartCoroutine(TextPechataetsi());
        }

        IEnumerator TextPechataetsi()
        {
            fullText = message[numberdialog];
            numberdialog++;
            wait = false;


            while (index < fullText.Length - 1)
            {
                textDialog.text += fullText[index];
                index++;
                yield return new WaitForSeconds(speedtext);
            }

            if (index == fullText.Length)
            {
                wait = true;

                StartCoroutine(waitik());
                IEnumerator waitik()
                {
                    yield return new WaitForSeconds(wait_time);
                    dialogue();

                }

            }


        }
    }

}
