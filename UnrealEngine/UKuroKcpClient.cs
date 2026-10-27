using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019F9 RID: 6649
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroNetwork.KuroKcpClient")]
	[UnrealStructLayout(984, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 984)]
	public class UKuroKcpClient : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018A39 RID: 100921 RVA: 0x002455ED File Offset: 0x002437ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroKcpClient._ClassPtr;
		}

		// Token: 0x06018A3A RID: 100922 RVA: 0x002455FC File Offset: 0x002437FC
		public UKuroKcpClient() : this(BuiltinUtils.AllocNativeUObject(UKuroKcpClient.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018A3B RID: 100923 RVA: 0x00245624 File Offset: 0x00243824
		public UKuroKcpClient(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroKcpClient.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061FE RID: 25086
		// (get) Token: 0x06018A3C RID: 100924 RVA: 0x00245658 File Offset: 0x00243858
		// (set) Token: 0x06018A3D RID: 100925 RVA: 0x00245691 File Offset: 0x00243891
		public FOnKcpConnectSuccessDelegate OnConnectSuccess
		{
			get
			{
				base.FastCheckIsValid();
				FOnKcpConnectSuccessDelegate result;
				if ((result = this._OnConnectSuccess) == null)
				{
					result = (this._OnConnectSuccess = new FOnKcpConnectSuccessDelegate(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnConnectSuccess, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnConnectSuccess, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170061FF RID: 25087
		// (get) Token: 0x06018A3E RID: 100926 RVA: 0x002456B4 File Offset: 0x002438B4
		// (set) Token: 0x06018A3F RID: 100927 RVA: 0x002456ED File Offset: 0x002438ED
		public FOnReceivedResponseDelegate OnRecResp
		{
			get
			{
				base.FastCheckIsValid();
				FOnReceivedResponseDelegate result;
				if ((result = this._OnRecResp) == null)
				{
					result = (this._OnRecResp = new FOnReceivedResponseDelegate(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnRecResp, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnRecResp, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006200 RID: 25088
		// (get) Token: 0x06018A40 RID: 100928 RVA: 0x00245710 File Offset: 0x00243910
		// (set) Token: 0x06018A41 RID: 100929 RVA: 0x00245749 File Offset: 0x00243949
		public FOnReceivedExceptionDelegate OnRecException
		{
			get
			{
				base.FastCheckIsValid();
				FOnReceivedExceptionDelegate result;
				if ((result = this._OnRecException) == null)
				{
					result = (this._OnRecException = new FOnReceivedExceptionDelegate(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnRecException, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnRecException, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006201 RID: 25089
		// (get) Token: 0x06018A42 RID: 100930 RVA: 0x0024576C File Offset: 0x0024396C
		// (set) Token: 0x06018A43 RID: 100931 RVA: 0x002457A5 File Offset: 0x002439A5
		public FOnReceivedPushDelegate OnRecPush
		{
			get
			{
				base.FastCheckIsValid();
				FOnReceivedPushDelegate result;
				if ((result = this._OnRecPush) == null)
				{
					result = (this._OnRecPush = new FOnReceivedPushDelegate(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnRecPush, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnRecPush, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006202 RID: 25090
		// (get) Token: 0x06018A44 RID: 100932 RVA: 0x002457C8 File Offset: 0x002439C8
		// (set) Token: 0x06018A45 RID: 100933 RVA: 0x00245801 File Offset: 0x00243A01
		public FOnReceivedTcpExceptionDelegate OnRecTcpException
		{
			get
			{
				base.FastCheckIsValid();
				FOnReceivedTcpExceptionDelegate result;
				if ((result = this._OnRecTcpException) == null)
				{
					result = (this._OnRecTcpException = new FOnReceivedTcpExceptionDelegate(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnRecTcpException, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnRecTcpException, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006203 RID: 25091
		// (get) Token: 0x06018A46 RID: 100934 RVA: 0x00245824 File Offset: 0x00243A24
		// (set) Token: 0x06018A47 RID: 100935 RVA: 0x0024585D File Offset: 0x00243A5D
		public FOnError OnError
		{
			get
			{
				base.FastCheckIsValid();
				FOnError result;
				if ((result = this._OnError) == null)
				{
					result = (this._OnError = new FOnError(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnError, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnError, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006204 RID: 25092
		// (get) Token: 0x06018A48 RID: 100936 RVA: 0x0024587E File Offset: 0x00243A7E
		// (set) Token: 0x06018A49 RID: 100937 RVA: 0x0024588E File Offset: 0x00243A8E
		public unsafe uint RemoteMtu
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_RemoteMtu);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_RemoteMtu) = (int)value;
			}
		}

		// Token: 0x17006205 RID: 25093
		// (get) Token: 0x06018A4A RID: 100938 RVA: 0x0024589F File Offset: 0x00243A9F
		// (set) Token: 0x06018A4B RID: 100939 RVA: 0x002458AF File Offset: 0x00243AAF
		public unsafe bool UseNewResolveIp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_UseNewResolveIp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_UseNewResolveIp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006206 RID: 25094
		// (get) Token: 0x06018A4C RID: 100940 RVA: 0x002458C0 File Offset: 0x00243AC0
		// (set) Token: 0x06018A4D RID: 100941 RVA: 0x002458D0 File Offset: 0x00243AD0
		public unsafe bool IsMultiThreaded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_IsMultiThreaded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_IsMultiThreaded) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006207 RID: 25095
		// (get) Token: 0x06018A4E RID: 100942 RVA: 0x002458E1 File Offset: 0x00243AE1
		// (set) Token: 0x06018A4F RID: 100943 RVA: 0x002458F1 File Offset: 0x00243AF1
		public unsafe bool IsTickDrivenOutside
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_IsTickDrivenOutside) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_IsTickDrivenOutside) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006208 RID: 25096
		// (get) Token: 0x06018A50 RID: 100944 RVA: 0x00245902 File Offset: 0x00243B02
		// (set) Token: 0x06018A51 RID: 100945 RVA: 0x00245912 File Offset: 0x00243B12
		public unsafe bool OpenSendVerify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OpenSendVerify) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OpenSendVerify) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006209 RID: 25097
		// (get) Token: 0x06018A52 RID: 100946 RVA: 0x00245924 File Offset: 0x00243B24
		// (set) Token: 0x06018A53 RID: 100947 RVA: 0x0024595D File Offset: 0x00243B5D
		public FOnKcpConnectTcpSuccessDelegate OnTcpConnected
		{
			get
			{
				base.FastCheckIsValid();
				FOnKcpConnectTcpSuccessDelegate result;
				if ((result = this._OnTcpConnected) == null)
				{
					result = (this._OnTcpConnected = new FOnKcpConnectTcpSuccessDelegate(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnTcpConnected, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnTcpConnected, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700620A RID: 25098
		// (get) Token: 0x06018A54 RID: 100948 RVA: 0x00245980 File Offset: 0x00243B80
		// (set) Token: 0x06018A55 RID: 100949 RVA: 0x002459B9 File Offset: 0x00243BB9
		public FOnKcpConnectTcpFailedDelegate OnTcpConnectFailed
		{
			get
			{
				base.FastCheckIsValid();
				FOnKcpConnectTcpFailedDelegate result;
				if ((result = this._OnTcpConnectFailed) == null)
				{
					result = (this._OnTcpConnectFailed = new FOnKcpConnectTcpFailedDelegate(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnTcpConnectFailed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroKcpClient.__PropertyOffset_OnTcpConnectFailed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700620B RID: 25099
		// (get) Token: 0x06018A56 RID: 100950 RVA: 0x002459DA File Offset: 0x00243BDA
		// (set) Token: 0x06018A57 RID: 100951 RVA: 0x002459EE File Offset: 0x00243BEE
		[Nullable(2)]
		public unsafe UKuroTcpClient TcpClient
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroTcpClient>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroKcpClient.__PropertyOffset_TcpClient);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroKcpClient.__PropertyOffset_TcpClient, value);
			}
		}

		// Token: 0x06018A58 RID: 100952 RVA: 0x00245A03 File Offset: 0x00243C03
		public void TickOutside(float DeltaSeconds)
		{
			UKuroKcpClient.__TickOutside_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06018A59 RID: 100953 RVA: 0x00245A14 File Offset: 0x00243C14
		public unsafe void StartTcpConnect(string Addr, int Port)
		{
			FString fstring = FString.AllocTemp(Addr);
			UKuroKcpClient.__StartTcpConnect_Internal(base.NativePtr, fstring, Port);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06018A5A RID: 100954 RVA: 0x00245A3F File Offset: 0x00243C3F
		public void SetKcpWndSize(int SndWnd, int RcvWnd)
		{
			UKuroKcpClient.__SetKcpWndSize_Internal(base.NativePtr, SndWnd, RcvWnd);
		}

		// Token: 0x06018A5B RID: 100955 RVA: 0x00245A4E File Offset: 0x00243C4E
		public void SetKcpStream(bool bStream)
		{
			UKuroKcpClient.__SetKcpStream_Internal(base.NativePtr, bStream);
		}

		// Token: 0x06018A5C RID: 100956 RVA: 0x00245A5C File Offset: 0x00243C5C
		public void SetKcpSegmentSize(int SegmentSize)
		{
			UKuroKcpClient.__SetKcpSegmentSize_Internal(base.NativePtr, SegmentSize);
		}

		// Token: 0x06018A5D RID: 100957 RVA: 0x00245A6A File Offset: 0x00243C6A
		public void SetKcpNoDelay(int NoDelay, int Interval, int Resend, int Nc)
		{
			UKuroKcpClient.__SetKcpNoDelay_Internal(base.NativePtr, NoDelay, Interval, Resend, Nc);
		}

		// Token: 0x06018A5E RID: 100958 RVA: 0x00245A7C File Offset: 0x00243C7C
		public void SetKcpMtu(int Mtu)
		{
			UKuroKcpClient.__SetKcpMtu_Internal(base.NativePtr, Mtu);
		}

		// Token: 0x06018A5F RID: 100959 RVA: 0x00245A8A File Offset: 0x00243C8A
		public bool SetK(byte Type, in FArrayBuffer KeyBuffer)
		{
			return UKuroKcpClient.__SetK_Internal(base.NativePtr, Type, KeyBuffer);
		}

		// Token: 0x06018A60 RID: 100960 RVA: 0x00245A99 File Offset: 0x00243C99
		public void SetEnType(byte Type, short MsgId)
		{
			UKuroKcpClient.__SetEnType_Internal(base.NativePtr, Type, MsgId);
		}

		// Token: 0x06018A61 RID: 100961 RVA: 0x00245AA8 File Offset: 0x00243CA8
		public void SendTcpMessage(short RpcId, short MsgId, in FArrayBuffer ArrayBuffer)
		{
			UKuroKcpClient.__SendTcpMessage_Internal(base.NativePtr, RpcId, MsgId, ArrayBuffer);
		}

		// Token: 0x06018A62 RID: 100962 RVA: 0x00245AB8 File Offset: 0x00243CB8
		public bool SendM(sbyte MsgType, int SeqNo, short RpcId, short MsgId, in FArrayBuffer ArrayBuffer, bool UseKcp)
		{
			return UKuroKcpClient.__SendM_Internal(base.NativePtr, MsgType, SeqNo, RpcId, MsgId, ArrayBuffer, UseKcp);
		}

		// Token: 0x06018A63 RID: 100963 RVA: 0x00245ACE File Offset: 0x00243CCE
		public bool IsTcpConnectStart()
		{
			return UKuroKcpClient.__IsTcpConnectStart_Internal(base.NativePtr);
		}

		// Token: 0x06018A64 RID: 100964 RVA: 0x00245ADB File Offset: 0x00243CDB
		public void HandleTcpConnectFailed()
		{
			UKuroKcpClient.__HandleTcpConnectFailed_Internal(base.NativePtr);
		}

		// Token: 0x06018A65 RID: 100965 RVA: 0x00245AE8 File Offset: 0x00243CE8
		public void HandleTcpConnected()
		{
			UKuroKcpClient.__HandleTcpConnected_Internal(base.NativePtr);
		}

		// Token: 0x06018A66 RID: 100966 RVA: 0x00245AF5 File Offset: 0x00243CF5
		public void HandleKcpConnect(uint NeedCrcCheck, uint Conv)
		{
			UKuroKcpClient.__HandleKcpConnect_Internal(base.NativePtr, NeedCrcCheck, Conv);
		}

		// Token: 0x06018A67 RID: 100967 RVA: 0x00245B04 File Offset: 0x00243D04
		public unsafe string GetDebugString(in FArrayBuffer ArrayBuffer, string Separator, short MsgId, int SeqNo)
		{
			FString fstring = FString.AllocTemp(Separator);
			string result = FString.ToStringAndDeleteNativePtr(UKuroKcpClient.__GetDebugString_Internal(base.NativePtr, ArrayBuffer, fstring, MsgId, SeqNo));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06018A68 RID: 100968 RVA: 0x00245B38 File Offset: 0x00243D38
		public unsafe bool DoConnect(string Addr, int Port, bool CrcCheckDisable, bool bAddTraceId)
		{
			FString fstring = FString.AllocTemp(Addr);
			bool result = UKuroKcpClient.__DoConnect_Internal(base.NativePtr, fstring, Port, CrcCheckDisable, bAddTraceId);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06018A69 RID: 100969 RVA: 0x00245B66 File Offset: 0x00243D66
		public void Disconnect()
		{
			UKuroKcpClient.__Disconnect_Internal(base.NativePtr);
		}

		// Token: 0x06018A6A RID: 100970 RVA: 0x00245B74 File Offset: 0x00243D74
		public unsafe bool Connect(string Addr, int Port, bool CrcCheckDisable)
		{
			FString fstring = FString.AllocTemp(Addr);
			bool result = UKuroKcpClient.__Connect_Internal(base.NativePtr, fstring, Port, CrcCheckDisable);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06018A6B RID: 100971 RVA: 0x00245BA0 File Offset: 0x00243DA0
		public void CloseTcpConnect()
		{
			UKuroKcpClient.__CloseTcpConnect_Internal(base.NativePtr);
		}

		// Token: 0x06018A6C RID: 100972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TickOutside_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x06018A6D RID: 100973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartTcpConnect_Internal(IntPtr @this, in FString Addr, int Port);

		// Token: 0x06018A6E RID: 100974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKcpWndSize_Internal(IntPtr @this, int SndWnd, int RcvWnd);

		// Token: 0x06018A6F RID: 100975
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKcpStream_Internal(IntPtr @this, bool bStream);

		// Token: 0x06018A70 RID: 100976
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKcpSegmentSize_Internal(IntPtr @this, int SegmentSize);

		// Token: 0x06018A71 RID: 100977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKcpNoDelay_Internal(IntPtr @this, int NoDelay, int Interval, int Resend, int Nc);

		// Token: 0x06018A72 RID: 100978
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKcpMtu_Internal(IntPtr @this, int Mtu);

		// Token: 0x06018A73 RID: 100979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetK_Internal(IntPtr @this, byte Type, in FArrayBuffer KeyBuffer);

		// Token: 0x06018A74 RID: 100980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnType_Internal(IntPtr @this, byte Type, short MsgId);

		// Token: 0x06018A75 RID: 100981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SendTcpMessage_Internal(IntPtr @this, short RpcId, short MsgId, in FArrayBuffer ArrayBuffer);

		// Token: 0x06018A76 RID: 100982
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SendM_Internal(IntPtr @this, sbyte MsgType, int SeqNo, short RpcId, short MsgId, in FArrayBuffer ArrayBuffer, bool UseKcp);

		// Token: 0x06018A77 RID: 100983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsTcpConnectStart_Internal(IntPtr @this);

		// Token: 0x06018A78 RID: 100984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleTcpConnectFailed_Internal(IntPtr @this);

		// Token: 0x06018A79 RID: 100985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleTcpConnected_Internal(IntPtr @this);

		// Token: 0x06018A7A RID: 100986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleKcpConnect_Internal(IntPtr @this, uint NeedCrcCheck, uint Conv);

		// Token: 0x06018A7B RID: 100987
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDebugString_Internal(IntPtr @this, in FArrayBuffer ArrayBuffer, in FString Separator, short MsgId, int SeqNo);

		// Token: 0x06018A7C RID: 100988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoConnect_Internal(IntPtr @this, in FString Addr, int Port, bool CrcCheckDisable, bool bAddTraceId);

		// Token: 0x06018A7D RID: 100989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Disconnect_Internal(IntPtr @this);

		// Token: 0x06018A7E RID: 100990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Connect_Internal(IntPtr @this, in FString Addr, int Port, bool CrcCheckDisable);

		// Token: 0x06018A7F RID: 100991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CloseTcpConnect_Internal(IntPtr @this);

		// Token: 0x06018A80 RID: 100992 RVA: 0x00245BAD File Offset: 0x00243DAD
		static UKuroKcpClient()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroKcpClient");
		}

		// Token: 0x06018A81 RID: 100993 RVA: 0x00245BBB File Offset: 0x00243DBB
		protected UKuroKcpClient(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D515 RID: 54549
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroKcpClient";

		// Token: 0x0400D516 RID: 54550
		private static IntPtr _ClassPtr;

		// Token: 0x0400D517 RID: 54551
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D518 RID: 54552
		internal static int __PropertyOffset_OnConnectSuccess;

		// Token: 0x0400D519 RID: 54553
		[Nullable(2)]
		private FOnKcpConnectSuccessDelegate _OnConnectSuccess;

		// Token: 0x0400D51A RID: 54554
		internal static int __PropertyOffset_OnRecResp;

		// Token: 0x0400D51B RID: 54555
		[Nullable(2)]
		private FOnReceivedResponseDelegate _OnRecResp;

		// Token: 0x0400D51C RID: 54556
		internal static int __PropertyOffset_OnRecException;

		// Token: 0x0400D51D RID: 54557
		[Nullable(2)]
		private FOnReceivedExceptionDelegate _OnRecException;

		// Token: 0x0400D51E RID: 54558
		internal static int __PropertyOffset_OnRecPush;

		// Token: 0x0400D51F RID: 54559
		[Nullable(2)]
		private FOnReceivedPushDelegate _OnRecPush;

		// Token: 0x0400D520 RID: 54560
		internal static int __PropertyOffset_OnRecTcpException;

		// Token: 0x0400D521 RID: 54561
		[Nullable(2)]
		private FOnReceivedTcpExceptionDelegate _OnRecTcpException;

		// Token: 0x0400D522 RID: 54562
		internal static int __PropertyOffset_OnError;

		// Token: 0x0400D523 RID: 54563
		[Nullable(2)]
		private FOnError _OnError;

		// Token: 0x0400D524 RID: 54564
		internal static int __PropertyOffset_RemoteMtu;

		// Token: 0x0400D525 RID: 54565
		internal static int __PropertyOffset_UseNewResolveIp;

		// Token: 0x0400D526 RID: 54566
		internal static int __PropertyOffset_IsMultiThreaded;

		// Token: 0x0400D527 RID: 54567
		internal static int __PropertyOffset_IsTickDrivenOutside;

		// Token: 0x0400D528 RID: 54568
		internal static int __PropertyOffset_OpenSendVerify;

		// Token: 0x0400D529 RID: 54569
		internal static int __PropertyOffset_OnTcpConnected;

		// Token: 0x0400D52A RID: 54570
		[Nullable(2)]
		private FOnKcpConnectTcpSuccessDelegate _OnTcpConnected;

		// Token: 0x0400D52B RID: 54571
		internal static int __PropertyOffset_OnTcpConnectFailed;

		// Token: 0x0400D52C RID: 54572
		[Nullable(2)]
		private FOnKcpConnectTcpFailedDelegate _OnTcpConnectFailed;

		// Token: 0x0400D52D RID: 54573
		internal static int __PropertyOffset_TcpClient;
	}
}
