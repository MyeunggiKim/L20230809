using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    //�÷��̾ ���� ����(Ÿ�� ����, �ְ� ����, ���� ����)�� �����Ѵ�.
    //�÷��̾ ������ ��´�.
    //�÷��̾ ���� ������ UI�� ǥ���� �ش�.
    //���� UI�� �ʱ�ȭ ���ش�.

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
