using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�� �Ǵ� �Ѿ��� �����Ǿ��� ���, �� ��ü�� �ı��Ѵ�.
public class DestroyZone : MonoBehaviour
{
    //�浹 ����
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
