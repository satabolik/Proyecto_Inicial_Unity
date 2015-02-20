using UnityEngine;
using System.Collections;

public class Bloque : MonoBehaviour {
	public int puntosGanados = 1; 
	private bool haCollisionado = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (!haCollisionado && (collision.collider.gameObject.name == "PataInferiorDerechaB" || collision.collider.gameObject.name == "PataInferiorIzquierdaB")) {
			haCollisionado = true;
			NotificationCenter.DefaultCenter().PostNotification(this,"IncrementarPuntos",puntosGanados);
		}
	}
}