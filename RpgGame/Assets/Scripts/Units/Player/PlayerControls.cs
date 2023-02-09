// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Units/Player/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace RPG.Units.Player
{
    public class @PlayerControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GameMap"",
            ""id"": ""7b22a096-2e8d-40db-85e1-47f35ff25534"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""b206bd17-54db-45b4-95f1-c0341db992e8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FastAttack"",
                    ""type"": ""Button"",
                    ""id"": ""273c206d-c25b-4606-a7ab-23911fcd92c6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StrongAttack"",
                    ""type"": ""Button"",
                    ""id"": ""815e6048-209f-4345-a461-11891103c008"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2bafc0f5-6fd1-4d12-b082-5ba6756c69f7"",
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
                    ""id"": ""641ca18a-83e7-4f54-857e-3792f1cb14df"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c2c56eeb-41ff-4bde-89e4-5110afbf25f9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bacf9712-443b-45c6-beb7-8d491ec5e503"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1f810e89-5019-4dbb-9301-ab5e2264c22d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c5a401a5-67bb-41ef-8f07-7adcfda66444"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55255b39-60f4-4533-b874-bb965e4ccf87"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StrongAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // GameMap
            m_GameMap = asset.FindActionMap("GameMap", throwIfNotFound: true);
            m_GameMap_Movement = m_GameMap.FindAction("Movement", throwIfNotFound: true);
            m_GameMap_FastAttack = m_GameMap.FindAction("FastAttack", throwIfNotFound: true);
            m_GameMap_StrongAttack = m_GameMap.FindAction("StrongAttack", throwIfNotFound: true);
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

        // GameMap
        private readonly InputActionMap m_GameMap;
        private IGameMapActions m_GameMapActionsCallbackInterface;
        private readonly InputAction m_GameMap_Movement;
        private readonly InputAction m_GameMap_FastAttack;
        private readonly InputAction m_GameMap_StrongAttack;
        public struct GameMapActions
        {
            private @PlayerControls m_Wrapper;
            public GameMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_GameMap_Movement;
            public InputAction @FastAttack => m_Wrapper.m_GameMap_FastAttack;
            public InputAction @StrongAttack => m_Wrapper.m_GameMap_StrongAttack;
            public InputActionMap Get() { return m_Wrapper.m_GameMap; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameMapActions set) { return set.Get(); }
            public void SetCallbacks(IGameMapActions instance)
            {
                if (m_Wrapper.m_GameMapActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_GameMapActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_GameMapActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_GameMapActionsCallbackInterface.OnMovement;
                    @FastAttack.started -= m_Wrapper.m_GameMapActionsCallbackInterface.OnFastAttack;
                    @FastAttack.performed -= m_Wrapper.m_GameMapActionsCallbackInterface.OnFastAttack;
                    @FastAttack.canceled -= m_Wrapper.m_GameMapActionsCallbackInterface.OnFastAttack;
                    @StrongAttack.started -= m_Wrapper.m_GameMapActionsCallbackInterface.OnStrongAttack;
                    @StrongAttack.performed -= m_Wrapper.m_GameMapActionsCallbackInterface.OnStrongAttack;
                    @StrongAttack.canceled -= m_Wrapper.m_GameMapActionsCallbackInterface.OnStrongAttack;
                }
                m_Wrapper.m_GameMapActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @FastAttack.started += instance.OnFastAttack;
                    @FastAttack.performed += instance.OnFastAttack;
                    @FastAttack.canceled += instance.OnFastAttack;
                    @StrongAttack.started += instance.OnStrongAttack;
                    @StrongAttack.performed += instance.OnStrongAttack;
                    @StrongAttack.canceled += instance.OnStrongAttack;
                }
            }
        }
        public GameMapActions @GameMap => new GameMapActions(this);
        public interface IGameMapActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnFastAttack(InputAction.CallbackContext context);
            void OnStrongAttack(InputAction.CallbackContext context);
        }
    }
}
