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
            // ������ֲ����ڣ����������ִ���Ϊ�棬��ʹ���ֶ��󲻱�����
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
