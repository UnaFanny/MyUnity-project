using UnityEngine;

public class Vida : MonoBehaviour
{
    [SerializeField]
    private GameManage gameManage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManage.SumarVidas(1);
            Destroy(this.gameObject);
        }
    }
}
