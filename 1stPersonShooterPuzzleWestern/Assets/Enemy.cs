using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public bool enemyHit = false;
    //public float health = 10f;
    public float speed = 20f;

    //public void TakeDamage(float amount)
    void Update()
    {
        if (enemyHit == true)
        {
            Spin();
        }
    }

    void Spin()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);

    }
}