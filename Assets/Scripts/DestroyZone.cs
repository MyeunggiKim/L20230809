using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//적 또는 총알이 감지되었을 경우, 그 물체를 파괴한다.
public class DestroyZone : MonoBehaviour
{
    //충돌 직전
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Bullet")
    //    {
    //        Destroy(other.gameObject);
    //    }

        
    //}

    private void OnCollisionEnter(Collision other)
    {      
        Destroy(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
