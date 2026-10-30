using UnityEngine;

public class SmallShip : MonoBehaviour
{
    public float speed = 2;
    public GameObject bullet;
    public GameObject explosion;
    public float bulletTimer = 0;
    public float bulletWait = 3;
    public float moveTimer = 0;
    public float moveWait = 7;
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);

        bulletTimer += Time.deltaTime;
        moveTimer += Time.deltaTime;
        if (bulletTimer > bulletWait)
        {
            bulletTimer = 0;
            Instantiate(bullet, transform.position - new Vector3(0, .5f, 0), Quaternion.identity);
        }
        if (moveTimer > moveWait)
            moveTimer = 0;
        transform.Translate(transform.right * speed / 2 * Time.deltaTime);
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
            GameObject temp = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(temp, 1.0f);
            Destroy(gameObject);
        }
    }
}
