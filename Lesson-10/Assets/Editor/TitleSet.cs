using UnityEngine;    
using UnityEditor;	// 被继承的类所在的命名空间
using System.IO;	// IO文件操作命名空间
using System;		// C#基础功能命名空间
using System.Text.RegularExpressions;	// 正则表达式的命名空间
using Cysharp.Threading.Tasks;

// [Obsolete]
public class TitleSet : AssetModificationProcessor//UnityEditor.AssetModificationProcessor
{
    private static void OnWillCreateAsset(string path)
    {
            path = path.Replace(".meta", "");   // 这里跌path是你的项目主路径Asset/Scripts/文件名
            // 等待文件创建（最多等待1秒）
            // int maxWait = 100;
            // while (!File.Exists(path) && maxWait > 0)
            // {
            //     System.Threading.Thread.Sleep(10);
            //     maxWait--;
            // }
            if (path.EndsWith(".cs"))    // 判断是否是c#文件
            {
                ChangeFileContent(path);
                // string fileName = Regex.Match(path, @"[^/]*$").Value;    // 通过正则拿到仅含文件名的字符串
                // string str = File.ReadAllText(path);    // 获取创建的文件名的全部内容
                // str = str.Replace("#Name#", "刘传玺").Replace("#CreateTime#", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")).Replace("#FileName#", fileName).Replace("#path#", path);    // 将头部注释替换
                // File.WriteAllText(path, str);   // 将替换后的内容写入文件，将原内容覆盖
                // AssetDatabase.Refresh();   
            }
    }
    static async void ChangeFileContent(string path)
{
    await UniTask.Yield();
    string fileName = Regex.Match(path, @"[^/]*$").Value;    // 通过正则拿到仅含文件名的字符串
    string str = File.ReadAllText(path);    // 获取创建的文件名的全部内容
    str = str.Replace("#Name#", "刘传玺").Replace("#CreateTime#", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")).Replace("#FileName#", fileName).Replace("#path#", path);    // 将头部注释替换
    File.WriteAllText(path, str);   // 将替换后的内容写入文件，将原内容覆盖
    AssetDatabase.Refresh();   

    // string str = File.ReadAllText(path);
    // str = str.Replace("#SCRIPTFULLNAME#", Path.GetFileName(path)).Replace(
    //                   "#CreateTime#", string.Concat(DateTime.Now.Year, "/", DateTime.Now.Month, "/",DateTime.Now.Day, " ", DateTime.Now.Hour, ":", DateTime.Now.Minute, ":", DateTime.Now.Second));
    // File.WriteAllText(path, str);
}
}