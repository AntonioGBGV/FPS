using UnityEngine;

public class BigBoss : MonoBehaviour
{
    public float health = 15.0f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            this.health--;
            Destroy(collision.gameObject);

            if (health < 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
