using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class man : MonoBehaviour
{
    public GameObject[] allbtt;

    public GameObject[] anniu1;
    public GameObject[] anniu2;
    public GameObject[] anniu3;
    public GameObject[] anniu4;
    public GameObject[] anniu5;
    public GameObject[] anniu6;

    public TextMeshProUGUI jia1;
    public TextMeshProUGUI jia2;


    public static man tha;

    public bool genggai;

    public bool fuqizhengchao;
    public bool fuqihemu;
    private void Awake()
    {
        tha = this;
    }


    public void allcolse()
    {
        foreach (GameObject ase in allbtt)
        {
            ase.SetActive(false);
        }
    }
    public void anniu1om()
    {
        foreach (GameObject ase in anniu1 )
        {
            ase.SetActive(true);
        }
    }
    public void anniu2om()
    {
        foreach (GameObject ase in anniu2)
        {
            ase.SetActive(true);
        }
    }
    public void anniu3om()
    {
        foreach (GameObject ase in anniu3)
        {
            ase.SetActive(true);
        }
    }
    public void anniu4om()
    {
        foreach (GameObject ase in anniu4)
        {
            ase.SetActive(true);
        }
    }
    public void anniu5om()
    {
        foreach (GameObject ase in anniu5)
        {
            ase.SetActive(true);
        }
    }
    public void anniu6om()
    {
        foreach (GameObject ase in anniu6)
        {
            ase.SetActive(true);
        }
    }

    public float year;
    public Animator manan;

    public GameObject hisbabyboidy;
    public Animator hisbaby;
    public float hisbabyeng;
    bool hisbabytru;

    public int dongbabyyear;



    public  bool isbaby=true ;
    public  bool isboy=true;
    public bool isyounman = true;
    public bool isman = true;
    public bool ISOLD = true;

    float OLDMANDIECOUNT;

    public bool isdie;

    public TMPro.TextMeshProUGUI  siyin;
    public GameObject siwang;

    public GameObject marry;


    public bool ismarryed;
    public float marrycount;
    public float dongtmarry;

    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        
        genggai=fuqihemu =fuqizhengchao = false;

        allcolse();
        anniu1om();
        marrycount = 10;
        dongtmarry = 5;
        marry.SetActive(false);


        OLDMANDIECOUNT = 50;
        isbaby = true;
        isboy = isyounman = isman = ISOLD = false;
        year = 0;
        isdie = false;
        siwang.SetActive(false);
        
    }









    public void oncliceaa()
    {
      
            if (!isdie)
            {

                if (hisbabytru==true)
                {
                    hisbabyeng += 1;
                    if (hisbabyeng==3)
                    {
                        StartCoroutine(growa2());
                        yiwaishijian.tha.shijian.text = "His child has grown up.";
                        TypewriterEffect.tha.dazi();
                        Debug.Log(37);
                    }
                 
                }


                year += 1;
                yiwaishijian.tha.shijian.text = "";
                yiwaishijian.tha.shijianmzong();
                yiwaishijian.tha.caiaa();
                yiwaishijian.tha.shengbinga();
                if (year < 60)
                {
                    if (year == 18)
                    {
                        yiwaishijian.tha.daxueaa();
                    }
                    die();
                }
                else
                {
                    OLDDIE();
                }

                if (year > 18 && year <= 60)
                {
                    ismarry();
                }
            }
    


}
    // Update is called once per frame
    void Update()
    {

        if (hisbabytru ==false)
        {
            hisbabyeng = 0;
           
            hisbabyboidy.SetActive(false);
        }
        if (hisbabyeng > 12)
        {
            hisbabytru = false;
            yiwaishijian.tha.shijian.text = "His children have become independent.";
            hisbaby.SetTrigger("end");
            TypewriterEffect.tha.dazi();
        }


        text.text = "" + year;

        if (year > 3&&isbaby)
        {
            StartCoroutine(growa());
            isbaby = false;
            isboy = true;
            allcolse();
            anniu2om();

        }
        if (year > 12 && isboy)
        {
            StartCoroutine(growa());
            isboy = false;
            isyounman = true;
            allcolse();
            anniu3om();
        }
        if (year > 18 && isyounman)
        {
            StartCoroutine(growa());
            isyounman = false;
            isman = true;
            allcolse();
            anniu4om();
        }
        if (year >35&&year <= 60)
        {
            allcolse();
            anniu5om();
        }
        if (year > 60 && isman)
        {
            isman = false;
            ISOLD = true;
            marry.SetActive(false);
            StartCoroutine(growa());
            allcolse();
            anniu6om();
        }
       

      
       
    }

    void ismarry()
    {
        float m = Random.Range(0, 200);
       
        if (!ismarryed)
        {
            jia1.text = "Romance";
            jia2.text = "Romance";
            if (year < 40)
            {
               
                marrycount += 1;
                if (m <= marrycount)
                {
                  
                    ismarryed = true;
                    marry.SetActive(true);
                    if (!genggai)
                    {
                        yiwaishijian.tha.jiehun();
                        genggai = !genggai;
                    }
                  
                }

               
            }
            if (year>= 40&&year <60)
            {
               
                marrycount -= 2;
                if (m <= marrycount)
                {
                    ismarryed = true;
                    marry.SetActive(true);
                    if (!genggai)
                    {
                        yiwaishijian.tha.jiehun();
                        genggai = !genggai;
                    }
                }
            }
        }
       else  if (ismarryed)
        {
            jia1.text = "Family";
            jia2.text = "Family";
            
            dongbabyyear += 1;
            if (dongbabyyear > 2&&year < 45&&hisbabytru ==false)
            {
                int f = Random.Range(0, 10);
                if (f <= 5)
                {
                    hisbabyeng = 0;
                    hisbabytru = true;
                    hisbabyboidy.SetActive(true);
                    yiwaishijian.tha.shijian.text = "His child was born.";
                    TypewriterEffect.tha.dazi();
                }

            }
            if (year < 40)
            {
                
                dongtmarry += 1;
                if (dongtmarry >= 50)
                {
                    if (!fuqizhengchao)
                    {
                        fuqizhengchao = true;
                        dongtmarry += 10;
                        yiwaishijian.tha.shijian.text = "He had a quarrel with his wife over some family matters";
                        TypewriterEffect.tha.dazi();
                    }
                }
                if (dongtmarry <= 20)
                {
                    if (!fuqihemu)
                    {
                        fuqihemu = true;
                        dongtmarry -= 10;
                        yiwaishijian.tha.shijian.text = "He got a present for his anniversary";
                        TypewriterEffect.tha.dazi();
                        shuxingkongzhi.tha.xinli += 3;
                    }
                }
                if (m <= dongtmarry)
                {
                    ismarryed = false ;
                    marry.SetActive(false);
                    hisbabytru = false;
                    hisbaby.SetTrigger("end");

                    marry.SetActive(false);
          
                    if (genggai)
                    {
                        yiwaishijian.tha.lihun();
                        genggai = !genggai;
                    }
                    yiwaishijian.tha.lihun();
                }
            }
            if (year >= 40 && year <= 60)
            {
                dongtmarry -= 2;
                if (dongtmarry >= 50)
                {
                    if (!fuqizhengchao)
                    {
                        fuqizhengchao = true;
                        dongtmarry += 10;
                        yiwaishijian.tha.shijian.text = "He had a quarrel with his wife over some family matters";
                        TypewriterEffect.tha.dazi();
                    }
                }
                if (dongtmarry <= 20)
                {
                    if (!fuqihemu)
                    {
                        fuqihemu = true;
                        dongtmarry -= 10;
                        shuxingkongzhi.tha.xinli += 3;
                        yiwaishijian.tha.shijian.text = "He got a present for his anniversary";
                        TypewriterEffect.tha.dazi();
                    }
                }
                if (m <= dongtmarry)
                {
                    ismarryed = false;

                    hisbabytru = false;
                    hisbaby.SetTrigger("end");

                    marry.SetActive(false);
                    if (genggai)
                    {
                        yiwaishijian.tha.lihun();
                        genggai = !genggai;
                        
                    }
                }
            }
        }
       
       
    }
    IEnumerator growa()
    {
        yield return new WaitForSeconds(0f);
        if (!ismarryed)
        {
            manan.SetTrigger("grow");
        }else
        {
            manan.SetTrigger("wf");
        }
       
    }
    IEnumerator growa2()
    {
        yield return new WaitForSeconds(0f);

        hisbaby.SetTrigger("grow");

    }
    void die()
    {
        if (isdie ==false)
        {
            if (isbaby)
            {
                float a = Random.Range(0, 1000);
                if (a <= 5)
                {
                    
                    float b = Random.Range(0, 100);

                   if (b < 30)
                    {
                        siyin.text = "congenital deformity";
                        siwang.SetActive(true);
                    }
                    if (b >= 30&&b <50)
                    {
                        siyin.text = "Preterm birth and low birth weight";
                        siwang.SetActive(true);
                    }
                    if (b >= 50 && b <65)
                    {
                        siyin.text = "respiratory distress syndrome";
                        siwang.SetActive(true);
                    }
                    if (b >= 65 && b < 75)
                    {
                        siyin.text = "catch";
                        siwang.SetActive(true);
                    }
                    if (b >= 75 && b < 100)
                    {
                        siyin.text = "Unexplained causes of death";
                        siwang.SetActive(true);
                    }
                    isdie = true;
                    //先天性畸形: 30 % 早产和低出生体重: 20 % 呼吸窘迫综合症: 15 % 感染疾病: 10 % 未解的死亡原因:25 %
                }
            }
            if (isboy)
            {
                float a = Random.Range(0, 1000);
                if (a <= 10)
                {

                    float b = Random.Range(0, 100);

                    if (b < 25)
                    {
                        siyin.text = "Traffic accidents";
                        siwang.SetActive(true);
                    }
                    if (b >= 25 && b < 40)
                    {
                        siyin.text = "Drowning";
                        siwang.SetActive(true);
                    }
                    if (b >= 40 && b < 55)
                    {
                        siyin.text = "Respiratory infections";
                        siwang.SetActive(true);
                    }
                    if (b >= 55 && b < 75)
                    {
                        siyin.text = "Injuries";
                        siwang.SetActive(true);
                    }
                    if (b >= 75 && b < 85)
                    {
                        siyin.text = "Accidental poisoning";
                        siwang.SetActive(true);
                    }
                    if (b >= 85 && b < 100)
                    {
                        siyin.text = "Unexplained causes of death";
                        siwang.SetActive(true);
                    }
                    isdie = true;
                    //先天性畸形: 30 % 早产和低出生体重: 20 % 呼吸窘迫综合症: 15 % 感染疾病: 10 % 未解的死亡原因:25 %
                }
            }
            if (isyounman)
            {
                float a = Random.Range(0, 1000);
                if (a <= 20)
                {

                    float b = Random.Range(0, 100);

                    if (b < 30)
                    {
                        siyin.text = "Traffic accidents";
                        siwang.SetActive(true);
                    }
                    if (b >= 30 && b < 50)
                    {
                        siyin.text = "Suicide";
                        siwang.SetActive(true);
                    }
                    if (b >= 50 && b < 70)
                    {
                        siyin.text = "Accidental injuries";
                        siwang.SetActive(true);
                    }
                    if (b >= 70 && b < 80)
                    {
                        siyin.text = "Infectious diseases";
                        siwang.SetActive(true);
                    }
                    if (b >= 80 && b <100)
                    {
                        siyin.text = "Unexplained causes of death";
                        siwang.SetActive(true);
                    }
 
                    isdie = true;
                    //先天性畸形: 30 % 早产和低出生体重: 20 % 呼吸窘迫综合症: 15 % 感染疾病: 10 % 未解的死亡原因:25 %
                }
            }
            if (isman)
            {
                float a = Random.Range(0, 1000);
                if (a <= 30)
                {

                    float b = Random.Range(0, 105);

                    if (b < 30)
                    {
                        siyin.text = "Cardiovascular diseases";
                        siwang.SetActive(true);
                    }
                    if (b >= 30 && b < 55)
                    {
                        siyin.text = "Cancer";
                        siwang.SetActive(true);
                    }
                    if (b >= 55 && b < 70)
                    {
                        siyin.text = "Accidental injuries";
                        siwang.SetActive(true);
                    }
                    if (b >= 70 && b < 80)
                    {
                        siyin.text = "Respiratory diseases";
                        siwang.SetActive(true);
                    }
                    if (b >= 80 && b < 85)
                    {
                        siyin.text = "Diabetes";
                        siwang.SetActive(true);
                    }
                    if (b >= 85 && b < 90)
                    {
                        siyin.text = "Infectious diseases";
                        siwang.SetActive(true);
                    }
                    if (b >= 90 && b < 95)
                    {
                        siyin.text = "Suicide";
                        siwang.SetActive(true);
                    }
                    if (b >= 95 && b < 98)
                    {
                        siyin.text = "Liver diseases";
                        siwang.SetActive(true);
                    }
                    if (b >= 98 && b < 100)
                    {
                        siyin.text = "Neurological disorders";
                        siwang.SetActive(true);
                    }
                    if (b >= 100 && b < 103)
                    {
                        siyin.text = "Unexplained causes of death";
                        siwang.SetActive(true);
                    }
                    if (b >= 103 && b < 105)
                    {
                        siyin.text = "Kidney diseases";
                        siwang.SetActive(true);
                    }


                    isdie = true;
                    //先天性畸形: 30 % 早产和低出生体重: 20 % 呼吸窘迫综合症: 15 % 感染疾病: 10 % 未解的死亡原因:25 %
                }
            }
        }
        
    }
    void OLDDIE()
    {
        allcolse();
        anniu6om();
        if (isdie == false)
        {
            if (OLDMANDIECOUNT < 99)
            {
                OLDMANDIECOUNT += 1;
            }
           
          float OLD = Random.Range(0,500); 
            if (OLD <OLDMANDIECOUNT)
            {
                float b = Random.Range(0, 104);

                if (b < 30)
                {
                    siyin.text = "Cardiovascular disease";
                    siwang.SetActive(true);
                }
                if (b >= 30 && b < 55)
                {
                    siyin.text = "Cancer";
                    siwang.SetActive(true);
                }
                if (b >= 55 && b < 70)
                {
                    siyin.text = "Respiratory diseases";
                    siwang.SetActive(true);
                }
                if (b >= 70 && b < 80)
                {
                    siyin.text = "Diabetes";
                    siwang.SetActive(true);
                }
                if (b >= 80 && b < 85)
                {
                    siyin.text = "Infectious diseases";
                    siwang.SetActive(true);
                }
                if (b >= 85&& b < 90)
                {
                    siyin.text = "Natural aging";
                    siwang.SetActive(true);
                }
                if (b >= 90 && b < 95)
                {
                    siyin.text = "Fractures and falls";
                    siwang.SetActive(true);
                }
                if (b >= 95 && b < 98)
                {
                    siyin.text = "Neurological disorders";
                    siwang.SetActive(true);
                }
                if (b >= 98 && b < 100)
                {
                    siyin.text = "Kidney diseases";
                    siwang.SetActive(true);
                }
                if (b >= 100 && b < 102)
                {
                    siyin.text = "Suicide";
                    siwang.SetActive(true);
                }
                if (b >= 102 && b <104)
                {
                    siyin.text = "Unexplained causes of death";
                    siwang.SetActive(true);
                }
                isdie = true;
            }
          
        }
    }
}
