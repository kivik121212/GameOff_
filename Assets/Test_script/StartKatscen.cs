using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartKatscen : MonoBehaviour
{
    public string scenename;
    public float start_time;
    public AudioSource zvuk;
    public AudioSource zvuk2;

    void Start()
    {
        StartCoroutine(wstart());
        IEnumerator wstart()
        {
            yield return new WaitForSeconds(start_time);
            SceneManager.LoadScene(scenename);
        }

        StartCoroutine(massage());
        IEnumerator massage()
        {
            yield return new WaitForSeconds(0.7f);
            zvuk.Play();
            yield return new WaitForSeconds(4.2f);
            zvuk.Play();
            yield return new WaitForSeconds(0.7f);
            zvuk.Play();
        }

        StartCoroutine(smeh());
        IEnumerator smeh()
        {
            yield return new WaitForSeconds(22.88f);
            zvuk2.Play();

        }
    }
}
