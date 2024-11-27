using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolClasses;

namespace KretaBasicSchoolSystem.Desktop.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private ControlPanelViewModel _controlPanelViewModel;
        private SchoolCitizensViewModel _schoolCitizensViewModel;

        public MainViewModel()
        {
            _controlPanelViewModel = new ControlPanelViewModel();
            _schoolCitizensViewModel = new SchoolCitizensViewModel();
        }

        public MainViewModel(
            ControlPanelViewModel controlPanelViewModel,
            SchoolCitizensViewModel schoolCitizensViewModel,
            SchoolClassesViewModel schoolClassViewModel
        )
        {
            _controlPanelViewModel = controlPanelViewModel;
            _schoolCitizensViewModel = schoolCitizensViewModel;
            _schoolClassesViewModel = schoolClassViewModel;



            CurrentChildView = _controlPanelViewModel;
            ShowDashbord();
        }

        [ObservableProperty]
        private string _caption = string.Empty;

        [ObservableProperty]
        private IconChar _icon = new IconChar();

        [ObservableProperty]
        private BaseViewModel _currentChildView;

        [RelayCommand]
        public void ShowDashbord()
        {
            Caption = "Vezérlőpult";
            Icon=IconChar.SolarPanel;
            CurrentChildView = _controlPanelViewModel;
        }

        [RelayCommand]
        public void ShowSchoolCitizens()
        {
            Caption = "Iskolapolgárok";
            Icon = IconChar.UserGroup;
            CurrentChildView = _schoolCitizensViewModel;
        }

        private SchoolClassesViewModel _schoolClassesViewModel;

        [RelayCommand]
        public void ShowSchoolClasses()
        {
            Caption = "Osztályok";
            Icon = IconChar.ChalkboardUser;
            CurrentChildView = _schoolClassesViewModel;
        }
        
        <ContentControl Content = "{Binding CurrentChildView}"
            Grid.Row="2"
            Margin="10,30,10,10"/>
    }
}
