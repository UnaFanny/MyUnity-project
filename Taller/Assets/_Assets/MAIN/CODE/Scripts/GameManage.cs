using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManage : MonoBehaviour
{
    [SerializeField]
    private int _vida = 5;

    [SerializeField]
    private int _puntos;

    [SerializeField]
    private float _tiempo = 60f;

    [SerializeField]
    private int _tiempoEntero;

    [SerializeField] 
    private GameObject Obstaculo;

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

    void Start()
    {
        vidaText.text = "Vida: " + _vida;
        tiempoText.text = "Tiempo: " + _tiempo;
        puntosText.text = "Puntos: " + _puntos;
        llavetext.text = "Llave: " + _Llave;
    }

    public void TomarLlave()
    {
        _Llave = true;
        llavetext.text = "Llave: " + _Llave;
    }
    private void Update()
    {


        if (_tiempo > 0f)
        {
            _tiempo -= Time.deltaTime;
            _tiempoEntero = (int)_tiempo;
            Debug.Log("Se acabó el tiempo!" + Mathf.CeilToInt(_tiempo));
            tiempoText.text = "Tiempo: " + _tiempo;

        }
        else 
        {
            SceneManager.LoadScene(1);
        }
        if (_puntos >= 1 && Obstaculo != null)
        {
            Destroy(Obstaculo);
            Obstaculo = null;

        }
    }
    public void SumarPuntos(int cantidad)
    {
        _puntos += cantidad;
        puntosText.text = "Puntos: " + _puntos;
    }



    public void RestarVida(int cantidad)
    {
        if (_vida <= 0)
        {
            SceneManager.LoadScene(1);
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
        tiempoText.text = "Tiempo: " + _tiempo;

    }


}
