using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour

{
    public CajaMovement cajaMovementScript;
    float initialYValue;
    public float VelocidadCaja = 2f;
    // Start is called before the first frame update
    void Start()
    {
      initialYValue = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-VelocidadCaja * Time.deltaTime ,0);
    }
    public void MoveBoxToRandomPosition()
    {
        Vector3 newPosition = transform.position;
        newPosition.y = initialYValue;
        transform.position = newPosition;
    }
}
