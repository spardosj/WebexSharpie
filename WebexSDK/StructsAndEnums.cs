using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

static class CFunctions
{
	// extern BOOL IsDebuggerAttached ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern bool IsDebuggerAttached ();

	// extern void BreakIntoDebugger ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void BreakIntoDebugger ();

	// extern NSString * _Nullable AtosCommandForCallStackReturnAddresses (NSArray<NSNumber *> * _Nonnull callStackReturnAddresses);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	[return: NullAllowed]
	static extern NSString AtosCommandForCallStackReturnAddresses (NSNumber[] callStackReturnAddresses);

	// extern NSException * _Nullable ExecuteThrowableBlock (void (^ _Nonnull)(void) block);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	[return: NullAllowed]
	static extern NSException ExecuteThrowableBlock (Action block);

	// extern void ExecuteFatalThrowableBlock (void (^ _Nonnull)(void) block);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void ExecuteFatalThrowableBlock (Action block);
}

[Native]
public enum RootLoggerLevel : long
{
	UnknownLoggerLevel = 0,
	Trace,
	Detail,
	Debug,
	Info,
	Warn,
	Error,
	Private,
	Test
}

[Native]
public enum LogLevel : long
{
	Error,
	Warn,
	Info,
	Verbose,
	Private
}

[Native]
public enum CHOAuthResult : ulong
{
	Success,
	InvalidEmail,
	UserNotActivated,
	UnableToDiscoverPreLoginServices,
	NetworkError,
	UnknownError
}

[Native]
public enum CHAccessTokenLoginResult : ulong
{
	Success,
	InvalidToken,
	TokenExpired,
	NetworkError,
	InternalError,
	FedRAMPError,
	UnknownError
}

[Native]
public enum CHConversationSortType : ulong
{
	byId,
	lastactivity,
	created,
	none
}

[Native]
public enum CHConversationType : ulong
{
	direct,
	group,
	none
}

[Native]
public enum CHDeleteSpaceResult : ulong
{
	NoError,
	InternalError,
	InvalidSpaceId,
	BadRequest
}

[Native]
public enum CHTeamCreateResult : ulong
{
	NoError,
	InternalError,
	InvalidNameError
}

[Native]
public enum CHTeamGetResult : ulong
{
	NoError,
	InternalError,
	TeamNotFound
}

[Native]
public enum CHTeamArchiveResult : ulong
{
	NoError,
	InternalError,
	TeamNotFound,
	AlreadyArchived,
	UserIsNotModerator,
	ArchiveFailed
}

[Native]
public enum CHTeamUpdateResult : ulong
{
	NoError,
	InternalError,
	TeamNotFound,
	InvalidTeamName
}

[Native]
public enum CHTelemetry : ulong
{
	AuthCodeReceived,
	WebexLoggedIn
}

[Native]
public enum CHUCBrowserLoginSSONavResult : ulong
{
	Success,
	FailedWith4xx,
	FailedWith5xx,
	UnknownError,
	FailedWithCertError
}

[Native]
public enum CHMessageResult : ulong
{
	NoError,
	UnknownError,
	EmptyMessage,
	MessageTooLong,
	UnknownConversation,
	NoFileData,
	MentionedUserDoesNotExist,
	ParentMessageDeletedByAuthor,
	ParentMessageDeletedByModerator,
	OneToOneParticipantRemovedFromCI,
	InvalidUnicodeContentInMessage,
	ParentMessageDeletedByModeratorWhileEditing,
	LinksAreDirty,
	ProvisionalSpaceConversionFailed,
	ServerError,
	SpaceError,
	InvalidFileData,
	FileUploadFailed
}

[Native]
public enum CHMentionType : ulong
{
	GroupAllMention,
	ContactMention
}

[Native]
public enum CHCallAssociationType : ulong
{
	Undefined,
	Transfer,
	Merge
}

[Native]
public enum CHMarkMessageReadResult : ulong
{
	InternalError,
	InvalidMessageId,
	InvalidSpaceId,
	FailedToMarkMessageRead,
	AttemptedToMarkMessageReadBySender,
	NoError
}

[Native]
public enum CHGetMessageResult : ulong
{
	InternalError,
	InvalidMessageId,
	NoError
}

[Native]
public enum CHDeleteMessageResult : ulong
{
	NoError,
	InternalError,
	InvalidMessageId
}

