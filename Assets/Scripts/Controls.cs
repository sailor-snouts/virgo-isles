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
                    ""name"": ""Turbo"",
                    ""type"": ""Button"",
                    ""id"": ""642d5d13-605a-475f-8a62-1926a42afdae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Anchor"",
                    ""type"": ""Button"",
                    ""id"": ""c286bae4-838a-47d3-89e7-9343f219142d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Bucket"",
                    ""type"": ""Button"",
                    ""id"": ""55621fa7-f25d-4e04-b0ce-1152cb547120"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cannon"",
                    ""type"": ""Button"",
                    ""id"": ""8a6a36e3-4140-4b96-be12-f98d0c791732"",
                    ""expectedControlType"": ""Button"",
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
                    ""path"": ""<Keyboard>/a"",
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
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SailsClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a5bb071-202b-4acd-a097-ad64e1b8d5b7"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turbo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cec14d9b-57b0-4ac9-a071-8a114bf6bce2"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45077adc-d931-4daa-93e5-bff043cae0ff"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bucket"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d5ffea6-d05d-45bd-903d-7a383c9e9302"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cannon"",
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
        m_Game_Turbo = m_Game.FindAction("Turbo", throwIfNotFound: true);
        m_Game_Anchor = m_Game.FindAction("Anchor", throwIfNotFound: true);
        m_Game_Bucket = m_Game.FindAction("Bucket", throwIfNotFound: true);
        m_Game_Cannon = m_Game.FindAction("Cannon", throwIfNotFound: true);
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
    private readonly InputAction m_Game_Turbo;
    private readonly InputAction m_Game_Anchor;
    private readonly InputAction m_Game_Bucket;
    private readonly InputAction m_Game_Cannon;
    public struct GameActions
    {
        private @Controls m_Wrapper;
        public GameActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Camera => m_Wrapper.m_Game_Camera;
        public InputAction @Pause => m_Wrapper.m_Game_Pause;
        public InputAction @SailsCounterClockwise => m_Wrapper.m_Game_SailsCounterClockwise;
        public InputAction @SailsClockwise => m_Wrapper.m_Game_SailsClockwise;
        public InputAction @Turbo => m_Wrapper.m_Game_Turbo;
        public InputAction @Anchor => m_Wrapper.m_Game_Anchor;
        public InputAction @Bucket => m_Wrapper.m_Game_Bucket;
        public InputAction @Cannon => m_Wrapper.m_Game_Cannon;
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
                @Turbo.started -= m_Wrapper.m_GameActionsCallbackInterface.OnTurbo;
                @Turbo.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnTurbo;
                @Turbo.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnTurbo;
                @Anchor.started -= m_Wrapper.m_GameActionsCallbackInterface.OnAnchor;
                @Anchor.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnAnchor;
                @Anchor.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnAnchor;
                @Bucket.started -= m_Wrapper.m_GameActionsCallbackInterface.OnBucket;
                @Bucket.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnBucket;
                @Bucket.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnBucket;
                @Cannon.started -= m_Wrapper.m_GameActionsCallbackInterface.OnCannon;
                @Cannon.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnCannon;
                @Cannon.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnCannon;
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
                @Turbo.started += instance.OnTurbo;
                @Turbo.performed += instance.OnTurbo;
                @Turbo.canceled += instance.OnTurbo;
                @Anchor.started += instance.OnAnchor;
                @Anchor.performed += instance.OnAnchor;
                @Anchor.canceled += instance.OnAnchor;
                @Bucket.started += instance.OnBucket;
                @Bucket.performed += instance.OnBucket;
                @Bucket.canceled += instance.OnBucket;
                @Cannon.started += instance.OnCannon;
                @Cannon.performed += instance.OnCannon;
                @Cannon.canceled += instance.OnCannon;
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
        void OnTurbo(InputAction.CallbackContext context);
        void OnAnchor(InputAction.CallbackContext context);
        void OnBucket(InputAction.CallbackContext context);
        void OnCannon(InputAction.CallbackContext context);
    }
}
