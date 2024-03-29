using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using WebexSDK;

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern double WebexSDKVersionNumber;
	[Field ("WebexSDKVersionNumber", "__Internal")]
	double WebexSDKVersionNumber { get; }

	// extern const unsigned char [] WebexSDKVersionString;
	[Field ("WebexSDKVersionString", "__Internal")]
	byte[] WebexSDKVersionString { get; }
}

// @protocol AppleSparkClientProvider
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
interface AppleSparkClientProvider
{
	// @required @property (readonly, nonatomic) NSString * _Nonnull userAgent;
	[Abstract]
	[Export ("userAgent")]
	string UserAgent { get; }

	// @required @property (readonly, nonatomic) NSString * _Nonnull oauthClientId;
	[Abstract]
	[Export ("oauthClientId")]
	string OauthClientId { get; }

	// @required @property (readonly, nonatomic) NSString * _Nonnull oauthClientSecret;
	[Abstract]
	[Export ("oauthClientSecret")]
	string OauthClientSecret { get; }

	// @required @property (readonly, nonatomic) NSString * _Nonnull oauthAdditionalScopes;
	[Abstract]
	[Export ("oauthAdditionalScopes")]
	string OauthAdditionalScopes { get; }

	// @required @property (readonly, nonatomic) NSString * _Nonnull oauthRedirectUri;
	[Abstract]
	[Export ("oauthRedirectUri")]
	string OauthRedirectUri { get; }

	// @required @property (readonly, nonatomic) NSString * _Nonnull applicationVersion;
	[Abstract]
	[Export ("applicationVersion")]
	string ApplicationVersion { get; }

	// @required @property (readonly, nonatomic) NSString * _Nonnull operatingSystemVersion;
	[Abstract]
	[Export ("operatingSystemVersion")]
	string OperatingSystemVersion { get; }

	// @required @property (readonly, nonatomic) NSString * _Nonnull operatingSystemLanguage;
	[Abstract]
	[Export ("operatingSystemLanguage")]
	string OperatingSystemLanguage { get; }

	// @required @property (readonly, nonatomic) NSString * _Nonnull platformInfo;
	[Abstract]
	[Export ("platformInfo")]
	string PlatformInfo { get; }

	// @required @property (readonly, nonatomic) NSString * _Nonnull databasePath;
	[Abstract]
	[Export ("databasePath")]
	string DatabasePath { get; }

	// @required @property (readonly, nonatomic) NSString * _Nonnull wdmDeviceType;
	[Abstract]
	[Export ("wdmDeviceType")]
	string WdmDeviceType { get; }

	// @required @property (readonly, nonatomic) NSString * _Nonnull platformEncryptionIdentifier;
	[Abstract]
	[Export ("platformEncryptionIdentifier")]
	string PlatformEncryptionIdentifier { get; }

	// @required @property (readonly, nonatomic) NSString * _Nonnull appType;
	[Abstract]
	[Export ("appType")]
	string AppType { get; }

	// @required -(NSString * _Nullable)extraTelemetryMetaDataForMetricEventName:(NSString * _Nonnull)metricEventName;
	[Abstract]
	[Export ("extraTelemetryMetaDataForMetricEventName:")]
	[return: NullAllowed]
	string ExtraTelemetryMetaDataForMetricEventName (string metricEventName);

	// @required @property (readonly, nonatomic) NSString * _Nonnull productName;
	[Abstract]
	[Export ("productName")]
	string ProductName { get; }

	// @required @property (readonly, getter = isDeveloperVersion, nonatomic) BOOL developerVersion;
	[Abstract]
	[Export ("developerVersion")]
	bool DeveloperVersion { [Bind ("isDeveloperVersion")] get; }

	// @required @property (readonly, getter = isTablet, nonatomic) BOOL tablet;
	[Abstract]
	[Export ("tablet")]
	bool Tablet { [Bind ("isTablet")] get; }

	// @required @property (readonly, nonatomic) NSString * _Nonnull appleAccessGroupIdentifier;
	[Abstract]
	[Export ("appleAccessGroupIdentifier")]
	string AppleAccessGroupIdentifier { get; }

	// @required -(NSString * _Nullable)additionalClientConfigForConfigName:(NSString * _Nonnull)configName;
	[Abstract]
	[Export ("additionalClientConfigForConfigName:")]
	[return: NullAllowed]
	string AdditionalClientConfigForConfigName (string configName);

	// @required @property (readonly, nonatomic) NSString * _Nonnull u2cUrl;
	[Abstract]
	[Export ("u2cUrl")]
	string U2cUrl { get; }
}

// @interface RootLoggerImpl : NSObject
[BaseType (typeof(NSObject))]
interface RootLoggerImpl
{
	// +(RootLoggerImpl *)sharedInstance;
	[Static]
	[Export ("sharedInstance")]
	[Verify (MethodToProperty)]
	RootLoggerImpl SharedInstance { get; }

	// -(void)configLogger:(NSURL *)logsDirectory;
	[Export ("configLogger:")]
	void ConfigLogger (NSURL logsDirectory);

	// -(void)setLogFilterLevel:(RootLoggerLevel)level;
	[Export ("setLogFilterLevel:")]
	void SetLogFilterLevel (RootLoggerLevel level);

	// -(void)enableCoutLogger:(BOOL)enable;
	[Export ("enableCoutLogger:")]
	void EnableCoutLogger (bool enable);

	// -(void)logMessage:(NSString *)msg atLevel:(RootLoggerLevel)level withLine:(int)lineNumber inFile:(const char *)filename inFunction:(const char *)fnName;
	[Export ("logMessage:atLevel:withLine:inFile:inFunction:")]
	unsafe void LogMessage (string msg, RootLoggerLevel level, int lineNumber, sbyte* filename, sbyte* fnName);

	// -(void)clear;
	[Export ("clear")]
	void Clear ();

	// -(void)prepareExit;
	[Export ("prepareExit")]
	void PrepareExit ();
}

// @protocol WebexBroadcastCallServerProtocol
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
interface WebexBroadcastCallServerProtocol
{
	// @required -(void)startBroadcast;
	[Abstract]
	[Export ("startBroadcast")]
	void StartBroadcast ();

	// @required -(void)stopBroadcast;
	[Abstract]
	[Export ("stopBroadcast")]
	void StopBroadcast ();

	// @required -(void)setup;
	[Abstract]
	[Export ("setup")]
	void Setup ();

	// @required -(void)sendFrameWithTimeStamp:(NSNumber * _Nonnull)timeStamp width:(NSNumber * _Nonnull)width height:(NSNumber * _Nonnull)height data:(void * _Nonnull)data length:(NSNumber * _Nonnull)length;
	[Abstract]
	[Export ("sendFrameWithTimeStamp:width:height:data:length:")]
	unsafe void SendFrameWithTimeStamp (NSNumber timeStamp, NSNumber width, NSNumber height, void* data, NSNumber length);
}

// @interface BroadcastUtil : NSObject
[BaseType (typeof(NSObject))]
interface BroadcastUtil
{
	[Wrap ("WeakDelegate")]
	[NullAllowed]
	WebexBroadcastCallServerProtocol Delegate { get; set; }

	// @property (nonatomic, weak) id<WebexBroadcastCallServerProtocol> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// -(BOOL)isBroadcastFrameworkAvailable;
	[Export ("isBroadcastFrameworkAvailable")]
	[Verify (MethodToProperty)]
	bool IsBroadcastFrameworkAvailable { get; }

	// -(BOOL)initScreenShareService:(NSError * _Nullable * _Nullable)error;
	[Export ("initScreenShareService:")]
	bool InitScreenShareService ([NullAllowed] out NSError error);

	// -(void)sharingStateChanged:(BOOL)sendingScreenShare;
	[Export ("sharingStateChanged:")]
	void SharingStateChanged (bool sendingScreenShare);

	// -(void)suspend;
	[Export ("suspend")]
	void Suspend ();

	// -(void)closeScreenShare;
	[Export ("closeScreenShare")]
	void CloseScreenShare ();
}

// typedef void (^SingleBoolCompletionFuncCallback)(BOOL);
delegate void SingleBoolCompletionFuncCallback (bool arg0);

// typedef void (^AccessTokenResultCompletionFuncCallback)(enum CHJWTTokenResult, NSString * _Nullable);
delegate void AccessTokenResultCompletionFuncCallback (CHJWTTokenResult arg0, [NullAllowed] string arg1);

// typedef void (^GuestIssuerResultCompletionFuncCallback)(enum CHJWTTokenResult);
delegate void GuestIssuerResultCompletionFuncCallback (CHJWTTokenResult arg0);

// typedef void (^GetOAuthUrlCompletionFuncCallback)(enum CHOAuthResult, NSString * _Nullable);
delegate void GetOAuthUrlCompletionFuncCallback (CHOAuthResult arg0, [NullAllowed] string arg1);

// typedef void (^OAuthResultCompletionFuncCallback)(enum CHOAuthResult);
delegate void OAuthResultCompletionFuncCallback (CHOAuthResult arg0);

// typedef void (^AccessTokenLoginResultCompletionFuncCallback)(enum CHAccessTokenLoginResult);
delegate void AccessTokenLoginResultCompletionFuncCallback (CHAccessTokenLoginResult arg0);

// typedef void (^VoidCompletionFuncCallback)();
delegate void VoidCompletionFuncCallback ();

// typedef void (^TeamCreateResultCompletionFuncCallback)(enum CHTeamCreateResult, CHTeam * _Nullable);
delegate void TeamCreateResultCompletionFuncCallback (CHTeamCreateResult arg0, [NullAllowed] CHTeam arg1);

// typedef void (^TeamListResultCompletionFuncCallback)(enum CHTeamListResult, NSArray<CHTeam *> * _Nullable);
delegate void TeamListResultCompletionFuncCallback (CHTeamListResult arg0, [NullAllowed] CHTeam[] arg1);

// typedef void (^TeamGetResultCompletionFuncCallback)(enum CHTeamGetResult, CHTeam * _Nullable);
delegate void TeamGetResultCompletionFuncCallback (CHTeamGetResult arg0, [NullAllowed] CHTeam arg1);

// typedef void (^TeamArchiveResultCompletionFuncCallback)(enum CHTeamArchiveResult);
delegate void TeamArchiveResultCompletionFuncCallback (CHTeamArchiveResult arg0);

// typedef void (^TeamUpdateResultCompletionFuncCallback)(enum CHTeamUpdateResult, CHTeam * _Nullable);
delegate void TeamUpdateResultCompletionFuncCallback (CHTeamUpdateResult arg0, [NullAllowed] CHTeam arg1);

// typedef void (^MarkMessageResultCompletionFuncCallback)(CHMarkMessageReadResult);
delegate void MarkMessageResultCompletionFuncCallback (CHMarkMessageReadResult arg0);

// typedef void (^SingleMessageCompletionFuncCallback)(CHMessage * _Nullable, CHGetMessageResult);
delegate void SingleMessageCompletionFuncCallback ([NullAllowed] CHMessage arg0, CHGetMessageResult arg1);

// typedef void (^MessageDeleteResultCompletionFuncCallback)(CHDeleteMessageResult);
delegate void MessageDeleteResultCompletionFuncCallback (CHDeleteMessageResult arg0);

// typedef void (^MessagePostCompletionFuncCallback)(CHMessage * _Nullable, CHMessageResult);
delegate void MessagePostCompletionFuncCallback ([NullAllowed] CHMessage arg0, CHMessageResult arg1);

// typedef void (^MessageEventCompletionCallback)(enum CHMessageEvent, CHMessage * _Nonnull);
delegate void MessageEventCompletionCallback (CHMessageEvent arg0, CHMessage arg1);

// typedef void (^MessageEventWithPayloadCompletionCallback)(enum CHMessageEvent, CHMessage * _Nonnull, NSString * _Nullable);
delegate void MessageEventWithPayloadCompletionCallback (CHMessageEvent arg0, CHMessage arg1, [NullAllowed] string arg2);

// typedef void (^PersonGetResultCompletionFuncCallback)(enum CHPersonGetResult, CHPerson * _Nullable, NSString * _Nullable);
delegate void PersonGetResultCompletionFuncCallback (CHPersonGetResult arg0, [NullAllowed] CHPerson arg1, [NullAllowed] string arg2);

// typedef void (^GetMembershipByMembershipIdCompletionFuncCallback)(CHMembership * _Nullable, CHGetMembershipByIdResult);
delegate void GetMembershipByMembershipIdCompletionFuncCallback ([NullAllowed] CHMembership arg0, CHGetMembershipByIdResult arg1);

// typedef void (^CreateMembershipCompletionFuncCallback)(CHCreateSpaceMembershipResult, CHMembership * _Nullable);
delegate void CreateMembershipCompletionFuncCallback (CHCreateSpaceMembershipResult arg0, [NullAllowed] CHMembership arg1);

// typedef void (^ListPersonsCompletionFuncCallback)(NSArray<CHPerson *> * _Nullable, CHListPersonsResult, NSString * _Nullable);
delegate void ListPersonsCompletionFuncCallback ([NullAllowed] CHPerson[] arg0, CHListPersonsResult arg1, [NullAllowed] string arg2);

// typedef void (^CreatePersonCompletionFuncCallback)(CHPersonCreateResult, CHPerson * _Nullable, NSString * _Nullable);
delegate void CreatePersonCompletionFuncCallback (CHPersonCreateResult arg0, [NullAllowed] CHPerson arg1, [NullAllowed] string arg2);

// typedef void (^UpdatePersonCompletionFuncCallback)(CHPersonUpdateResult, CHPerson * _Nullable, NSString * _Nullable);
delegate void UpdatePersonCompletionFuncCallback (CHPersonUpdateResult arg0, [NullAllowed] CHPerson arg1, [NullAllowed] string arg2);

// typedef void (^DeletePersonCompletionFuncCallback)(enum CHPersonDeleteResult, NSString * _Nullable);
delegate void DeletePersonCompletionFuncCallback (CHPersonDeleteResult arg0, [NullAllowed] string arg1);

// typedef void (^MembershipUpdateResultCompletionFuncCallback)(enum CHMembershipUpdateResult, CHMembership * _Nullable);
delegate void MembershipUpdateResultCompletionFuncCallback (CHMembershipUpdateResult arg0, [NullAllowed] CHMembership arg1);

// typedef void (^ListMessagesCompletionFuncCallback)(NSArray<CHMessage *> * _Nullable, CHListMessagesResult);
delegate void ListMessagesCompletionFuncCallback ([NullAllowed] CHMessage[] arg0, CHListMessagesResult arg1);

// typedef void (^MembershipDeleteResultCompletionFuncCallback)(CHMembershipDeleteResult);
delegate void MembershipDeleteResultCompletionFuncCallback (CHMembershipDeleteResult arg0);

// typedef void (^ListTeamMembershipCompletionFuncCallback)(enum CHListTeamMembershipResult, NSArray<CHTeamMembership *> * _Nullable, NSString * _Nullable);
delegate void ListTeamMembershipCompletionFuncCallback (CHListTeamMembershipResult arg0, [NullAllowed] CHTeamMembership[] arg1, [NullAllowed] string arg2);

// typedef void (^CreateTeamMembershipCompletionFuncCallback)(CHCreateTeamMembershipResult, CHTeamMembership * _Nullable);
delegate void CreateTeamMembershipCompletionFuncCallback (CHCreateTeamMembershipResult arg0, [NullAllowed] CHTeamMembership arg1);

// typedef void (^GetTeamMembershipCompletionFuncCallback)(enum CHGetTeamMembershipResult, CHTeamMembership * _Nullable, NSString * _Nullable);
delegate void GetTeamMembershipCompletionFuncCallback (CHGetTeamMembershipResult arg0, [NullAllowed] CHTeamMembership arg1, [NullAllowed] string arg2);

// typedef void (^UpdateTeamMembershipCompletionFuncCallback)(enum CHUpdateTeamMembershipResult, CHTeamMembership * _Nullable);
delegate void UpdateTeamMembershipCompletionFuncCallback (CHUpdateTeamMembershipResult arg0, [NullAllowed] CHTeamMembership arg1);

// typedef void (^DeleteTeamMembershipCompletionFuncCallback)(enum CHDeleteTeamMembershipResult);
delegate void DeleteTeamMembershipCompletionFuncCallback (CHDeleteTeamMembershipResult arg0);

// typedef void (^ListMembershipsCompletionFuncCallback)(CHListMembershipResult, NSArray<CHMembership *> * _Nullable, NSString * _Nullable);
delegate void ListMembershipsCompletionFuncCallback (CHListMembershipResult arg0, [NullAllowed] CHMembership[] arg1, [NullAllowed] string arg2);

// typedef void (^ListMembershipsReadStatusCompletionFuncCallback)(enum CHListMembershipsReadStatusResult, NSArray<CHMembershipReadStatus *> * _Nullable);
delegate void ListMembershipsReadStatusCompletionFuncCallback (CHListMembershipsReadStatusResult arg0, [NullAllowed] CHMembershipReadStatus[] arg1);

// typedef void (^MembershipEventCompletionCallback)(enum CHMembershipEvent, CHMembership * _Nonnull, NSString * _Nullable);
delegate void MembershipEventCompletionCallback (CHMembershipEvent arg0, CHMembership arg1, [NullAllowed] string arg2);

// typedef void (^MembershipEventWithPayloadCompletionCallback)(enum CHMembershipEvent, CHMembership * _Nonnull, NSString * _Nullable, NSString * _Nullable);
delegate void MembershipEventWithPayloadCompletionCallback (CHMembershipEvent arg0, CHMembership arg1, [NullAllowed] string arg2, [NullAllowed] string arg3);

// typedef void (^UpdateSpaceTitleResultCompletionFuncCallback)(CHUpdateSpaceTitleResult, CHSpace * _Nullable);
delegate void UpdateSpaceTitleResultCompletionFuncCallback (CHUpdateSpaceTitleResult arg0, [NullAllowed] CHSpace arg1);

// typedef void (^ListSpacesCompletionFuncCallback)(NSArray<CHSpace *> * _Nullable);
delegate void ListSpacesCompletionFuncCallback ([NullAllowed] CHSpace[] arg0);

// typedef void (^SingleSpaceCompletionFuncCallback)(CHSpace * _Nullable);
delegate void SingleSpaceCompletionFuncCallback ([NullAllowed] CHSpace arg0);

// typedef void (^DeleteSpaceCompletionFuncCallback)(CHDeleteSpaceResult, NSString * _Nullable);
delegate void DeleteSpaceCompletionFuncCallback (CHDeleteSpaceResult arg0, [NullAllowed] string arg1);

// typedef void (^SingleSpaceReadStatusCompletionFuncCallback)(CHSpaceReadStatus * _Nullable);
delegate void SingleSpaceReadStatusCompletionFuncCallback ([NullAllowed] CHSpaceReadStatus arg0);

// typedef void (^ListSpaceReadStatusCompletionFuncCallback)(NSArray<CHSpaceReadStatus *> * _Nullable);
delegate void ListSpaceReadStatusCompletionFuncCallback ([NullAllowed] CHSpaceReadStatus[] arg0);

// typedef void (^SpaceEventCompletionCallback)(enum CHSpaceEvent, CHSpace * _Nonnull);
delegate void SpaceEventCompletionCallback (CHSpaceEvent arg0, CHSpace arg1);

// typedef void (^SpaceEventWithPayloadCompletionCallback)(enum CHSpaceEvent, CHSpace * _Nonnull, NSString * _Nullable);
delegate void SpaceEventWithPayloadCompletionCallback (CHSpaceEvent arg0, CHSpace arg1, [NullAllowed] string arg2);

// typedef void (^MessageDownloadFileCompletionFuncCallback)(NSString * _Nonnull, enum CHDownloadFileResult);
delegate void MessageDownloadFileCompletionFuncCallback (string arg0, CHDownloadFileResult arg1);

// typedef void (^MessageThumbnailResultCompletionFuncCallback)(NSData * _Nullable, enum CHDownloadThumbnailResult);
delegate void MessageThumbnailResultCompletionFuncCallback ([NullAllowed] NSData arg0, CHDownloadThumbnailResult arg1);

// typedef void (^ListWebhooksCompletionFuncCallback)(enum CHListWebhooksResult, NSArray<CHWebhook *> * _Nullable, NSString * _Nullable);
delegate void ListWebhooksCompletionFuncCallback (CHListWebhooksResult arg0, [NullAllowed] CHWebhook[] arg1, [NullAllowed] string arg2);

// typedef void (^CreateWebhookCompletionFuncCallback)(enum CHCreateWebhookResult, CHWebhook * _Nullable, NSString * _Nullable);
delegate void CreateWebhookCompletionFuncCallback (CHCreateWebhookResult arg0, [NullAllowed] CHWebhook arg1, [NullAllowed] string arg2);

// typedef void (^GetWebhookCompletionFuncCallback)(enum CHGetWebhookByIdResult, CHWebhook * _Nullable, NSString * _Nullable);
delegate void GetWebhookCompletionFuncCallback (CHGetWebhookByIdResult arg0, [NullAllowed] CHWebhook arg1, [NullAllowed] string arg2);

// typedef void (^UpdateWebhookCompletionFuncCallback)(enum CHUpdateWebhookByIdResult, CHWebhook * _Nullable, NSString * _Nullable);
delegate void UpdateWebhookCompletionFuncCallback (CHUpdateWebhookByIdResult arg0, [NullAllowed] CHWebhook arg1, [NullAllowed] string arg2);

// typedef void (^DeleteWebhookCompletionFuncCallback)(enum CHDeleteWebhookByIdResult, NSString * _Nullable);
delegate void DeleteWebhookCompletionFuncCallback (CHDeleteWebhookByIdResult arg0, [NullAllowed] string arg1);

// typedef void (^MessageDownloadFileProgressCompletionFuncCallback)(double);
delegate void MessageDownloadFileProgressCompletionFuncCallback (double arg0);

// typedef void (^Base64EncodeCompletionFuncCallback)(NSString * _Nonnull, enum CHBase64EncodeResult, NSString * _Nullable);
delegate void Base64EncodeCompletionFuncCallback (string arg0, CHBase64EncodeResult arg1, [NullAllowed] string arg2);

// typedef void (^CallScheduleChangedCompletionCallback)(CHCall * _Nullable);
delegate void CallScheduleChangedCompletionCallback ([NullAllowed] CHCall arg0);

// typedef void (^CallStartedCompletionCallback)(_Bool, CHCall * _Nullable);
delegate void CallStartedCompletionCallback (bool arg0, [NullAllowed] CHCall arg1);

// typedef void (^DeviceChangedCompletionCallback)(CHCall * _Nullable);
delegate void DeviceChangedCompletionCallback ([NullAllowed] CHCall arg0);

// typedef void (^IncomingCompletionCallback)(CHCall * _Nullable);
delegate void IncomingCompletionCallback ([NullAllowed] CHCall arg0);

// typedef void (^CallFailedCompletionCallback)(CHCall * _Nullable, NSString * _Nonnull);
delegate void CallFailedCompletionCallback ([NullAllowed] CHCall arg0, string arg1);

// typedef void (^CallRingingChangedCompletionCallback)(CHCall * _Nullable);
delegate void CallRingingChangedCompletionCallback ([NullAllowed] CHCall arg0);

// typedef void (^CallConnectedCompletionCallback)(CHCall * _Nullable);
delegate void CallConnectedCompletionCallback ([NullAllowed] CHCall arg0);

// typedef void (^CallDisconnectedCompletionCallback)(CHCall * _Nullable);
delegate void CallDisconnectedCompletionCallback ([NullAllowed] CHCall arg0);

// typedef void (^CallTerminatedCompletionCallback)(CHCall * _Nullable);
delegate void CallTerminatedCompletionCallback ([NullAllowed] CHCall arg0);

// typedef void (^CallInfoChangedCompletionCallback)(CHCall * _Nullable);
delegate void CallInfoChangedCompletionCallback ([NullAllowed] CHCall arg0);

// typedef void (^ListSpacesActiveCallsCompletionCallback)(NSArray<CHSpace *> * _Nullable);
delegate void ListSpacesActiveCallsCompletionCallback ([NullAllowed] CHSpace[] arg0);

// typedef void (^LetInCompletionCallback)(enum CHLetInResult);
delegate void LetInCompletionCallback (CHLetInResult arg0);

// typedef void (^CompositedVideoLayoutCompletionCallback)(enum CHSetCompositedLayoutResult);
delegate void CompositedVideoLayoutCompletionCallback (CHSetCompositedLayoutResult arg0);

// typedef void (^ApplyVirtualBackgroundCompletionCallback)(enum CHApplyVirtualBackgroundResult);
delegate void ApplyVirtualBackgroundCompletionCallback (CHApplyVirtualBackgroundResult arg0);

// typedef void (^DeleteVirtualBackgroundCompletionCallback)(enum CHDeleteVirtualBackgroundResult);
delegate void DeleteVirtualBackgroundCompletionCallback (CHDeleteVirtualBackgroundResult arg0);

// typedef void (^PreviewVirtualBackgroundCompletionCallback)(enum CHPreviewVirtualBackgroundResult);
delegate void PreviewVirtualBackgroundCompletionCallback (CHPreviewVirtualBackgroundResult arg0);

// typedef void (^UploadVirtualBackgroundCompletionCallback)(CHVirtualBackgroundItem * _Nullable, NSData * _Nullable, enum CHUploadVirtualBackgroundResult);
delegate void UploadVirtualBackgroundCompletionCallback ([NullAllowed] CHVirtualBackgroundItem arg0, [NullAllowed] NSData arg1, CHUploadVirtualBackgroundResult arg2);

// typedef void (^FetchVirtualBackgroundCompletionCallback)(NSArray<CHVirtualBackgroundItem *> * _Nullable, NSArray<NSData *> * _Nullable, enum CHFetchVirtualBackgroundResult);
delegate void FetchVirtualBackgroundCompletionCallback ([NullAllowed] CHVirtualBackgroundItem[] arg0, [NullAllowed] NSData[] arg1, CHFetchVirtualBackgroundResult arg2);

// typedef void (^CallOnHitCpuThresholdCompletionCallback)();
delegate void CallOnHitCpuThresholdCompletionCallback ();

// typedef void (^CallTranscriptionArrivedCompletionCallback)(CHCall * _Nonnull, CHTranscription * _Nonnull);
delegate void CallTranscriptionArrivedCompletionCallback (CHCall arg0, CHTranscription arg1);

// typedef void (^ListCalendarMeetingsCompletionCallback)(enum CHListCalendarMeetingsResult, NSArray<CHMeeting *> * _Nullable);
delegate void ListCalendarMeetingsCompletionCallback (CHListCalendarMeetingsResult arg0, [NullAllowed] CHMeeting[] arg1);

// typedef void (^GetCalendarMeetingCompletionCallback)(enum CHGetCalendarMeetingByIdResult, CHMeeting * _Nullable);
delegate void GetCalendarMeetingCompletionCallback (CHGetCalendarMeetingByIdResult arg0, [NullAllowed] CHMeeting arg1);

// typedef void (^CalendarMeetingEventCompletionCallback)(enum CHCalendarMeetingEvent, CHMeeting * _Nonnull);
delegate void CalendarMeetingEventCompletionCallback (CHCalendarMeetingEvent arg0, CHMeeting arg1);

// typedef void (^VideoForceLandscapeCompletionCallback)(BOOL);
delegate void VideoForceLandscapeCompletionCallback (bool arg0);

// typedef void (^CallPhotoOutputCompletionCallback)(NSData * _Nullable);
delegate void CallPhotoOutputCompletionCallback ([NullAllowed] NSData arg0);

// @protocol OmniusServiceBridgeDelegate
[Protocol, Model (AutoGeneratedName = true)]
interface OmniusServiceBridgeDelegate
{
	// @required -(void)omniusServiceBridge:(id<OmniusServiceBridgeProtocol> _Nonnull)omniusServiceBridge showUCSSOLoginView:(NSString * _Nonnull)ssoUrl;
	[Abstract]
	[Export ("omniusServiceBridge:showUCSSOLoginView:")]
	void OmniusServiceBridge (OmniusServiceBridgeProtocol omniusServiceBridge, string ssoUrl);

	// @required -(void)omniusServiceBridgeShowUCNonSSOLoginView:(id<OmniusServiceBridgeProtocol> _Nonnull)omniusServiceBridge;
	[Abstract]
	[Export ("omniusServiceBridgeShowUCNonSSOLoginView:")]
	void OmniusServiceBridgeShowUCNonSSOLoginView (OmniusServiceBridgeProtocol omniusServiceBridge);