[Native]
public enum CHPersonGetResult : ulong
{
	NoError,
	InternalError,
	PersonNotFound,
	Unauthorized,
	BadRequest
}

[Native]
public enum CHGetMembershipByIdResult : ulong
{
	InternalError,
	InvalidMembershipId,
	NoError
}

[Native]
public enum CHCreateSpaceMembershipResult : ulong
{
	NoError,
	InvalidSpaceId,
	NonModeratorCannotAddToModeratedSpace,
	UserDoesntExistInOrg,
	ExternalUserNotAllowed,
	CompanyPolicyPreventsMembershipCreation,
	BotCannotBeAdded,
	BotCannotBeAddedToDirectSpace,
	TeamGuestMemberNotEntitled,
	UserNotPartOfTeamOffice365,
	UserNotPartOfOrganizationOffice365,
	FailedToSetModerator,
	FailedOperationDisallowedForCommercialGuest,
	InternalError
}

[Native]
public enum CHMembershipUpdateResult : ulong
{
	NoError,
	InternalError,
	InvalidMembershipId,
	SpaceIsProvisional,
	InsufficientSpacePrivileges,
	FailedToRemoveModerator
}

[Native]
public enum CHListMessagesResult : ulong
{
	NoError,
	InternalError,
	InvalidSpaceId,
	InvalidMaxValue
}

[Native]
public enum CHMembershipDeleteResult : ulong
{
	NoError,
	InternalError,
	InvalidMembershipId,
	SpaceTypeDirect,
	NoPeople,
	LoadingError,
	SelfNotInSpace,
	InsufficientSpacePrivileges
}

[Native]
public enum CHListTeamMembershipResult : ulong
{
	NoError,
	InternalError,
	TeamNotFound,
	BadRequest
}

[Native]
public enum CHCreateTeamMembershipResult : ulong
{
	NoError,
	InternalError,
	InvalidTeamId,
	TeamNotFound,
	NonModeratorCannotAddToModeratedTeam,
	UserDoesntExistInOrg,
	ExternalUserNotAllowed,
	CompanyPolicyPreventsMembershipCreation,
	BotCannotBeAdded,
	BotCannotBeAddedToDirectSpace,
	TeamGuestMemberNotEntitled,
	UserNotPartOfTeamOffice365,
	UserNotPartOfOrganizationOffice365,
	FailedToSetModerator,
	FailedOperationDisallowedForCommercialGuest
}

[Native]
public enum CHGetTeamMembershipResult : ulong
{
	NoError,
	InternalError,
	InvalidTeamMembershipId,
	TeamNotFound,
	BadRequest
}

[Native]
public enum CHUpdateTeamMembershipResult : ulong
{
	NoError,
	InternalError,
	InvalidTeamMembershipId,
	TeamNotFound,
	SpaceIsProvisional,
	InsufficientTeamPrivileges,
	FailedToRemoveModerator
}

[Native]
public enum CHDeleteTeamMembershipResult : ulong
{
	NoError,
	InternalError,
	InvalidTeamMembershipId,
	TeamNotFound,
	SpaceTypeDirect,
	NoPeople,
	LoadingError,
	SelfNotInTeam,
	InsufficientTeamPrivileges
}

[Native]
public enum CHListPersonsResult : ulong
{
	NoError,
	InternalError,
	InvalidPayload,
	Unauthorized,
	BadRequest
}

[Native]
public enum CHPersonCreateResult : ulong
{
	NoError,
	InternalError,
	Unauthorized,
	BadRequest
}

[Native]
public enum CHPersonDeleteResult : ulong
{
	NoError,
	InternalError,
	PersonNotFound,
	Unauthorized,
	BadRequest
}

[Native]
public enum CHPersonUpdateResult : ulong
{
	NoError,
	InternalError,
	Unauthorized,
	PersonNotFound,
	BadRequest
}

[Native]
public enum CHListMembershipResult : ulong
{
	NoError,
	InvalidSpaceId,
	InvalidPersonId,
	InvalidPersonEmail,
	InternalError,
	BadRequest
}

[Native]
public enum CHListMembershipsReadStatusResult : ulong
{
	NoError,
	InvalidSpaceId,
	InternalError
}

