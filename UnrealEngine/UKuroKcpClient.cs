using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200047F RID: 1151
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroNetwork.KuroKcpClient")]
	[UnrealStructLayout(984, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 984)]
	public class UKuroKcpClient : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006CB6 RID: 27830 RVA: 0x0009EDE9 File Offset: 0x0009CFE9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroKcpClient._ClassPtr;
		}

		// Token: 0x06006CB7 RID: 27831 RVA: 0x0009EDF8 File Offset: 0x0009CFF8
		public UKuroKcpClient() : this(BuiltinUtils.AllocNativeUObject(UKuroKcpClient.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006CB8 RID: 27832 RVA: 0x0009EE20 File Offset: 0x0009D020
		public UKuroKcpClient(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroKcpClient.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06006CB9 RID: 27833 RVA: 0x0009EE54 File Offset: 0x0009D054
		// (set) Token: 0x06006CBA RID: 27834 RVA: 0x0009EE8D File Offset: 0x0009D08D
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

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06006CBB RID: 27835 RVA: 0x0009EEB0 File Offset: 0x0009D0B0
		// (set) Token: 0x06006CBC RID: 27836 RVA: 0x0009EEE9 File Offset: 0x0009D0E9
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

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06006CBD RID: 27837 RVA: 0x0009EF0C File Offset: 0x0009D10C
		// (set) Token: 0x06006CBE RID: 27838 RVA: 0x0009EF45 File Offset: 0x0009D145
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

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06006CBF RID: 27839 RVA: 0x0009EF68 File Offset: 0x0009D168
		// (set) Token: 0x06006CC0 RID: 27840 RVA: 0x0009EFA1 File Offset: 0x0009D1A1
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

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06006CC1 RID: 27841 RVA: 0x0009EFC4 File Offset: 0x0009D1C4
		// (set) Token: 0x06006CC2 RID: 27842 RVA: 0x0009EFFD File Offset: 0x0009D1FD
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

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06006CC3 RID: 27843 RVA: 0x0009F020 File Offset: 0x0009D220
		// (set) Token: 0x06006CC4 RID: 27844 RVA: 0x0009F059 File Offset: 0x0009D259
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

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06006CC5 RID: 27845 RVA: 0x0009F07A File Offset: 0x0009D27A
		// (set) Token: 0x06006CC6 RID: 27846 RVA: 0x0009F08A File Offset: 0x0009D28A
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

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06006CC7 RID: 27847 RVA: 0x0009F09B File Offset: 0x0009D29B
		// (set) Token: 0x06006CC8 RID: 27848 RVA: 0x0009F0AB File Offset: 0x0009D2AB
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

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06006CC9 RID: 27849 RVA: 0x0009F0BC File Offset: 0x0009D2BC
		// (set) Token: 0x06006CCA RID: 27850 RVA: 0x0009F0CC File Offset: 0x0009D2CC
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

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06006CCB RID: 27851 RVA: 0x0009F0DD File Offset: 0x0009D2DD
		// (set) Token: 0x06006CCC RID: 27852 RVA: 0x0009F0ED File Offset: 0x0009D2ED
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

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06006CCD RID: 27853 RVA: 0x0009F0FE File Offset: 0x0009D2FE
		// (set) Token: 0x06006CCE RID: 27854 RVA: 0x0009F10E File Offset: 0x0009D30E
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

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06006CCF RID: 27855 RVA: 0x0009F120 File Offset: 0x0009D320
		// (set) Token: 0x06006CD0 RID: 27856 RVA: 0x0009F159 File Offset: 0x0009D359
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

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x06006CD1 RID: 27857 RVA: 0x0009F17C File Offset: 0x0009D37C
		// (set) Token: 0x06006CD2 RID: 27858 RVA: 0x0009F1B5 File Offset: 0x0009D3B5
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

		// Token: 0x06006CD3 RID: 27859 RVA: 0x0009F1D6 File Offset: 0x0009D3D6
		public void TickOutside(float DeltaSeconds)
		{
			UKuroKcpClient.__TickOutside_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06006CD4 RID: 27860 RVA: 0x0009F1E4 File Offset: 0x0009D3E4
		public unsafe void StartTcpConnect(string Addr, int Port)
		{
			FString fstring = FString.AllocTemp(Addr);
			UKuroKcpClient.__StartTcpConnect_Internal(base.NativePtr, fstring, Port);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06006CD5 RID: 27861 RVA: 0x0009F20F File Offset: 0x0009D40F
		public void SetKcpWndSize(int SndWnd, int RcvWnd)
		{
			UKuroKcpClient.__SetKcpWndSize_Internal(base.NativePtr, SndWnd, RcvWnd);
		}

		// Token: 0x06006CD6 RID: 27862 RVA: 0x0009F21E File Offset: 0x0009D41E
		public void SetKcpStream(bool bStream)
		{
			UKuroKcpClient.__SetKcpStream_Internal(base.NativePtr, bStream);
		}

		// Token: 0x06006CD7 RID: 27863 RVA: 0x0009F22C File Offset: 0x0009D42C
		public void SetKcpSegmentSize(int SegmentSize)
		{
			UKuroKcpClient.__SetKcpSegmentSize_Internal(base.NativePtr, SegmentSize);
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x0009F23A File Offset: 0x0009D43A
		public void SetKcpNoDelay(int NoDelay, int Interval, int Resend, int Nc)
		{
			UKuroKcpClient.__SetKcpNoDelay_Internal(base.NativePtr, NoDelay, Interval, Resend, Nc);
		}

		// Token: 0x06006CD9 RID: 27865 RVA: 0x0009F24C File Offset: 0x0009D44C
		public void SetKcpMtu(int Mtu)
		{
			UKuroKcpClient.__SetKcpMtu_Internal(base.NativePtr, Mtu);
		}

		// Token: 0x06006CDA RID: 27866 RVA: 0x0009F25A File Offset: 0x0009D45A
		public bool SetK(byte Type, in FArrayBuffer KeyBuffer)
		{
			return UKuroKcpClient.__SetK_Internal(base.NativePtr, Type, KeyBuffer);
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x0009F269 File Offset: 0x0009D469
		public void SetEnType(byte Type, short MsgId)
		{
			UKuroKcpClient.__SetEnType_Internal(base.NativePtr, Type, MsgId);
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x0009F278 File Offset: 0x0009D478
		public void SendTcpMessage(short RpcId, short MsgId, in FArrayBuffer ArrayBuffer)
		{
			UKuroKcpClient.__SendTcpMessage_Internal(base.NativePtr, RpcId, MsgId, ArrayBuffer);
		}

		// Token: 0x06006CDD RID: 27869 RVA: 0x0009F288 File Offset: 0x0009D488
		public bool SendM(sbyte MsgType, int SeqNo, short RpcId, short MsgId, in FArrayBuffer ArrayBuffer, bool UseKcp)
		{
			return UKuroKcpClient.__SendM_Internal(base.NativePtr, MsgType, SeqNo, RpcId, MsgId, ArrayBuffer, UseKcp);
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x0009F29E File Offset: 0x0009D49E
		public bool IsTcpConnectStart()
		{
			return UKuroKcpClient.__IsTcpConnectStart_Internal(base.NativePtr);
		}

		// Token: 0x06006CDF RID: 27871 RVA: 0x0009F2AB File Offset: 0x0009D4AB
		public void HandleTcpConnectFailed()
		{
			UKuroKcpClient.__HandleTcpConnectFailed_Internal(base.NativePtr);
		}

		// Token: 0x06006CE0 RID: 27872 RVA: 0x0009F2B8 File Offset: 0x0009D4B8
		public void HandleTcpConnected()
		{
			UKuroKcpClient.__HandleTcpConnected_Internal(base.NativePtr);
		}

		// Token: 0x06006CE1 RID: 27873 RVA: 0x0009F2C5 File Offset: 0x0009D4C5
		public void HandleKcpConnect(uint NeedCrcCheck, uint Conv)
		{
			UKuroKcpClient.__HandleKcpConnect_Internal(base.NativePtr, NeedCrcCheck, Conv);
		}

		// Token: 0x06006CE2 RID: 27874 RVA: 0x0009F2D4 File Offset: 0x0009D4D4
		public unsafe string GetDebugString(in FArrayBuffer ArrayBuffer, string Separator, short MsgId, int SeqNo)
		{
			FString fstring = FString.AllocTemp(Separator);
			string result = FString.ToStringAndDeleteNativePtr(UKuroKcpClient.__GetDebugString_Internal(base.NativePtr, ArrayBuffer, fstring, MsgId, SeqNo));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006CE3 RID: 27875 RVA: 0x0009F308 File Offset: 0x0009D508
		public unsafe bool DoConnect(string Addr, int Port, bool CrcCheckDisable, bool bAddTraceId)
		{
			FString fstring = FString.AllocTemp(Addr);
			bool result = UKuroKcpClient.__DoConnect_Internal(base.NativePtr, fstring, Port, CrcCheckDisable, bAddTraceId);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006CE4 RID: 27876 RVA: 0x0009F336 File Offset: 0x0009D536
		public void Disconnect()
		{
			UKuroKcpClient.__Disconnect_Internal(base.NativePtr);
		}

		// Token: 0x06006CE5 RID: 27877 RVA: 0x0009F344 File Offset: 0x0009D544
		public unsafe bool Connect(string Addr, int Port, bool CrcCheckDisable)
		{
			FString fstring = FString.AllocTemp(Addr);
			bool result = UKuroKcpClient.__Connect_Internal(base.NativePtr, fstring, Port, CrcCheckDisable);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006CE6 RID: 27878 RVA: 0x0009F370 File Offset: 0x0009D570
		public void CloseTcpConnect()
		{
			UKuroKcpClient.__CloseTcpConnect_Internal(base.NativePtr);
		}

		// Token: 0x06006CE7 RID: 27879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TickOutside_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x06006CE8 RID: 27880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartTcpConnect_Internal(IntPtr @this, in FString Addr, int Port);

		// Token: 0x06006CE9 RID: 27881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKcpWndSize_Internal(IntPtr @this, int SndWnd, int RcvWnd);

		// Token: 0x06006CEA RID: 27882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKcpStream_Internal(IntPtr @this, bool bStream);

		// Token: 0x06006CEB RID: 27883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKcpSegmentSize_Internal(IntPtr @this, int SegmentSize);

		// Token: 0x06006CEC RID: 27884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKcpNoDelay_Internal(IntPtr @this, int NoDelay, int Interval, int Resend, int Nc);

		// Token: 0x06006CED RID: 27885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKcpMtu_Internal(IntPtr @this, int Mtu);

		// Token: 0x06006CEE RID: 27886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetK_Internal(IntPtr @this, byte Type, in FArrayBuffer KeyBuffer);

		// Token: 0x06006CEF RID: 27887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnType_Internal(IntPtr @this, byte Type, short MsgId);

		// Token: 0x06006CF0 RID: 27888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SendTcpMessage_Internal(IntPtr @this, short RpcId, short MsgId, in FArrayBuffer ArrayBuffer);

		// Token: 0x06006CF1 RID: 27889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SendM_Internal(IntPtr @this, sbyte MsgType, int SeqNo, short RpcId, short MsgId, in FArrayBuffer ArrayBuffer, bool UseKcp);

		// Token: 0x06006CF2 RID: 27890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsTcpConnectStart_Internal(IntPtr @this);

		// Token: 0x06006CF3 RID: 27891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleTcpConnectFailed_Internal(IntPtr @this);

		// Token: 0x06006CF4 RID: 27892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleTcpConnected_Internal(IntPtr @this);

		// Token: 0x06006CF5 RID: 27893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleKcpConnect_Internal(IntPtr @this, uint NeedCrcCheck, uint Conv);

		// Token: 0x06006CF6 RID: 27894
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDebugString_Internal(IntPtr @this, in FArrayBuffer ArrayBuffer, in FString Separator, short MsgId, int SeqNo);

		// Token: 0x06006CF7 RID: 27895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoConnect_Internal(IntPtr @this, in FString Addr, int Port, bool CrcCheckDisable, bool bAddTraceId);

		// Token: 0x06006CF8 RID: 27896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Disconnect_Internal(IntPtr @this);

		// Token: 0x06006CF9 RID: 27897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Connect_Internal(IntPtr @this, in FString Addr, int Port, bool CrcCheckDisable);

		// Token: 0x06006CFA RID: 27898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CloseTcpConnect_Internal(IntPtr @this);

		// Token: 0x06006CFB RID: 27899 RVA: 0x0009F37D File Offset: 0x0009D57D
		static UKuroKcpClient()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroKcpClient");
		}

		// Token: 0x06006CFC RID: 27900 RVA: 0x0009F38B File Offset: 0x0009D58B
		protected UKuroKcpClient(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E77 RID: 11895
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroKcpClient";

		// Token: 0x04002E78 RID: 11896
		private static IntPtr _ClassPtr;

		// Token: 0x04002E79 RID: 11897
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002E7A RID: 11898
		internal static int __PropertyOffset_OnConnectSuccess;

		// Token: 0x04002E7B RID: 11899
		[Nullable(2)]
		private FOnKcpConnectSuccessDelegate _OnConnectSuccess;

		// Token: 0x04002E7C RID: 11900
		internal static int __PropertyOffset_OnRecResp;

		// Token: 0x04002E7D RID: 11901
		[Nullable(2)]
		private FOnReceivedResponseDelegate _OnRecResp;

		// Token: 0x04002E7E RID: 11902
		internal static int __PropertyOffset_OnRecException;

		// Token: 0x04002E7F RID: 11903
		[Nullable(2)]
		private FOnReceivedExceptionDelegate _OnRecException;

		// Token: 0x04002E80 RID: 11904
		internal static int __PropertyOffset_OnRecPush;

		// Token: 0x04002E81 RID: 11905
		[Nullable(2)]
		private FOnReceivedPushDelegate _OnRecPush;

		// Token: 0x04002E82 RID: 11906
		internal static int __PropertyOffset_OnRecTcpException;

		// Token: 0x04002E83 RID: 11907
		[Nullable(2)]
		private FOnReceivedTcpExceptionDelegate _OnRecTcpException;

		// Token: 0x04002E84 RID: 11908
		internal static int __PropertyOffset_OnError;

		// Token: 0x04002E85 RID: 11909
		[Nullable(2)]
		private FOnError _OnError;

		// Token: 0x04002E86 RID: 11910
		internal static int __PropertyOffset_RemoteMtu;

		// Token: 0x04002E87 RID: 11911
		internal static int __PropertyOffset_UseNewResolveIp;

		// Token: 0x04002E88 RID: 11912
		internal static int __PropertyOffset_IsMultiThreaded;

		// Token: 0x04002E89 RID: 11913
		internal static int __PropertyOffset_IsTickDrivenOutside;

		// Token: 0x04002E8A RID: 11914
		internal static int __PropertyOffset_OpenSendVerify;

		// Token: 0x04002E8B RID: 11915
		internal static int __PropertyOffset_OnTcpConnected;

		// Token: 0x04002E8C RID: 11916
		[Nullable(2)]
		private FOnKcpConnectTcpSuccessDelegate _OnTcpConnected;

		// Token: 0x04002E8D RID: 11917
		internal static int __PropertyOffset_OnTcpConnectFailed;

		// Token: 0x04002E8E RID: 11918
		[Nullable(2)]
		private FOnKcpConnectTcpFailedDelegate _OnTcpConnectFailed;
	}
}
