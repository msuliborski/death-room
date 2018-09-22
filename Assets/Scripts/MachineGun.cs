using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    public GameObject bullet;
    public float firerate = 0.5f;
    public float velocity = 15f;
    public float rotationOffset = 5f;
    bool flag = true;
    public GameObject inst;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; //zmienić na pozycję postaci
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationOffset * Time.deltaTime);

        if (flag)
        {
            direction.Normalize();
            GameObject shot = (GameObject)Instantiate(bullet, inst.transform.position, Quaternion.identity);
            shot.GetComponent<Rigidbody2D>().velocity = direction * velocity;
            StartCoroutine(Cooldown());
            Destroy(shot, 1);
        }
    }

    IEnumerator Cooldown()
    {
        flag = false;
        yield return new WaitForSeconds(firerate);
        flag = true;
    }
}