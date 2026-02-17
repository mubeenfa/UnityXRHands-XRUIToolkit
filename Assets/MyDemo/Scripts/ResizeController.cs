using UnityEngine;
using UnityEngine.UIElements;

public class ResizeController : MonoBehaviour
{
    [SerializeField] private UIDocument targetDocument;
    [SerializeField] private UIDocument uiDocWithSlider;

    private Slider resizeSlider;

    private Vector3 initialScale;

    private float minValue = 0.5f;
    private float maxValue = 2f;
    private float midValue = 1f;

    private void OnEnable()
    {
        var root = uiDocWithSlider.rootVisualElement;
        resizeSlider = root.Q<Slider>("ResizeSlider");

        initialScale = targetDocument.transform.localScale;

        resizeSlider.lowValue = minValue;
        resizeSlider.highValue = maxValue;
        resizeSlider.value = midValue;

        resizeSlider.RegisterValueChangedCallback(OnResizeChanged);
    }

    private void OnResizeChanged(ChangeEvent<float> evt)
    {
        float multiplier = evt.newValue;
        targetDocument.transform.localScale = initialScale * multiplier;
    }
}
