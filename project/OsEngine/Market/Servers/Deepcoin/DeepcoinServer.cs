using System;
using System.Collections.Generic;
using OsEngine.Entity;
using OsEngine.Language;
using OsEngine.Logging;
using OsEngine.Market.Servers.Entity;

namespace OsEngine.Market.Servers.Deepcoin
{
    public class DeepcoinServer : AServer
    {
        public DeepcoinServer()
        {
            DeepcoinServerRealization realization = new DeepcoinServerRealization();
            ServerRealization = realization;
            
            CreateParameterString(OsLocalization.Market.ServerParamPublicKey, "");
            CreateParameterPassword(OsLocalization.Market.ServerParamSecretKey, "");
            CreateParameterPassword(OsLocalization.Market.ServerParamPassphrase, "");
        }
    }

    public class DeepcoinServerRealization : IServerRealization
    {
        #region 1 Constructor, Status, Connection

        // В данном регионе располагается конструктор реализации сервера. Реализация методов Connect / Disconnect. Тип сервера и т.д.
        // То, что нужно для старта работы сервера.

        public DeepcoinServerRealization()
        {
            ServerStatus = ServerConnectStatus.Disconnect;
            
            
        }

        public void Connect()
        {
            _publicKey = ((ServerParameterString)ServerParameters[0]).Value;
            _secretKey = ((ServerParameterPassword)ServerParameters[1]).Value;
            _passphrase = ((ServerParameterPassword)ServerParameters[2]).Value;
            
            ServerStatus = ServerConnectStatus.Connect;
        }
        
        public void Dispose()
        {
            ServerStatus = ServerConnectStatus.Disconnect;
        }

        public event Action ConnectEvent;
        
        public event Action DisconnectEvent;

        #endregion

        #region 2 Properties

        // В данном регионе располагаются настройки коннектора.
        
        private string _baseUrl = "https://api.deepcoin.com";
        
        private string _publicKey;
        
        private string _secretKey;
        
        private string _passphrase;
        
        public ServerType ServerType => ServerType.Deepcoin;
        
        public ServerConnectStatus ServerStatus { get; set; }
        
        public DateTime ServerTime { get; set; }
        
        public List<IServerParameter> ServerParameters { get; set; }

        #endregion

        #region 3 Securities

        // Запрос доступных для подключения бумаг у подключения. Плюс всё, что с этим связано.

        #endregion

        #region 4 Portfolios

        // Запрос доступных портфелей у подключения. Плюс всё, что с этим связано.

        #endregion

        #region 5 Data

        // Запросы данных по свечкам и трейдам. Плюс всё, что с этим связано.        

        #endregion

        #region 6 WebSocket creation

        // Создание вебсокет соединения. Плюс всё, что с этим связано.

        #endregion

        #region 7 WebSocket events

        // Обработка входящих сообщений от вёбсокета. И что важно в данном конкретном случае, Closed и Opened методы обязательно должны находиться здесь, а не только приём сообщений. Ибо без них стабильно наладить работу вёбсокета не выйдет.

        #endregion

        #region 8 WebSocket check alive

        // Проверка вёбсокета на работоспособность путём отправки ему пингов.

        #endregion

        #region 9 Security subscrible

        // Подписка на бумагу. В данном случае это один метод, но бывает их тут и три. Поэтому отдельный регион.
        
        // С обязательным контролем скорости и кол-ву запросов к методу Subscrible через rateGate. Иначе будут проблемы, когда пользователи начнут подписываться на 400 источников.

        #endregion

        #region 10 WebSocket parsing the messages

        // Разбор сообщений от сокета и отправка их наверх.

        #endregion

        #region 11 Trade

        // Регион, посвящённый торговле. Выставление ордеров, отзыв и т.д.

        #endregion

        #region 12 Queries

        // Место расположение HTTP запросов.

        #endregion

        #region 13 Log

        // Логирование.

        #endregion
        
        
        
        public void GetSecurities()
        {
            throw new NotImplementedException();
        }

        public event Action<List<Security>> SecurityEvent;
        
        public void GetPortfolios()
        {
            throw new NotImplementedException();
        }

        public event Action<List<Portfolio>> PortfolioEvent;
        
        public void Subscrible(Security security)
        {
            throw new NotImplementedException();
        }

        public event Action<MarketDepth> MarketDepthEvent;
        public event Action<Trade> NewTradesEvent;
        
        public List<Candle> GetLastCandleHistory(Security security, TimeFrameBuilder timeFrameBuilder, int candleCount)
        {
            throw new NotImplementedException();
        }

        public List<Candle> GetCandleDataToSecurity(Security security, TimeFrameBuilder timeFrameBuilder, DateTime startTime, DateTime endTime,
            DateTime actualTime)
        {
            throw new NotImplementedException();
        }

        public List<Trade> GetTickDataToSecurity(Security security, DateTime startTime, DateTime endTime, DateTime actualTime)
        {
            throw new NotImplementedException();
        }

        public void SendOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void ChangeOrderPrice(Order order, decimal newPrice)
        {
            throw new NotImplementedException();
        }

        public void CancelOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void CancelAllOrders()
        {
            throw new NotImplementedException();
        }

        public void CancelAllOrdersToSecurity(Security security)
        {
            throw new NotImplementedException();
        }

        public void GetAllActivOrders()
        {
            throw new NotImplementedException();
        }

        public void GetOrderStatus(Order order)
        {
            throw new NotImplementedException();
        }

        public event Action<Order> MyOrderEvent;
        public event Action<MyTrade> MyTradeEvent;
        public event Action<string, LogMessageType> LogMessageEvent;
    }
}