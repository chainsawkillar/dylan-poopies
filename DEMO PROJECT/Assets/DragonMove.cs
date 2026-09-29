using UnityEngine;

public class DragonMove : MonoBehaviour
{
    public float speed = 5;
    public bool goingUp = true;

    private float ratWait = 1, fireballWait = 2, whatsappWait = 8;
    private float ratTimer = 0, fireballTimer = 0, whatsappTimer = 0;
    public GameObject rat;
    public GameObject fireball;
    public GameObject whatsapp;

    

    void Update()
    {
        ratTimer += Time.deltaTime;
        fireballTimer += Time.deltaTime;
        whatsappTimer += Time.deltaTime;

        if(ratTimer > ratWait)
        {
            Instantiate(rat, transform.position, Quaternion.identity);
            ratTimer = 0;
            ratWait = Random.Range(1f, 2f);
        }
        if (fireballTimer > fireballWait)
        {
            Instantiate(fireball, transform.position, Quaternion.identity);
            fireballTimer = 0;
            fireballWait = Random.Range(2f, 3f);
        }
        if (whatsappTimer > whatsappWait)
        {
            Instantiate(whatsapp, transform.position, Quaternion.identity);
            whatsappTimer = 0;
            whatsappWait = Random.Range(5f, 10f);
        }
        transform.Translate(transform.up * speed * Time.deltaTime);

        if(transform.position.y > 4 && goingUp == true)
        {
            goingUp = false;
            speed *= -1;
        }
        if (transform.position.y < -4 && goingUp == false)
        {
            goingUp = true;
            speed *= -1;
        }
    }
}
