using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GB20284Local.Models
{
    // 定义实现INotifyPropertyChanged接口的类型,作为需要实现数据双向绑定的数据源基类
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChange([CallerMemberName] string propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                foreach (PropertyChangedEventHandler h in handler.GetInvocationList())
                {
                    var synch = h.Target as ISynchronizeInvoke;
                    if (synch != null && synch.InvokeRequired)
                    {
                        synch.Invoke(h, new object[] { this, e });
                    }
                    else
                    {
                        h(this, e);
                    }
                }
            }
        }
    }
}
