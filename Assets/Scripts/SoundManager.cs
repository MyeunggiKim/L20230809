using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//BGM���� ����, ������ ȹ�� ȿ������ �����Ѵ�.
//BGM, ���� ����, ������ ȹ�� ȿ������ ����� Ŭ��
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