	// @required -(void)omniusServiceBridgeOnUCLoggedIn:(id<OmniusServiceBridgeProtocol> _Nonnull)omniusServiceBridge;
	[Abstract]
	[Export ("omniusServiceBridgeOnUCLoggedIn:")]
	void OmniusServiceBridgeOnUCLoggedIn (OmniusServiceBridgeProtocol omniusServiceBridge);

	// @required -(void)omniusServiceBridgeOnUCLoggedOut:(id<OmniusServiceBridgeProtocol> _Nonnull)omniusServiceBridge;
	[Abstract]
	[Export ("omniusServiceBridgeOnUCLoggedOut:")]
	void OmniusServiceBridgeOnUCLoggedOut (OmniusServiceBridgeProtocol omniusServiceBridge);

	// @required -(void)omniusServiceBridgeOnUCLoginFailed:(id<OmniusServiceBridgeProtocol> _Nonnull)omniusServiceBridge;
	[Abstract]
	[Export ("omniusServiceBridgeOnUCLoginFailed:")]
	void OmniusServiceBridgeOnUCLoginFailed (OmniusServiceBridgeProtocol omniusServiceBridge);

	// @required -(void)omniusServiceBridge:(id<OmniusServiceBridgeProtocol> _Nonnull)omniusServiceBridge onUCServerConnectionStateChanged:(CHUCLoginServerConnectionStatus)status failureReason:(CHPhoneServiceRegistrationFailureReason)failureReason;
	[Abstract]
	[Export ("omniusServiceBridge:onUCServerConnectionStateChanged:failureReason:")]
	void OmniusServiceBridge (OmniusServiceBridgeProtocol omniusServiceBridge, CHUCLoginServerConnectionStatus status, CHPhoneServiceRegistrationFailureReason failureReason);
}

// @protocol OmniusServiceBridgeProtocol
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
interface OmniusServiceBridgeProtocol
{
	[Wrap ("WeakDelegate"), Abstract]
	[NullAllowed]
	OmniusServiceBridgeDelegate Delegate { get; set; }

	// @required @property (nonatomic, weak) id<OmniusServiceBridgeDelegate> _Nullable delegate;
	[Abstract]
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @required -(instancetype _Nonnull)initWithSparkClientProvider:(id<AppleSparkClientProvider> _Nonnull)sparkClientProvider;
	[Abstract]
	[Export ("initWithSparkClientProvider:")]
	IntPtr Constructor (AppleSparkClientProvider sparkClientProvider);

	// @required -(void)getAuthorizationUrl:(NSString * _Nonnull)email callback:(GetOAuthUrlCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("getAuthorizationUrl(email:callback:)")));
	[Abstract]
	[Export ("getAuthorizationUrl:callback:")]
	void GetAuthorizationUrl (string email, GetOAuthUrlCompletionFuncCallback callback);

	// @required -(void)signOut:(VoidCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("signOut(callback:)")));
	[Abstract]
	[Export ("signOut:")]
	void SignOut (VoidCompletionFuncCallback callback);

	// @required -(void)appTransition:(BOOL)isInBackground __attribute__((swift_name("appTransition(isInBackground:)")));
	[Abstract]
	[Export ("appTransition:")]
	void AppTransition (bool isInBackground);

	// @required -(_Bool)hasActiveCalls __attribute__((swift_name("hasActiveCalls()")));
	[Abstract]
	[Export ("hasActiveCalls")]
	[Verify (MethodToProperty)]
	bool HasActiveCalls { get; }

	// @required -(_Bool)isLoggedIn;
	[Abstract]
	[Export ("isLoggedIn")]
	[Verify (MethodToProperty)]
	bool IsLoggedIn { get; }

	// @required -(void)attemptToLoginWithCachedUser:(SingleBoolCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("attemptToLoginWithCachedUser(callback:)")));
	[Abstract]
	[Export ("attemptToLoginWithCachedUser:")]
	void AttemptToLoginWithCachedUser (SingleBoolCompletionFuncCallback callback);

	// @required -(void)loginWithAuthCode:(NSString * _Nonnull)authCode emailId:(NSString * _Nonnull)emailId callback:(OAuthResultCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("loginWithAuthCode(authCode:emailId:callback:)")));
	[Abstract]
	[Export ("loginWithAuthCode:emailId:callback:")]
	void LoginWithAuthCode (string authCode, string emailId, OAuthResultCompletionFuncCallback callback);

	// @required -(void)loginWithJWT:(NSString * _Nonnull)jwt callback:(GuestIssuerResultCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("loginWithJWT(jwt:callback:)")));
	[Abstract]
	[Export ("loginWithJWT:callback:")]
	void LoginWithJWT (string jwt, GuestIssuerResultCompletionFuncCallback callback);

	// @required -(void)loginWithAccessToken:(NSString * _Nonnull)accessToken expiresInSeconds:(NSNumber * _Nullable)expiresInSeconds callback:(AccessTokenLoginResultCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("loginWithAccessToken(accessToken:expiresInSeconds:callback:)")));
	[Abstract]
	[Export ("loginWithAccessToken:expiresInSeconds:callback:")]
	void LoginWithAccessToken (string accessToken, [NullAllowed] NSNumber expiresInSeconds, AccessTokenLoginResultCompletionFuncCallback callback);

	// @required -(void)setOnTokenExpiredListener:(VoidCompletionFuncCallback _Nullable)callback __attribute__((swift_name("setOnTokenExpiredListener(callback:)")));
	[Abstract]
	[Export ("setOnTokenExpiredListener:")]
	void SetOnTokenExpiredListener ([NullAllowed] VoidCompletionFuncCallback callback);

	// @required -(void)getAccessToken:(AccessTokenResultCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("getAccessToken(callback:)")));
	[Abstract]
	[Export ("getAccessToken:")]
	void GetAccessToken (AccessTokenResultCompletionFuncCallback callback);

	// @required -(void)refreshAccessToken:(AccessTokenResultCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("refreshAccessToken(callback:)")));
	[Abstract]
	[Export ("refreshAccessToken:")]
	void RefreshAccessToken (AccessTokenResultCompletionFuncCallback callback);

	// @required -(NSString * _Nullable)getJwtToken;
	[Abstract]
	[NullAllowed, Export ("getJwtToken")]
	[Verify (MethodToProperty)]
	string JwtToken { get; }

	// @required -(NSDate * _Nullable)getGuestIssuerAccessTokenExpiration;
	[Abstract]
	[NullAllowed, Export ("getGuestIssuerAccessTokenExpiration")]
	[Verify (MethodToProperty)]
	NSDate GuestIssuerAccessTokenExpiration { get; }

	// @required -(NSDate * _Nullable)getGuestIssuerJwtExpiration;
	[Abstract]
	[NullAllowed, Export ("getGuestIssuerJwtExpiration")]
	[Verify (MethodToProperty)]
	NSDate GuestIssuerJwtExpiration { get; }

	// @required -(void)addLoginTelemetry:(enum CHTelemetry)loginEvent startTime:(NSDate * _Nonnull)startTime endTime:(NSDate * _Nonnull)endTime __attribute__((swift_name("addLoginTelemetry(loginEvent:startTime:endTime:)")));
	[Abstract]
	[Export ("addLoginTelemetry:startTime:endTime:")]
	void AddLoginTelemetry (CHTelemetry loginEvent, NSDate startTime, NSDate endTime);

	// @required -(void)isNetworkReachable:(BOOL)isNetworkReachable;
	[Abstract]
	[Export ("isNetworkReachable:")]
	void IsNetworkReachable (bool isNetworkReachable);

	// @required -(void)setUCDomainServerUrl:(NSString * _Nonnull)ucDomain serverUrl:(NSString * _Nonnull)serverUrl __attribute__((swift_name("setUCDomainServerUrl(ucDomain:serverUrl:)")));
	[Abstract]
	[Export ("setUCDomainServerUrl:serverUrl:")]
	void SetUCDomainServerUrl (string ucDomain, string serverUrl);

	// @required -(void)setCUCMCredential:(NSString * _Nonnull)username password:(NSString * _Nonnull)password __attribute__((swift_name("setCUCMCredential(username:password:)")));
	[Abstract]
	[Export ("setCUCMCredential:password:")]
	void SetCUCMCredential (string username, string password);

	// @required -(void)processSSOBrowserNavigationResult:(enum CHUCBrowserLoginSSONavResult)result currentUrl:(NSString * _Nonnull)currentUrl document:(NSString * _Nonnull)document __attribute__((swift_name("processSSOBrowserNavigationResult(result:currentUrl:document:)")));
	[Abstract]
	[Export ("processSSOBrowserNavigationResult:currentUrl:document:")]
	void ProcessSSOBrowserNavigationResult (CHUCBrowserLoginSSONavResult result, string currentUrl, string document);

	// @required -(void)ucCancelSSOLogin;
	[Abstract]
	[Export ("ucCancelSSOLogin")]
	void UcCancelSSOLogin ();

	// @required -(_Bool)isUCLoggedIn;
	[Abstract]
	[Export ("isUCLoggedIn")]
	[Verify (MethodToProperty)]
	bool IsUCLoggedIn { get; }

	// @required -(CHUCLoginServerConnectionStatus)getUCServerConnectionStatus;
	[Abstract]
	[Export ("getUCServerConnectionStatus")]
	[Verify (MethodToProperty)]
	CHUCLoginServerConnectionStatus UCServerConnectionStatus { get; }

	// @required -(void)getSearchResult:(NSString * _Nonnull)searchString callback:(ListSpacesCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("getSearchResult(searchString:callback:)")));
	[Abstract]
	[Export ("getSearchResult:callback:")]
	void GetSearchResult (string searchString, ListSpacesCompletionFuncCallback callback);

	// @required -(NSArray<CHSpace *> * _Nonnull)getCallHistory;
	[Abstract]
	[Export ("getCallHistory")]
	[Verify (MethodToProperty)]
	CHSpace[] CallHistory { get; }

	// @required -(NSString * _Nullable)dial:(NSString * _Nonnull)input __attribute__((swift_name("dial(input:)")));
	[Abstract]
	[Export ("dial:")]
	[return: NullAllowed]
	string Dial (string input);

	// @required -(NSString * _Nullable)dial:(NSString * _Nonnull)input localVideoView:(void * _Nullable)localVideoView remoteVideoView:(void * _Nullable)remoteVideoView sharingVideoView:(void * _Nullable)sharingVideoView __attribute__((swift_name("dial(input:localVideoView:remoteVideoView:sharingVideoView:)")));
	[Abstract]
	[Export ("dial:localVideoView:remoteVideoView:sharingVideoView:")]
	[return: NullAllowed]
	unsafe string Dial (string input, [NullAllowed] void* localVideoView, [NullAllowed] void* remoteVideoView, [NullAllowed] void* sharingVideoView);

	// @required -(void)startShare:(NSString * _Nonnull)callId __attribute__((swift_name("startShare(callId:)")));
	[Abstract]
	[Export ("startShare:")]
	void StartShare (string callId);

	// @required -(void)stopShare:(NSString * _Nonnull)callId __attribute__((swift_name("stopShare(callId:)")));
	[Abstract]
	[Export ("stopShare:")]
	void StopShare (string callId);

	// @required -(void)setupExternalInput:(NSString * _Nonnull)callId height:(NSNumber * _Nonnull)height width:(NSNumber * _Nonnull)width __attribute__((swift_name("setupExternalInput(callId:height:width:)")));
	[Abstract]
	[Export ("setupExternalInput:height:width:")]
	void SetupExternalInput (string callId, NSNumber height, NSNumber width);

	// @required -(void)sendFrameToExternalInputter:(NSString * _Nonnull)callId timeStamp:(NSNumber * _Nonnull)timeStamp height:(NSNumber * _Nonnull)height width:(NSNumber * _Nonnull)width data:(void *const _Nonnull)data length:(NSNumber * _Nonnull)length __attribute__((swift_name("sendFrameToExternalInputter(callId:timeStamp:height:width:data:length:)")));
	[Abstract]
	[Export ("sendFrameToExternalInputter:timeStamp:height:width:data:length:")]
	unsafe void SendFrameToExternalInputter (string callId, NSNumber timeStamp, NSNumber height, NSNumber width, void* data, NSNumber length);

	// @required -(void)answer:(NSString * _Nonnull)callId isModerator:(_Bool)isModerator pin:(NSString * _Nonnull)pin localVideoView:(void * _Nullable)localVideoView remoteVideoView:(void * _Nullable)remoteVideoView sharingVideoView:(void * _Nullable)sharingVideoView callback:(CallStartedCompletionCallback _Nullable)callback __attribute__((swift_name("answer(callId:isModerator:pin:localVideoView:remoteVideoView:sharingVideoView:callback:)")));
	[Abstract]
	[Export ("answer:isModerator:pin:localVideoView:remoteVideoView:sharingVideoView:callback:")]
	unsafe void Answer (string callId, bool isModerator, string pin, [NullAllowed] void* localVideoView, [NullAllowed] void* remoteVideoView, [NullAllowed] void* sharingVideoView, [NullAllowed] CallStartedCompletionCallback callback);

	// @required -(NSArray<CHMeetingInfo *> * _Nullable)getSchedules:(NSString * _Nonnull)callId __attribute__((swift_name("getSchedules(callId:)")));
	[Abstract]
	[Export ("getSchedules:")]
	[return: NullAllowed]
	CHMeetingInfo[] GetSchedules (string callId);

	// @required -(void)joinCall:(NSString * _Nonnull)callId isModerator:(_Bool)isModerator pin:(NSString * _Nonnull)pin isAudioOnly:(_Bool)isAudioOnly callback:(CallStartedCompletionCallback _Nullable)callback __attribute__((swift_name("joinCall(callId:isModerator:pin:isAudioOnly:callback:)")));
	[Abstract]
	[Export ("joinCall:isModerator:pin:isAudioOnly:callback:")]
	void JoinCall (string callId, bool isModerator, string pin, bool isAudioOnly, [NullAllowed] CallStartedCompletionCallback callback);

	// @required -(void)declineCall:(NSString * _Nonnull)callId __attribute__((swift_name("declineCall(callId:)")));
	[Abstract]
	[Export ("declineCall:")]
	void DeclineCall (string callId);

	// @required -(void)endCall:(NSString * _Nonnull)callId __attribute__((swift_name("endCall(callId:)")));
	[Abstract]
	[Export ("endCall:")]
	void EndCall (string callId);

	// @required -(void)endActiveCall;
	[Abstract]
	[Export ("endActiveCall")]
	void EndActiveCall ();

	// @required -(void)muteAudio:(NSString * _Nonnull)callId participantId:(NSString * _Nonnull)participantId isMuted:(_Bool)isMuted __attribute__((swift_name("muteAudio(callId:participantId:isMuted:)")));
	[Abstract]
	[Export ("muteAudio:participantId:isMuted:")]
	void MuteAudio (string callId, string participantId, bool isMuted);

	// @required -(void)muteAll:(NSString * _Nonnull)callId doMute:(_Bool)doMute __attribute__((swift_name("muteAll(callId:doMute:)")));
	[Abstract]
	[Export ("muteAll:doMute:")]
	void MuteAll (string callId, bool doMute);

	// @required -(_Bool)isOnHold:(NSString * _Nonnull)callId __attribute__((swift_name("isOnHold(callId:)")));
	[Abstract]
	[Export ("isOnHold:")]
	bool IsOnHold (string callId);

	// @required -(void)holdCall:(NSString * _Nonnull)callId isMuted:(_Bool)onHold __attribute__((swift_name("holdCall(callId:onHold:)")));
	[Abstract]
	[Export ("holdCall:isMuted:")]
	void HoldCall (string callId, bool onHold);

	// @required -(void)startAssociatedCall:(NSString * _Nonnull)callId dialNumber:(NSString * _Nonnull)dialNumber associationType:(enum CHCallAssociationType)associationType audioCall:(_Bool)audioCall callback:(CallStartedCompletionCallback _Nullable)callback __attribute__((swift_name("startAssociatedCall(callId:dialNumber:associationType:audioCall:callback:)")));
	[Abstract]
	[Export ("startAssociatedCall:dialNumber:associationType:audioCall:callback:")]
	void StartAssociatedCall (string callId, string dialNumber, CHCallAssociationType associationType, bool audioCall, [NullAllowed] CallStartedCompletionCallback callback);

	// @required -(void)transferCall:(NSString * _Nonnull)fromCallId toCallId:(NSString * _Nonnull)toCallId __attribute__((swift_name("transferCall(fromCallId:toCallId:)")));
	[Abstract]
	[Export ("transferCall:toCallId:")]
	void TransferCall (string fromCallId, string toCallId);

	// @required -(void)mergeCall:(NSString * _Nonnull)callId targetCallId:(NSString * _Nonnull)targetCallId __attribute__((swift_name("mergeCall(callId:targetCallId:)")));
	[Abstract]
	[Export ("mergeCall:targetCallId:")]
	void MergeCall (string callId, string targetCallId);

	// @required -(void)swapCamera:(NSString * _Nonnull)callId __attribute__((swift_name("swapCamera(callId:)")));
	[Abstract]
	[Export ("swapCamera:")]
	void SwapCamera (string callId);

	// @required -(NSArray<CHCallMembership *> * _Nonnull)getCallMemberships:(NSString * _Nonnull)callId __attribute__((swift_name("getCallMemberships(callId:)")));
	[Abstract]
	[Export ("getCallMemberships:")]
	CHCallMembership[] GetCallMemberships (string callId);

	// @required -(NSString * _Nonnull)getCallIdByNotificationId:(NSString * _Nonnull)notificationId notificationType:(enum CHNotificationCallType)notificationType __attribute__((swift_name("getCallIdByNotificationId(notificationId:notificationType:)")));
	[Abstract]
	[Export ("getCallIdByNotificationId:notificationType:")]
	string GetCallIdByNotificationId (string notificationId, CHNotificationCallType notificationType);

	// @required -(CHCall * _Nullable)getCall:(NSString * _Nonnull)callId __attribute__((swift_name("getCall(callId:)")));
	[Abstract]
	[Export ("getCall:")]
	[return: NullAllowed]
	CHCall GetCall (string callId);

	// @required -(void)setVideoMaxTxFPS:(NSNumber * _Nonnull)fps __attribute__((swift_name("setVideoMaxTxFPS(fps:)")));
	[Abstract]
	[Export ("setVideoMaxTxFPS:")]
	void SetVideoMaxTxFPS (NSNumber fps);

	// @required -(void)setVideoEnableDecoderMosaic:(_Bool)value __attribute__((swift_name("setVideoEnableDecoderMosaic(value:)")));
	[Abstract]
	[Export ("setVideoEnableDecoderMosaic:")]
	void SetVideoEnableDecoderMosaic (bool value);

	// @required -(NSString * _Nonnull)getWmeVersion __attribute__((swift_name("getWmeVersion()")));
	[Abstract]
	[Export ("getWmeVersion")]
	[Verify (MethodToProperty)]
	string WmeVersion { get; }

	// @required -(void)letIn:(NSString * _Nonnull)callId participantIds:(NSArray<NSString *> * _Nonnull)participantIds callback:(LetInCompletionCallback _Nonnull)callback __attribute__((swift_name("letIn(callId:participantIds:callback:)")));
	[Abstract]
	[Export ("letIn:participantIds:callback:")]
	void LetIn (string callId, string[] participantIds, LetInCompletionCallback callback);

	// @required -(void)sendFeedback:(NSNumber * _Nonnull)rating comments:(NSString * _Nonnull)comments __attribute__((swift_name("sendFeedback(rating:comments:)")));
	[Abstract]
	[Export ("sendFeedback:comments:")]
	void SendFeedback (NSNumber rating, string comments);

	// @required -(NSString * _Nonnull)sendDTMF:(NSString * _Nonnull)callId keys:(NSString * _Nonnull)keys __attribute__((swift_name("sendDTMF(callId:keys:)")));
	[Abstract]
	[Export ("sendDTMF:keys:")]
	string SendDTMF (string callId, string keys);

	// @required -(void)enableBNR:(NSString * _Nonnull)callId enable:(_Bool)enable __attribute__((swift_name("enableBNR(callId:enable:)")));
	[Abstract]
	[Export ("enableBNR:enable:")]
	void EnableBNR (string callId, bool enable);

	// @required -(_Bool)isBNREnabled:(NSString * _Nonnull)callId __attribute__((swift_name("isBNREnabled(callId:)")));
	[Abstract]
	[Export ("isBNREnabled:")]
	bool IsBNREnabled (string callId);

	// @required -(_Bool)setBNRProfileMode:(NSString * _Nonnull)callId mode:(NSNumber * _Nonnull)mode __attribute__((swift_name("setBNRProfileMode(callId:mode:)")));
	[Abstract]
	[Export ("setBNRProfileMode:mode:")]
	bool SetBNRProfileMode (string callId, NSNumber mode);

	// @required -(NSNumber * _Nonnull)getBNRProfileMode:(NSString * _Nonnull)callId __attribute__((swift_name("getBNRProfileMode(callId:)")));
	[Abstract]
	[Export ("getBNRProfileMode:")]
	NSNumber GetBNRProfileMode (string callId);

	// @required -(void)setVideoMaxRxBandwidth:(NSNumber * _Nonnull)bandwidth __attribute__((swift_name("setVideoMaxRxBandwidth(bandwidth:)")));
	[Abstract]
	[Export ("setVideoMaxRxBandwidth:")]
	void SetVideoMaxRxBandwidth (NSNumber bandwidth);

	// @required -(void)setVideoMaxTxBandwidth:(NSNumber * _Nonnull)bandwidth __attribute__((swift_name("setVideoMaxTxBandwidth(bandwidth:)")));
	[Abstract]
	[Export ("setVideoMaxTxBandwidth:")]
	void SetVideoMaxTxBandwidth (NSNumber bandwidth);

	// @required -(void)setSharingMaxRxBandwidth:(NSNumber * _Nonnull)bandwidth __attribute__((swift_name("setSharingMaxRxBandwidth(bandwidth:)")));
	[Abstract]
	[Export ("setSharingMaxRxBandwidth:")]
	void SetSharingMaxRxBandwidth (NSNumber bandwidth);

	// @required -(void)setAudioMaxRxBandwidth:(NSNumber * _Nonnull)bandwidth __attribute__((swift_name("setAudioMaxRxBandwidth(bandwidth:)")));
	[Abstract]
	[Export ("setAudioMaxRxBandwidth:")]
	void SetAudioMaxRxBandwidth (NSNumber bandwidth);

	// @required -(_Bool)cameraFocusAtPoint:(NSString * _Nonnull)callId pointX:(NSNumber * _Nonnull)pointX pointY:(NSNumber * _Nonnull)pointY __attribute__((swift_name("cameraFocusAtPoint(callId:pointX:pointY:)")));
	[Abstract]
	[Export ("cameraFocusAtPoint:pointX:pointY:")]
	bool CameraFocusAtPoint (string callId, NSNumber pointX, NSNumber pointY);

	// @required -(_Bool)setCameraFlashMode:(NSString * _Nonnull)callId mode:(enum CHVideoFlashMode)mode __attribute__((swift_name("setCameraFlashMode(callId:mode:)")));
	[Abstract]
	[Export ("setCameraFlashMode:mode:")]
	bool SetCameraFlashMode (string callId, CHVideoFlashMode mode);

	// @required -(enum CHVideoFlashMode)getCameraFlashMode:(NSString * _Nonnull)callId __attribute__((swift_name("getCameraFlashMode(callId:)")));
	[Abstract]
	[Export ("getCameraFlashMode:")]
	CHVideoFlashMode GetCameraFlashMode (string callId);

	// @required -(enum CHVideoTorchMode)getCameraTorchMode:(NSString * _Nonnull)callId __attribute__((swift_name("getCameraTorchMode(callId:)")));
	[Abstract]
	[Export ("getCameraTorchMode:")]
	CHVideoTorchMode GetCameraTorchMode (string callId);

	// @required -(_Bool)setCameraTorchMode:(NSString * _Nonnull)callId mode:(enum CHVideoTorchMode)mode __attribute__((swift_name("setCameraTorchMode(callId:mode:)")));
	[Abstract]
	[Export ("setCameraTorchMode:mode:")]
	bool SetCameraTorchMode (string callId, CHVideoTorchMode mode);

	// @required -(CHCameraExposureDuration * _Nonnull)getCameraExposureDuration:(NSString * _Nonnull)callId __attribute__((swift_name("getCameraExposureDuration(callId:)")));
	[Abstract]
	[Export ("getCameraExposureDuration:")]
	CHCameraExposureDuration GetCameraExposureDuration (string callId);

	// @required -(CHCameraExposureISO * _Nonnull)getCameraExposureISO:(NSString * _Nonnull)callId __attribute__((swift_name("getCameraExposureISO(callId:)")));
	[Abstract]
	[Export ("getCameraExposureISO:")]
	CHCameraExposureISO GetCameraExposureISO (string callId);

	// @required -(CHCameraExposureTargetBias * _Nonnull)getCameraExposureTargetBias:(NSString * _Nonnull)callId __attribute__((swift_name("getCameraExposureTargetBias(callId:)")));
	[Abstract]
	[Export ("getCameraExposureTargetBias:")]
	CHCameraExposureTargetBias GetCameraExposureTargetBias (string callId);

	// @required -(_Bool)setCameraCustomExposure:(NSString * _Nonnull)callId duration:(NSNumber * _Nonnull)duration iso:(NSNumber * _Nonnull)iso __attribute__((swift_name("setCameraCustomExposure(callId:duration:iso:)")));
	[Abstract]
	[Export ("setCameraCustomExposure:duration:iso:")]
	bool SetCameraCustomExposure (string callId, NSNumber duration, NSNumber iso);

	// @required -(_Bool)setCameraAutoExposure:(NSString * _Nonnull)callId targetBias:(NSNumber * _Nonnull)targetBias __attribute__((swift_name("setCameraAutoExposure(callId:targetBias:)")));
	[Abstract]
	[Export ("setCameraAutoExposure:targetBias:")]
	bool SetCameraAutoExposure (string callId, NSNumber targetBias);

	// @required -(_Bool)setVideoZoomFactor:(NSString * _Nonnull)callId factor:(NSNumber * _Nonnull)factor __attribute__((swift_name("setVideoZoomFactor(callId:factor:)")));
	[Abstract]
	[Export ("setVideoZoomFactor:factor:")]
	bool SetVideoZoomFactor (string callId, NSNumber factor);

	// @required -(NSNumber * _Nonnull)getVideoZoomFactor:(NSString * _Nonnull)callId __attribute__((swift_name("getVideoZoomFactor(callId:)")));
	[Abstract]
	[Export ("getVideoZoomFactor:")]
	NSNumber GetVideoZoomFactor (string callId);

	// @required -(_Bool)takePhoto:(NSString * _Nonnull)callId __attribute__((swift_name("takePhoto(callId:)")));
	[Abstract]
	[Export ("takePhoto:")]
	bool TakePhoto (string callId);

	// @required -(void)startPreview:(void * _Nonnull)viewHandle __attribute__((swift_name("startPreview(viewHandle:)")));
	[Abstract]
	[Export ("startPreview:")]
	unsafe void StartPreview (void* viewHandle);

	// @required -(void)stopPreview __attribute__((swift_name("stopPreview()")));
	[Abstract]
	[Export ("stopPreview")]
	void StopPreview ();

	// @required -(void)setVideoStreamMode:(enum CHVideoStreamMode)mode __attribute__((swift_name("setVideoStreamMode(mode:)")));
	[Abstract]
	[Export ("setVideoStreamMode:")]
	void SetVideoStreamMode (CHVideoStreamMode mode);

	// @required -(enum CHVideoStreamMode)getVideoStreamMode __attribute__((swift_name("getVideoStreamMode()")));
	[Abstract]
	[Export ("getVideoStreamMode")]
	[Verify (MethodToProperty)]
	CHVideoStreamMode VideoStreamMode { get; }

	// @required -(void)setCompositedVideoLayout:(NSString * _Nonnull)callId layout:(enum CHCompositedVideoLayout)layout __attribute__((swift_name("setCompositedVideoLayout(callId:layout:)")));
	[Abstract]
	[Export ("setCompositedVideoLayout:layout:")]
	void SetCompositedVideoLayout (string callId, CHCompositedVideoLayout layout);

