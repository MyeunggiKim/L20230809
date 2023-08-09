using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//목표: 사용자 입력(Space)를 받아 총알을 만들고 싶다.
//순서1: 입력을 받고 싶다.
//순서2: 총알을 만들고 싶다.
public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;
    public int skillLevel = 1;
    public int degree = 15;

    private void Start()
    {
        bullet.layer = 11;        
    }

    // Update is called once per frame
    void Update()
    {
        //순서1: 입력을 받고 싶다.
        if (Input.GetKeyDown(KeyCode.Space))
        {

            ExcuteSkill(skillLevel);
        }
    }

    private void ExcuteSkill(int _skillLevel)
    {
        switch (_skillLevel)
        {
            case 0:
                ExcuteSkill0();
                break;
            case 1:
                ExcuteSkill1();
                break;
            case 2:
                ExcuteSkill2();
                break;
            case 3:
                ExcuteSkill3();
                break;
        }
    }

    void ExcuteSkill0()
    {
        bullet.tag = "PlayerBullet";
        //순서2: 총알을 만들고 싶다.
        GameObject bulletGO = Instantiate(bullet);

        //순서3: 총알의 위치를 플레이어의 위치로 정해주고 싶다.
        bulletGO.transform.position = transform.position;
    }

    void ExcuteSkill1()
    {
        bullet.tag = "PlayerBullet";
        //순서2: 총알을 만들고 싶다.
        GameObject bulletGO = Instantiate(bullet);
        GameObject bulletGO1 = Instantiate(bullet);

        //순서3: 총알의 위치를 플레이어의 위치로 정해주고 싶다.
        bulletGO.transform.position = transform.position+new Vector3(-0.3f ,0 ,0) ;
        bulletGO1.transform.position = transform.position + new Vector3(0.3f, 0, 0);
    }

    void ExcuteSkill2()
    {
        bullet.tag = "PlayerBullet";
        //순서2: 총알을 만들고 싶다.
        GameObject bulletGO = Instantiate(bullet);
        GameObject bulletGO1 = Instantiate(bullet);
        GameObject bulletGO2 = Instantiate(bullet);

        //순서3: 총알의 위치를 플레이어의 위치로 정해주고 싶다.
        bulletGO.transform.position = transform.position;
        bulletGO2.GetComponent<Bullet>().dir = bulletGO2.transform.up;

        bulletGO1.transform.position = transform.position + new Vector3(0.3f, 0, 0);
        bulletGO1.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
        bulletGO1.GetComponent<Bullet>().dir = bulletGO1.transform.up;

        bulletGO2.transform.position = transform.position + new Vector3(-0.3f, 0, 0);
        bulletGO2.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -30));
        bulletGO2.GetComponent<Bullet>().dir = bulletGO2.transform.up;
    }

    void ExcuteSkill3()
    {
        int numOfBullet = 360 / degree;

        for(int i = 0; i < numOfBullet; i++)
        {
            GameObject bulletGO = Instantiate(bullet);

            bulletGO.transform.position = transform.position;
            bulletGO.transform.rotation = Quaternion.Euler(0, 0, i * degree);
            bulletGO.GetComponent<Bullet>().dir = bulletGO.transform.up;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Item")
        {
            if (skillLevel < 3)
            {
                skillLevel++;

            }
            Destroy(other.gameObject);
        }
    }
}
