using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndaAnda : MonoBehaviour {

  public Vector3 movimento;
  void Start ()
  {
		
	}

	void Update ()
  {
    Vector3 translacao = new Vector3(movimento.x * Time.deltaTime,
                                     movimento.y * Time.deltaTime,
                                     movimento.z * Time.deltaTime);
    transform.Translate(translacao);
	}
}
