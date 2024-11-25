namespace OsEngine.Market.Servers.Deepcoin
{
    public class DeepcoinServerPermission : IServerPermission
    {
        public ServerType ServerType
        {
            get => ServerType.Deepcoin;
        }
        
        public bool DataFeedTf1SecondCanLoad { get; }
        public bool DataFeedTf2SecondCanLoad { get; }
        public bool DataFeedTf5SecondCanLoad { get; }
        public bool DataFeedTf10SecondCanLoad { get; }
        public bool DataFeedTf15SecondCanLoad { get; }
        public bool DataFeedTf20SecondCanLoad { get; }
        public bool DataFeedTf30SecondCanLoad { get; }
        public bool DataFeedTf1MinuteCanLoad { get; }
        public bool DataFeedTf2MinuteCanLoad { get; }
        public bool DataFeedTf5MinuteCanLoad { get; }
        public bool DataFeedTf10MinuteCanLoad { get; }
        public bool DataFeedTf15MinuteCanLoad { get; }
        public bool DataFeedTf30MinuteCanLoad { get; }
        public bool DataFeedTf1HourCanLoad { get; }
        public bool DataFeedTf2HourCanLoad { get; }
        public bool DataFeedTf4HourCanLoad { get; }
        public bool DataFeedTfDayCanLoad { get; }
        public bool DataFeedTfTickCanLoad { get; }
        public bool DataFeedTfMarketDepthCanLoad { get; }
        public bool MarketOrdersIsSupport { get; }
        public bool IsCanChangeOrderPrice { get; }
        public bool IsUseLotToCalculateProfit { get; }
        public TimeFramePermission TradeTimeFramePermission { get; }
        public int WaitTimeSecondsAfterFirstStartToSendOrders { get; }
        public bool UseStandartCandlesStarter { get; }
        public bool ManuallyClosePositionOnBoard_IsOn { get; }
        public string[] ManuallyClosePositionOnBoard_ValuesForTrimmingName { get; }
        public string[] ManuallyClosePositionOnBoard_ExceptionPositionNames { get; }
        public bool CanQueryOrdersAfterReconnect { get; }
        public bool CanQueryOrderStatus { get; }
    }
}