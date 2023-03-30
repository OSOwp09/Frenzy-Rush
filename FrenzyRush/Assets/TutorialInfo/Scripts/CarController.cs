using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f; // velocidad inicial del vehículo
    public float brakeForce = 10f; // fuerza de frenado del vehículo
    private float currentSpeed; // velocidad actual del vehículo
    private bool isBraking = false; // indica si se está frenando o no

    void Start()
    {
        currentSpeed = speed;
    }

    void Update()
    {
        // Si se presiona la barra espaciadora, comienza el frenado gradual
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isBraking = true;
        }

        // Si se suelta la barra espaciadora, termina el frenado gradual
        //if (Input.GetKeyUp(KeyCode.Space))
       // {
           // isBraking = false;
         //   currentSpeed = speed;
       // }

        // Si se está frenando gradualmente, reduce la velocidad actual
        if (isBraking)
        {
            currentSpeed -= brakeForce * Time.deltaTime;
            currentSpeed = Mathf.Max(currentSpeed, 0f); // asegura que la velocidad no sea negativa
        }

        // Mueve el vehículo hacia adelante con la velocidad actual
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }
}
