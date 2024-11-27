using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GovorimSGirl : MonoBehaviour
{
    public GameObject voprosmade, voproslove, made, love, girrrrl;
    public GameObject Primo, trichet;
    public bool IsPrimo, IsTric;

    void Start()
    {
        voproslove.SetActive(false);
        made.SetActive(false);
        voprosmade.SetActive(false);
        love.SetActive(false);
    }

    void Update()
    {
        IsPrimo = Primo.activeInHierarchy;
        IsTric = trichet.activeInHierarchy;
        if (IsPrimo || IsTric)
        {
            girrrrl.SetActive(false);
        }
        else
        {
            girrrrl.SetActive(true);
        }
    }

    public void ClickGirl()
    {
        if(love.activeInHierarchy || made.activeInHierarchy)
        {

        }
        else
        {
            voproslove.SetActive(true);
            voprosmade.SetActive(true);
        }

    }

    public void ClickLove()
    {
        love.SetActive(true);
        voproslove.SetActive(false);
        made.SetActive(false);
        voprosmade.SetActive(false);
        girrrrl.GetComponent<Animator>().Play("sss_sprosil");
        StartCoroutine(Govorit());
    }

    public void ClickMade()
    {
        made.SetActive(true);
        voproslove.SetActive(false);
        love.SetActive(false);
        voprosmade.SetActive(false);
        girrrrl.GetComponent<Animator>().Play("sss_sprosil");
        StartCoroutine(Govorit());
    }

    IEnumerator Govorit()
    {
        yield return new WaitForSeconds(13);
        girrrrl.GetComponent<Animator>().Play("sss");
        made.SetActive(false);
        love.SetActive(false);
    }

}
