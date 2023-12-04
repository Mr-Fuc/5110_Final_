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

    public TextMeshProUGUI  text; // 文本组件
    public string content; // 要显示的内容
    public float duration = 2f; // 显示的总时长
    private float timer; // 计时器
    private int index; // 当前显示的字符索引

    void Start()
    {
        whetherClick = true;
        text.text = ""; // 清空文本
    }

    void Update()
    {
        if (whetherClick ==false)
        {
           
           
            timer += Time.deltaTime; // 更新计时器
            if (timer >= duration) // 如果超过总时长
            {
                text.text = content; // 直接显示全部内容
                whetherClick = true;
                timer = 0;
            }
            else
            {
                index = (int)(content.Length * timer / duration); // 计算当前显示的字符索引
                text.text = content.Substring(0, index); // 显示部分内容
            }
        }
      
    }
    public void typeWords()
    {
        whetherClick = false;
    }
}
