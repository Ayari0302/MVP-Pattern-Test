using UnityEngine;
using UnityEngine.UI;

public class MediaView : MonoBehaviour
{
    [SerializeField] private Slider _volumeBar;

    public FloatEvent OnVolumeChanged = new FloatEvent();


    private void Awake()
    {
        RegisterSlider();
    }

    /// <summary>
    /// 音量スライドバーに処理を登録
    /// UnityEventでスライダーの値を音量として送る
    /// </summary>
    private void RegisterSlider()
    {
        _volumeBar.onValueChanged.AddListener(volume => OnVolumeChanged.Invoke(volume));
    }
}