using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	public int puntosGanados = 5;
	public AudioClip itemSound;
	public float volumenClip = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Player") {
			NotificationCenter.DefaultCenter().PostNotification(this,"IncrementarPuntos",puntosGanados);
			AudioSource.PlayClipAtPoint(itemSound,Camera.main.transform.position,volumenClip);
			Destroy (gameObject);
		
		}

	}
}
