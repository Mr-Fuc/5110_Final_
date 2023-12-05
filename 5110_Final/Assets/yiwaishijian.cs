using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class yiwaishijian : MonoBehaviour
{
    public static yiwaishijian tha;

    public bool travel=false;
    public bool disorder = false;
    public bool bigdisorder = false;
    public bool zhongfengf;
    public bool heartDisease;
    //初始化数值
    public bool haveCar = false;
    public bool haveHouse = false;
    public bool isRichman = false;

    public bool haveIllness;

    public string[] travelPlans;
    private void Awake()
    {
        tha = this;
    }

    public TextMeshProUGUI  shijian;
    // Start is called before the first frame update
    void Start()
    {
        travel = disorder = bigdisorder = zhongfengf = haveIllness = false;
    }

    void disorderLogic()
    {
        if (!disorder)
        {
            if (shuxingkongzhi .tha.mental <= 10)
            {
                TypewriterEffect.tha.content = "He suffered from depression";
                TypewriterEffect.tha.typeWords();
                disorder = !disorder;
            }

        }
        if(disorder&&!bigdisorder)
        {
            if (shuxingkongzhi.tha.mental <= 5)
            {
                TypewriterEffect.tha.content = "His depression worsened";
                TypewriterEffect.tha.typeWords();
                bigdisorder = true;
            }
            if (shuxingkongzhi.tha.mental >= 40)
            {
                TypewriterEffect.tha.content = "He came out of depression";
                TypewriterEffect.tha.typeWords();
                bigdisorder = false;
                disorder = false;
            }
        }
        if (bigdisorder)
        {
            if (shuxingkongzhi.tha.mental >= 40)
            {
                TypewriterEffect.tha.content = "He came out of depression";
                TypewriterEffect.tha.typeWords();
                bigdisorder = false;
                disorder = false;
            }
            if (shuxingkongzhi.tha.mental <= 1)
            {
               man .tha . siyin.text = "Accidental poisoning";
               
                man.tha.siwang.SetActive(true);
                
            }
        }
    }

    public void gambling()
    {
        if (man.tha.year > 18)
        {
            if (shuxingkongzhi.tha.investment >= 5 && shuxingkongzhi.tha.wealth >= 50)
            {
                shuxingkongzhi.tha.mental -= 2;
                int a = Random.Range(0, 1);
                if (a == 0)
                {
                    shuxingkongzhi.tha.wealth += 5;
                }else
                {
                    shuxingkongzhi.tha.wealth -= 5;
                }

                TypewriterEffect.tha.content = "He is involved in gambling";
                TypewriterEffect.tha.typeWords();

            }
        }
    }

    public void lottery()
    {
        if (man.tha.year > 18)
        {
            float a = Random.Range(0, 1000000);
            if (a == 1)
            {
                TypewriterEffect.tha.content = "He won a big prize in the lottery";
                TypewriterEffect.tha.typeWords();
                shuxingkongzhi.tha.mental += 10;
                shuxingkongzhi.tha.wealth += 100;
            }
            if (a > 1 && a <= 3)
            {
                TypewriterEffect.tha.content = "He won a small prize in the lottery";
                TypewriterEffect.tha.typeWords();
                shuxingkongzhi.tha.mental += 1;
                shuxingkongzhi.tha.wealth += 10;
            }
        }
    }

    public void illness()
    {
        if (shuxingkongzhi .tha .health < 30&&!haveIllness)
        {
            int a= Random.Range(0, 100);
            a += shuxingkongzhi.tha.health;
            if (a > 50)
            {
                TypewriterEffect.tha.content = "He was ill.";
                TypewriterEffect.tha.typeWords();
                shuxingkongzhi.tha.intelligence -= 1;
                shuxingkongzhi.tha.health -= 5;
                shuxingkongzhi.tha.mental -= 3;
                shuxingkongzhi.tha.wealth -= 2;
                haveIllness = true;
            }
           
        }
        if (haveIllness)
        {
            int a = Random.Range(0, 100);
            a += shuxingkongzhi.tha.health ;
            if (a > 80)
            {
                TypewriterEffect.tha.content = "He recovered.";
                TypewriterEffect.tha.typeWords();
                shuxingkongzhi.tha.health  += 4 ;
                shuxingkongzhi.tha.mental += 3;
                haveIllness = false ;
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
        TypewriterEffect.tha.typeWords();
        if (man.tha.year > 30 && !zhongfengf)
        {
            if (shuxingkongzhi.tha.health <= 30)
            {
                TypewriterEffect.tha.content = "He suffered a stroke.";
                TypewriterEffect.tha.typeWords();
                zhongfengf = !zhongfengf;
            }
        }
        if (man.tha.year > 60 && !heartDisease)
        {
            if (shuxingkongzhi.tha.health <= 50)
            {
                TypewriterEffect.tha.content = "He had a heart attack.";
                TypewriterEffect.tha.typeWords();
                heartDisease = !heartDisease;
            }
        }





        if (shuxingkongzhi.tha.wealth <= 0)
        {
            man.tha.siyin.text = "starvation";
           
            man.tha.siwang.SetActive(true);
        }
        if (shuxingkongzhi.tha.health  <= 0)
        {
            man.tha.siyin.text = "illness";
           
            man.tha.siwang.SetActive(true);
        }
        disorderLogic();
        if (!travel)
        {
            if (shuxingkongzhi.tha.wealth  >= 100)
            {
                int aes =Random.Range(0, travelPlans.Length);
                string bea = travelPlans[aes];
                TypewriterEffect.tha.content = "He went to" + bea;
                TypewriterEffect.tha.typeWords();
                travel = !travel;
            }
        }
        if (man.tha.hisbabyeng ==3)
        {

            TypewriterEffect.tha.content = "His child has grown up.";
            TypewriterEffect.tha.typeWords();
        }
        if (man .tha .hisbabyeng > 12)
        {
          
            TypewriterEffect.tha.content = "His children have become independent.";
            TypewriterEffect.tha.typeWords();
        }
    }
    public void daxueaa()
    {
        if (shuxingkongzhi.tha.intelligence >= 40)
        {
            TypewriterEffect.tha.content = "He got into a good university";
            TypewriterEffect.tha.typeWords();
        }
        if (shuxingkongzhi.tha.intelligence < 40 && shuxingkongzhi.tha.intelligence  >= 20)
        {
            TypewriterEffect.tha.content = "He got into a general university";
            TypewriterEffect.tha.typeWords();
        }
        if (shuxingkongzhi.tha.mental < 20)
        {
            TypewriterEffect.tha.content = "He didn't go to university";
            TypewriterEffect.tha.typeWords();
        }
    }
    public void isDivorced()
    {
        TypewriterEffect.tha.content = "He's divorced.";
        TypewriterEffect.tha.typeWords();
        //属性改变
        shuxingkongzhi.tha.wealth /= 2;
        shuxingkongzhi.tha.mental -= 5;
    }
    public void jiehun()
    {
        TypewriterEffect.tha.content = "he is married";
        TypewriterEffect.tha.typeWords();
        //属性改变
        shuxingkongzhi.tha.wealth += 25;
        shuxingkongzhi.tha.mental += 5;
        shuxingkongzhi.tha.health += 2;
    }

    public void buyCar()
    {
        //年龄及财富、条件判断
        if (man.tha.year >= 18 && shuxingkongzhi.tha.wealth >= 50 && haveCar == false )
        {
            //打字
            TypewriterEffect.tha.content = "he bought a car";
            TypewriterEffect.tha.typeWords();
            //属性改变
            shuxingkongzhi.tha.wealth -= 30;
            shuxingkongzhi.tha.mental += 5;
            shuxingkongzhi.tha.intelligence += 2;
            man.tha.dongtmarry -= 5;
            //判断条件改变
            haveCar = true;
        }
           
    }

    public void buyHouse()
    {
        //年龄及财富、条件判断
        if (man.tha.year >= 18 && shuxingkongzhi.tha.wealth >= 200 && haveHouse == false )
        {
            //打字
            TypewriterEffect.tha.content = "he bought a house";
            TypewriterEffect.tha.typeWords();
            //属性改变
            shuxingkongzhi.tha.wealth -= 100;
            shuxingkongzhi.tha.mental += 5;
            shuxingkongzhi.tha.health += 3;
            man.tha.dongtmarry -= 10;
            //判断条件改变
            haveHouse = true;
        }
    }

    public void richPerson()
    {   
        //先决条件判断
        if(isRichman == true && shuxingkongzhi.tha.wealth <= 150 )
        {
            TypewriterEffect.tha.content = "he is no longer a billionairy";
            TypewriterEffect.tha.typeWords();
            isRichman = false;
        }
        //年龄及财富、条件判断
        if (man.tha.year >= 20 && shuxingkongzhi.tha.wealth >= 250 && isRichman == false )
        {
            //打字
            TypewriterEffect.tha.content = "he became a billionairy";
            TypewriterEffect.tha.typeWords();
            //属性改变
            shuxingkongzhi.tha.mental -= 10;
            shuxingkongzhi.tha.intelligence += 5;
            shuxingkongzhi.tha.health += 10;
            man.tha.dongtmarry += 10;
            isRichman = true;
        }
    }

    public void workPromotion()
    {
        //先决条件随机
        float tmp = Random.Range(0, 10);
        //年龄及智力判断
        if (man.tha.year >= 25 && man.tha.year <= 50 && shuxingkongzhi.tha.intelligence > 40 && tmp >= 5)
        {
            TypewriterEffect.tha.content = "he got a work promotion";
            TypewriterEffect.tha.typeWords();
            //属性改变
            shuxingkongzhi.tha.intelligence += 5;
            shuxingkongzhi.tha.wealth += 20;
            shuxingkongzhi.tha.health -= 5;
            man.tha.dongtmarry -= 10;
        }
    }

    public void workDemotion()
    {
        //先决条件随机
        float tmp = Random.Range(0, 10);
        //年龄及智力判断
        if (man.tha.year >= 25 && man.tha.year <= 50 && shuxingkongzhi.tha.intelligence < 20 && tmp >= 5)
        {
            TypewriterEffect.tha.content = "he got a work demotion";
            TypewriterEffect.tha.typeWords();
            //属性改变
            shuxingkongzhi.tha.mental -= 5;
            shuxingkongzhi.tha.wealth -= 20;
            shuxingkongzhi.tha.health += 5;
            man.tha.dongtmarry += 5;
        }
    }
}
