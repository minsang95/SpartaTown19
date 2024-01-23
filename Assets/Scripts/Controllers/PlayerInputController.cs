using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : SpartaTownCharacterController
{
    [SerializeField]private SpriteRenderer characterRenderer;

    private void Awake()
    {
        
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;
        
        if(newAim.magnitude >= 0.9f)
        {
            CallLookEvent(newAim);
        }
        characterRenderer.flipX = newAim.x < 0;
    }
}
