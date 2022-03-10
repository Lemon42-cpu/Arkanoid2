using System.Collections;
using UnityEngine;

public class MoonMove : MonoBehaviour
{
    [SerializeField]

    Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody.velocity = new Vector2 (Random.Range(4f,7f), Random.Range(4f,7f));
    }
//dd
    void OnCollisisonEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Lose"){
            Debug.Log("LUZ ");
        }
        if (col.gameObject.CompareTag("Block"))
            Destroy(col.gameObject);
    }
}
