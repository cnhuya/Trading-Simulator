
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Security.Policy;
using System.Net;
using System.Globalization;
using CryptoExchange.Net.SharedApis;
using CryptoExchange.Net.Clients;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using CryptoExchange.Net;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Text.Json;
using System.Threading;
using trading_simulator.Properties;
using trading_simulator;
using cnsl;
using MovableForm;
using System.Diagnostics;
using System.Runtime;
using System.Diagnostics.Eventing.Reader;
namespace WindowsFormsApp1
{
    public partial class TradingSimulator : Form
    {


        private Color Scheme_Ligher;
        private Color Scheme_Darker;
        private Color Scheme_Text;
        public class SettingsData
        {
            public string Language { get; set; }
            public string Theme { get; set; }
            public Color HoverColor { get; set; }
            public bool CloseOnStart { get; set; }


        }

        private static SharedSymbol _symbol_PRICE_STREAM;
        public static decimal BALANCE { get; private set; }

        public static decimal BOUGHT { get; private set; }

        public static decimal PERIOD { get; private set; }

        public static decimal SOLD { get; private set; }
        public static decimal LAST_TRIGGERED_PRICE { get; private set; }

        public static decimal BUY_VALUE { get; private set; }
        public static decimal SELL_VALUE { get; private set; }
        public static decimal BUY_TRIGGER { get; private set; }
        public static decimal SELL_TRIGGER { get; private set; }

        private decimal initialBalance;
        private decimal currentBalance;
        private int buy_count;
        private int sell_count;

        private decimal buy_costs;
        private decimal sell_costs;

        private decimal token_balance;
        private decimal set;

        private int time;
        private string lang;

        private decimal prevPrice;

        Console_Class _console = new Console_Class();

        public TradingSimulator()
        {
            InitializeComponent();
            LoadSettings();
            language();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            language();
        }

