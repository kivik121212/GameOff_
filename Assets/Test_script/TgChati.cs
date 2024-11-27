using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TgChati : MonoBehaviour
{
    public GameObject chat1;
    public GameObject chat2;
    public GameObject chat3;
    public GameObject chat4;
    public GameObject chat5;
    //public AudioSource zvuk;

    void Start()
    {
        chat1.SetActive(true);
        chat2.SetActive(false);
        chat3.SetActive(false);
        chat4.SetActive(false);
        chat5.SetActive(false);
    }

    public void Chatik1()
    {
        //zvuk.Play();
        chat1.SetActive(true);
        chat2.SetActive(false);
        chat3.SetActive(false);
        chat4.SetActive(false);
        chat5.SetActive(false);
    }

    public void Chatik2()
    {
        //zvuk.Play();
        chat2.SetActive(true);
        chat1.SetActive(false);
        chat3.SetActive(false);
        chat4.SetActive(false);
        chat5.SetActive(false);
    }

    public void Chatik3()
    {
        //zvuk.Play();
        chat3.SetActive(true);
        chat2.SetActive(false);
        chat1.SetActive(false);
        chat4.SetActive(false);
        chat5.SetActive(false);
    }

    public void Chatik4()
    {
        //zvuk.Play();
        chat4.SetActive(true);
        chat2.SetActive(false);
        chat3.SetActive(false);
        chat1.SetActive(false);
        chat5.SetActive(false);
    }

    public void Chatik5()
    {
        //zvuk.Play();
        chat5.SetActive(true);
        chat2.SetActive(false);
        chat3.SetActive(false);
        chat4.SetActive(false);
        chat1.SetActive(false);
    }
}
