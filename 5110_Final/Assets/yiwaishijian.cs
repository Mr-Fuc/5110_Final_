using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class yiwaishijian : MonoBehaviour
{
    public static yiwaishijian tha;

    public bool luyou=false;
    public bool yiyu = false;
    public bool bigyiyu = false;
    public bool zhongfengf;
    public bool xinzangbing;

    public bool shenmgbing;

    public string[] lvyouxiangmu;
    private void Awake()
    {
        tha = this;
    }

    public TextMeshProUGUI  shijian;
    // Start is called before the first frame update
    void Start()
    {
        luyou = yiyu = bigyiyu = zhongfengf = shenmgbing = false;
    }

    void yiyuluoji()
    {
        if (!yiyu)
        {
            if (shuxingkongzhi .tha.xinli <= 10)
            {
                TypewriterEffect.tha.content = "He suffered from depression";
                TypewriterEffect.tha.dazi();
                yiyu = !yiyu;
            }

        }
        if(yiyu&&!bigyiyu)
        {
            if (shuxingkongzhi.tha.xinli <= 5)
            {
                TypewriterEffect.tha.content = "His depression worsened";
                TypewriterEffect.tha.dazi();
                bigyiyu = true;
            }
            if (shuxingkongzhi.tha.xinli >= 40)
            {
                TypewriterEffect.tha.content = "He came out of depression";
                TypewriterEffect.tha.dazi();
                bigyiyu = false;
                yiyu = false;
            }
        }
        if (bigyiyu)
        {
            if (shuxingkongzhi.tha.xinli >= 40)
            {
                TypewriterEffect.tha.content = "He came out of depression";
                TypewriterEffect.tha.dazi();
                bigyiyu = false;
                yiyu = false;
            }
            if (shuxingkongzhi.tha.xinli <= 1)
            {
               man .tha . siyin.text = "Accidental poisoning";
               
                man.tha.siwang.SetActive(true);
                
            }
        }
    }

    public void duboaa()
    {
        if (man.tha.year > 18)
        {
            if (shuxingkongzhi.tha.touzi >= 5 && shuxingkongzhi.tha.caifu >= 50)
            {
                shuxingkongzhi.tha.xinli -= 2;
                int a = Random.Range(0, 1);
                if (a == 0)
                {
                    shuxingkongzhi.tha.caifu += 5;
                }else
                {
                    shuxingkongzhi.tha.caifu -= 5;
                }

                TypewriterEffect.tha.content = "He is involved in gambling";
                TypewriterEffect.tha.dazi();

            }
        }
    }

    public void caiaa()
    {
        if (man.tha.year > 18)
        {
            float a = Random.Range(0, 1000000);
            if (a == 1)
            {
                TypewriterEffect.tha.content = "He won a big prize in the lottery";
                TypewriterEffect.tha.dazi();
                shuxingkongzhi.tha.xinli += 10;
                shuxingkongzhi.tha.caifu += 100;
            }
            if (a > 1 && a <= 3)
            {
                TypewriterEffect.tha.content = "He won a small prize in the lottery";
                TypewriterEffect.tha.dazi();
                shuxingkongzhi.tha.xinli += 1;
                shuxingkongzhi.tha.caifu += 10;
            }
        }
    }

    public void shengbinga()
    {
        if (shuxingkongzhi .tha .jiankang < 30&&!shenmgbing)
        {
            int a= Random.Range(0, 100);
            a += shuxingkongzhi.tha.jiankang;
            if (a > 50)
            {
                TypewriterEffect.tha.content = "He was ill.";
                TypewriterEffect.tha.dazi();
                shuxingkongzhi.tha.zhili -= 1;
                shuxingkongzhi.tha.jiankang -= 5;
                shuxingkongzhi.tha.xinli -= 3;
                shuxingkongzhi.tha.caifu -= 2;
                shenmgbing = true;
            }
           
        }
        if (shenmgbing)
        {
            int a = Random.Range(0, 100);
            a += shuxingkongzhi.tha.jiankang;
            if (a > 80)
            {
                TypewriterEffect.tha.content = "He recovered.";
                TypewriterEffect.tha.dazi();
                shuxingkongzhi.tha.jiankang += 4 ;
                shuxingkongzhi.tha.xinli += 3;
                shenmgbing = false ;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void shijianmzong()
    {
        TypewriterEffect.tha.content = "he grew up";
        TypewriterEffect.tha.dazi();
        if (man.tha.year > 30 && !zhongfengf)
        {
            if (shuxingkongzhi.tha.jiankang <= 30)
            {
                TypewriterEffect.tha.content = "He suffered a stroke.";
                TypewriterEffect.tha.dazi();
                zhongfengf = !zhongfengf;
            }
        }
        if (man.tha.year > 60 && !xinzangbing)
        {
            if (shuxingkongzhi.tha.jiankang <= 50)
            {
                TypewriterEffect.tha.content = "He had a heart attack.";
                TypewriterEffect.tha.dazi();
                xinzangbing = !xinzangbing;
            }
        }





        if (shuxingkongzhi.tha.caifu <= 0)
        {
            man.tha.siyin.text = "starvation";
           
            man.tha.siwang.SetActive(true);
        }
        if (shuxingkongzhi.tha.jiankang <= 0)
        {
            man.tha.siyin.text = "illness";
           
            man.tha.siwang.SetActive(true);
        }
        yiyuluoji();
        if (!luyou)
        {
            if (shuxingkongzhi.tha.caifu >= 100)
            {
                int aes =Random.Range(0, lvyouxiangmu.Length);
                string bea = lvyouxiangmu[aes];
                TypewriterEffect.tha.content = "He went to" + bea;
                TypewriterEffect.tha.dazi();
                luyou = !luyou;
            }
        }
        if (man.tha.hisbabyeng ==3)
        {

            TypewriterEffect.tha.content = "His child has grown up.";
            TypewriterEffect.tha.dazi();
        }
        if (man .tha .hisbabyeng > 12)
        {
          
            TypewriterEffect.tha.content = "His children have become independent.";
            TypewriterEffect.tha.dazi();
        }
    }
    public void daxueaa()
    {
        if (shuxingkongzhi.tha.zhili >= 40)
        {
            TypewriterEffect.tha.content = "He got into a good university";
            TypewriterEffect.tha.dazi();
        }
        if (shuxingkongzhi.tha.zhili<40&& shuxingkongzhi.tha.zhili >= 20)
        {
            TypewriterEffect.tha.content = "He got into a general university";
            TypewriterEffect.tha.dazi();
        }
        if (shuxingkongzhi.tha.zhili < 20)
        {
            TypewriterEffect.tha.content = "He didn't go to university";
            TypewriterEffect.tha.dazi();
        }
    }
    public void lihun()
    {
        TypewriterEffect.tha.content = "He's divorced.";
        TypewriterEffect.tha.dazi();
    }
    public void jiehun()
    {
        TypewriterEffect.tha.content = "he is married";
        TypewriterEffect.tha.dazi();
     
    }
}
