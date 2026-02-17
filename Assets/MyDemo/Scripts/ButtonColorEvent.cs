using UnityEngine;
using UnityEngine.UIElements;

public class ButtonColorEvent : MonoBehaviour
{
    public Renderer renderer;

    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button btn1 = root.Q<Button>("Button1");
        Button btn2 = root.Q<Button>("Button2");
        Button btn3 = root.Q<Button>("Button2");
        Button btn4 = root.Q<Button>("Button4");

        btn1.clicked += () => SetColor(Color.red);
        btn2.clicked += () => SetColor(Color.orchid);
        btn3.clicked += () => SetColor(Color.pink);
        btn4.clicked += () => SetColor(Color.purple);
    }

    // Update is called once per frame
    private void SetColor(Color _Color)
    {
        renderer.material.color = _Color;
    }
}