[Native]
public enum CHUpdateSpaceTitleResult : ulong
{
	NoError,
	InvalidSpaceId,
	FailedToUpdateSpaceTitle,
	TitleCannotBeEmpty,
	InternalError
}

[Native]
public enum CHUCLoginServerConnectionStatus : ulong
{
	Idle,
	Connecting,
	Connected,
	Disconnected,
	Failed
}

[Native]
public enum CHPhoneServiceRegistrationFailureReason : ulong
{
	Unknown,
	None,
	Registering,
	WaitingForConfigFile,
	NotStarted,
	NoNetwork,
	Failover,
	Fallback,
	RegAllFailed,
	Shutdown,
	LogoutReset,
	InvalidCredentials,
	NoCredentialsConfigured,
	PhoneAuthenticationFailure,
	PhoneAuthenticationRequired,
	LineRegistrationFailure,
	RegisteredElsewhere,
	NoRemoteDestinationAvailable,
	CouldNotActivateRemoteDestination,
	NoDeviceConfigured,
	InvalidConfig,
	CouldNotConnect,
	DeviceNotInService,
	DeviceRegTimedOut,
	DeviceRegDeviceAlreadyRegistered,
	DeviceRegCouldNotConnect,
	DeviceRegNoDevicesFound,
	DeviceRegAuthenticationFailure,
	DeviceRegSelectedDeviceNotFound,
	DeviceRegSelectedLineNotFound,
	DeviceRegCouldNotOpenDevice,
	DeviceRegCouldNotOpenLine,
	DeviceNotAuthorised,
	TLSFailure,
	IpModeMismatch,
	HostResolutionFailure,
	ServerError,
	RequireStorageHelper,
	DeviceConfigurationRetrievalTimedOut,
	EdgePhoneModeNotSupported,
	EdgeIpModeNotSupported,
	NoHttpHelperAvailable,
	CTIUnableToVerifyCertificate,
	FIPSNoCertificateVerifier,
	NoCertificateVerifier,
	P2PHybridNotSupported,
	DisabledByMRAPolicy,
	DeviceMaxConnectionReached,
	UltrasoundCapturerOccupied,
	DirectoryLoginNotAllowed
}

[Native]
public enum CHDeleteWebhookByIdResult : ulong
{
	NoError,
	InternalError,
	WebhookNotFound,
	BadRequest
}

[Native]
public enum CHUpdateWebhookByIdResult : ulong
{
	NoError,
	InternalError,
	WebhookNotFound,
	InvalidPayload,
	BadRequest
}

[Native]
public enum CHGetWebhookByIdResult : ulong
{
	NoError,
	InternalError,
	WebhookNotFound,
	BadRequest
}

[Native]
public enum CHCreateWebhookResult : ulong
{
	NoError,
	InternalError,
	InvalidPayload,
	BadRequest
}

[Native]
public enum CHListWebhooksResult : ulong
{
	NoError,
	InternalError,
	BadRequest
}

[Native]
public enum CHResourceType : ulong
{
	Memberships,
	Messages,
	Rooms,
	Teams
}

[Native]
public enum CHNotificationCallType : ulong
{
	Webex,
	Cucm
}

[Native]
public enum CHMessageEvent : ulong
{
	Received,
	Deleted,
	ThumbnailUpdated,
	Edited
}

[Native]
public enum CHSpaceEvent : ulong
{
	Create,
	Update,
	SpaceCallStarted,
	SpaceCallEnded
}

[Native]
public enum CHCallDirection : ulong
{
	Undefined,
	Incoming,
	Outgoing
}

[Native]
public enum CHCallMembershipState : ulong
{
	Unknown,
	Idle,
	Notified,
	Joined,
	Left,
	Declined,
	Waiting
}

[Native]
public enum CHVideoRenderMode : ulong
{
	Fit,
	CropFill,
	StretchFill
}

[Native]
public enum CHMediaStreamType : ulong
{
	Unknown,
	Local,
	Remote,
	RemoteAux1,
	RemoteAux2,
	RemoteAux3,
	RemoteAux4,
	RemoteAux5,
	RemoteAux6,
	RemoteAux7,
	RemoteAux8,
	RemoteAux9,
	RemoteAux10,
	RemoteAux11,
	RemoteAux12,
	RemoteAux13,
	RemoteAux14,
	RemoteAux15,
	RemoteAux16,
	RemoteAux17,
	RemoteAux18,
	RemoteAux19,
	RemoteAux20,
	RemoteAux21,
	RemoteAux22,
	RemoteAux23,
	RemoteAux24,
	RemoteAuxEnd,
	LocalShare,
	RemoteShare
}

