using UnityEngine;

public class MonedaContorller : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManager.SumarPuntos(1);
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
