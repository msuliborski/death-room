using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject SpawnPoint;
    
    GameObject Player;

    public float firerate = 2f;
    //public float velocity = 2f;
    public float rotationOffset = 0.4f;
    
    bool flag = true;
    public AudioClip clip;
    AudioSource source;

    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        source = GetComponent<AudioSource>();
        source.clip = clip;
    }
    
    // Update is called once per frame
    void Update()
    {
        aim();
    }

    IEnumerator Cooldown(float time)
    {
        flag = false;
        yield return new WaitForSeconds(time);
        flag = true;
    }

    void aim()
    {
        Vector2 direction = (Player.transform.position - transform.position);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationOffset);

        if (flag)
        {
            direction.Normalize();
            if(Mathf.Abs((Player.transform.position-transform.position).magnitude)<50)
                {
                GameObject shot = (GameObject)Instantiate(Bullet, SpawnPoint.transform.position, Quaternion.identity);
                source.PlayOneShot(source.clip);
                shot.GetComponent<Rigidbody2D>().velocity = transform.right * 5f;
                Destroy(shot, 3f);
                StartCoroutine(Cooldown(0.2f));
            }
        }
    }
}