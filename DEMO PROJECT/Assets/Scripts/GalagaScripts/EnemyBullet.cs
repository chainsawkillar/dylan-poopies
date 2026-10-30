
using Unity.VisualScripting;
using UnityEngine;

public class BulletShip : MonoBehaviour
{
    public float speed = 3;
    public GameObject bullet;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet") || collision.gameObject.CompareTag("GalagaPlayer"))
        {
            if (collision.gameObject.CompareTag("PlayerBullet"))
                Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}