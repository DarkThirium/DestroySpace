using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;

    // Update is called once per frame
    void Update()
    {
        float movimiento = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right *movimiento *velocidad*Time.deltaTime);
    }
}
