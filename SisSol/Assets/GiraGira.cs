using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraGira : MonoBehaviour {

  Vector3 rotacao;

  public float rotacaoX, rotacaoY, rotacaoZ;

	// Use this for initialization
	void Start ()
  {
    
	}
	
	// Update is called once per frame
	void Update ()
  {
    rotacao = new Vector3(rotacaoX * Time.deltaTime, 
                          rotacaoY * Time.deltaTime,
                          rotacaoZ * Time.deltaTime 
                         );
    transform.Rotate(rotacao);
	}
}
