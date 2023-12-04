using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TypewriterEffect : MonoBehaviour
{

    public static TypewriterEffect tha;
    private void Awake()
    {
        tha = this;
    }

    public bool whetherClick;

    public TextMeshProUGUI  text; // �ı����
    public string content; // Ҫ��ʾ������
    public float duration = 2f; // ��ʾ����ʱ��
    private float timer; // ��ʱ��
    private int index; // ��ǰ��ʾ���ַ�����

    void Start()
    {
        whetherClick = true;
        text.text = ""; // ����ı�
    }

    void Update()
    {
        if (whetherClick ==false)
        {
           
           
            timer += Time.deltaTime; // ���¼�ʱ��
            if (timer >= duration) // ���������ʱ��
            {
                text.text = content; // ֱ����ʾȫ������
                whetherClick = true;
                timer = 0;
            }
            else
            {
                index = (int)(content.Length * timer / duration); // ���㵱ǰ��ʾ���ַ�����
                text.text = content.Substring(0, index); // ��ʾ��������
            }
        }
      
    }
    public void typeWords()
    {
        whetherClick = false;
    }
}
