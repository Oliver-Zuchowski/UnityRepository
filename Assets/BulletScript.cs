using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float bulletspeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += bulletspeed * transform.forward * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
       Health possiblevictim = collision.transform.GetComponent<Health>();
        if (possiblevictim)
        {
            possiblevictim.takeDamage(25);
        }
    }
}
