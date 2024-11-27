using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonVkl : MonoBehaviour
{
    public GameObject vkl;
    //public AudioSource zvuk;

    void Start()
    {
        vkl.SetActive(false);
    }

    public void Vkluchi()
    {
        //zvuk.Play();
        vkl.SetActive(true);
    }
}
