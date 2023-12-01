using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shuxingkongzhi : MonoBehaviour
{
    public static shuxingkongzhi tha;
    private void Awake()
    {
        tha = this;
    }

    public int zhili;
    public int xinli;
    public int jiankang;
    public int caifu;
    public int jiating;
    public int touzi;

    public TextMeshProUGUI one;
    public TextMeshProUGUI one2;
    public TextMeshProUGUI one3;
    public TextMeshProUGUI one4;
    public TextMeshProUGUI one5;
    // Start is called before the first frame update
    void Start()
    {
        touzi = 0;
        zhili = Random.Range(0,10);
        xinli = Random.Range(30, 100);
        jiankang = Random.Range(50, 100);
        caifu = Random.Range(10, 100);
    }
    public void touziaa()
    {
        if (TypewriterEffect.tha.shifoudianji == true)
        {
            man.tha.oncliceaa();
            touzi += 1;
        }
    }
    public void growzhili(int ase)
    {
        if (TypewriterEffect.tha.shifoudianji == true)
        {
            man.tha.oncliceaa();
            zhili += ase;
        }
    }
    public void growxinli(int ase)
    {
        if (TypewriterEffect.tha.shifoudianji == true)
        {
            man.tha.oncliceaa();
            xinli += ase;
        }
    }
    public void growjiankang(int ase)
    {
        if (TypewriterEffect.tha.shifoudianji == true)
        {
            man.tha.oncliceaa();
            jiankang += ase;
        }
    }
    public void growcaifu(int ase)
    {
        if (TypewriterEffect.tha.shifoudianji == true)
        {
            man.tha.oncliceaa();
            caifu += ase;
        }
    }
    public void growjiating(int ase)
    {
        if (TypewriterEffect.tha.shifoudianji == true)
        {
            man.tha.oncliceaa();
            if (man.tha.marry == true)
            {
                man.tha.dongtmarry -= ase;
            }
            if (man.tha.marry != true)
            {
                man.tha.dongtmarry += ase;
            }
        }
    }
 
    // Update is called once per frame
    void Update()
    {
        if (man .tha .year>=40&&!(man .tha .isdie))
        {

        }



        one.text = "" + zhili;
        one2.text = "" + xinli;
        one3.text = "" + jiankang ;
        one4.text = "" + caifu;
    }
}
