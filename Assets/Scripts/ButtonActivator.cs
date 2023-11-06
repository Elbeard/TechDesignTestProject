using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActivator : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Button _batton;

    public void OnPointerClick(PointerEventData eventData)
    {
        _batton?.gameObject.SetActive(true);
    }
}
