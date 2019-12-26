using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerGunController : MonoBehaviour, OtherInputs.IGunControlsActions{
    
    private OtherInputs _otherInputs;

    [SerializeField] private List<GameObject> activeFlares = new List<GameObject>();

    [SerializeField] private int _destroyFlareTime = 6;
    [SerializeField] private GameObject _flare = null;
    [SerializeField] private float _speed = 20;
    private void Awake() {
        _otherInputs = new OtherInputs();
        _otherInputs.GunControls.SetCallbacks(this);
    }
    private void OnEnable() {
        _otherInputs.GunControls.Enable();
        CursorLock.DisablePlayerControllersAction += PlayerControllerSwitch;
        BreadcrumbAi.Ai.ActiveFlaresFunc += ActiveFlareNumber;
    }
    private void OnDisable() {
        _otherInputs.GunControls.Disable();
        CursorLock.DisablePlayerControllersAction += PlayerControllerSwitch;
        BreadcrumbAi.Ai.ActiveFlaresFunc -= ActiveFlareNumber;
    }

    public void OnShoot(InputAction.CallbackContext context) {
        if(context.ReadValue<float>() == 1) {
            GameObject instantiatedFlare = Instantiate(_flare, transform.position, UnityEngine.Random.rotation);
            instantiatedFlare.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0, _speed));
            activeFlares.Add(instantiatedFlare);
            StartCoroutine(WaitAndDestroy(instantiatedFlare));
        }
    }

    private IEnumerator WaitAndDestroy(GameObject flare) {
        yield return new WaitForSeconds(_destroyFlareTime);
        Destroy(flare);
        activeFlares.Remove(flare);
    }

    private void PlayerControllerSwitch(bool state) {
        if (state) 
            _otherInputs.GunControls.Disable();
        else 
            _otherInputs.GunControls.Enable();
    }

    private int ActiveFlareNumber() {
        return activeFlares.Count;
    }
}
