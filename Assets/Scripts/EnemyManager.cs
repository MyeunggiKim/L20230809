using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ:���� �����Ѵ�.
// �ʿ� �Ӽ�: Ư�� �ð�,���� �ð�, �� GameObject
// ����1. Ư�� �ð��� �帥��.
// ����2. ���� �ð��� Ư�� �ð��� �Ǹ�
// ����3. ���� EnemyManager ��ġ�� �����Ѵ�.
// ����4. �ð��� �ʱ�ȭ ���ش�.

// �߰�. Ư�� �ð��� ������ �ð����� �����Ѵ�.
public class EnemyManager : MonoBehaviour
{
    //�ʿ� �Ӽ�: Ư�� �ð�, ����ð�, �� GameObject
    //Ư���ð�
    float createTime;

    //����ð�
    float currentTime = 0;

    //�� ���ӿ�����Ʈ
    public GameObject enemy;


    public float minTime = 3;
    public float maxTime = 5;

    public void Start()
    {
        createTime = Random.Range(minTime, maxTime);
    }


    // Update is called once per frame
    void Update()
    {
        enemy.layer = 6;
        // ����1. Ư�� �ð��� �帥��.
        currentTime += Time.deltaTime;
        //print("currentTime" + currentTime);

        // ����2. ���� �ð��� Ư�� �ð��� �Ǹ�
        if (currentTime > createTime)
        {
            //����3. ���� EnemyManager ��ġ�� �����Ѵ�.
            GameObject enemyGO = Instantiate(enemy);
            enemyGO.transform.position = transform.position;

            //����4. �ð��� �ʱ�ȭ ���ش�.
            currentTime = 0;
        }
    }
}