	// @required -(void)setCompositedVideoLayout:(NSString * _Nonnull)callId layout:(enum CHCompositedVideoLayout)layout callback:(CompositedVideoLayoutCompletionCallback _Nonnull)callback __attribute__((swift_name("setCompositedVideoLayout(callId:layout:callback:)")));
	[Abstract]
	[Export ("setCompositedVideoLayout:layout:callback:")]
	void SetCompositedVideoLayout (string callId, CHCompositedVideoLayout layout, CompositedVideoLayoutCompletionCallback callback);

	// @required -(enum CHCompositedVideoLayout)getCompositedVideoLayout:(NSString * _Nonnull)callId __attribute__((swift_name("getCompositedVideoLayout(callId:)")));
	[Abstract]
	[Export ("getCompositedVideoLayout:")]
	CHCompositedVideoLayout GetCompositedVideoLayout (string callId);

	// @required -(void)addAuxVideoView:(NSString * _Nonnull)callId type:(enum CHMediaStreamType)type auxView:(void * _Nullable)auxView __attribute__((swift_name("addAuxVideoView(callId:type:auxView:)")));
	[Abstract]
	[Export ("addAuxVideoView:type:auxView:")]
	unsafe void AddAuxVideoView (string callId, CHMediaStreamType type, [NullAllowed] void* auxView);

	// @required -(void)removeAuxVideoView:(NSString * _Nonnull)callId type:(enum CHMediaStreamType)type auxView:(void * _Nullable)auxView __attribute__((swift_name("removeAuxVideoView(callId:type:auxView:)")));
	[Abstract]
	[Export ("removeAuxVideoView:type:auxView:")]
	unsafe void RemoveAuxVideoView (string callId, CHMediaStreamType type, [NullAllowed] void* auxView);

	// @required -(void)setDefaultCameraMode:(NSNumber * _Nonnull)mode __attribute__((swift_name("setDefaultCameraMode(mode:)")));
	[Abstract]
	[Export ("setDefaultCameraMode:")]
	void SetDefaultCameraMode (NSNumber mode);

	// @required -(void)setVideoRenderViews:(NSString * _Nonnull)callId localVideoView:(void * _Nullable)localVideoView remoteVideoView:(void * _Nullable)remoteVideoView __attribute__((swift_name("setVideoRenderViews(callId:localVideoView:remoteVideoView:)")));
	[Abstract]
	[Export ("setVideoRenderViews:localVideoView:remoteVideoView:")]
	unsafe void SetVideoRenderViews (string callId, [NullAllowed] void* localVideoView, [NullAllowed] void* remoteVideoView);

	// @required -(void)setSharingRenderView:(NSString * _Nonnull)callId sharingVideoView:(void * _Nullable)sharingVideoView __attribute__((swift_name("setSharingRenderView(callId:sharingVideoView:)")));
	[Abstract]
	[Export ("setSharingRenderView:sharingVideoView:")]
	unsafe void SetSharingRenderView (string callId, [NullAllowed] void* sharingVideoView);

	// @required -(void)restartAudioSession:(NSString * _Nonnull)callId;
	[Abstract]
	[Export ("restartAudioSession:")]
	void RestartAudioSession (string callId);

	// @required -(void)restartMediaSession:(NSString * _Nonnull)callId;
	[Abstract]
	[Export ("restartMediaSession:")]
	void RestartMediaSession (string callId);

	// @required -(void)setRemoteVideoRenderMode:(NSString * _Nonnull)callId mode:(CHVideoRenderMode)mode __attribute__((swift_name("setRemoteVideoRenderMode(callId:mode:)")));
	[Abstract]
	[Export ("setRemoteVideoRenderMode:mode:")]
	void SetRemoteVideoRenderMode (string callId, CHVideoRenderMode mode);

	// @required -(void)setIncomingCallListener:(IncomingCompletionCallback _Nonnull)callback __attribute__((swift_name("setIncomingCallListener(callback:)")));
	[Abstract]
	[Export ("setIncomingCallListener:")]
	void SetIncomingCallListener (IncomingCompletionCallback callback);

	// @required -(void)setDeviceChangedListener:(NSString * _Nonnull)callId callback:(DeviceChangedCompletionCallback _Nonnull)callback __attribute__((swift_name("setDeviceChangedListener(callId:callback:)")));
	[Abstract]
	[Export ("setDeviceChangedListener:callback:")]
	void SetDeviceChangedListener (string callId, DeviceChangedCompletionCallback callback);

	// @required -(void)setSendingVideo:(NSString * _Nonnull)callId sending:(_Bool)sending __attribute__((swift_name("setSendingVideo(callId:sending:)")));
	[Abstract]
	[Export ("setSendingVideo:sending:")]
	void SetSendingVideo (string callId, bool sending);

	// @required -(void)setSendingAudio:(NSString * _Nonnull)callId sending:(_Bool)sending __attribute__((swift_name("setSendingAudio(callId:sending:)")));
	[Abstract]
	[Export ("setSendingAudio:sending:")]
	void SetSendingAudio (string callId, bool sending);

	// @required -(void)setSendingSharing:(NSString * _Nonnull)callId sending:(_Bool)sending sourceId:(NSString * _Nonnull)sourceId __attribute__((swift_name("setSendingSharing(callId:sending:sourceId:)")));
	[Abstract]
	[Export ("setSendingSharing:sending:sourceId:")]
	void SetSendingSharing (string callId, bool sending, string sourceId);

	// @required -(void)setReceivingVideo:(NSString * _Nonnull)callId receiving:(_Bool)receiving __attribute__((swift_name("setReceivingVideo(callId:receiving:)")));
	[Abstract]
	[Export ("setReceivingVideo:receiving:")]
	void SetReceivingVideo (string callId, bool receiving);

	// @required -(void)setReceivingAudio:(NSString * _Nonnull)callId receiving:(_Bool)receiving __attribute__((swift_name("setReceivingAudio(callId:receiving:)")));
	[Abstract]
	[Export ("setReceivingAudio:receiving:")]
	void SetReceivingAudio (string callId, bool receiving);

	// @required -(void)setReceivingSharing:(NSString * _Nonnull)callId receiving:(_Bool)receiving __attribute__((swift_name("setReceivingSharing(callId:receiving:)")));
	[Abstract]
	[Export ("setReceivingSharing:receiving:")]
	void SetReceivingSharing (string callId, bool receiving);

	// @required -(void)onScheduleChanged:(NSString * _Nonnull)callId callback:(CallScheduleChangedCompletionCallback _Nonnull)callback __attribute__((swift_name("onScheduleChanged(callId:callback:)")));
	[Abstract]
	[Export ("onScheduleChanged:callback:")]
	void OnScheduleChanged (string callId, CallScheduleChangedCompletionCallback callback);

	// @required -(void)setOnCallRingingChangedListener:(NSString * _Nonnull)callId callback:(CallRingingChangedCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCallRingingChangedListener(callId:callback:)")));
	[Abstract]
	[Export ("setOnCallRingingChangedListener:callback:")]
	void SetOnCallRingingChangedListener (string callId, CallRingingChangedCompletionCallback callback);

	// @required -(void)setOnCallConnectedListener:(NSString * _Nonnull)callId callback:(CallConnectedCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCallConnectedListener(callId:callback:)")));
	[Abstract]
	[Export ("setOnCallConnectedListener:callback:")]
	void SetOnCallConnectedListener (string callId, CallConnectedCompletionCallback callback);

	// @required -(void)setOnCallDisconnectedListener:(NSString * _Nonnull)callId callback:(CallDisconnectedCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCallDisconnectedListener(callId:callback:)")));
	[Abstract]
	[Export ("setOnCallDisconnectedListener:callback:")]
	void SetOnCallDisconnectedListener (string callId, CallDisconnectedCompletionCallback callback);

	// @required -(void)setOnCallTerminatedListener:(NSString * _Nonnull)callId callback:(CallTerminatedCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCallTerminatedListener(callId:callback:)")));
	[Abstract]
	[Export ("setOnCallTerminatedListener:callback:")]
	void SetOnCallTerminatedListener (string callId, CallTerminatedCompletionCallback callback);

	// @required -(void)setOnCallFailedListener:(NSString * _Nonnull)callId callback:(CallFailedCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCallFailedListener(callId:callback:)")));
	[Abstract]
	[Export ("setOnCallFailedListener:callback:")]
	void SetOnCallFailedListener (string callId, CallFailedCompletionCallback callback);

	// @required -(void)setOnCallInfoChangedListener:(NSString * _Nonnull)callId callback:(CallInfoChangedCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCallInfoChangedListener(callId:callback:)")));
	[Abstract]
	[Export ("setOnCallInfoChangedListener:callback:")]
	void SetOnCallInfoChangedListener (string callId, CallInfoChangedCompletionCallback callback);

	// @required -(void)setOnPerformanceCausedResolutionChangedListener:(NSString * _Nonnull)callId callback:(CallOnHitCpuThresholdCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnPerformanceCausedResolutionChangedListener(callId:callback:)")));
	[Abstract]
	[Export ("setOnPerformanceCausedResolutionChangedListener:callback:")]
	void SetOnPerformanceCausedResolutionChangedListener (string callId, CallOnHitCpuThresholdCompletionCallback callback);

	// @required -(void)setOnCallPhotoOutputListener:(NSString * _Nonnull)callId callback:(CallPhotoOutputCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCallPhotoOutputListener(callId:callback:)")));
	[Abstract]
	[Export ("setOnCallPhotoOutputListener:callback:")]
	void SetOnCallPhotoOutputListener (string callId, CallPhotoOutputCompletionCallback callback);

	// @required -(_Bool)isVirtualBackgroundSupported __attribute__((swift_name("isVirtualBackgroundSupported()")));
	[Abstract]
	[Export ("isVirtualBackgroundSupported")]
	[Verify (MethodToProperty)]
	bool IsVirtualBackgroundSupported { get; }

	// @required -(void)fetchVirtualBackgroundItems:(FetchVirtualBackgroundCompletionCallback _Nonnull)callback __attribute__((swift_name("fetchVirtualBackgroundItems(callback:)")));
	[Abstract]
	[Export ("fetchVirtualBackgroundItems:")]
	void FetchVirtualBackgroundItems (FetchVirtualBackgroundCompletionCallback callback);

	// @required -(void)uploadVirtualBackground:(NSDictionary<CHLocalFile *,NSArray<NSData *> *> * _Nonnull)backgroundImage callback:(UploadVirtualBackgroundCompletionCallback _Nonnull)callback __attribute__((swift_name("uploadVirtualBackground(item:callback:)")));
	[Abstract]
	[Export ("uploadVirtualBackground:callback:")]
	void UploadVirtualBackground (NSDictionary<CHLocalFile, NSArray<NSData>> backgroundImage, UploadVirtualBackgroundCompletionCallback callback);

	// @required -(void)deleteVirtualBackgroundItem:(CHVirtualBackgroundItem * _Nonnull)item callback:(DeleteVirtualBackgroundCompletionCallback _Nonnull)callback __attribute__((swift_name("deleteVirtualBackgroundItem(item:callback:)")));
	[Abstract]
	[Export ("deleteVirtualBackgroundItem:callback:")]
	void DeleteVirtualBackgroundItem (CHVirtualBackgroundItem item, DeleteVirtualBackgroundCompletionCallback callback);

	// @required -(void)setVirtualBackgroundForPreview:(CHVirtualBackgroundItem * _Nonnull)item callback:(PreviewVirtualBackgroundCompletionCallback _Nonnull)callback __attribute__((swift_name("setVirtualBackgroundForPreview(item:callback:)")));
	[Abstract]
	[Export ("setVirtualBackgroundForPreview:callback:")]
	void SetVirtualBackgroundForPreview (CHVirtualBackgroundItem item, PreviewVirtualBackgroundCompletionCallback callback);

	// @required -(void)setVirtualBackgroundForCall:(CHVirtualBackgroundItem * _Nonnull)item callback:(ApplyVirtualBackgroundCompletionCallback _Nonnull)callback __attribute__((swift_name("setVirtualBackgroundForCall(item:callback:)")));
	[Abstract]
	[Export ("setVirtualBackgroundForCall:callback:")]
	void SetVirtualBackgroundForCall (CHVirtualBackgroundItem item, ApplyVirtualBackgroundCompletionCallback callback);

	// @required -(void)setVirtualBackgroundLimit:(NSNumber * _Nonnull)limit __attribute__((swift_name("setVirtualBackgroundLimit(limit:)")));
	[Abstract]
	[Export ("setVirtualBackgroundLimit:")]
	void SetVirtualBackgroundLimit (NSNumber limit);

	// @required -(NSNumber * _Nonnull)getVirtualBackgroundLimit __attribute__((swift_name("getVirtualBackgroundLimit()")));
	[Abstract]
	[Export ("getVirtualBackgroundLimit")]
	[Verify (MethodToProperty)]
	NSNumber VirtualBackgroundLimit { get; }

	// @required -(void)forceSendingVideoLandscape:(NSString * _Nonnull)callId forceLandscape:(_Bool)forceLandscape callback:(VideoForceLandscapeCompletionCallback _Nonnull)callback __attribute__((swift_name("forceSendingVideoLandscape(callId:forceLandscape:callback:)")));
	[Abstract]
	[Export ("forceSendingVideoLandscape:forceLandscape:callback:")]
	void ForceSendingVideoLandscape (string callId, bool forceLandscape, VideoForceLandscapeCompletionCallback callback);

	// @required -(void)setOnTranscriptionArrivedListener:(NSString * _Nonnull)callId callback:(CallTranscriptionArrivedCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnTranscriptionArrivedListener(callId:callback:)")));
	[Abstract]
	[Export ("setOnTranscriptionArrivedListener:callback:")]
	void SetOnTranscriptionArrivedListener (string callId, CallTranscriptionArrivedCompletionCallback callback);

	// @required -(void)setWXAEnabled:(NSString * _Nonnull)callId isEnabled:(_Bool)isEnabled callback:(SingleBoolCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("setWXAEnabled(callId:isEnabled:callback:)")));
	[Abstract]
	[Export ("setWXAEnabled:isEnabled:callback:")]
	void SetWXAEnabled (string callId, bool isEnabled, SingleBoolCompletionFuncCallback callback);

	// @required -(void)listCalendarMeetings:(NSDate * _Nullable)fromDate toDate:(NSDate * _Nullable)toDate callback:(ListCalendarMeetingsCompletionCallback _Nonnull)callback __attribute__((swift_name("listCalendarMeetings(fromDate:toDate:callback:)")));
	[Abstract]
	[Export ("listCalendarMeetings:toDate:callback:")]
	void ListCalendarMeetings ([NullAllowed] NSDate fromDate, [NullAllowed] NSDate toDate, ListCalendarMeetingsCompletionCallback callback);

	// @required -(void)getCalendarMeeting:(NSString * _Nonnull)meetingId callback:(GetCalendarMeetingCompletionCallback _Nonnull)callback __attribute__((swift_name("getCalendarMeeting(meetingId:callback:)")));
	[Abstract]
	[Export ("getCalendarMeeting:callback:")]
	void GetCalendarMeeting (string meetingId, GetCalendarMeetingCompletionCallback callback);

	// @required -(void)setOnCalendarMeetingEventListener:(CalendarMeetingEventCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCalendarMeetingEventListener(callback:)")));
	[Abstract]
	[Export ("setOnCalendarMeetingEventListener:")]
	void SetOnCalendarMeetingEventListener (CalendarMeetingEventCompletionCallback callback);

	// @required -(void)getMe:(PersonGetResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("getMe(completionHandler:)")));
	[Abstract]
	[Export ("getMe:")]
	void GetMe (PersonGetResultCompletionFuncCallback completionHandler);

	// @required -(void)getPersonWithId:(NSString * _Nonnull)personId completionHandler:(PersonGetResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("getPersonWithId(personId:completionHandler:)")));
	[Abstract]
	[Export ("getPersonWithId:completionHandler:")]
	void GetPersonWithId (string personId, PersonGetResultCompletionFuncCallback completionHandler);

	// @required -(void)listPersons:(NSString * _Nullable)email displayName:(NSString * _Nullable)displayName idString:(NSString * _Nullable)idString orgId:(NSString * _Nullable)orgId max:(NSNumber * _Nullable)max completionHandler:(ListPersonsCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listPersons(email:displayName:idString:orgId:max:completionHandler:)")));
	[Abstract]
	[Export ("listPersons:displayName:idString:orgId:max:completionHandler:")]
	void ListPersons ([NullAllowed] string email, [NullAllowed] string displayName, [NullAllowed] string idString, [NullAllowed] string orgId, [NullAllowed] NSNumber max, ListPersonsCompletionFuncCallback completionHandler);

	// @required -(void)createPerson:(NSString * _Nonnull)email displayName:(NSString * _Nullable)displayName firstName:(NSString * _Nullable)firstName lastName:(NSString * _Nullable)lastName avatar:(NSString * _Nullable)avatar orgId:(NSString * _Nullable)orgId roles:(NSString * _Nullable)roles licenses:(NSString * _Nullable)licenses completionHandler:(CreatePersonCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createPerson(email:displayName:firstName:lastName:avatar:orgId:roles:licenses:completionHandler:)")));
	[Abstract]
	[Export ("createPerson:displayName:firstName:lastName:avatar:orgId:roles:licenses:completionHandler:")]
	void CreatePerson (string email, [NullAllowed] string displayName, [NullAllowed] string firstName, [NullAllowed] string lastName, [NullAllowed] string avatar, [NullAllowed] string orgId, [NullAllowed] string roles, [NullAllowed] string licenses, CreatePersonCompletionFuncCallback completionHandler);

	// @required -(void)updatePerson:(NSString * _Nonnull)personId email:(NSString * _Nullable)email displayName:(NSString * _Nullable)displayName firstName:(NSString * _Nullable)firstName lastName:(NSString * _Nullable)lastName avatar:(NSString * _Nullable)avatar orgId:(NSString * _Nullable)orgId roles:(NSString * _Nullable)roles licenses:(NSString * _Nullable)licenses completionHandler:(UpdatePersonCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("updatePerson(personId:email:displayName:firstName:lastName:avatar:orgId:roles:licenses:completionHandler:)")));
	[Abstract]
	[Export ("updatePerson:email:displayName:firstName:lastName:avatar:orgId:roles:licenses:completionHandler:")]
	void UpdatePerson (string personId, [NullAllowed] string email, [NullAllowed] string displayName, [NullAllowed] string firstName, [NullAllowed] string lastName, [NullAllowed] string avatar, [NullAllowed] string orgId, [NullAllowed] string roles, [NullAllowed] string licenses, UpdatePersonCompletionFuncCallback completionHandler);

	// @required -(void)deletePerson:(NSString * _Nonnull)personId completionHandler:(DeletePersonCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("deletePerson(personId:completionHandler:)")));
	[Abstract]
	[Export ("deletePerson:completionHandler:")]
	void DeletePerson (string personId, DeletePersonCompletionFuncCallback completionHandler);

	// @required -(void)listTeams:(NSNumber * _Nonnull)maxTeams completionHandler:(TeamListResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listTeams(maxTeams:completionHandler:)")));
	[Abstract]
	[Export ("listTeams:completionHandler:")]
	void ListTeams (NSNumber maxTeams, TeamListResultCompletionFuncCallback completionHandler);

	// @required -(void)createTeam:(NSString * _Nonnull)name completionHandler:(TeamCreateResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createTeam(name:completionHandler:)")));
	[Abstract]
	[Export ("createTeam:completionHandler:")]
	void CreateTeam (string name, TeamCreateResultCompletionFuncCallback completionHandler);

	// @required -(void)getTeamWithId:(NSString * _Nonnull)teamId completionHandler:(TeamGetResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("getTeamWithId(teamId:completionHandler:)")));
	[Abstract]
	[Export ("getTeamWithId:completionHandler:")]
	void GetTeamWithId (string teamId, TeamGetResultCompletionFuncCallback completionHandler);

	// @required -(void)updateTeamWith:(NSString * _Nonnull)teamId newName:(NSString * _Nonnull)newName completionHandler:(TeamUpdateResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("updateTeamWith(teamId:newName:completionHandler:)")));
	[Abstract]
	[Export ("updateTeamWith:newName:completionHandler:")]
	void UpdateTeamWith (string teamId, string newName, TeamUpdateResultCompletionFuncCallback completionHandler);

	// @required -(void)deleteTeamWithId:(NSString * _Nonnull)teamId completionHandler:(TeamArchiveResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("deleteTeamWithId(teamId:completionHandler:)")));
	[Abstract]
	[Export ("deleteTeamWithId:completionHandler:")]
	void DeleteTeamWithId (string teamId, TeamArchiveResultCompletionFuncCallback completionHandler);

	// @required -(void)listSpaces:(NSString * _Nullable)teamId max:(NSNumber * _Nullable)max conversationType:(enum CHConversationType)conversationType sortType:(enum CHConversationSortType)sortType completionHandler:(ListSpacesCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listSpaces(teamId:max:conversationType:sortType:completionHandler:)")));
	[Abstract]
	[Export ("listSpaces:max:conversationType:sortType:completionHandler:")]
	void ListSpaces ([NullAllowed] string teamId, [NullAllowed] NSNumber max, CHConversationType conversationType, CHConversationSortType sortType, ListSpacesCompletionFuncCallback completionHandler);

	// @required -(void)getSpace:(NSString * _Nonnull)spaceId completionHandler:(SingleSpaceCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("getSpace(spaceId:completionHandler:)")));
	[Abstract]
	[Export ("getSpace:completionHandler:")]
	void GetSpace (string spaceId, SingleSpaceCompletionFuncCallback completionHandler);

	// @required -(void)createSpace:(NSString * _Nullable)teamId title:(NSString * _Nonnull)title completionHandler:(SingleSpaceCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createSpace(teamId:title:completionHandler:)")));
	[Abstract]
	[Export ("createSpace:title:completionHandler:")]
	void CreateSpace ([NullAllowed] string teamId, string title, SingleSpaceCompletionFuncCallback completionHandler);

	// @required -(void)updateSpaceTitle:(NSString * _Nonnull)spaceId newTitle:(NSString * _Nonnull)newTitle completionHandler:(UpdateSpaceTitleResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("updateSpaceTitle(spaceId:newTitle:completionHandler:)")));
	[Abstract]
	[Export ("updateSpaceTitle:newTitle:completionHandler:")]
	void UpdateSpaceTitle (string spaceId, string newTitle, UpdateSpaceTitleResultCompletionFuncCallback completionHandler);

	// @required -(void)deleteSpace:(NSString * _Nonnull)spaceId completionHandler:(DeleteSpaceCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("deleteSpace(spaceId:completionHandler:)")));
	[Abstract]
	[Export ("deleteSpace:completionHandler:")]
	void DeleteSpace (string spaceId, DeleteSpaceCompletionFuncCallback completionHandler);

	// @required -(void)getMeetingInfoFor:(NSString * _Nonnull)spaceId completionHandler:(void (^ _Nonnull)(CHSpaceMeetingInfo * _Nullable, BOOL))completionHandler;
	[Abstract]
	[Export ("getMeetingInfoFor:completionHandler:")]
	void GetMeetingInfoFor (string spaceId, Action<CHSpaceMeetingInfo, bool> completionHandler);

	// @required -(void)getReadStatus:(NSString * _Nonnull)spaceId completionHandler:(SingleSpaceReadStatusCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("getReadStatus(spaceId:completionHandler:)")));
	[Abstract]
	[Export ("getReadStatus:completionHandler:")]
	void GetReadStatus (string spaceId, SingleSpaceReadStatusCompletionFuncCallback completionHandler);

	// @required -(void)listReadStatus:(NSNumber * _Nonnull)max completionHandler:(ListSpaceReadStatusCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listReadStatus(max:completionHandler:)")));
	[Abstract]
	[Export ("listReadStatus:completionHandler:")]
	void ListReadStatus (NSNumber max, ListSpaceReadStatusCompletionFuncCallback completionHandler);

	// @required -(void)setOnSpaceEventListener:(SpaceEventCompletionCallback _Nullable)callback __attribute__((swift_name("setOnSpaceEventListener(callback:)")));
	[Abstract]
	[Export ("setOnSpaceEventListener:")]
	void SetOnSpaceEventListener ([NullAllowed] SpaceEventCompletionCallback callback);

	// @required -(void)setOnSpaceEventWithPayloadListener:(SpaceEventWithPayloadCompletionCallback _Nullable)callback __attribute__((swift_name("setOnSpaceEventWithPayloadListener(callback:)")));
	[Abstract]
	[Export ("setOnSpaceEventWithPayloadListener:")]
	void SetOnSpaceEventWithPayloadListener ([NullAllowed] SpaceEventWithPayloadCompletionCallback callback);

	// @required -(void)listWithActiveCalls:(ListSpacesActiveCallsCompletionCallback _Nonnull)completionHandler __attribute__((swift_name("listWithActiveCalls(completionHandler:)")));
	[Abstract]
	[Export ("listWithActiveCalls:")]
	void ListWithActiveCalls (ListSpacesActiveCallsCompletionCallback completionHandler);

	// @required -(void)listTeamMembershipIn:(NSString * _Nonnull)teamId max:(NSNumber * _Nullable)max completionHandler:(ListTeamMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listTeamMembershipIn(teamId:max:completionHandler:)")));
	[Abstract]
	[Export ("listTeamMembershipIn:max:completionHandler:")]
	void ListTeamMembershipIn (string teamId, [NullAllowed] NSNumber max, ListTeamMembershipCompletionFuncCallback completionHandler);

	// @required -(void)createTeamMembershipWithPersonId:(NSString * _Nonnull)personId teamId:(NSString * _Nonnull)teamId isModerator:(_Bool)isModerator completionHandler:(CreateTeamMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createTeamMembershipWith(personId:teamId:isModerator:completionHandler:)")));
	[Abstract]
	[Export ("createTeamMembershipWithPersonId:teamId:isModerator:completionHandler:")]
	void CreateTeamMembershipWithPersonId (string personId, string teamId, bool isModerator, CreateTeamMembershipCompletionFuncCallback completionHandler);

	// @required -(void)createTeamMembershipWithEmailAddress:(NSString * _Nonnull)emailAddress teamId:(NSString * _Nonnull)teamId isModerator:(_Bool)isModerator completionHandler:(CreateTeamMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createTeamMembershipWith(emailAddress:teamId:isModerator:completionHandler:)")));
	[Abstract]
	[Export ("createTeamMembershipWithEmailAddress:teamId:isModerator:completionHandler:")]
	void CreateTeamMembershipWithEmailAddress (string emailAddress, string teamId, bool isModerator, CreateTeamMembershipCompletionFuncCallback completionHandler);

	// @required -(void)getTeamMembership:(NSString * _Nonnull)teamMembershipId completionHandler:(GetTeamMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("getTeamMembership(teamMembershipId:completionHandler:)")));
	[Abstract]
	[Export ("getTeamMembership:completionHandler:")]
	void GetTeamMembership (string teamMembershipId, GetTeamMembershipCompletionFuncCallback completionHandler);

	// @required -(void)updateTeamMembershipWith:(NSString * _Nonnull)teamMembershipId isModerator:(_Bool)isModerator completionHandler:(UpdateTeamMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("updateTeamMembershipWith(teamMembershipId:isModerator:completionHandler:)")));
	[Abstract]
	[Export ("updateTeamMembershipWith:isModerator:completionHandler:")]
	void UpdateTeamMembershipWith (string teamMembershipId, bool isModerator, UpdateTeamMembershipCompletionFuncCallback completionHandler);

	// @required -(void)deleteTeamMembershipWithId:(NSString * _Nonnull)teamMembershipId completionHandler:(DeleteTeamMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("deleteTeamMembershipWithId(teamMembershipId:completionHandler:)")));
	[Abstract]
	[Export ("deleteTeamMembershipWithId:completionHandler:")]
	void DeleteTeamMembershipWithId (string teamMembershipId, DeleteTeamMembershipCompletionFuncCallback completionHandler);

	// @required -(void)listMemberships:(NSString * _Nullable)spaceId personId:(NSString * _Nullable)personId email:(NSString * _Nullable)email max:(NSNumber * _Nullable)max completionHandler:(ListMembershipsCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listMemberships(spaceId:personId:email:max:completionHandler:)")));
	[Abstract]
	[Export ("listMemberships:personId:email:max:completionHandler:")]
	void ListMemberships ([NullAllowed] string spaceId, [NullAllowed] string personId, [NullAllowed] string email, [NullAllowed] NSNumber max, ListMembershipsCompletionFuncCallback completionHandler);

