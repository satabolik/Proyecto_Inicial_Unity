﻿using UnityEngine;
using System.Collections;

public class ActualizarGameOver : MonoBehaviour {
	public TextMesh total;
	public TextMesh record;
	public Puntuacion puntuacion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnEnable(){
		if (EstadoJuego.estadoJuego != null) {
			total.text = puntuacion.puntuacion.ToString();
			record.text = EstadoJuego.estadoJuego.puntuacionMaxima.ToString ();
		}
	}
}
