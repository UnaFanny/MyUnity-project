using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;


public class GameManage : MonoBehaviour
{
    [SerializeField]
    private int _vida = 5;

    [SerializeField]
    private int _puntos;

    [SerializeField]
    private float _tiempo = 60;

    [SerializeField]
    private int _tiempoEntero;

    [SerializeField] 
    private GameObject Obstaculo;

    [SerializeField]
    private bool _Llave = false;

    [SerializeField] 
    private GameObject panelMenu;

    [SerializeField]
    private TMP_Text puntosText;
    [SerializeField]
    private TMP_Text vidaText;
    [SerializeField]
    private TMP_Text tiempoText;
    [SerializeField]
    private TMP_Text llavetext;



    void Start()
    {
        vidaText.text = "Vida: " + _vida;
        tiempoText.text = "Tiempo: " + _tiempo;
        puntosText.text = " x " + _puntos;
        llavetext.text = "Llave: " + _Llave;
    }

   
    private void Update()
    {


        if (_tiempo > 0)
        {
            _tiempo -= Time.deltaTime;
            _tiempoEntero = (int)_tiempo;
            tiempoText.text = "Tiempo: " + _tiempoEntero;

        }
        else 
        {
            _tiempo = 0f;
            EstadoDelJuego("perdiste");
        }
        if (_puntos >= 10 && Obstaculo != null)
        {
            Destroy(Obstaculo);
            Obstaculo = null;

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EstadoDelJuego("pause");
            panelMenu.SetActive(true);
        }
    }
    public void SumarPuntos(int cantidad)
    {
        _puntos += cantidad;
        puntosText.text = " x " + _puntos;
    }



    public void RestarVida(int cantidad)
    {
        if (_vida <= 0)
        {
            EstadoDelJuego("perdiste");
        }
        else
        {
            _vida -= cantidad;
            vidaText.text = "Vida: " + _vida;
        }
    }

          public void SumarVidas(int cantidad)
    {
        _vida += cantidad;
        vidaText.text = "Vida: " + _vida;
    }
    public void SumarTiempo(int cantidad)
    {
        _tiempo += cantidad;
        //tiempoText.text = "Tiempo: " + _tiempo;

    }

    public void TomarLlave()
    {
        _Llave = true;
        llavetext.text = "Llave: " + _Llave;

    }
    public void LlegarAPuerta()
    {
        if (_Llave)
        {
            EstadoDelJuego("ganaste");
        }
        else
        {
            Debug.Log("Necesitas la llave para entrar.");
        }
    }
   
    public void EstadoDelJuego(string estado)
    {
        switch (estado)
        {
            case "play":
                Time.timeScale = 1;
                panelMenu.SetActive(true);

                break;
            case "pause":
                Time.timeScale = 0;
                panelMenu.SetActive(false);
                break;
            case "ganaste":
                SceneManager.LoadScene(2);
                break;
            case "perdiste":
                SceneManager.LoadScene(3); 
                break;
            case "salir":
                Application.Quit();
                break;
        }
    }


}
