using UnityEngine;
using UnityEngine.EventSystems;

public class Coin_Tap : MonoBehaviour,IPointerDownHandler
{
    [SerializeField] private Material[] _materialToChange;
    private int _numberOfMaterial = 1;
    [SerializeField] private MeshRenderer _meshRenderer;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject.name == "PirateCoin")
        {
            _meshRenderer.material = _materialToChange[_numberOfMaterial];
            _numberOfMaterial++;
            if (_numberOfMaterial >= _materialToChange.Length)
                _numberOfMaterial = 0;
        }
    }
}