	// @required -(void)getMembership:(NSString * _Nonnull)membershipId completionHandler:(GetMembershipByMembershipIdCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("get(membershipId:completionHandler:)")));
	[Abstract]
	[Export ("getMembership:completionHandler:")]
	void GetMembership (string membershipId, GetMembershipByMembershipIdCompletionFuncCallback completionHandler);

	// @required -(void)updateMembershipWith:(NSString * _Nonnull)membershipId isModerator:(_Bool)isModerator completionHandler:(MembershipUpdateResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("updateMembershipWith(membershipId:isModerator:completionHandler:)")));
	[Abstract]
	[Export ("updateMembershipWith:isModerator:completionHandler:")]
	void UpdateMembershipWith (string membershipId, bool isModerator, MembershipUpdateResultCompletionFuncCallback completionHandler);

	// @required -(void)createMembershipWithPersonId:(NSString * _Nonnull)personId spaceId:(NSString * _Nonnull)spaceId isModerator:(_Bool)isModerator completionHandler:(CreateMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createMembershipWith(personId:spaceId:isModerator:completionHandler:)")));
	[Abstract]
	[Export ("createMembershipWithPersonId:spaceId:isModerator:completionHandler:")]
	void CreateMembershipWithPersonId (string personId, string spaceId, bool isModerator, CreateMembershipCompletionFuncCallback completionHandler);

	// @required -(void)createMembershipWithEmailAddress:(NSString * _Nonnull)emailAddress spaceId:(NSString * _Nonnull)spaceId isModerator:(_Bool)isModerator completionHandler:(CreateMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createMembershipWith(emailAddress:spaceId:isModerator:completionHandler:)")));
	[Abstract]
	[Export ("createMembershipWithEmailAddress:spaceId:isModerator:completionHandler:")]
	void CreateMembershipWithEmailAddress (string emailAddress, string spaceId, bool isModerator, CreateMembershipCompletionFuncCallback completionHandler);

	// @required -(void)deleteMembershipWithId:(NSString * _Nonnull)membershipId completionHandler:(MembershipDeleteResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("deleteMembershipWithId(membershipId:completionHandler:)")));
	[Abstract]
	[Export ("deleteMembershipWithId:completionHandler:")]
	void DeleteMembershipWithId (string membershipId, MembershipDeleteResultCompletionFuncCallback completionHandler);

	// @required -(void)listMembershipsWithReadStatus:(NSString * _Nonnull)spaceId completionHandler:(ListMembershipsReadStatusCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listMembershipsWithReadStatus(spaceId:completionHandler:)")));
	[Abstract]
	[Export ("listMembershipsWithReadStatus:completionHandler:")]
	void ListMembershipsWithReadStatus (string spaceId, ListMembershipsReadStatusCompletionFuncCallback completionHandler);

	// @required -(void)setOnMembershipEventListener:(MembershipEventCompletionCallback _Nullable)callback __attribute__((swift_name("setOnMembershipEventListener(callback:)")));
	[Abstract]
	[Export ("setOnMembershipEventListener:")]
	void SetOnMembershipEventListener ([NullAllowed] MembershipEventCompletionCallback callback);

	// @required -(void)setOnMembershipEventWithPayloadListener:(MembershipEventWithPayloadCompletionCallback _Nullable)callback __attribute__((swift_name("setOnMembershipEventWithPayloadListener(callback:)")));
	[Abstract]
	[Export ("setOnMembershipEventWithPayloadListener:")]
	void SetOnMembershipEventWithPayloadListener ([NullAllowed] MembershipEventWithPayloadCompletionCallback callback);

	// @required -(void)listMessages:(NSString * _Nonnull)spaceId max:(NSNumber * _Nonnull)max beforeMessageId:(NSString * _Nullable)beforeMessageId beforeDate:(NSDate * _Nullable)beforeDate mentionedPeople:(NSArray<CHMention *> * _Nullable)mentionedPeople completionHandler:(ListMessagesCompletionFuncCallback _Nonnull)completionHandler;
	[Abstract]
	[Export ("listMessages:max:beforeMessageId:beforeDate:mentionedPeople:completionHandler:")]
	void ListMessages (string spaceId, NSNumber max, [NullAllowed] string beforeMessageId, [NullAllowed] NSDate beforeDate, [NullAllowed] CHMention[] mentionedPeople, ListMessagesCompletionFuncCallback completionHandler);

	// @required -(void)markMessageRead:(NSString * _Nonnull)spaceId messageId:(NSString * _Nullable)messageId completionHandler:(MarkMessageResultCompletionFuncCallback _Nonnull)completionHandler;
	[Abstract]
	[Export ("markMessageRead:messageId:completionHandler:")]
	void MarkMessageRead (string spaceId, [NullAllowed] string messageId, MarkMessageResultCompletionFuncCallback completionHandler);

	// @required -(void)getMessage:(NSString * _Nonnull)messageId completionHandler:(SingleMessageCompletionFuncCallback _Nonnull)completion __attribute__((swift_name("getMessage(messageId:completionHandler:)")));
	[Abstract]
	[Export ("getMessage:completionHandler:")]
	void GetMessage (string messageId, SingleMessageCompletionFuncCallback completion);

	// @required -(void)deleteMessage:(NSString * _Nonnull)messageId completionHandler:(MessageDeleteResultCompletionFuncCallback _Nonnull)completion __attribute__((swift_name("deleteMessage(messageId:completionHandler:)")));
	[Abstract]
	[Export ("deleteMessage:completionHandler:")]
	void DeleteMessage (string messageId, MessageDeleteResultCompletionFuncCallback completion);

	// @required -(void)postMessage:(CHMessageText * _Nullable)messageText destination:(NSString * _Nonnull)destination parent:(NSString * _Nullable)parent mentions:(NSArray<CHMention *> * _Nonnull)mentions files:(NSArray<NSDictionary<CHLocalFile *,NSArray<NSData *> *> *> * _Nonnull)files completionHandler:(MessagePostCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("postMessage(messageText:destination:parent:mentions:files:completionHandler:)")));
	[Abstract]
	[Export ("postMessage:destination:parent:mentions:files:completionHandler:")]
	void PostMessage ([NullAllowed] CHMessageText messageText, string destination, [NullAllowed] string parent, CHMention[] mentions, NSDictionary<CHLocalFile, NSArray<NSData>>[] files, MessagePostCompletionFuncCallback completionHandler);

	// @required -(void)editMessage:(CHMessageText * _Nullable)messageText spaceId:(NSString * _Nonnull)spaceId parent:(NSString * _Nonnull)parent mentions:(NSArray<CHMention *> * _Nonnull)mentions completionHandler:(MessagePostCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("editMessage(messageText:conversationId:parentId:mentions:completionHandler:)")));
	[Abstract]
	[Export ("editMessage:spaceId:parent:mentions:completionHandler:")]
	void EditMessage ([NullAllowed] CHMessageText messageText, string spaceId, string parent, CHMention[] mentions, MessagePostCompletionFuncCallback completionHandler);

	// @required -(void)downloadFile:(NSString * _Nonnull)spaceId messageId:(NSString * _Nonnull)messageId contentIndex:(NSNumber * _Nonnull)contentIndex downloadPath:(NSString * _Nonnull)downloadPath progressHandler:(MessageDownloadFileProgressCompletionFuncCallback _Nullable)progressHandler completionHandler:(MessageDownloadFileCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("downloadFile(spaceId:messageId:contentIndex:downloadPath:progressHandler:completionHandler:)")));
	[Abstract]
	[Export ("downloadFile:messageId:contentIndex:downloadPath:progressHandler:completionHandler:")]
	void DownloadFile (string spaceId, string messageId, NSNumber contentIndex, string downloadPath, [NullAllowed] MessageDownloadFileProgressCompletionFuncCallback progressHandler, MessageDownloadFileCompletionFuncCallback completionHandler);

	// @required -(void)downloadThumbnail:(NSString * _Nonnull)spaceId messageId:(NSString * _Nonnull)messageId contentIndex:(NSNumber * _Nonnull)contentIndex completionHandler:(MessageThumbnailResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("downloadThumbnail(spaceId:messageId:contentIndex:completionHandler:)")));
	[Abstract]
	[Export ("downloadThumbnail:messageId:contentIndex:completionHandler:")]
	void DownloadThumbnail (string spaceId, string messageId, NSNumber contentIndex, MessageThumbnailResultCompletionFuncCallback completionHandler);

	// @required -(void)setOnMessageEventListener:(MessageEventCompletionCallback _Nullable)callback __attribute__((swift_name("setOnMessageEventListener(callback:)")));
	[Abstract]
	[Export ("setOnMessageEventListener:")]
	void SetOnMessageEventListener ([NullAllowed] MessageEventCompletionCallback callback);

	// @required -(void)setOnMessageEventWithPayloadListener:(MessageEventWithPayloadCompletionCallback _Nullable)callback __attribute__((swift_name("setOnMessageEventWithPayloadListener(callback:)")));
	[Abstract]
	[Export ("setOnMessageEventWithPayloadListener:")]
	void SetOnMessageEventWithPayloadListener ([NullAllowed] MessageEventWithPayloadCompletionCallback callback);

	// @required -(void)listWebhooksWithMax:(NSNumber * _Nullable)max completionHandler:(ListWebhooksCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listWebhooks(max:completionHandler:)")));
	[Abstract]
	[Export ("listWebhooksWithMax:completionHandler:")]
	void ListWebhooksWithMax ([NullAllowed] NSNumber max, ListWebhooksCompletionFuncCallback completionHandler);

	// @required -(void)getWebhook:(NSString * _Nonnull)webhookId completionHandler:(GetWebhookCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("getWebhook(webhookId:completionHandler:)")));
	[Abstract]
	[Export ("getWebhook:completionHandler:")]
	void GetWebhook (string webhookId, GetWebhookCompletionFuncCallback completionHandler);

	// @required -(void)createWebhook:(NSString * _Nonnull)name targetUrl:(NSString * _Nonnull)targetUrl resource:(NSString * _Nonnull)resource event:(NSString * _Nonnull)event filter:(NSString * _Nullable)filter secret:(NSString * _Nullable)secret completionHandler:(CreateWebhookCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createWebhook(name:targetUrl:resource:event:filter:secret:completionHandler:)")));
	[Abstract]
	[Export ("createWebhook:targetUrl:resource:event:filter:secret:completionHandler:")]
	void CreateWebhook (string name, string targetUrl, string resource, string @event, [NullAllowed] string filter, [NullAllowed] string secret, CreateWebhookCompletionFuncCallback completionHandler);

	// @required -(void)updateWebhook:(NSString * _Nonnull)webhookId name:(NSString * _Nonnull)name targetUrl:(NSString * _Nonnull)targetUrl secret:(NSString * _Nullable)secret status:(NSString * _Nullable)status completionHandler:(UpdateWebhookCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("updateWebhook(webhookId:name:targetUrl:secret:status:completionHandler:)")));
	[Abstract]
	[Export ("updateWebhook:name:targetUrl:secret:status:completionHandler:")]
	void UpdateWebhook (string webhookId, string name, string targetUrl, [NullAllowed] string secret, [NullAllowed] string status, UpdateWebhookCompletionFuncCallback completionHandler);

	// @required -(void)deleteWebhook:(NSString * _Nonnull)webhookId completionHandler:(DeleteWebhookCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("deleteWebhook(webhookId:completionHandler:)")));
	[Abstract]
	[Export ("deleteWebhook:completionHandler:")]
	void DeleteWebhook (string webhookId, DeleteWebhookCompletionFuncCallback completionHandler);

	// @required -(NSString * _Nonnull)getServiceUrl:(enum CHServiceUrlType)serviceUrlType __attribute__((swift_name("getServiceUrl(serviceUrlType:)")));
	[Abstract]
	[Export ("getServiceUrl:")]
	string GetServiceUrl (CHServiceUrlType serviceUrlType);

	// @required -(NSString * _Nullable)pathTologFilesAsZip;
	[Abstract]
	[NullAllowed, Export ("pathTologFilesAsZip")]
	[Verify (MethodToProperty)]
	string PathTologFilesAsZip { get; }

	// @required -(void)base64EncodeResource:(enum CHResourceType)resourceType resource:(NSString * _Nonnull)resource completionHandler:(Base64EncodeCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("base64EncodeResource(resourceType:resource:completionHandler:)")));
	[Abstract]
	[Export ("base64EncodeResource:resource:completionHandler:")]
	void Base64EncodeResource (CHResourceType resourceType, string resource, Base64EncodeCompletionFuncCallback completionHandler);

	// @required -(CHResource * _Nonnull)base64DecodeResource:(NSString * _Nonnull)encodedResource __attribute__((swift_name("base64DecodeResource(encodedResource:)")));
	[Abstract]
	[Export ("base64DecodeResource:")]
	CHResource Base64DecodeResource (string encodedResource);
}

// @interface OmniusServiceBridge : NSObject <OmniusServiceBridgeProtocol>
[BaseType (typeof(NSObject))]
interface OmniusServiceBridge : IOmniusServiceBridgeProtocol
{
	[Wrap ("WeakDelegate")]
	[NullAllowed]
	OmniusServiceBridgeDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<OmniusServiceBridgeDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// -(instancetype _Nonnull)initWithSparkClientProvider:(id<AppleSparkClientProvider> _Nonnull)sparkClientProvider;
	[Export ("initWithSparkClientProvider:")]
	IntPtr Constructor (AppleSparkClientProvider sparkClientProvider);

	// -(void)getAuthorizationUrl:(NSString * _Nonnull)email callback:(GetOAuthUrlCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("getAuthorizationUrl(email:callback:)")));
	[Export ("getAuthorizationUrl:callback:")]
	void GetAuthorizationUrl (string email, GetOAuthUrlCompletionFuncCallback callback);

	// -(void)signOut:(VoidCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("signOut(callback:)")));
	[Export ("signOut:")]
	void SignOut (VoidCompletionFuncCallback callback);

	// -(void)appTransition:(BOOL)isInBackground __attribute__((swift_name("appTransition(isInBackground:)")));
	[Export ("appTransition:")]
	void AppTransition (bool isInBackground);

	// -(_Bool)getActiveCalls;
	[Export ("getActiveCalls")]
	[Verify (MethodToProperty)]
	bool ActiveCalls { get; }

	// -(_Bool)isLoggedIn;
	[Export ("isLoggedIn")]
	[Verify (MethodToProperty)]
	bool IsLoggedIn { get; }

	// -(void)attemptToLoginWithCachedUser:(SingleBoolCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("attemptToLoginWithCachedUser(callback:)")));
	[Export ("attemptToLoginWithCachedUser:")]
	void AttemptToLoginWithCachedUser (SingleBoolCompletionFuncCallback callback);

	// -(void)loginWithAuthCode:(NSString * _Nonnull)authCode emailId:(NSString * _Nonnull)emailId callback:(OAuthResultCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("loginWithAuthCode(authCode:emailId:callback:)")));
	[Export ("loginWithAuthCode:emailId:callback:")]
	void LoginWithAuthCode (string authCode, string emailId, OAuthResultCompletionFuncCallback callback);

	// -(void)loginWithJWT:(NSString * _Nonnull)jwt callback:(GuestIssuerResultCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("loginWithJWT(jwt:callback:)")));
	[Export ("loginWithJWT:callback:")]
	void LoginWithJWT (string jwt, GuestIssuerResultCompletionFuncCallback callback);

	// -(void)loginWithAccessToken:(NSString * _Nonnull)accessToken expiresInSeconds:(NSNumber * _Nullable)expiresInSeconds callback:(AccessTokenLoginResultCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("loginWithAccessToken(accessToken:expiresInSeconds:callback:)")));
	[Export ("loginWithAccessToken:expiresInSeconds:callback:")]
	void LoginWithAccessToken (string accessToken, [NullAllowed] NSNumber expiresInSeconds, AccessTokenLoginResultCompletionFuncCallback callback);

	// -(void)setOnTokenExpiredListener:(VoidCompletionFuncCallback _Nullable)callback __attribute__((swift_name("setOnTokenExpiredListener(callback:)")));
	[Export ("setOnTokenExpiredListener:")]
	void SetOnTokenExpiredListener ([NullAllowed] VoidCompletionFuncCallback callback);

	// -(void)getAccessToken:(AccessTokenResultCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("getAccessToken(callback:)")));
	[Export ("getAccessToken:")]
	void GetAccessToken (AccessTokenResultCompletionFuncCallback callback);

	// -(void)refreshAccessToken:(AccessTokenResultCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("refreshAccessToken(callback:)")));
	[Export ("refreshAccessToken:")]
	void RefreshAccessToken (AccessTokenResultCompletionFuncCallback callback);

	// -(NSString * _Nullable)getJwtToken;
	[NullAllowed, Export ("getJwtToken")]
	[Verify (MethodToProperty)]
	string JwtToken { get; }

	// -(NSDate * _Nullable)getGuestIssuerAccessTokenExpiration;
	[NullAllowed, Export ("getGuestIssuerAccessTokenExpiration")]
	[Verify (MethodToProperty)]
	NSDate GuestIssuerAccessTokenExpiration { get; }

	// -(NSDate * _Nullable)getGuestIssuerJwtExpiration;
	[NullAllowed, Export ("getGuestIssuerJwtExpiration")]
	[Verify (MethodToProperty)]
	NSDate GuestIssuerJwtExpiration { get; }

	// -(void)addLoginTelemetry:(enum CHTelemetry)loginEvent startTime:(NSDate * _Nonnull)startTime endTime:(NSDate * _Nonnull)endTime __attribute__((swift_name("addLoginTelemetry(loginEvent:startTime:endTime:)")));
	[Export ("addLoginTelemetry:startTime:endTime:")]
	void AddLoginTelemetry (CHTelemetry loginEvent, NSDate startTime, NSDate endTime);

	// -(void)isNetworkReachable:(BOOL)isNetworkReachable;
	[Export ("isNetworkReachable:")]
	void IsNetworkReachable (bool isNetworkReachable);

	// -(void)setUCDomainServerUrl:(NSString * _Nonnull)ucDomain serverUrl:(NSString * _Nonnull)serverUrl __attribute__((swift_name("setUCDomainServerUrl(ucDomain:serverUrl:)")));
	[Export ("setUCDomainServerUrl:serverUrl:")]
	void SetUCDomainServerUrl (string ucDomain, string serverUrl);

	// -(void)setCUCMCredential:(NSString * _Nonnull)username password:(NSString * _Nonnull)password __attribute__((swift_name("setCUCMCredential(username:password:)")));
	[Export ("setCUCMCredential:password:")]
	void SetCUCMCredential (string username, string password);

	// -(void)processSSOBrowserNavigationResult:(enum CHUCBrowserLoginSSONavResult)result currentUrl:(NSString * _Nonnull)currentUrl document:(NSString * _Nonnull)document __attribute__((swift_name("processSSOBrowserNavigationResult(result:currentUrl:document:)")));
	[Export ("processSSOBrowserNavigationResult:currentUrl:document:")]
	void ProcessSSOBrowserNavigationResult (CHUCBrowserLoginSSONavResult result, string currentUrl, string document);

	// -(void)ucCancelSSOLogin;
	[Export ("ucCancelSSOLogin")]
	void UcCancelSSOLogin ();

	// -(_Bool)isUCLoggedIn;
	[Export ("isUCLoggedIn")]
	[Verify (MethodToProperty)]
	bool IsUCLoggedIn { get; }

	// -(CHUCLoginServerConnectionStatus)getUCServerConnectionStatus;
	[Export ("getUCServerConnectionStatus")]
	[Verify (MethodToProperty)]
	CHUCLoginServerConnectionStatus UCServerConnectionStatus { get; }

	// -(void)getSearchResult:(NSString * _Nonnull)searchString callback:(ListSpacesCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("getSearchResult(searchString:callback:)")));
	[Export ("getSearchResult:callback:")]
	void GetSearchResult (string searchString, ListSpacesCompletionFuncCallback callback);

	// -(NSArray<CHSpace *> * _Nonnull)getCallHistory;
	[Export ("getCallHistory")]
	[Verify (MethodToProperty)]
	CHSpace[] CallHistory { get; }

	// -(NSString * _Nullable)dial:(NSString * _Nonnull)input __attribute__((swift_name("dial(input:)")));
	[Export ("dial:")]
	[return: NullAllowed]
	string Dial (string input);

	// -(NSString * _Nullable)dial:(NSString * _Nonnull)input localVideoView:(void * _Nullable)localVideoView remoteVideoView:(void * _Nullable)remoteVideoView sharingVideoView:(void * _Nullable)sharingVideoView __attribute__((swift_name("dial(input:localVideoView:remoteVideoView:sharingVideoView:)")));
	[Export ("dial:localVideoView:remoteVideoView:sharingVideoView:")]
	[return: NullAllowed]
	unsafe string Dial (string input, [NullAllowed] void* localVideoView, [NullAllowed] void* remoteVideoView, [NullAllowed] void* sharingVideoView);

	// -(void)startShare:(NSString * _Nonnull)callId __attribute__((swift_name("startShare(callId:)")));
	[Export ("startShare:")]
	void StartShare (string callId);

	// -(void)stopShare:(NSString * _Nonnull)callId __attribute__((swift_name("stopShare(callId:)")));
	[Export ("stopShare:")]
	void StopShare (string callId);

	// -(void)setupExternalInput:(NSString * _Nonnull)callId height:(NSNumber * _Nonnull)height width:(NSNumber * _Nonnull)width __attribute__((swift_name("setupExternalInput(callId:height:width:)")));
	[Export ("setupExternalInput:height:width:")]
	void SetupExternalInput (string callId, NSNumber height, NSNumber width);

	// -(void)sendFrameToExternalInputter:(NSString * _Nonnull)callId timeStamp:(NSNumber * _Nonnull)timeStamp height:(NSNumber * _Nonnull)height width:(NSNumber * _Nonnull)width data:(void *const _Nonnull)data length:(NSNumber * _Nonnull)length __attribute__((swift_name("sendFrameToExternalInputter(callId:timeStamp:height:width:data:length:)")));
	[Export ("sendFrameToExternalInputter:timeStamp:height:width:data:length:")]
	unsafe void SendFrameToExternalInputter (string callId, NSNumber timeStamp, NSNumber height, NSNumber width, void* data, NSNumber length);

	// -(void)answer:(NSString * _Nonnull)callId isModerator:(_Bool)isModerator pin:(NSString * _Nonnull)pin localVideoView:(void * _Nullable)localVideoView remoteVideoView:(void * _Nullable)remoteVideoView sharingVideoView:(void * _Nullable)sharingVideoView callback:(CallStartedCompletionCallback _Nullable)callback __attribute__((swift_name("answer(callId:isModerator:pin:localVideoView:remoteVideoView:sharingVideoView:callback:)")));
	[Export ("answer:isModerator:pin:localVideoView:remoteVideoView:sharingVideoView:callback:")]
	unsafe void Answer (string callId, bool isModerator, string pin, [NullAllowed] void* localVideoView, [NullAllowed] void* remoteVideoView, [NullAllowed] void* sharingVideoView, [NullAllowed] CallStartedCompletionCallback callback);

	// -(NSArray<CHMeetingInfo *> * _Nullable)getSchedules:(NSString * _Nonnull)callId __attribute__((swift_name("getSchedules(callId:)")));
	[Export ("getSchedules:")]
	[return: NullAllowed]
	CHMeetingInfo[] GetSchedules (string callId);

	// -(void)joinCall:(NSString * _Nonnull)callId isModerator:(_Bool)isModerator pin:(NSString * _Nonnull)pin isAudioOnly:(_Bool)isAudioOnly callback:(CallStartedCompletionCallback _Nullable)callback __attribute__((swift_name("joinCall(callId:isModerator:pin:isAudioOnly:callback:)")));
	[Export ("joinCall:isModerator:pin:isAudioOnly:callback:")]
	void JoinCall (string callId, bool isModerator, string pin, bool isAudioOnly, [NullAllowed] CallStartedCompletionCallback callback);

	// -(void)declineCall:(NSString * _Nonnull)callId __attribute__((swift_name("declineCall(callId:)")));
	[Export ("declineCall:")]
	void DeclineCall (string callId);

	// -(void)endCall:(NSString * _Nonnull)callId __attribute__((swift_name("endCall(callId:)")));
	[Export ("endCall:")]
	void EndCall (string callId);

	// -(void)endActiveCall;
	[Export ("endActiveCall")]
	void EndActiveCall ();

	// -(void)muteAudio:(NSString * _Nonnull)callId participantId:(NSString * _Nonnull)participantId isMuted:(_Bool)isMuted __attribute__((swift_name("muteAudio(callId:participantId:isMuted:)")));
	[Export ("muteAudio:participantId:isMuted:")]
	void MuteAudio (string callId, string participantId, bool isMuted);

	// -(void)muteAll:(NSString * _Nonnull)callId doMute:(_Bool)doMute __attribute__((swift_name("muteAll(callId:doMute:)")));
	[Export ("muteAll:doMute:")]
	void MuteAll (string callId, bool doMute);

	// -(_Bool)isOnHold:(NSString * _Nonnull)callId __attribute__((swift_name("isOnHold(callId:)")));
	[Export ("isOnHold:")]
	bool IsOnHold (string callId);

	// -(void)holdCall:(NSString * _Nonnull)callId isMuted:(_Bool)onHold __attribute__((swift_name("holdCall(callId:onHold:)")));
	[Export ("holdCall:isMuted:")]
	void HoldCall (string callId, bool onHold);

	// -(void)startAssociatedCall:(NSString * _Nonnull)callId dialNumber:(NSString * _Nonnull)dialNumber associationType:(enum CHCallAssociationType)associationType audioCall:(_Bool)audioCall callback:(CallStartedCompletionCallback _Nullable)callback __attribute__((swift_name("startAssociatedCall(callId:dialNumber:associationType:audioCall:callback:)")));
	[Export ("startAssociatedCall:dialNumber:associationType:audioCall:callback:")]
	void StartAssociatedCall (string callId, string dialNumber, CHCallAssociationType associationType, bool audioCall, [NullAllowed] CallStartedCompletionCallback callback);

	// -(void)transferCall:(NSString * _Nonnull)fromCallId toCallId:(NSString * _Nonnull)toCallId __attribute__((swift_name("transferCall(fromCallId:toCallId:)")));
	[Export ("transferCall:toCallId:")]
	void TransferCall (string fromCallId, string toCallId);

	// -(void)mergeCall:(NSString * _Nonnull)callId targetCallId:(NSString * _Nonnull)targetCallId __attribute__((swift_name("mergeCall(callId:targetCallId:)")));
	[Export ("mergeCall:targetCallId:")]
	void MergeCall (string callId, string targetCallId);

	// -(void)swapCamera:(NSString * _Nonnull)callId __attribute__((swift_name("swapCamera(callId:)")));
	[Export ("swapCamera:")]
	void SwapCamera (string callId);

	// -(void)restartAudioSession:(NSString * _Nonnull)callId;
	[Export ("restartAudioSession:")]
	void RestartAudioSession (string callId);

	// -(void)restartMediaSession:(NSString * _Nonnull)callId;
	[Export ("restartMediaSession:")]
	void RestartMediaSession (string callId);

	// -(NSArray<CHCallMembership *> * _Nonnull)getCallMemberships:(NSString * _Nonnull)callId __attribute__((swift_name("getCallMemberships(callId:)")));
	[Export ("getCallMemberships:")]
	CHCallMembership[] GetCallMemberships (string callId);

	// -(NSString * _Nonnull)getCallIdByNotificationId:(NSString * _Nonnull)notificationId notificationType:(enum CHNotificationCallType)notificationType __attribute__((swift_name("getCallIdByNotificationId(notificationId:notificationType:)")));
	[Export ("getCallIdByNotificationId:notificationType:")]
	string GetCallIdByNotificationId (string notificationId, CHNotificationCallType notificationType);

	// -(CHCall * _Nullable)getCall:(NSString * _Nonnull)callId __attribute__((swift_name("getCall(callId:)")));
	[Export ("getCall:")]
	[return: NullAllowed]
	CHCall GetCall (string callId);

