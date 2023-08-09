using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//BGM폭발 사운드, 아이템 획득 효과음을 제생한다.
//BGM, 폭발 사운드, 아이템 획득 효과음의 오디오 클립
public class SoundManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public AudioSource effectAudioSource;

    public List<AudioClip> bgmAudioClips = new List<AudioClip>();
    public List<AudioClip> explosionAudioClips = new List<AudioClip>();
    public List<AudioClip> itemAudioClips = new List<AudioClip>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
