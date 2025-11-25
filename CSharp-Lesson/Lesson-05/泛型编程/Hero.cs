using System;

namespace Lesson05.泛型编程 {
    class Hero : IPerson{
        public string name;
        public void Eat() {}
    }
    class Student: IComparable {
        public string mName;
        public Student(string name) {
            this.mName = name;
        }
        public int CompareTo(object? obj) { //? 表示该参数可以为 null
            if (obj is Student) {
                Student other = (Student)obj;
                return this.mName.CompareTo(other.mName);
            }
            throw new ArgumentException("Object is not a Student");
        }
    }

}