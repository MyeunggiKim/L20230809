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
        //아이템 이펙트의 생성
        GameObject itemEffGO = Instantiate(itemEffect);
        itemEffGO.transform.position= transform.position;

        //폭발시 사운드 이펙트 생성
        GameObject soundManager = GameObject.Find("SoundManager");
                
        AudioSource audioSource = soundManager.GetComponent<SoundManager>().effectAudioSource;
        //사운드 매니저에서 오디오 소스의 클립을 변경
        audioSource.clip = soundManager.GetComponent<SoundManager>().itemAudioClips[0];

        //사운드 매니저에서 오디오 소스를 재생
        audioSource.Play();
    }


}
