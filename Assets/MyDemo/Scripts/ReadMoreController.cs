using UnityEngine;
using UnityEngine.UIElements;

public class ReadMoreController : MonoBehaviour
{
    [SerializeField] private float collapsedHeight = 100f;

    private ScrollView scrollView;
    private Button readMoreButton;
    private Label descriptionLabel;

    private bool isExpanded = false;

    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        scrollView = root.Q<ScrollView>("TextContainer");
        readMoreButton = root.Q<Button>("ReadMoreButton");
        descriptionLabel = root.Q<Label>("ExpandableText");


        readMoreButton.clicked += ToggleReadMore;

        SetCollapsedState();
    }

    void ToggleReadMore()
    {
        isExpanded = !isExpanded;

        Debug.Log("Button Clicked! "+ isExpanded);

        if (isExpanded)
            SetExpandedState();
        else
            SetCollapsedState();

        scrollView.MarkDirtyRepaint();

    }

    private void SetCollapsedState()
    {
        scrollView.mode = ScrollViewMode.VerticalAndHorizontal; // keep vertical layout
        scrollView.verticalScrollerVisibility = ScrollerVisibility.Hidden;
        scrollView.horizontalScrollerVisibility = ScrollerVisibility.Hidden;

        // THIS is the key
        scrollView.verticalScroller.value = 0;
        scrollView.SetEnabled(false);   // disables all interaction

        scrollView.style.maxHeight = collapsedHeight;
        scrollView.style.overflow = Overflow.Hidden;

        readMoreButton.text = "Read More";
    }

    private void SetExpandedState()
    {
        scrollView.SetEnabled(true);

        scrollView.verticalScrollerVisibility = ScrollerVisibility.Auto;
        scrollView.horizontalScrollerVisibility = ScrollerVisibility.Auto;
        scrollView.style.maxHeight = StyleKeyword.None;
        scrollView.style.overflow = Overflow.Visible;

        readMoreButton.text = "Read Less";
    }

}
