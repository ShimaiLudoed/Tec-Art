using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class HighLighter2 : MonoBehaviour
{
    private MeshRenderer _mRenderer;

    [SerializeField] private Material default_m;
    [SerializeField] private Material highlight;

    private void Start()
    {
        _mRenderer = GetComponent<MeshRenderer>();
    }

    public void EnableHighlight(bool onOff)
    {
        if (_mRenderer != null && default_m != null && highlight != null)
        {
            _mRenderer.material = onOff ? highlight : default_m;
        }
    }

    private void OnMouseOver()
    {
        EnableHighlight(true);
    }

    private void OnMouseExit()
    {
        EnableHighlight(false);
    }
}