	// -(void)setVideoMaxTxFPS:(NSNumber * _Nonnull)fps __attribute__((swift_name("setVideoMaxTxFPS(fps:)")));
	[Export ("setVideoMaxTxFPS:")]
	void SetVideoMaxTxFPS (NSNumber fps);

	// -(void)setVideoEnableDecoderMosaic:(_Bool)value __attribute__((swift_name("setVideoEnableDecoderMosaic(value:)")));
	[Export ("setVideoEnableDecoderMosaic:")]
	void SetVideoEnableDecoderMosaic (bool value);

	// -(NSString * _Nonnull)getWmeVersion __attribute__((swift_name("getWmeVersion()")));
	[Export ("getWmeVersion")]
	[Verify (MethodToProperty)]
	string WmeVersion { get; }

	// -(void)letIn:(NSString * _Nonnull)callId participantIds:(NSArray<NSString *> * _Nonnull)participantIds callback:(LetInCompletionCallback _Nonnull)callback __attribute__((swift_name("letIn(callId:participantIds:callback:)")));
	[Export ("letIn:participantIds:callback:")]
	void LetIn (string callId, string[] participantIds, LetInCompletionCallback callback);

	// -(void)sendFeedback:(NSNumber * _Nonnull)rating comments:(NSString * _Nonnull)comments __attribute__((swift_name("sendFeedback(rating:comments:)")));
	[Export ("sendFeedback:comments:")]
	void SendFeedback (NSNumber rating, string comments);

	// -(NSString * _Nonnull)sendDTMF:(NSString * _Nonnull)callId keys:(NSString * _Nonnull)keys __attribute__((swift_name("sendDTMF(callId:keys:)")));
	[Export ("sendDTMF:keys:")]
	string SendDTMF (string callId, string keys);

	// -(void)enableBNR:(NSString * _Nonnull)callId enable:(_Bool)enable __attribute__((swift_name("enableBNR(callId:enable:)")));
	[Export ("enableBNR:enable:")]
	void EnableBNR (string callId, bool enable);

	// -(_Bool)isBNREnabled:(NSString * _Nonnull)callId __attribute__((swift_name("isBNREnabled(callId:)")));
	[Export ("isBNREnabled:")]
	bool IsBNREnabled (string callId);

	// -(_Bool)setBNRProfileMode:(NSString * _Nonnull)callId mode:(NSNumber * _Nonnull)mode __attribute__((swift_name("setBNRProfileMode(callId:mode:)")));
	[Export ("setBNRProfileMode:mode:")]
	bool SetBNRProfileMode (string callId, NSNumber mode);

	// -(NSNumber * _Nonnull)getBNRProfileMode:(NSString * _Nonnull)callId __attribute__((swift_name("getBNRProfileMode(callId:)")));
	[Export ("getBNRProfileMode:")]
	NSNumber GetBNRProfileMode (string callId);

	// -(void)setVideoMaxRxBandwidth:(NSNumber * _Nonnull)bandwidth __attribute__((swift_name("setVideoMaxRxBandwidth(bandwidth:)")));
	[Export ("setVideoMaxRxBandwidth:")]
	void SetVideoMaxRxBandwidth (NSNumber bandwidth);

	// -(void)setVideoMaxTxBandwidth:(NSNumber * _Nonnull)bandwidth __attribute__((swift_name("setVideoMaxTxBandwidth(bandwidth:)")));
	[Export ("setVideoMaxTxBandwidth:")]
	void SetVideoMaxTxBandwidth (NSNumber bandwidth);

	// -(void)setSharingMaxRxBandwidth:(NSNumber * _Nonnull)bandwidth __attribute__((swift_name("setSharingMaxRxBandwidth(bandwidth:)")));
	[Export ("setSharingMaxRxBandwidth:")]
	void SetSharingMaxRxBandwidth (NSNumber bandwidth);

	// -(void)setAudioMaxRxBandwidth:(NSNumber * _Nonnull)bandwidth __attribute__((swift_name("setAudioMaxRxBandwidth(bandwidth:)")));
	[Export ("setAudioMaxRxBandwidth:")]
	void SetAudioMaxRxBandwidth (NSNumber bandwidth);

	// -(_Bool)cameraFocusAtPoint:(NSString * _Nonnull)callId pointX:(NSNumber * _Nonnull)pointX pointY:(NSNumber * _Nonnull)pointY __attribute__((swift_name("cameraFocusAtPoint(callId:pointX:pointY:)")));
	[Export ("cameraFocusAtPoint:pointX:pointY:")]
	bool CameraFocusAtPoint (string callId, NSNumber pointX, NSNumber pointY);

	// -(_Bool)setCameraFlashMode:(NSString * _Nonnull)callId mode:(enum CHVideoFlashMode)mode __attribute__((swift_name("setCameraFlashMode(callId:mode:)")));
	[Export ("setCameraFlashMode:mode:")]
	bool SetCameraFlashMode (string callId, CHVideoFlashMode mode);

	// -(enum CHVideoFlashMode)getCameraFlashMode:(NSString * _Nonnull)callId __attribute__((swift_name("getCameraFlashMode(callId:)")));
	[Export ("getCameraFlashMode:")]
	CHVideoFlashMode GetCameraFlashMode (string callId);

	// -(enum CHVideoTorchMode)getCameraTorchMode:(NSString * _Nonnull)callId __attribute__((swift_name("getCameraTorchMode(callId:)")));
	[Export ("getCameraTorchMode:")]
	CHVideoTorchMode GetCameraTorchMode (string callId);

	// -(_Bool)setCameraTorchMode:(NSString * _Nonnull)callId mode:(enum CHVideoTorchMode)mode __attribute__((swift_name("setCameraTorchMode(callId:mode:)")));
	[Export ("setCameraTorchMode:mode:")]
	bool SetCameraTorchMode (string callId, CHVideoTorchMode mode);

	// -(CHCameraExposureDuration * _Nonnull)getCameraExposureDuration:(NSString * _Nonnull)callId __attribute__((swift_name("getCameraExposureDuration(callId:)")));
	[Export ("getCameraExposureDuration:")]
	CHCameraExposureDuration GetCameraExposureDuration (string callId);

	// -(CHCameraExposureISO * _Nonnull)getCameraExposureISO:(NSString * _Nonnull)callId __attribute__((swift_name("getCameraExposureISO(callId:)")));
	[Export ("getCameraExposureISO:")]
	CHCameraExposureISO GetCameraExposureISO (string callId);

	// -(CHCameraExposureTargetBias * _Nonnull)getCameraExposureTargetBias:(NSString * _Nonnull)callId __attribute__((swift_name("getCameraExposureTargetBias(callId:)")));
	[Export ("getCameraExposureTargetBias:")]
	CHCameraExposureTargetBias GetCameraExposureTargetBias (string callId);

	// -(_Bool)setCameraCustomExposure:(NSString * _Nonnull)callId duration:(NSNumber * _Nonnull)duration iso:(NSNumber * _Nonnull)iso __attribute__((swift_name("setCameraCustomExposure(callId:duration:iso:)")));
	[Export ("setCameraCustomExposure:duration:iso:")]
	bool SetCameraCustomExposure (string callId, NSNumber duration, NSNumber iso);

	// -(_Bool)setCameraAutoExposure:(NSString * _Nonnull)callId targetBias:(NSNumber * _Nonnull)targetBias __attribute__((swift_name("setCameraAutoExposure(callId:targetBias:)")));
	[Export ("setCameraAutoExposure:targetBias:")]
	bool SetCameraAutoExposure (string callId, NSNumber targetBias);

	// -(_Bool)setVideoZoomFactor:(NSString * _Nonnull)callId factor:(NSNumber * _Nonnull)factor __attribute__((swift_name("setVideoZoomFactor(callId:factor:)")));
	[Export ("setVideoZoomFactor:factor:")]
	bool SetVideoZoomFactor (string callId, NSNumber factor);

	// -(NSNumber * _Nonnull)getVideoZoomFactor:(NSString * _Nonnull)callId __attribute__((swift_name("getVideoZoomFactor(callId:)")));
	[Export ("getVideoZoomFactor:")]
	NSNumber GetVideoZoomFactor (string callId);

	// -(_Bool)takePhoto:(NSString * _Nonnull)callId __attribute__((swift_name("takePhoto(callId:)")));
	[Export ("takePhoto:")]
	bool TakePhoto (string callId);

	// -(void)startPreview:(void * _Nonnull)viewHandle __attribute__((swift_name("startPreview(viewHandle:)")));
	[Export ("startPreview:")]
	unsafe void StartPreview (void* viewHandle);

	// -(void)stopPreview __attribute__((swift_name("stopPreview()")));
	[Export ("stopPreview")]
	void StopPreview ();

	// -(void)setVideoStreamMode:(enum CHVideoStreamMode)mode __attribute__((swift_name("setVideoStreamMode(mode:)")));
	[Export ("setVideoStreamMode:")]
	void SetVideoStreamMode (CHVideoStreamMode mode);

	// -(enum CHVideoStreamMode)getVideoStreamMode __attribute__((swift_name("getVideoStreamMode()")));
	[Export ("getVideoStreamMode")]
	[Verify (MethodToProperty)]
	CHVideoStreamMode VideoStreamMode { get; }

	// -(void)setCompositedVideoLayout:(NSString * _Nonnull)callId layout:(enum CHCompositedVideoLayout)layout __attribute__((swift_name("setCompositedVideoLayout(callId:layout:)")));
	[Export ("setCompositedVideoLayout:layout:")]
	void SetCompositedVideoLayout (string callId, CHCompositedVideoLayout layout);

	// -(void)setCompositedVideoLayout:(NSString * _Nonnull)callId layout:(enum CHCompositedVideoLayout)layout callback:(CompositedVideoLayoutCompletionCallback _Nonnull)callback __attribute__((swift_name("setCompositedVideoLayout(callId:layout:callback:)")));
	[Export ("setCompositedVideoLayout:layout:callback:")]
	void SetCompositedVideoLayout (string callId, CHCompositedVideoLayout layout, CompositedVideoLayoutCompletionCallback callback);

	// -(enum CHCompositedVideoLayout)getCompositedVideoLayout:(NSString * _Nonnull)callId __attribute__((swift_name("getCompositedVideoLayout(callId:)")));
	[Export ("getCompositedVideoLayout:")]
	CHCompositedVideoLayout GetCompositedVideoLayout (string callId);

	// -(void)addAuxVideoView:(NSString * _Nonnull)callId type:(enum CHMediaStreamType)type auxView:(void * _Nullable)auxView __attribute__((swift_name("addAuxVideoView(callId:type:auxView:)")));
	[Export ("addAuxVideoView:type:auxView:")]
	unsafe void AddAuxVideoView (string callId, CHMediaStreamType type, [NullAllowed] void* auxView);

	// -(void)removeAuxVideoView:(NSString * _Nonnull)callId type:(enum CHMediaStreamType)type auxView:(void * _Nullable)auxView __attribute__((swift_name("removeAuxVideoView(callId:type:auxView:)")));
	[Export ("removeAuxVideoView:type:auxView:")]
	unsafe void RemoveAuxVideoView (string callId, CHMediaStreamType type, [NullAllowed] void* auxView);

	// -(void)setDefaultCameraMode:(NSNumber * _Nonnull)mode __attribute__((swift_name("setDefaultCameraMode(mode:)")));
	[Export ("setDefaultCameraMode:")]
	void SetDefaultCameraMode (NSNumber mode);

	// -(void)setVideoRenderViews:(NSString * _Nonnull)callId localVideoView:(void * _Nullable)localVideoView remoteVideoView:(void * _Nullable)remoteVideoView __attribute__((swift_name("setVideoRenderViews(callId:localVideoView:remoteVideoView:)")));
	[Export ("setVideoRenderViews:localVideoView:remoteVideoView:")]
	unsafe void SetVideoRenderViews (string callId, [NullAllowed] void* localVideoView, [NullAllowed] void* remoteVideoView);

	// -(void)setSharingRenderView:(NSString * _Nonnull)callId sharingVideoView:(void * _Nullable)sharingVideoView __attribute__((swift_name("setSharingRenderView(callId:sharingVideoView:)")));
	[Export ("setSharingRenderView:sharingVideoView:")]
	unsafe void SetSharingRenderView (string callId, [NullAllowed] void* sharingVideoView);

	// -(void)setRemoteVideoRenderMode:(NSString * _Nonnull)callId mode:(CHVideoRenderMode)mode __attribute__((swift_name("setRemoteVideoRenderMode(callId:mode:)")));
	[Export ("setRemoteVideoRenderMode:mode:")]
	void SetRemoteVideoRenderMode (string callId, CHVideoRenderMode mode);

	// -(void)onScheduleChanged:(NSString * _Nonnull)callId callback:(CallScheduleChangedCompletionCallback _Nonnull)callback __attribute__((swift_name("onScheduleChanged(callId:callback:)")));
	[Export ("onScheduleChanged:callback:")]
	void OnScheduleChanged (string callId, CallScheduleChangedCompletionCallback callback);

	// -(void)setIncomingCallListener:(IncomingCompletionCallback _Nonnull)callback __attribute__((swift_name("setIncomingCallListener(callback:)")));
	[Export ("setIncomingCallListener:")]
	void SetIncomingCallListener (IncomingCompletionCallback callback);

	// -(void)setDeviceChangedListener:(NSString * _Nonnull)callId callback:(DeviceChangedCompletionCallback _Nonnull)callback __attribute__((swift_name("setDeviceChangedListener(callId:callback:)")));
	[Export ("setDeviceChangedListener:callback:")]
	void SetDeviceChangedListener (string callId, DeviceChangedCompletionCallback callback);

	// -(void)setSendingVideo:(NSString * _Nonnull)callId sending:(_Bool)sending __attribute__((swift_name("setSendingVideo(callId:sending:)")));
	[Export ("setSendingVideo:sending:")]
	void SetSendingVideo (string callId, bool sending);

	// -(void)setSendingAudio:(NSString * _Nonnull)callId sending:(_Bool)sending __attribute__((swift_name("setSendingAudio(callId:sending:)")));
	[Export ("setSendingAudio:sending:")]
	void SetSendingAudio (string callId, bool sending);

	// -(void)setSendingSharing:(NSString * _Nonnull)callId sending:(_Bool)sending sourceId:(NSString * _Nonnull)sourceId __attribute__((swift_name("setSendingSharing(callId:sending:sourceId:)")));
	[Export ("setSendingSharing:sending:sourceId:")]
	void SetSendingSharing (string callId, bool sending, string sourceId);

	// -(void)setReceivingVideo:(NSString * _Nonnull)callId receiving:(_Bool)receiving __attribute__((swift_name("setReceivingVideo(callId:receiving:)")));
	[Export ("setReceivingVideo:receiving:")]
	void SetReceivingVideo (string callId, bool receiving);

	// -(void)setReceivingAudio:(NSString * _Nonnull)callId receiving:(_Bool)receiving __attribute__((swift_name("setReceivingAudio(callId:receiving:)")));
	[Export ("setReceivingAudio:receiving:")]
	void SetReceivingAudio (string callId, bool receiving);

	// -(void)setReceivingSharing:(NSString * _Nonnull)callId receiving:(_Bool)receiving __attribute__((swift_name("setReceivingSharing(callId:receiving:)")));
	[Export ("setReceivingSharing:receiving:")]
	void SetReceivingSharing (string callId, bool receiving);

	// -(void)setOnCallRingingChangedListener:(NSString * _Nonnull)callId callback:(CallRingingChangedCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCallRingingChangedListener(callId:callback:)")));
	[Export ("setOnCallRingingChangedListener:callback:")]
	void SetOnCallRingingChangedListener (string callId, CallRingingChangedCompletionCallback callback);

	// -(void)setOnCallConnectedListener:(NSString * _Nonnull)callId callback:(CallConnectedCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCallConnectedListener(callId:callback:)")));
	[Export ("setOnCallConnectedListener:callback:")]
	void SetOnCallConnectedListener (string callId, CallConnectedCompletionCallback callback);

	// -(void)setOnCallDisconnectedListener:(NSString * _Nonnull)callId callback:(CallDisconnectedCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCallDisconnectedListener(callId:callback:)")));
	[Export ("setOnCallDisconnectedListener:callback:")]
	void SetOnCallDisconnectedListener (string callId, CallDisconnectedCompletionCallback callback);

	// -(void)setOnCallTerminatedListener:(NSString * _Nonnull)callId callback:(CallTerminatedCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCallTerminatedListener(callId:callback:)")));
	[Export ("setOnCallTerminatedListener:callback:")]
	void SetOnCallTerminatedListener (string callId, CallTerminatedCompletionCallback callback);

	// -(void)setOnCallFailedListener:(NSString * _Nonnull)callId callback:(CallFailedCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCallFailedListener(callId:callback:)")));
	[Export ("setOnCallFailedListener:callback:")]
	void SetOnCallFailedListener (string callId, CallFailedCompletionCallback callback);

	// -(void)setOnCallInfoChangedListener:(NSString * _Nonnull)callId callback:(CallInfoChangedCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCallInfoChangedListener(callId:callback:)")));
	[Export ("setOnCallInfoChangedListener:callback:")]
	void SetOnCallInfoChangedListener (string callId, CallInfoChangedCompletionCallback callback);

	// -(_Bool)isVirtualBackgroundSupported __attribute__((swift_name("isVirtualBackgroundSupported()")));
	[Export ("isVirtualBackgroundSupported")]
	[Verify (MethodToProperty)]
	bool IsVirtualBackgroundSupported { get; }

	// -(void)fetchVirtualBackgroundItems:(FetchVirtualBackgroundCompletionCallback _Nonnull)callback __attribute__((swift_name("fetchVirtualBackgroundItems(callback:)")));
	[Export ("fetchVirtualBackgroundItems:")]
	void FetchVirtualBackgroundItems (FetchVirtualBackgroundCompletionCallback callback);

	// -(void)uploadVirtualBackground:(NSDictionary<CHLocalFile *,NSArray<NSData *> *> * _Nonnull)backgroundImage callback:(UploadVirtualBackgroundCompletionCallback _Nonnull)callback __attribute__((swift_name("uploadVirtualBackground(item:callback:)")));
	[Export ("uploadVirtualBackground:callback:")]
	void UploadVirtualBackground (NSDictionary<CHLocalFile, NSArray<NSData>> backgroundImage, UploadVirtualBackgroundCompletionCallback callback);

	// -(void)deleteVirtualBackgroundItem:(CHVirtualBackgroundItem * _Nonnull)item callback:(DeleteVirtualBackgroundCompletionCallback _Nonnull)callback __attribute__((swift_name("deleteVirtualBackgroundItem(item:callback:)")));
	[Export ("deleteVirtualBackgroundItem:callback:")]
	void DeleteVirtualBackgroundItem (CHVirtualBackgroundItem item, DeleteVirtualBackgroundCompletionCallback callback);

	// -(void)setVirtualBackgroundForPreview:(CHVirtualBackgroundItem * _Nonnull)item callback:(PreviewVirtualBackgroundCompletionCallback _Nonnull)callback __attribute__((swift_name("setVirtualBackgroundForPreview(item:callback:)")));
	[Export ("setVirtualBackgroundForPreview:callback:")]
	void SetVirtualBackgroundForPreview (CHVirtualBackgroundItem item, PreviewVirtualBackgroundCompletionCallback callback);

	// -(void)setVirtualBackgroundForCall:(CHVirtualBackgroundItem * _Nonnull)item callback:(ApplyVirtualBackgroundCompletionCallback _Nonnull)callback __attribute__((swift_name("setVirtualBackgroundForCall(item:callback:)")));
	[Export ("setVirtualBackgroundForCall:callback:")]
	void SetVirtualBackgroundForCall (CHVirtualBackgroundItem item, ApplyVirtualBackgroundCompletionCallback callback);

	// -(void)setOnPerformanceCausedResolutionChangedListener:(NSString * _Nonnull)callId callback:(CallOnHitCpuThresholdCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnPerformanceCausedResolutionChangedListener(callId:callback:)")));
	[Export ("setOnPerformanceCausedResolutionChangedListener:callback:")]
	void SetOnPerformanceCausedResolutionChangedListener (string callId, CallOnHitCpuThresholdCompletionCallback callback);

	// -(void)setVirtualBackgroundLimit:(NSNumber * _Nonnull)limit __attribute__((swift_name("setVirtualBackgroundLimit(limit:)")));
	[Export ("setVirtualBackgroundLimit:")]
	void SetVirtualBackgroundLimit (NSNumber limit);

	// -(NSNumber * _Nonnull)getVirtualBackgroundLimit __attribute__((swift_name("getVirtualBackgroundLimit()")));
	[Export ("getVirtualBackgroundLimit")]
	[Verify (MethodToProperty)]
	NSNumber VirtualBackgroundLimit { get; }

	// -(void)forceSendingVideoLandscape:(NSString * _Nonnull)callId forceLandscape:(_Bool)forceLandscape callback:(VideoForceLandscapeCompletionCallback _Nonnull)callback __attribute__((swift_name("forceSendingVideoLandscape(callId:forceLandscape:callback:)")));
	[Export ("forceSendingVideoLandscape:forceLandscape:callback:")]
	void ForceSendingVideoLandscape (string callId, bool forceLandscape, VideoForceLandscapeCompletionCallback callback);

	// -(void)setOnCallPhotoOutputListener:(NSString * _Nonnull)callId callback:(CallPhotoOutputCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCallPhotoOutputListener(callId:callback:)")));
	[Export ("setOnCallPhotoOutputListener:callback:")]
	void SetOnCallPhotoOutputListener (string callId, CallPhotoOutputCompletionCallback callback);

	// -(void)setOnTranscriptionArrivedListener:(NSString * _Nonnull)callId callback:(CallTranscriptionArrivedCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnTranscriptionArrivedListener(callId:callback:)")));
	[Export ("setOnTranscriptionArrivedListener:callback:")]
	void SetOnTranscriptionArrivedListener (string callId, CallTranscriptionArrivedCompletionCallback callback);

	// -(void)setWXAEnabled:(NSString * _Nonnull)callId isEnabled:(_Bool)isEnabled callback:(SingleBoolCompletionFuncCallback _Nonnull)callback __attribute__((swift_name("setWXAEnabled(callId:isEnabled:callback:)")));
	[Export ("setWXAEnabled:isEnabled:callback:")]
	void SetWXAEnabled (string callId, bool isEnabled, SingleBoolCompletionFuncCallback callback);

	// -(void)listCalendarMeetings:(NSDate * _Nullable)fromDate toDate:(NSDate * _Nullable)toDate callback:(ListCalendarMeetingsCompletionCallback _Nonnull)callback __attribute__((swift_name("listCalendarMeetings(fromDate:toDate:callback:)")));
	[Export ("listCalendarMeetings:toDate:callback:")]
	void ListCalendarMeetings ([NullAllowed] NSDate fromDate, [NullAllowed] NSDate toDate, ListCalendarMeetingsCompletionCallback callback);

	// -(void)getCalendarMeeting:(NSString * _Nonnull)meetingId callback:(GetCalendarMeetingCompletionCallback _Nonnull)callback __attribute__((swift_name("getCalendarMeeting(meetingId:callback:)")));
	[Export ("getCalendarMeeting:callback:")]
	void GetCalendarMeeting (string meetingId, GetCalendarMeetingCompletionCallback callback);

	// -(void)setOnCalendarMeetingEventListener:(CalendarMeetingEventCompletionCallback _Nonnull)callback __attribute__((swift_name("setOnCalendarMeetingEventListener(callback:)")));
	[Export ("setOnCalendarMeetingEventListener:")]
	void SetOnCalendarMeetingEventListener (CalendarMeetingEventCompletionCallback callback);

	// -(void)getMe:(PersonGetResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("getMe(completionHandler:)")));
	[Export ("getMe:")]
	void GetMe (PersonGetResultCompletionFuncCallback completionHandler);

	// -(void)getPersonWithId:(NSString * _Nonnull)personId completionHandler:(PersonGetResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("getPersonWithId(personId:completionHandler:)")));
	[Export ("getPersonWithId:completionHandler:")]
	void GetPersonWithId (string personId, PersonGetResultCompletionFuncCallback completionHandler);

	// -(void)listPersons:(NSString * _Nullable)email displayName:(NSString * _Nullable)displayName idString:(NSString * _Nullable)idString orgId:(NSString * _Nullable)orgId max:(NSNumber * _Nullable)max completionHandler:(ListPersonsCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listPersons(email:displayName:idString:orgId:max:completionHandler:)")));
	[Export ("listPersons:displayName:idString:orgId:max:completionHandler:")]
	void ListPersons ([NullAllowed] string email, [NullAllowed] string displayName, [NullAllowed] string idString, [NullAllowed] string orgId, [NullAllowed] NSNumber max, ListPersonsCompletionFuncCallback completionHandler);

	// -(void)createPerson:(NSString * _Nonnull)email displayName:(NSString * _Nullable)displayName firstName:(NSString * _Nullable)firstName lastName:(NSString * _Nullable)lastName avatar:(NSString * _Nullable)avatar orgId:(NSString * _Nullable)orgId roles:(NSString * _Nullable)roles licenses:(NSString * _Nullable)licenses completionHandler:(CreatePersonCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createPerson(email:displayName:firstName:lastName:avatar:orgId:roles:licenses:completionHandler:)")));
	[Export ("createPerson:displayName:firstName:lastName:avatar:orgId:roles:licenses:completionHandler:")]
	void CreatePerson (string email, [NullAllowed] string displayName, [NullAllowed] string firstName, [NullAllowed] string lastName, [NullAllowed] string avatar, [NullAllowed] string orgId, [NullAllowed] string roles, [NullAllowed] string licenses, CreatePersonCompletionFuncCallback completionHandler);

	// -(void)updatePerson:(NSString * _Nonnull)personId email:(NSString * _Nullable)email displayName:(NSString * _Nullable)displayName firstName:(NSString * _Nullable)firstName lastName:(NSString * _Nullable)lastName avatar:(NSString * _Nullable)avatar orgId:(NSString * _Nullable)orgId roles:(NSString * _Nullable)roles licenses:(NSString * _Nullable)licenses completionHandler:(UpdatePersonCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("updatePerson(personId:email:displayName:firstName:lastName:avatar:orgId:roles:licenses:completionHandler:)")));
	[Export ("updatePerson:email:displayName:firstName:lastName:avatar:orgId:roles:licenses:completionHandler:")]
	void UpdatePerson (string personId, [NullAllowed] string email, [NullAllowed] string displayName, [NullAllowed] string firstName, [NullAllowed] string lastName, [NullAllowed] string avatar, [NullAllowed] string orgId, [NullAllowed] string roles, [NullAllowed] string licenses, UpdatePersonCompletionFuncCallback completionHandler);

	// -(void)deletePerson:(NSString * _Nonnull)personId completionHandler:(DeletePersonCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("deletePerson(personId:completionHandler:)")));
	[Export ("deletePerson:completionHandler:")]
	void DeletePerson (string personId, DeletePersonCompletionFuncCallback completionHandler);

	// -(void)listTeams:(NSNumber * _Nonnull)maxTeams completionHandler:(TeamListResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listTeams(maxTeams:completionHandler:)")));
	[Export ("listTeams:completionHandler:")]
	void ListTeams (NSNumber maxTeams, TeamListResultCompletionFuncCallback completionHandler);

	// -(void)createTeam:(NSString * _Nonnull)name completionHandler:(TeamCreateResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createTeam(name:completionHandler:)")));
	[Export ("createTeam:completionHandler:")]
	void CreateTeam (string name, TeamCreateResultCompletionFuncCallback completionHandler);

	// -(void)getTeamWithId:(NSString * _Nonnull)teamId completionHandler:(TeamGetResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("getTeamWithId(teamId:completionHandler:)")));
	[Export ("getTeamWithId:completionHandler:")]
	void GetTeamWithId (string teamId, TeamGetResultCompletionFuncCallback completionHandler);

	// -(void)updateTeamWith:(NSString * _Nonnull)teamId newName:(NSString * _Nonnull)newName completionHandler:(TeamUpdateResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("updateTeamWith(teamId:newName:completionHandler:)")));
	[Export ("updateTeamWith:newName:completionHandler:")]
	void UpdateTeamWith (string teamId, string newName, TeamUpdateResultCompletionFuncCallback completionHandler);

