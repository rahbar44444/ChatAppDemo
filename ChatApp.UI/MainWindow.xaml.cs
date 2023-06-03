using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatApp.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> mainMenuList = new List<string>();
        List<TeamMate> TeamMateList = new List<TeamMate>();
        List<Messagee> MessageList = new List<Messagee>();
        public MainWindow()
        {
            InitializeComponent();
            mainMenuList.Add("A");
            mainMenuList.Add("B");
            mainMenuList.Add("C");
            mainMenuTemplate.ItemsSource = mainMenuList;

            TeamMateList.Add(new TeamMate
            {
                Text = "HHH",
                ImageSource = @"./hhh.png"
            }) ;
            MessageList.Add(new Messagee
            {
                ImagePath = @"./Assets/hhh.png",
                Name="Kamran",
                Time= "6:49 PM",
                Message= @"봄날의 햇살 따라 새벽길을 걷네, 작은 꽃들이 눈부신 향기를 품고 서로 맞닿아 웃네. 나비들은 춤추며 색다른 세계를 만들어가고, 그 속에서 나는 풍경에 녹아들어 자유롭게 흘러가네.

어린 그림자들이 덧없이 노래하며 흐르고, 푸른 하늘은 감탄을 자아내며 펼쳐진다. 저 멀리 산들은 우리에게 약속을 전하고, 물결처럼 흐르는 강물은 시간을 담고 흘러간다.
끝없이 이어지는 세상의 수레바퀴, 그 안에서 나는 작은 하나의 이야기가 되어 흘러간다.",
                ReplyCount= "8 replies",
                LastReply= "Last reply today at 3:12 AM",
                ReactionPanelVisibility = Visibility.Collapsed,
                MessagePanelVisibility = Visibility.Visible,
                LastReadOn= "Monday, March 1st"
            });
            MessageList.Add(new Messagee
            {
                ImagePath = @"./Assets/hhh.png",
                Name = "Kamran",
                Time = "6:49 PM",
                Message = @"봄날의 햇살 따라 새벽길을 걷네, 작은 꽃들이 눈부신 향기를 품고 서로 맞닿아 웃네. 나비들은 춤추며 색다른 세계를 만들어가고, 그 속에서 나는 풍경에 녹아들어 자유롭게 흘러가네.

어린 그림자들이 덧없이 노래하며 흐르고, 푸른 하늘은 감탄을 자아내며 펼쳐진다. 저 멀리 산들은 우리에게 약속을 전하고, 물결처럼 흐르는 강물은 시간을 담고 흘러간다.
끝없이 이어지는 세상의 수레바퀴, 그 안에서 나는 작은 하나의 이야기가 되어 흘러간다.",
                ReplyCount = "8 replies",
                LastReply = "Last reply today at 3:12 AM",
                ReactionPanelVisibility = Visibility.Collapsed,
                MessagePanelVisibility = Visibility.Visible,
                LastReadOn = "Monday, March 1st"
            });
            MessageList.Add(new Messagee
            {
                ImagePath = @"./Assets/hhh.png",
                Name = "Heal",
                Time = "6:49 PM",
                Message = @"그 안에서 나는 작은 하나의 이야기가 되어 흘러간다.",
                ReplyCount = "8 replies",
                LastReply = "Last reply today at 3:12 AM",
                ReactionPanelVisibility = Visibility.Visible,
                MessagePanelVisibility = Visibility.Collapsed,
                LastReadOn = "Today"
            });

            messageList.ItemsSource = MessageList;
        }

        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            
        }
    }

    public class TeamMate
    {
        public string Text { get; set; }
        public string ImageSource { get; set; }
    }

    public class Messagee
    {
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public string Message { get; set; }
        public string ReplyCount { get; set; }
        public string LastReply { get; set; }
        public Visibility MessagePanelVisibility { get; set; }
        public Visibility ReactionPanelVisibility { get; set; }
        public string LastReadOn { get; set; }
    }
}