using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Animator))]
public class ClicForAnimationStart : MonoBehaviour, IPointerClickHandler
{
    private Animator _animator;
    [SerializeField] 
    private string _animationName;

    public void OnPointerClick(PointerEventData eventData)
    {
        _animator.Rebind();
        _animator.Play(_animationName);
    }

    void Start()
    {
        _animator = GetComponent<Animator>();
    }
}
