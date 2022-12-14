using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonSpell1BulletBehavior : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float Damage;

    private void Start()
    {
        rb.velocity = transform.up * speed;
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth playerHealth = hitInfo.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.PlayerTakeDamage(Damage);
        }
        this.GetComponent<Animator>().SetTrigger("IsHit");
        
    }
    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
    public void HitBoxOn()
    {
        this.GetComponent<Collider2D>().enabled = true;
    }
}
