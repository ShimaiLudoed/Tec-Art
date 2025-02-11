using UnityEngine;

public class ObjectHighlighter : MonoBehaviour
{
    [SerializeField] private RectTransform highlightArea;
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    private Renderer _mRenderer;
    private Camera _mainCamera;

    private void Start()
    {
        _mRenderer = GetComponent<Renderer>();
        _mainCamera = Camera.main;

    }

    private void Update()
    {
        if (IsObjectUnderHighlightArea())
        {
            EnableHighlight(true);
        }
        else
        {
            EnableHighlight(false);
        }
    }

    private bool IsObjectUnderHighlightArea()
    {
        Vector3 screenPosition = _mainCamera.WorldToScreenPoint(transform.position);
        
        return RectTransformUtility.RectangleContainsScreenPoint(
            highlightArea,
            screenPosition,
            _mainCamera
        );
    }

    public void EnableHighlight(bool onOff)
    {
        if (_mRenderer != null && highlightMaterial != null && defaultMaterial != null)
        {
            _mRenderer.sharedMaterial = onOff ? highlightMaterial : defaultMaterial;
        }
    }
}