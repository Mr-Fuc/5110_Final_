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

    public int Intelligence;
    public int Mental;
    public int Health;
    public int Wealth;
    public int Family;
    public int Investment;

    public TextMeshProUGUI one;
    public TextMeshProUGUI one2;
    public TextMeshProUGUI one3;
    public TextMeshProUGUI one4;
    public TextMeshProUGUI one5;
    // Start is called before the first frame update
    void Start()
    {
        Investment = 0;
        Intelligence = Random.Range(0,10);
        Mental = Random.Range(30, 100);
        Health = Random.Range(50, 100);
        Wealth = Random.Range(10, 100);
    }
    public void touziaa()
    {
        if (TypewriterEffect.tha.shifoudianji == true)
        {
            man.tha.oncliceaa();
            Investment += 1;
        }
    }
    public void growzhili(int ase)
    {
        if (TypewriterEffect.tha.shifoudianji == true)
        {
            man.tha.oncliceaa();
            Intelligence += ase;
        }
    }
    public void growxinli(int ase)
    {
        if (TypewriterEffect.tha.shifoudianji == true)
        {
            man.tha.oncliceaa();
            Mental += ase;
        }
    }
    public void growjiankang(int ase)
    {
        if (TypewriterEffect.tha.shifoudianji == true)
        {
            man.tha.oncliceaa();
            Health += ase;
        }
    }
    public void growcaifu(int ase)
    {
        if (TypewriterEffect.tha.shifoudianji == true)
        {
            man.tha.oncliceaa();
            Wealth += ase;
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



        one.text = "" + Intelligence;
        one2.text = "" + Mental;
        one3.text = "" + Health;
        one4.text = "" + Wealth;
    }
}
