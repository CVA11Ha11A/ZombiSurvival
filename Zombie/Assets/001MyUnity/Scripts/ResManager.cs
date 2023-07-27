using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
// runtime이 아닌 editor time 실행되는 확장자들이 있다.
using UnityEditor;

public class ResManager : MonoBehaviour
{
    public static ResManager m_instance;

    public static ResManager instance
    {
        get
        {
            // 만약 싱글톤 변수에 아직 오브젝트가 할당되지 않았다면
            if (m_instance == null)
            {
                // 씬에서 GameManager 오브젝트를 찾아 할당
                m_instance = FindObjectOfType<ResManager>();
            }

            // 싱글톤 오브젝트를 반환
            return m_instance;
        }
    }

    //private string dataPath = default;
    private static string zombieDataPath = default;

    // 캐싱
    public ZombieData zombieData_default = default;

    private void Awake()
    {
        // 기존에 빌드하면 파일 위치들이 달라지기 때문에, 경로를 사용해서 파일을 불러오는 방식은 주의를 요함
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

        Debug.LogFormat("게임 save data를 여기에다가 저장하는 것이 상식이다. -> {0}", 
            Application.persistentDataPath);

        // 싱글게임에서 사용
        // 암호화 : aes-256 
        // 네트워크게임이면 서버에다가 저장.
    }

    private void Start()
    {

    }

}
