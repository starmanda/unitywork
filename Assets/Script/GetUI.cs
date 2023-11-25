using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GetUI : MonoBehaviour
{
    public Image image;
    public string folderPath;

    void Start()
    {
        LoadRandomImage();
    }

    void LoadRandomImage()
    {
        string[] files = Directory.GetFiles(folderPath, "*.jpg"); // ��ȡ�ļ���������png��ʽ��ͼƬ�ļ�

        if (files.Length > 0)
        {
            string randomImagePath = files[Random.Range(0, files.Length)]; // ���ļ����������ѡ��һ��ͼƬ·��
            byte[] fileData = File.ReadAllBytes(randomImagePath); // ��ȡͼƬ�ļ����ֽ�����
            Texture2D texture = new Texture2D(2, 2);
            texture.LoadImage(fileData); // ����ͼƬ���ݵ�Texture2D

            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f)); // ����Sprite

            image.sprite = sprite; // ��Sprite��ʾ��Image��
        }
        else
        {
            Debug.LogError("No images found in the folder");
        }
    }
}
