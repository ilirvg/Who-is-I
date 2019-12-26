using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CursorLock : MonoBehaviour, OtherInputs.IOtherControlsActions {
    public static Action<bool> DisablePlayerControllersAction;

    private OtherInputs _otherInputs;
    private bool _isCursorActive = false;
    [SerializeField] private GameObject _escapeMenu;

    public GameObject npc;

    private void Awake() {
        _otherInputs = new OtherInputs();
        _otherInputs.OtherControls.SetCallbacks(this);
    }
    private void OnEnable() {
        _otherInputs.OtherControls.Enable();
    }
    private void OnDisable() {
        _otherInputs.OtherControls.Disable();
    }

    private void Start() {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        if (_escapeMenu != null) {
            _escapeMenu.SetActive(false);
        }
    }

    public void OnCursorLock(InputAction.CallbackContext context) {
        if (context.ReadValue<float>() != 1)
            return;

        _isCursorActive = !_isCursorActive;
        Cursor.visible = _isCursorActive;

        if (!_isCursorActive) {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else {
            Cursor.lockState = CursorLockMode.Confined;
        }

        if(_escapeMenu != null) {
            _escapeMenu.SetActive(_isCursorActive);
            npc.SetActive(!_isCursorActive);
            
            if (DisablePlayerControllersAction != null)
                DisablePlayerControllersAction(_isCursorActive);

          
        }

    }
}
