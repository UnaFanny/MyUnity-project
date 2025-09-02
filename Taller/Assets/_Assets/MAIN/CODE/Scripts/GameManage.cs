using UnityEngine;
using UnityEngine.SceneManagement;

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



    private void Update()
    {

        if (_tiempo > 0f)
        {
            _tiempo -= Time.deltaTime;
            _tiempoEntero = (int)_tiempo;
            Debug.Log("Se acabó el tiempo!" + Mathf.CeilToInt(_tiempo));

        }
        else 
        {
            SceneManager.LoadScene(1);
        }
        if (_puntos >= 10 && Obstaculo != null)
        {
            Destroy(Obstaculo);
            Obstaculo = null;

        }
    }
    public void SumarPuntos(int cantidad)
    {
        _puntos += cantidad;
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
        }
    }

          public void SumarVidas(int cantidad)
    {
        _vida += cantidad;
    }
    public void SumarTiempo(int cantidad)
    {
        _tiempo += cantidad;
    }

}
