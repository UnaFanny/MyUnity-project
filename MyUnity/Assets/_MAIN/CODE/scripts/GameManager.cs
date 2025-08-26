using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int _vida = 10;

    [SerializeField]
    private int _puntos;

    [SerializeField]
    private float _tiempo;

    [SerializeField]
    private int _tiempoEntero;

    private void Update()
    {
        
        if (_tiempo > 0f)
        {
            _tiempo -= Time.deltaTime;
            _tiempoEntero = (int)_tiempo;
            Debug.Log("Se acabó el tiempo!" + Mathf.CeilToInt(_tiempo));

        }
    }
    public void SumarPuntos( int cantidad)
    {
        _puntos += cantidad;
    }
    


    public void RestarVida(int cantidad)
    {
        if ( _vida <= 0 )
        {
            SceneManager.LoadScene(1); 
        }
        else
        {
            _vida -= cantidad;
        }
           
    }
}
