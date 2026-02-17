using UnityEngine;
using UnityEngine.UIElements;

public class OpacityController : MonoBehaviour
{
    [SerializeField] private UIDocument[] targetDocuments;
    [SerializeField]  private UIDocument uiDocWithSlider;

    public float minValue = 0.1f;
    public float maxValue = 1f;
    public float midValue = 0.5f;

    private Slider opacitySlider;

    void OnEnable()
    {
        var root = uiDocWithSlider.rootVisualElement;

        //rootContainer = root.Q<VisualElement>("RootContainer");
        opacitySlider = root.Q<Slider>("OpacitySlider");

        opacitySlider.lowValue = minValue;
        opacitySlider.highValue = maxValue;
        opacitySlider.value = midValue;

        opacitySlider.RegisterValueChangedCallback(OnSliderUpdated);
    }


    void OnSliderUpdated(ChangeEvent<float> evt)
    {
        float alpha = evt.newValue;

        foreach (var doc in targetDocuments)
        {
            if (doc == null) return;

            var root = doc.rootVisualElement;

            root.style.opacity = alpha;

            root.pickingMode = alpha <= minValue ? PickingMode.Ignore : PickingMode.Position;
        }

        
    }
}
