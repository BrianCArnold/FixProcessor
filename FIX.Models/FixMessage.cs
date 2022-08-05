namespace FIX.Models;
public class FixMessage
{
    [FieldNumber(1)]
    public string? Account { get; set; }
    [FieldNumber(2)]
    public string? AdvId { get; set; }
    [FieldNumber(3)]
    public string? AdvRefID { get; set; }
    [FieldNumber(4)]
    public string? AdvSide { get; set; }
    [FieldNumber(5)]
    public string? AdvTransType { get; set; }
    [FieldNumber(6)]
    public string? AvgPx { get; set; }
    [FieldNumber(7)]
    public string? BeginSeqNo { get; set; }
    [FieldNumber(8)]
    public string? BeginString { get; set; }
    [FieldNumber(9)]
    public string? BodyLength { get; set; }
    [FieldNumber(10)]
    public string? CheckSum { get; set; }
    [FieldNumber(11)]
    public string? ClOrdID { get; set; }
    [FieldNumber(12)]
    public string? Commission { get; set; }
    [FieldNumber(13)]
    public string? CommType { get; set; }
    [FieldNumber(14)]
    public string? CumQty { get; set; }
    [FieldNumber(15)]
    public string? Currency { get; set; }
    [FieldNumber(16)]
    public string? EndSeqNo { get; set; }
    [FieldNumber(17)]
    public string? ExecID { get; set; }
    [FieldNumber(18)]
    public string? ExecInst { get; set; }
    [FieldNumber(19)]
    public string? ExecRefID { get; set; }
    [FieldNumber(20)]
    public string? ExecTransType { get; set; }
    [FieldNumber(21)]
    public string? HandlInst { get; set; }
    [FieldNumber(22)]
    public string? IDSource { get; set; }
    [FieldNumber(23)]
    public string? IOIid { get; set; }
    [FieldNumber(24)]
    [Obsolete]
    public string? IOIOthSvc { get; set; }
    [FieldNumber(25)]
    public string? IOIQltyInd { get; set; }
    [FieldNumber(26)]
    public string? IOIRefID { get; set; }
    [FieldNumber(27)]
    public string? IOIShares { get; set; }
    [FieldNumber(28)]
    public string? IOITransType { get; set; }
    [FieldNumber(29)]
    public string? LastCapacity { get; set; }
    [FieldNumber(30)]
    public string? LastMkt { get; set; }
    [FieldNumber(31)]
    public string? LastPx { get; set; }
    [FieldNumber(32)]
    public string? LastShares { get; set; }
    [FieldNumber(33)]
    public string? LinesOfText { get; set; }
    [FieldNumber(34)]
    public string? MsgSeqNum { get; set; }
    [FieldNumber(35)]
    public string? MsgType { get; set; }
    [FieldNumber(36)]
    public string? NewSeqNo { get; set; }
    [FieldNumber(37)]
    public string? OrderID { get; set; }
    [FieldNumber(38)]
    public string? OrderQty { get; set; }
    [FieldNumber(39)]
    public string? OrdStatus { get; set; }
    [FieldNumber(40)]
    public string? OrdType { get; set; }
    [FieldNumber(41)]
    public string? OrigClOrdID { get; set; }
    [FieldNumber(42)]
    public string? OrigTime { get; set; }
    [FieldNumber(43)]
    public string? PossDupFlag { get; set; }
    [FieldNumber(44)]
    public string? Price { get; set; }
    [FieldNumber(45)]
    public string? RefSeqNum { get; set; }
    [FieldNumber(46)]
    public string? RelatdSym { get; set; }
    [FieldNumber(47)]
    public string? Rule80A { get; set; }
    [FieldNumber(48)]
    public string? SecurityID { get; set; }
    [FieldNumber(49)]
    public string? SenderCompID { get; set; }
    [FieldNumber(50)]
    public string? SenderSubID { get; set; }
    [FieldNumber(51)]
    [Obsolete]
    public string? SendingDate { get; set; }
    [FieldNumber(52)]
    public string? SendingTime { get; set; }
    [FieldNumber(53)]
    public string? Shares { get; set; }
    [FieldNumber(54)]
    public string? Side { get; set; }
    [FieldNumber(55)]
    public string? Symbol { get; set; }
    [FieldNumber(56)]
    public string? TargetCompID { get; set; }
    [FieldNumber(57)]
    public string? TargetSubID { get; set; }
    [FieldNumber(58)]
    public string? Text { get; set; }
    [FieldNumber(59)]
    public string? TimeInForce { get; set; }
    [FieldNumber(60)]
    public string? TransactTime { get; set; }
    [FieldNumber(61)]
    public string? Urgency { get; set; }
    [FieldNumber(62)]
    public string? ValidUntilTime { get; set; }
    [FieldNumber(63)]
    public string? SettlmntTyp { get; set; }
    [FieldNumber(64)]
    public string? FutSettDate { get; set; }
    [FieldNumber(65)]
    public string? SymbolSfx { get; set; }
    [FieldNumber(66)]
    public string? ListID { get; set; }
    [FieldNumber(67)]
    public string? ListSeqNo { get; set; }
    [FieldNumber(68)]
    public string? TotNoOrders { get; set; }
    [FieldNumber(69)]
    public string? ListExecInst { get; set; }
    [FieldNumber(70)]
    public string? AllocID { get; set; }
    [FieldNumber(71)]
    public string? AllocTransType { get; set; }
    [FieldNumber(72)]
    public string? RefAllocID { get; set; }
    [FieldNumber(73)]
    public string? NoOrders { get; set; }
    [FieldNumber(74)]
    public string? AvgPrxPrecision { get; set; }
    [FieldNumber(75)]
    public string? TradeDate { get; set; }
    [FieldNumber(76)]
    public string? ExecBroker { get; set; }
    [FieldNumber(77)]
    public string? OpenClose { get; set; }
    [FieldNumber(78)]
    public string? NoAllocs { get; set; }
    [FieldNumber(79)]
    public string? AllocAccount { get; set; }
    [FieldNumber(80)]
    public string? AllocShares { get; set; }
    [FieldNumber(81)]
    public string? ProcessCode { get; set; }
    [FieldNumber(82)]
    public string? NoRpts { get; set; }
    [FieldNumber(83)]
    public string? RptSeq { get; set; }
    [FieldNumber(84)]
    public string? CxlQty { get; set; }
    [FieldNumber(85)]
    [Obsolete]
    public string? NoDlvyInst { get; set; }
    [FieldNumber(86)]
    [Obsolete]
    public string? DlvyInst { get; set; }
    [FieldNumber(87)]
    public string? AllocStatus { get; set; }
    [FieldNumber(88)]
    public string? AllocRejCode { get; set; }
    [FieldNumber(89)]
    public string? Signature { get; set; }
    [FieldNumber(90)]
    public string? SecureDataLen { get; set; }
    [FieldNumber(91)]
    public string? SecureData { get; set; }
    [FieldNumber(92)]
    public string? BrokerOfCredit { get; set; }
    [FieldNumber(93)]
    public string? SignatureLength { get; set; }
    [FieldNumber(94)]
    public string? EmailType { get; set; }
    [FieldNumber(95)]
    public string? RawDataLength { get; set; }
    [FieldNumber(96)]
    public string? RawData { get; set; }
    [FieldNumber(97)]
    public string? PossResend { get; set; }
    [FieldNumber(98)]
    public string? EncryptMethod { get; set; }
    [FieldNumber(99)]
    public string? StopPx { get; set; }
    [FieldNumber(100)]
    public string? ExDestination { get; set; }
    [FieldNumber(102)]
    public string? CxlRejReason { get; set; }
    [FieldNumber(103)]
    public string? OrdRejReason { get; set; }
    [FieldNumber(104)]
    public string? IOIQualifier { get; set; }
    [FieldNumber(105)]
    public string? WaveNo { get; set; }
    [FieldNumber(106)]
    public string? Issuer { get; set; }
    [FieldNumber(107)]
    public string? SecurityDesc { get; set; }
    [FieldNumber(108)]
    public string? HeartBtInt { get; set; }
    [FieldNumber(109)]
    public string? ClientID { get; set; }
    [FieldNumber(110)]
    public string? MinQty { get; set; }
    [FieldNumber(111)]
    public string? MaxFloor { get; set; }
    [FieldNumber(112)]
    public string? TestReqID { get; set; }
    [FieldNumber(113)]
    public string? ReportToExch { get; set; }
    [FieldNumber(114)]
    public string? LocateReqd { get; set; }
    [FieldNumber(115)]
    public string? OnBehalfOfCompID { get; set; }
    [FieldNumber(116)]
    public string? OnBehalfOfSubID { get; set; }
    [FieldNumber(117)]
    public string? QuoteID { get; set; }
    [FieldNumber(118)]
    public string? NetMoney { get; set; }
    [FieldNumber(119)]
    public string? SettlCurrAmt { get; set; }
    [FieldNumber(120)]
    public string? SettlCurrency { get; set; }
    [FieldNumber(121)]
    public string? ForexReq { get; set; }
    [FieldNumber(122)]
    public string? OrigSendingTime { get; set; }
    [FieldNumber(123)]
    public string? GapFillFlag { get; set; }
    [FieldNumber(124)]
    public string? NoExecs { get; set; }
    [FieldNumber(125)]
    [Obsolete]
    public string? CxlType { get; set; }
    [FieldNumber(126)]
    public string? ExpireTime { get; set; }
    [FieldNumber(127)]
    public string? DKReason { get; set; }
    [FieldNumber(128)]
    public string? DeliverToCompID { get; set; }
    [FieldNumber(129)]
    public string? DeliverToSubID { get; set; }
    [FieldNumber(130)]
    public string? IOINaturalFlag { get; set; }
    [FieldNumber(131)]
    public string? QuoteReqID { get; set; }
    [FieldNumber(132)]
    public string? BidPx { get; set; }
    [FieldNumber(133)]
    public string? OfferPx { get; set; }
    [FieldNumber(134)]
    public string? BidSize { get; set; }
    [FieldNumber(135)]
    public string? OfferSize { get; set; }
    [FieldNumber(136)]
    public string? NoMiscFees { get; set; }
    [FieldNumber(137)]
    public string? MiscFeeAmt { get; set; }
    [FieldNumber(138)]
    public string? MiscFeeCurr { get; set; }
    [FieldNumber(139)]
    public string? MiscFeeType { get; set; }
    [FieldNumber(140)]
    public string? PrevClosePx { get; set; }
    [FieldNumber(141)]
    public string? ResetSeqNumFlag { get; set; }
    [FieldNumber(142)]
    public string? SenderLocationID { get; set; }
    [FieldNumber(143)]
    public string? TargetLocationID { get; set; }
    [FieldNumber(144)]
    public string? OnBehalfOfLocationID { get; set; }
    [FieldNumber(145)]
    public string? DeliverToLocationID { get; set; }
    [FieldNumber(146)]
    public string? NoRelatedSym { get; set; }
    [FieldNumber(147)]
    public string? Subject { get; set; }
    [FieldNumber(148)]
    public string? Headline { get; set; }
    [FieldNumber(149)]
    public string? URLLink { get; set; }
    [FieldNumber(150)]
    public string? ExecType { get; set; }
    [FieldNumber(151)]
    public string? LeavesQty { get; set; }
    [FieldNumber(152)]
    public string? CashOrderQty { get; set; }
    [FieldNumber(153)]
    public string? AllocAvgPx { get; set; }
    [FieldNumber(154)]
    public string? AllocNetMoney { get; set; }
    [FieldNumber(155)]
    public string? SettlCurrFxRate { get; set; }
    [FieldNumber(156)]
    public string? SettlCurrFxRateCalc { get; set; }
    [FieldNumber(157)]
    public string? NumDaysInterest { get; set; }
    [FieldNumber(158)]
    public string? AccruedInterestRate { get; set; }
    [FieldNumber(159)]
    public string? AccruedInterestAmt { get; set; }
    [FieldNumber(160)]
    public string? SettlInstMode { get; set; }
    [FieldNumber(161)]
    public string? AllocText { get; set; }
    [FieldNumber(162)]
    public string? SettlInstID { get; set; }
    [FieldNumber(163)]
    public string? SettlInstTransType { get; set; }
    [FieldNumber(164)]
    public string? EmailThreadID { get; set; }
    [FieldNumber(165)]
    public string? SettlInstSource { get; set; }
    [FieldNumber(166)]
    public string? SettlLocation { get; set; }
    [FieldNumber(167)]
    public string? SecurityType { get; set; }
    [FieldNumber(168)]
    public string? EffectiveTime { get; set; }
    [FieldNumber(169)]
    public string? StandInstDbType { get; set; }
    [FieldNumber(170)]
    public string? StandInstDbName { get; set; }
    [FieldNumber(171)]
    public string? StandInstDbID { get; set; }
    [FieldNumber(172)]
    public string? SettlDeliveryType { get; set; }
    [FieldNumber(173)]
    public string? SettlDepositoryCode { get; set; }
    [FieldNumber(174)]
    public string? SettlBrkrCode { get; set; }
    [FieldNumber(175)]
    public string? SettlInstCode { get; set; }
    [FieldNumber(176)]
    public string? SecuritySettlAgentName { get; set; }
    [FieldNumber(177)]
    public string? SecuritySettlAgentCode { get; set; }
    [FieldNumber(178)]
    public string? SecuritySettlAgentAcctNum { get; set; }
    [FieldNumber(179)]
    public string? SecuritySettlAgentAcctName { get; set; }
    [FieldNumber(180)]
    public string? SecuritySettlAgentContactName { get; set; }
    [FieldNumber(181)]
    public string? SecuritySettlAgentContactPhone { get; set; }
    [FieldNumber(182)]
    public string? CashSettlAgentName { get; set; }
    [FieldNumber(183)]
    public string? CashSettlAgentCode { get; set; }
    [FieldNumber(184)]
    public string? CashSettlAgentAcctNum { get; set; }
    [FieldNumber(185)]
    public string? CashSettlAgentAcctName { get; set; }
    [FieldNumber(186)]
    public string? CashSettlAgentContactName { get; set; }
    [FieldNumber(187)]
    public string? CashSettlAgentContactPhone { get; set; }
    [FieldNumber(188)]
    public string? BidSpotRate { get; set; }
    [FieldNumber(189)]
    public string? BidForwardPoints { get; set; }
    [FieldNumber(190)]
    public string? OfferSpotRate { get; set; }
    [FieldNumber(191)]
    public string? OfferForwardPoints { get; set; }
    [FieldNumber(192)]
    public string? OrderQty2 { get; set; }
    [FieldNumber(193)]
    public string? FutSettDate2 { get; set; }
    [FieldNumber(194)]
    public string? LastSpotRate { get; set; }
    [FieldNumber(195)]
    public string? LastForwardPoints { get; set; }
    [FieldNumber(196)]
    public string? AllocLinkID { get; set; }
    [FieldNumber(197)]
    public string? AllocLinkType { get; set; }
    [FieldNumber(198)]
    public string? SecondaryOrderID { get; set; }
    [FieldNumber(199)]
    public string? NoIOIQualifiers { get; set; }
    [FieldNumber(200)]
    public string? MaturityMonthYear { get; set; }
    [FieldNumber(201)]
    public string? PutOrCall { get; set; }
    [FieldNumber(202)]
    public string? StrikePrice { get; set; }
    [FieldNumber(203)]
    public string? CoveredOrUncovered { get; set; }
    [FieldNumber(204)]
    public string? CustomerOrFirm { get; set; }
    [FieldNumber(205)]
    public string? MaturityDay { get; set; }
    [FieldNumber(206)]
    public string? OptAttribute { get; set; }
    [FieldNumber(207)]
    public string? SecurityExchange { get; set; }
    [FieldNumber(208)]
    public string? NotifyBrokerOfCredit { get; set; }
    [FieldNumber(209)]
    public string? AllocHandlInst { get; set; }
    [FieldNumber(210)]
    public string? MaxShow { get; set; }
    [FieldNumber(211)]
    public string? PegDifference { get; set; }
    [FieldNumber(212)]
    public string? XmlDataLen { get; set; }
    [FieldNumber(213)]
    public string? XmlData { get; set; }
    [FieldNumber(214)]
    public string? SettlInstRefID { get; set; }
    [FieldNumber(215)]
    public string? NoRoutingIDs { get; set; }
    [FieldNumber(216)]
    public string? RoutingType { get; set; }
    [FieldNumber(217)]
    public string? RoutingID { get; set; }
    [FieldNumber(218)]
    public string? SpreadToBenchmark { get; set; }
    [FieldNumber(219)]
    public string? Benchmark { get; set; }
    [FieldNumber(223)]
    public string? CouponRate { get; set; }
    [FieldNumber(231)]
    public string? ContractMultiplier { get; set; }
    [FieldNumber(262)]
    public string? MDReqID { get; set; }
    [FieldNumber(263)]
    public string? SubscriptionRequestType { get; set; }
    [FieldNumber(264)]
    public string? MarketDepth { get; set; }
    [FieldNumber(265)]
    public string? MDUpdateType { get; set; }
    [FieldNumber(266)]
    public string? AggregatedBook { get; set; }
    [FieldNumber(267)]
    public string? NoMDEntryTypes { get; set; }
    [FieldNumber(268)]
    public string? NoMDEntries { get; set; }
    [FieldNumber(269)]
    public string? MDEntryType { get; set; }
    [FieldNumber(270)]
    public string? MDEntryPx { get; set; }
    [FieldNumber(271)]
    public string? MDEntrySize { get; set; }
    [FieldNumber(272)]
    public string? MDEntryDate { get; set; }
    [FieldNumber(273)]
    public string? MDEntryTime { get; set; }
    [FieldNumber(274)]
    public string? TickDirection { get; set; }
    [FieldNumber(275)]
    public string? MDMkt { get; set; }
    [FieldNumber(276)]
    public string? QuoteCondition { get; set; }
    [FieldNumber(277)]
    public string? TradeCondition { get; set; }
    [FieldNumber(278)]
    public string? MDEntryID { get; set; }
    [FieldNumber(279)]
    public string? MDUpdateAction { get; set; }
    [FieldNumber(280)]
    public string? MDEntryRefID { get; set; }
    [FieldNumber(281)]
    public string? MDReqRejReason { get; set; }
    [FieldNumber(282)]
    public string? MDEntryOriginator { get; set; }
    [FieldNumber(283)]
    public string? LocationID { get; set; }
    [FieldNumber(284)]
    public string? DeskID { get; set; }
    [FieldNumber(285)]
    public string? DeleteReason { get; set; }
    [FieldNumber(286)]
    public string? OpenCloseSettleFlag { get; set; }
    [FieldNumber(287)]
    public string? SellerDays { get; set; }
    [FieldNumber(288)]
    public string? MDEntryBuyer { get; set; }
    [FieldNumber(289)]
    public string? MDEntrySeller { get; set; }
    [FieldNumber(290)]
    public string? MDEntryPositionNo { get; set; }
    [FieldNumber(291)]
    public string? FinancialStatus { get; set; }
    [FieldNumber(292)]
    public string? CorporateAction { get; set; }
    [FieldNumber(293)]
    public string? DefBidSize { get; set; }
    [FieldNumber(294)]
    public string? DefOfferSize { get; set; }
    [FieldNumber(295)]
    public string? NoQuoteEntries { get; set; }
    [FieldNumber(296)]
    public string? NoQuoteSets { get; set; }
    [FieldNumber(297)]
    public string? QuoteAckStatus { get; set; }
    [FieldNumber(298)]
    public string? QuoteCancelType { get; set; }
    [FieldNumber(299)]
    public string? QuoteEntryID { get; set; }
    [FieldNumber(300)]
    public string? QuoteRejectReason { get; set; }
    [FieldNumber(301)]
    public string? QuoteResponseLevel { get; set; }
    [FieldNumber(302)]
    public string? QuoteSetID { get; set; }
    [FieldNumber(303)]
    public string? QuoteRequestType { get; set; }
    [FieldNumber(304)]
    public string? TotQuoteEntries { get; set; }
    [FieldNumber(305)]
    public string? UnderlyingIDSource { get; set; }
    [FieldNumber(306)]
    public string? UnderlyingIssuer { get; set; }
    [FieldNumber(307)]
    public string? UnderlyingSecurityDesc { get; set; }
    [FieldNumber(308)]
    public string? UnderlyingSecurityExchange { get; set; }
    [FieldNumber(309)]
    public string? UnderlyingSecurityID { get; set; }
    [FieldNumber(310)]
    public string? UnderlyingSecurityType { get; set; }
    [FieldNumber(311)]
    public string? UnderlyingSymbol { get; set; }
    [FieldNumber(312)]
    public string? UnderlyingSymbolSfx { get; set; }
    [FieldNumber(313)]
    public string? UnderlyingMaturityMonthYear { get; set; }
    [FieldNumber(314)]
    public string? UnderlyingMaturityDay { get; set; }
    [FieldNumber(315)]
    public string? UnderlyingPutOrCall { get; set; }
    [FieldNumber(316)]
    public string? UnderlyingStrikePrice { get; set; }
    [FieldNumber(317)]
    public string? UnderlyingOptAttribute { get; set; }
    [FieldNumber(318)]
    public string? UnderlyingCurrency { get; set; }
    [FieldNumber(319)]
    public string? RatioQty { get; set; }
    [FieldNumber(320)]
    public string? SecurityReqID { get; set; }
    [FieldNumber(321)]
    public string? SecurityRequestType { get; set; }
    [FieldNumber(322)]
    public string? SecurityResponseID { get; set; }
    [FieldNumber(323)]
    public string? SecurityResponseType { get; set; }
    [FieldNumber(324)]
    public string? SecurityStatusReqID { get; set; }
    [FieldNumber(325)]
    public string? UnsolicitedIndicator { get; set; }
    [FieldNumber(326)]
    public string? SecurityTradingStatus { get; set; }
    [FieldNumber(327)]
    public string? HaltReason { get; set; }
    [FieldNumber(328)]
    public string? InViewOfCommon { get; set; }
    [FieldNumber(329)]
    public string? DueToRelated { get; set; }
    [FieldNumber(330)]
    public string? BuyVolume { get; set; }
    [FieldNumber(331)]
    public string? SellVolume { get; set; }
    [FieldNumber(332)]
    public string? HighPx { get; set; }
    [FieldNumber(333)]
    public string? LowPx { get; set; }
    [FieldNumber(334)]
    public string? Adjustment { get; set; }
    [FieldNumber(335)]
    public string? TradSesReqID { get; set; }
    [FieldNumber(336)]
    public string? TradingSessionID { get; set; }
    [FieldNumber(337)]
    public string? ContraTrader { get; set; }
    [FieldNumber(338)]
    public string? TradSesMethod { get; set; }
    [FieldNumber(339)]
    public string? TradSesMode { get; set; }
    [FieldNumber(340)]
    public string? TradSesStatus { get; set; }
    [FieldNumber(341)]
    public string? TradSesStartTime { get; set; }
    [FieldNumber(342)]
    public string? TradSesOpenTime { get; set; }
    [FieldNumber(343)]
    public string? TradSesPreCloseTime { get; set; }
    [FieldNumber(344)]
    public string? TradSesCloseTime { get; set; }
    [FieldNumber(345)]
    public string? TradSesEndTime { get; set; }
    [FieldNumber(346)]
    public string? NumberOfOrders { get; set; }
    [FieldNumber(347)]
    public string? MessageEncoding { get; set; }
    [FieldNumber(348)]
    public string? EncodedIssuerLen { get; set; }
    [FieldNumber(349)]
    public string? EncodedIssuer { get; set; }
    [FieldNumber(350)]
    public string? EncodedSecurityDescLen { get; set; }
    [FieldNumber(351)]
    public string? EncodedSecurityDesc { get; set; }
    [FieldNumber(352)]
    public string? EncodedListExecInstLen { get; set; }
    [FieldNumber(353)]
    public string? EncodedListExecInst { get; set; }
    [FieldNumber(354)]
    public string? EncodedTextLen { get; set; }
    [FieldNumber(355)]
    public string? EncodedText { get; set; }
    [FieldNumber(356)]
    public string? EncodedSubjectLen { get; set; }
    [FieldNumber(357)]
    public string? EncodedSubject { get; set; }
    [FieldNumber(358)]
    public string? EncodedHeadlineLen { get; set; }
    [FieldNumber(359)]
    public string? EncodedHeadline { get; set; }
    [FieldNumber(360)]
    public string? EncodedAllocTextLen { get; set; }
    [FieldNumber(361)]
    public string? EncodedAllocText { get; set; }
    [FieldNumber(362)]
    public string? EncodedUnderlyingIssuerLen { get; set; }
    [FieldNumber(363)]
    public string? EncodedUnderlyingIssuer { get; set; }
    [FieldNumber(364)]
    public string? EncodedUnderlyingSecurityDescLen { get; set; }
    [FieldNumber(365)]
    public string? EncodedUnderlyingSecurityDesc { get; set; }
    [FieldNumber(366)]
    public string? AllocPrice { get; set; }
    [FieldNumber(367)]
    public string? QuoteSetValidUntilTime { get; set; }
    [FieldNumber(368)]
    public string? QuoteEntryRejectReason { get; set; }
    [FieldNumber(369)]
    public string? LastMsgSeqNumProcessed { get; set; }
    [FieldNumber(370)]
    public string? OnBehalfOfSendingTime { get; set; }
    [FieldNumber(371)]
    public string? RefTagID { get; set; }
    [FieldNumber(372)]
    public string? RefMsgType { get; set; }
    [FieldNumber(373)]
    public string? SessionRejectReason { get; set; }
    [FieldNumber(374)]
    public string? BidRequestTransType { get; set; }
    [FieldNumber(375)]
    public string? ContraBroker { get; set; }
    [FieldNumber(376)]
    public string? ComplianceID { get; set; }
    [FieldNumber(377)]
    public string? SolicitedFlag { get; set; }
    [FieldNumber(378)]
    public string? ExecRestatementReason { get; set; }
    [FieldNumber(379)]
    public string? BusinessRejectRefID { get; set; }
    [FieldNumber(380)]
    public string? BusinessRejectReason { get; set; }
    [FieldNumber(381)]
    public string? GrossTradeAmt { get; set; }
    [FieldNumber(382)]
    public string? NoContraBrokers { get; set; }
    [FieldNumber(383)]
    public string? MaxMessageSize { get; set; }
    [FieldNumber(384)]
    public string? NoMsgTypes { get; set; }
    [FieldNumber(385)]
    public string? MsgDirection { get; set; }
    [FieldNumber(386)]
    public string? NoTradingSessions { get; set; }
    [FieldNumber(387)]
    public string? TotalVolumeTraded { get; set; }
    [FieldNumber(388)]
    public string? DiscretionInst { get; set; }
    [FieldNumber(389)]
    public string? DiscretionOffset { get; set; }
    [FieldNumber(390)]
    public string? BidID { get; set; }
    [FieldNumber(391)]
    public string? ClientBidID { get; set; }
    [FieldNumber(392)]
    public string? ListName { get; set; }
    [FieldNumber(393)]
    public string? TotalNumSecurities { get; set; }
    [FieldNumber(394)]
    public string? BidType { get; set; }
    [FieldNumber(395)]
    public string? NumTickets { get; set; }
    [FieldNumber(396)]
    public string? SideValue1 { get; set; }
    [FieldNumber(397)]
    public string? SideValue2 { get; set; }
    [FieldNumber(398)]
    public string? NoBidDescriptors { get; set; }
    [FieldNumber(399)]
    public string? BidDescriptorType { get; set; }
    [FieldNumber(400)]
    public string? BidDescriptor { get; set; }
    [FieldNumber(401)]
    public string? SideValueInd { get; set; }
    [FieldNumber(402)]
    public string? LiquidityPctLow { get; set; }
    [FieldNumber(403)]
    public string? LiquidityPctHigh { get; set; }
    [FieldNumber(404)]
    public string? LiquidityValue { get; set; }
    [FieldNumber(405)]
    public string? EFPTrackingError { get; set; }
    [FieldNumber(406)]
    public string? FairValue { get; set; }
    [FieldNumber(407)]
    public string? OutsideIndexPct { get; set; }
    [FieldNumber(408)]
    public string? ValueOfFutures { get; set; }
    [FieldNumber(409)]
    public string? LiquidityIndType { get; set; }
    [FieldNumber(410)]
    public string? WtAverageLiquidity { get; set; }
    [FieldNumber(411)]
    public string? ExchangeForPhysical { get; set; }
    [FieldNumber(412)]
    public string? OutMainCntryUIndex { get; set; }
    [FieldNumber(413)]
    public string? CrossPercent { get; set; }
    [FieldNumber(414)]
    public string? ProgRptReqs { get; set; }
    [FieldNumber(415)]
    public string? ProgPeriodInterval { get; set; }
    [FieldNumber(416)]
    public string? IncTaxInd { get; set; }
    [FieldNumber(417)]
    public string? NumBidders { get; set; }
    [FieldNumber(418)]
    public string? TradeType { get; set; }
    [FieldNumber(419)]
    public string? BasisPxType { get; set; }
    [FieldNumber(420)]
    public string? NoBidComponents { get; set; }
    [FieldNumber(421)]
    public string? Country { get; set; }
    [FieldNumber(422)]
    public string? TotNoStrikes { get; set; }
    [FieldNumber(423)]
    public string? PriceType { get; set; }
    [FieldNumber(424)]
    public string? DayOrderQty { get; set; }
    [FieldNumber(425)]
    public string? DayCumQty { get; set; }
    [FieldNumber(426)]
    public string? DayAvgPx { get; set; }
    [FieldNumber(427)]
    public string? GTBookingInst { get; set; }
    [FieldNumber(428)]
    public string? NoStrikes { get; set; }
    [FieldNumber(429)]
    public string? ListStatusType { get; set; }
    [FieldNumber(430)]
    public string? NetGrossInd { get; set; }
    [FieldNumber(431)]
    public string? ListOrderStatus { get; set; }
    [FieldNumber(432)]
    public string? ExpireDate { get; set; }
    [FieldNumber(433)]
    public string? ListExecInstType { get; set; }
    [FieldNumber(434)]
    public string? CxlRejResponseTo { get; set; }
    [FieldNumber(435)]
    public string? UnderlyingCouponRate { get; set; }
    [FieldNumber(436)]
    public string? UnderlyingContractMultiplier { get; set; }
    [FieldNumber(437)]
    public string? ContraTradeQty { get; set; }
    [FieldNumber(438)]
    public string? ContraTradeTime { get; set; }
    [FieldNumber(439)]
    [Obsolete]
    public string? ClearingFirm { get; set; }
    [FieldNumber(440)]
    [Obsolete]
    public string? ClearingAccount { get; set; }
    [FieldNumber(441)]
    public string? LiquidityNumSecurities { get; set; }
    [FieldNumber(442)]
    public string? MultiLegReportingType { get; set; }
    [FieldNumber(443)]
    public string? StrikeTime { get; set; }
    [FieldNumber(444)]
    public string? ListStatusText { get; set; }
    [FieldNumber(445)]
    public string? EncodedListStatusTextLen { get; set; }
    [FieldNumber(446)]
    public string? EncodedListStatusText { get; set; }


