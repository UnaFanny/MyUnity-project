using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text tituloText;
    [SerializeField]
    private TMP_Text alertasText;

    [SerializeField]
    private TMP_InputField respuestaInput;

    [SerializeField]
    private Button enviarButton;

    [SerializeField]
    private int edad;

    [SerializeField]
    private Image[] spritesCorazon;

    [SerializeField]
    private int _vida = 5;

    [SerializeField]
    private int _puntos;

    [SerializeField]
    private float _tiempo = 60;

    [SerializeField]
    private bool _Llave = false;


    [SerializeField]
    private TMP_Text puntosText;
    [SerializeField]
    private TMP_Text vidaText;
    [SerializeField]
    private TMP_Text tiempoText;
    [SerializeField]
    private TMP_Text llavetext;





    int vida = 5;
    private void Start()
    {
        vidaText.text = "Vida: " + _vida;
        tiempoText.text = "Tiempo: " + _tiempo;
        puntosText.text = " x " + _puntos;
        llavetext.text = "Llave: " + _Llave;
        tituloText.text = "Hola, introduce tu edad";
        alertasText.text = "";
        enviarButton.onClick.AddListener(FuncionDelBoton);

        for (int i = 0; i < 4; i++)
        {
            spritesCorazon[i].enabled = false;
        }
    }
    public void FuncionDelBoton()
    {
        int edad = int.Parse(respuestaInput.textComponent.text);

    }
    


   
}