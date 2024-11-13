using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateRay : MonoBehaviour {
    [SerializeField] GameObject m_leftRay;
    [SerializeField] GameObject m_rightRay;

    [SerializeField] InputActionProperty m_LeftActivate;
    [SerializeField] InputActionProperty m_RightActivate;

    [SerializeField] InputActionProperty m_LeftCancel;
    [SerializeField] InputActionProperty m_RightCancel;


    void Update() {
        m_leftRay.SetActive(m_LeftCancel.action.ReadValue<float>() == 0 && m_LeftActivate.action.ReadValue<float>() > 0.1);
        m_rightRay.SetActive(m_RightCancel.action.ReadValue<float>() == 0 && m_RightActivate.action.ReadValue<float>() > 0.1);

    }
}
