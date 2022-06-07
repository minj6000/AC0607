// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/InputTest.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputTest : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputTest()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputTest"",
    ""maps"": [
        {
            ""name"": ""PlayerWalk"",
            ""id"": ""1dc782ad-d93c-4659-9c64-20c46b6b7c8c"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""7314ea1a-cdf1-4315-8285-316b0e81a006"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""70699fa8-6bed-4c53-aecb-187e6c33561a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dcdb56d2-2611-4300-b470-7cd3cbb88080"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""dc7aac04-8e66-4e0d-816e-5793829bd6c6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""916e66df-ff6d-453e-88cb-f7878a06f402"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6600dbee-26b8-42d6-ad2c-55a9269cdcca"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""22d4707a-7b2b-43a9-b669-2af87abd6f45"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2e4e294e-fa57-4364-bb0e-9d9e1e85b7b4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bc278050-ded9-4180-bbe7-a8a425451a30"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""keyboard"",
            ""bindingGroup"": ""keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerWalk
        m_PlayerWalk = asset.FindActionMap("PlayerWalk", throwIfNotFound: true);
        m_PlayerWalk_Jump = m_PlayerWalk.FindAction("Jump", throwIfNotFound: true);
        m_PlayerWalk_Movement = m_PlayerWalk.FindAction("Movement", throwIfNotFound: true);
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

    // PlayerWalk
    private readonly InputActionMap m_PlayerWalk;
    private IPlayerWalkActions m_PlayerWalkActionsCallbackInterface;
    private readonly InputAction m_PlayerWalk_Jump;
    private readonly InputAction m_PlayerWalk_Movement;
    public struct PlayerWalkActions
    {
        private @InputTest m_Wrapper;
        public PlayerWalkActions(@InputTest wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PlayerWalk_Jump;
        public InputAction @Movement => m_Wrapper.m_PlayerWalk_Movement;
        public InputActionMap Get() { return m_Wrapper.m_PlayerWalk; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerWalkActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerWalkActions instance)
        {
            if (m_Wrapper.m_PlayerWalkActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerWalkActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerWalkActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerWalkActionsCallbackInterface.OnJump;
                @Movement.started -= m_Wrapper.m_PlayerWalkActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerWalkActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerWalkActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayerWalkActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayerWalkActions @PlayerWalk => new PlayerWalkActions(this);
    private int m_keyboardSchemeIndex = -1;
    public InputControlScheme keyboardScheme
    {
        get
        {
            if (m_keyboardSchemeIndex == -1) m_keyboardSchemeIndex = asset.FindControlSchemeIndex("keyboard");
            return asset.controlSchemes[m_keyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerWalkActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
}
