using UnityEngine;

public class Llave : MonoBehaviour
{
    [SerializeField]
    private GameManage gameManage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManage.TomarLlave();
            Destroy(gameObject); // la llave desaparece
        }
    }
}
