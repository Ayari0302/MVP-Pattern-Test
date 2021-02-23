using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIMotionView : MonoBehaviour
{
    [SerializeField] private RawImage _hoverImage;
    [SerializeField] private Slider _slider;

    private void Awake()
    {
        // ObjectにEventTriggerコンポーネントを追加する
        var trigger = _hoverImage.gameObject.AddComponent<EventTrigger>();

        // 登録するイベントを設定する
        var entry = new EventTrigger.Entry {eventID = EventTriggerType.PointerEnter};

        entry.callback.AddListener((data) =>
        {
            ShowSlider();
            Debug.Log("PointerEnter");
        });

        trigger.triggers.Add(entry);

        entry = new EventTrigger.Entry {eventID = EventTriggerType.PointerExit};
        entry.callback.AddListener((data) =>
        {
            HideSlider();
            Debug.Log("PointerExit");
        });
        trigger.triggers.Add(entry);
    }

    private void HideSlider()
    {
        // スライダーを非表示にする
        _slider.gameObject.SetActive(false);
    }

    private void ShowSlider()
    {
        // スライダーを表示する
        _slider.gameObject.SetActive(true);
    }
}