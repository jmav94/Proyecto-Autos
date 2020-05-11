using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    private Image _colorImg;
    private Button _colorBtn;

    private void Awake()
    {
        _colorBtn = GetComponent<Button>();
        _colorImg = GetComponent<Image>();
    }

    private void Start()
    {
        _colorBtn.onClick.AddListener(() => GameManager.Instance.ChangeColor(_colorImg.color));
    }

}