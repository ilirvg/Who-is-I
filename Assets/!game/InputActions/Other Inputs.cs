// GENERATED AUTOMATICALLY FROM 'Assets/!game/InputActions/Other Inputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @OtherInputs : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @OtherInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Other Inputs"",
    ""maps"": [
        {
            ""name"": ""OtherControls"",
            ""id"": ""100a1cf8-9f36-4a8a-9985-ae963a520914"",
            ""actions"": [
                {
                    ""name"": ""CursorLock"",
                    ""type"": ""Value"",
                    ""id"": ""98689bbb-67a1-4bb5-8fee-47dc0d107010"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9f53e385-1338-4e82-ad30-3f0b12994fe1"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CursorLock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GunControls"",
            ""id"": ""2d8259a8-94e8-4f6f-8528-0ed55ab77976"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Value"",
                    ""id"": ""48d909ee-4ffa-4392-a9e2-02031d4cf283"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6a5654a0-d6c2-4115-9ab4-6f84ae6a1eb6"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // OtherControls
        m_OtherControls = asset.FindActionMap("OtherControls", throwIfNotFound: true);
        m_OtherControls_CursorLock = m_OtherControls.FindAction("CursorLock", throwIfNotFound: true);
        // GunControls
        m_GunControls = asset.FindActionMap("GunControls", throwIfNotFound: true);
        m_GunControls_Shoot = m_GunControls.FindAction("Shoot", throwIfNotFound: true);
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

    // OtherControls
    private readonly InputActionMap m_OtherControls;
    private IOtherControlsActions m_OtherControlsActionsCallbackInterface;
    private readonly InputAction m_OtherControls_CursorLock;
    public struct OtherControlsActions
    {
        private @OtherInputs m_Wrapper;
        public OtherControlsActions(@OtherInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @CursorLock => m_Wrapper.m_OtherControls_CursorLock;
        public InputActionMap Get() { return m_Wrapper.m_OtherControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OtherControlsActions set) { return set.Get(); }
        public void SetCallbacks(IOtherControlsActions instance)
        {
            if (m_Wrapper.m_OtherControlsActionsCallbackInterface != null)
            {
                @CursorLock.started -= m_Wrapper.m_OtherControlsActionsCallbackInterface.OnCursorLock;
                @CursorLock.performed -= m_Wrapper.m_OtherControlsActionsCallbackInterface.OnCursorLock;
                @CursorLock.canceled -= m_Wrapper.m_OtherControlsActionsCallbackInterface.OnCursorLock;
            }
            m_Wrapper.m_OtherControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CursorLock.started += instance.OnCursorLock;
                @CursorLock.performed += instance.OnCursorLock;
                @CursorLock.canceled += instance.OnCursorLock;
            }
        }
    }
    public OtherControlsActions @OtherControls => new OtherControlsActions(this);

    // GunControls
    private readonly InputActionMap m_GunControls;
    private IGunControlsActions m_GunControlsActionsCallbackInterface;
    private readonly InputAction m_GunControls_Shoot;
    public struct GunControlsActions
    {
        private @OtherInputs m_Wrapper;
        public GunControlsActions(@OtherInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_GunControls_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_GunControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GunControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGunControlsActions instance)
        {
            if (m_Wrapper.m_GunControlsActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_GunControlsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GunControlsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GunControlsActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_GunControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public GunControlsActions @GunControls => new GunControlsActions(this);
    public interface IOtherControlsActions
    {
        void OnCursorLock(InputAction.CallbackContext context);
    }
    public interface IGunControlsActions
    {
        void OnShoot(InputAction.CallbackContext context);
    }
}
