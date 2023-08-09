using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//목표1: 아래 방향으로 이동한다.
//목표2: 다른 충돌체와 부딪혔으면 둘다 파괴한다.
//목표3: 시작시 30%의 확률로 플레이어를 따라간다.
//목표4: 10프로의 확률로 플레이어를 따라간다.
//목표5: 적도 플레이어를 향해 일정 시간마다 총알을 쏜다.
//목표6: 충돌시 폭발 효과를 생성한다.
//목표7: 총알과 충돌시 hp 감소, 플레이어와 충돌시 파괴한다.
//목표8: 피격시 게임 매니저에 attackScore를 올린다.
//목표9: 격추시 게임 매니저에 destroyScore를 올린다.
public class Enemy : MonoBehaviour
{

    public float speed = 1.0f;
    public Vector3 dir = Vector3.down;
    int randValue;
    GameObject player;
    public GameObject eplosionEff;
    public int hp = 3;

    GameManager gameManager;

    Vector3 playerDir;

    // Start is called before the first frame update
    void Start()
    {
        randValue = Random.Range(0, 10);
        player = GameObject.Find("Player");

        if (randValue < 5 )
        {
           if(player != null)
            {
                dir = (player.transform.position -gameObject.transform.position).normalized;
            }
        }

        gameManager =GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (randValue < 3)
        {
            if(player != null)
            {
                playerDir = (player.transform.position - gameObject.transform.position).normalized;
                dir = playerDir;
            }
        }

        transform.position += dir * speed * Time.deltaTime;

        gameManager.attackScoreTxt.text = gameManager.attackScore.ToString();
        gameManager.destroyScoreTxt.text = gameManager.destroyScore.ToString();

    }

    //
    private void OnCollisionEnter(Collision otherObject)
    {
        if (otherObject.gameObject.tag == "PlayerBullet")
        {
            hp--;
            gameManager.attackScore += 10;

            if (hp < 0)
            {
                if (otherObject.gameObject.tag == "Player")
                {
                    player.GetComponent<PlayerMove>().hp--;

                    if (player.GetComponent<PlayerMove>().hp < 0)
                    {
                        Destroy(otherObject.gameObject);
                    }
                }

                Destroy(gameObject);

                GameObject bulletExplosionGO = Instantiate(eplosionEff);
                bulletExplosionGO.transform.position = transform.position;

                if (otherObject.gameObject.tag != "DestroyZone")
                {
                    Destroy(otherObject.gameObject);
                }
            }
            else if (hp <= 0)
            {
                gameManager.destroyScore += 100;

                Destroy(gameObject);

                GameObject bulletExplosionGO = Instantiate(eplosionEff);
                bulletExplosionGO.transform.position = transform.position;


                gameManager.destroyScoreTxt.text = gameManager.destroyScore.ToString();

            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }
}
