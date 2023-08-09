using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject bullet;
    float currentTime;
    public float creatTime=1;
    GameObject player;
    Vector3 playerDir;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        /*bullet.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        transform.rotation = Quaternion.Euler(playerDir);
        playerDir = (player.transform.position - gameObject.transform.position).normalized;
        transform.rotation = Quaternion.LookRotation(playerDir);
        transform.rotation *= Quaternion.Euler(90, 0, 0);*/
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            currentTime += Time.deltaTime;
         
            if (currentTime > creatTime)
            {
                GameObject bulletGO = Instantiate(bullet);
                bulletGO.tag = "EnemyBullet";
                bulletGO.layer = 10;

                bulletGO.transform.position = transform.position;

                playerDir = (player.transform.position - gameObject.transform.position).normalized;
                bulletGO.GetComponent<Bullet>().dir = playerDir;


                currentTime = 0;
            }
        }
    }
}
