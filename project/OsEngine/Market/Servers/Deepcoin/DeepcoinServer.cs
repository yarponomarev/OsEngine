using System;
using System.Collections.Generic;
using OsEngine.Entity;
using OsEngine.Logging;
using OsEngine.Market.Servers.Entity;

namespace OsEngine.Market.Servers.Deepcoin
{
    public class DeepcoinServer : AServer
    {
        public DeepcoinServer()
        {
            
        }
    }

    public class DeepcoinServerRealization : IServerRealization
    {
        public ServerType ServerType { get; }
        public ServerConnectStatus ServerStatus { get; set; }
        public DateTime ServerTime { get; set; }
        public List<IServerParameter> ServerParameters { get; set; }
        
        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public event Action ConnectEvent;
        public event Action DisconnectEvent;
        
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