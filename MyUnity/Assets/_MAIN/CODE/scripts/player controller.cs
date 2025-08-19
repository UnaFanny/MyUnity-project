using System.Runtime.CompilerServices;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb2d;

    [SerializeField]
    private Vector2 direccion = new Vector2(0.5f, 0.5f);
    [SerializeField]
    private float fuerzaDeSalto = 200f;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();


    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb2d.AddForce(direccion * fuerzaDeSalto);

        }
        else
        {
            print("No oprimir la tecla Space");
        }
    }
}



