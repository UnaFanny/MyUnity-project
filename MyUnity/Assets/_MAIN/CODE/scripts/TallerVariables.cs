using UnityEngine;
using TMPro;

public class TallerVariables : MonoBehaviour
{
    [Header("Variables C#")]

    [SerializeField]
    private int vida = 1;
    [SerializeField]
    private int puntaje = 200;
    [SerializeField]
    private int nivel = 29;

    public string nombre = "Dazai";
    [SerializeField]
    private float tiempo = 60.5f;
    [SerializeField]
    private bool isAlive = true;

    [Header("Variables Unity")]

    [SerializeField]
    private TMP_Text nombreText;
    [SerializeField]
    private TMP_Text vidaText;
    [SerializeField]
    private TMP_Text tiempoText;
    [SerializeField]
    private TMP_Text puntostext;
    [SerializeField]
    private TMP_Text estaVivotext;


    //Declarar las variables privadas y serializadas
    
    //Nombre
    //Vida
    //Tiempo
    //Puntos
    //EstaVivo

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nombreText.text = "Nombre: " + nombre;
        vidaText.text = "Vida: " + vida;
        tiempoText.text = "Tiempo: " + tiempo;
        puntostext.text = "Puntos: " + puntaje;
        estaVivotext.text = "Esta Vivo: " + isAlive;
        //Le voy a dar un valor a nuestras variables de texto = cadena texto + variables

        if (isAlive == true)
        {
            Debug.Log("Estoy vivo UwU");
        }
        else
        {
            Debug.Log("Estoy muerto X.X");
        }
        if (nombre == "Dazai")
        {
            Debug.Log("Hola Dazai :D");
        }
        else
        {
            Debug.Log("Hola señor");
        }
        if

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
