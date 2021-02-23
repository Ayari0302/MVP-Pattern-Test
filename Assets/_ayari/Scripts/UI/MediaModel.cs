using UnityEngine;

public class MediaModel : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;

    // 音量
    private float _volume;

    public void SetVolume(float volume)
    {
        _volume = volume;
        _audio.volume = _volume;
        Debug.Log($"{volume}にモデル側で音量を変更しました。");
    }
}