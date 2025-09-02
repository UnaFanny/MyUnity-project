using UnityEngine;

public class Trampa : MonoBehaviour
{
    [SerializeField]
    private GameManage gameManage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManage.RestarVida(1);

        }


    }
}
