using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileLaser : MonoBehaviour {
	
	bool isTriggered = false;
 	SpriteRenderer spriteRenderer;
    GameObject _player;
    public GameObject _lazerV;
    public GameObject _lazerH;
    bool flag = false;
    private AudioSource source;
    public AudioClip clip;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        source = GetComponent<AudioSource>();
        source.clip = clip;
    }

	void Update () {
        if (flag)
        {
            _lazerV.transform.position = new Vector2(_lazerV.transform.position.x - 0.03f, _lazerV.transform.position.y);
            _lazerH.transform.position = new Vector2(_lazerH.transform.position.x, _lazerH.transform.position.y + 0.03f);
        }
    }

	void OnTriggerEnter2D(Collider2D _colliderPlayer){
		if(!isTriggered){
			isTriggered = true;
            source.PlayOneShot(source.clip);
            flag = true;
            StartCoroutine(Cooldown());
            _lazerV.SetActive(true);
            _lazerH.SetActive(true);
            //spriteRenderer.color = new Color(0.1f, 0.4f, 0.255f, 1f);
            spriteRenderer.color = Color.red;
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
