using UnityEngine;
using UnityEngine.InputSystem;

public class FpController : MonoBehaviour, GeneralInput.IBasicFPControllerActions, GeneralInput.IClassicFPControllerActions {
    public GeneralInput inputControls;
    private CharacterController _characterController;
    private bool _changeCrouch = false;

    //Move variables
    private Vector2 _moveAxis;
    [SerializeField] private float _walkSpeed = 5;
    [SerializeField] private float _strafingSpeed = 5;

    //Rotation variables
    [SerializeField] private float _horizontalSensitivity = 2;
    [SerializeField] private float _verticalSensitivity = 2;

    //Vertical look variables
    private Transform _fpCamera = null;
    private float _cameraAngle = 0;
    [SerializeField] private float _minCameraAngle = -89;
    [SerializeField] private float _maxCameraAngle = 89;
    

    //Jump variables
    private float _isJumping = 0;
    private Vector3 _jumpVector;
    [SerializeField] private float _jumpSpeed = 18;
    [SerializeField] private float _gravityMultiplier = 1.3f;
    [SerializeField] private float _jumpWalkSpeed = 1;
    [SerializeField] private float _jumpStrafingSpeed = 0.5f;

    //Crouch variables
    private float _isCrouching;
    private bool _isCrouchingBlocked;

    private void Awake() {
        inputControls = new GeneralInput();
        inputControls.BasicFPController.SetCallbacks(this);
        inputControls.ClassicFPController.SetCallbacks(this);
    }

    private void OnEnable() {
        inputControls.BasicFPController.Enable();
        inputControls.ClassicFPController.Enable();
        CursorLock.DisablePlayerControllersAction += PlayerControllerSwitch;
    }

    private void OnDisable() {
        inputControls.BasicFPController.Disable();
        inputControls.ClassicFPController.Disable();
        CursorLock.DisablePlayerControllersAction -= PlayerControllerSwitch;
    }

    private void Start() {
        _fpCamera = GetComponentInChildren<Camera>().transform;
        _characterController = GetComponent<CharacterController>();
    }

    private void Update() {
        PlayerMovment();
        if (_isCrouching > 0)
            CheckCrouchBlock();
    }

    private void PlayerMovment() {
        Vector3 _movment = Vector3.zero;
        if (_characterController.isGrounded) {
            _movment += transform.forward * _moveAxis.y * _walkSpeed;
            _movment += transform.right * _moveAxis.x * _strafingSpeed;
        }
        else {
            _movment += transform.forward * _moveAxis.y * _jumpWalkSpeed;
            _movment += transform.right * _moveAxis.x * _jumpStrafingSpeed;
        }

        _movment += Physics.gravity * _gravityMultiplier;
        _movment = PlayerJump(_movment);
        _characterController.Move(_movment);
    }

    private Vector3 PlayerJump(Vector3 _movment) {
        if (_characterController.isGrounded) {
            _jumpVector = Vector3.Lerp(_jumpVector, Vector3.zero, 5 * Time.deltaTime);
            if (_isJumping > 0) {
                _jumpVector = _movment;
                _jumpVector.y = _jumpSpeed;
                _isJumping = 0;
            }
        }
        else {
            _jumpVector += Physics.gravity * _gravityMultiplier * Time.deltaTime;
        }

        _movment += _jumpVector;
        _movment *= Time.deltaTime;
        return _movment;
    }

    private void CheckCrouchBlock() {
        RaycastHit _hit;
        if (Physics.Raycast(_fpCamera.position, Vector3.up, out _hit, 1.1f)) {
            _isCrouchingBlocked = true;
        }
        else {
            _isCrouchingBlocked = false;
            if (_changeCrouch) {
                _changeCrouch = false;
                _isCrouching = 0;
                ChangeCrouchState(2, new Vector3(0, 1, 0), new Vector3(0, 1.5f, 0));
            }
        }
    }

    public void OnMove(InputAction.CallbackContext context) {
        _moveAxis = context.ReadValue<Vector2>();
    }

    public void OnMouseX(InputAction.CallbackContext context) {
        float _yRotate = context.ReadValue<float>();
        Vector3 _rotate = new Vector3(0, _yRotate, 0) * _horizontalSensitivity * Time.deltaTime;
        transform.Rotate(_rotate);
    }

    public void OnMouseY(InputAction.CallbackContext context) {
        _cameraAngle += context.ReadValue<float>() * _verticalSensitivity * Time.deltaTime;
        _cameraAngle = Mathf.Clamp(_cameraAngle, _minCameraAngle, _maxCameraAngle);
        _fpCamera.localEulerAngles = new Vector3(-_cameraAngle, 0, 0);
    }

    public void OnJump(InputAction.CallbackContext context) {
        if (_characterController.isGrounded)
            _isJumping = context.ReadValue<float>();
    }

    public void OnCrouch(InputAction.CallbackContext context) {
        if (_isCrouchingBlocked) {
            if (context.ReadValue<float>() != 0)
                _changeCrouch = false;
            else
                _changeCrouch = true;
            return;
        }

        _isCrouching = context.ReadValue<float>();
        if (_isCrouching > 0)
            ChangeCrouchState(1.5f, new Vector3(0, 0.75f, 0), new Vector3(0, 1, 0));
        else
            ChangeCrouchState(2, new Vector3(0, 1, 0), new Vector3(0, 1.5f, 0));
    }

    private void ChangeCrouchState(float h, Vector3 c, Vector3 p) {
        _characterController.height = h;
        _characterController.center = c;
        _fpCamera.localPosition = p;
    }

    public void OnRun(InputAction.CallbackContext context) {
        if (context.ReadValue<float>() != 0) {
            _walkSpeed *= 2f;
            _strafingSpeed *= 2f;
            _jumpSpeed += 1;
        }
        else {
            _walkSpeed /= 2f;
            _strafingSpeed /= 2f;
            _jumpSpeed -= 1;
        }
    }

    private void PlayerControllerSwitch(bool state) {
        if (state) {
            inputControls.BasicFPController.Disable();
            inputControls.ClassicFPController.Disable();
        }
        else {
            inputControls.BasicFPController.Enable();
            inputControls.ClassicFPController.Enable();
        }
    }
}
