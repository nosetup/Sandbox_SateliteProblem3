namespace LogTerminal
{
  partial class FrmTerminal
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTerminal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerScript = new System.Windows.Forms.Timer(this.components);
            this.timerAutoReply = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MenuStripTerminal = new System.Windows.Forms.MenuStrip();
            this.TsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsmiFileLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFLogsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFLogsSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TsmiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiConnections = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAutomate = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAutomateScripting = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAScriptOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TsmiAScriptSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAutomateAutoReply = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAAutoReplyOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TsmiAAutoReplySaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiControl = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiControlCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCCustomTVControls = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ethernetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripButtons = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnLogOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLogSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnConnect = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnTVControls = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRLSLKRobot = new System.Windows.Forms.ToolStripButton();
            this.TsbtnClearConsole = new System.Windows.Forms.ToolStripButton();
            this.BtnTest1 = new System.Windows.Forms.Button();
            this.BtnTest4 = new System.Windows.Forms.Button();
            this.BtnAltTest1 = new System.Windows.Forms.Button();
            this.BtnTest5 = new System.Windows.Forms.Button();
            this.BtnTest6 = new System.Windows.Forms.Button();
            this.BtnTest3 = new System.Windows.Forms.Button();
            this.BtnTest2 = new System.Windows.Forms.Button();
            this.Dgv_SolutionLog = new System.Windows.Forms.DataGridView();
            this.MenuStripTerminal.SuspendLayout();
            this.ToolStripButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SolutionLog)).BeginInit();
            this.SuspendLayout();
            // 
            // timerScript
            // 
            this.timerScript.Interval = 1000;
            this.timerScript.Tick += new System.EventHandler(this.TimerScript_Tick);
            // 
            // timerAutoReply
            // 
            this.timerAutoReply.Interval = 1000;
            // 
            // MenuStripTerminal
            // 
            this.MenuStripTerminal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStripTerminal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStripTerminal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiFile,
            this.TsmiConnections,
            this.TsmiAutomate,
            this.TsmiControl,
            this.TsmiHelp});
            this.MenuStripTerminal.Location = new System.Drawing.Point(0, 0);
            this.MenuStripTerminal.Name = "MenuStripTerminal";
            this.MenuStripTerminal.Size = new System.Drawing.Size(1284, 33);
            this.MenuStripTerminal.TabIndex = 22;
            this.MenuStripTerminal.Text = "menuStripTerminal";
            // 
            // TsmiFile
            // 
            this.TsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.TsmiFileLogs,
            this.toolStripSeparator2,
            this.TsmiFileExit});
            this.TsmiFile.Name = "TsmiFile";
            this.TsmiFile.Size = new System.Drawing.Size(54, 29);
            this.TsmiFile.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // TsmiFileLogs
            // 
            this.TsmiFileLogs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiFLogsOpen,
            this.TsmiFLogsSaveAs});
            this.TsmiFileLogs.Name = "TsmiFileLogs";
            this.TsmiFileLogs.Size = new System.Drawing.Size(152, 34);
            this.TsmiFileLogs.Text = "Logs";
            // 
            // TsmiFLogsOpen
            // 
            this.TsmiFLogsOpen.Name = "TsmiFLogsOpen";
            this.TsmiFLogsOpen.Size = new System.Drawing.Size(176, 34);
            this.TsmiFLogsOpen.Text = "Open";
            // 
            // TsmiFLogsSaveAs
            // 
            this.TsmiFLogsSaveAs.Name = "TsmiFLogsSaveAs";
            this.TsmiFLogsSaveAs.Size = new System.Drawing.Size(176, 34);
            this.TsmiFLogsSaveAs.Text = "Save As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // TsmiFileExit
            // 
            this.TsmiFileExit.Name = "TsmiFileExit";
            this.TsmiFileExit.Size = new System.Drawing.Size(152, 34);
            this.TsmiFileExit.Text = "Exit";
            this.TsmiFileExit.Click += new System.EventHandler(this.TsmiFileExit_Click);
            // 
            // TsmiConnections
            // 
            this.TsmiConnections.Name = "TsmiConnections";
            this.TsmiConnections.Size = new System.Drawing.Size(126, 29);
            this.TsmiConnections.Text = "Connections";
            this.TsmiConnections.Visible = false;
            // 
            // TsmiAutomate
            // 
            this.TsmiAutomate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiAutomateScripting,
            this.TsmiAutomateAutoReply});
            this.TsmiAutomate.Name = "TsmiAutomate";
            this.TsmiAutomate.Size = new System.Drawing.Size(107, 29);
            this.TsmiAutomate.Text = "Automate";
            this.TsmiAutomate.Visible = false;
            // 
            // TsmiAutomateScripting
            // 
            this.TsmiAutomateScripting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiAScriptOpen,
            this.toolStripSeparator4,
            this.TsmiAScriptSaveAs});
            this.TsmiAutomateScripting.Name = "TsmiAutomateScripting";
            this.TsmiAutomateScripting.Size = new System.Drawing.Size(201, 34);
            this.TsmiAutomateScripting.Text = "Scripting";
            // 
            // TsmiAScriptOpen
            // 
            this.TsmiAScriptOpen.Name = "TsmiAScriptOpen";
            this.TsmiAScriptOpen.Size = new System.Drawing.Size(208, 34);
            this.TsmiAScriptOpen.Text = "Open Script";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(205, 6);
            // 
            // TsmiAScriptSaveAs
            // 
            this.TsmiAScriptSaveAs.Name = "TsmiAScriptSaveAs";
            this.TsmiAScriptSaveAs.Size = new System.Drawing.Size(208, 34);
            this.TsmiAScriptSaveAs.Text = "Save As";
            // 
            // TsmiAutomateAutoReply
            // 
            this.TsmiAutomateAutoReply.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiAAutoReplyOpen,
            this.toolStripSeparator3,
            this.TsmiAAutoReplySaveAs});
            this.TsmiAutomateAutoReply.Name = "TsmiAutomateAutoReply";
            this.TsmiAutomateAutoReply.Size = new System.Drawing.Size(201, 34);
            this.TsmiAutomateAutoReply.Text = "Auto Reply";
            // 
            // TsmiAAutoReplyOpen
            // 
            this.TsmiAAutoReplyOpen.Name = "TsmiAAutoReplyOpen";
            this.TsmiAAutoReplyOpen.Size = new System.Drawing.Size(250, 34);
            this.TsmiAAutoReplyOpen.Text = "Open Auto Reply";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(247, 6);
            // 
            // TsmiAAutoReplySaveAs
            // 
            this.TsmiAAutoReplySaveAs.Name = "TsmiAAutoReplySaveAs";
            this.TsmiAAutoReplySaveAs.Size = new System.Drawing.Size(250, 34);
            this.TsmiAAutoReplySaveAs.Text = "Save As";
            // 
            // TsmiControl
            // 
            this.TsmiControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiControlCustom});
            this.TsmiControl.Name = "TsmiControl";
            this.TsmiControl.Size = new System.Drawing.Size(87, 29);
            this.TsmiControl.Text = "Control";
            this.TsmiControl.Visible = false;
            // 
            // TsmiControlCustom
            // 
            this.TsmiControlCustom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiCCustomTVControls});
            this.TsmiControlCustom.Name = "TsmiControlCustom";
            this.TsmiControlCustom.Size = new System.Drawing.Size(176, 34);
            this.TsmiControlCustom.Text = "Custom";
            // 
            // TsmiCCustomTVControls
            // 
            this.TsmiCCustomTVControls.Name = "TsmiCCustomTVControls";
            this.TsmiCCustomTVControls.Size = new System.Drawing.Size(206, 34);
            this.TsmiCCustomTVControls.Text = "TV Controls";
            // 
            // TsmiHelp
            // 
            this.TsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiHelpAbout});
            this.TsmiHelp.Name = "TsmiHelp";
            this.TsmiHelp.Size = new System.Drawing.Size(65, 29);
            this.TsmiHelp.Text = "Help";
            // 
            // TsmiHelpAbout
            // 
            this.TsmiHelpAbout.Name = "TsmiHelpAbout";
            this.TsmiHelpAbout.Size = new System.Drawing.Size(164, 34);
            this.TsmiHelpAbout.Text = "About";
            this.TsmiHelpAbout.Click += new System.EventHandler(this.TsmiAbout_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(267, 6);
            // 
            // serialToolStripMenuItem
            // 
            this.serialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.connectToolStripMenuItem1,
            this.disconnectToolStripMenuItem1});
            this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
            this.serialToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.serialToolStripMenuItem.Text = "Serial";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(201, 34);
            this.settingsToolStripMenuItem1.Text = "Settings";
            // 
            // connectToolStripMenuItem1
            // 
            this.connectToolStripMenuItem1.Name = "connectToolStripMenuItem1";
            this.connectToolStripMenuItem1.Size = new System.Drawing.Size(201, 34);
            this.connectToolStripMenuItem1.Text = "Connect";
            // 
            // disconnectToolStripMenuItem1
            // 
            this.disconnectToolStripMenuItem1.Name = "disconnectToolStripMenuItem1";
            this.disconnectToolStripMenuItem1.Size = new System.Drawing.Size(201, 34);
            this.disconnectToolStripMenuItem1.Text = "Disconnect";
            // 
            // ethernetToolStripMenuItem
            // 
            this.ethernetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.ethernetToolStripMenuItem.Name = "ethernetToolStripMenuItem";
            this.ethernetToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ethernetToolStripMenuItem.Text = "Ethernet";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 680);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1284, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripButtons
            // 
            this.ToolStripButtons.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.tsbtnLogOpen,
            this.tsbtnLogSaveAs,
            this.toolStripSeparator6,
            this.toolStripLabel1,
            this.tsbtnConnect,
            this.tsbtnDisconnect,
            this.toolStripSeparator7,
            this.toolStripLabel2,
            this.tsbtnTVControls,
            this.tsbtnRLSLKRobot,
            this.TsbtnClearConsole});
            this.ToolStripButtons.Location = new System.Drawing.Point(0, 33);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ToolStripButtons.Size = new System.Drawing.Size(1284, 33);
            this.ToolStripButtons.TabIndex = 25;
            this.ToolStripButtons.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(50, 28);
            this.toolStripLabel3.Text = "Logs";
            // 
            // tsbtnLogOpen
            // 
            this.tsbtnLogOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLogOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLogOpen.Image")));
            this.tsbtnLogOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLogOpen.Name = "tsbtnLogOpen";
            this.tsbtnLogOpen.Size = new System.Drawing.Size(34, 28);
            this.tsbtnLogOpen.Text = "Open";
            // 
            // tsbtnLogSaveAs
            // 
            this.tsbtnLogSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLogSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLogSaveAs.Image")));
            this.tsbtnLogSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLogSaveAs.Name = "tsbtnLogSaveAs";
            this.tsbtnLogSaveAs.Size = new System.Drawing.Size(34, 28);
            this.tsbtnLogSaveAs.Text = "Save As";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(91, 28);
            this.toolStripLabel1.Text = "Serial Port";
            this.toolStripLabel1.Visible = false;
            // 
            // tsbtnConnect
            // 
            this.tsbtnConnect.BackColor = System.Drawing.SystemColors.Control;
            this.tsbtnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConnect.Image")));
            this.tsbtnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConnect.Name = "tsbtnConnect";
            this.tsbtnConnect.Size = new System.Drawing.Size(34, 28);
            this.tsbtnConnect.Text = "Connect";
            this.tsbtnConnect.Visible = false;
            // 
            // tsbtnDisconnect
            // 
            this.tsbtnDisconnect.BackColor = System.Drawing.SystemColors.Control;
            this.tsbtnDisconnect.Checked = true;
            this.tsbtnDisconnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbtnDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDisconnect.Image")));
            this.tsbtnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDisconnect.Name = "tsbtnDisconnect";
            this.tsbtnDisconnect.Size = new System.Drawing.Size(34, 28);
            this.tsbtnDisconnect.Text = "Disconnect";
            this.tsbtnDisconnect.Visible = false;
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(128, 28);
            this.toolStripLabel2.Text = "Show Controls";
            this.toolStripLabel2.Visible = false;
            // 
            // tsbtnTVControls
            // 
            this.tsbtnTVControls.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnTVControls.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnTVControls.Image")));
            this.tsbtnTVControls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTVControls.Name = "tsbtnTVControls";
            this.tsbtnTVControls.Size = new System.Drawing.Size(34, 28);
            this.tsbtnTVControls.Text = "Show TV Controls";
            this.tsbtnTVControls.Visible = false;
            // 
            // tsbtnRLSLKRobot
            // 
            this.tsbtnRLSLKRobot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRLSLKRobot.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRLSLKRobot.Image")));
            this.tsbtnRLSLKRobot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRLSLKRobot.Name = "tsbtnRLSLKRobot";
            this.tsbtnRLSLKRobot.Size = new System.Drawing.Size(34, 28);
            this.tsbtnRLSLKRobot.Text = "RSLK Robot";
            this.tsbtnRLSLKRobot.Visible = false;
            // 
            // TsbtnClearConsole
            // 
            this.TsbtnClearConsole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbtnClearConsole.Image = ((System.Drawing.Image)(resources.GetObject("TsbtnClearConsole.Image")));
            this.TsbtnClearConsole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbtnClearConsole.Name = "TsbtnClearConsole";
            this.TsbtnClearConsole.Size = new System.Drawing.Size(34, 28);
            this.TsbtnClearConsole.Text = "DebugClearConsole";
            this.TsbtnClearConsole.Click += new System.EventHandler(this.TsbtnClearConsole_Click);
            // 
            // BtnTest1
            // 
            this.BtnTest1.Location = new System.Drawing.Point(30, 193);
            this.BtnTest1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTest1.Name = "BtnTest1";
            this.BtnTest1.Size = new System.Drawing.Size(82, 75);
            this.BtnTest1.TabIndex = 28;
            this.BtnTest1.Text = "TEST1";
            this.BtnTest1.Click += new System.EventHandler(this.BtnServerConnect_Click);
            // 
            // BtnTest4
            // 
            this.BtnTest4.Location = new System.Drawing.Point(284, 193);
            this.BtnTest4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTest4.Name = "BtnTest4";
            this.BtnTest4.Size = new System.Drawing.Size(80, 75);
            this.BtnTest4.TabIndex = 42;
            this.BtnTest4.Text = "TEST4";
            this.BtnTest4.Click += new System.EventHandler(this.BtnTest4_Click);
            // 
            // BtnAltTest1
            // 
            this.BtnAltTest1.Location = new System.Drawing.Point(30, 121);
            this.BtnAltTest1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAltTest1.Name = "BtnAltTest1";
            this.BtnAltTest1.Size = new System.Drawing.Size(171, 62);
            this.BtnAltTest1.TabIndex = 45;
            this.BtnAltTest1.Text = "ALT 1";
            this.BtnAltTest1.Click += new System.EventHandler(this.BtnAltTest1_Click);
            // 
            // BtnTest5
            // 
            this.BtnTest5.Location = new System.Drawing.Point(365, 193);
            this.BtnTest5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTest5.Name = "BtnTest5";
            this.BtnTest5.Size = new System.Drawing.Size(77, 75);
            this.BtnTest5.TabIndex = 42;
            this.BtnTest5.Text = "TEST5";
            this.BtnTest5.Click += new System.EventHandler(this.BtnTest5_Click);
            // 
            // BtnTest6
            // 
            this.BtnTest6.Location = new System.Drawing.Point(448, 193);
            this.BtnTest6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTest6.Name = "BtnTest6";
            this.BtnTest6.Size = new System.Drawing.Size(79, 75);
            this.BtnTest6.TabIndex = 51;
            this.BtnTest6.Text = "TEST6";
            this.BtnTest6.Click += new System.EventHandler(this.BtnTest6_Click);
            // 
            // BtnTest3
            // 
            this.BtnTest3.Location = new System.Drawing.Point(209, 193);
            this.BtnTest3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTest3.Name = "BtnTest3";
            this.BtnTest3.Size = new System.Drawing.Size(74, 75);
            this.BtnTest3.TabIndex = 53;
            this.BtnTest3.Text = "TEST3";
            this.BtnTest3.Click += new System.EventHandler(this.BtnTest3_Click);
            // 
            // BtnTest2
            // 
            this.BtnTest2.Location = new System.Drawing.Point(120, 193);
            this.BtnTest2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTest2.Name = "BtnTest2";
            this.BtnTest2.Size = new System.Drawing.Size(81, 75);
            this.BtnTest2.TabIndex = 53;
            this.BtnTest2.Text = "TEST2";
            this.BtnTest2.Click += new System.EventHandler(this.BtnTest2_Click);
            // 
            // Dgv_SolutionLog
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_SolutionLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_SolutionLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_SolutionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_SolutionLog.Location = new System.Drawing.Point(30, 277);
            this.Dgv_SolutionLog.Name = "Dgv_SolutionLog";
            this.Dgv_SolutionLog.RowHeadersWidth = 62;
            this.Dgv_SolutionLog.RowTemplate.Height = 18;
            this.Dgv_SolutionLog.Size = new System.Drawing.Size(1223, 400);
            this.Dgv_SolutionLog.TabIndex = 56;
            // 
            // FrmTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.Dgv_SolutionLog);
            this.Controls.Add(this.BtnTest2);
            this.Controls.Add(this.BtnAltTest1);
            this.Controls.Add(this.BtnTest5);
            this.Controls.Add(this.BtnTest6);
            this.Controls.Add(this.BtnTest3);
            this.Controls.Add(this.BtnTest4);
            this.Controls.Add(this.BtnTest1);
            this.Controls.Add(this.ToolStripButtons);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MenuStripTerminal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripTerminal;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1268, 642);
            this.Name = "FrmTerminal";
            this.Text = "SateliteProblem3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTerminal_FormClosing);
            this.Load += new System.EventHandler(this.FrmTerminal_Load);
            this.Shown += new System.EventHandler(this.FrmTerminal_Shown);
            this.MenuStripTerminal.ResumeLayout(false);
            this.MenuStripTerminal.PerformLayout();
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SolutionLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timerScript;
        private System.Windows.Forms.Timer timerAutoReply;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip MenuStripTerminal;
        private System.Windows.Forms.ToolStripMenuItem TsmiFile;
        private System.Windows.Forms.ToolStripMenuItem TsmiFileExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TsmiConnections;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem TsmiAutomate;
        private System.Windows.Forms.ToolStripMenuItem TsmiAutomateScripting;
        private System.Windows.Forms.ToolStripMenuItem TsmiAScriptOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem TsmiAScriptSaveAs;
        private System.Windows.Forms.ToolStripMenuItem TsmiAutomateAutoReply;
        private System.Windows.Forms.ToolStripMenuItem TsmiAAutoReplyOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem TsmiAAutoReplySaveAs;
        private System.Windows.Forms.ToolStripMenuItem TsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem TsmiHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem TsmiControl;
        private System.Windows.Forms.ToolStripMenuItem TsmiControlCustom;
        private System.Windows.Forms.ToolStripMenuItem TsmiCCustomTVControls;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip ToolStripButtons;
        private System.Windows.Forms.ToolStripButton tsbtnLogSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbtnConnect;
        private System.Windows.Forms.ToolStripButton tsbtnDisconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tsbtnTVControls;
        private System.Windows.Forms.ToolStripButton tsbtnLogOpen;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton tsbtnRLSLKRobot;
        private System.Windows.Forms.ToolStripMenuItem TsmiFileLogs;
        private System.Windows.Forms.ToolStripMenuItem TsmiFLogsOpen;
        private System.Windows.Forms.ToolStripMenuItem TsmiFLogsSaveAs;
        private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ethernetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.Button BtnTest1;
        private System.Windows.Forms.Button BtnTest4;
        private System.Windows.Forms.Button BtnTest5;
        private System.Windows.Forms.Button BtnAltTest1;
        private System.Windows.Forms.ToolStripButton TsbtnClearConsole;
        private System.Windows.Forms.Button BtnTest6;
        private System.Windows.Forms.Button BtnTest3;
        private System.Windows.Forms.Button BtnTest2;
        public System.Windows.Forms.DataGridView Dgv_SolutionLog;
    }
}

