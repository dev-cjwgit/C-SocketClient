using PacketComponent;
using SocketComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SocketTest
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 
    
    public partial class LoginFrm : Window
    {
        public LoginFrm()
        {
            InitializeComponent();
            new ServerService("192.168.1.40", 5000);

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SendPacket s = new SendPacket();
            s.writeInt(255);
            s.writeString("admin");
            s.writeString("ss1235");
            ServerService.send(s.getPacket());
        }
    }
}
