namespace StrategyGame.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    void NewGame(){}
    void LoadGame(){}
    void SettingsMenu(){}
    void ExitGame(){
        if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime lifetime) lifetime.Shutdown();
    }
}