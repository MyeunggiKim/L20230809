using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int hp = 10;

    public GameObject bulletExplosion;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "EnemyBullet")
        {
            hp--;
            if (hp < 0)
            {
                if (other.gameObject.tag == "EnemyBullet")
                {
                    Destroy(gameObject);

                    GameObject bulletExplosionGO = Instantiate(bulletExplosion);
                    bulletExplosionGO.transform.position = transform.position;
                }
            }
        }
    }
}
