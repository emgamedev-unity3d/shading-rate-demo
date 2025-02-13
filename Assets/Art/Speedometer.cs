using UnityEngine;

public class Speedometer : MonoBehaviour
{
    public Rigidbody Car_RB;
    public float m_DegreePrSpeed;

    private RectTransform m_RectTransform;

    private float m_StartRotation;

    private float m_CurrentAngle;

    private float m_AngleVel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_RectTransform = GetComponent<RectTransform>();
        m_StartRotation = m_RectTransform.localRotation.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        float targetAngle = m_StartRotation - m_DegreePrSpeed * Car_RB.linearVelocity.magnitude;
        m_CurrentAngle = Mathf.SmoothDamp(m_CurrentAngle, targetAngle, ref m_AngleVel, 0.5f);
        m_RectTransform.localRotation = Quaternion.Euler(0, 0, m_CurrentAngle);
    }
}
