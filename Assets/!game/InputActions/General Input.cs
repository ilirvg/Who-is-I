// GENERATED AUTOMATICALLY FROM 'Assets/!game/InputActions/General Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GeneralInput : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @GeneralInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""General Input"",
    ""maps"": [
        {
            ""name"": ""BasicFPController"",
            ""id"": ""79b660a8-fe67-4816-9c1d-4e02495cf2a5"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""1991957b-3908-4db3-9de8-3a148ec76b93"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""Button"",
                    ""id"": ""6578530d-f4fe-4548-8fce-e0bc8bc58f8c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""Button"",
                    ""id"": ""544c2800-9150-468e-a8c1-a8a290f38dcd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""f0cea038-c8cd-47c2-acd1-0c48d7e9aadf"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""52bfb83b-312a-4098-8789-b29450ecfd56"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b411e344-a00c-4626-8d17-594df4bd5915"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8d60a035-5a76-4104-b846-66ea2758ac9c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b189a76a-107e-4a6f-8767-fc5f1ebe7ba5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b9b8de88-022e-4e3c-addf-a05b2094a36a"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5183122b-d965-483b-be94-b6692cccf689"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ClassicFPController"",
            ""id"": ""9e35f9b6-bf86-4294-a80d-2e9f6651e574"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8d567f5a-5d65-4789-90e6-02bff84cbd6b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Value"",
                    ""id"": ""228d79dc-6de1-4cd8-a6da-792a9f90daed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Value"",
                    ""id"": ""523f1fcc-df7a-4c0f-8c58-bb146dc3e7e0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a61e4e20-b0b6-497d-97aa-6375313a813c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee7e1dc0-8df9-4a6e-86b3-e32115f446e3"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0de81b88-8aa4-42e2-8a04-631513fe8762"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BasicFPController
        m_BasicFPController = asset.FindActionMap("BasicFPController", throwIfNotFound: true);
        m_BasicFPController_Move = m_BasicFPController.FindAction("Move", throwIfNotFound: true);
        m_BasicFPController_MouseX = m_BasicFPController.FindAction("MouseX", throwIfNotFound: true);
        m_BasicFPController_MouseY = m_BasicFPController.FindAction("MouseY", throwIfNotFound: true);
        // ClassicFPController
        m_ClassicFPController = asset.FindActionMap("ClassicFPController", throwIfNotFound: true);
        m_ClassicFPController_Jump = m_ClassicFPController.FindAction("Jump", throwIfNotFound: true);
        m_ClassicFPController_Crouch = m_ClassicFPController.FindAction("Crouch", throwIfNotFound: true);
        m_ClassicFPController_Run = m_ClassicFPController.FindAction("Run", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // BasicFPController
    private readonly InputActionMap m_BasicFPController;
    private IBasicFPControllerActions m_BasicFPControllerActionsCallbackInterface;
    private readonly InputAction m_BasicFPController_Move;
    private readonly InputAction m_BasicFPController_MouseX;
    private readonly InputAction m_BasicFPController_MouseY;
    public struct BasicFPControllerActions
    {
        private @GeneralInput m_Wrapper;
        public BasicFPControllerActions(@GeneralInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_BasicFPController_Move;
        public InputAction @MouseX => m_Wrapper.m_BasicFPController_MouseX;
        public InputAction @MouseY => m_Wrapper.m_BasicFPController_MouseY;
        public InputActionMap Get() { return m_Wrapper.m_BasicFPController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicFPControllerActions set) { return set.Get(); }
        public void SetCallbacks(IBasicFPControllerActions instance)
        {
            if (m_Wrapper.m_BasicFPControllerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BasicFPControllerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BasicFPControllerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BasicFPControllerActionsCallbackInterface.OnMove;
                @MouseX.started -= m_Wrapper.m_BasicFPControllerActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_BasicFPControllerActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_BasicFPControllerActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_BasicFPControllerActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_BasicFPControllerActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_BasicFPControllerActionsCallbackInterface.OnMouseY;
            }
            m_Wrapper.m_BasicFPControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
            }
        }
    }
    public BasicFPControllerActions @BasicFPController => new BasicFPControllerActions(this);

    // ClassicFPController
    private readonly InputActionMap m_ClassicFPController;
    private IClassicFPControllerActions m_ClassicFPControllerActionsCallbackInterface;
    private readonly InputAction m_ClassicFPController_Jump;
    private readonly InputAction m_ClassicFPController_Crouch;
    private readonly InputAction m_ClassicFPController_Run;
    public struct ClassicFPControllerActions
    {
        private @GeneralInput m_Wrapper;
        public ClassicFPControllerActions(@GeneralInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_ClassicFPController_Jump;
        public InputAction @Crouch => m_Wrapper.m_ClassicFPController_Crouch;
        public InputAction @Run => m_Wrapper.m_ClassicFPController_Run;
        public InputActionMap Get() { return m_Wrapper.m_ClassicFPController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ClassicFPControllerActions set) { return set.Get(); }
        public void SetCallbacks(IClassicFPControllerActions instance)
        {
            if (m_Wrapper.m_ClassicFPControllerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_ClassicFPControllerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ClassicFPControllerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ClassicFPControllerActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_ClassicFPControllerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_ClassicFPControllerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_ClassicFPControllerActionsCallbackInterface.OnCrouch;
                @Run.started -= m_Wrapper.m_ClassicFPControllerActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_ClassicFPControllerActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_ClassicFPControllerActionsCallbackInterface.OnRun;
            }
            m_Wrapper.m_ClassicFPControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
            }
        }
    }
    public ClassicFPControllerActions @ClassicFPController => new ClassicFPControllerActions(this);
    public interface IBasicFPControllerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
    }
    public interface IClassicFPControllerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
}
