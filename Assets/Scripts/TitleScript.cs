using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TitleScript : MonoBehaviour
{
    //DOSizeDelta(Vector2 to, float duration, bool snapping)
    [Header("Resize")]
    [SerializeField] private RectTransform title;
    [SerializeField] private Vector2 size;
    [Range(0,5)]
    [SerializeField] private float duration;
    [SerializeField] private bool snapping;

    [Header("Move")] 
    [SerializeField] private Vector2 endPlace;

    [Header("Button")] 
    [SerializeField] private Image playButton;
    [Range(0,1)]
    [SerializeField] private float fadeIn;

    void Start()
    {
        Shrink();
    }
    void Shrink()
    {
        title.DOSizeDelta(size, duration, snapping);
        title.DOAnchorPos(endPlace, duration, snapping);
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(duration / 2);
        playButton.DOFade(fadeIn, duration);
        this.gameObject.SetActive(false);
    }

}
