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
    private TMP_Text tiempoText;
    [SerializeField]
    private Image imagenLlave;






    int vida = 5;
    private void Start()
    {
        tiempoText.text = "Tiempo: " + _tiempo;
        puntosText.text = " x " + _puntos;
        tituloText.text = "Hola, introduce tu edad";
        alertasText.text = "";
        enviarButton.onClick.AddListener(FuncionDelBoton);
        imagenLlave.gameObject.SetActive(false);

    }
    public void ActualizarCorazones(int vidasActuales)
    {
        for (int i = 0; i < spritesCorazon.Length; i++)
        {
            if (i < vidasActuales)
            {
                spritesCorazon[i].enabled = true; 
            }
            else
            {
                spritesCorazon[i].enabled = false; 
            }
        }
    }
    public void ActualizarImagenLlave(bool tieneLlave)
    {
        imagenLlave.gameObject.SetActive(tieneLlave);
    }
    public void FuncionDelBoton()
    {
        int edad = int.Parse(respuestaInput.textComponent.text);

    }
    


   
}
