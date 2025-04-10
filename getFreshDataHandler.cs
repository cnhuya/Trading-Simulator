using Bybit.Net.Clients;
using CryptoExchange.Net.CommonObjects;
using CryptoExchange.Net.SharedApis;
using System;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class getFreshDataHandler
    {

        private static BybitSocketClient _client;

        public string STREAM_TICKER { get; private set; }
        public decimal STREAM_TICKER_PRICE { get; private set; }
        public string STREAM_TICKER_TIMESTAMP { get; private set; }
        public string STREAM_TICKER_PRICE_CHANGE24H { get; private set; }
        public string STREAM_TICKER_EXCHANGE { get; private set; }

        public async Task getFreshDataAsync(SharedSymbol symbol)
        {
            // Načtění dat z spotovéhotrhu dané kryptoměny a poté předání těchto dat handlerovi update
            var SOCKET_STREAM = await _client.V5SpotApi.SharedClient.SubscribeToTickerUpdatesAsync(new SubscribeTickerRequest(symbol), update =>
            {
                STREAM_TICKER_EXCHANGE = update.Exchange.ToString();
                STREAM_TICKER_PRICE = (decimal)update.Data.LastPrice;
                STREAM_TICKER_TIMESTAMP = update.DataTime.ToString();
                STREAM_TICKER = update.Symbol;
                decimal roundedChangePercentage = Math.Round((decimal)update.Data.ChangePercentage, 2);
                STREAM_TICKER_PRICE_CHANGE24H = $"{(roundedChangePercentage > 0 ? "+" : "")}{roundedChangePercentage}% (24H)";
            });

            // Chybějící kód, který způsoboval memory leak
            await _client.V5SpotApi.UnsubscribeAllAsync();
        }

        public void joinClient()
        {
            // Připojení uživatele k bybit API
            _client = new BybitSocketClient();
        }
    }
}
