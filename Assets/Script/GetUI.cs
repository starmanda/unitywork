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
        string[] files = Directory.GetFiles(folderPath, "*.jpg"); // 获取文件夹中所有png格式的图片文件

        if (files.Length > 0)
        {
            string randomImagePath = files[Random.Range(0, files.Length)]; // 从文件数组中随机选择一张图片路径
            byte[] fileData = File.ReadAllBytes(randomImagePath); // 读取图片文件的字节数据
            Texture2D texture = new Texture2D(2, 2);
            texture.LoadImage(fileData); // 加载图片数据到Texture2D

            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f)); // 创建Sprite

            image.sprite = sprite; // 将Sprite显示在Image上
        }
        else
        {
            Debug.LogError("No images found in the folder");
        }
    }
}
