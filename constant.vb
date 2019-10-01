Option Strict Off
Option Explicit On
Module Module1
	Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)
	
	' Catalyst SocketWrench 3.6
	' Copyright 1995-2003, Catalyst Development Corporation
	' All rights reserved
	'
	' This product is licensed to you pursuant to the terms of the
	' Catalyst license agreement included with the original software,
	' and is protected by copyright law and international treaties.
	' Unauthorized reproduction or distribution may result in severe
	' criminal penalties.
	'
	' This file contains constants for use in Visual Basic 6.0 and
	' should be loaded into a code module. If you are updating an
	' application written using an earlier version of this product,
	' you should replace the constants with the values in this file.
	'
	
	'
	' General constants used with most of the controls
	'
	Public Const INVALID_HANDLE As Short = -1
	Public Const CONTROL_ERRIGNORE As Short = 0
	Public Const CONTROL_ERRDISPLAY As Short = 1
	
	'
	' SocketWrench Control Actions
	'
	Public Const SOCKET_OPEN As Short = 1
	Public Const SOCKET_CONNECT As Short = 2
	Public Const SOCKET_LISTEN As Short = 3
	Public Const SOCKET_ACCEPT As Short = 4
	Public Const SOCKET_CANCEL As Short = 5
	Public Const SOCKET_FLUSH As Short = 6
	Public Const SOCKET_CLOSE As Short = 7
	Public Const SOCKET_DISCONNECT As Short = 7
	Public Const SOCKET_ABORT As Short = 8
	Public Const SOCKET_STARTUP As Short = 9
	Public Const SOCKET_CLEANUP As Short = 10
	
	'
	' SocketWrench Control States
	'
	Public Const SOCKET_NONE As Short = 0
	Public Const SOCKET_IDLE As Short = 1
	Public Const SOCKET_LISTENING As Short = 2
	Public Const SOCKET_CONNECTING As Short = 3
	Public Const SOCKET_ACCEPTING As Short = 4
	Public Const SOCKET_RECEIVING As Short = 5
	Public Const SOCKET_SENDING As Short = 6
	Public Const SOCKET_CLOSING As Short = 7
	
	'
	' Socket Address Families
	'
	Public Const AF_UNSPEC As Short = 0
	Public Const AF_UNIX As Short = 1
	Public Const AF_INET As Short = 2
	
	'
	' Socket Types
	'
	Public Const SOCK_STREAM As Short = 1
	Public Const SOCK_DGRAM As Short = 2
	Public Const SOCK_RAW As Short = 3
	Public Const SOCK_RDM As Short = 4
	Public Const SOCK_SEQPACKET As Short = 5
	
	'
	' Protocol Types
	'
	Public Const IPPROTO_IP As Short = 0
	Public Const IPPROTO_ICMP As Short = 1
	Public Const IPPROTO_GGP As Short = 2
	Public Const IPPROTO_TCP As Short = 6
	Public Const IPPROTO_PUP As Short = 12
	Public Const IPPROTO_UDP As Short = 17
	Public Const IPPROTO_IDP As Short = 22
	Public Const IPPROTO_ND As Short = 77
	Public Const IPPROTO_RAW As Short = 255
	Public Const IPPROTO_MAX As Short = 256
	
	'
	' Well-Known Port Numbers
	'
	Public Const IPPORT_ANY As Short = 0
	Public Const IPPORT_ECHO As Short = 7
	Public Const IPPORT_DISCARD As Short = 9
	Public Const IPPORT_SYSTAT As Short = 11
	Public Const IPPORT_DAYTIME As Short = 13
	Public Const IPPORT_NETSTAT As Short = 15
	Public Const IPPORT_CHARGEN As Short = 19
	Public Const IPPORT_FTP As Short = 21
	Public Const IPPORT_TELNET As Short = 23
	Public Const IPPORT_SMTP As Short = 25
	Public Const IPPORT_TIMESERVER As Short = 37
	Public Const IPPORT_NAMESERVER As Short = 42
	Public Const IPPORT_WHOIS As Short = 43
	Public Const IPPORT_MTP As Short = 57
	Public Const IPPORT_TFTP As Short = 69
	Public Const IPPORT_FINGER As Short = 79
	Public Const IPPORT_HTTP As Short = 80
	Public Const IPPORT_POP3 As Short = 110
	Public Const IPPORT_NNTP As Short = 119
	Public Const IPPORT_SNMP As Short = 161
	Public Const IPPORT_EXEC As Short = 512
	Public Const IPPORT_LOGIN As Short = 513
	Public Const IPPORT_SHELL As Short = 514
	Public Const IPPORT_RESERVED As Short = 1024
	Public Const IPPORT_USERRESERVED As Short = 5000
	
	'
	' Network Addresses
	'
	Public Const INADDR_ANY As String = "0.0.0.0"
	Public Const INADDR_LOOPBACK As String = "127.0.0.1"
	Public Const INADDR_NONE As String = "255.255.255.255"
	
	'
	' Shutdown Values
	'
	Public Const SOCKET_READ As Short = 0
	Public Const SOCKET_WRITE As Short = 1
	Public Const SOCKET_READWRITE As Short = 2
	
	'
	' Byte Order
	'
	Public Const LOCAL_BYTE_ORDER As Short = 0
	Public Const NETWORK_BYTE_ORDER As Short = 1
	
	'
	' SocketWrench Error Response
	'
	Public Const SOCKET_ERRIGNORE As Short = 0
	Public Const SOCKET_ERRDISPLAY As Short = 1
	
	'
	' SocketWrench Error Codes
	'
	Public Const WSABASEERR As Short = 24000
	Public Const WSAEINTR As Short = 24004
	Public Const WSAEBADF As Short = 24009
	Public Const WSAEACCES As Short = 24013
	Public Const WSAEFAULT As Short = 24014
	Public Const WSAEINVAL As Short = 24022
	Public Const WSAEMFILE As Short = 24024
	Public Const WSAEWOULDBLOCK As Short = 24035
	Public Const WSAEINPROGRESS As Short = 24036
	Public Const WSAEALREADY As Short = 24037
	Public Const WSAENOTSOCK As Short = 24038
	Public Const WSAEDESTADDRREQ As Short = 24039
	Public Const WSAEMSGSIZE As Short = 24040
	Public Const WSAEPROTOTYPE As Short = 24041
	Public Const WSAENOPROTOOPT As Short = 24042
	Public Const WSAEPROTONOSUPPORT As Short = 24043
	Public Const WSAESOCKTNOSUPPORT As Short = 24044
	Public Const WSAEOPNOTSUPP As Short = 24045
	Public Const WSAEPFNOSUPPORT As Short = 24046
	Public Const WSAEAFNOSUPPORT As Short = 24047
	Public Const WSAEADDRINUSE As Short = 24048
	Public Const WSAEADDRNOTAVAIL As Short = 24049
	Public Const WSAENETDOWN As Short = 24050
	Public Const WSAENETUNREACH As Short = 24051
	Public Const WSAENETRESET As Short = 24052
	Public Const WSAECONNABORTED As Short = 24053
	Public Const WSAECONNRESET As Short = 24054
	Public Const WSAENOBUFS As Short = 24055
	Public Const WSAEISCONN As Short = 24056
	Public Const WSAENOTCONN As Short = 24057
	Public Const WSAESHUTDOWN As Short = 24058
	Public Const WSAETOOMANYREFS As Short = 24059
	Public Const WSAETIMEDOUT As Short = 24060
	Public Const WSAECONNREFUSED As Short = 24061
	Public Const WSAELOOP As Short = 24062
	Public Const WSAENAMETOOLONG As Short = 24063
	Public Const WSAEHOSTDOWN As Short = 24064
	Public Const WSAEHOSTUNREACH As Short = 24065
	Public Const WSAENOTEMPTY As Short = 24066
	Public Const WSAEPROCLIM As Short = 24067
	Public Const WSAEUSERS As Short = 24068
	Public Const WSAEDQUOT As Short = 24069
	Public Const WSAESTALE As Short = 24070
	Public Const WSAEREMOTE As Short = 24071
	Public Const WSASYSNOTREADY As Short = 24091
	Public Const WSAVERNOTSUPPORTED As Short = 24092
	Public Const WSANOTINITIALISED As Short = 24093
	Public Const WSAHOST_NOT_FOUND As Short = 25001
	Public Const WSATRY_AGAIN As Short = 25002
	Public Const WSANO_RECOVERY As Short = 25003
	Public Const WSANO_DATA As Short = 25004
	Public Const WSANO_ADDRESS As Short = 25004
	
	'
	' RAS Control Actions
	'
	Public Const RAS_ACTION_CONNECT As Short = 1
	Public Const RAS_ACTION_DISCONNECT As Short = 2
	Public Const RAS_ACTION_RESET As Short = 3
	
	'
	' RAS Control Connection States
	'
	Public Const RASCS_UNUSED As Short = -1 ' The control is not in use
	Public Const RASCS_OPENPORT As Short = 0 ' The communications port is about to be opened
	Public Const RASCS_PORTOPENED As Short = 1 ' The communications port has been opened
	Public Const RASCS_CONNECTDEVICE As Short = 2 ' A device is about to be connected
	Public Const RASCS_DEVICECONNECTED As Short = 3 ' A device has been connected successfully
	Public Const RASCS_ALLDEVICESCONNECTED As Short = 4 ' All devices have been connected, physical link established
	Public Const RASCS_AUTHENTICATE As Short = 5 ' The authentication phase is starting
	Public Const RASCS_AUTHNOTIFY As Short = 6 ' An authentication event has occurred
	Public Const RASCS_AUTHRETRY As Short = 7 ' The client has requested another validation attempt
	Public Const RASCS_AUTHCALLBACK As Short = 8 ' The remote server has requested a callback number
	Public Const RASCS_AUTHCHANGEPASSWORD As Short = 9 ' The client has requested to change the password
	Public Const RASCS_AUTHPROJECT As Short = 10 ' The projection phase is starting
	Public Const RASCS_AUTHLINKSPEED As Short = 11 ' The link speed calculation phase is starting
	Public Const RASCS_AUTHACK As Short = 12 ' The authentication request has been acknowledged
	Public Const RASCS_REAUTHENTICATE As Short = 13 ' Re-authentication after a callback is starting
	Public Const RASCS_AUTHENTICATED As Short = 14 ' The client has successfully completed authentication
	Public Const RASCS_PREPAREFORCALLBACK As Short = 15 ' The link is about to disconnect in preperation for a callback
	Public Const RASCS_WAITFORMODEMRESET As Short = 16 ' The client is waiting for the modem to reset
	Public Const RASCS_WAITFORCALLBACK As Short = 17 ' The client is waiting for an incoming callback
	Public Const RASCS_PROJECTED As Short = 18 ' The projection phase has completed
	Public Const RASCS_STARTAUTHENTICATION As Short = 19 ' User authentication is being initiated
	Public Const RASCS_CALLBACKCOMPLETE As Short = 20 ' The client has been called back, resume authentication
	Public Const RASCS_LOGONNETWORK As Short = 21 ' The client is logging on to the network
	Public Const RASCS_SUBENTRYCONNECTED As Short = 22 ' A subentry has been connected (multilink connections)
	Public Const RASCS_SUBENTRYDISCONNECTED As Short = 23 ' A subentry has been disconnected (multilink connections)
	Public Const RASCS_PAUSED As Short = 4096 ' The client has paused for an interactive (terminal) session
	Public Const RASCS_RETRYAUTHENTICATION As Short = 4097 ' The client is in a re-authentication state
	Public Const RASCS_CALLBACKSETBYCALLER As Short = 4098 ' The client is in a callback state
	Public Const RASCS_PASSWORDEXPIRED As Short = 4099 ' The client is in a change password state
	Public Const RASCS_CONNECTED As Short = 8192 ' A successful connection has been established
	Public Const RASCS_DISCONNECTED As Short = 8193 ' The client has been disconnected or the connection attempt failed
	
	'
	' RAS Control Error Codes
	'
	' These error codes are returned by the LastError property and
	' passed as an argument to the LastError event. These are the
	' same codes returned by the RAS library, with 25000 added to the
	' base value
	'
	Public Const ERROR_INVALID_PORT_HANDLE As Short = 25601
	Public Const ERROR_PORT_ALREADY_OPEN As Short = 25602
	Public Const ERROR_BUFFER_TOO_SMALL As Short = 25603
	Public Const ERROR_WRONG_INFO_SPECIFIED As Short = 25604
	Public Const ERROR_CANNOT_SET_PORT_INFO As Short = 25605
	Public Const ERROR_PORT_NOT_CONNECTED As Short = 25606
	Public Const ERROR_EVENT_INVALID As Short = 25607
	Public Const ERROR_DEVICE_DOES_NOT_EXIST As Short = 25608
	Public Const ERROR_DEVICETYPE_DOES_NOT_EXIST As Short = 25609
	Public Const ERROR_BUFFER_INVALID As Short = 25610
	Public Const ERROR_ROUTE_NOT_AVAILABLE As Short = 25611
	Public Const ERROR_ROUTE_NOT_ALLOCATED As Short = 25612
	Public Const ERROR_INVALID_COMPRESSION_SPECIFIED As Short = 25613
	Public Const ERROR_OUT_OF_BUFFERS As Short = 25614
	Public Const ERROR_PORT_NOT_FOUND As Short = 25615
	Public Const ERROR_ASYNC_REQUEST_PENDING As Short = 25616
	Public Const ERROR_ALREADY_DISCONNECTING As Short = 25617
	Public Const ERROR_PORT_NOT_OPEN As Short = 25618
	Public Const ERROR_PORT_DISCONNECTED As Short = 25619
	Public Const ERROR_NO_ENDPOINTS As Short = 25620
	Public Const ERROR_CANNOT_OPEN_PHONEBOOK As Short = 25621
	Public Const ERROR_CANNOT_LOAD_PHONEBOOK As Short = 25622
	Public Const ERROR_CANNOT_FIND_PHONEBOOK_ENTRY As Short = 25623
	Public Const ERROR_CANNOT_WRITE_PHONEBOOK As Short = 25624
	Public Const ERROR_CORRUPT_PHONEBOOK As Short = 25625
	Public Const ERROR_CANNOT_LOAD_STRING As Short = 25626
	Public Const ERROR_KEY_NOT_FOUND As Short = 25627
	Public Const ERROR_DISCONNECTION As Short = 25628
	Public Const ERROR_REMOTE_DISCONNECTION As Short = 25629
	Public Const ERROR_HARDWARE_FAILURE As Short = 25630
	Public Const ERROR_USER_DISCONNECTION As Short = 25631
	Public Const ERROR_INVALID_SIZE As Short = 25632
	Public Const ERROR_PORT_NOT_AVAILABLE As Short = 25633
	Public Const ERROR_CANNOT_PROJECT_CLIENT As Short = 25634
	Public Const ERROR_UNKNOWN As Short = 25635
	Public Const ERROR_WRONG_DEVICE_ATTACHED As Short = 25636
	Public Const ERROR_BAD_STRING As Short = 25637
	Public Const ERROR_REQUEST_TIMEOUT As Short = 25638
	Public Const ERROR_CANNOT_GET_LANA As Short = 25639
	Public Const ERROR_NETBIOS_ERROR As Short = 25640
	Public Const ERROR_SERVER_OUT_OF_RESOURCES As Short = 25641
	Public Const ERROR_NAME_EXISTS_ON_NET As Short = 25642
	Public Const ERROR_SERVER_GENERAL_NET_FAILURE As Short = 25643
	Public Const WARNING_MSG_ALIAS_NOT_ADDED As Short = 25644
	Public Const ERROR_AUTH_INTERNAL As Short = 25645
	Public Const ERROR_RESTRICTED_LOGON_HOURS As Short = 25646
	Public Const ERROR_ACCT_DISABLED As Short = 25647
	Public Const ERROR_PASSWD_EXPIRED As Short = 25648
	Public Const ERROR_NO_DIALIN_PERMISSION As Short = 25649
	Public Const ERROR_SERVER_NOT_RESPONDING As Short = 25650
	Public Const ERROR_FROM_DEVICE As Short = 25651
	Public Const ERROR_UNRECOGNIZED_RESPONSE As Short = 25652
	Public Const ERROR_MACRO_NOT_FOUND As Short = 25653
	Public Const ERROR_MACRO_NOT_DEFINED As Short = 25654
	Public Const ERROR_MESSAGE_MACRO_NOT_FOUND As Short = 25655
	Public Const ERROR_DEFAULTOFF_MACRO_NOT_FOUND As Short = 25656
	Public Const ERROR_FILE_COULD_NOT_BE_OPENED As Short = 25657
	Public Const ERROR_DEVICENAME_TOO_LONG As Short = 25658
	Public Const ERROR_DEVICENAME_NOT_FOUND As Short = 25659
	Public Const ERROR_NO_RESPONSES As Short = 25660
	Public Const ERROR_NO_COMMAND_FOUND As Short = 25661
	Public Const ERROR_WRONG_KEY_SPECIFIED As Short = 25662
	Public Const ERROR_UNKNOWN_DEVICE_TYPE As Short = 25663
	Public Const ERROR_ALLOCATING_MEMORY As Short = 25664
	Public Const ERROR_PORT_NOT_CONFIGURED As Short = 25665
	Public Const ERROR_DEVICE_NOT_READY As Short = 25666
	Public Const ERROR_READING_INI_FILE As Short = 25667
	Public Const ERROR_NO_CONNECTION As Short = 25668
	Public Const ERROR_BAD_USAGE_IN_INI_FILE As Short = 25669
	Public Const ERROR_READING_SECTIONNAME As Short = 25670
	Public Const ERROR_READING_DEVICETYPE As Short = 25671
	Public Const ERROR_READING_DEVICENAME As Short = 25672
	Public Const ERROR_READING_USAGE As Short = 25673
	Public Const ERROR_READING_MAXCONNECTBPS As Short = 25674
	Public Const ERROR_READING_MAXCARRIERBPS As Short = 25675
	Public Const ERROR_LINE_BUSY As Short = 25676
	Public Const ERROR_VOICE_ANSWER As Short = 25677
	Public Const ERROR_NO_ANSWER As Short = 25678
	Public Const ERROR_NO_CARRIER As Short = 25679
	Public Const ERROR_NO_DIALTONE As Short = 25680
	Public Const ERROR_IN_COMMAND As Short = 25681
	Public Const ERROR_WRITING_SECTIONNAME As Short = 25682
	Public Const ERROR_WRITING_DEVICETYPE As Short = 25683
	Public Const ERROR_WRITING_DEVICENAME As Short = 25684
	Public Const ERROR_WRITING_MAXCONNECTBPS As Short = 25685
	Public Const ERROR_WRITING_MAXCARRIERBPS As Short = 25686
	Public Const ERROR_WRITING_USAGE As Short = 25687
	Public Const ERROR_WRITING_DEFAULTOFF As Short = 25688
	Public Const ERROR_READING_DEFAULTOFF As Short = 25689
	Public Const ERROR_EMPTY_INI_FILE As Short = 25690
	Public Const ERROR_AUTHENTICATION_FAILURE As Short = 25691
	Public Const ERROR_PORT_OR_DEVICE As Short = 25692
	Public Const ERROR_NOT_BINARY_MACRO As Short = 25693
	Public Const ERROR_DCB_NOT_FOUND As Short = 25694
	Public Const ERROR_STATE_MACHINES_NOT_STARTED As Short = 25695
	Public Const ERROR_STATE_MACHINES_ALREADY_STARTED As Short = 25696
	Public Const ERROR_PARTIAL_RESPONSE_LOOPING As Short = 25697
	Public Const ERROR_UNKNOWN_RESPONSE_KEY As Short = 25698
	Public Const ERROR_RECV_BUF_FULL As Short = 25699
	Public Const ERROR_CMD_TOO_LONG As Short = 25700
	Public Const ERROR_UNSUPPORTED_BPS As Short = 25701
	Public Const ERROR_UNEXPECTED_RESPONSE As Short = 25702
	Public Const ERROR_INTERACTIVE_MODE As Short = 25703
	Public Const ERROR_BAD_CALLBACK_NUMBER As Short = 25704
	Public Const ERROR_INVALID_AUTH_STATE As Short = 25705
	Public Const ERROR_WRITING_INITBPS As Short = 25706
	Public Const ERROR_X25_DIAGNOSTIC As Short = 25707
	Public Const ERROR_ACCT_EXPIRED As Short = 25708
	Public Const ERROR_CHANGING_PASSWORD As Short = 25709
	Public Const ERROR_OVERRUN As Short = 25710
	Public Const ERROR_RASMAN_CANNOT_INITIALIZE As Short = 25711
	Public Const ERROR_BIPLEX_PORT_NOT_AVAILABLE As Short = 25712
	Public Const ERROR_NO_ACTIVE_ISDN_LINES As Short = 25713
	Public Const ERROR_NO_ISDN_CHANNELS_AVAILABLE As Short = 25714
	Public Const ERROR_TOO_MANY_LINE_ERRORS As Short = 25715
	Public Const ERROR_IP_CONFIGURATION As Short = 25716
	Public Const ERROR_NO_IP_ADDRESSES As Short = 25717
	Public Const ERROR_PPP_TIMEOUT As Short = 25718
	Public Const ERROR_PPP_REMOTE_TERMINATED As Short = 25719
	Public Const ERROR_PPP_NO_PROTOCOLS_CONFIGURED As Short = 25720
	Public Const ERROR_PPP_NO_RESPONSE As Short = 25721
	Public Const ERROR_PPP_INVALID_PACKET As Short = 25722
	Public Const ERROR_PHONE_NUMBER_TOO_LONG As Short = 25723
	Public Const ERROR_IPXCP_NO_DIALOUT_CONFIGURED As Short = 25724
	Public Const ERROR_IPXCP_NO_DIALIN_CONFIGURED As Short = 25725
	Public Const ERROR_IPXCP_DIALOUT_ALREADY_ACTIVE As Short = 25726
	Public Const ERROR_ACCESSING_TCPCFGDLL As Short = 25727
	Public Const ERROR_NO_IP_RAS_ADAPTER As Short = 25728
	Public Const ERROR_SLIP_REQUIRES_IP As Short = 25729
	Public Const ERROR_PROJECTION_NOT_COMPLETE As Short = 25730
	Public Const ERROR_PROTOCOL_NOT_CONFIGURED As Short = 25731
	Public Const ERROR_PPP_NOT_CONVERGING As Short = 25732
	Public Const ERROR_PPP_CP_REJECTED As Short = 25733
	Public Const ERROR_PPP_LCP_TERMINATED As Short = 25734
	Public Const ERROR_PPP_REQUIRED_ADDRESS_REJECTED As Short = 25735
	Public Const ERROR_PPP_NCP_TERMINATED As Short = 25736
	Public Const ERROR_PPP_LOOPBACK_DETECTED As Short = 25737
	Public Const ERROR_PPP_NO_ADDRESS_ASSIGNED As Short = 25738
	Public Const ERROR_CANNOT_USE_LOGON_CREDENTIALS As Short = 25739
	Public Const ERROR_TAPI_CONFIGURATION As Short = 25740
	Public Const ERROR_NO_LOCAL_ENCRYPTION As Short = 25741
	Public Const ERROR_NO_REMOTE_ENCRYPTION As Short = 25742
	Public Const ERROR_REMOTE_REQUIRES_ENCRYPTION As Short = 25743
	Public Const ERROR_IPXCP_NET_NUMBER_CONFLICT As Short = 25744
	Public Const ERROR_INVALID_SMM As Short = 25745
	Public Const ERROR_SMM_UNINITIALIZED As Short = 25746
	Public Const ERROR_NO_MAC_FOR_PORT As Short = 25747
	Public Const ERROR_SMM_TIMEOUT As Short = 25748
	Public Const ERROR_BAD_PHONE_NUMBER As Short = 25749
	Public Const ERROR_WRONG_MODULE As Short = 25750
	Public Const ERROR_INVALID_CALLBACK_NUMBER As Short = 25751
	Public Const ERROR_SCRIPT_SYNTAX As Short = 25752
	Public Const ERROR_HANGUP_FAILED As Short = 25753
	Public Const ERROR_BUNDLE_NOT_FOUND As Short = 25754
	Public Const ERROR_CANNOT_DO_CUSTOMDIAL As Short = 25755
	Public Const ERROR_DIAL_ALREADY_IN_PROGRESS As Short = 25756
	Public Const ERROR_RASAUTO_CANNOT_INITIALIZE As Short = 25757
	Public Const ERROR_CONNECTION_ALREADY_SHARED As Short = 25758
	Public Const ERROR_SHARING_CHANGE_FAILED As Short = 25759
	Public Const ERROR_SHARING_ROUTER_INSTALL As Short = 25760
	Public Const ERROR_SHARE_CONNECTION_FAILED As Short = 25761
	Public Const ERROR_SHARING_PRIVATE_INSTALL As Short = 25762
	Public Const ERROR_CANNOT_SHARE_CONNECTION As Short = 25763
	Public Const ERROR_NO_SMART_CARD_READER As Short = 25764
	Public Const ERROR_SHARING_ADDRESS_EXISTS As Short = 25765
	Public Const ERROR_NO_CERTIFICATE As Short = 25766
	Public Const ERROR_SHARING_MULTIPLE_ADDRESSES As Short = 25767
	Public Const ERROR_FAILED_TO_ENCRYPT As Short = 25768
	Public Const ERROR_BAD_ADDRESS_SPECIFIED As Short = 25769
	Public Const ERROR_CONNECTION_REJECT As Short = 25770
	Public Const ERROR_CONGESTION As Short = 25771
	Public Const ERROR_INCOMPATIBLE As Short = 25772
	Public Const ERROR_NUMBERCHANGED As Short = 25773
	Public Const ERROR_TEMPFAILURE As Short = 25774
	Public Const ERROR_BLOCKED As Short = 25775
	Public Const ERROR_DONOTDISTURB As Short = 25776
	Public Const ERROR_OUTOFORDER As Short = 25777
	Public Const ERROR_UNABLE_TO_AUTHENTICATE_SERVER As Short = 25778
	Public Const ERROR_SMART_CARD_REQUIRED As Short = 25779
	Public Const ERROR_INVALID_FUNCTION_FOR_ENTRY As Short = 25780
	Public Const ERROR_CERT_FOR_ENCRYPTION_NOT_FOUND As Short = 25781
	Public Const ERROR_SHARING_RRAS_CONFLICT As Short = 25782
	Public Const ERROR_SHARING_NO_PRIVATE_LAN As Short = 25783
	Public Const ERROR_NO_DIFF_USER_AT_LOGON As Short = 25784
	Public Const ERROR_NO_REG_CERT_AT_LOGON As Short = 25785
	Public Const ERROR_OAKLEY_NO_CERT As Short = 25786
	Public Const ERROR_OAKLEY_AUTH_FAIL As Short = 25787
	Public Const ERROR_OAKLEY_ATTRIB_FAIL As Short = 25788
	Public Const ERROR_OAKLEY_GENERAL_PROCESSING As Short = 25789
	Public Const ERROR_OAKLEY_NO_PEER_CERT As Short = 25790
	Public Const ERROR_OAKLEY_NO_POLICY As Short = 25791
	Public Const ERROR_OAKLEY_TIMED_OUT As Short = 25792
	Public Const ERROR_OAKLEY_ERROR As Short = 25793
	Public Const ERROR_UNKNOWN_FRAMED_PROTOCOL As Short = 25794
	Public Const ERROR_WRONG_TUNNEL_TYPE As Short = 25795
	Public Const ERROR_UNKNOWN_SERVICE_TYPE As Short = 25796
	Public Const ERROR_CONNECTING_DEVICE_NOT_FOUND As Short = 25797
	Public Const ERROR_NO_EAPTLS_CERTIFICATE As Short = 25798
	
	
	'
	' File Encoding Constants
	'
	' File encoding and decoding constants for use with the DecodeFileEx
	' and EncodeFileEx functions
	'
	Public Const FILE_ENCODE_DEFAULT As Short = 0
	Public Const FILE_ENCODE_UUCODE As Short = 1
	Public Const FILE_ENCODE_BASE64 As Short = 2
	Public Const FILE_ENCODE_COMPRESSED As Integer = 65536
End Module