using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    [SerializeField] private GameObject information;
    [SerializeField] private GameObject selectCharacter;
    [SerializeField] private Image characterSprite;

    private CharacterType characterType;
    public void OnClickCharacter()
    {
        information.SetActive(false);
        selectCharacter.SetActive(true);
    }

    public void OnClickSelectCharacter(int index)
    {
        characterType = (CharacterType)index;
        var character = GameManager.Instance.CharacterList.Find(item=>item.Type == characterType);
        characterSprite.sprite = character.CharacterSprite;
        selectCharacter.SetActive(false);
        information.SetActive(true);
    }
    public void OnClickjoin()
    {
        if(!(2 < inputField.text.Length && inputField.text.Length < 10))
        {
            return;
        }
        GameManager.Instance.SetCharacter(characterType, name);
        
        Destroy(gameObject);
    }
}
