using UnityEngine;
using UnityEngine.SceneManagement;

public class TrampController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
        
            SceneManager.LoadScene("condicionales");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
