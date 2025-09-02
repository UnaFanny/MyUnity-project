using UnityEngine;

public class puntos : MonoBehaviour
{
    [SerializeField]
    private GameManage gameManage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManage.SumarPuntos(1);
            Destroy(this.gameObject);
        }
    }
}
