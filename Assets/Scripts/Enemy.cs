using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//��ǥ1: �Ʒ� �������� �̵��Ѵ�.
//��ǥ2: �ٸ� �浹ü�� �ε������� �Ѵ� �ı��Ѵ�.
//��ǥ3: ���۽� 30%�� Ȯ���� �÷��̾ ���󰣴�.
//��ǥ4: 10������ Ȯ���� �÷��̾ ���󰣴�.
//��ǥ5: ���� �÷��̾ ���� ���� �ð����� �Ѿ��� ���.
//��ǥ6: �浹�� ���� ȿ���� �����Ѵ�.
//��ǥ7; �Ѿ˰� �浹�� hp ����, �÷��̾�� �浹�� �ı��Ѵ�.
public class Enemy : MonoBehaviour
{

    public float speed = 1.0f;
    public Vector3 dir = Vector3.down;
    int randValue;
    GameObject player;
    public GameObject eplosionEff;
    public int hp = 3;

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

    }

    //
    private void OnCollisionEnter(Collision otherObject)
    {
        hp--;

        if (hp < 0)
        {
            if (otherObject.gameObject.tag == "Player")
            {
                player.GetComponent<PlayerMove>().hp--;

                if(player.GetComponent<PlayerMove>().hp < 0)
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
        else if (hp<0)
        {
            Destroy(gameObject);

            Destroy(otherObject.gameObject);

            GameObject bulletExplosionGO = Instantiate(eplosionEff);
            bulletExplosionGO.transform.position = transform.position;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }
}
