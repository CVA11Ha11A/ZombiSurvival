using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
// runtime�� �ƴ� editor time ����Ǵ� Ȯ���ڵ��� �ִ�.
using UnityEditor;

public class ResManager : MonoBehaviour
{
    public static ResManager m_instance;

    public static ResManager instance
    {
        get
        {
            // ���� �̱��� ������ ���� ������Ʈ�� �Ҵ���� �ʾҴٸ�
            if (m_instance == null)
            {
                // ������ GameManager ������Ʈ�� ã�� �Ҵ�
                m_instance = FindObjectOfType<ResManager>();
            }

            // �̱��� ������Ʈ�� ��ȯ
            return m_instance;
        }
    }

    //private string dataPath = default;
    private static string zombieDataPath = default;

    // ĳ��
    public ZombieData zombieData_default = default;

    private void Awake()
    {
        // ������ �����ϸ� ���� ��ġ���� �޶����� ������, ��θ� ����ؼ� ������ �ҷ����� ����� ���Ǹ� ����
        //dataPath = Application.dataPath;
        //zombieDataPath = string.Format("{0}/{1}", Application.dataPath,
        //    "001MyUnity/Scriptable");

        //zombieDataPath = "Assets/001MyUnity/Scriptable";
        zombieDataPath = "Scriptable";
        zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "Zombie Data Default");

        zombieData_default = Resources.Load<ZombieData>(zombieDataPath);

        //ZombieData zombieData_ = Resources.Load<ZombieData>(zombieDataPath);

        //Debug.LogFormat(" Zombie data Path: {0}", zombieDataPath);
        //Debug.LogFormat("zombie data : {0}, {1}, {2}",
        //    zombieData_.health, zombieData_.damage, zombieData_.speed);

        Debug.LogFormat("���� save data�� ���⿡�ٰ� �����ϴ� ���� ����̴�. -> {0}", 
            Application.persistentDataPath);

        // �̱۰��ӿ��� ���
        // ��ȣȭ : aes-256 
        // ��Ʈ��ũ�����̸� �������ٰ� ����.
    }

    private void Start()
    {

    }

}
