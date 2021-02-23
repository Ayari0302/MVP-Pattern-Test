using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIMotionView : MonoBehaviour
{
    [SerializeField] private GameObject _hoverPanel;
    [SerializeField] private Slider _slider;

    private void Awake()
    {
        // SliderにEventTriggerコンポーネントを追加する
        _hoverPanel.gameObject.AddComponent<EventTrigger>();

        // 処理を登録
        RegisterPointerEnter();
        RegisterPointerExit();
    }

    /// <summary>
    /// PointerEnterイベントに処理を登録する
    /// </summary>
    private void RegisterPointerEnter()
    {
        // PanelにEventTriggerコンポーネントを追加する
        var hoverTrigger = _hoverPanel.GetComponent<EventTrigger>();

        // 登録するイベントを設定する
        var entry = new EventTrigger.Entry {eventID = EventTriggerType.PointerEnter};

        entry.callback.AddListener((data) =>
        {
            ShowSlider();
            Debug.Log("PointerEnter");
        });

        hoverTrigger.triggers.Add(entry);
    }

    /// <summary>
    /// PointerExitイベントに処理を登録する
    /// </summary>
    private void RegisterPointerExit()
    {
        // PanelにEventTriggerコンポーネントを追加する
        var hoverTrigger = _hoverPanel.GetComponent<EventTrigger>();

        // 登録するイベントを設定する
        var entry = new EventTrigger.Entry {eventID = EventTriggerType.PointerExit};

        entry.callback.AddListener((data) =>
        {
            HideSlider();
            Debug.Log("PointerExit");
        });

        hoverTrigger.triggers.Add(entry);
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