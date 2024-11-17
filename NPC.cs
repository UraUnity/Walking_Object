using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 5; // 응응응응응응응응응응응응응응응응� 芬� 干� 응응응응응응응응응응응응응응응응응응 鷗쩨瑾農 考 勍촨 芬� 驥瑾菊 응응응응응응응응응응응응응응응응응응응응응응응응
    public int level = 1;
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
