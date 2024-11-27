using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonVklVikl : MonoBehaviour
{
    public GameObject Tg;
    public GameObject Vk;
    //public AudioSource zvuk;

    void Start()
    {
        Tg.SetActive(false);
        Vk.SetActive(false);
    }

    public void VkluchilVk()
    {
        //zvuk.Play();
        Tg.SetActive(false);
        Vk.SetActive(true);
    }
    public void VikluchilVk()
    {
        //zvuk.Play();
        Tg.SetActive(true);
        Vk.SetActive(false);
    }

}
