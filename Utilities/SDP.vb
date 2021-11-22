Public Class SDP


	Dim vErsion As Integer = 0          'v=  (protocol version number, currently only 0)
	Dim oRiginator As OriginatorInfo            'o=- 2 0 IN IP4 192.168.110.178 (originator And session identifier : username, id, version number, network address)

	Class OriginatorInfo
		Dim username As Integer
		Dim id As Integer
		Dim versionNumber As String
		Dim NetworkAddress As String
	End Class

	Dim sEssion As String               's=WardBeck 32ME  s=  (session name : mandatory with at least one UTF-8-encoded character)
	Dim tIme As Integer                 't=0 0    t=  (time the session Is active)

	Dim eMail As String '				e=* (zero Or more email address With Optional name Of contacts)
	Dim pHone As String                 'p=* (zero or more phone number with optional name of contacts)

	Dim aClockDomain As String          'a=clock-domain:PTPv2 0     a=* (attribute)
	Dim mAusio As String                'm=audio 50000 RTP/AVP 98    m=  (media name And transport address)
	Dim cOnnection As CONNECTIONINFO                     'c=In IP4 239.30.178.1/1    c=* (connection information/TTL) 

	Class CONNECTIONINFO
		Dim Direction As String
		Dim Protocol As String
		Dim MulticastAddress As String
		Dim TTL As Integer
	End Class

	Dim aRtpmap As RTPMAP            'a=rtpmap:98 L24/48000/8a=* (attribute)

	Class RTPMAP
		Dim Profile As Integer
		Dim Bitrate As Integer
		Dim SampleRate As Integer
		Dim ChannelWidth As Integer = 2
		Dim Channel(ChannelWidth) As Integer
	End Class

	Dim aRecvonlya As Boolean           'a=recvonlya=* (attribute)
	Dim aFramecount As Integer          'a=framecount:48a=* (attribute)
	Dim aSyncTime As Integer            'a=sync-time:0a=* (attribute)
	Dim aPtime As Integer               'a=ptime:1a=* (attribute: Packet Time)a=ts-refclk:ptp=IEEE1588-2008:EC-46-70-FF-FE-00-8F-C8:0a=* (attribute)
	Dim aMediaclk As Integer            'a=mediaclk:direct=0a=* (attribute)




End Class
