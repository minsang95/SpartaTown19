using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YumyechanTutorTalk : MonoBehaviour
{
    [SerializeField] GameObject StartTalk;
    [SerializeField] GameObject Talk1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartTalk.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            StartTalk.gameObject.SetActive(false);
            Talk1.gameObject.SetActive(false);
        }
    }

    public void OnClickTalkStartBtn()
    {
        StartTalk.gameObject.SetActive(false);
        Talk1.gameObject.SetActive(true);
    }

    public void OnClickTalkEscBtn()
    {
        Talk1.gameObject.SetActive(false);
    }
}
