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

    public int intelligence;
    public int mental;
    public int health;
    public int wealth;
    public int family;
    public int investment;

    public TextMeshProUGUI one;
    public TextMeshProUGUI one2;
    public TextMeshProUGUI one3;
    public TextMeshProUGUI one4;
    public TextMeshProUGUI one5;
    // Start is called before the first frame update
    void Start()
    {
        investment = 0;
        intelligence = Random.Range(0,10);
        mental = Random.Range(30, 100);
        health = Random.Range(50, 100);
        wealth = Random.Range(10, 100);
    }
    public void touziaa()
    {
        if (TypewriterEffect.tha.whetherClick == true)
        {
            man.tha.oncliceaa();
            investment += 1;
        }
    }
    public void intelligenceGrowth(int ase)
    {
        if (TypewriterEffect.tha.whetherClick == true)
        {
            man.tha.oncliceaa();
            intelligence += ase;
        }
    }
    public void mentalGrowth(int ase)
    {
        if (TypewriterEffect.tha.whetherClick == true)
        {
            man.tha.oncliceaa();
            mental += ase;
        }
    }
    public void healthGrowth(int ase)
    {
        if (TypewriterEffect.tha.whetherClick == true)
        {
            man.tha.oncliceaa();
            health += ase;
        }
    }
    public void wealthGrowth(int ase)
    {
        if (TypewriterEffect.tha.whetherClick == true)
        {
            man.tha.oncliceaa();
            wealth += ase;
        }
    }
    public void familyGrowth(int ase)
    {
        if (TypewriterEffect.tha.whetherClick == true)
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



        one.text = "" + intelligence;
        one2.text = "" + mental;
        one3.text = "" + health;
        one4.text = "" + wealth;
    }
}