	// -(void)deleteTeamWithId:(NSString * _Nonnull)teamId completionHandler:(TeamArchiveResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("deleteTeamWithId(teamId:completionHandler:)")));
	[Export ("deleteTeamWithId:completionHandler:")]
	void DeleteTeamWithId (string teamId, TeamArchiveResultCompletionFuncCallback completionHandler);

	// -(void)listSpaces:(NSString * _Nullable)teamId max:(NSNumber * _Nullable)max conversationType:(enum CHConversationType)conversationType sortType:(enum CHConversationSortType)sortType completionHandler:(ListSpacesCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listSpaces(teamId:max:conversationType:sortType:completionHandler:)")));
	[Export ("listSpaces:max:conversationType:sortType:completionHandler:")]
	void ListSpaces ([NullAllowed] string teamId, [NullAllowed] NSNumber max, CHConversationType conversationType, CHConversationSortType sortType, ListSpacesCompletionFuncCallback completionHandler);

	// -(void)getSpace:(NSString * _Nonnull)spaceId completionHandler:(SingleSpaceCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("getSpace(spaceId:completionHandler:)")));
	[Export ("getSpace:completionHandler:")]
	void GetSpace (string spaceId, SingleSpaceCompletionFuncCallback completionHandler);

	// -(void)createSpace:(NSString * _Nullable)teamId title:(NSString * _Nonnull)title completionHandler:(SingleSpaceCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createSpace(teamId:title:completionHandler:)")));
	[Export ("createSpace:title:completionHandler:")]
	void CreateSpace ([NullAllowed] string teamId, string title, SingleSpaceCompletionFuncCallback completionHandler);

	// -(void)updateSpaceTitle:(NSString * _Nonnull)spaceId newTitle:(NSString * _Nonnull)newTitle completionHandler:(UpdateSpaceTitleResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("updateSpaceTitle(spaceId:newTitle:completionHandler:)")));
	[Export ("updateSpaceTitle:newTitle:completionHandler:")]
	void UpdateSpaceTitle (string spaceId, string newTitle, UpdateSpaceTitleResultCompletionFuncCallback completionHandler);

	// -(void)deleteSpace:(NSString * _Nonnull)spaceId completionHandler:(DeleteSpaceCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("deleteSpace(spaceId:completionHandler:)")));
	[Export ("deleteSpace:completionHandler:")]
	void DeleteSpace (string spaceId, DeleteSpaceCompletionFuncCallback completionHandler);

	// -(void)getMeetingInfoFor:(NSString * _Nonnull)spaceId completionHandler:(void (^ _Nonnull)(CHSpaceMeetingInfo * _Nullable, BOOL))completionHandler;
	[Export ("getMeetingInfoFor:completionHandler:")]
	void GetMeetingInfoFor (string spaceId, Action<CHSpaceMeetingInfo, bool> completionHandler);

	// -(void)getReadStatus:(NSString * _Nonnull)spaceId completionHandler:(SingleSpaceReadStatusCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("getReadStatus(spaceId:completionHandler:)")));
	[Export ("getReadStatus:completionHandler:")]
	void GetReadStatus (string spaceId, SingleSpaceReadStatusCompletionFuncCallback completionHandler);

	// -(void)listReadStatus:(NSNumber * _Nonnull)max completionHandler:(ListSpaceReadStatusCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listReadStatus(max:completionHandler:)")));
	[Export ("listReadStatus:completionHandler:")]
	void ListReadStatus (NSNumber max, ListSpaceReadStatusCompletionFuncCallback completionHandler);

	// -(void)setOnSpaceEventListener:(SpaceEventCompletionCallback _Nullable)callback __attribute__((swift_name("setOnSpaceEventListener(callback:)")));
	[Export ("setOnSpaceEventListener:")]
	void SetOnSpaceEventListener ([NullAllowed] SpaceEventCompletionCallback callback);

	// -(void)setOnSpaceEventWithPayloadListener:(SpaceEventWithPayloadCompletionCallback _Nullable)callback __attribute__((swift_name("setOnSpaceEventWithPayloadListener(callback:)")));
	[Export ("setOnSpaceEventWithPayloadListener:")]
	void SetOnSpaceEventWithPayloadListener ([NullAllowed] SpaceEventWithPayloadCompletionCallback callback);

	// -(void)listWithActiveCalls:(ListSpacesActiveCallsCompletionCallback _Nonnull)completionHandler __attribute__((swift_name("listWithActiveCalls(completionHandler:)")));
	[Export ("listWithActiveCalls:")]
	void ListWithActiveCalls (ListSpacesActiveCallsCompletionCallback completionHandler);

	// -(void)listTeamMembershipIn:(NSString * _Nonnull)teamId max:(NSNumber * _Nullable)max completionHandler:(ListTeamMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listTeamMembershipIn(teamId:max:completionHandler:)")));
	[Export ("listTeamMembershipIn:max:completionHandler:")]
	void ListTeamMembershipIn (string teamId, [NullAllowed] NSNumber max, ListTeamMembershipCompletionFuncCallback completionHandler);

	// -(void)createTeamMembershipWithPersonId:(NSString * _Nonnull)personId teamId:(NSString * _Nonnull)teamId isModerator:(_Bool)isModerator completionHandler:(CreateTeamMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createTeamMembershipWith(personId:teamId:isModerator:completionHandler:)")));
	[Export ("createTeamMembershipWithPersonId:teamId:isModerator:completionHandler:")]
	void CreateTeamMembershipWithPersonId (string personId, string teamId, bool isModerator, CreateTeamMembershipCompletionFuncCallback completionHandler);

	// -(void)createTeamMembershipWithEmailAddress:(NSString * _Nonnull)emailAddress teamId:(NSString * _Nonnull)teamId isModerator:(_Bool)isModerator completionHandler:(CreateTeamMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createTeamMembershipWith(emailAddress:teamId:isModerator:completionHandler:)")));
	[Export ("createTeamMembershipWithEmailAddress:teamId:isModerator:completionHandler:")]
	void CreateTeamMembershipWithEmailAddress (string emailAddress, string teamId, bool isModerator, CreateTeamMembershipCompletionFuncCallback completionHandler);

	// -(void)getTeamMembership:(NSString * _Nonnull)teamMembershipId completionHandler:(GetTeamMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("getTeamMembership(teamMembershipId:completionHandler:)")));
	[Export ("getTeamMembership:completionHandler:")]
	void GetTeamMembership (string teamMembershipId, GetTeamMembershipCompletionFuncCallback completionHandler);

	// -(void)updateTeamMembershipWith:(NSString * _Nonnull)teamMembershipId isModerator:(_Bool)isModerator completionHandler:(UpdateTeamMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("updateTeamMembershipWith(teamMembershipId:isModerator:completionHandler:)")));
	[Export ("updateTeamMembershipWith:isModerator:completionHandler:")]
	void UpdateTeamMembershipWith (string teamMembershipId, bool isModerator, UpdateTeamMembershipCompletionFuncCallback completionHandler);

	// -(void)deleteTeamMembershipWithId:(NSString * _Nonnull)teamMembershipId completionHandler:(DeleteTeamMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("deleteTeamMembershipWithId(teamMembershipId:completionHandler:)")));
	[Export ("deleteTeamMembershipWithId:completionHandler:")]
	void DeleteTeamMembershipWithId (string teamMembershipId, DeleteTeamMembershipCompletionFuncCallback completionHandler);

	// -(void)listMemberships:(NSString * _Nullable)spaceId personId:(NSString * _Nullable)personId email:(NSString * _Nullable)email max:(NSNumber * _Nullable)max completionHandler:(ListMembershipsCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listMemberships(spaceId:personId:email:max:completionHandler:)")));
	[Export ("listMemberships:personId:email:max:completionHandler:")]
	void ListMemberships ([NullAllowed] string spaceId, [NullAllowed] string personId, [NullAllowed] string email, [NullAllowed] NSNumber max, ListMembershipsCompletionFuncCallback completionHandler);

	// -(void)getMembership:(NSString * _Nonnull)membershipId completionHandler:(GetMembershipByMembershipIdCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("get(membershipId:completionHandler:)")));
	[Export ("getMembership:completionHandler:")]
	void GetMembership (string membershipId, GetMembershipByMembershipIdCompletionFuncCallback completionHandler);

	// -(void)updateMembershipWith:(NSString * _Nonnull)membershipId isModerator:(_Bool)isModerator completionHandler:(MembershipUpdateResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("updateMembershipWith(membershipId:isModerator:completionHandler:)")));
	[Export ("updateMembershipWith:isModerator:completionHandler:")]
	void UpdateMembershipWith (string membershipId, bool isModerator, MembershipUpdateResultCompletionFuncCallback completionHandler);

	// -(void)createMembershipWithPersonId:(NSString * _Nonnull)personId spaceId:(NSString * _Nonnull)spaceId isModerator:(_Bool)isModerator completionHandler:(CreateMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createMembershipWith(personId:spaceId:isModerator:completionHandler:)")));
	[Export ("createMembershipWithPersonId:spaceId:isModerator:completionHandler:")]
	void CreateMembershipWithPersonId (string personId, string spaceId, bool isModerator, CreateMembershipCompletionFuncCallback completionHandler);

	// -(void)createMembershipWithEmailAddress:(NSString * _Nonnull)emailAddress spaceId:(NSString * _Nonnull)spaceId isModerator:(_Bool)isModerator completionHandler:(CreateMembershipCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createMembershipWith(emailAddress:spaceId:isModerator:completionHandler:)")));
	[Export ("createMembershipWithEmailAddress:spaceId:isModerator:completionHandler:")]
	void CreateMembershipWithEmailAddress (string emailAddress, string spaceId, bool isModerator, CreateMembershipCompletionFuncCallback completionHandler);

	// -(void)deleteMembershipWithId:(NSString * _Nonnull)membershipId completionHandler:(MembershipDeleteResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("deleteMembershipWithId(membershipId:completionHandler:)")));
	[Export ("deleteMembershipWithId:completionHandler:")]
	void DeleteMembershipWithId (string membershipId, MembershipDeleteResultCompletionFuncCallback completionHandler);

	// -(void)listMembershipsWithReadStatus:(NSString * _Nonnull)spaceId completionHandler:(ListMembershipsReadStatusCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listMembershipsWithReadStatus(spaceId:completionHandler:)")));
	[Export ("listMembershipsWithReadStatus:completionHandler:")]
	void ListMembershipsWithReadStatus (string spaceId, ListMembershipsReadStatusCompletionFuncCallback completionHandler);

	// -(void)setOnMembershipEventListener:(MembershipEventCompletionCallback _Nullable)callback __attribute__((swift_name("setOnMembershipEventListener(callback:)")));
	[Export ("setOnMembershipEventListener:")]
	void SetOnMembershipEventListener ([NullAllowed] MembershipEventCompletionCallback callback);

	// -(void)setOnMembershipEventWithPayloadListener:(MembershipEventWithPayloadCompletionCallback _Nullable)callback __attribute__((swift_name("setOnMembershipEventWithPayloadListener(callback:)")));
	[Export ("setOnMembershipEventWithPayloadListener:")]
	void SetOnMembershipEventWithPayloadListener ([NullAllowed] MembershipEventWithPayloadCompletionCallback callback);

	// -(void)listMessages:(NSString * _Nonnull)spaceId max:(NSNumber * _Nonnull)max beforeMessageId:(NSString * _Nullable)beforeMessageId beforeDate:(NSDate * _Nullable)beforeDate mentionedPeople:(NSArray<CHMention *> * _Nullable)mentionedPeople completionHandler:(ListMessagesCompletionFuncCallback _Nonnull)completionHandler;
	[Export ("listMessages:max:beforeMessageId:beforeDate:mentionedPeople:completionHandler:")]
	void ListMessages (string spaceId, NSNumber max, [NullAllowed] string beforeMessageId, [NullAllowed] NSDate beforeDate, [NullAllowed] CHMention[] mentionedPeople, ListMessagesCompletionFuncCallback completionHandler);

	// -(void)markMessageRead:(NSString * _Nonnull)spaceId messageId:(NSString * _Nullable)messageId completionHandler:(MarkMessageResultCompletionFuncCallback _Nonnull)completionHandler;
	[Export ("markMessageRead:messageId:completionHandler:")]
	void MarkMessageRead (string spaceId, [NullAllowed] string messageId, MarkMessageResultCompletionFuncCallback completionHandler);

	// -(void)getMessage:(NSString * _Nonnull)messageId completionHandler:(SingleMessageCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("getMessage(messageId:completionHandler:)")));
	[Export ("getMessage:completionHandler:")]
	void GetMessage (string messageId, SingleMessageCompletionFuncCallback completionHandler);

	// -(void)deleteMessage:(NSString * _Nonnull)messageId completionHandler:(MessageDeleteResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("deleteMessage(messageId:completionHandler:)")));
	[Export ("deleteMessage:completionHandler:")]
	void DeleteMessage (string messageId, MessageDeleteResultCompletionFuncCallback completionHandler);

	// -(void)downloadFile:(NSString * _Nonnull)spaceId messageId:(NSString * _Nonnull)messageId contentIndex:(NSNumber * _Nonnull)contentIndex downloadPath:(NSString * _Nonnull)downloadPath progressHandler:(MessageDownloadFileProgressCompletionFuncCallback _Nullable)progressHandler completionHandler:(MessageDownloadFileCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("downloadFile(spaceId:messageId:contentIndex:downloadPath:progressHandler:completionHandler:)")));
	[Export ("downloadFile:messageId:contentIndex:downloadPath:progressHandler:completionHandler:")]
	void DownloadFile (string spaceId, string messageId, NSNumber contentIndex, string downloadPath, [NullAllowed] MessageDownloadFileProgressCompletionFuncCallback progressHandler, MessageDownloadFileCompletionFuncCallback completionHandler);

	// -(void)postMessage:(CHMessageText * _Nullable)messageText destination:(NSString * _Nonnull)destination parent:(NSString * _Nullable)parent mentions:(NSArray<CHMention *> * _Nonnull)mentions files:(NSArray<NSDictionary<CHLocalFile *,NSArray<NSData *> *> *> * _Nonnull)files completionHandler:(MessagePostCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("postMessage(messageText:destination:parent:mentions:files:completionHandler:)")));
	[Export ("postMessage:destination:parent:mentions:files:completionHandler:")]
	void PostMessage ([NullAllowed] CHMessageText messageText, string destination, [NullAllowed] string parent, CHMention[] mentions, NSDictionary<CHLocalFile, NSArray<NSData>>[] files, MessagePostCompletionFuncCallback completionHandler);

	// -(void)editMessage:(CHMessageText * _Nullable)messageText spaceId:(NSString * _Nonnull)spaceId parent:(NSString * _Nonnull)parent mentions:(NSArray<CHMention *> * _Nonnull)mentions completionHandler:(MessagePostCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("editMessage(messageText:conversationId:parentId:mentions:completionHandler:)")));
	[Export ("editMessage:spaceId:parent:mentions:completionHandler:")]
	void EditMessage ([NullAllowed] CHMessageText messageText, string spaceId, string parent, CHMention[] mentions, MessagePostCompletionFuncCallback completionHandler);

	// -(void)downloadThumbnail:(NSString * _Nonnull)spaceId messageId:(NSString * _Nonnull)messageId contentIndex:(NSNumber * _Nonnull)contentIndex completionHandler:(MessageThumbnailResultCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("downloadThumbnail(spaceId:messageId:contentIndex:completionHandler:)")));
	[Export ("downloadThumbnail:messageId:contentIndex:completionHandler:")]
	void DownloadThumbnail (string spaceId, string messageId, NSNumber contentIndex, MessageThumbnailResultCompletionFuncCallback completionHandler);

	// -(void)setOnMessageEventListener:(MessageEventCompletionCallback _Nullable)callback __attribute__((swift_name("setOnMessageEventListener(callback:)")));
	[Export ("setOnMessageEventListener:")]
	void SetOnMessageEventListener ([NullAllowed] MessageEventCompletionCallback callback);

	// -(void)setOnMessageEventWithPayloadListener:(MessageEventWithPayloadCompletionCallback _Nullable)callback __attribute__((swift_name("setOnMessageEventWithPayloadListener(callback:)")));
	[Export ("setOnMessageEventWithPayloadListener:")]
	void SetOnMessageEventWithPayloadListener ([NullAllowed] MessageEventWithPayloadCompletionCallback callback);

	// -(void)listWebhooksWithMax:(NSNumber * _Nullable)max completionHandler:(ListWebhooksCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("listWebhooks(max:completionHandler:)")));
	[Export ("listWebhooksWithMax:completionHandler:")]
	void ListWebhooksWithMax ([NullAllowed] NSNumber max, ListWebhooksCompletionFuncCallback completionHandler);

	// -(void)getWebhook:(NSString * _Nonnull)webhookId completionHandler:(GetWebhookCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("getWebhook(webhookId:completionHandler:)")));
	[Export ("getWebhook:completionHandler:")]
	void GetWebhook (string webhookId, GetWebhookCompletionFuncCallback completionHandler);

	// -(void)createWebhook:(NSString * _Nonnull)name targetUrl:(NSString * _Nonnull)targetUrl resource:(NSString * _Nonnull)resource event:(NSString * _Nonnull)event filter:(NSString * _Nullable)filter secret:(NSString * _Nullable)secret completionHandler:(CreateWebhookCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("createWebhook(name:targetUrl:resource:event:filter:secret:completionHandler:)")));
	[Export ("createWebhook:targetUrl:resource:event:filter:secret:completionHandler:")]
	void CreateWebhook (string name, string targetUrl, string resource, string @event, [NullAllowed] string filter, [NullAllowed] string secret, CreateWebhookCompletionFuncCallback completionHandler);

	// -(void)updateWebhook:(NSString * _Nonnull)webhookId name:(NSString * _Nonnull)name targetUrl:(NSString * _Nonnull)targetUrl secret:(NSString * _Nullable)secret status:(NSString * _Nullable)status completionHandler:(UpdateWebhookCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("updateWebhook(webhookId:name:targetUrl:secret:status:completionHandler:)")));
	[Export ("updateWebhook:name:targetUrl:secret:status:completionHandler:")]
	void UpdateWebhook (string webhookId, string name, string targetUrl, [NullAllowed] string secret, [NullAllowed] string status, UpdateWebhookCompletionFuncCallback completionHandler);

	// -(void)deleteWebhook:(NSString * _Nonnull)webhookId completionHandler:(DeleteWebhookCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("deleteWebhook(webhookId:completionHandler:)")));
	[Export ("deleteWebhook:completionHandler:")]
	void DeleteWebhook (string webhookId, DeleteWebhookCompletionFuncCallback completionHandler);

	// -(NSString * _Nonnull)getServiceUrl:(enum CHServiceUrlType)serviceUrlType __attribute__((swift_name("getServiceUrl(serviceUrlType:)")));
	[Export ("getServiceUrl:")]
	string GetServiceUrl (CHServiceUrlType serviceUrlType);

	// -(NSString * _Nullable)pathTologFilesAsZip;
	[NullAllowed, Export ("pathTologFilesAsZip")]
	[Verify (MethodToProperty)]
	string PathTologFilesAsZip { get; }

	// -(void)base64EncodeResource:(enum CHResourceType)resourceType resource:(NSString * _Nonnull)resource completionHandler:(Base64EncodeCompletionFuncCallback _Nonnull)completionHandler __attribute__((swift_name("base64EncodeResource(resourceType:resource:completionHandler:)")));
	[Export ("base64EncodeResource:resource:completionHandler:")]
	void Base64EncodeResource (CHResourceType resourceType, string resource, Base64EncodeCompletionFuncCallback completionHandler);

	// -(CHResource * _Nonnull)base64DecodeResource:(NSString * _Nonnull)encodedResource __attribute__((swift_name("base64DecodeResource(encodedResource:)")));
	[Export ("base64DecodeResource:")]
	CHResource Base64DecodeResource (string encodedResource);
}

// @interface SparkVideoLayer : UIView
[BaseType (typeof(UIView))]
interface SparkVideoLayer
{
	// -(UIView *)getRenderView;
	[Export ("getRenderView")]
	[Verify (MethodToProperty)]
	UIView RenderView { get; }

	// -(void)allowDrawFrame:(_Bool)bAllow;
	[Export ("allowDrawFrame:")]
	void AllowDrawFrame (bool bAllow);

	// -(void)useVideoRenderType:(VideoRenderType)type;
	[Export ("useVideoRenderType:")]
	void UseVideoRenderType (VideoRenderType type);

	// -(void)useCustomRenderer:(_Bool)value;
	[Export ("useCustomRenderer:")]
	void UseCustomRenderer (bool value);
}

// @protocol BuildInfoProtocol
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol (Name = "_TtP8WebexSDK17BuildInfoProtocol_")]
interface BuildInfoProtocol
{
	// @required @property (readonly, nonatomic) BOOL isUnitTestBuild;
	[Abstract]
	[Export ("isUnitTestBuild")]
	bool IsUnitTestBuild { get; }

	// @required @property (readonly, nonatomic) BOOL isUITestBuild;
	[Abstract]
	[Export ("isUITestBuild")]
	bool IsUITestBuild { get; }

	// @required @property (readonly, nonatomic) BOOL isDebugBuild;
	[Abstract]
	[Export ("isDebugBuild")]
	bool IsDebugBuild { get; }

	// @required @property (readonly, nonatomic) BOOL isDevBuild;
	[Abstract]
	[Export ("isDevBuild")]
	bool IsDevBuild { get; }

	// @required @property (readonly, nonatomic) BOOL isAppStoreBuild;
	[Abstract]
	[Export ("isAppStoreBuild")]
	bool IsAppStoreBuild { get; }

	// @required @property (readonly, nonatomic) BOOL isTestFlightBuild;
	[Abstract]
	[Export ("isTestFlightBuild")]
	bool IsTestFlightBuild { get; }

	// @required @property (readonly, nonatomic) BOOL isInHouseBuild;
	[Abstract]
	[Export ("isInHouseBuild")]
	bool IsInHouseBuild { get; }

	// @required @property (readonly, nonatomic) BOOL isDistributionBuild;
	[Abstract]
	[Export ("isDistributionBuild")]
	bool IsDistributionBuild { get; }

	// @required @property (readonly, nonatomic) BOOL isSqbuDevBundleId;
	[Abstract]
	[Export ("isSqbuDevBundleId")]
	bool IsSqbuDevBundleId { get; }

	// @required @property (readonly, copy, nonatomic) NSString * _Nonnull gitRevision;
	[Abstract]
	[Export ("gitRevision")]
	string GitRevision { get; }

	// @required @property (readonly, copy, nonatomic) NSString * _Nonnull groupIdentifier;
	[Abstract]
	[Export ("groupIdentifier")]
	string GroupIdentifier { get; }

	// @required @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull universalLinkURLs;
	[Abstract]
	[Export ("universalLinkURLs", ArgumentSemantic.Copy)]
	string[] UniversalLinkURLs { get; }

	// @required @property (readonly, copy, nonatomic) NSString * _Nonnull onBoardingDomain;
	[Abstract]
	[Export ("onBoardingDomain")]
	string OnBoardingDomain { get; }

	// @required @property (readonly, nonatomic) BOOL supportsScreenShare;
	[Abstract]
	[Export ("supportsScreenShare")]
	bool SupportsScreenShare { get; }

	// @required @property (readonly, copy, nonatomic) NSString * _Nonnull version;
	[Abstract]
	[Export ("version")]
	string Version { get; }

	// @required @property (readonly, copy, nonatomic) NSString * _Nonnull prettyVersion;
	[Abstract]
	[Export ("prettyVersion")]
	string PrettyVersion { get; }

	// @required @property (readonly, copy, nonatomic) NSString * _Nonnull releaseVersion;
	[Abstract]
	[Export ("releaseVersion")]
	string ReleaseVersion { get; }

	// @required @property (readonly, copy, nonatomic) NSString * _Nonnull buildVersion;
	[Abstract]
	[Export ("buildVersion")]
	string BuildVersion { get; }
}

