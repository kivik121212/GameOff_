using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBut : MonoBehaviour
{
    public AudioSource zvuk;

    public void ZvukBut()
    {
        zvuk.Play();
    }
}
