using UnityEngine;
using UnityEngine.UIElements;

public class GestureUIUpdater : MonoBehaviour
{

    [SerializeField] private UIDocument document;
    private Label gestureLabel;

    private void OnEnable()
    {
        var root = document.rootVisualElement;

        gestureLabel = root.Q<Label>("HandGestureText");
    }

    public void SetGestureText(string msg)
    {
        if(gestureLabel != null)
        {
            gestureLabel.text = msg;
        }
    }
}
