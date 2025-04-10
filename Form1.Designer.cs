namespace WindowsFormsApp1
{
    partial class TradingSimulator
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_buy_triggerSettings = new System.Windows.Forms.Label();
            this.lbl_BALANCE_START = new System.Windows.Forms.Label();
            this.lbl_AVG_BUY = new System.Windows.Forms.Label();
            this.lbl_BALANCE_TOKEN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_LAST_TRIGGERED_PRICE = new System.Windows.Forms.Label();
            this.lbl_BALANCE_NOW = new System.Windows.Forms.Label();
            this.lbl_BUYS = new System.Windows.Forms.Label();
            this.settings_bot = new System.Windows.Forms.Panel();
            this.tb_SELL_VALUE = new System.Windows.Forms.NumericUpDown();
            this.tb_BUY_VALUE = new System.Windows.Forms.NumericUpDown();
            this.tb_SELL_TRIGGER = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_BUY_TRIGGER = new System.Windows.Forms.NumericUpDown();
            this.lbl_sellSettings = new System.Windows.Forms.Label();
            this.tb_BALANCE = new System.Windows.Forms.TextBox();
            this.lbl_balanceSettings = new System.Windows.Forms.Label();
            this.lbl_BuySettings = new System.Windows.Forms.Label();
            this.lbl_sell_triggerSettings = new System.Windows.Forms.Label();
            this.dca_settings = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.DCA_balance = new System.Windows.Forms.TextBox();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.DCA_amount = new System.Windows.Forms.TextBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.DCA_period = new System.Windows.Forms.TextBox();
            this.lbl_Interval = new System.Windows.Forms.Label();
            this.lbl_TIME = new System.Windows.Forms.Label();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.panel_DCA = new System.Windows.Forms.Panel();
            this.lbl_dca = new System.Windows.Forms.Label();
            this.about_dca = new System.Windows.Forms.Label();
            this.btn_dca = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_grid = new System.Windows.Forms.Panel();
            this.lbl_grid = new System.Windows.Forms.Label();
            this.about_grid = new System.Windows.Forms.Label();
            this.btn_grid = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_GRID = new System.Windows.Forms.Panel();
            this.results = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.profit = new System.Windows.Forms.Label();
            this.lbl_PROFIT = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.Panel();
            this.avg_sell = new System.Windows.Forms.Label();
            this.lbl_AVG_SELL = new System.Windows.Forms.Label();
            this.lbl_SELLS = new System.Windows.Forms.Label();
            this.Sold = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Bought = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.avg_buy = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.last_triger = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.balance_combined = new System.Windows.Forms.Label();
            this.lbl_CURRENT_BALANCE = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.balance_token = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.balance = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.initial_balance = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Coin_TickerFromExchange = new System.Windows.Forms.Label();
            this.settings_ticker = new System.Windows.Forms.Panel();
            this.tb_COIN_TICKER = new System.Windows.Forms.TextBox();
            this.lbl_Symbol = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_START = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.tb_console = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_web = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimalize = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.settings_bot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_SELL_VALUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_BUY_VALUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_SELL_TRIGGER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_BUY_TRIGGER)).BeginInit();
            this.dca_settings.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.panel_DCA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_GRID.SuspendLayout();
            this.results.SuspendLayout();
            this.panel12.SuspendLayout();
            this.grid.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.settings_ticker.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_buy_triggerSettings
            // 
            this.lbl_buy_triggerSettings.AutoSize = true;
            this.lbl_buy_triggerSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_buy_triggerSettings.Location = new System.Drawing.Point(33, 80);
            this.lbl_buy_triggerSettings.MinimumSize = new System.Drawing.Size(100, 30);
            this.lbl_buy_triggerSettings.Name = "lbl_buy_triggerSettings";
            this.lbl_buy_triggerSettings.Size = new System.Drawing.Size(100, 30);
            this.lbl_buy_triggerSettings.TabIndex = 12;
            this.lbl_buy_triggerSettings.Text = "Buy trigger";
            this.lbl_buy_triggerSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_BALANCE_START
            // 
            this.lbl_BALANCE_START.AutoSize = true;
            this.lbl_BALANCE_START.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_BALANCE_START.Location = new System.Drawing.Point(2, 30);
            this.lbl_BALANCE_START.MinimumSize = new System.Drawing.Size(170, 0);
            this.lbl_BALANCE_START.Name = "lbl_BALANCE_START";
            this.lbl_BALANCE_START.Size = new System.Drawing.Size(170, 18);
            this.lbl_BALANCE_START.TabIndex = 42;
            this.lbl_BALANCE_START.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AVG_BUY
            // 
            this.lbl_AVG_BUY.AutoSize = true;
            this.lbl_AVG_BUY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_AVG_BUY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(209)))), ((int)(((byte)(39)))));
            this.lbl_AVG_BUY.Location = new System.Drawing.Point(5, 33);
            this.lbl_AVG_BUY.MaximumSize = new System.Drawing.Size(170, 0);
            this.lbl_AVG_BUY.MinimumSize = new System.Drawing.Size(170, 0);
            this.lbl_AVG_BUY.Name = "lbl_AVG_BUY";
            this.lbl_AVG_BUY.Size = new System.Drawing.Size(170, 18);
            this.lbl_AVG_BUY.TabIndex = 40;
            this.lbl_AVG_BUY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_BALANCE_TOKEN
            // 
            this.lbl_BALANCE_TOKEN.AutoSize = true;
            this.lbl_BALANCE_TOKEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_BALANCE_TOKEN.Location = new System.Drawing.Point(2, 30);
            this.lbl_BALANCE_TOKEN.MinimumSize = new System.Drawing.Size(170, 0);
            this.lbl_BALANCE_TOKEN.Name = "lbl_BALANCE_TOKEN";
            this.lbl_BALANCE_TOKEN.Size = new System.Drawing.Size(170, 18);
            this.lbl_BALANCE_TOKEN.TabIndex = 39;
            this.lbl_BALANCE_TOKEN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(59, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "label3";
            // 
            // lbl_LAST_TRIGGERED_PRICE
            // 
            this.lbl_LAST_TRIGGERED_PRICE.AutoSize = true;
            this.lbl_LAST_TRIGGERED_PRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_LAST_TRIGGERED_PRICE.Location = new System.Drawing.Point(5, 30);
            this.lbl_LAST_TRIGGERED_PRICE.MinimumSize = new System.Drawing.Size(170, 0);
            this.lbl_LAST_TRIGGERED_PRICE.Name = "lbl_LAST_TRIGGERED_PRICE";
            this.lbl_LAST_TRIGGERED_PRICE.Size = new System.Drawing.Size(170, 18);
            this.lbl_LAST_TRIGGERED_PRICE.TabIndex = 37;
            this.lbl_LAST_TRIGGERED_PRICE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_BALANCE_NOW
            // 
            this.lbl_BALANCE_NOW.AutoSize = true;
            this.lbl_BALANCE_NOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_BALANCE_NOW.Location = new System.Drawing.Point(2, 30);
            this.lbl_BALANCE_NOW.MinimumSize = new System.Drawing.Size(170, 0);
            this.lbl_BALANCE_NOW.Name = "lbl_BALANCE_NOW";
            this.lbl_BALANCE_NOW.Size = new System.Drawing.Size(170, 18);
            this.lbl_BALANCE_NOW.TabIndex = 36;
            this.lbl_BALANCE_NOW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_BUYS
            // 
            this.lbl_BUYS.AutoSize = true;
            this.lbl_BUYS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_BUYS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(209)))), ((int)(((byte)(39)))));
            this.lbl_BUYS.Location = new System.Drawing.Point(1, 33);
            this.lbl_BUYS.MaximumSize = new System.Drawing.Size(170, 0);
            this.lbl_BUYS.MinimumSize = new System.Drawing.Size(170, 0);
            this.lbl_BUYS.Name = "lbl_BUYS";
            this.lbl_BUYS.Size = new System.Drawing.Size(170, 18);
            this.lbl_BUYS.TabIndex = 34;
            this.lbl_BUYS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settings_bot
            // 
            this.settings_bot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.settings_bot.Controls.Add(this.tb_SELL_VALUE);
            this.settings_bot.Controls.Add(this.tb_BUY_VALUE);
            this.settings_bot.Controls.Add(this.tb_SELL_TRIGGER);
            this.settings_bot.Controls.Add(this.label22);
            this.settings_bot.Controls.Add(this.tb_BUY_TRIGGER);
            this.settings_bot.Controls.Add(this.lbl_sellSettings);
            this.settings_bot.Controls.Add(this.tb_BALANCE);
            this.settings_bot.Controls.Add(this.lbl_balanceSettings);
            this.settings_bot.Controls.Add(this.lbl_BuySettings);
            this.settings_bot.Controls.Add(this.lbl_sell_triggerSettings);
            this.settings_bot.Controls.Add(this.lbl_buy_triggerSettings);
            this.settings_bot.Location = new System.Drawing.Point(433, 8);
            this.settings_bot.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.settings_bot.Name = "settings_bot";
            this.settings_bot.Size = new System.Drawing.Size(444, 201);
            this.settings_bot.TabIndex = 9;
            // 
            // tb_SELL_VALUE
            // 
            this.tb_SELL_VALUE.DecimalPlaces = 5;
            this.tb_SELL_VALUE.Location = new System.Drawing.Point(280, 160);
            this.tb_SELL_VALUE.Name = "tb_SELL_VALUE";
            this.tb_SELL_VALUE.Size = new System.Drawing.Size(120, 20);
            this.tb_SELL_VALUE.TabIndex = 32;
            // 
            // tb_BUY_VALUE
            // 
            this.tb_BUY_VALUE.DecimalPlaces = 5;
            this.tb_BUY_VALUE.Location = new System.Drawing.Point(280, 80);
            this.tb_BUY_VALUE.Name = "tb_BUY_VALUE";
            this.tb_BUY_VALUE.Size = new System.Drawing.Size(120, 20);
            this.tb_BUY_VALUE.TabIndex = 31;
            // 
            // tb_SELL_TRIGGER
            // 
            this.tb_SELL_TRIGGER.DecimalPlaces = 5;
            this.tb_SELL_TRIGGER.Location = new System.Drawing.Point(37, 168);
            this.tb_SELL_TRIGGER.Name = "tb_SELL_TRIGGER";
            this.tb_SELL_TRIGGER.Size = new System.Drawing.Size(120, 20);
            this.tb_SELL_TRIGGER.TabIndex = 30;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Crimson;
            this.label22.Location = new System.Drawing.Point(59, 519);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "label22";
            // 
            // tb_BUY_TRIGGER
            // 
            this.tb_BUY_TRIGGER.DecimalPlaces = 5;
            this.tb_BUY_TRIGGER.Location = new System.Drawing.Point(37, 105);
            this.tb_BUY_TRIGGER.Name = "tb_BUY_TRIGGER";
            this.tb_BUY_TRIGGER.Size = new System.Drawing.Size(120, 20);
            this.tb_BUY_TRIGGER.TabIndex = 29;
            // 
            // lbl_sellSettings
            // 
            this.lbl_sellSettings.AutoSize = true;
            this.lbl_sellSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_sellSettings.Location = new System.Drawing.Point(277, 127);
            this.lbl_sellSettings.MinimumSize = new System.Drawing.Size(50, 30);
            this.lbl_sellSettings.Name = "lbl_sellSettings";
            this.lbl_sellSettings.Size = new System.Drawing.Size(50, 30);
            this.lbl_sellSettings.TabIndex = 26;
            this.lbl_sellSettings.Text = "Sell";
            this.lbl_sellSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_BALANCE
            // 
            this.tb_BALANCE.Location = new System.Drawing.Point(37, 43);
            this.tb_BALANCE.Name = "tb_BALANCE";
            this.tb_BALANCE.Size = new System.Drawing.Size(206, 20);
            this.tb_BALANCE.TabIndex = 25;
            // 
            // lbl_balanceSettings
            // 
            this.lbl_balanceSettings.AutoSize = true;
            this.lbl_balanceSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_balanceSettings.Location = new System.Drawing.Point(33, 18);
            this.lbl_balanceSettings.MinimumSize = new System.Drawing.Size(100, 30);
            this.lbl_balanceSettings.Name = "lbl_balanceSettings";
            this.lbl_balanceSettings.Size = new System.Drawing.Size(100, 30);
            this.lbl_balanceSettings.TabIndex = 24;
            this.lbl_balanceSettings.Text = "Balance";
            this.lbl_balanceSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_BuySettings
            // 
            this.lbl_BuySettings.AutoSize = true;
            this.lbl_BuySettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_BuySettings.Location = new System.Drawing.Point(277, 57);
            this.lbl_BuySettings.MinimumSize = new System.Drawing.Size(50, 30);
            this.lbl_BuySettings.Name = "lbl_BuySettings";
            this.lbl_BuySettings.Size = new System.Drawing.Size(50, 30);
            this.lbl_BuySettings.TabIndex = 22;
            this.lbl_BuySettings.Text = "Buy";
            this.lbl_BuySettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_sell_triggerSettings
            // 
            this.lbl_sell_triggerSettings.AutoSize = true;
            this.lbl_sell_triggerSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_sell_triggerSettings.Location = new System.Drawing.Point(33, 137);
            this.lbl_sell_triggerSettings.MinimumSize = new System.Drawing.Size(100, 30);
            this.lbl_sell_triggerSettings.Name = "lbl_sell_triggerSettings";
            this.lbl_sell_triggerSettings.Size = new System.Drawing.Size(100, 30);
            this.lbl_sell_triggerSettings.TabIndex = 14;
            this.lbl_sell_triggerSettings.Text = "Sell trigger";
            this.lbl_sell_triggerSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dca_settings
            // 
            this.dca_settings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dca_settings.Controls.Add(this.label5);
            this.dca_settings.Controls.Add(this.DCA_balance);
            this.dca_settings.Controls.Add(this.lbl_balance);
            this.dca_settings.Controls.Add(this.DCA_amount);
            this.dca_settings.Controls.Add(this.lbl_Amount);
            this.dca_settings.Controls.Add(this.DCA_period);
            this.dca_settings.Controls.Add(this.lbl_Interval);
            this.dca_settings.Location = new System.Drawing.Point(429, 8);
            this.dca_settings.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.dca_settings.Name = "dca_settings";
            this.dca_settings.Size = new System.Drawing.Size(453, 201);
            this.dca_settings.TabIndex = 29;
            this.dca_settings.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(59, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "label5";
            // 
            // DCA_balance
            // 
            this.DCA_balance.Location = new System.Drawing.Point(114, 35);
            this.DCA_balance.Name = "DCA_balance";
            this.DCA_balance.Size = new System.Drawing.Size(239, 20);
            this.DCA_balance.TabIndex = 25;
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_balance.Location = new System.Drawing.Point(113, 6);
            this.lbl_balance.MinimumSize = new System.Drawing.Size(240, 30);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(240, 30);
            this.lbl_balance.TabIndex = 24;
            this.lbl_balance.Text = "Balance";
            this.lbl_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DCA_amount
            // 
            this.DCA_amount.Location = new System.Drawing.Point(114, 156);
            this.DCA_amount.Name = "DCA_amount";
            this.DCA_amount.Size = new System.Drawing.Size(237, 20);
            this.DCA_amount.TabIndex = 15;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Amount.Location = new System.Drawing.Point(113, 127);
            this.lbl_Amount.MinimumSize = new System.Drawing.Size(240, 30);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(240, 30);
            this.lbl_Amount.TabIndex = 14;
            this.lbl_Amount.Text = "Amount";
            this.lbl_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DCA_period
            // 
            this.DCA_period.Location = new System.Drawing.Point(114, 99);
            this.DCA_period.Name = "DCA_period";
            this.DCA_period.Size = new System.Drawing.Size(239, 20);
            this.DCA_period.TabIndex = 13;
            // 
            // lbl_Interval
            // 
            this.lbl_Interval.AutoSize = true;
            this.lbl_Interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Interval.Location = new System.Drawing.Point(113, 66);
            this.lbl_Interval.MinimumSize = new System.Drawing.Size(240, 30);
            this.lbl_Interval.Name = "lbl_Interval";
            this.lbl_Interval.Size = new System.Drawing.Size(240, 30);
            this.lbl_Interval.TabIndex = 12;
            this.lbl_Interval.Text = "Interval (Seconds)";
            this.lbl_Interval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TIME
            // 
            this.lbl_TIME.AutoSize = true;
            this.lbl_TIME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_TIME.Location = new System.Drawing.Point(726, 2);
            this.lbl_TIME.MinimumSize = new System.Drawing.Size(50, 20);
            this.lbl_TIME.Name = "lbl_TIME";
            this.lbl_TIME.Size = new System.Drawing.Size(50, 20);
            this.lbl_TIME.TabIndex = 43;
            this.lbl_TIME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Controls.Add(this.panel_DCA);
            this.pnl_menu.Controls.Add(this.panel_grid);
            this.pnl_menu.Location = new System.Drawing.Point(24, 8);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(880, 378);
            this.pnl_menu.TabIndex = 36;
            // 
            // panel_DCA
            // 
            this.panel_DCA.BackColor = System.Drawing.Color.DimGray;
            this.panel_DCA.Controls.Add(this.lbl_dca);
            this.panel_DCA.Controls.Add(this.about_dca);
            this.panel_DCA.Controls.Add(this.btn_dca);
            this.panel_DCA.Controls.Add(this.pictureBox1);
            this.panel_DCA.Location = new System.Drawing.Point(146, 27);
            this.panel_DCA.Name = "panel_DCA";
            this.panel_DCA.Padding = new System.Windows.Forms.Padding(50);
            this.panel_DCA.Size = new System.Drawing.Size(250, 320);
            this.panel_DCA.TabIndex = 27;
            // 
            // lbl_dca
            // 
            this.lbl_dca.AutoSize = true;
            this.lbl_dca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_dca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(234)))), ((int)(((byte)(249)))));
            this.lbl_dca.Location = new System.Drawing.Point(104, 117);
            this.lbl_dca.Name = "lbl_dca";
            this.lbl_dca.Size = new System.Drawing.Size(52, 24);
            this.lbl_dca.TabIndex = 8;
            this.lbl_dca.Text = "DCA";
            // 
            // about_dca
            // 
            this.about_dca.AutoSize = true;
            this.about_dca.Location = new System.Drawing.Point(42, 157);
            this.about_dca.MaximumSize = new System.Drawing.Size(175, 0);
            this.about_dca.MinimumSize = new System.Drawing.Size(0, 100);
            this.about_dca.Name = "about_dca";
            this.about_dca.Size = new System.Drawing.Size(175, 100);
            this.about_dca.TabIndex = 7;
            this.about_dca.Text = "Do you wonder how your dca strategy would turned out? Well lets find out. We have" +
    " built a highly customized DCA simulator.";
            this.about_dca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_dca
            // 
            this.btn_dca.FlatAppearance.BorderSize = 0;
            this.btn_dca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dca.Location = new System.Drawing.Point(76, 275);
            this.btn_dca.Name = "btn_dca";
            this.btn_dca.Size = new System.Drawing.Size(100, 23);
            this.btn_dca.TabIndex = 6;
            this.btn_dca.Text = "Continue";
            this.btn_dca.UseVisualStyleBackColor = true;
            this.btn_dca.Click += new System.EventHandler(this.btn_dca_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::trading_simulator.Properties.Resources.dca;
            this.pictureBox1.Location = new System.Drawing.Point(90, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel_grid
            // 
            this.panel_grid.BackColor = System.Drawing.Color.DimGray;
            this.panel_grid.Controls.Add(this.lbl_grid);
            this.panel_grid.Controls.Add(this.about_grid);
            this.panel_grid.Controls.Add(this.btn_grid);
            this.panel_grid.Controls.Add(this.pictureBox2);
            this.panel_grid.Location = new System.Drawing.Point(476, 27);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.Padding = new System.Windows.Forms.Padding(50);
            this.panel_grid.Size = new System.Drawing.Size(250, 320);
            this.panel_grid.TabIndex = 28;
            // 
            // lbl_grid
            // 
            this.lbl_grid.AutoSize = true;
            this.lbl_grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_grid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(234)))), ((int)(((byte)(249)))));
            this.lbl_grid.Location = new System.Drawing.Point(98, 117);
            this.lbl_grid.Name = "lbl_grid";
            this.lbl_grid.Size = new System.Drawing.Size(58, 24);
            this.lbl_grid.TabIndex = 12;
            this.lbl_grid.Text = "GRID";
            // 
            // about_grid
            // 
            this.about_grid.AutoSize = true;
            this.about_grid.Location = new System.Drawing.Point(44, 157);
            this.about_grid.MaximumSize = new System.Drawing.Size(175, 0);
            this.about_grid.MinimumSize = new System.Drawing.Size(0, 100);
            this.about_grid.Name = "about_grid";
            this.about_grid.Size = new System.Drawing.Size(167, 100);
            this.about_grid.TabIndex = 11;
            this.about_grid.Text = "A simple yet usefull and highly customizable simulating of grid trading. A.K buyi" +
    "ng lower than last price, and selling higher than previous trigger.\r\n";
            this.about_grid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_grid
            // 
            this.btn_grid.FlatAppearance.BorderSize = 0;
            this.btn_grid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grid.Location = new System.Drawing.Point(77, 280);
            this.btn_grid.Name = "btn_grid";
            this.btn_grid.Size = new System.Drawing.Size(100, 23);
            this.btn_grid.TabIndex = 10;
            this.btn_grid.Text = "Continue";
            this.btn_grid.UseVisualStyleBackColor = true;
            this.btn_grid.Click += new System.EventHandler(this.btn_grid_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::trading_simulator.Properties.Resources.grid;
            this.pictureBox2.Location = new System.Drawing.Point(91, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pnl_GRID
            // 
            this.pnl_GRID.Controls.Add(this.dca_settings);
            this.pnl_GRID.Controls.Add(this.results);
            this.pnl_GRID.Controls.Add(this.settings_bot);
            this.pnl_GRID.Controls.Add(this.settings_ticker);
            this.pnl_GRID.Location = new System.Drawing.Point(23, 8);
            this.pnl_GRID.Name = "pnl_GRID";
            this.pnl_GRID.Size = new System.Drawing.Size(882, 375);
            this.pnl_GRID.TabIndex = 35;
            this.pnl_GRID.Visible = false;
            // 
            // results
            // 
            this.results.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.results.Controls.Add(this.panel12);
            this.results.Controls.Add(this.grid);
            this.results.Controls.Add(this.panel10);
            this.results.Controls.Add(this.panel8);
            this.results.Controls.Add(this.panel2);
            this.results.Controls.Add(this.panel1);
            this.results.Controls.Add(this.label3);
            this.results.Location = new System.Drawing.Point(-1, 219);
            this.results.Margin = new System.Windows.Forms.Padding(10);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(883, 168);
            this.results.TabIndex = 10;
            this.results.Visible = false;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.profit);
            this.panel12.Controls.Add(this.lbl_PROFIT);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(701, 95);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(175, 73);
            this.panel12.TabIndex = 34;
            // 
            // profit
            // 
            this.profit.AutoSize = true;
            this.profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.profit.Location = new System.Drawing.Point(2, 15);
            this.profit.MinimumSize = new System.Drawing.Size(170, 0);
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(170, 18);
            this.profit.TabIndex = 56;
            this.profit.Text = "Profit";
            this.profit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PROFIT
            // 
            this.lbl_PROFIT.AutoSize = true;
            this.lbl_PROFIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_PROFIT.Location = new System.Drawing.Point(2, 33);
            this.lbl_PROFIT.MinimumSize = new System.Drawing.Size(170, 0);
            this.lbl_PROFIT.Name = "lbl_PROFIT";
            this.lbl_PROFIT.Size = new System.Drawing.Size(170, 18);
            this.lbl_PROFIT.TabIndex = 55;
            this.lbl_PROFIT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grid
            // 
            this.grid.Controls.Add(this.avg_sell);
            this.grid.Controls.Add(this.lbl_AVG_SELL);
            this.grid.Controls.Add(this.lbl_SELLS);
            this.grid.Controls.Add(this.Sold);
            this.grid.Dock = System.Windows.Forms.DockStyle.Left;
            this.grid.Location = new System.Drawing.Point(350, 95);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(351, 73);
            this.grid.TabIndex = 33;
            // 
            // avg_sell
            // 
            this.avg_sell.AutoSize = true;
            this.avg_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.avg_sell.Location = new System.Drawing.Point(175, 15);
            this.avg_sell.MinimumSize = new System.Drawing.Size(170, 0);
            this.avg_sell.Name = "avg_sell";
            this.avg_sell.Size = new System.Drawing.Size(170, 18);
            this.avg_sell.TabIndex = 55;
            this.avg_sell.Text = "Average Sell";
            this.avg_sell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AVG_SELL
            // 
            this.lbl_AVG_SELL.AutoSize = true;
            this.lbl_AVG_SELL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_AVG_SELL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.lbl_AVG_SELL.Location = new System.Drawing.Point(175, 33);
            this.lbl_AVG_SELL.MinimumSize = new System.Drawing.Size(170, 0);
            this.lbl_AVG_SELL.Name = "lbl_AVG_SELL";
            this.lbl_AVG_SELL.Size = new System.Drawing.Size(170, 18);
            this.lbl_AVG_SELL.TabIndex = 41;
            this.lbl_AVG_SELL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_SELLS
            // 
            this.lbl_SELLS.AutoSize = true;
            this.lbl_SELLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_SELLS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(35)))), ((int)(((byte)(75)))));
            this.lbl_SELLS.Location = new System.Drawing.Point(3, 33);
            this.lbl_SELLS.MinimumSize = new System.Drawing.Size(170, 0);
            this.lbl_SELLS.Name = "lbl_SELLS";
            this.lbl_SELLS.Size = new System.Drawing.Size(170, 18);
            this.lbl_SELLS.TabIndex = 35;
            this.lbl_SELLS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sold
            // 
            this.Sold.AutoSize = true;
            this.Sold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sold.Location = new System.Drawing.Point(3, 15);
            this.Sold.MinimumSize = new System.Drawing.Size(170, 0);
            this.Sold.Name = "Sold";
            this.Sold.Size = new System.Drawing.Size(170, 18);
            this.Sold.TabIndex = 54;
            this.Sold.Text = "Sold";
            this.Sold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.Bought);
            this.panel10.Controls.Add(this.lbl_BUYS);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(175, 95);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(175, 73);
            this.panel10.TabIndex = 32;
            // 
            // Bought
            // 
            this.Bought.AutoSize = true;
            this.Bought.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bought.Location = new System.Drawing.Point(2, 15);
            this.Bought.MaximumSize = new System.Drawing.Size(170, 0);
            this.Bought.MinimumSize = new System.Drawing.Size(170, 0);
            this.Bought.Name = "Bought";
            this.Bought.Size = new System.Drawing.Size(170, 18);
            this.Bought.TabIndex = 53;
            this.Bought.Text = "Bought";
            this.Bought.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.avg_buy);
            this.panel8.Controls.Add(this.lbl_AVG_BUY);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 95);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(175, 73);
            this.panel8.TabIndex = 31;
            // 
            // avg_buy
            // 
            this.avg_buy.AutoSize = true;
            this.avg_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.avg_buy.Location = new System.Drawing.Point(5, 15);
            this.avg_buy.MinimumSize = new System.Drawing.Size(170, 0);
            this.avg_buy.Name = "avg_buy";
            this.avg_buy.Size = new System.Drawing.Size(170, 18);
            this.avg_buy.TabIndex = 52;
            this.avg_buy.Text = "Average Buy";
            this.avg_buy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 65);
            this.panel2.TabIndex = 30;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.last_triger);
            this.panel9.Controls.Add(this.lbl_LAST_TRIGGERED_PRICE);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(700, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(175, 65);
            this.panel9.TabIndex = 4;
            // 
            // last_triger
            // 
            this.last_triger.AutoSize = true;
            this.last_triger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.last_triger.Location = new System.Drawing.Point(5, 12);
            this.last_triger.MinimumSize = new System.Drawing.Size(170, 0);
            this.last_triger.Name = "last_triger";
            this.last_triger.Size = new System.Drawing.Size(170, 18);
            this.last_triger.TabIndex = 51;
            this.last_triger.Text = "Last Trigger";
            this.last_triger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.balance_combined);
            this.panel7.Controls.Add(this.lbl_CURRENT_BALANCE);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(525, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(175, 65);
            this.panel7.TabIndex = 3;
            // 
            // balance_combined
            // 
            this.balance_combined.AutoSize = true;
            this.balance_combined.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.balance_combined.Location = new System.Drawing.Point(3, 12);
            this.balance_combined.MinimumSize = new System.Drawing.Size(170, 0);
            this.balance_combined.Name = "balance_combined";
            this.balance_combined.Size = new System.Drawing.Size(170, 18);
            this.balance_combined.TabIndex = 49;
            this.balance_combined.Text = "Balance Combined";
            this.balance_combined.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CURRENT_BALANCE
            // 
            this.lbl_CURRENT_BALANCE.AutoSize = true;
            this.lbl_CURRENT_BALANCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_CURRENT_BALANCE.Location = new System.Drawing.Point(6, 30);
            this.lbl_CURRENT_BALANCE.MinimumSize = new System.Drawing.Size(170, 0);
            this.lbl_CURRENT_BALANCE.Name = "lbl_CURRENT_BALANCE";
            this.lbl_CURRENT_BALANCE.Size = new System.Drawing.Size(170, 18);
            this.lbl_CURRENT_BALANCE.TabIndex = 45;
            this.lbl_CURRENT_BALANCE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.balance_token);
            this.panel6.Controls.Add(this.lbl_BALANCE_TOKEN);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(350, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 65);
            this.panel6.TabIndex = 2;
            // 
            // balance_token
            // 
            this.balance_token.AutoSize = true;
            this.balance_token.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.balance_token.Location = new System.Drawing.Point(2, 12);
            this.balance_token.MinimumSize = new System.Drawing.Size(170, 0);
            this.balance_token.Name = "balance_token";
            this.balance_token.Size = new System.Drawing.Size(170, 18);
            this.balance_token.TabIndex = 48;
            this.balance_token.Text = "Balance Token";
            this.balance_token.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.balance);
            this.panel5.Controls.Add(this.lbl_BALANCE_NOW);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(175, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 65);
            this.panel5.TabIndex = 1;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.balance.Location = new System.Drawing.Point(2, 12);
            this.balance.MinimumSize = new System.Drawing.Size(170, 0);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(170, 18);
            this.balance.TabIndex = 47;
            this.balance.Text = "Balance (USD)";
            this.balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.initial_balance);
            this.panel3.Controls.Add(this.lbl_BALANCE_START);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 65);
            this.panel3.TabIndex = 0;
            // 
            // initial_balance
            // 
            this.initial_balance.AutoSize = true;
            this.initial_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.initial_balance.Location = new System.Drawing.Point(-1, 12);
            this.initial_balance.MinimumSize = new System.Drawing.Size(170, 0);
            this.initial_balance.Name = "initial_balance";
            this.initial_balance.Size = new System.Drawing.Size(170, 18);
            this.initial_balance.TabIndex = 46;
            this.initial_balance.Text = "Initial Balance";
            this.initial_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Coin_TickerFromExchange);
            this.panel1.Controls.Add(this.lbl_TIME);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 30);
            this.panel1.TabIndex = 29;
            // 
            // lbl_Coin_TickerFromExchange
            // 
            this.lbl_Coin_TickerFromExchange.AutoSize = true;
            this.lbl_Coin_TickerFromExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Coin_TickerFromExchange.Location = new System.Drawing.Point(9, 2);
            this.lbl_Coin_TickerFromExchange.MinimumSize = new System.Drawing.Size(250, 20);
            this.lbl_Coin_TickerFromExchange.Name = "lbl_Coin_TickerFromExchange";
            this.lbl_Coin_TickerFromExchange.Size = new System.Drawing.Size(250, 20);
            this.lbl_Coin_TickerFromExchange.TabIndex = 13;
            this.lbl_Coin_TickerFromExchange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settings_ticker
            // 
            this.settings_ticker.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.settings_ticker.Controls.Add(this.tb_COIN_TICKER);
            this.settings_ticker.Controls.Add(this.lbl_Symbol);
            this.settings_ticker.Controls.Add(this.panel4);
            this.settings_ticker.Controls.Add(this.btn_START);
            this.settings_ticker.Location = new System.Drawing.Point(-1, 8);
            this.settings_ticker.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.settings_ticker.Name = "settings_ticker";
            this.settings_ticker.Size = new System.Drawing.Size(424, 201);
            this.settings_ticker.TabIndex = 7;
            // 
            // tb_COIN_TICKER
            // 
            this.tb_COIN_TICKER.Location = new System.Drawing.Point(67, 87);
            this.tb_COIN_TICKER.Name = "tb_COIN_TICKER";
            this.tb_COIN_TICKER.Size = new System.Drawing.Size(300, 20);
            this.tb_COIN_TICKER.TabIndex = 26;
            // 
            // lbl_Symbol
            // 
            this.lbl_Symbol.AutoSize = true;
            this.lbl_Symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Symbol.Location = new System.Drawing.Point(67, 57);
            this.lbl_Symbol.MinimumSize = new System.Drawing.Size(300, 20);
            this.lbl_Symbol.Name = "lbl_Symbol";
            this.lbl_Symbol.Size = new System.Drawing.Size(300, 22);
            this.lbl_Symbol.TabIndex = 9;
            this.lbl_Symbol.Text = "Enter symbol";
            this.lbl_Symbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Location = new System.Drawing.Point(25, 213);
            this.panel4.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.panel4.MaximumSize = new System.Drawing.Size(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 1);
            this.panel4.TabIndex = 8;
            // 
            // btn_START
            // 
            this.btn_START.FlatAppearance.BorderSize = 0;
            this.btn_START.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_START.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_START.Location = new System.Drawing.Point(67, 137);
            this.btn_START.Name = "btn_START";
            this.btn_START.Size = new System.Drawing.Size(300, 27);
            this.btn_START.TabIndex = 2;
            this.btn_START.Text = "START";
            this.btn_START.UseVisualStyleBackColor = true;
            this.btn_START.Click += new System.EventHandler(this.btn_START_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnGoBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGoBack.ForeColor = System.Drawing.Color.Black;
            this.btnGoBack.Location = new System.Drawing.Point(52, 9);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGoBack.Size = new System.Drawing.Size(40, 40);
            this.btnGoBack.TabIndex = 27;
            this.btnGoBack.Text = "🔙";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Visible = false;
            this.btnGoBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_console
            // 
            this.tb_console.Location = new System.Drawing.Point(35, 461);
            this.tb_console.Name = "tb_console";
            this.tb_console.ReadOnly = true;
            this.tb_console.Size = new System.Drawing.Size(880, 103);
            this.tb_console.TabIndex = 37;
            this.tb_console.Text = "";
            this.tb_console.TextChanged += new System.EventHandler(this.tb_console_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.DimGray;
            this.pnl_top.Controls.Add(this.btnGoBack);
            this.pnl_top.Controls.Add(this.btn_web);
            this.pnl_top.Controls.Add(this.label7);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.btn_minimalize);
            this.pnl_top.Location = new System.Drawing.Point(34, 9);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(25, 10, 25, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(882, 60);
            this.pnl_top.TabIndex = 34;
            this.pnl_top.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_top_Paint);
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
            // 
            // btn_web
            // 
            this.btn_web.BackColor = System.Drawing.Color.Transparent;
            this.btn_web.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_web.FlatAppearance.BorderSize = 0;
            this.btn_web.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_web.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_web.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_web.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_web.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_web.ForeColor = System.Drawing.Color.Black;
            this.btn_web.Location = new System.Drawing.Point(7, 9);
            this.btn_web.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btn_web.Name = "btn_web";
            this.btn_web.Size = new System.Drawing.Size(40, 40);
            this.btn_web.TabIndex = 5;
            this.btn_web.Text = "🌐";
            this.btn_web.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(218, 16);
            this.label7.MaximumSize = new System.Drawing.Size(840, 0);
            this.label7.MinimumSize = new System.Drawing.Size(420, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(420, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Trading Simulator";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(818, 9);
            this.btn_close.Margin = new System.Windows.Forms.Padding(5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 40);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "✖";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_minimalize
            // 
            this.btn_minimalize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimalize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_minimalize.FlatAppearance.BorderSize = 0;
            this.btn_minimalize.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_minimalize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_minimalize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_minimalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_minimalize.ForeColor = System.Drawing.Color.Black;
            this.btn_minimalize.Location = new System.Drawing.Point(773, 9);
            this.btn_minimalize.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btn_minimalize.Name = "btn_minimalize";
            this.btn_minimalize.Size = new System.Drawing.Size(40, 40);
            this.btn_minimalize.TabIndex = 4;
            this.btn_minimalize.Text = "➖";
            this.btn_minimalize.UseVisualStyleBackColor = false;
            this.btn_minimalize.Click += new System.EventHandler(this.btn_minimalize_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.pnl_menu);
            this.pnl_main.Controls.Add(this.pnl_GRID);
            this.pnl_main.Location = new System.Drawing.Point(11, 72);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(927, 383);
            this.pnl_main.TabIndex = 38;
            // 
            // TradingSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.tb_console);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TradingSimulator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.settings_bot.ResumeLayout(false);
            this.settings_bot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_SELL_VALUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_BUY_VALUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_SELL_TRIGGER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_BUY_TRIGGER)).EndInit();
            this.dca_settings.ResumeLayout(false);
            this.dca_settings.PerformLayout();
            this.pnl_menu.ResumeLayout(false);
            this.panel_DCA.ResumeLayout(false);
            this.panel_DCA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_grid.ResumeLayout(false);
            this.panel_grid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_GRID.ResumeLayout(false);
            this.results.ResumeLayout(false);
            this.results.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.grid.ResumeLayout(false);
            this.grid.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.settings_ticker.ResumeLayout(false);
            this.settings_ticker.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_buy_triggerSettings;
        private System.Windows.Forms.Label lbl_BALANCE_START;
        private System.Windows.Forms.Label lbl_AVG_BUY;
        private System.Windows.Forms.Label lbl_BALANCE_TOKEN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_LAST_TRIGGERED_PRICE;
        private System.Windows.Forms.Label lbl_BALANCE_NOW;
        private System.Windows.Forms.Label lbl_BUYS;
        private System.Windows.Forms.Panel settings_bot;
        private System.Windows.Forms.Panel dca_settings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DCA_balance;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.TextBox DCA_amount;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.TextBox DCA_period;
        private System.Windows.Forms.Label lbl_Interval;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbl_sellSettings;
        private System.Windows.Forms.TextBox tb_BALANCE;
        private System.Windows.Forms.Label lbl_balanceSettings;
        private System.Windows.Forms.Label lbl_BuySettings;
        private System.Windows.Forms.Label lbl_sell_triggerSettings;
        private System.Windows.Forms.Label lbl_TIME;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel panel_DCA;
        private System.Windows.Forms.Label lbl_dca;
        private System.Windows.Forms.Label about_dca;
        private System.Windows.Forms.Button btn_dca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_grid;
        private System.Windows.Forms.Label lbl_grid;
        private System.Windows.Forms.Label about_grid;
        private System.Windows.Forms.Button btn_grid;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_SELLS;
        private System.Windows.Forms.RichTextBox tb_console;
        private System.Windows.Forms.Button btn_START;
        private System.Windows.Forms.Panel settings_ticker;
        private System.Windows.Forms.Label lbl_Symbol;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_Coin_TickerFromExchange;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_web;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimalize;
        private System.Windows.Forms.Panel pnl_GRID;
        private System.Windows.Forms.Panel results;
        private System.Windows.Forms.Label lbl_CURRENT_BALANCE;
        private System.Windows.Forms.Label lbl_AVG_SELL;
        private System.Windows.Forms.Label balance_combined;
        private System.Windows.Forms.Label balance_token;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label initial_balance;
        private System.Windows.Forms.Label last_triger;
        private System.Windows.Forms.Label avg_buy;
        private System.Windows.Forms.Label Bought;
        private System.Windows.Forms.Label avg_sell;
        private System.Windows.Forms.Label Sold;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel grid;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label profit;
        private System.Windows.Forms.Label lbl_PROFIT;
        private System.Windows.Forms.TextBox tb_COIN_TICKER;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.NumericUpDown tb_BUY_TRIGGER;
        private System.Windows.Forms.NumericUpDown tb_SELL_VALUE;
        private System.Windows.Forms.NumericUpDown tb_BUY_VALUE;
        private System.Windows.Forms.NumericUpDown tb_SELL_TRIGGER;
        private System.Windows.Forms.Panel pnl_main;
    }
}

