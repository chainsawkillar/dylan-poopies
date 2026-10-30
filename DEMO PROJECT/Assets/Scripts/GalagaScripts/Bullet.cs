using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);
        if (transform.position.y>10)
        {
            Destroy(gameObject);
        }
    }
}
