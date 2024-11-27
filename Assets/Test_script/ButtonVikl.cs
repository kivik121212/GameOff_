using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonVikl : MonoBehaviour
{
    public GameObject vikluch;
    //public AudioSource zvuk;
    public GameObject palochka;

    public void Vikluchil()
    {
        //zvuk.Play();
        vikluch.SetActive(false);
        palochka.SetActive(false);
    }
}
