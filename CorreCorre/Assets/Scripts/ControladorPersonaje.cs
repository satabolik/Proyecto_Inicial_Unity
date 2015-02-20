using UnityEngine;
using System.Collections;

public class ControladorPersonaje : MonoBehaviour {
	public float fuerzaSalto = 100f;
	public Transform comprobadorSuelo;
	public LayerMask mascaraSuelo;
	public float velocidad = 1.5f;
	private float comprobadorRadio = 0.07f;
	private bool enSuelo = true;
	private bool dobleSalto = false;
	private Animator anim;
	private bool corriendo = false;

	void Awake(){
		anim = GetComponent<Animator> ();
	}
	// Use this for initialization
	void Start () {
	
	}
	void FixedUpdate(){
		if (corriendo) {
			rigidbody2D.velocity = new Vector2(velocidad,rigidbody2D.velocity.y);
		}
		enSuelo = Physics2D.OverlapCircle (comprobadorSuelo.position, comprobadorRadio,mascaraSuelo);
		anim.SetBool ("isGrounded", enSuelo);
		anim.SetFloat ("VelX", rigidbody2D.velocity.x);
		if (enSuelo){
			dobleSalto = true;
		}

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			if (corriendo){
				if (enSuelo || dobleSalto){
					audio.Play();
					rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x,fuerzaSalto);
					if (!enSuelo && dobleSalto){
						dobleSalto = false;
					}
				}
			}
			else{
				corriendo = true;
				NotificationCenter.DefaultCenter().PostNotification(this,"PersonajeEmpiezaACorrer");
			}
		}


	}
}
