using System.Runtime.CompilerServices;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb2d;


   
    [SerializeField]
    private float fuerzaDeSalto = 200f;
    [SerializeField] 
    private float velocidadX = 3f;


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb2d.AddForce(Vector2.up  * fuerzaDeSalto);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddForce(Vector2.left * velocidadX);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddForce(Vector2.right * velocidadX);
        }
    }
}



   