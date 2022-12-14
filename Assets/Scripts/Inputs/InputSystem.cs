//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/InputSystem.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Inputs
{
    public partial class @InputSystem : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputSystem()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""Cooking"",
            ""id"": ""f6899943-84aa-461b-b3a9-47ff336d4920"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""387eaae6-734e-49d0-9ea0-526c73de79f0"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Put/Get"",
                    ""type"": ""Button"",
                    ""id"": ""90c1a76b-4200-438b-a791-5dc89d7094d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""952a1fbf-47ec-4011-88a9-bbf714b81bf5"",
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
                    ""id"": ""9b28037f-ba6e-4216-a2f7-0ffe433db87a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9e1bd6ac-73d3-4fa3-a889-2136dccc0f37"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e308fb0d-fdf1-4c0f-9036-2af0eeae5c8b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e33c8e1a-3cf2-4189-8e76-433c1b0b12c3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6994cae0-93f0-42aa-8350-5965b1ed23ad"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a35510cb-35c1-4e6c-b763-2a397456f539"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Put/Get"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7983cf28-e39c-49c5-ad1a-6e8b290fe83a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Put/Get"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
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
            ""devices"": []
        }
    ]
}");
            // Cooking
            m_Cooking = asset.FindActionMap("Cooking", throwIfNotFound: true);
            m_Cooking_Movement = m_Cooking.FindAction("Movement", throwIfNotFound: true);
            m_Cooking_PutGet = m_Cooking.FindAction("Put/Get", throwIfNotFound: true);
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
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Cooking
        private readonly InputActionMap m_Cooking;
        private ICookingActions m_CookingActionsCallbackInterface;
        private readonly InputAction m_Cooking_Movement;
        private readonly InputAction m_Cooking_PutGet;
        public struct CookingActions
        {
            private @InputSystem m_Wrapper;
            public CookingActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_Cooking_Movement;
            public InputAction @PutGet => m_Wrapper.m_Cooking_PutGet;
            public InputActionMap Get() { return m_Wrapper.m_Cooking; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CookingActions set) { return set.Get(); }
            public void SetCallbacks(ICookingActions instance)
            {
                if (m_Wrapper.m_CookingActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_CookingActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_CookingActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_CookingActionsCallbackInterface.OnMovement;
                    @PutGet.started -= m_Wrapper.m_CookingActionsCallbackInterface.OnPutGet;
                    @PutGet.performed -= m_Wrapper.m_CookingActionsCallbackInterface.OnPutGet;
                    @PutGet.canceled -= m_Wrapper.m_CookingActionsCallbackInterface.OnPutGet;
                }
                m_Wrapper.m_CookingActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @PutGet.started += instance.OnPutGet;
                    @PutGet.performed += instance.OnPutGet;
                    @PutGet.canceled += instance.OnPutGet;
                }
            }
        }
        public CookingActions @Cooking => new CookingActions(this);
        private int m_KeyboardSchemeIndex = -1;
        public InputControlScheme KeyboardScheme
        {
            get
            {
                if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
                return asset.controlSchemes[m_KeyboardSchemeIndex];
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
        public interface ICookingActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnPutGet(InputAction.CallbackContext context);
        }
    }
}
