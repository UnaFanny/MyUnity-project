using UnityEngine;
using TMPro;

public class variables : MonoBehaviour
{
    [Header ("Variables C#")]
    [SerializeField]
    private int vida = 1;
    [SerializeField]
    private int puntaje = 200;
    [SerializeField]
    private int nivel = 29;

    public string nombre = "Stefany";
    [SerializeField]
    private float tiempo = 60.5f;
    [SerializeField]
    private bool isAlive = true;

    [Header("Variables Unity")]

    [SerializeField]
    private TMP_Text mensaje;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mensaje.text = "Hola " + nombre + ", como estas?"; 
    }

    // Update is called once per frame
    void Update()
    {
        print("Hola Mundo!");
    }
}
