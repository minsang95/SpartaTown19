using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSetting : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    [SerializeField] private Text PlayerName;
    [SerializeField] private Text PersonList;
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
        GameManager.Instance.Persons.Replace(GameManager.Instance.BefName, inputField.text+"\n");
        GameManager.Instance.BefName = inputField.text + "\n";
        transform.Find("NameChangedUI").gameObject.SetActive(false);
    }
    public void OnClickPersonListBtn()
    {
        transform.Find("PersonListUI").gameObject.SetActive(true);
        PersonList.text = GameManager.Instance.Persons.ToString();
    }
    public void OnClickPersonListEscBtn()
    {
        transform.Find("PersonListUI").gameObject.SetActive(false);
    }
}
