using UnityEngine;


public class TrampController : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManager.RestarVida(1);
            
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
