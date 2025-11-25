using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Lesson05.集合 {
    class Collection {
        static void Main() {
            //非泛型集合
            ArrayList array = new ArrayList();
            array.Add("张飞");
            array.Add(250);
            array.Add(2.4f);
            array.Add('A');
            foreach(var item in array) {
                Console.WriteLine(item);
            }
            //泛型集合
            //列表----------------------------------------------------------
            List<string> li = new List<string>();
            //添加
            li.Add("古力娜扎");
            li.Add("迪丽热巴");
            li.Add("热依扎");
            //添加数组
            string[] strList = {"赵云","马超","关羽","张飞"};
            li.AddRange(strList);
            //查询
            foreach(var item in li) {
                Console.WriteLine(item);
            }
            //索引
            for(int i=0; i<li.Count; i++) {
                Console.WriteLine(li[i]);
            }
            //修改
            li[4] = "马耳他";
            Console.WriteLine(li[4]);
            //删除
            //删值
            li.Remove("马耳他");
            //删索引对应的值
            li.RemoveAt(4);
            //删全部
            li.Clear();
            //链表----------------------------------------------------------
            LinkedList<string> link = new LinkedList<string>();
            link.AddLast("胡八一");
            link.AddFirst("雪莉杨");
            //查找
            LinkedListNode<string> node = link.Find("胡八一");
            link.AddBefore(node, "刘备");
            node = link.Find("胡八一");
            link.AddAfter(node, "关羽");
            foreach(var item in link) {
                Console.WriteLine(item);
            }
            //索引不支持
            // link[0] = "";
            //查找
            // node.Previous;//上一个节点
            // node.Next;//下一个节点
            //删除
            node = link.Find("胡八一");
            link.Remove(node);
            link.RemoveFirst();
            link.RemoveLast();
            link.Clear();
            //字典----------------------------------------------------------
            Dictionary<int, string> dic = new Dictionary<int, string>();
            //添加键-值对
            dic.Add(10052, "张颌");
            dic.Add(10032, "张角");
            dic.Add(10096, "张辽");
            //查找 & 修改
            dic[10052] = "张鲁";
            foreach (var key in dic.Keys) {
                Console.WriteLine(key);
            }
            foreach (var value in dic.Values) {
                Console.WriteLine(value);
            }
            foreach (KeyValuePair<int, string> pair in dic) {
                Console.WriteLine(pair.Key.ToString() + ":"+ pair.Value);
            }
            //查找是否存在键
            if (dic.ContainsKey(10052)) {
                Console.WriteLine("存在10052->"+dic[10052]);
            }
            //删除
            dic.Remove(10052);
            
            
        }
    }

}