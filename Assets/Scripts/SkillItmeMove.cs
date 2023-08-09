using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillItmeMove : MonoBehaviour
{

    public float itemSpeed = 1.0f;
    Vector3 dir = Vector3.down;
    public GameObject itemEffect;
    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * itemSpeed * Time.deltaTime;
    }
    private void OnDestroy()
    {
        //������ ����Ʈ�� ����
        GameObject itemEffGO = Instantiate(itemEffect);
        itemEffGO.transform.position= transform.position;

        //���߽� ���� ����Ʈ ����
        GameObject soundManager = GameObject.Find("SoundManager");
                
        AudioSource audioSource = soundManager.GetComponent<SoundManager>().effectAudioSource;
        //���� �Ŵ������� ����� �ҽ��� Ŭ���� ����
        audioSource.clip = soundManager.GetComponent<SoundManager>().itemAudioClips[0];

        //���� �Ŵ������� ����� �ҽ��� ���
        audioSource.Play();
    }


}
