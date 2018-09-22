using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazers : MonoBehaviour {

    GameObject _player;
	public GameObject _lazerV;
	public GameObject _lazerH;
    bool flag = false;
    private AudioSource source;
    public AudioClip clip;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = clip;
        source.PlayOneShot(source.clip);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 5)
        {
            source.PlayOneShot(source.clip);
            flag = true;
            StartCoroutine(Cooldown());
            _lazerV.SetActive(true);
            _lazerH.SetActive(true);
        }
    }
    void Update()
    {
        if(flag)
        {
            _lazerV.transform.position = new Vector2(_lazerV.transform.position.x - 0.03f, _lazerV.transform.position.y);
            _lazerH.transform.position = new Vector2(_lazerH.transform.position.x, _lazerH.transform.position.y + 0.03f);
        }
    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(0.6f);
        flag = false;
        _lazerV.SetActive(false);
        _lazerV.transform.position = new Vector2(0.5f, 0);
        _lazerH.SetActive(false);
        _lazerH.transform.position = new Vector2(0, -0.5f);
    }
}
