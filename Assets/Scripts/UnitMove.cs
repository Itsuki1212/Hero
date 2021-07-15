using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UnitMove : MonoBehaviour
{
    [SerializeField]private InputAction m_inputMover;
    public Vector2 m_movementValue;
    public float m_fSpeed = 1.0f;

    private void OnEnable()
    {
        m_inputMover.Enable();
    }

    private void OnDisable()
    {
        m_inputMover.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_movementValue = m_inputMover.ReadValue<Vector2>();
        float fInputHorizontal = m_movementValue.x;
        float fInputVertical = m_movementValue.y;
        transform.Translate(fInputHorizontal * m_fSpeed, fInputVertical * m_fSpeed, 0.0f);

    }
}
