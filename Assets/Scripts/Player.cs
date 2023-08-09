using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int hp = 10;

    public GameObject bulletExplosion;

    public GameManager gameManager;
    Enemy enemy;

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
                    
                    GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
                    
                    gameManager.bestScore = gameManager.attackScore + gameManager.destroyScore;
                    gameManager.bestScoreTxt.text = gameManager.bestScore.ToString();

                    PlayerPrefs.SetInt("Best Score", gameManager.bestScore);
                }
            }
        }
    }
}