// @interface CHCall : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK6CHCall")]
[DisableDefaultCtor]
interface CHCall
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull callId;
	[Export ("callId")]
	string CallId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull conversationId;
	[Export ("conversationId")]
	string ConversationId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull meetingId;
	[Export ("meetingId")]
	string MeetingId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull title;
	[Export ("title")]
	string Title { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull selfId;
	[Export ("selfId")]
	string SelfId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull screenSharingLabel;
	[Export ("screenSharingLabel")]
	string ScreenSharingLabel { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull locusUrl;
	[Export ("locusUrl")]
	string LocusUrl { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull startTime;
	[Export ("startTime", ArgumentSemantic.Copy)]
	NSDate StartTime { get; }

	// @property (readonly, nonatomic) BOOL isAudioOnly;
	[Export ("isAudioOnly")]
	bool IsAudioOnly { get; }

	// @property (readonly, nonatomic) BOOL isEccCall;
	[Export ("isEccCall")]
	bool IsEccCall { get; }

	// @property (readonly, nonatomic) BOOL isFrontCamera;
	[Export ("isFrontCamera")]
	bool IsFrontCamera { get; }

	// @property (readonly, nonatomic) BOOL isOnHold;
	[Export ("isOnHold")]
	bool IsOnHold { get; }

	// @property (readonly, nonatomic) BOOL canShare;
	[Export ("canShare")]
	bool CanShare { get; }

	// @property (readonly, nonatomic) BOOL isActive;
	[Export ("isActive")]
	bool IsActive { get; }

	// @property (readonly, nonatomic) BOOL isSendingAudio;
	[Export ("isSendingAudio")]
	bool IsSendingAudio { get; }

	// @property (readonly, nonatomic) BOOL isRemoteSendingAudio;
	[Export ("isRemoteSendingAudio")]
	bool IsRemoteSendingAudio { get; }

	// @property (readonly, nonatomic) BOOL isReceivingAudio;
	[Export ("isReceivingAudio")]
	bool IsReceivingAudio { get; }

	// @property (readonly, nonatomic) BOOL isSendingVideo;
	[Export ("isSendingVideo")]
	bool IsSendingVideo { get; }

	// @property (readonly, nonatomic) BOOL isRemoteSendingVideo;
	[Export ("isRemoteSendingVideo")]
	bool IsRemoteSendingVideo { get; }

	// @property (readonly, nonatomic) BOOL isReceivingVideo;
	[Export ("isReceivingVideo")]
	bool IsReceivingVideo { get; }

	// @property (readonly, nonatomic) BOOL isSendingSharing;
	[Export ("isSendingSharing")]
	bool IsSendingSharing { get; }

	// @property (readonly, nonatomic) BOOL isRemoteSendingSharing;
	[Export ("isRemoteSendingSharing")]
	bool IsRemoteSendingSharing { get; }

	// @property (readonly, nonatomic) BOOL isReceivingSharing;
	[Export ("isReceivingSharing")]
	bool IsReceivingSharing { get; }

	// @property (readonly, nonatomic) BOOL isJoinedOnThisDevice;
	[Export ("isJoinedOnThisDevice")]
	bool IsJoinedOnThisDevice { get; }

	// @property (readonly, nonatomic) BOOL isJoinedOnAnotherDevice;
	[Export ("isJoinedOnAnotherDevice")]
	bool IsJoinedOnAnotherDevice { get; }

	// @property (readonly, nonatomic) BOOL showDtmfDigits;
	[Export ("showDtmfDigits")]
	bool ShowDtmfDigits { get; }

	// @property (readonly, nonatomic) BOOL canShowDTMFKeypad;
	[Export ("canShowDTMFKeypad")]
	bool CanShowDTMFKeypad { get; }

	// @property (readonly, nonatomic) BOOL isOneToOneCall;
	[Export ("isOneToOneCall")]
	bool IsOneToOneCall { get; }

	// @property (readonly, nonatomic) BOOL isMeeting;
	[Export ("isMeeting")]
	bool IsMeeting { get; }

	// @property (readonly, nonatomic) BOOL isPmr;
	[Export ("isPmr")]
	bool IsPmr { get; }

	// @property (readonly, nonatomic) BOOL isSparkSpaceMeeting;
	[Export ("isSparkSpaceMeeting")]
	bool IsSparkSpaceMeeting { get; }

	// @property (readonly, nonatomic) BOOL hasAnyoneJoined;
	[Export ("hasAnyoneJoined")]
	bool HasAnyoneJoined { get; }

	// @property (readonly, nonatomic) BOOL isSelfCreator;
	[Export ("isSelfCreator")]
	bool IsSelfCreator { get; }

	// @property (readonly, nonatomic) BOOL isScheduledMeeting;
	[Export ("isScheduledMeeting")]
	bool IsScheduledMeeting { get; }

	// @property (readonly, nonatomic) BOOL isWXAEnabled;
	[Export ("isWXAEnabled")]
	bool IsWXAEnabled { get; }

	// @property (readonly, nonatomic) BOOL canControlWXA;
	[Export ("canControlWXA")]
	bool CanControlWXA { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull maxNumberAuxStreams;
	[Export ("maxNumberAuxStreams", ArgumentSemantic.Strong)]
	NSNumber MaxNumberAuxStreams { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull availableAuxStreamCount;
	[Export ("availableAuxStreamCount", ArgumentSemantic.Strong)]
	NSNumber AvailableAuxStreamCount { get; }

	// @property (readonly, copy, nonatomic) NSArray<CHCallMembership *> * _Nonnull memberships;
	[Export ("memberships", ArgumentSemantic.Copy)]
	CHCallMembership[] Memberships { get; }

	// @property (readonly, copy, nonatomic) NSArray<CHMediaStream *> * _Nonnull mediaAuxStreams;
	[Export ("mediaAuxStreams", ArgumentSemantic.Copy)]
	CHMediaStream[] MediaAuxStreams { get; }

	// @property (readonly, nonatomic, strong) CHVideoFrameSize * _Nonnull localVideoFrameSize;
	[Export ("localVideoFrameSize", ArgumentSemantic.Strong)]
	CHVideoFrameSize LocalVideoFrameSize { get; }

	// @property (readonly, nonatomic, strong) CHVideoFrameSize * _Nonnull remoteVideoFrameSize;
	[Export ("remoteVideoFrameSize", ArgumentSemantic.Strong)]
	CHVideoFrameSize RemoteVideoFrameSize { get; }

	// @property (readonly, nonatomic, strong) CHVideoFrameSize * _Nonnull localSharingFrameSize;
	[Export ("localSharingFrameSize", ArgumentSemantic.Strong)]
	CHVideoFrameSize LocalSharingFrameSize { get; }

	// @property (readonly, nonatomic, strong) CHVideoFrameSize * _Nonnull remoteSharingFrameSize;
	[Export ("remoteSharingFrameSize", ArgumentSemantic.Strong)]
	CHVideoFrameSize RemoteSharingFrameSize { get; }

	// @property (readonly, nonatomic) CHCallDirection direction;
	[Export ("direction")]
	CHCallDirection Direction { get; }

	// @property (readonly, nonatomic) CHMeetingLockedErrorCodes meetingLockedErrorCodes;
	[Export ("meetingLockedErrorCodes")]
	CHMeetingLockedErrorCodes MeetingLockedErrorCodes { get; }

	// -(instancetype _Nonnull)initWithCallId:(NSString * _Nonnull)callId conversationId:(NSString * _Nonnull)conversationId meetingId:(NSString * _Nonnull)meetingId title:(NSString * _Nonnull)title selfId:(NSString * _Nonnull)selfId screenSharingLabel:(NSString * _Nonnull)screenSharingLabel locusUrl:(NSString * _Nonnull)locusUrl startTime:(NSDate * _Nonnull)startTime isAudioOnly:(BOOL)isAudioOnly isEccCall:(BOOL)isEccCall isFrontCamera:(BOOL)isFrontCamera isOnHold:(BOOL)isOnHold canShare:(BOOL)canShare isActive:(BOOL)isActive isSendingAudio:(BOOL)isSendingAudio isRemoteSendingAudio:(BOOL)isRemoteSendingAudio isReceivingAudio:(BOOL)isReceivingAudio isSendingVideo:(BOOL)isSendingVideo isRemoteSendingVideo:(BOOL)isRemoteSendingVideo isReceivingVideo:(BOOL)isReceivingVideo isSendingSharing:(BOOL)isSendingSharing isRemoteSendingSharing:(BOOL)isRemoteSendingSharing isReceivingSharing:(BOOL)isReceivingSharing isJoinedOnThisDevice:(BOOL)isJoinedOnThisDevice isJoinedOnAnotherDevice:(BOOL)isJoinedOnAnotherDevice showDtmfDigits:(BOOL)showDtmfDigits canShowDTMFKeypad:(BOOL)canShowDTMFKeypad isOneToOneCall:(BOOL)isOneToOneCall isMeeting:(BOOL)isMeeting isPmr:(BOOL)isPmr isSparkSpaceMeeting:(BOOL)isSparkSpaceMeeting hasAnyoneJoined:(BOOL)hasAnyoneJoined isSelfCreator:(BOOL)isSelfCreator isScheduledMeeting:(BOOL)isScheduledMeeting isWXAEnabled:(BOOL)isWXAEnabled canControlWXA:(BOOL)canControlWXA maxNumberAuxStreams:(NSNumber * _Nonnull)maxNumberAuxStreams availableAuxStreamCount:(NSNumber * _Nonnull)availableAuxStreamCount memberships:(NSArray<CHCallMembership *> * _Nonnull)memberships mediaAuxStreams:(NSArray<CHMediaStream *> * _Nonnull)mediaAuxStreams localVideoFrameSize:(CHVideoFrameSize * _Nonnull)localVideoFrameSize remoteVideoFrameSize:(CHVideoFrameSize * _Nonnull)remoteVideoFrameSize localSharingFrameSize:(CHVideoFrameSize * _Nonnull)localSharingFrameSize remoteSharingFrameSize:(CHVideoFrameSize * _Nonnull)remoteSharingFrameSize direction:(CHCallDirection)direction meetingLockedErrorCodes:(CHMeetingLockedErrorCodes)meetingLockedErrorCodes __attribute__((objc_designated_initializer));
	[Export ("initWithCallId:conversationId:meetingId:title:selfId:screenSharingLabel:locusUrl:startTime:isAudioOnly:isEccCall:isFrontCamera:isOnHold:canShare:isActive:isSendingAudio:isRemoteSendingAudio:isReceivingAudio:isSendingVideo:isRemoteSendingVideo:isReceivingVideo:isSendingSharing:isRemoteSendingSharing:isReceivingSharing:isJoinedOnThisDevice:isJoinedOnAnotherDevice:showDtmfDigits:canShowDTMFKeypad:isOneToOneCall:isMeeting:isPmr:isSparkSpaceMeeting:hasAnyoneJoined:isSelfCreator:isScheduledMeeting:isWXAEnabled:canControlWXA:maxNumberAuxStreams:availableAuxStreamCount:memberships:mediaAuxStreams:localVideoFrameSize:remoteVideoFrameSize:localSharingFrameSize:remoteSharingFrameSize:direction:meetingLockedErrorCodes:")]
	[DesignatedInitializer]
	IntPtr Constructor (string callId, string conversationId, string meetingId, string title, string selfId, string screenSharingLabel, string locusUrl, NSDate startTime, bool isAudioOnly, bool isEccCall, bool isFrontCamera, bool isOnHold, bool canShare, bool isActive, bool isSendingAudio, bool isRemoteSendingAudio, bool isReceivingAudio, bool isSendingVideo, bool isRemoteSendingVideo, bool isReceivingVideo, bool isSendingSharing, bool isRemoteSendingSharing, bool isReceivingSharing, bool isJoinedOnThisDevice, bool isJoinedOnAnotherDevice, bool showDtmfDigits, bool canShowDTMFKeypad, bool isOneToOneCall, bool isMeeting, bool isPmr, bool isSparkSpaceMeeting, bool hasAnyoneJoined, bool isSelfCreator, bool isScheduledMeeting, bool isWXAEnabled, bool canControlWXA, NSNumber maxNumberAuxStreams, NSNumber availableAuxStreamCount, CHCallMembership[] memberships, CHMediaStream[] mediaAuxStreams, CHVideoFrameSize localVideoFrameSize, CHVideoFrameSize remoteVideoFrameSize, CHVideoFrameSize localSharingFrameSize, CHVideoFrameSize remoteSharingFrameSize, CHCallDirection direction, CHMeetingLockedErrorCodes meetingLockedErrorCodes);
}

// @interface CHCallHistory : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK13CHCallHistory")]
[DisableDefaultCtor]
interface CHCallHistory
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull conversationId;
	[Export ("conversationId")]
	string ConversationId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull title;
	[Export ("title")]
	string Title { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull created;
	[Export ("created", ArgumentSemantic.Copy)]
	NSDate Created { get; }

	// -(instancetype _Nonnull)initWithConversationId:(NSString * _Nonnull)conversationId title:(NSString * _Nonnull)title created:(NSDate * _Nonnull)created __attribute__((objc_designated_initializer));
	[Export ("initWithConversationId:title:created:")]
	[DesignatedInitializer]
	IntPtr Constructor (string conversationId, string title, NSDate created);
}

// @interface CHCallMembership : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK16CHCallMembership")]
[DisableDefaultCtor]
interface CHCallMembership
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
	[Export ("name")]
	string Name { get; }

	// @property (readonly, nonatomic) BOOL isInitiator;
	[Export ("isInitiator")]
	bool IsInitiator { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull personId;
	[Export ("personId")]
	string PersonId { get; }

	// @property (readonly, nonatomic) CHCallMembershipState state;
	[Export ("state")]
	CHCallMembershipState State { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull sipUrl;
	[Export ("sipUrl")]
	string SipUrl { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull phoneNumber;
	[Export ("phoneNumber")]
	string PhoneNumber { get; }

	// @property (readonly, nonatomic) BOOL isSelf;
	[Export ("isSelf")]
	bool IsSelf { get; }

	// @property (readonly, nonatomic) BOOL isSendingVideo;
	[Export ("isSendingVideo")]
	bool IsSendingVideo { get; }

	// @property (readonly, nonatomic) BOOL isSendingAudio;
	[Export ("isSendingAudio")]
	bool IsSendingAudio { get; }

	// @property (readonly, nonatomic) BOOL isSendingSharing;
	[Export ("isSendingSharing")]
	bool IsSendingSharing { get; }

	// @property (readonly, nonatomic) BOOL isActiveSpeaker;
	[Export ("isActiveSpeaker")]
	bool IsActiveSpeaker { get; }

	// @property (readonly, nonatomic) BOOL isAudioMutedControlled;
	[Export ("isAudioMutedControlled")]
	bool IsAudioMutedControlled { get; }

	// @property (readonly, nonatomic) BOOL isUserType;
	[Export ("isUserType")]
	bool IsUserType { get; }

	// @property (readonly, nonatomic) BOOL isResourceRoomType;
	[Export ("isResourceRoomType")]
	bool IsResourceRoomType { get; }

	// @property (readonly, nonatomic) BOOL isExternal;
	[Export ("isExternal")]
	bool IsExternal { get; }

	// @property (readonly, nonatomic) BOOL declinedOrLeft;
	[Export ("declinedOrLeft")]
	bool DeclinedOrLeft { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull audioModifiedBy;
	[Export ("audioModifiedBy")]
	string AudioModifiedBy { get; }

	// @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull csis;
	[Export ("csis", ArgumentSemantic.Copy)]
	NSNumber[] Csis { get; }

	// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name isInitiator:(BOOL)isInitiator personId:(NSString * _Nonnull)personId state:(CHCallMembershipState)state sipUrl:(NSString * _Nonnull)sipUrl phoneNumber:(NSString * _Nonnull)phoneNumber isSelf:(BOOL)isSelf isSendingVideo:(BOOL)isSendingVideo isSendingAudio:(BOOL)isSendingAudio isSendingSharing:(BOOL)isSendingSharing isActiveSpeaker:(BOOL)isActiveSpeaker isAudioMutedControlled:(BOOL)isAudioMutedControlled isUserType:(BOOL)isUserType isResourceRoomType:(BOOL)isResourceRoomType isExternal:(BOOL)isExternal declinedOrLeft:(BOOL)declinedOrLeft audioModifiedBy:(NSString * _Nonnull)audioModifiedBy csis:(NSArray<NSNumber *> * _Nonnull)csis __attribute__((objc_designated_initializer));
	[Export ("initWithName:isInitiator:personId:state:sipUrl:phoneNumber:isSelf:isSendingVideo:isSendingAudio:isSendingSharing:isActiveSpeaker:isAudioMutedControlled:isUserType:isResourceRoomType:isExternal:declinedOrLeft:audioModifiedBy:csis:")]
	[DesignatedInitializer]
	IntPtr Constructor (string name, bool isInitiator, string personId, CHCallMembershipState state, string sipUrl, string phoneNumber, bool isSelf, bool isSendingVideo, bool isSendingAudio, bool isSendingSharing, bool isActiveSpeaker, bool isAudioMutedControlled, bool isUserType, bool isResourceRoomType, bool isExternal, bool declinedOrLeft, string audioModifiedBy, NSNumber[] csis);
}

// @interface CHCameraExposureDuration : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK24CHCameraExposureDuration")]
[DisableDefaultCtor]
interface CHCameraExposureDuration
{
	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull min;
	[Export ("min", ArgumentSemantic.Strong)]
	NSNumber Min { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull max;
	[Export ("max", ArgumentSemantic.Strong)]
	NSNumber Max { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull current;
	[Export ("current", ArgumentSemantic.Strong)]
	NSNumber Current { get; }

	// -(instancetype _Nonnull)initWithMin:(NSNumber * _Nonnull)min max:(NSNumber * _Nonnull)max current:(NSNumber * _Nonnull)current __attribute__((objc_designated_initializer));
	[Export ("initWithMin:max:current:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSNumber min, NSNumber max, NSNumber current);
}

// @interface CHCameraExposureISO : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK19CHCameraExposureISO")]
[DisableDefaultCtor]
interface CHCameraExposureISO
{
	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull min;
	[Export ("min", ArgumentSemantic.Strong)]
	NSNumber Min { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull max;
	[Export ("max", ArgumentSemantic.Strong)]
	NSNumber Max { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull current;
	[Export ("current", ArgumentSemantic.Strong)]
	NSNumber Current { get; }

	// -(instancetype _Nonnull)initWithMin:(NSNumber * _Nonnull)min max:(NSNumber * _Nonnull)max current:(NSNumber * _Nonnull)current __attribute__((objc_designated_initializer));
	[Export ("initWithMin:max:current:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSNumber min, NSNumber max, NSNumber current);
}

// @interface CHCameraExposureTargetBias : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK26CHCameraExposureTargetBias")]
[DisableDefaultCtor]
interface CHCameraExposureTargetBias
{
	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull min;
	[Export ("min", ArgumentSemantic.Strong)]
	NSNumber Min { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull max;
	[Export ("max", ArgumentSemantic.Strong)]
	NSNumber Max { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull current;
	[Export ("current", ArgumentSemantic.Strong)]
	NSNumber Current { get; }

	// -(instancetype _Nonnull)initWithMin:(NSNumber * _Nonnull)min max:(NSNumber * _Nonnull)max current:(NSNumber * _Nonnull)current __attribute__((objc_designated_initializer));
	[Export ("initWithMin:max:current:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSNumber min, NSNumber max, NSNumber current);
}

// @interface CHEmailAddress : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK14CHEmailAddress")]
[DisableDefaultCtor]
interface CHEmailAddress
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull address;
	[Export ("address")]
	string Address { get; }

	// -(instancetype _Nonnull)initWithAddress:(NSString * _Nonnull)address __attribute__((objc_designated_initializer));
	[Export ("initWithAddress:")]
	[DesignatedInitializer]
	IntPtr Constructor (string address);
}

// @interface CHInvitee : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK9CHInvitee")]
[DisableDefaultCtor]
interface CHInvitee
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull contactId;
	[Export ("contactId")]
	string ContactId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull displayName;
	[Export ("displayName")]
	string DisplayName { get; }

	// @property (readonly, nonatomic) CHInviteeResponse response;
	[Export ("response")]
	CHInviteeResponse Response { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull externalDomain;
	[Export ("externalDomain")]
	string ExternalDomain { get; }

	// -(instancetype _Nonnull)initWithContactId:(NSString * _Nonnull)contactId displayName:(NSString * _Nonnull)displayName response:(CHInviteeResponse)response externalDomain:(NSString * _Nonnull)externalDomain __attribute__((objc_designated_initializer));
	[Export ("initWithContactId:displayName:response:externalDomain:")]
	[DesignatedInitializer]
	IntPtr Constructor (string contactId, string displayName, CHInviteeResponse response, string externalDomain);
}

// @interface CHLocalFile : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK11CHLocalFile")]
[DisableDefaultCtor]
interface CHLocalFile
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull displayName;
	[Export ("displayName")]
	string DisplayName { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull mimeType;
	[Export ("mimeType")]
	string MimeType { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull url;
	[Export ("url")]
	string Url { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull thumbnailWidth;
	[Export ("thumbnailWidth", ArgumentSemantic.Strong)]
	NSNumber ThumbnailWidth { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull thumbnailHeight;
	[Export ("thumbnailHeight", ArgumentSemantic.Strong)]
	NSNumber ThumbnailHeight { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull thumbnailMimeType;
	[Export ("thumbnailMimeType")]
	string ThumbnailMimeType { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull thumbnailUrl;
	[Export ("thumbnailUrl")]
	string ThumbnailUrl { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull thumbnailSize;
	[Export ("thumbnailSize", ArgumentSemantic.Strong)]
	NSNumber ThumbnailSize { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull fullImageSize;
	[Export ("fullImageSize", ArgumentSemantic.Strong)]
	NSNumber FullImageSize { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull fullImageWidth;
	[Export ("fullImageWidth", ArgumentSemantic.Strong)]
	NSNumber FullImageWidth { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull fullImageHeight;
	[Export ("fullImageHeight", ArgumentSemantic.Strong)]
	NSNumber FullImageHeight { get; }

	// -(instancetype _Nonnull)initWithDisplayName:(NSString * _Nonnull)displayName mimeType:(NSString * _Nonnull)mimeType url:(NSString * _Nonnull)url thumbnailWidth:(NSNumber * _Nonnull)thumbnailWidth thumbnailHeight:(NSNumber * _Nonnull)thumbnailHeight thumbnailMimeType:(NSString * _Nonnull)thumbnailMimeType thumbnailUrl:(NSString * _Nonnull)thumbnailUrl thumbnailSize:(NSNumber * _Nonnull)thumbnailSize fullImageSize:(NSNumber * _Nonnull)fullImageSize fullImageWidth:(NSNumber * _Nonnull)fullImageWidth fullImageHeight:(NSNumber * _Nonnull)fullImageHeight __attribute__((objc_designated_initializer));
	[Export ("initWithDisplayName:mimeType:url:thumbnailWidth:thumbnailHeight:thumbnailMimeType:thumbnailUrl:thumbnailSize:fullImageSize:fullImageWidth:fullImageHeight:")]
	[DesignatedInitializer]
	IntPtr Constructor (string displayName, string mimeType, string url, NSNumber thumbnailWidth, NSNumber thumbnailHeight, string thumbnailMimeType, string thumbnailUrl, NSNumber thumbnailSize, NSNumber fullImageSize, NSNumber fullImageWidth, NSNumber fullImageHeight);
}

// @interface CHMediaStream : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK13CHMediaStream")]
[DisableDefaultCtor]
interface CHMediaStream
{
	// @property (readonly, nonatomic) BOOL showMediaStream;
	[Export ("showMediaStream")]
	bool ShowMediaStream { get; }

	// @property (readonly, nonatomic) BOOL isVideoAvailable;
	[Export ("isVideoAvailable")]
	bool IsVideoAvailable { get; }

	// @property (readonly, nonatomic) BOOL hasVideo;
	[Export ("hasVideo")]
	bool HasVideo { get; }

	// @property (readonly, nonatomic) BOOL isActiveSpeaker;
	[Export ("isActiveSpeaker")]
	bool IsActiveSpeaker { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull height;
	[Export ("height", ArgumentSemantic.Strong)]
	NSNumber Height { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull width;
	[Export ("width", ArgumentSemantic.Strong)]
	NSNumber Width { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull trackCSI;
	[Export ("trackCSI", ArgumentSemantic.Strong)]
	NSNumber TrackCSI { get; }

	// @property (readonly, nonatomic, strong) CHCallMembership * _Nonnull membership;
	[Export ("membership", ArgumentSemantic.Strong)]
	CHCallMembership Membership { get; }

	// @property (readonly, nonatomic) CHMediaStreamType streamType;
	[Export ("streamType")]
	CHMediaStreamType StreamType { get; }

	// -(instancetype _Nonnull)initWithShowMediaStream:(BOOL)showMediaStream isVideoAvailable:(BOOL)isVideoAvailable hasVideo:(BOOL)hasVideo isActiveSpeaker:(BOOL)isActiveSpeaker height:(NSNumber * _Nonnull)height width:(NSNumber * _Nonnull)width trackCSI:(NSNumber * _Nonnull)trackCSI membership:(CHCallMembership * _Nonnull)membership streamType:(CHMediaStreamType)streamType __attribute__((objc_designated_initializer));
	[Export ("initWithShowMediaStream:isVideoAvailable:hasVideo:isActiveSpeaker:height:width:trackCSI:membership:streamType:")]
	[DesignatedInitializer]
	IntPtr Constructor (bool showMediaStream, bool isVideoAvailable, bool hasVideo, bool isActiveSpeaker, NSNumber height, NSNumber width, NSNumber trackCSI, CHCallMembership membership, CHMediaStreamType streamType);
}

// @interface CHMeeting : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK9CHMeeting")]
[DisableDefaultCtor]
interface CHMeeting
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull meetingId;
	[Export ("meetingId")]
	string MeetingId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull seriesId;
	[Export ("seriesId")]
	string SeriesId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull organizer;
	[Export ("organizer")]
	string Organizer { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull organizerName;
	[Export ("organizerName")]
	string OrganizerName { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull startTime;
	[Export ("startTime", ArgumentSemantic.Copy)]
	NSDate StartTime { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull endTime;
	[Export ("endTime", ArgumentSemantic.Copy)]
	NSDate EndTime { get; }

	// @property (readonly, nonatomic) BOOL isAllDay;
	[Export ("isAllDay")]
	bool IsAllDay { get; }

	// @property (readonly, nonatomic) BOOL isRecurring;
	[Export ("isRecurring")]
	bool IsRecurring { get; }

	// @property (readonly, nonatomic) BOOL canJoin;
	[Export ("canJoin")]
	bool CanJoin { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull link;
	[Export ("link")]
	string Link { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull sipUrl;
	[Export ("sipUrl")]
	string SipUrl { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull subject;
	[Export ("subject")]
	string Subject { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull sDescription;
	[Export ("sDescription")]
	string SDescription { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull location;
	[Export ("location")]
	string Location { get; }

	// @property (readonly, copy, nonatomic) NSArray<CHInvitee *> * _Nonnull invitees;
	[Export ("invitees", ArgumentSemantic.Copy)]
	CHInvitee[] Invitees { get; }

	// -(instancetype _Nonnull)initWithMeetingId:(NSString * _Nonnull)meetingId seriesId:(NSString * _Nonnull)seriesId organizer:(NSString * _Nonnull)organizer organizerName:(NSString * _Nonnull)organizerName startTime:(NSDate * _Nonnull)startTime endTime:(NSDate * _Nonnull)endTime isAllDay:(BOOL)isAllDay isRecurring:(BOOL)isRecurring canJoin:(BOOL)canJoin link:(NSString * _Nonnull)link sipUrl:(NSString * _Nonnull)sipUrl subject:(NSString * _Nonnull)subject sDescription:(NSString * _Nonnull)sDescription location:(NSString * _Nonnull)location invitees:(NSArray<CHInvitee *> * _Nonnull)invitees __attribute__((objc_designated_initializer));
	[Export ("initWithMeetingId:seriesId:organizer:organizerName:startTime:endTime:isAllDay:isRecurring:canJoin:link:sipUrl:subject:sDescription:location:invitees:")]
	[DesignatedInitializer]
	IntPtr Constructor (string meetingId, string seriesId, string organizer, string organizerName, NSDate startTime, NSDate endTime, bool isAllDay, bool isRecurring, bool canJoin, string link, string sipUrl, string subject, string sDescription, string location, CHInvitee[] invitees);
}

// @interface CHMeetingInfo : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK13CHMeetingInfo")]
[DisableDefaultCtor]
interface CHMeetingInfo
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull organizer;
	[Export ("organizer")]
	string Organizer { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull meetingId;
	[Export ("meetingId")]
	string MeetingId { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull startTime;
	[Export ("startTime", ArgumentSemantic.Copy)]
	NSDate StartTime { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull endTime;
	[Export ("endTime", ArgumentSemantic.Copy)]
	NSDate EndTime { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull link;
	[Export ("link")]
	string Link { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull subject;
	[Export ("subject")]
	string Subject { get; }

	// -(instancetype _Nonnull)initWithOrganizer:(NSString * _Nonnull)organizer meetingId:(NSString * _Nonnull)meetingId startTime:(NSDate * _Nonnull)startTime endTime:(NSDate * _Nonnull)endTime link:(NSString * _Nonnull)link subject:(NSString * _Nonnull)subject __attribute__((objc_designated_initializer));
	[Export ("initWithOrganizer:meetingId:startTime:endTime:link:subject:")]
	[DesignatedInitializer]
	IntPtr Constructor (string organizer, string meetingId, NSDate startTime, NSDate endTime, string link, string subject);
}

// @interface CHMembership : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK12CHMembership")]
[DisableDefaultCtor]
interface CHMembership
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull membershipId;
	[Export ("membershipId")]
	string MembershipId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull personId;
	[Export ("personId")]
	string PersonId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull emailAddress;
	[Export ("emailAddress")]
	string EmailAddress { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull spaceId;
	[Export ("spaceId")]
	string SpaceId { get; }

	// @property (readonly, nonatomic) BOOL isModerator;
	[Export ("isModerator")]
	bool IsModerator { get; }

	// @property (readonly, nonatomic) BOOL isMonitor;
	[Export ("isMonitor")]
	bool IsMonitor { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull createdDate;
	[Export ("createdDate", ArgumentSemantic.Copy)]
	NSDate CreatedDate { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull personDisplayName;
	[Export ("personDisplayName")]
	string PersonDisplayName { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull personOrgId;
	[Export ("personOrgId")]
	string PersonOrgId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull personFirstName;
	[Export ("personFirstName")]
	string PersonFirstName { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull personLastName;
	[Export ("personLastName")]
	string PersonLastName { get; }

	// -(instancetype _Nonnull)initWithMembershipId:(NSString * _Nonnull)membershipId personId:(NSString * _Nonnull)personId emailAddress:(NSString * _Nonnull)emailAddress spaceId:(NSString * _Nonnull)spaceId isModerator:(BOOL)isModerator isMonitor:(BOOL)isMonitor createdDate:(NSDate * _Nonnull)createdDate personDisplayName:(NSString * _Nonnull)personDisplayName personOrgId:(NSString * _Nonnull)personOrgId personFirstName:(NSString * _Nonnull)personFirstName personLastName:(NSString * _Nonnull)personLastName __attribute__((objc_designated_initializer));
	[Export ("initWithMembershipId:personId:emailAddress:spaceId:isModerator:isMonitor:createdDate:personDisplayName:personOrgId:personFirstName:personLastName:")]
	[DesignatedInitializer]
	IntPtr Constructor (string membershipId, string personId, string emailAddress, string spaceId, bool isModerator, bool isMonitor, NSDate createdDate, string personDisplayName, string personOrgId, string personFirstName, string personLastName);
}

// @interface CHMembershipId : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK14CHMembershipId")]
[DisableDefaultCtor]
interface CHMembershipId
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull contactId;
	[Export ("contactId")]
	string ContactId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull spaceId;
	[Export ("spaceId")]
	string SpaceId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull delimeter;
	[Export ("delimeter")]
	string Delimeter { get; }

	// -(instancetype _Nonnull)initWithContactId:(NSString * _Nonnull)contactId spaceId:(NSString * _Nonnull)spaceId delimeter:(NSString * _Nonnull)delimeter __attribute__((objc_designated_initializer));
	[Export ("initWithContactId:spaceId:delimeter:")]
	[DesignatedInitializer]
	IntPtr Constructor (string contactId, string spaceId, string delimeter);
}

// @interface CHMembershipReadStatus : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK22CHMembershipReadStatus")]
[DisableDefaultCtor]
interface CHMembershipReadStatus
{
	// @property (readonly, nonatomic, strong) CHMembership * _Nonnull member;
	[Export ("member", ArgumentSemantic.Strong)]
	CHMembership Member { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable lastSeenId;
	[NullAllowed, Export ("lastSeenId")]
	string LastSeenId { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull lastSeenDate;
	[Export ("lastSeenDate", ArgumentSemantic.Copy)]
	NSDate LastSeenDate { get; }

	// -(instancetype _Nonnull)initWithMember:(CHMembership * _Nonnull)member lastSeenId:(NSString * _Nullable)lastSeenId lastSeenDate:(NSDate * _Nonnull)lastSeenDate __attribute__((objc_designated_initializer));
	[Export ("initWithMember:lastSeenId:lastSeenDate:")]
	[DesignatedInitializer]
	IntPtr Constructor (CHMembership member, [NullAllowed] string lastSeenId, NSDate lastSeenDate);
}

// @interface CHMention : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK9CHMention")]
[DisableDefaultCtor]
interface CHMention
{
	// @property (readonly, nonatomic) CHMentionType type;
	[Export ("type")]
	CHMentionType Type { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull contactId;
	[Export ("contactId")]
	string ContactId { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull start;
	[Export ("start", ArgumentSemantic.Strong)]
	NSNumber Start { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull end;
	[Export ("end", ArgumentSemantic.Strong)]
	NSNumber End { get; }

	// -(instancetype _Nonnull)initWithType:(CHMentionType)type contactId:(NSString * _Nonnull)contactId start:(NSNumber * _Nonnull)start end:(NSNumber * _Nonnull)end __attribute__((objc_designated_initializer));
	[Export ("initWithType:contactId:start:end:")]
	[DesignatedInitializer]
	IntPtr Constructor (CHMentionType type, string contactId, NSNumber start, NSNumber end);
}

// @interface CHMessage : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK9CHMessage")]
[DisableDefaultCtor]
interface CHMessage
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull spaceId;
	[Export ("spaceId")]
	string SpaceId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull messageId;
	[Export ("messageId")]
	string MessageId { get; }

	// @property (readonly, nonatomic, strong) CHMessageText * _Nonnull messageBody;
	[Export ("messageBody", ArgumentSemantic.Strong)]
	CHMessageText MessageBody { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull created;
	[Export ("created", ArgumentSemantic.Copy)]
	NSDate Created { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull updated;
	[Export ("updated", ArgumentSemantic.Copy)]
	NSDate Updated { get; }

	// @property (readonly, nonatomic) BOOL isSelfMentioned;
	[Export ("isSelfMentioned")]
	bool IsSelfMentioned { get; }

	// @property (readonly, nonatomic) BOOL isAllMentioned;
	[Export ("isAllMentioned")]
	bool IsAllMentioned { get; }

	// @property (readonly, copy, nonatomic) NSArray<CHMention *> * _Nonnull mentions;
	[Export ("mentions", ArgumentSemantic.Copy)]
	CHMention[] Mentions { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull parentId;
	[Export ("parentId")]
	string ParentId { get; }

	// @property (readonly, nonatomic) BOOL isReply;
	[Export ("isReply")]
	bool IsReply { get; }

	// @property (readonly, nonatomic) BOOL isEdited;
	[Export ("isEdited")]
	bool IsEdited { get; }

	// @property (readonly, nonatomic) BOOL isContentDecrypted;
	[Export ("isContentDecrypted")]
	bool IsContentDecrypted { get; }

	// @property (readonly, nonatomic) CHConversationType conversationType;
	[Export ("conversationType")]
	CHConversationType ConversationType { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull personId;
	[Export ("personId")]
	string PersonId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull personEmail;
	[Export ("personEmail")]
	string PersonEmail { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull personDisplayName;
	[Export ("personDisplayName")]
	string PersonDisplayName { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull toPersonId;
	[Export ("toPersonId")]
	string ToPersonId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull toPersonEmail;
	[Export ("toPersonEmail")]
	string ToPersonEmail { get; }

	// @property (readonly, copy, nonatomic) NSArray<CHRemoteFile *> * _Nonnull attachments;
	[Export ("attachments", ArgumentSemantic.Copy)]
	CHRemoteFile[] Attachments { get; }

	// -(instancetype _Nonnull)initWithSpaceId:(NSString * _Nonnull)spaceId messageId:(NSString * _Nonnull)messageId messageBody:(CHMessageText * _Nonnull)messageBody created:(NSDate * _Nonnull)created updated:(NSDate * _Nonnull)updated isSelfMentioned:(BOOL)isSelfMentioned isAllMentioned:(BOOL)isAllMentioned mentions:(NSArray<CHMention *> * _Nonnull)mentions parentId:(NSString * _Nonnull)parentId isReply:(BOOL)isReply isEdited:(BOOL)isEdited isContentDecrypted:(BOOL)isContentDecrypted conversationType:(CHConversationType)conversationType personId:(NSString * _Nonnull)personId personEmail:(NSString * _Nonnull)personEmail personDisplayName:(NSString * _Nonnull)personDisplayName toPersonId:(NSString * _Nonnull)toPersonId toPersonEmail:(NSString * _Nonnull)toPersonEmail attachments:(NSArray<CHRemoteFile *> * _Nonnull)attachments __attribute__((objc_designated_initializer));
	[Export ("initWithSpaceId:messageId:messageBody:created:updated:isSelfMentioned:isAllMentioned:mentions:parentId:isReply:isEdited:isContentDecrypted:conversationType:personId:personEmail:personDisplayName:toPersonId:toPersonEmail:attachments:")]
	[DesignatedInitializer]
	IntPtr Constructor (string spaceId, string messageId, CHMessageText messageBody, NSDate created, NSDate updated, bool isSelfMentioned, bool isAllMentioned, CHMention[] mentions, string parentId, bool isReply, bool isEdited, bool isContentDecrypted, CHConversationType conversationType, string personId, string personEmail, string personDisplayName, string toPersonId, string toPersonEmail, CHRemoteFile[] attachments);
}

// @interface CHMessageText : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK13CHMessageText")]
[DisableDefaultCtor]
interface CHMessageText
{
	// @property (readonly, copy, nonatomic) NSString * _Nullable markdown;
	[NullAllowed, Export ("markdown")]
	string Markdown { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable html;
	[NullAllowed, Export ("html")]
	string Html { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable plain;
	[NullAllowed, Export ("plain")]
	string Plain { get; }

	// -(instancetype _Nonnull)initWithMarkdown:(NSString * _Nullable)markdown html:(NSString * _Nullable)html plain:(NSString * _Nullable)plain __attribute__((objc_designated_initializer));
	[Export ("initWithMarkdown:html:plain:")]
	[DesignatedInitializer]
	IntPtr Constructor ([NullAllowed] string markdown, [NullAllowed] string html, [NullAllowed] string plain);
}

// @interface CHPerson : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK8CHPerson")]
[DisableDefaultCtor]
interface CHPerson
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull personId;
	[Export ("personId")]
	string PersonId { get; }

	// @property (readonly, copy, nonatomic) NSArray<CHEmailAddress *> * _Nonnull emails;
	[Export ("emails", ArgumentSemantic.Copy)]
	CHEmailAddress[] Emails { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable displayName;
	[NullAllowed, Export ("displayName")]
	string DisplayName { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable avatar;
	[NullAllowed, Export ("avatar")]
	string Avatar { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull created;
	[Export ("created", ArgumentSemantic.Copy)]
	NSDate Created { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable nickName;
	[NullAllowed, Export ("nickName")]
	string NickName { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable firstName;
	[NullAllowed, Export ("firstName")]
	string FirstName { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable lastName;
	[NullAllowed, Export ("lastName")]
	string LastName { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable orgId;
	[NullAllowed, Export ("orgId")]
	string OrgId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable type;
	[NullAllowed, Export ("type")]
	string Type { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull lastActivity;
	[Export ("lastActivity", ArgumentSemantic.Copy)]
	NSDate LastActivity { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable status;
	[NullAllowed, Export ("status")]
	string Status { get; }

	// -(instancetype _Nonnull)initWithPersonId:(NSString * _Nonnull)personId emails:(NSArray<CHEmailAddress *> * _Nonnull)emails displayName:(NSString * _Nullable)displayName avatar:(NSString * _Nullable)avatar created:(NSDate * _Nonnull)created nickName:(NSString * _Nullable)nickName firstName:(NSString * _Nullable)firstName lastName:(NSString * _Nullable)lastName orgId:(NSString * _Nullable)orgId type:(NSString * _Nullable)type lastActivity:(NSDate * _Nonnull)lastActivity status:(NSString * _Nullable)status __attribute__((objc_designated_initializer));
	[Export ("initWithPersonId:emails:displayName:avatar:created:nickName:firstName:lastName:orgId:type:lastActivity:status:")]
	[DesignatedInitializer]
	IntPtr Constructor (string personId, CHEmailAddress[] emails, [NullAllowed] string displayName, [NullAllowed] string avatar, NSDate created, [NullAllowed] string nickName, [NullAllowed] string firstName, [NullAllowed] string lastName, [NullAllowed] string orgId, [NullAllowed] string type, NSDate lastActivity, [NullAllowed] string status);
}

// @interface CHRemoteFile : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK12CHRemoteFile")]
[DisableDefaultCtor]
interface CHRemoteFile
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull displayName;
	[Export ("displayName")]
	string DisplayName { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull mimeType;
	[Export ("mimeType")]
	string MimeType { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull url;
	[Export ("url")]
	string Url { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull size;
	[Export ("size", ArgumentSemantic.Strong)]
	NSNumber Size { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull thumbnailWidth;
	[Export ("thumbnailWidth", ArgumentSemantic.Strong)]
	NSNumber ThumbnailWidth { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull thumbnailHeight;
	[Export ("thumbnailHeight", ArgumentSemantic.Strong)]
	NSNumber ThumbnailHeight { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull thumbnailMimeType;
	[Export ("thumbnailMimeType")]
	string ThumbnailMimeType { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull thumbnailUrl;
	[Export ("thumbnailUrl")]
	string ThumbnailUrl { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull messageId;
	[Export ("messageId")]
	string MessageId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull conversationId;
	[Export ("conversationId")]
	string ConversationId { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull contentIndex;
	[Export ("contentIndex", ArgumentSemantic.Strong)]
	NSNumber ContentIndex { get; }

	// -(instancetype _Nonnull)initWithDisplayName:(NSString * _Nonnull)displayName mimeType:(NSString * _Nonnull)mimeType url:(NSString * _Nonnull)url size:(NSNumber * _Nonnull)size thumbnailWidth:(NSNumber * _Nonnull)thumbnailWidth thumbnailHeight:(NSNumber * _Nonnull)thumbnailHeight thumbnailMimeType:(NSString * _Nonnull)thumbnailMimeType thumbnailUrl:(NSString * _Nonnull)thumbnailUrl messageId:(NSString * _Nonnull)messageId conversationId:(NSString * _Nonnull)conversationId contentIndex:(NSNumber * _Nonnull)contentIndex __attribute__((objc_designated_initializer));
	[Export ("initWithDisplayName:mimeType:url:size:thumbnailWidth:thumbnailHeight:thumbnailMimeType:thumbnailUrl:messageId:conversationId:contentIndex:")]
	[DesignatedInitializer]
	IntPtr Constructor (string displayName, string mimeType, string url, NSNumber size, NSNumber thumbnailWidth, NSNumber thumbnailHeight, string thumbnailMimeType, string thumbnailUrl, string messageId, string conversationId, NSNumber contentIndex);
}

// @interface CHResource : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK10CHResource")]
[DisableDefaultCtor]
interface CHResource
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull clusterId;
	[Export ("clusterId")]
	string ClusterId { get; }

	// @property (readonly, nonatomic) CHResourceType type;
	[Export ("type")]
	CHResourceType Type { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull resource;
	[Export ("resource")]
	string Resource { get; }

	// -(instancetype _Nonnull)initWithClusterId:(NSString * _Nonnull)clusterId type:(CHResourceType)type resource:(NSString * _Nonnull)resource __attribute__((objc_designated_initializer));
	[Export ("initWithClusterId:type:resource:")]
	[DesignatedInitializer]
	IntPtr Constructor (string clusterId, CHResourceType type, string resource);
}

// @interface CHSpace : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK7CHSpace")]
[DisableDefaultCtor]
interface CHSpace
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull spaceId;
	[Export ("spaceId")]
	string SpaceId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull title;
	[Export ("title")]
	string Title { get; }

	// @property (readonly, nonatomic) CHConversationType conversationType;
	[Export ("conversationType")]
	CHConversationType ConversationType { get; }

	// @property (readonly, nonatomic) BOOL isLocked;
	[Export ("isLocked")]
	bool IsLocked { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull lastActivityTimestamp;
	[Export ("lastActivityTimestamp", ArgumentSemantic.Copy)]
	NSDate LastActivityTimestamp { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull created;
	[Export ("created", ArgumentSemantic.Copy)]
	NSDate Created { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull teamId;
	[Export ("teamId")]
	string TeamId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull sipAddress;
	[Export ("sipAddress")]
	string SipAddress { get; }

	// -(instancetype _Nonnull)initWithSpaceId:(NSString * _Nonnull)spaceId title:(NSString * _Nonnull)title conversationType:(CHConversationType)conversationType isLocked:(BOOL)isLocked lastActivityTimestamp:(NSDate * _Nonnull)lastActivityTimestamp created:(NSDate * _Nonnull)created teamId:(NSString * _Nonnull)teamId sipAddress:(NSString * _Nonnull)sipAddress __attribute__((objc_designated_initializer));
	[Export ("initWithSpaceId:title:conversationType:isLocked:lastActivityTimestamp:created:teamId:sipAddress:")]
	[DesignatedInitializer]
	IntPtr Constructor (string spaceId, string title, CHConversationType conversationType, bool isLocked, NSDate lastActivityTimestamp, NSDate created, string teamId, string sipAddress);
}

// @interface CHSpaceApiErrorInfo : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK19CHSpaceApiErrorInfo")]
[DisableDefaultCtor]
interface CHSpaceApiErrorInfo
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull code;
	[Export ("code")]
	string Code { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull message;
	[Export ("message")]
	string Message { get; }

	// -(instancetype _Nonnull)initWithCode:(NSString * _Nonnull)code message:(NSString * _Nonnull)message __attribute__((objc_designated_initializer));
	[Export ("initWithCode:message:")]
	[DesignatedInitializer]
	IntPtr Constructor (string code, string message);
}

// @interface CHSpaceMeetingInfo : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK18CHSpaceMeetingInfo")]
[DisableDefaultCtor]
interface CHSpaceMeetingInfo
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull spaceId;
	[Export ("spaceId")]
	string SpaceId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull meetingLink;
	[Export ("meetingLink")]
	string MeetingLink { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull sipAddress;
	[Export ("sipAddress")]
	string SipAddress { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull meetingNumber;
	[Export ("meetingNumber")]
	string MeetingNumber { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull callInTollFreeNumber;
	[Export ("callInTollFreeNumber")]
	string CallInTollFreeNumber { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull callInTollNumber;
	[Export ("callInTollNumber")]
	string CallInTollNumber { get; }

	// -(instancetype _Nonnull)initWithSpaceId:(NSString * _Nonnull)spaceId meetingLink:(NSString * _Nonnull)meetingLink sipAddress:(NSString * _Nonnull)sipAddress meetingNumber:(NSString * _Nonnull)meetingNumber callInTollFreeNumber:(NSString * _Nonnull)callInTollFreeNumber callInTollNumber:(NSString * _Nonnull)callInTollNumber __attribute__((objc_designated_initializer));
	[Export ("initWithSpaceId:meetingLink:sipAddress:meetingNumber:callInTollFreeNumber:callInTollNumber:")]
	[DesignatedInitializer]
	IntPtr Constructor (string spaceId, string meetingLink, string sipAddress, string meetingNumber, string callInTollFreeNumber, string callInTollNumber);
}

// @interface CHSpaceReadStatus : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK17CHSpaceReadStatus")]
[DisableDefaultCtor]
interface CHSpaceReadStatus
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull spaceId;
	[Export ("spaceId")]
	string SpaceId { get; }

	// @property (readonly, nonatomic) CHConversationType type;
	[Export ("type")]
	CHConversationType Type { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull lastActivityDate;
	[Export ("lastActivityDate", ArgumentSemantic.Copy)]
	NSDate LastActivityDate { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull lastSeenActivityDate;
	[Export ("lastSeenActivityDate", ArgumentSemantic.Copy)]
	NSDate LastSeenActivityDate { get; }

	// -(instancetype _Nonnull)initWithSpaceId:(NSString * _Nonnull)spaceId type:(CHConversationType)type lastActivityDate:(NSDate * _Nonnull)lastActivityDate lastSeenActivityDate:(NSDate * _Nonnull)lastSeenActivityDate __attribute__((objc_designated_initializer));
	[Export ("initWithSpaceId:type:lastActivityDate:lastSeenActivityDate:")]
	[DesignatedInitializer]
	IntPtr Constructor (string spaceId, CHConversationType type, NSDate lastActivityDate, NSDate lastSeenActivityDate);
}

// @interface CHTeam : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK6CHTeam")]
[DisableDefaultCtor]
interface CHTeam
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull teamId;
	[Export ("teamId")]
	string TeamId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
	[Export ("name")]
	string Name { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull created;
	[Export ("created", ArgumentSemantic.Copy)]
	NSDate Created { get; }

	// @property (readonly, nonatomic) BOOL isDeleted;
	[Export ("isDeleted")]
	bool IsDeleted { get; }

	// -(instancetype _Nonnull)initWithTeamId:(NSString * _Nonnull)teamId name:(NSString * _Nonnull)name created:(NSDate * _Nonnull)created isDeleted:(BOOL)isDeleted __attribute__((objc_designated_initializer));
	[Export ("initWithTeamId:name:created:isDeleted:")]
	[DesignatedInitializer]
	IntPtr Constructor (string teamId, string name, NSDate created, bool isDeleted);
}

// @interface CHTeamMembership : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK16CHTeamMembership")]
[DisableDefaultCtor]
interface CHTeamMembership
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull teamMembershipId;
	[Export ("teamMembershipId")]
	string TeamMembershipId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull teamId;
	[Export ("teamId")]
	string TeamId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull personId;
	[Export ("personId")]
	string PersonId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull emailAddress;
	[Export ("emailAddress")]
	string EmailAddress { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull personDisplayName;
	[Export ("personDisplayName")]
	string PersonDisplayName { get; }

	// @property (readonly, nonatomic) BOOL isModerator;
	[Export ("isModerator")]
	bool IsModerator { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull createdDate;
	[Export ("createdDate", ArgumentSemantic.Copy)]
	NSDate CreatedDate { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull personOrgId;
	[Export ("personOrgId")]
	string PersonOrgId { get; }

	// -(instancetype _Nonnull)initWithTeamMembershipId:(NSString * _Nonnull)teamMembershipId teamId:(NSString * _Nonnull)teamId personId:(NSString * _Nonnull)personId emailAddress:(NSString * _Nonnull)emailAddress personDisplayName:(NSString * _Nonnull)personDisplayName isModerator:(BOOL)isModerator createdDate:(NSDate * _Nonnull)createdDate personOrgId:(NSString * _Nonnull)personOrgId __attribute__((objc_designated_initializer));
	[Export ("initWithTeamMembershipId:teamId:personId:emailAddress:personDisplayName:isModerator:createdDate:personOrgId:")]
	[DesignatedInitializer]
	IntPtr Constructor (string teamMembershipId, string teamId, string personId, string emailAddress, string personDisplayName, bool isModerator, NSDate createdDate, string personOrgId);
}

// @interface CHTeamMembershipId : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK18CHTeamMembershipId")]
[DisableDefaultCtor]
interface CHTeamMembershipId
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull contactId;
	[Export ("contactId")]
	string ContactId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull teamId;
	[Export ("teamId")]
	string TeamId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull delimeter;
	[Export ("delimeter")]
	string Delimeter { get; }

	// -(instancetype _Nonnull)initWithContactId:(NSString * _Nonnull)contactId teamId:(NSString * _Nonnull)teamId delimeter:(NSString * _Nonnull)delimeter __attribute__((objc_designated_initializer));
	[Export ("initWithContactId:teamId:delimeter:")]
	[DesignatedInitializer]
	IntPtr Constructor (string contactId, string teamId, string delimeter);
}

// @interface CHTranscription : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK15CHTranscription")]
[DisableDefaultCtor]
interface CHTranscription
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull personId;
	[Export ("personId")]
	string PersonId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull personName;
	[Export ("personName")]
	string PersonName { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull timeStamp;
	[Export ("timeStamp", ArgumentSemantic.Strong)]
	NSNumber TimeStamp { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull content;
	[Export ("content")]
	string Content { get; }

	// -(instancetype _Nonnull)initWithPersonId:(NSString * _Nonnull)personId personName:(NSString * _Nonnull)personName timeStamp:(NSNumber * _Nonnull)timeStamp content:(NSString * _Nonnull)content __attribute__((objc_designated_initializer));
	[Export ("initWithPersonId:personName:timeStamp:content:")]
	[DesignatedInitializer]
	IntPtr Constructor (string personId, string personName, NSNumber timeStamp, string content);
}

// @interface CHVideoFrameSize : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK16CHVideoFrameSize")]
[DisableDefaultCtor]
interface CHVideoFrameSize
{
	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull width;
	[Export ("width", ArgumentSemantic.Strong)]
	NSNumber Width { get; }

	// @property (readonly, nonatomic, strong) NSNumber * _Nonnull height;
	[Export ("height", ArgumentSemantic.Strong)]
	NSNumber Height { get; }

	// -(instancetype _Nonnull)initWithWidth:(NSNumber * _Nonnull)width height:(NSNumber * _Nonnull)height __attribute__((objc_designated_initializer));
	[Export ("initWithWidth:height:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSNumber width, NSNumber height);
}

// @interface CHVirtualBackgroundItem : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK23CHVirtualBackgroundItem")]
[DisableDefaultCtor]
interface CHVirtualBackgroundItem
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
	[Export ("id")]
	string Id { get; }

	// @property (readonly, nonatomic) CHVirtualBackgroundType type;
	[Export ("type")]
	CHVirtualBackgroundType Type { get; }

	// @property (readonly, nonatomic, strong) CHVirtualBackgroundThumbnail * _Nonnull image;
	[Export ("image", ArgumentSemantic.Strong)]
	CHVirtualBackgroundThumbnail Image { get; }

	// @property (readonly, nonatomic) BOOL isActive;
	[Export ("isActive")]
	bool IsActive { get; }

	// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id type:(CHVirtualBackgroundType)type image:(CHVirtualBackgroundThumbnail * _Nonnull)image isActive:(BOOL)isActive __attribute__((objc_designated_initializer));
	[Export ("initWithId:type:image:isActive:")]
	[DesignatedInitializer]
	IntPtr Constructor (string id, CHVirtualBackgroundType type, CHVirtualBackgroundThumbnail image, bool isActive);
}

// @interface CHVirtualBackgroundThumbnail : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK28CHVirtualBackgroundThumbnail")]
[DisableDefaultCtor]
interface CHVirtualBackgroundThumbnail
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
	[Export ("name")]
	string Name { get; }

	// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name __attribute__((objc_designated_initializer));
	[Export ("initWithName:")]
	[DesignatedInitializer]
	IntPtr Constructor (string name);
}

// @interface CHWebhook : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK9CHWebhook")]
[DisableDefaultCtor]
interface CHWebhook
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull webhookId;
	[Export ("webhookId")]
	string WebhookId { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
	[Export ("name")]
	string Name { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull targetUrl;
	[Export ("targetUrl")]
	string TargetUrl { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull resource;
	[Export ("resource")]
	string Resource { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull event;
	[Export ("event")]
	string Event { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull created;
	[Export ("created")]
	string Created { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull filter;
	[Export ("filter")]
	string Filter { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull status;
	[Export ("status")]
	string Status { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull secret;
	[Export ("secret")]
	string Secret { get; }

	// -(instancetype _Nonnull)initWithWebhookId:(NSString * _Nonnull)webhookId name:(NSString * _Nonnull)name targetUrl:(NSString * _Nonnull)targetUrl resource:(NSString * _Nonnull)resource event:(NSString * _Nonnull)event created:(NSString * _Nonnull)created filter:(NSString * _Nonnull)filter status:(NSString * _Nonnull)status secret:(NSString * _Nonnull)secret __attribute__((objc_designated_initializer));
	[Export ("initWithWebhookId:name:targetUrl:resource:event:created:filter:status:secret:")]
	[DesignatedInitializer]
	IntPtr Constructor (string webhookId, string name, string targetUrl, string resource, string @event, string created, string filter, string status, string secret);
}

// @interface H264LicensePrompter : UIViewController
[BaseType (typeof(UIViewController), Name = "_TtC8WebexSDK19H264LicensePrompter")]
interface H264LicensePrompter
{
	// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
	[Export ("initWithNibName:bundle:")]
	[DesignatedInitializer]
	IntPtr Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder coder);
}

// @interface MediaRenderView : SparkVideoLayer
[BaseType (typeof(SparkVideoLayer), Name = "_TtC8WebexSDK15MediaRenderView")]
interface MediaRenderView
{
	// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor (CGRect frame);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder coder);
}

// @interface Webex : NSObject
[BaseType (typeof(NSObject), Name = "_TtC8WebexSDK5Webex")]
[DisableDefaultCtor]
interface Webex
{
}

// @interface WebexSDK_Swift_846 (Webex) <OmniusServiceBridgeDelegate>
[Category]
[BaseType (typeof(Webex))]
interface Webex_WebexSDK_Swift_846 : IOmniusServiceBridgeDelegate
{
	// -(void)omniusServiceBridge:(id<OmniusServiceBridgeProtocol> _Nonnull)omniusServiceBridge showUCSSOLoginView:(NSString * _Nonnull)ssoUrl;
	[Export ("omniusServiceBridge:showUCSSOLoginView:")]
	void OmniusServiceBridge (OmniusServiceBridgeProtocol omniusServiceBridge, string ssoUrl);

	// -(void)omniusServiceBridgeShowUCNonSSOLoginView:(id<OmniusServiceBridgeProtocol> _Nonnull)omniusServiceBridge;
	[Export ("omniusServiceBridgeShowUCNonSSOLoginView:")]
	void OmniusServiceBridgeShowUCNonSSOLoginView (OmniusServiceBridgeProtocol omniusServiceBridge);

	// -(void)omniusServiceBridgeOnUCLoggedIn:(id<OmniusServiceBridgeProtocol> _Nonnull)omniusServiceBridge;
	[Export ("omniusServiceBridgeOnUCLoggedIn:")]
	void OmniusServiceBridgeOnUCLoggedIn (OmniusServiceBridgeProtocol omniusServiceBridge);

	// -(void)omniusServiceBridgeOnUCLoggedOut:(id<OmniusServiceBridgeProtocol> _Nonnull)omniusServiceBridge;
	[Export ("omniusServiceBridgeOnUCLoggedOut:")]
	void OmniusServiceBridgeOnUCLoggedOut (OmniusServiceBridgeProtocol omniusServiceBridge);

	// -(void)omniusServiceBridgeOnUCLoginFailed:(id<OmniusServiceBridgeProtocol> _Nonnull)omniusServiceBridge;
	[Export ("omniusServiceBridgeOnUCLoginFailed:")]
	void OmniusServiceBridgeOnUCLoginFailed (OmniusServiceBridgeProtocol omniusServiceBridge);

	// -(void)omniusServiceBridge:(id<OmniusServiceBridgeProtocol> _Nonnull)omniusServiceBridge onUCServerConnectionStateChanged:(CHUCLoginServerConnectionStatus)status failureReason:(CHPhoneServiceRegistrationFailureReason)failureReason;
	[Export ("omniusServiceBridge:onUCServerConnectionStateChanged:failureReason:")]
	void OmniusServiceBridge (OmniusServiceBridgeProtocol omniusServiceBridge, CHUCLoginServerConnectionStatus status, CHPhoneServiceRegistrationFailureReason failureReason);
}
