using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PersonCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameManager.Instance.Persons.Append($"{GameManager.Instance.PlayerName.text}\n");
            GameManager.Instance.BefName = $"{GameManager.Instance.PlayerName.text}\n";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameManager.Instance.Persons.Replace(GameManager.Instance.BefName, "");
        }
    }
}
