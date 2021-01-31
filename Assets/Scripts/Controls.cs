// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Game"",
            ""id"": ""0e32f06b-6459-40b3-85d5-1bc15d0d4e18"",
            ""actions"": [
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""93cba151-368f-4cfd-99a9-7f95f3224055"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""aa0bc436-2dc4-4845-9d57-595a05feecab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SailsCounterClockwise"",
                    ""type"": ""Value"",
                    ""id"": ""43be773c-a010-4325-8956-7e1a8cd6ccf4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SailsClockwise"",
                    ""type"": ""Button"",
                    ""id"": ""8e37b3e6-edc4-4359-b6d6-d49b5ba338cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerCounterClockwise"",
                    ""type"": ""Value"",
                    ""id"": ""891bace6-aee0-4e68-b2f6-9f79bb6ddc36"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerClockwise"",
                    ""type"": ""Value"",
                    ""id"": ""53ef2a52-c41a-4abd-9396-19df1026104b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aa3a46a0-37eb-40f6-984e-4197994a2d16"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49850d1c-a6e8-4018-86f6-f50d23a504a1"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc704a43-f503-4e66-a9e5-de6d42370d6a"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SailsCounterClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc90d17d-4571-4fde-b189-47f469f907fe"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SailsClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aaab645c-1329-46ed-8f32-1b2db5f5fb6d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerCounterClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53dbf559-2e0f-4fb0-9644-11580194cdba"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_Camera = m_Game.FindAction("Camera", throwIfNotFound: true);
        m_Game_Pause = m_Game.FindAction("Pause", throwIfNotFound: true);
        m_Game_SailsCounterClockwise = m_Game.FindAction("SailsCounterClockwise", throwIfNotFound: true);
        m_Game_SailsClockwise = m_Game.FindAction("SailsClockwise", throwIfNotFound: true);
        m_Game_PlayerCounterClockwise = m_Game.FindAction("PlayerCounterClockwise", throwIfNotFound: true);
        m_Game_PlayerClockwise = m_Game.FindAction("PlayerClockwise", throwIfNotFound: true);
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

    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_Camera;
    private readonly InputAction m_Game_Pause;
    private readonly InputAction m_Game_SailsCounterClockwise;
    private readonly InputAction m_Game_SailsClockwise;
    private readonly InputAction m_Game_PlayerCounterClockwise;
    private readonly InputAction m_Game_PlayerClockwise;
    public struct GameActions
    {
        private @Controls m_Wrapper;
        public GameActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Camera => m_Wrapper.m_Game_Camera;
        public InputAction @Pause => m_Wrapper.m_Game_Pause;
        public InputAction @SailsCounterClockwise => m_Wrapper.m_Game_SailsCounterClockwise;
        public InputAction @SailsClockwise => m_Wrapper.m_Game_SailsClockwise;
        public InputAction @PlayerCounterClockwise => m_Wrapper.m_Game_PlayerCounterClockwise;
        public InputAction @PlayerClockwise => m_Wrapper.m_Game_PlayerClockwise;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                @Camera.started -= m_Wrapper.m_GameActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnCamera;
                @Pause.started -= m_Wrapper.m_GameActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnPause;
                @SailsCounterClockwise.started -= m_Wrapper.m_GameActionsCallbackInterface.OnSailsCounterClockwise;
                @SailsCounterClockwise.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnSailsCounterClockwise;
                @SailsCounterClockwise.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnSailsCounterClockwise;
                @SailsClockwise.started -= m_Wrapper.m_GameActionsCallbackInterface.OnSailsClockwise;
                @SailsClockwise.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnSailsClockwise;
                @SailsClockwise.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnSailsClockwise;
                @PlayerCounterClockwise.started -= m_Wrapper.m_GameActionsCallbackInterface.OnPlayerCounterClockwise;
                @PlayerCounterClockwise.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnPlayerCounterClockwise;
                @PlayerCounterClockwise.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnPlayerCounterClockwise;
                @PlayerClockwise.started -= m_Wrapper.m_GameActionsCallbackInterface.OnPlayerClockwise;
                @PlayerClockwise.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnPlayerClockwise;
                @PlayerClockwise.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnPlayerClockwise;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @SailsCounterClockwise.started += instance.OnSailsCounterClockwise;
                @SailsCounterClockwise.performed += instance.OnSailsCounterClockwise;
                @SailsCounterClockwise.canceled += instance.OnSailsCounterClockwise;
                @SailsClockwise.started += instance.OnSailsClockwise;
                @SailsClockwise.performed += instance.OnSailsClockwise;
                @SailsClockwise.canceled += instance.OnSailsClockwise;
                @PlayerCounterClockwise.started += instance.OnPlayerCounterClockwise;
                @PlayerCounterClockwise.performed += instance.OnPlayerCounterClockwise;
                @PlayerCounterClockwise.canceled += instance.OnPlayerCounterClockwise;
                @PlayerClockwise.started += instance.OnPlayerClockwise;
                @PlayerClockwise.performed += instance.OnPlayerClockwise;
                @PlayerClockwise.canceled += instance.OnPlayerClockwise;
            }
        }
    }
    public GameActions @Game => new GameActions(this);
    public interface IGameActions
    {
        void OnCamera(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnSailsCounterClockwise(InputAction.CallbackContext context);
        void OnSailsClockwise(InputAction.CallbackContext context);
        void OnPlayerCounterClockwise(InputAction.CallbackContext context);
        void OnPlayerClockwise(InputAction.CallbackContext context);
    }
}
