using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{
  public PuntosManager Puntos;
  void OnCollisionEnter(Collision col)
  {
          if (col.gameObject.CompareTag("Caja"))
        {
            Destroy(gameObject);
            Puntos.Pausa = false;
        }
  }
}
