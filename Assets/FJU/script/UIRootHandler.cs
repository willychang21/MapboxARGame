using UnityEngine;

public class UIRootHandler : MonoBehaviour
{
    void Awake()
    {
        UIManager.Instance.m_CanvasRoot = gameObject;
    }
}