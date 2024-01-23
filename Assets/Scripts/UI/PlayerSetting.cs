using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSetting : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    [SerializeField ]private Text PlayerName;
    public void OnClickNameChangedBtn()
    {
        transform.Find("NameChangedUI").gameObject.SetActive(true);
    }
    public void OnClickNameSet()
    {
        if (!(2 < inputField.text.Length && inputField.text.Length < 10))
        {
            return;
        }
        PlayerName.text = inputField.text;

        transform.Find("NameChangedUI").gameObject.SetActive(false);
    }
}
