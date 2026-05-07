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
        int randomx = 0;
        randomx = Random.Range(0,3);
        if(randomx == 0)
        {
            newPosition.x = -2;

        }else if(randomx == 1){
            newPosition.x = 0;
        }else{
            newPosition.x = 2;
        }
     
        newPosition.y = initialYValue;
        
        transform.position = newPosition;
        
    }
}
