using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCatsSprite : MonoBehaviour
{
    public Image sr_telo;
    public Image sr_nogi;
    public Image sr_obuv;

    public Image sr_telo2;
    public Image sr_nogi2;
    public Image sr_obuv2;

    public Sprite telo1fut, telo2pidz, telo3shcolo, nogi1pizham, nogi2scholo, nogi3shoti, obuv1lasti, obuv2krosi, obuv3skololo;
    public Sprite telo1fut2, telo2pidz2, telo3shcolo2, nogi1pizham2, nogi2scholo2, nogi3shoti2, obuv1lasti2, obuv2krosi2, obuv3skololo2;

    public bool fotbolka_Bn, pidzhak_Bn, kofta_Bn, pizhama_Bn, bruki_Bn, shorti_Bn, lasti_Bn, obuv_Bn, crossi_Bn;

    // Start is called before the first frame update
    void Start()
    {
        fotbolka_Bn = ActTwoOdezhda.fotbolka_B;
        pidzhak_Bn = ActTwoOdezhda.pidzhak_B;
        kofta_Bn = ActTwoOdezhda.kofta_B;
        pizhama_Bn = ActTwoOdezhda.pizhama_B;
        bruki_Bn = ActTwoOdezhda.bruki_B;
        shorti_Bn = ActTwoOdezhda.shorti_B;
        lasti_Bn = ActTwoOdezhda.lasti_B;
        obuv_Bn = ActTwoOdezhda.obuv_B;
        crossi_Bn = ActTwoOdezhda.crossi_B;

        if (fotbolka_Bn == true)
        {
            sr_telo.sprite = telo1fut;
        }

        if (pidzhak_Bn == true)
        {
            sr_telo.sprite = telo2pidz;
        }

        if (kofta_Bn == true)
        {
            sr_telo.sprite = telo3shcolo;
        }

        if (pizhama_Bn == true)
        {
            sr_nogi.sprite = nogi1pizham;
        }

        if (bruki_Bn == true)
        {
            sr_nogi.sprite = nogi2scholo;
        }

        if (shorti_Bn == true)
        {
            sr_nogi.sprite = nogi3shoti;
        }

        if (lasti_Bn == true)
        {
            sr_obuv.sprite = obuv1lasti;
        }

        if (obuv_Bn == true)
        {
            sr_obuv.sprite = obuv3skololo;
        }

        if (crossi_Bn == true)
        {
            sr_obuv.sprite = obuv2krosi;
        }

        // не запутайся

        if (fotbolka_Bn == true)
        {
            sr_telo2.sprite = telo1fut2;
        }

        if (pidzhak_Bn == true)
        {
            sr_telo2.sprite = telo2pidz2;
        }

        if (kofta_Bn == true)
        {
            sr_telo2.sprite = telo3shcolo2;
        }

        if (pizhama_Bn == true)
        {
            sr_nogi2.sprite = nogi1pizham2;
        }

        if (bruki_Bn == true)
        {
            sr_nogi2.sprite = nogi2scholo2;
        }

        if (shorti_Bn == true)
        {
            sr_nogi2.sprite = nogi3shoti2;
        }

        if (lasti_Bn == true)
        {
            sr_obuv2.sprite = obuv1lasti2;
        }

        if (obuv_Bn == true)
        {
            sr_obuv2.sprite = obuv3skololo2;
        }

        if (crossi_Bn == true)
        {
            sr_obuv2.sprite = obuv2krosi2;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
