using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickVklAndVikl : MonoBehaviour
{
    public GameObject Vkluchi, nevkluchi;
    public AudioSource zvuk;
    public bool isActive;
    public SpriteRenderer sprite;

    public GameObject palochka;
    public GameObject Dialog_1, Dialog_2, Dialog_3, Dia_sis;
    public bool IsDia;
    public bool IsDia2;
    public bool IsDia3;
    public bool IsDiaSis;
    public bool isActive2;

    void Start()
    {
        Vkluchi.SetActive(false);
        palochka.SetActive(false);
        sprite = GetComponent<SpriteRenderer>();

    }

    
    private void OnMouseDown()
    {
        IsDia = Dialog_1.activeInHierarchy;
        IsDia2 = Dialog_2.activeInHierarchy;
        IsDia3 = Dialog_3.activeInHierarchy;
        IsDiaSis = Dia_sis.activeInHierarchy;

        if (IsDia || IsDia2 || IsDia3 & IsDiaSis)
        {
            
        }
        else
        {
            zvuk.Play();
            isActive = Vkluchi.activeInHierarchy;
            isActive2 = nevkluchi.activeInHierarchy;
            sprite.color = new Color(0.5f, 0.5f, 0.5f, 1);

            if (isActive || isActive2)
            {
                Vkluchi.SetActive(false);
                palochka.SetActive(false);
            }
            else
            {
                Vkluchi.SetActive(true);
                palochka.SetActive(true);
            }
        }
            
    }

    private void OnMouseEnter()
    {
        IsDia = Dialog_1.activeInHierarchy;
        IsDia2 = Dialog_2.activeInHierarchy;
        IsDia3 = Dialog_3.activeInHierarchy;
        IsDiaSis = Dia_sis.activeInHierarchy;

        if (IsDia || IsDia2 || IsDia3 & IsDiaSis)
        {
            
        }
        else
        {
            sprite.color = new Color(0.7f, 0.7f, 0.7f, 1);
        }
            
    }

    private void OnMouseExit()
    {
        sprite.color = new Color(1, 1, 1, 1);
    }

    void Update()
    {
        isActive = Vkluchi.activeInHierarchy;
        isActive2 = nevkluchi.activeInHierarchy;

        if (isActive || isActive2)
        {
            palochka.SetActive(true);
        }
        else
        {
            palochka.SetActive(false);
        }

    }
}
