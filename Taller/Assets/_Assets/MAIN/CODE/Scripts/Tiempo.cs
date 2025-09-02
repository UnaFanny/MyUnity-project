using UnityEngine;

public class Tiempo : MonoBehaviour
{
    [SerializeField]
    private GameManage gameManage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManage.SumarTiempo(5);
            Destroy(this.gameObject);
        }
    }
}