[Native]
public enum CHVideoStreamMode : ulong
{
	Composited,
	Auxiliary
}

[Native]
public enum CHCompositedVideoLayout : ulong
{
	Single,
	Filmstrip,
	Grid,
	NotSupported
}

[Native]
public enum CHLetInResult : ulong
{
	Illegal,
	NoError,
	InternalError,
	CallNotFound
}

[Native]
public enum CHSetCompositedLayoutResult : ulong
{
	Illegal,
	NoError,
	InternalError,
	CallNotFound,
	NotSupported
}

[Native]
public enum CHMeetingLockedErrorCodes : ulong
{
	Unknown,
	None,
	ModeratorPinOrGuest,
	ModeratorPinOrGuestPassword,
	MeetingPassword
}

[Native]
public enum CHTeamListResult : ulong
{
	NoError,
	InternalError,
	InvalidMinMaxLimitError
}

[Native]
public enum CHSetRemoteVideoRenderModeResult : ulong
{
	Illegal,
	NoError,
	InternalError,
	CallNotFound,
	NotSupported
}

[Native]
public enum CHDownloadFileResult : ulong
{
	NoError,
	UnknownError,
	InternalError,
	InvalidSpaceId,
	InvalidMessageID,
	InvalidContentIndex,
	InvalidDownloadPath,
	InvalidContent,
	Blocked,
	FileIsUnscannable
}

[Native]
public enum CHDownloadThumbnailResult : ulong
{
	NoError,
	InternalError,
	InvalidSpaceId,
	InvalidMessageID,
	InvalidContentIndex,
	NotAvailable
}

[Native]
public enum CHBase64EncodeResult : ulong
{
	NoError,
	InternalError,
	AlreadyEncoded,
	BadRequest
}

[Native]
public enum CHJWTTokenResult : ulong
{
	NoError,
	InternalError,
	TokenExpiryMissing,
	TokenExpired,
	FedRAMPError,
	InvalidToken
}

[Native]
public enum CHServiceUrlType : ulong
{
	Metrics,
	Client_Logs,
	Kms
}

[Native]
public enum CHMembershipEvent : ulong
{
	Create,
	Update,
	Delete,
	MessageSeen
}

[Native]
public enum CHInviteeResponse : ulong
{
	Organizer,
	Accepted,
	Declined,
	Tentative,
	Unavailable,
	WaitingForResponse
}

[Native]
public enum CHCalendarMeetingEvent : ulong
{
	Create,
	Update,
	Delete
}

[Native]
public enum CHListCalendarMeetingsResult : ulong
{
	NoError,
	InternalError,
	CalendarServiceDisabled
}

[Native]
public enum CHGetCalendarMeetingByIdResult : ulong
{
	NoError,
	InternalError,
	CalendarServiceDisabled,
	NotFound
}

[Native]
public enum CHApplyVirtualBackgroundResult : ulong
{
	NoError,
	InternalError,
	NotFound
}

[Native]
public enum CHDeleteVirtualBackgroundResult : ulong
{
	Illegal,
	NoError,
	InternalError,
	NotFound,
	StorageError
}

[Native]
public enum CHPreviewVirtualBackgroundResult : ulong
{
	NoError,
	InternalError,
	NotFound
}

[Native]
public enum CHUploadVirtualBackgroundResult : ulong
{
	NoError,
	InternalError,
	StorageError,
	ImageSizeError,
	ImageTypeError
}

[Native]
public enum CHVirtualBackgroundType : ulong
{
	None,
	Blur,
	Customized
}

[Native]
public enum CHFetchVirtualBackgroundResult : ulong
{
	NoError,
	InternalError,
	NotSupported
}

[Native]
public enum CHVideoTorchMode : ulong
{
	Off,
	On,
	Auto
}

[Native]
public enum CHVideoFlashMode : ulong
{
	Off,
	On,
	Auto
}

[Native]
public enum VideoRenderType : ulong
{
	Default,
	Remote,
	Local,
	Custom = Local
}
