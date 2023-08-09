using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    //플레이어가 쌓은 점수(타격 점수, 최고 점수, 격추 점수)를 저장한다.
    //플레이어가 점수를 얻는다.
    //플레이어가 쌓은 점수를 UI에 표시해 준다.
    //점수 UI를 초기화 해준다.

    public int attackScore;
    public int bestScore;
    public int destroyScore;

    public TMP_Text attackScoreTxt;
    public TMP_Text bestScoreTxt;
    public TMP_Text destroyScoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        attackScoreTxt.text = "0";
        destroyScoreTxt.text = "0";
        bestScore = PlayerPrefs.GetInt("Best Score");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
