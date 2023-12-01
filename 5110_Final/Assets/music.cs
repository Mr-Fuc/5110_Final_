using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    private static bool musicExists = false;
    private void Awake()
    {
        if (musicExists)
        {
            Destroy(gameObject);
        }
        else
        {
            // 如果音乐不存在，就设置音乐存在为真，并使音乐对象不被销毁
            musicExists = true;
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
      var bjm=  gameObject.AddComponent<AudioSource>();
        bjm.playOnAwake = true;
        bjm.loop = true;
        bjm.Play();
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
