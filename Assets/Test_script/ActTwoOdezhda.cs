using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActTwoOdezhda : MonoBehaviour
{
    public GameObject fotbolka, pidzhak, kofta, pizhama, bruki, shorti, lasti, obuv, crossi;
    public static bool fotbolka_B, pidzhak_B, kofta_B, pizhama_B, bruki_B, shorti_B, lasti_B, obuv_B, crossi_B;
    public GameObject Ready_image;
    public Button readyButton;
    public bool readybut;

    // Start is called before the first frame update
    void Start()
    {
        fotbolka.SetActive(false);  
        pidzhak.SetActive(false);   
        kofta.SetActive(false); 
        pizhama.SetActive(false);   
        bruki.SetActive(false);
        shorti.SetActive(false);
        lasti.SetActive(false);
        obuv.SetActive(false);
        crossi.SetActive(false);

        Ready_image.SetActive(false);
        readyButton.interactable = false;
        readybut = false;
    }

    public void fotbolka_v()
    {
        fotbolka.SetActive(true);
        pidzhak.SetActive(false);
        kofta.SetActive(false);

        fotbolka_B = true;
        pidzhak_B = false;
        kofta_B = false;

    }
    public void pidzhak_v()
    {
        fotbolka.SetActive(false);
        pidzhak.SetActive(true);
        kofta.SetActive(false);

        fotbolka_B = false;
        pidzhak_B = true;
        kofta_B = false;
    }
    public void kofta_v()
    {
        fotbolka.SetActive(false);
        pidzhak.SetActive(false);
        kofta.SetActive(true);

        fotbolka_B = false;
        pidzhak_B = false;
        kofta_B = true;
    }
    public void bruki_v()
    {
        pizhama.SetActive(false);
        bruki.SetActive(true);
        shorti.SetActive(false);

        pizhama_B = false;
        bruki_B = true;
        shorti_B = false;
    }
    public void shorti_v()
    {
        pizhama.SetActive(false);
        bruki.SetActive(false);
        shorti.SetActive(true);

        pizhama_B = false;
        bruki_B = false;
        shorti_B = true;
    }
    public void pizhama_v()
    {
        pizhama.SetActive(true);
        bruki.SetActive(false);
        shorti.SetActive(false);

        pizhama_B = true;
        bruki_B = false;
        shorti_B = false;
    }
    public void lasti_v()
    {
        lasti.SetActive(true);
        obuv.SetActive(false);
        crossi.SetActive(false);

        lasti_B = true;
        obuv_B = false;
        crossi_B = false;
    }
    public void obuv_v()
    {
        lasti.SetActive(false);
        obuv.SetActive(true);
        crossi.SetActive(false);

        lasti_B = false;
        obuv_B = true;
        crossi_B = false;
    }
    public void crossi_v()
    {
        lasti.SetActive(false);
        obuv.SetActive(false);
        crossi.SetActive(true);

        lasti_B = false;
        obuv_B = false;
        crossi_B = true;
    }

    public void ready()
    {
        if (crossi_B == true || obuv_B == true || lasti_B == true)
        {
            if (fotbolka_B == true || kofta_B == true || pidzhak_B == true)
            {
                if (pizhama_B == true || bruki_B == true || shorti_B == true)
                {
                    Ready_image.SetActive(true);
                    readyButton.interactable = false;
                    readybut = true;
                }
            }
        }
        
    }

    void Update()
    {
        if (crossi_B == true || obuv_B == true || lasti_B == true)
        {
            if (fotbolka_B == true || kofta_B == true || pidzhak_B == true)
            {
                if (pizhama_B == true || bruki_B == true || shorti_B == true)
                {
                    if(readybut == false)
                    {
                        readyButton.interactable = true;
                    }
                    
                }
            }
        }
    }
}
