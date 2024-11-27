using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStart : MonoBehaviour
{
    public GameObject Dialog_1, Dialog_2, Dialog_3, Dialog_4, Dialog_5;

    public GameObject anim;
    public GameObject anim2;
    public bool proigrala;

    public GameObject activate_obj, activate_obj2, activate_obj3, activate_obj4;

    void Start()
    {
        Dialog_1.SetActive(true);
        Dialog_2.SetActive(false);
        Dialog_3.SetActive(false);
        Dialog_4.SetActive(false);
        Dialog_5.SetActive(false);

        proigrala = false;
        activate_obj.SetActive(false);
        activate_obj2.SetActive(false);
        activate_obj3.SetActive(false);
    }


    void Update()
    {
        if (Dialog_1.activeInHierarchy == false)
        {
            //анимация девочки со сканом приложений
            StartCoroutine(AnimBeforeDialog1());
            IEnumerator AnimBeforeDialog1()
            {
                //anim.GetComponent<Animator>().Play("menushka");
                yield return new WaitForSeconds(1.1f);
                Dialog_2.SetActive(true);
            }
        }

        if (Dialog_2.activeInHierarchy == false)
        {
            StartCoroutine(AnimBeforeDialog2());
            IEnumerator AnimBeforeDialog2()
            {
                // anim.GetComponent<Animator>().Play("menushka");
                activate_obj.SetActive(true);
                yield return new WaitForSeconds(1.1f);
                Dialog_3.SetActive(true);
            }
        }

        if (Dialog_3.activeInHierarchy == false & proigrala == false)
        {
            StartCoroutine(AnimBeforeDialog3());
            IEnumerator AnimBeforeDialog3()
            {
                //anim.GetComponent<Animator>().Play("menushka");
                activate_obj2.SetActive(true);
                yield return new WaitForSeconds(1.1f);
                Dialog_3.SetActive(true);
                proigrala = true;
            }

        }

        if (Dialog_3.activeInHierarchy == false & proigrala == true)
        {
            StartCoroutine(AnimBeforeDialog3_2());
            IEnumerator AnimBeforeDialog3_2()
            {
                //anim2.GetComponent<Animator>().Play("menushka");
                activate_obj3.SetActive(true);
                yield return new WaitForSeconds(1.1f);
                Dialog_4.SetActive(true);
            }
        }

        if (Dialog_4.activeInHierarchy == false)
        {
            StartCoroutine(AnimBeforeDialog1());
            IEnumerator AnimBeforeDialog1()
            {
                //anim.GetComponent<Animator>().Play("menushka");
                yield return new WaitForSeconds(1.1f);
                activate_obj4.SetActive(true);
                Dialog_5.SetActive(true);
            }
        }

        if (Dialog_5.activeInHierarchy == false)
        {
            StartCoroutine(AnimBeforeDialog1());
            IEnumerator AnimBeforeDialog1()
            {
                //anim.GetComponent<Animator>().Play("menushka");
                yield return new WaitForSeconds(1.1f);
                activate_obj4.SetActive(true);
                Dialog_5.SetActive(true);
            }
        }
    }
}
