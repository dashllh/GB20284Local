using System.Windows.Forms;


namespace GB20284Local.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        //SynchronizationContext? uiContext = SynchronizationContext.Current;
        //if(uiContext != null)
        //{
        //    AppData.Data?.Add("UIContext", uiContext);
        //}        
    }
    private void btnQuit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnCalibration_Click(object sender, EventArgs e)
    {
        menuCalibration.Show(btnCalibration, 0, btnCalibration.Height + 2);
    }

    private void btnSystemTools_Click(object sender, EventArgs e)
    {
        menuSystemTools.Show(btnSystemTools, 0, btnSystemTools.Height + 2);
    }

    private void menuCalibration_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == menuItemKtv)
        {

        }
        else if (e.ClickedItem == menuItemKtvStep)
        {

        }
        else if (e.ClickedItem == menuItemHeptane)
        {

        }
    }

    private void btnNewTest_Click(object sender, EventArgs e)
    {
        Form frmTest = new TestForm();
        frmTest.Show();
    }

    private void menuItemKtvStep_Click(object sender, EventArgs e)
    {
        Form frmStepCalibration = new StepCalibrationForm();
        frmStepCalibration.Show();
    }

    private void menuSystemTools_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        
    }

    private void menuItemSystemStatus_Click(object sender, EventArgs e)
    {
        Form frmSystemStatus = new SystemStatusForm();
        frmSystemStatus.Show();
    }
}