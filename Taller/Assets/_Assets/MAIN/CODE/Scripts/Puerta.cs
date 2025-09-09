using UnityEngine;


public class Puerta : MonoBehaviour
{
    [SerializeField] 
    private GameManage gameManage;
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManage.LlegarAPuerta();
        }
    }
}

