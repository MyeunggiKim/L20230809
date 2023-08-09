using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//���� ���� ���ư���. 
public class Bullet : MonoBehaviour
{

    public float speed = 1.0f;
    public Vector3 dir = Vector3.up;
    public GameObject bulletExplosion;

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision otherObject)
    {
        if (otherObject.gameObject.tag == "Player")
        {
            GameObject player = GameObject.Find("Player");

            if(player != null)
            {
                player.GetComponent<PlayerMove>().hp--;

                if (player.GetComponent<PlayerMove>().hp < 0)
                {
                    Destroy(otherObject.gameObject);
                }
            }
        }

        Destroy(gameObject);

        GameObject bulletExplosionGO = Instantiate(bulletExplosion);
        bulletExplosionGO.transform.position = transform.position;
    }
}
