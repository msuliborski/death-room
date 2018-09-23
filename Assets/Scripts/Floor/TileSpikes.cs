using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpikes : MonoBehaviour {
	
	bool isTriggered = false;
 	SpriteRenderer spriteRenderer;
    public GameObject boom;
    public GameObject collider;
    public AudioClip peep;
    AudioSource source;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        source = GetComponent<AudioSource>();
        source.clip = peep;
    }

	void Update () {

	}

	void OnTriggerEnter2D(Collider2D _colliderPlayer){
		if(!isTriggered){
			isTriggered = true;
            //spriteRenderer.color = new Color(0.1f, 0.4f, 0.255f, 1f);
            StartCoroutine(boobyTrap());
        	spriteRenderer.color = Color.grey;
	 	}
	}

    IEnumerator boobyTrap()
    {
        source.PlayOneShot(source.clip);
        yield return new WaitForSeconds(0.5f);
        collider.SetActive(true);
        Instantiate(boom, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        collider.SetActive(false);

    }
}
