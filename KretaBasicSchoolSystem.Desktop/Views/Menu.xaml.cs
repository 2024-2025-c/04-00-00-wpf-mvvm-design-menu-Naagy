using System.Windows.Controls;


namespace KretaBasicSchoolSystem.Desktop.Views
{
    /// <summary>
    /// Interaction logic for MenuButtons.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }
        <RadioButton
            Style = "{StaticResource menuButton}"
            Tag="{StaticResource colorGreen}"
            IsChecked="True"
            Command="{Binding ShowDashbordCommand}"
        >
            <StackPanel Orientation = "Horizontal" >
                < fa:IconImage Icon = "SolarPanel" Style="{StaticResource menuButtonIcon}"/>
                <TextBlock Text = "Vezérőpul" Style="{StaticResource menuButtonText}"/>
            </StackPanel>
        </RadioButton>

        <UserControl
            x:Class="KretaBasicSchoolSystem.Desktop.Views.SchoolClasses.SchoolClassesView"
            xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
            xmlns:mc="http://schemas.openxmlformats.org/markupcompatibility/2006"
            xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
            xmlns:local="clrnamespace:KretaBasicSchoolSystem.Desktop.Views.SchoolClasses"
            mc:Ignorable="d"
            d:DesignHeight="450" d:DesignWidth="800">
            <Grid>
                <TextBlock>Osztályok</TextBlock>
            </Grid>
        </UserControl>
    }
}