    [FieldNumber(447)]
    public string? PartyIDSource { get; set; }
    [FieldNumber(448)]
    public string? PartyID { get; set; }
    [FieldNumber(449)]
    [Obsolete]
    public string? TotalVolumeTradedDate { get; set; }
    [FieldNumber(450)]
    [Obsolete]
    public string? TotalVolumeTradedTime { get; set; }
    [FieldNumber(451)]
    public string? NetChgPrevDay { get; set; }
    [FieldNumber(452)]
    public string? PartyRole { get; set; }
    [FieldNumber(453)]
    public string? NoPartyIDs { get; set; }
    [FieldNumber(454)]
    public string? NoSecurityAltID { get; set; }
    [FieldNumber(455)]
    public string? SecurityAltID { get; set; }
    [FieldNumber(456)]
    public string? SecurityAltIDSource { get; set; }
    [FieldNumber(457)]
    public string? NoUnderlyingSecurityAltID { get; set; }
    [FieldNumber(458)]
    public string? UnderlyingSecurityAltID { get; set; }
    [FieldNumber(459)]
    public string? UnderlyingSecurityAltIDSource { get; set; }
    [FieldNumber(460)]
    public string? Product { get; set; }
    [FieldNumber(461)]
    public string? CFICode { get; set; }
    [FieldNumber(462)]
    public string? UnderlyingProduct { get; set; }
    [FieldNumber(463)]
    public string? UnderlyingCFICode { get; set; }
    [FieldNumber(464)]
    public string? TestMessageIndicator { get; set; }
    [FieldNumber(465)]
    [Obsolete]
    public string? QuantityType { get; set; }
    [FieldNumber(466)]
    public string? BookingRefID { get; set; }
    [FieldNumber(467)]
    public string? IndividualAllocID { get; set; }
    [FieldNumber(468)]
    public string? RoundingDirection { get; set; }
    [FieldNumber(469)]
    public string? RoundingModulus { get; set; }
    [FieldNumber(470)]
    public string? CountryOfIssue { get; set; }
    [FieldNumber(471)]
    public string? StateOrProvinceOfIssue { get; set; }
    [FieldNumber(472)]
    public string? LocaleOfIssue { get; set; }
    [FieldNumber(473)]
    public string? NoRegistDtls { get; set; }
    [FieldNumber(474)]
    public string? MailingDtls { get; set; }
    [FieldNumber(475)]
    public string? InvestorCountryOfResidence { get; set; }
    [FieldNumber(476)]
    public string? PaymentRef { get; set; }
    [FieldNumber(477)]
    public string? DistribPaymentMethod { get; set; }
    [FieldNumber(478)]
    public string? CashDistribCurr { get; set; }
    [FieldNumber(479)]
    public string? CommCurrency { get; set; }
    [FieldNumber(480)]
    public string? CancellationRights { get; set; }
    [FieldNumber(481)]
    public string? MoneyLaunderingStatus { get; set; }
    [FieldNumber(482)]
    public string? MailingInst { get; set; }
    [FieldNumber(483)]
    public string? TransBkdTime { get; set; }
    [FieldNumber(484)]
    public string? ExecPriceType { get; set; }
    [FieldNumber(485)]
    public string? ExecPriceAdjustment { get; set; }
    [FieldNumber(486)]
    public string? DateOfBirth { get; set; }
    [FieldNumber(487)]
    public string? TradeReportTransType { get; set; }
    [FieldNumber(488)]
    public string? CardHolderName { get; set; }
    [FieldNumber(489)]
    public string? CardNumber { get; set; }
    [FieldNumber(490)]
    public string? CardExpDate { get; set; }
    [FieldNumber(491)]
    public string? CardIssNum { get; set; }
    [FieldNumber(492)]
    public string? PaymentMethod { get; set; }
    [FieldNumber(493)]
    public string? RegistAcctType { get; set; }
    [FieldNumber(494)]
    public string? Designation { get; set; }
    [FieldNumber(495)]
    public string? TaxAdvantageType { get; set; }
    [FieldNumber(496)]
    public string? RegistRejReasonText { get; set; }
    [FieldNumber(497)]
    public string? FundRenewWaiv { get; set; }
    [FieldNumber(498)]
    public string? CashDistribAgentName { get; set; }
    [FieldNumber(499)]
    public string? CashDistribAgentCode { get; set; }
    [FieldNumber(500)]
    public string? CashDistribAgentAcctNumber { get; set; }
    [FieldNumber(501)]
    public string? CashDistribPayRef { get; set; }
    [FieldNumber(502)]
    public string? CashDistribAgentAcctName { get; set; }
    [FieldNumber(503)]
    public string? CardStartDate { get; set; }
    [FieldNumber(504)]
    public string? PaymentDate { get; set; }
    [FieldNumber(505)]
    public string? PaymentRemitterID { get; set; }
    [FieldNumber(506)]
    public string? RegistStatus { get; set; }
    [FieldNumber(507)]
    public string? RegistRejReasonCode { get; set; }
    [FieldNumber(508)]
    public string? RegistRefID { get; set; }
    [FieldNumber(509)]
    public string? RegistDtls { get; set; }
    [FieldNumber(510)]
    public string? NoDistribInsts { get; set; }
    [FieldNumber(511)]
    public string? RegistEmail { get; set; }
    [FieldNumber(512)]
    public string? DistribPercentage { get; set; }
    [FieldNumber(513)]
    public string? RegistID { get; set; }
    [FieldNumber(514)]
    public string? RegistTransType { get; set; }
    [FieldNumber(515)]
    public string? ExecValuationPoint { get; set; }
    [FieldNumber(516)]
    public string? OrderPercent { get; set; }
    [FieldNumber(517)]
    public string? OwnershipType { get; set; }
    [FieldNumber(518)]
    public string? NoContAmts { get; set; }
    [FieldNumber(519)]
    public string? ContAmtType { get; set; }
    [FieldNumber(520)]
    public string? ContAmtValue { get; set; }
    [FieldNumber(521)]
    public string? ContAmtCurr { get; set; }
    [FieldNumber(522)]
    public string? OwnerType { get; set; }
    [FieldNumber(523)]
    public string? PartySubID { get; set; }
    [FieldNumber(524)]
    public string? NestedPartyID { get; set; }
    [FieldNumber(525)]
    public string? NestedPartyIDSource { get; set; }
    [FieldNumber(526)]
    public string? SecondaryClOrdID { get; set; }
    [FieldNumber(527)]
    public string? SecondaryExecID { get; set; }
    [FieldNumber(528)]
    public string? OrderCapacity { get; set; }
    [FieldNumber(529)]
    public string? OrderRestrictions { get; set; }
    [FieldNumber(530)]
    public string? MassCancelRequestType { get; set; }
    [FieldNumber(531)]
    public string? MassCancelResponse { get; set; }
    [FieldNumber(532)]
    public string? MassCancelRejectReason { get; set; }
    [FieldNumber(533)]
    public string? TotalAffectedOrders { get; set; }
    [FieldNumber(534)]
    public string? NoAffectedOrders { get; set; }
    [FieldNumber(535)]
    public string? AffectedOrderID { get; set; }
    [FieldNumber(536)]
    public string? AffectedSecondaryOrderID { get; set; }
    [FieldNumber(537)]
    public string? QuoteType { get; set; }
    [FieldNumber(538)]
    public string? NestedPartyRole { get; set; }
    [FieldNumber(539)]
    public string? NoNestedPartyIDs { get; set; }
    [FieldNumber(540)]
    [Obsolete]
    public string? TotalAccruedInterestAmt { get; set; }
    [FieldNumber(541)]
    public string? MaturityDate { get; set; }
    [FieldNumber(542)]
    public string? UnderlyingMaturityDate { get; set; }
    [FieldNumber(543)]
    public string? InstrRegistry { get; set; }
    [FieldNumber(544)]
    public string? CashMargin { get; set; }
    [FieldNumber(545)]
    public string? NestedPartySubID { get; set; }
    [FieldNumber(546)]
    public string? Scope { get; set; }
    [FieldNumber(547)]
    public string? MDImplicitDelete { get; set; }
    [FieldNumber(548)]
    public string? CrossID { get; set; }
    [FieldNumber(549)]
    public string? CrossType { get; set; }
    [FieldNumber(550)]
    public string? CrossPrioritization { get; set; }
    [FieldNumber(551)]
    public string? OrigCrossID { get; set; }
    [FieldNumber(552)]
    public string? NoSides { get; set; }
    [FieldNumber(553)]
    public string? Username { get; set; }
    [FieldNumber(554)]
    public string? Password { get; set; }
    [FieldNumber(555)]
    public string? NoLegs { get; set; }
    [FieldNumber(556)]
    public string? LegCurrency { get; set; }
    [FieldNumber(557)]
    public string? TotNoSecurityTypes { get; set; }
    [FieldNumber(558)]
    public string? NoSecurityTypes { get; set; }
    [FieldNumber(559)]
    public string? SecurityListRequestType { get; set; }
    [FieldNumber(560)]
    public string? SecurityRequestResult { get; set; }
    [FieldNumber(561)]
    public string? RoundLot { get; set; }
    [FieldNumber(562)]
    public string? MinTradeVol { get; set; }
    [FieldNumber(563)]
    public string? MultiLegRptTypeReq { get; set; }
    [FieldNumber(564)]
    public string? LegPositionEffect { get; set; }
    [FieldNumber(565)]
    public string? LegCoveredOrUncovered { get; set; }
    [FieldNumber(566)]
    public string? LegPrice { get; set; }
    [FieldNumber(567)]
    public string? TradSesStatusRejReason { get; set; }
    [FieldNumber(568)]
    public string? TradeRequestID { get; set; }
    [FieldNumber(569)]
    public string? TradeRequestType { get; set; }
    [FieldNumber(570)]
    public string? PreviouslyReported { get; set; }
    [FieldNumber(571)]
    public string? TradeReportID { get; set; }
    [FieldNumber(572)]
    public string? TradeReportRefID { get; set; }
    [FieldNumber(573)]
    public string? MatchStatus { get; set; }
    [FieldNumber(574)]
    public string? MatchType { get; set; }
    [FieldNumber(575)]
    public string? OddLot { get; set; }
    [FieldNumber(576)]
    public string? NoClearingInstructions { get; set; }
    [FieldNumber(577)]
    public string? ClearingInstruction { get; set; }
    [FieldNumber(578)]
    public string? TradeInputSource { get; set; }
    [FieldNumber(579)]
    public string? TradeInputDevice { get; set; }
    [FieldNumber(580)]
    public string? NoDates { get; set; }
    [FieldNumber(581)]
    public string? AccountType { get; set; }
    [FieldNumber(582)]
    public string? CustOrderCapacity { get; set; }
    [FieldNumber(583)]
    public string? ClOrdLinkID { get; set; }
    [FieldNumber(584)]
    public string? MassStatusReqID { get; set; }
    [FieldNumber(585)]
    public string? MassStatusReqType { get; set; }
    [FieldNumber(586)]
    public string? OrigOrdModTime { get; set; }
    [FieldNumber(587)]
    public string? LegSettlType { get; set; }
    [FieldNumber(588)]
    public string? LegSettlDate { get; set; }
    [FieldNumber(589)]
    public string? DayBookingInst { get; set; }
    [FieldNumber(590)]
    public string? BookingUnit { get; set; }
    [FieldNumber(591)]
    public string? PreallocMethod { get; set; }
    [FieldNumber(592)]
    public string? UnderlyingCountryOfIssue { get; set; }
    [FieldNumber(593)]
    public string? UnderlyingStateOrProvinceOfIssue { get; set; }
    [FieldNumber(594)]
    public string? UnderlyingLocaleOfIssue { get; set; }
    [FieldNumber(595)]
    public string? UnderlyingInstrRegistry { get; set; }
    [FieldNumber(596)]
    public string? LegCountryOfIssue { get; set; }
    [FieldNumber(597)]
    public string? LegStateOrProvinceOfIssue { get; set; }
    [FieldNumber(598)]
    public string? LegLocaleOfIssue { get; set; }
    [FieldNumber(599)]
    public string? LegInstrRegistry { get; set; }
    [FieldNumber(600)]
    public string? LegSymbol { get; set; }
    [FieldNumber(601)]
    public string? LegSymbolSfx { get; set; }
    [FieldNumber(602)]
    public string? LegSecurityID { get; set; }
    [FieldNumber(603)]
    public string? LegSecurityIDSource { get; set; }
    [FieldNumber(604)]
    public string? NoLegSecurityAltID { get; set; }
    [FieldNumber(605)]
    public string? LegSecurityAltID { get; set; }
    [FieldNumber(606)]
    public string? LegSecurityAltIDSource { get; set; }
    [FieldNumber(607)]
    public string? LegProduct { get; set; }
    [FieldNumber(608)]
    public string? LegCFICode { get; set; }
    [FieldNumber(609)]
    public string? LegSecurityType { get; set; }
    [FieldNumber(610)]
    public string? LegMaturityMonthYear { get; set; }
    [FieldNumber(611)]
    public string? LegMaturityDate { get; set; }
    [FieldNumber(612)]
    public string? LegStrikePrice { get; set; }
    [FieldNumber(613)]
    public string? LegOptAttribute { get; set; }
    [FieldNumber(614)]
    public string? LegContractMultiplier { get; set; }
    [FieldNumber(615)]
    public string? LegCouponRate { get; set; }
    [FieldNumber(616)]
    public string? LegSecurityExchange { get; set; }
    [FieldNumber(617)]
    public string? LegIssuer { get; set; }
    [FieldNumber(618)]
    public string? EncodedLegIssuerLen { get; set; }
    [FieldNumber(619)]
    public string? EncodedLegIssuer { get; set; }
    [FieldNumber(620)]
    public string? LegSecurityDesc { get; set; }
    [FieldNumber(621)]
    public string? EncodedLegSecurityDescLen { get; set; }
    [FieldNumber(622)]
    public string? EncodedLegSecurityDesc { get; set; }
    [FieldNumber(623)]
    public string? LegRatioQty { get; set; }
    [FieldNumber(624)]
    public string? LegSide { get; set; }
    [FieldNumber(625)]
    public string? TradingSessionSubID { get; set; }
    [FieldNumber(626)]
    public string? AllocType { get; set; }
    [FieldNumber(627)]
    public string? NoHops { get; set; }
    [FieldNumber(628)]
    public string? HopCompID { get; set; }
    [FieldNumber(629)]
    public string? HopSendingTime { get; set; }
    [FieldNumber(630)]
    public string? HopRefID { get; set; }
    [FieldNumber(631)]
    public string? MidPx { get; set; }
    [FieldNumber(632)]
    public string? BidYield { get; set; }
    [FieldNumber(633)]
    public string? MidYield { get; set; }
    [FieldNumber(634)]
    public string? OfferYield { get; set; }
    [FieldNumber(635)]
    public string? ClearingFeeIndicator { get; set; }
    [FieldNumber(636)]
    public string? WorkingIndicator { get; set; }
    [FieldNumber(637)]
    public string? LegLastPx { get; set; }
    [FieldNumber(638)]
    public string? PriorityIndicator { get; set; }
    [FieldNumber(639)]
    public string? PriceImprovement { get; set; }
    [FieldNumber(640)]
    public string? Price2 { get; set; }
    [FieldNumber(641)]
    public string? LastForwardPoints2 { get; set; }
    [FieldNumber(642)]
    public string? BidForwardPoints2 { get; set; }
    [FieldNumber(643)]
    public string? OfferForwardPoints2 { get; set; }
    [FieldNumber(644)]
    public string? RFQReqID { get; set; }
    [FieldNumber(645)]
    public string? MktBidPx { get; set; }
    [FieldNumber(646)]
    public string? MktOfferPx { get; set; }
    [FieldNumber(647)]
    public string? MinBidSize { get; set; }
    [FieldNumber(648)]
    public string? MinOfferSize { get; set; }
    [FieldNumber(649)]
    public string? QuoteStatusReqID { get; set; }
    [FieldNumber(650)]
    public string? LegalConfirm { get; set; }
    [FieldNumber(651)]
    public string? UnderlyingLastPx { get; set; }
    [FieldNumber(652)]
    public string? UnderlyingLastQty { get; set; }
    [FieldNumber(653)]
    [Obsolete]
    public string? SecDefStatus { get; set; }
    [FieldNumber(654)]
    public string? LegRefID { get; set; }
    [FieldNumber(655)]
    public string? ContraLegRefID { get; set; }
    [FieldNumber(656)]
    public string? SettlCurrBidFxRate { get; set; }
    [FieldNumber(657)]
    public string? SettlCurrOfferFxRate { get; set; }
    [FieldNumber(658)]
    public string? QuoteRequestRejectReason { get; set; }
    [FieldNumber(659)]
    public string? SideComplianceID { get; set; }
    [FieldNumber(660)]
    public string? AcctIDSource { get; set; }
    [FieldNumber(661)]
    public string? AllocAcctIDSource { get; set; }
    [FieldNumber(662)]
    public string? BenchmarkPrice { get; set; }
    [FieldNumber(663)]
    public string? BenchmarkPriceType { get; set; }
    [FieldNumber(664)]
    public string? ConfirmID { get; set; }
    [FieldNumber(665)]
    public string? ConfirmStatus { get; set; }
    [FieldNumber(666)]
    public string? ConfirmTransType { get; set; }
    [FieldNumber(667)]
    public string? ContractSettlMonth { get; set; }
    [FieldNumber(668)]
    public string? DeliveryForm { get; set; }
    [FieldNumber(669)]
    public string? LastParPx { get; set; }
    [FieldNumber(670)]
    public string? NoLegAllocs { get; set; }
    [FieldNumber(671)]
    public string? LegAllocAccount { get; set; }
    [FieldNumber(672)]
    public string? LegIndividualAllocID { get; set; }
    [FieldNumber(673)]
    public string? LegAllocQty { get; set; }
    [FieldNumber(674)]
    public string? LegAllocAcctIDSource { get; set; }
    [FieldNumber(675)]
    public string? LegSettlCurrency { get; set; }
    [FieldNumber(676)]
    public string? LegBenchmarkCurveCurrency { get; set; }
    [FieldNumber(677)]
    public string? LegBenchmarkCurveName { get; set; }
    [FieldNumber(678)]
    public string? LegBenchmarkCurvePoint { get; set; }
    [FieldNumber(679)]
    public string? LegBenchmarkPrice { get; set; }
    [FieldNumber(680)]
    public string? LegBenchmarkPriceType { get; set; }
    [FieldNumber(681)]
    public string? LegBidPx { get; set; }
    [FieldNumber(682)]
    public string? LegIOIQty { get; set; }
    [FieldNumber(683)]
    public string? NoLegStipulations { get; set; }
    [FieldNumber(684)]
    public string? LegOfferPx { get; set; }
    [FieldNumber(685)]
    public string? LegOrderQty { get; set; }
    [FieldNumber(686)]
    public string? LegPriceType { get; set; }
    [FieldNumber(687)]
    public string? LegQty { get; set; }
    [FieldNumber(688)]
    public string? LegStipulationType { get; set; }
    [FieldNumber(689)]
    public string? LegStipulationValue { get; set; }
    [FieldNumber(690)]
    public string? LegSwapType { get; set; }
    [FieldNumber(691)]
    public string? Pool { get; set; }
    [FieldNumber(692)]
    public string? QuotePriceType { get; set; }
    [FieldNumber(693)]
    public string? QuoteRespID { get; set; }
    [FieldNumber(694)]
    public string? QuoteRespType { get; set; }
    [FieldNumber(695)]
    public string? QuoteQualifier { get; set; }
    [FieldNumber(696)]
    public string? YieldRedemptionDate { get; set; }
    [FieldNumber(697)]
    public string? YieldRedemptionPrice { get; set; }
    [FieldNumber(698)]
    public string? YieldRedemptionPriceType { get; set; }
    [FieldNumber(699)]
    public string? BenchmarkSecurityID { get; set; }
    [FieldNumber(700)]
    public string? ReversalIndicator { get; set; }
    [FieldNumber(701)]
    public string? YieldCalcDate { get; set; }
    [FieldNumber(702)]
    public string? NoPositions { get; set; }
    [FieldNumber(703)]
    public string? PosType { get; set; }
    [FieldNumber(704)]
    public string? LongQty { get; set; }
    [FieldNumber(705)]
    public string? ShortQty { get; set; }
    [FieldNumber(706)]
    public string? PosQtyStatus { get; set; }
    [FieldNumber(707)]
    public string? PosAmtType { get; set; }
    [FieldNumber(708)]
    public string? PosAmt { get; set; }
    [FieldNumber(709)]
    public string? PosTransType { get; set; }
    [FieldNumber(710)]
    public string? PosReqID { get; set; }
    [FieldNumber(711)]
    public string? NoUnderlyings { get; set; }
    [FieldNumber(712)]
    public string? PosMaintAction { get; set; }
    [FieldNumber(713)]
    public string? OrigPosReqRefID { get; set; }
    [FieldNumber(714)]
    public string? PosMaintRptRefID { get; set; }
    [FieldNumber(715)]
    public string? ClearingBusinessDate { get; set; }
    [FieldNumber(716)]
    public string? SettlSessID { get; set; }
    [FieldNumber(717)]
    public string? SettlSessSubID { get; set; }
    [FieldNumber(718)]
    public string? AdjustmentType { get; set; }
    [FieldNumber(719)]
    public string? ContraryInstructionIndicator { get; set; }
    [FieldNumber(720)]
    public string? PriorSpreadIndicator { get; set; }
    [FieldNumber(721)]
    public string? PosMaintRptID { get; set; }
    [FieldNumber(722)]
    public string? PosMaintStatus { get; set; }
    [FieldNumber(723)]
    public string? PosMaintResult { get; set; }
    [FieldNumber(724)]
    public string? PosReqType { get; set; }
    [FieldNumber(725)]
    public string? ResponseTransportType { get; set; }
    [FieldNumber(726)]
    public string? ResponseDestination { get; set; }
    [FieldNumber(727)]
    public string? TotalNumPosReports { get; set; }
    [FieldNumber(728)]
    public string? PosReqResult { get; set; }
    [FieldNumber(729)]
    public string? PosReqStatus { get; set; }
    [FieldNumber(730)]
    public string? SettlPrice { get; set; }
    [FieldNumber(731)]
    public string? SettlPriceType { get; set; }
    [FieldNumber(732)]
    public string? UnderlyingSettlPrice { get; set; }
    [FieldNumber(733)]
    public string? UnderlyingSettlPriceType { get; set; }
    [FieldNumber(734)]
    public string? PriorSettlPrice { get; set; }
    [FieldNumber(735)]
    public string? NoQuoteQualifiers { get; set; }
    [FieldNumber(736)]
    public string? AllocSettlCurrency { get; set; }
    [FieldNumber(737)]
    public string? AllocSettlCurrAmt { get; set; }
    [FieldNumber(738)]
    public string? InterestAtMaturity { get; set; }
    [FieldNumber(739)]
    public string? LegDatedDate { get; set; }
    [FieldNumber(740)]
    public string? LegPool { get; set; }
    [FieldNumber(741)]
    public string? AllocInterestAtMaturity { get; set; }
    [FieldNumber(742)]
    public string? AllocAccruedInterestAmt { get; set; }
    [FieldNumber(743)]
    public string? DeliveryDate { get; set; }
    [FieldNumber(744)]
    public string? AssignmentMethod { get; set; }
    [FieldNumber(745)]
    public string? AssignmentUnit { get; set; }
    [FieldNumber(746)]
    public string? OpenInterest { get; set; }
    [FieldNumber(747)]
    public string? ExerciseMethod { get; set; }
    [FieldNumber(748)]
    public string? TotNumTradeReports { get; set; }
    [FieldNumber(749)]
    public string? TradeRequestResult { get; set; }
    [FieldNumber(750)]
    public string? TradeRequestStatus { get; set; }
    [FieldNumber(751)]
    public string? TradeReportRejectReason { get; set; }
    [FieldNumber(752)]
    public string? SideMultiLegReportingType { get; set; }
    [FieldNumber(753)]
    public string? NoPosAmt { get; set; }
    [FieldNumber(754)]
    public string? AutoAcceptIndicator { get; set; }
    [FieldNumber(755)]
    public string? AllocReportID { get; set; }
    [FieldNumber(756)]
    public string? NoNested2PartyIDs { get; set; }
    [FieldNumber(757)]
    public string? Nested2PartyID { get; set; }
    [FieldNumber(758)]
    public string? Nested2PartyIDSource { get; set; }
    [FieldNumber(759)]
    public string? Nested2PartyRole { get; set; }
    [FieldNumber(760)]
    public string? Nested2PartySubID { get; set; }
    [FieldNumber(761)]
    public string? BenchmarkSecurityIDSource { get; set; }
    [FieldNumber(762)]
    public string? SecuritySubType { get; set; }
    [FieldNumber(763)]
    public string? UnderlyingSecuritySubType { get; set; }
    [FieldNumber(764)]
    public string? LegSecuritySubType { get; set; }
    [FieldNumber(765)]
    public string? AllowableOneSidednessPct { get; set; }
    [FieldNumber(766)]
    public string? AllowableOneSidednessValue { get; set; }
    [FieldNumber(767)]
    public string? AllowableOneSidednessCurr { get; set; }
    [FieldNumber(768)]
    public string? NoTrdRegTimestamps { get; set; }
    [FieldNumber(769)]
    public string? TrdRegTimestamp { get; set; }
    [FieldNumber(770)]
    public string? TrdRegTimestampType { get; set; }
    [FieldNumber(771)]
    public string? TrdRegTimestampOrigin { get; set; }
    [FieldNumber(772)]
    public string? ConfirmRefID { get; set; }
    [FieldNumber(773)]
    public string? ConfirmType { get; set; }
    [FieldNumber(774)]
    public string? ConfirmRejReason { get; set; }
    [FieldNumber(775)]
    public string? BookingType { get; set; }
    [FieldNumber(776)]
    public string? IndividualAllocRejCode { get; set; }
    [FieldNumber(777)]
    public string? SettlInstMsgID { get; set; }
    [FieldNumber(778)]
    public string? NoSettlInst { get; set; }
    [FieldNumber(779)]
    public string? LastUpdateTime { get; set; }
    [FieldNumber(780)]
    public string? AllocSettlInstType { get; set; }
    [FieldNumber(781)]
    public string? NoSettlPartyIDs { get; set; }
    [FieldNumber(782)]
    public string? SettlPartyID { get; set; }
    [FieldNumber(783)]
    public string? SettlPartyIDSource { get; set; }
    [FieldNumber(784)]
    public string? SettlPartyRole { get; set; }
    [FieldNumber(785)]
    public string? SettlPartySubID { get; set; }
    [FieldNumber(786)]
    public string? SettlPartySubIDType { get; set; }
    [FieldNumber(787)]
    public string? DlvyInstType { get; set; }
    [FieldNumber(788)]
    public string? TerminationType { get; set; }
    [FieldNumber(789)]
    public string? NextExpectedMsgSeqNum { get; set; }
    [FieldNumber(790)]
    public string? OrdStatusReqID { get; set; }
    [FieldNumber(791)]
    public string? SettlInstReqID { get; set; }
    [FieldNumber(792)]
    public string? SettlInstReqRejCode { get; set; }
    [FieldNumber(793)]
    public string? SecondaryAllocID { get; set; }
    [FieldNumber(794)]
    public string? AllocReportType { get; set; }
    [FieldNumber(795)]
    public string? AllocReportRefID { get; set; }
    [FieldNumber(796)]
    public string? AllocCancReplaceReason { get; set; }
    [FieldNumber(797)]
    public string? CopyMsgIndicator { get; set; }
    [FieldNumber(798)]
    public string? AllocAccountType { get; set; }
    [FieldNumber(799)]
    public string? OrderAvgPx { get; set; }
    [FieldNumber(800)]
    public string? OrderBookingQty { get; set; }
    [FieldNumber(801)]
    public string? NoSettlPartySubIDs { get; set; }
    [FieldNumber(802)]
    public string? NoPartySubIDs { get; set; }
    [FieldNumber(803)]
    public string? PartySubIDType { get; set; }
    [FieldNumber(804)]
    public string? NoNestedPartySubIDs { get; set; }
    [FieldNumber(805)]
    public string? NestedPartySubIDType { get; set; }
    [FieldNumber(806)]
    public string? NoNested2PartySubIDs { get; set; }
    [FieldNumber(807)]
    public string? Nested2PartySubIDType { get; set; }
    [FieldNumber(808)]
    public string? AllocIntermedReqType { get; set; }
    [FieldNumber(810)]
    public string? UnderlyingPx { get; set; }
    [FieldNumber(811)]
    public string? PriceDelta { get; set; }
    [FieldNumber(812)]
    public string? ApplQueueMax { get; set; }
    [FieldNumber(813)]
    public string? ApplQueueDepth { get; set; }
    [FieldNumber(814)]
    public string? ApplQueueResolution { get; set; }
    [FieldNumber(815)]
    public string? ApplQueueAction { get; set; }
    [FieldNumber(816)]
    public string? NoAltMDSource { get; set; }
    [FieldNumber(817)]
    public string? AltMDSourceID { get; set; }
    [FieldNumber(818)]
    public string? SecondaryTradeReportID { get; set; }
    [FieldNumber(819)]
    public string? AvgPxIndicator { get; set; }
    [FieldNumber(820)]
    public string? TradeLinkID { get; set; }
    [FieldNumber(821)]
    public string? OrderInputDevice { get; set; }
    [FieldNumber(822)]
    public string? UnderlyingTradingSessionID { get; set; }
    [FieldNumber(823)]
    public string? UnderlyingTradingSessionSubID { get; set; }
    [FieldNumber(824)]
    public string? TradeLegRefID { get; set; }
    [FieldNumber(825)]
    public string? ExchangeRule { get; set; }
    [FieldNumber(826)]
    public string? TradeAllocIndicator { get; set; }
    [FieldNumber(827)]
    public string? ExpirationCycle { get; set; }
    [FieldNumber(828)]
    public string? TrdType { get; set; }
    [FieldNumber(829)]
    public string? TrdSubType { get; set; }
    [FieldNumber(830)]
    public string? TransferReason { get; set; }
    [FieldNumber(831)]
    public string? AsgnReqID { get; set; }
    [FieldNumber(832)]
    public string? TotNumAssignmentReports { get; set; }
    [FieldNumber(833)]
    public string? AsgnRptID { get; set; }
    [FieldNumber(834)]
    public string? ThresholdAmount { get; set; }
    [FieldNumber(835)]
    public string? PegMoveType { get; set; }
    [FieldNumber(836)]
    public string? PegOffsetType { get; set; }
    [FieldNumber(837)]
    public string? PegLimitType { get; set; }
    [FieldNumber(838)]
    public string? PegRoundDirection { get; set; }
    [FieldNumber(839)]
    public string? PeggedPrice { get; set; }
    [FieldNumber(840)]
    public string? PegScope { get; set; }
    [FieldNumber(841)]
    public string? DiscretionMoveType { get; set; }
    [FieldNumber(842)]
    public string? DiscretionOffsetType { get; set; }
    [FieldNumber(843)]
    public string? DiscretionLimitType { get; set; }
    [FieldNumber(844)]
    public string? DiscretionRoundDirection { get; set; }
    [FieldNumber(845)]
    public string? DiscretionPrice { get; set; }
    [FieldNumber(846)]
    public string? DiscretionScope { get; set; }
    [FieldNumber(847)]
    public string? TargetStrategy { get; set; }
    [FieldNumber(848)]
    public string? TargetStrategyParameters { get; set; }
    [FieldNumber(849)]
    public string? ParticipationRate { get; set; }
    [FieldNumber(850)]
    public string? TargetStrategyPerformance { get; set; }
    [FieldNumber(851)]
    public string? LastLiquidityInd { get; set; }
    [FieldNumber(852)]
    public string? PublishTrdIndicator { get; set; }
    [FieldNumber(853)]
    public string? ShortSaleReason { get; set; }
    [FieldNumber(854)]
    public string? QtyType { get; set; }
    [FieldNumber(855)]
    public string? SecondaryTrdType { get; set; }
    [FieldNumber(856)]
    public string? TradeReportType { get; set; }
    [FieldNumber(857)]
    public string? AllocNoOrdersType { get; set; }
    [FieldNumber(858)]
    public string? SharedCommission { get; set; }
    [FieldNumber(859)]
    public string? ConfirmReqID { get; set; }
    [FieldNumber(860)]
    public string? AvgParPx { get; set; }
    [FieldNumber(861)]
    public string? ReportedPx { get; set; }
    [FieldNumber(862)]
    public string? NoCapacities { get; set; }
    [FieldNumber(863)]
    public string? OrderCapacityQty { get; set; }
    [FieldNumber(864)]
    public string? NoEvents { get; set; }
    [FieldNumber(865)]
    public string? EventType { get; set; }
    [FieldNumber(866)]
    public string? EventDate { get; set; }
    [FieldNumber(867)]
    public string? EventPx { get; set; }
    [FieldNumber(868)]
    public string? EventText { get; set; }
    [FieldNumber(869)]
    public string? PctAtRisk { get; set; }
    [FieldNumber(870)]
    public string? NoInstrAttrib { get; set; }
    [FieldNumber(871)]
    public string? InstrAttribType { get; set; }
    [FieldNumber(872)]
    public string? InstrAttribValue { get; set; }
    [FieldNumber(873)]
    public string? DatedDate { get; set; }
    [FieldNumber(874)]
    public string? InterestAccrualDate { get; set; }
    [FieldNumber(875)]
    public string? CPProgram { get; set; }
    [FieldNumber(876)]
    public string? CPRegType { get; set; }
    [FieldNumber(877)]
    public string? UnderlyingCPProgram { get; set; }
    [FieldNumber(878)]
    public string? UnderlyingCPRegType { get; set; }
    [FieldNumber(879)]
    public string? UnderlyingQty { get; set; }
    [FieldNumber(880)]
    public string? TrdMatchID { get; set; }
    [FieldNumber(881)]
    public string? SecondaryTradeReportRefID { get; set; }
    [FieldNumber(882)]
    public string? UnderlyingDirtyPrice { get; set; }
    [FieldNumber(883)]
    public string? UnderlyingEndPrice { get; set; }
    [FieldNumber(884)]
    public string? UnderlyingStartValue { get; set; }
    [FieldNumber(885)]
    public string? UnderlyingCurrentValue { get; set; }
    [FieldNumber(886)]
    public string? UnderlyingEndValue { get; set; }
    [FieldNumber(887)]
    public string? NoUnderlyingStips { get; set; }
    [FieldNumber(888)]
    public string? UnderlyingStipType { get; set; }
    [FieldNumber(889)]
    public string? UnderlyingStipValue { get; set; }
    [FieldNumber(890)]
    public string? MaturityNetMoney { get; set; }
    [FieldNumber(891)]
    public string? MiscFeeBasis { get; set; }
    [FieldNumber(892)]
    public string? TotNoAllocs { get; set; }
    [FieldNumber(893)]
    public string? LastFragment { get; set; }
    [FieldNumber(894)]
    public string? CollReqID { get; set; }
    [FieldNumber(895)]
    public string? CollAsgnReason { get; set; }
    [FieldNumber(896)]
    public string? CollInquiryQualifier { get; set; }
    [FieldNumber(897)]
    public string? NoTrades { get; set; }
    [FieldNumber(898)]
    public string? MarginRatio { get; set; }
    [FieldNumber(899)]
    public string? MarginExcess { get; set; }
    [FieldNumber(900)]
    public string? TotalNetValue { get; set; }
    [FieldNumber(901)]
    public string? CashOutstanding { get; set; }
    [FieldNumber(902)]
    public string? CollAsgnID { get; set; }
    [FieldNumber(903)]
    public string? CollAsgnTransType { get; set; }
    [FieldNumber(904)]
    public string? CollRespID { get; set; }
    [FieldNumber(905)]
    public string? CollAsgnRespType { get; set; }
    [FieldNumber(906)]
    public string? CollAsgnRejectReason { get; set; }
    [FieldNumber(907)]
    public string? CollAsgnRefID { get; set; }
    [FieldNumber(908)]
    public string? CollRptID { get; set; }
    [FieldNumber(909)]
    public string? CollInquiryID { get; set; }
    [FieldNumber(910)]
    public string? CollStatus { get; set; }
    [FieldNumber(911)]
    public string? TotNumReports { get; set; }
    [FieldNumber(912)]
    public string? LastRptRequested { get; set; }
    [FieldNumber(913)]
    public string? AgreementDesc { get; set; }
    [FieldNumber(914)]
    public string? AgreementID { get; set; }
    [FieldNumber(915)]
    public string? AgreementDate { get; set; }
    [FieldNumber(916)]
    public string? StartDate { get; set; }
    [FieldNumber(917)]
    public string? EndDate { get; set; }
    [FieldNumber(918)]
    public string? AgreementCurrency { get; set; }
    [FieldNumber(919)]
    public string? DeliveryType { get; set; }
    [FieldNumber(920)]
    public string? EndAccruedInterestAmt { get; set; }
    [FieldNumber(921)]
    public string? StartCash { get; set; }
    [FieldNumber(922)]
    public string? EndCash { get; set; }
    [FieldNumber(923)]
    public string? UserRequestID { get; set; }
    [FieldNumber(924)]
    public string? UserRequestType { get; set; }
    [FieldNumber(925)]
    public string? NewPassword { get; set; }
    [FieldNumber(926)]
    public string? UserStatus { get; set; }
    [FieldNumber(927)]
    public string? UserStatusText { get; set; }
    [FieldNumber(928)]
    public string? StatusValue { get; set; }
    [FieldNumber(929)]
    public string? StatusText { get; set; }
    [FieldNumber(930)]
    public string? RefCompID { get; set; }
    [FieldNumber(931)]
    public string? RefSubID { get; set; }
    [FieldNumber(932)]
    public string? NetworkResponseID { get; set; }
    [FieldNumber(933)]
    public string? NetworkRequestID { get; set; }
    [FieldNumber(934)]
    public string? LastNetworkResponseID { get; set; }
    [FieldNumber(935)]
    public string? NetworkRequestType { get; set; }
    [FieldNumber(936)]
    public string? NoCompIDs { get; set; }
    [FieldNumber(937)]
    public string? NetworkStatusResponseType { get; set; }
    [FieldNumber(938)]
    public string? NoCollInquiryQualifier { get; set; }
    [FieldNumber(939)]
    public string? TrdRptStatus { get; set; }
    [FieldNumber(940)]
    public string? AffirmStatus { get; set; }
    [FieldNumber(941)]
    public string? UnderlyingStrikeCurrency { get; set; }
    [FieldNumber(942)]
    public string? LegStrikeCurrency { get; set; }
    [FieldNumber(943)]
    public string? TimeBracket { get; set; }
    [FieldNumber(944)]
    public string? CollAction { get; set; }
    [FieldNumber(945)]
    public string? CollInquiryStatus { get; set; }
    [FieldNumber(946)]
    public string? CollInquiryResult { get; set; }
    [FieldNumber(947)]
    public string? StrikeCurrency { get; set; }
    [FieldNumber(948)]
    public string? NoNested3PartyIDs { get; set; }
    [FieldNumber(949)]
    public string? Nested3PartyID { get; set; }
    [FieldNumber(950)]
    public string? Nested3PartyIDSource { get; set; }
    [FieldNumber(951)]
    public string? Nested3PartyRole { get; set; }
    [FieldNumber(952)]
    public string? NoNested3PartySubIDs { get; set; }
    [FieldNumber(953)]
    public string? Nested3PartySubID { get; set; }
    [FieldNumber(954)]
    public string? Nested3PartySubIDType { get; set; }
    [FieldNumber(955)]
    public string? LegContractSettlMonth { get; set; }
    [FieldNumber(956)]
    public string? LegInterestAccrualDate { get; set; }

    public string? ListNoOrds => TotNoOrders;
    public string? OrderCapacity => Rule80A;
}
