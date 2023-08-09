using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject skillItem;
    public float creatTime;
    public float minCreateTime = 3;
    public float maxCreateTime = 10;
    float currentTime;

    private void Start()
    {
        creatTime = UnityEngine.Random.Range(minCreateTime, maxCreateTime);
    }

    // Update is called once per frame
    void Update()
    {
        creatTime += Time.deltaTime;

        if (currentTime < creatTime)
        {
            GameObject skillItemGO = Instantiate(skillItem);

            skillItemGO.transform.position = transform.position;

            creatTime = 0;

            currentTime = Random.Range(minCreateTime, maxCreateTime);
        }
    }
}
