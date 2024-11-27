using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonwithoutPalka : MonoBehaviour
{
    public GameObject vikluch;
    //public AudioSource zvuk;

    public void Vikluchil()
    {
        //zvuk.Play();
        vikluch.SetActive(false);
    }
}
