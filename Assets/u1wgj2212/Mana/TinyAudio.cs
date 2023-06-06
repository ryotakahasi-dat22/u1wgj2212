using UnityEngine;
public class TinyAudio : MonoBehaviour
{
    public static TinyAudio Instance { get; private set; }
    /// <summary>
    /// seList�ɐݒ肷����ʉ��̎�ނ��ȉ��ɒ�`���܂��B
    /// </summary>
    public enum SE
    {
        Click,
        Hit,
        Magic
    }
    [Tooltip("���ʉ���Audio Clip���ASE�̗񋓎q�Ɠ������ԂŐݒ肵�Ă��������B"), SerializeField]
    AudioClip[] seList;
    AudioSource audioSource;
    private void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }
    /// <summary>
    /// SE�Ŏw�肵�����ʉ����Đ����܂��B
    /// </summary>
    /// <param name="se">�炵�������ʉ�</param>
    public static void PlaySE(SE se)
    {
        Instance.audioSource.PlayOneShot(Instance.seList[(int)se]);
    }
}
