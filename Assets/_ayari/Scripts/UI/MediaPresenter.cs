using UnityEngine;

public class MediaPresenter : MonoBehaviour
{
    [SerializeField] private MediaModel _model;
    [SerializeField] private MediaView _view;

    private void Awake()
    {
        SendMessageModelToView();
        SendMessageViewToModel();
    }

    /// <summary>
    /// モデルのデータが変化したら、ビューに伝える
    /// </summary>
    private void SendMessageModelToView()
    {
    }

    /// <summary>
    /// ビューが変化したら、モデルに伝える
    /// </summary>
    private void SendMessageViewToModel()
    {
        // スライド(ビュー)を変更したら音量(モデル)を調整する
        _view.OnVolumeChanged.AddListener(volume => _model.SetVolume(volume));
    }
}