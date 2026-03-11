/*
    *Author: #Name#
    *CreateTime: #CreateTime#
    *Title:
    *Description:
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.ComponentModel.Design.Serialization;
using UnityEngine.UI;//xml命名空间

public struct Item
{
    public int id;
    public string name;
    public Item(int _id, string _name){
        id = _id;
        name = _name;
    }
}
public class Hero
{
    public string name;
    public int hp;
    public int def;
    public int atk;
    public List<Item> bag = new List<Item>();//结构体是值类型不可以使用new创建对象
    //构造
    public Hero(string _name, int _atk, int _def, int _hp)
    {
        name = _name;
        atk = _atk;
        def = _def;
        hp = _hp;
    }
}
public class XMLFileLoad : MonoBehaviour
{
    List<Hero> heros;//游戏数据
    public Text xmlText;//显示数据组件，例如atk def hp等组件信息，此处统一用xmlText
    public string url = Application.dataPath + "/Resources/" + "Heroinfo.xml";//文件目录
    // Start is called before the first frame update
    void Start()
    {
        heros = new List<Hero>();
        //添加一条游戏数据
        var hero = new Hero("赵云", 35, 12, 1000);
        hero.bag.Add(new Item(10025, "青釭剑"));
        hero.bag.Add(new Item(10026, "大还丹"));
        hero.bag.Add(new Item(10035,"巨鳄枪"));
        heros.Add(hero);
        //添加一条游戏数据
        var hero2 = new Hero("张飞", 45, 22, 2000);
        hero2.bag.Add(new Item(10025, "锁子甲"));
        hero2.bag.Add(new Item(10026, "酒"));
        hero2.bag.Add(new Item(10035,"丈八蛇矛"));
        heros.Add(hero2);
        //添加一条游戏数据
        var hero3 = new Hero("关羽", 55, 19, 1700);
        hero3.bag.Add(new Item(10025, "佩剑"));
        hero3.bag.Add(new Item(10026, "赤兔马"));
        hero3.bag.Add(new Item(10035,"青龙偃月刀"));
        heros.Add(hero3);
    }

    // Update is called once per frame
    void Update()
    {
        //按键盘将数据保存到xml文件
        if (Input.GetKeyDown(KeyCode.W))
        {
            WriteXMLFile("Heroinfo.xml");
            Debug.Log("XML写入操作完毕");
        } else if (Input.GetKeyDown(KeyCode.R)) //如果使用nput.GetKey会读取若干遍xml内容，这个问题是因为 Update() 方法在每帧都会被调用，而你在 Update 中检测按键输入。Input.GetKey() 在按键被按住期间每帧都返回 true，导致 ReadXMLFile() 在按键期间被反复调用。
        {
            ReadXMLFile(url);
            Debug.Log("XML读取操作完毕");
        }
    }

    //读取操作
    public void ReadXMLFile(string fileName)
    {
        //创建文档对象
        XmlDocument doc = new XmlDocument();
        //加载xml文件
        doc.Load(fileName);
        //逐层读取节点信息
        //获取一个root节点
        XmlNode root = doc.SelectSingleNode("root");
        //可以将节点转成标签，让后用标签孩子标签找子标签
        // XmlElement rootElement = doc.SelectSingleNode("root") as XmlElement;
        // XmlNodeList heroNodes =rootElement.ChildNodes
        XmlNodeList heroNodes = root.SelectNodes("hero");
        //遍历hero节点
        foreach (XmlNode heroNode in heroNodes)
        {
            //填写数据到界面
            string name = heroNode.Attributes["name"].Value;
            int atk = int.Parse(heroNode.Attributes["atk"].Value);
            int def = int.Parse(heroNode.Attributes["def"].Value);
            int hp = int.Parse(heroNode.Attributes["hp"].Value);
            xmlText.text += "英雄名字：" + name + "  攻击力：" + atk + "  防御力：" + def + "  生命值：" + hp + "[\n";
            // Hero hero = new Hero(name, atk, def, hp);
            XmlNodeList itemNodes = heroNode.SelectSingleNode("bag").ChildNodes;
            foreach (XmlNode itemNode in itemNodes)
            {
                int id = int.Parse(itemNode.Attributes["id"].Value);
                string itemName = itemNode.Attributes["name"].Value;
                xmlText.text += "    道具ID：" + id + "  道具名称：" + itemName + "\n";
                // Item item = new Item(id, itemName);
                // hero.bag.Add(item);
            }
            xmlText.text += "]\n";
            // heros.Add(hero);
        }
    }
    //写入操作
    public void WriteXMLFile(string fileName)
    {
        //创建文档对象
        XmlDocument doc = new XmlDocument();
        //xml结构
        /* <root>
            <hero>
                <bag>
                    <item/>
                </bag>
            </hero>
        </root> */
        //创建root根标签
        XmlElement root = doc.CreateElement("root");
        doc.AppendChild(root);//root标签放入文档对象
        //创建hero标签
        foreach (Hero hero in heros)
        {
            XmlElement heroElement = doc.CreateElement("hero");
            root.AppendChild(heroElement);//hero标签放入root标签
            //设置属性
            heroElement.SetAttribute("name", hero.name);
            heroElement.SetAttribute("atk", hero.atk.ToString());
            heroElement.SetAttribute("def", hero.def.ToString());
            heroElement.SetAttribute("hp", hero.hp.ToString());
            //创建bag标签
            XmlElement bagElement = doc.CreateElement("bag");
            heroElement.AppendChild(bagElement);//bag标签放入hero标签
            //创建item标签
            foreach (Item item in hero.bag)
            {
                XmlElement itemElement = doc.CreateElement("item");
                //设置属性
                itemElement.SetAttribute("id", item.id.ToString());
                itemElement.SetAttribute("name", item.name);
                bagElement.AppendChild(itemElement);//item标签放入bag标签
            }
        }
        //判断文件夹是否存在
         if(!System.IO.Directory.Exists(Application.dataPath + "/Resources/"))
        {
            //创建文件夹
            System.IO.Directory.CreateDirectory(Application.dataPath + "/Resources/");
        }
        //判断文件是否存在
        if (System.IO.File.Exists(Application.dataPath + "/Resources/" + fileName))
        {
            //读取文件
            string fileStr = System.IO.File.ReadAllText(Application.dataPath + "/Resources/" + "file.txt");
            Debug.Log("file.txt文件已存在，读取内容：" + fileStr);
        }
        //保存xml文件
        doc.Save(Application.dataPath + "/Resources/" + fileName);
        Debug.Log("XML文件保存成功，路径：" + Application.dataPath + "/Resources/" + fileName);
    }
    
}
