namespace OsEngine.Market.Servers.Deepcoin
{
    public class DeepcoinServerPermission : IServerPermission
    {
        public ServerType ServerType
        {
            get { return ServerType.Deepcoin; }
        }

        #region Data Feed Permissions

        public bool DataFeedTf1SecondCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf2SecondCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf5SecondCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf10SecondCanLoad
        {
            get { return false; }
        }
        
        public bool DataFeedTf15SecondCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf20SecondCanLoad
        {
            get { return false; ; }
        }

        public bool DataFeedTf30SecondCanLoad
        {
            get { return false; }
        }
        
        public bool DataFeedTf1MinuteCanLoad
        {
            get { return true; }
        }

        public bool DataFeedTf2MinuteCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf5MinuteCanLoad
        {
            get { return true; }
        }

        public bool DataFeedTf10MinuteCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf15MinuteCanLoad
        {
            get { return true; }
        }

        public bool DataFeedTf30MinuteCanLoad
        {
            get { return true; }
        }

        public bool DataFeedTf1HourCanLoad
        {
            get { return true; }
        }

        public bool DataFeedTf2HourCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf4HourCanLoad
        {
            get { return true; }
        }

        public bool DataFeedTfDayCanLoad
        {
            get { return true; }
        }

        public bool DataFeedTfTickCanLoad
        {
            get { return true; }
        }

        public bool DataFeedTfMarketDepthCanLoad
        {
            get { return true; }
        }

        #endregion

        #region Trade Permissions

        public bool MarketOrdersIsSupport
        {
            get { return true; }
        }

        public bool IsCanChangeOrderPrice
        {
            get { return true; }
        }

        public bool IsUseLotToCalculateProfit
        {
            get { return false; }
        }

        public TimeFramePermission TradeTimeFramePermission
        {
            get { return _tradeTimeFramePermission; }
        }
        
        private TimeFramePermission _tradeTimeFramePermission
            = new TimeFramePermission()
            {
                TimeFrameSec1IsOn = false,
                TimeFrameSec2IsOn = false,
                TimeFrameSec5IsOn = false,
                TimeFrameSec10IsOn = false,
                TimeFrameSec15IsOn = false,
                TimeFrameSec20IsOn = false,
                TimeFrameSec30IsOn = false,
                TimeFrameMin1IsOn = true,
                TimeFrameMin2IsOn = false,
                TimeFrameMin3IsOn = false,
                TimeFrameMin5IsOn = true,
                TimeFrameMin10IsOn = false,
                TimeFrameMin15IsOn = true,
                TimeFrameMin20IsOn = false,
                TimeFrameMin30IsOn = true,
                TimeFrameMin45IsOn = false,
                TimeFrameHour1IsOn = true,
                TimeFrameHour2IsOn = false,
                TimeFrameHour4IsOn = true,
                TimeFrameDayIsOn = true
            };

        public int WaitTimeSecondsAfterFirstStartToSendOrders
        {
            get { return 5; }
        }

        public bool UseStandartCandlesStarter
        {
            get { return true; }
        }

        public bool ManuallyClosePositionOnBoard_IsOn
        {
            get { return true; }
        }
        
        /// <summary>
        /// Это массив строк, которые нужно обрезать от названия бумаги.
        /// </summary>
        public string[] ManuallyClosePositionOnBoard_ValuesForTrimmingName
        {
            get { return null; }
        }

        // TODO: Нужно заполнить
        /// <summary>
        /// Это массив названий бумаг в портфеле, которые не надо пытаться закрывать.
        /// </summary>
        public string[] ManuallyClosePositionOnBoard_ExceptionPositionNames
        {
            get;
        }
        
        // TODO: Нужно заполнить
        public bool CanQueryOrdersAfterReconnect
        {
            get;
        }

        // TODO: Нужно заполнить
        public bool CanQueryOrderStatus
        {
            get;
        }

        #endregion
    }
}