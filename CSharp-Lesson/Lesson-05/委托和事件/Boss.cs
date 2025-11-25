using System;

namespace Lesson05.事件和委托 {
    class Boss {
        public static Action dead;//普通委托对象
        public static event Action deadEvent;//事件对象
        public void BossDeadDispatch() {
            if (deadEvent != null) {
                deadEvent();
            }
            
        }
    }
}