using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light lightComponent;
    public InputActionReference action;
    private bool switched = false;
    void Start()
    {
        lightComponent = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += ToggleColor;
    }

    private void ToggleColor(InputAction.CallbackContext ctx) 
    {
        if(switched)
        {
            lightComponent.color = Color.white;
        }
        else{
            lightComponent.color = Color.red;
        }
        switched = !switched;
    }
}
