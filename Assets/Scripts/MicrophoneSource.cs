using UnityEngine;
using System.Collections;

// ��� Audio Source ������Ēu��
[RequireComponent(typeof(AudioSource))]
public class MicrophoneSource : MonoBehaviour
{
    void Start()
    {
        // ��� Audio Source���擾
        var audio = GetComponent<AudioSource>();
        // Audio Source �� Audio Clip ���}�C�N���͂ɐݒ�
        // �����́A�f�o�C�X���inull �Ȃ�f�t�H���g�j�A���[�v�A���b��邩�A�T���v�����O���g��
        audio.clip = Microphone.Start(null, false, 3599, 44100);
        // �}�C�N�� Ready �ɂȂ�܂őҋ@�i��u�j
        while (Microphone.GetPosition(null) <= 0) { }
        // �Đ��J�n�i�^�����悩��Đ��A�X�s�[�J�[����o�͂���ƃn�E�����O���܂��j
        audio.Play();
    }
}