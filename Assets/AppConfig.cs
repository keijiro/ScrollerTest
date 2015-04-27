using UnityEngine;
using System.Collections;

public class AppConfig : MonoBehaviour
{
    static int mode;

    public static float Delta {
        get {
            switch (mode / 3) {
                case 0: return Time.deltaTime;
                case 1: return Time.smoothDeltaTime;
                default: return 1.0f / 30;
            }
        }
    }

    public static int Layers {
        get { return mode % 3; }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            mode = (mode + 1) % 9;
    }

    void OnGUI()
    {
        string[] modeNames = {"deltaTime", "smoothDeltaTime", "1/30s"};
        GUI.Label(new Rect(0, 0, 200, 100), modeNames[mode / 3]);
    }
}