        private void LoadSettings()
        {
            string path = Directory.GetCurrentDirectory() + @"\settings.json";

            try
            {
                if (File.Exists(path))
                {
                    string jsonString = File.ReadAllText(path);

                    SettingsData settings = JsonSerializer.Deserialize<SettingsData>(jsonString);

                    if (settings != null)
                    {
                        lang = settings.Language;
                        string theme = settings.Theme;
                        Color hoverColor = settings.HoverColor;
                        bool closeOnStart = settings.CloseOnStart;

                        if (theme == "White")
                        {
                            Scheme_Ligher = Color.FromArgb(222, 222, 222);
                            Scheme_Darker = Color.Silver;
                            Scheme_Text = Color.FromArgb(64, 64, 64);
                        }
                        else if (theme == "Dark")
                        {
                            Scheme_Ligher = Color.DimGray;
                            Scheme_Darker = Color.FromArgb(75, 75, 75);
                            Scheme_Text = Color.LightGray;
                        }
                        else if (theme == "Black")
                        {
                            Scheme_Ligher = Color.FromArgb(44, 44, 44);
                            Scheme_Darker = Color.FromArgb(33, 33, 33);
                            Scheme_Text = Color.FromArgb(200, 200, 200);
                        }

                        this.BackColor = Scheme_Darker;
                        pnl_top.BackColor = Scheme_Ligher;
                        panel_DCA.BackColor = Scheme_Ligher;
                        panel_grid.BackColor = Scheme_Ligher;
                        tb_console.BackColor = Scheme_Ligher;
                        results.BackColor = Scheme_Ligher;
                        settings_ticker.BackColor = Scheme_Ligher;
                        settings_bot.BackColor = Scheme_Ligher;
                        dca_settings.BackColor = Scheme_Ligher;
                        tb_console.BackColor = Scheme_Ligher;
                        tb_console.ForeColor = Scheme_Text;

                        DetectObjects(this);
                    }
                    else
                    {
                        MessageBox.Show("Failed to deserialize settings.json.  Check the file format.");
                    }
                }
                else
                {
                    MessageBox.Show("settings.json file not found at: " + path + "Please make sure that you have succesfully installed Launcher, or the json file that contains settings does exists at the specified file path.");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error: Settings file not found. " + ex.Message + "Make sure you have succesfully installed Launcher, if not please install the Launcher.");
            }    
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show("Error: Directory not found for settings file. " + ex.Message);
            }
            catch (JsonException ex)
            {
                MessageBox.Show("Error: Could not parse settings.json. Invalid JSON format. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void DetectObjects(Control parent) // zdroj: https://learn.microsoft.com/en-us/answers/questions/1380697/controls-inside-controls
        {
            foreach (Control control in parent.Controls)
            {
                // detekce vsech buttonu, labelu a checkboxu
                if (control.Name == "lbl_martingale" || control.Name == "lbl_dca" || control.Name == "lbl_grid")
                {
                    control.ForeColor = Color.FromArgb(50, 235, 230);
                }

                else if (control.Name == "lbl_BUYS" || control.Name == "lbl_AVG_BUY")
                {
                    control.ForeColor = Color.Lime;
                }

                else if (control.Name == "lbl_SELLS" || control.Name == "lbl_AVG_SELL")
                {
                    control.ForeColor = Color.Crimson;
                }


                else if (control is Button btn || control is Label lbl || control is CheckBox checkB)
                {
                    control.ForeColor = Scheme_Text;
                }

                // detekce pokud je objekt napriklad vlozen v panelu
                else if (control.HasChildren)
                {
                    DetectObjects(control);
                }
            }
        }



        private async Task FreshData(string coinSymbol)
        {
            try
            {
                getFreshDataHandler FreshDataHandler = new getFreshDataHandler();
                await FreshDataHandler.getFreshDataAsync(_symbol_PRICE_STREAM);

                decimal currentPrice = FreshDataHandler.STREAM_TICKER_PRICE;

                if (decimal.Compare(Math.Abs(currentPrice - (decimal)prevPrice), 0.0001m) > 0)
                {
                    decimal last_trigger_diff = prevPrice != 0
                        ? ((currentPrice - (decimal)prevPrice) / (decimal)prevPrice) * 100: 0;

                    lbl_Coin_TickerFromExchange.Text = $"{FreshDataHandler.STREAM_TICKER_EXCHANGE} | {FreshDataHandler.STREAM_TICKER} | {FreshDataHandler.STREAM_TICKER_PRICE} | {FreshDataHandler.STREAM_TICKER_PRICE_CHANGE24H}";
                    lbl_LAST_TRIGGERED_PRICE.Text = $"{LAST_TRIGGERED_PRICE:F4} | {last_trigger_diff:F4}";
                    lbl_TIME.Text = FreshDataHandler.STREAM_TICKER_TIMESTAMP;
                    lbl_BUYS.Text = BOUGHT.ToString();
                    lbl_SELLS.Text = SOLD.ToString();
                    token_balance = BOUGHT - SOLD;
                    lbl_BALANCE_TOKEN.Text = token_balance.ToString("F2");

                    Bot_Buy(FreshDataHandler.STREAM_TICKER_PRICE, last_trigger_diff);
                    prevPrice = (decimal)FreshDataHandler.STREAM_TICKER_PRICE;
                    decimal profit = currentBalance - initialBalance;
                    lbl_PROFIT.Text = profit.ToString("F2");
                    lbl_PROFIT.ForeColor = profit > 0 ? Color.Lime : Color.Crimson;
                }
            }
            catch (Exception ex)
            {
                tb_console.Text += _console.output(true, $"Error in FreshData: {ex.Message}");
            }
        }

        private void checkEmptyInput()
        {
            if (string.IsNullOrEmpty(tb_COIN_TICKER.Text))
            {
                tb_console.Text += _console.output(true, "Please input cryptocurrency ticker (ex. btc)");
                return;
            }

            if (set == 2)
            {
                if (!decimal.TryParse(tb_BALANCE.Text, out decimal balance) || string.IsNullOrEmpty(tb_BALANCE.Text))
                {
                    tb_console.Text += _console.output(true, "Please enter valid balance");
                    return;
                }

                if (!decimal.TryParse(tb_BUY_TRIGGER.Text, out decimal buyTrigger) || string.IsNullOrEmpty(tb_BUY_TRIGGER.Text))
                {
                    tb_console.Text += _console.output(true, "Please enter price decrease trigger 0.1 to 100, (ex. 5 = price goes up by 5%, bot buys");
                    return;
                }

                if (!decimal.TryParse(tb_SELL_TRIGGER.Text, out decimal sellTrigger) || string.IsNullOrEmpty(tb_SELL_TRIGGER.Text))
                {
                    tb_console.Text += _console.output(true, "Please enter price increase trigger 0.1 to 100, (ex. 5 = price goes up by 5%, bot sells");
                    return;
                }

                if (!decimal.TryParse(tb_BUY_VALUE.Text, out decimal buyValue) || string.IsNullOrEmpty(tb_BUY_VALUE.Text))
                {
                    tb_console.Text += _console.output(true, "Please enter how much do you want to invest per each buy, from 0.1 to 100, value is in %");
                    return;
                }

                if (!decimal.TryParse(tb_SELL_VALUE.Text, out decimal sellValue) || string.IsNullOrEmpty(tb_SELL_VALUE.Text))
                {
                    tb_console.Text += _console.output(true, "Please enter how much do you want to sell per each trigger, from 0.1 to 100, value is in %");
                    return;
                }

                BUY_TRIGGER = buyTrigger;
                SELL_TRIGGER = sellTrigger;
                BUY_VALUE = buyValue; 
                SELL_VALUE = sellValue; 

                BALANCE = balance;
              //  grid.Visible = true;
            }
            else if (set == 1)
            {
                if (!decimal.TryParse(DCA_balance.Text, out decimal balance) || string.IsNullOrEmpty(DCA_balance.Text))
                {
                    tb_console.Text += _console.output(true, "Please enter valid balance");
                    return;
                }

                if (!decimal.TryParse(DCA_period.Text, out decimal period) || string.IsNullOrEmpty(DCA_period.Text))
                {
                    tb_console.Text += _console.output(true, "Please enter valid DCA period");
                    return;
                }

                if (!decimal.TryParse(DCA_amount.Text, out decimal dcaAmount) || string.IsNullOrEmpty(DCA_amount.Text))
                {
                    tb_console.Text += _console.output(true, "Please enter valid DCA amount");
                    return;
                }

                BALANCE = balance;
                BUY_VALUE = dcaAmount;
                PERIOD = period;
                MessageBox.Show(dcaAmount.ToString(), PERIOD.ToString());
            }

            Math.Round(BALANCE, 2);
            Math.Round(currentBalance, 2);

            _symbol_PRICE_STREAM = new SharedSymbol(TradingMode.Spot, tb_COIN_TICKER.Text.ToUpper(), "USDT");

            timer1.Start();
        }


        public void Bot_Buy(decimal STREAM_TICKER_PRICE, decimal PERCENTAGE_DIFF)
        {
            if (LAST_TRIGGERED_PRICE == 0)
            {
                LAST_TRIGGERED_PRICE = STREAM_TICKER_PRICE;
                initialBalance = BALANCE;
            }

            decimal buy_amount = BUY_VALUE;
            decimal sell_amount = SELL_VALUE;


          //  tb_console.Text += _console.output(false, "SET " + set + " PRICE " + STREAM_TICKER_PRICE + " DIFF " + PERCENTAGE_DIFF + " buy_value " +buy_amount + " sell_value " + sell_amount + " buy trigger " + BUY_TRIGGER + " sell trigger " + SELL_TRIGGER);

            decimal boughtUSD = buy_amount * STREAM_TICKER_PRICE;

            if (boughtUSD <= BALANCE)
            {
                if (set == 1)
                {
                    if (time >= PERIOD)
                    {
                        decimal _buy_amount = BUY_VALUE * STREAM_TICKER_PRICE;
                        BOUGHT += BUY_VALUE;
                        BALANCE -= _buy_amount;
                        LAST_TRIGGERED_PRICE = STREAM_TICKER_PRICE;
                        buy_count++;
                        buy_costs += STREAM_TICKER_PRICE;
                        decimal avg_buy = Math.Round(buy_costs / buy_count, 2);
                        lbl_AVG_BUY.Text = avg_buy.ToString();
                        tb_console.Text += _console.output(false, "Succesfully DCA bought at price " + STREAM_TICKER_PRICE);
                        time = 0;
                    }
                }
                else if (set == 2)
                {
                    if (PERCENTAGE_DIFF <= (-1) * SELL_TRIGGER)
                    {
                        decimal boughtTokens = buy_amount;
                        BOUGHT += boughtTokens;
                        BALANCE -= boughtUSD;
                        LAST_TRIGGERED_PRICE = STREAM_TICKER_PRICE;
                        buy_count++;
                        buy_costs += STREAM_TICKER_PRICE;
                        decimal avg_buy = Math.Round( buy_costs / buy_count, 2);
                        lbl_AVG_BUY.Text = avg_buy.ToString();
                        tb_console.Text += _console.output(false, "Succesfully bought " + boughtTokens + " at price " + STREAM_TICKER_PRICE);
                    }
                    else if (PERCENTAGE_DIFF >= BUY_TRIGGER)
                    {
                        if (token_balance >= sell_amount)
                        {
                            decimal soldUSD = sell_amount * STREAM_TICKER_PRICE;
                            decimal soldTokens = sell_amount;
                            SOLD += soldTokens;
                            BALANCE += soldUSD;
                            LAST_TRIGGERED_PRICE = STREAM_TICKER_PRICE;
                            sell_count++;
                            sell_costs += STREAM_TICKER_PRICE;
                            decimal avg_sell = Math.Round(sell_costs / sell_count, 2);
                            lbl_AVG_SELL.Text = avg_sell.ToString();
                            tb_console.Text += _console.output(false, "Succesfully sold " + soldTokens + " at price " + STREAM_TICKER_PRICE);
                        }
                        else
                        {
                            tb_console.Text += _console.output(true, "Do not have enough tokens for sell.");
                        }
                    }
                }
            }
            else
            {
                {
                    tb_console.Text += _console.output(true, "Inefficient balance.");
                }
            }

            token_balance = BOUGHT - SOLD;
            currentBalance = BALANCE + (token_balance * STREAM_TICKER_PRICE);
            lbl_BALANCE_NOW.Text = BALANCE.ToString("F2");
            lbl_CURRENT_BALANCE.Text = currentBalance.ToString("F2");
            lbl_BALANCE_TOKEN.Text = token_balance.ToString("F2");
        }



        private void language()
        {
            string languageCode = "";

            switch (lang)
            {
                case "Čeština (Czech)":
                    languageCode = "cs-CZ";
                    break;
                case "English":
                    languageCode = "";
                    break;
                case "中國人 (Chinese)":
                    languageCode = "zh-CN";
                    break;
                case "Tiếng Việt (Vietnamese)":
                    languageCode = "vi-VN";
                    break;
                case "한국어 (Korean)":
                    languageCode = "ko-KR";
                    break;
            }

            LanguageHandler(languageCode);
            about_dca.Text = trading_simulator.Properties.Resources.dca_info;
            about_grid.Text = trading_simulator.Properties.Resources.grid_info;
            btn_grid.Text = trading_simulator.Properties.Resources.Continue;
            btn_dca.Text = trading_simulator.Properties.Resources.Continue;
            lbl_Symbol.Text = trading_simulator.Properties.Resources.Ticker;
            lbl_balance.Text = trading_simulator.Properties.Resources.Balance;
            lbl_Amount.Text = trading_simulator.Properties.Resources.Amount;
            lbl_Interval.Text = trading_simulator.Properties.Resources.Interval;
            balance.Text = trading_simulator.Properties.Resources.Balance;
            balance_combined.Text = trading_simulator.Properties.Resources.Balance_Combined;
            balance_token.Text = trading_simulator.Properties.Resources.token_balance;
            initial_balance.Text = trading_simulator.Properties.Resources.initial_balance;
            profit.Text = trading_simulator.Properties.Resources.Profit;
            last_triger.Text = trading_simulator.Properties.Resources.Last_Trigger;
            avg_buy.Text = trading_simulator.Properties.Resources.average_buy;
            avg_sell.Text = trading_simulator.Properties.Resources.average_sell;
            Sold.Text = trading_simulator.Properties.Resources.sold;
            Bought.Text = trading_simulator.Properties.Resources.bought;

            lbl_BuySettings.Text = trading_simulator.Properties.Resources.Buy;
            lbl_sellSettings.Text = trading_simulator.Properties.Resources.Sell;
            lbl_buy_triggerSettings.Text = trading_simulator.Properties.Resources.buyTrigger;
            lbl_sell_triggerSettings.Text = trading_simulator.Properties.Resources.sellTrigger;
            lbl_balanceSettings.Text = trading_simulator.Properties.Resources.Balance;
        }

        private void LanguageHandler(string language) // zdroj: https://stackoverflow.com/questions/32989100/how-to-make-multi-language-app-in-winforms
        {

            //https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.currentculture?view=net-9.0 mozna optimalizace, udelat vlastni ddl rozsireni?
            Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
        }

        private void btn_dca_Click_1(object sender, EventArgs e)
        {
            pnl_GRID.Visible = true;
            set = 1;
            dca_settings.Visible = true;
            pnl_menu.Visible = false;
            btnGoBack.Visible = true;
        }

        private void btn_grid_Click_1(object sender, EventArgs e)
        {
            grid.Visible = true;
            set = 2;
            pnl_menu.Visible = false;
            pnl_GRID.Visible = true;
            btnGoBack.Visible = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            // Původní řešení, avšak tento řádek kódu vypne/ukončí VŠECHNY winform aplikace daného projektu. Tedy i launcher.
            //Application.Exit();

            // Fungující řešení, které detekuje winform aplikace podle názvu.
            // Zdroj: https://learn.microsoft.com/en-us/answers/questions/634918/show-a-form-if-already-is-running-c
            var thisForm = Application.OpenForms.Cast<Form>()
                               .FirstOrDefault(f => f.Name == "TradingSimulator");
            // Následné ukončení/zavření vydetekované winform aplikace, v tomto případe TradingSimulator
            thisForm.Close();

            // Přepnutí launched proměnné na false
            Class1.launched = false;
        }

        private void btn_minimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_START_Click(object sender, EventArgs e)
        {
            checkEmptyInput();
            getFreshDataHandler freshDataHandler = new getFreshDataHandler();
            freshDataHandler.joinClient();
            results.Visible = true;
            initialBalance = BALANCE;
            lbl_BALANCE_START.Text = initialBalance.ToString();

        }

        private async void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                time++;
                await FreshData(tb_COIN_TICKER.Text.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_menu.Visible = true;
            pnl_GRID.Visible = false;
            btnGoBack.Visible = false;
            if(timer1.Enabled == true)
            {
                timer1.Stop();
                tb_console.Text += _console.output(false, "Simulator stopped");
            }
        }

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            MovableForm.MovableForm.MouseDown(e, MouseButtons.Left, Handle);
        }

        private void tb_console_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

