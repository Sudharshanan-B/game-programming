using UnityEngine;
using UnityEngine.UI;
public class ChangeSpriteColor : MonoBehaviour {
    public SpriteRenderer spriteRenderer;
    public Button colorButton;
    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        colorButton.onClick.AddListener(xyz);
    }
    void xyz() {
        spriteRenderer.color = Color.blue;
    }
}