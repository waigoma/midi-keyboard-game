//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/MidiKeyGame/Scripts/InputAction/MidiKeyInputAction.inputactions
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

public partial class @MidiKeyInputAction : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MidiKeyInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MidiKeyInputAction"",
    ""maps"": [
        {
            ""name"": ""MidiKeyMap"",
            ""id"": ""5f35d371-ca6a-4c52-a13f-033f83e280d7"",
            ""actions"": [
                {
                    ""name"": ""MidiKeyBoard"",
                    ""type"": ""Button"",
                    ""id"": ""98015a26-3b75-45e2-8ded-40c18b2f9a48"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""073bcc4b-ef75-438f-802c-225d4cb511a9"",
                    ""path"": ""<MidiDevice>/note060"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MidiKeyBoard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MidiKeyMap
        m_MidiKeyMap = asset.FindActionMap("MidiKeyMap", throwIfNotFound: true);
        m_MidiKeyMap_MidiKeyBoard = m_MidiKeyMap.FindAction("MidiKeyBoard", throwIfNotFound: true);
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

    // MidiKeyMap
    private readonly InputActionMap m_MidiKeyMap;
    private IMidiKeyMapActions m_MidiKeyMapActionsCallbackInterface;
    private readonly InputAction m_MidiKeyMap_MidiKeyBoard;
    public struct MidiKeyMapActions
    {
        private @MidiKeyInputAction m_Wrapper;
        public MidiKeyMapActions(@MidiKeyInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @MidiKeyBoard => m_Wrapper.m_MidiKeyMap_MidiKeyBoard;
        public InputActionMap Get() { return m_Wrapper.m_MidiKeyMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MidiKeyMapActions set) { return set.Get(); }
        public void SetCallbacks(IMidiKeyMapActions instance)
        {
            if (m_Wrapper.m_MidiKeyMapActionsCallbackInterface != null)
            {
                @MidiKeyBoard.started -= m_Wrapper.m_MidiKeyMapActionsCallbackInterface.OnMidiKeyBoard;
                @MidiKeyBoard.performed -= m_Wrapper.m_MidiKeyMapActionsCallbackInterface.OnMidiKeyBoard;
                @MidiKeyBoard.canceled -= m_Wrapper.m_MidiKeyMapActionsCallbackInterface.OnMidiKeyBoard;
            }
            m_Wrapper.m_MidiKeyMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MidiKeyBoard.started += instance.OnMidiKeyBoard;
                @MidiKeyBoard.performed += instance.OnMidiKeyBoard;
                @MidiKeyBoard.canceled += instance.OnMidiKeyBoard;
            }
        }
    }
    public MidiKeyMapActions @MidiKeyMap => new MidiKeyMapActions(this);
    public interface IMidiKeyMapActions
    {
        void OnMidiKeyBoard(InputAction.CallbackContext context);
    }
}