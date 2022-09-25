using UnityEngine;

public class SortOrder : MonoBehaviour
{
    public int sortingOrder = 100;
    public Renderer vfxRenderer;
    public string layer;

    void OnValidate()
    {
        vfxRenderer = GetComponent<Renderer>();
        if (vfxRenderer)
        {
            vfxRenderer.sortingOrder = sortingOrder;
            vfxRenderer.sortingLayerName = layer;
        }
    }
}
