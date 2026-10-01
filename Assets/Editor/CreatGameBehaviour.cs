using System.IO;
using UnityEditor;

public class CreatGameBehaviour
{
    
    [MenuItem("Assets/Create/GameBehaviour Script", false, 80)]
    public static void CreateScript()
    {
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
            "Assets/Editor/ScriptTemplates/GameBehaviour.cs.txt", "DefaultName.cs");
    }

}
