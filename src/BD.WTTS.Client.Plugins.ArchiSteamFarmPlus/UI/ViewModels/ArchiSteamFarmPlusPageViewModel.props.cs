using ArchiSteamFarm.Steam;

namespace BD.WTTS.UI.ViewModels;

public sealed partial class ArchiSteamFarmPlusPageViewModel
{
    /// <summary>
    /// 选择 ASF 可执行文件路径
    /// </summary>
    public ICommand SelectASFExePath { get; }

    /// <summary>
    /// 启动或停止
    /// </summary>
    public ICommand RunOrStop { get; }

    /// <summary>
    /// 打开 ASF WEBUI 控制台
    /// </summary>
    public ICommand OpenWebUIConsole { get; }

    /// <summary>
    /// 打开 ASF 相关网址
    /// </summary>
    public ICommand OpenASFBrowser { get; }

    public ICommand ShellMessageInput { get; }

    private bool _IsRedeemKeyDialogOpen;

    public bool IsRedeemKeyDialogOpen
    {
        get => _IsRedeemKeyDialogOpen;
        set => this.RaiseAndSetIfChanged(ref _IsRedeemKeyDialogOpen, value);
    }
}
