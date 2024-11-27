using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterQr : MonoBehaviour
{
    public GameObject Qr;

    void Start()
    {
        Qr.SetActive(false);
    }

    private void OnMouseEnter()
    {
        Qr.SetActive(true);
    }

    private void OnMouseExit()
    {
        Qr.SetActive(false);
    }
}
