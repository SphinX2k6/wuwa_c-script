using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019FF RID: 6655
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroNetwork.KuroTcpClient")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UKuroTcpClient : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018AC5 RID: 101061 RVA: 0x00246305 File Offset: 0x00244505
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTcpClient._ClassPtr;
		}

		// Token: 0x06018AC6 RID: 101062 RVA: 0x00246314 File Offset: 0x00244514
		public UKuroTcpClient() : this(BuiltinUtils.AllocNativeUObject(UKuroTcpClient.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018AC7 RID: 101063 RVA: 0x0024633C File Offset: 0x0024453C
		public UKuroTcpClient(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTcpClient.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006214 RID: 25108
		// (get) Token: 0x06018AC8 RID: 101064 RVA: 0x0024636F File Offset: 0x0024456F
		// (set) Token: 0x06018AC9 RID: 101065 RVA: 0x0024637F File Offset: 0x0024457F
		public unsafe bool IsTickDrivenOutside
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTcpClient.__PropertyOffset_IsTickDrivenOutside) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTcpClient.__PropertyOffset_IsTickDrivenOutside) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006215 RID: 25109
		// (get) Token: 0x06018ACA RID: 101066 RVA: 0x00246390 File Offset: 0x00244590
		// (set) Token: 0x06018ACB RID: 101067 RVA: 0x002463C9 File Offset: 0x002445C9
		public TArray<byte> RecvData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._RecvData) == null)
				{
					result = (this._RecvData = new TArray<byte>(base.NativePtr + (IntPtr)UKuroTcpClient.__PropertyOffset_RecvData, this));
				}
				return result;
			}
			set
			{
				this.RecvData.CopyAssign(value);
			}
		}

		// Token: 0x06018ACC RID: 101068 RVA: 0x002463D7 File Offset: 0x002445D7
		public void TickOutside(float DeltaSeconds)
		{
			UKuroTcpClient.__TickOutside_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06018ACD RID: 101069 RVA: 0x002463E5 File Offset: 0x002445E5
		public void ShutDownSocket()
		{
			UKuroTcpClient.__ShutDownSocket_Internal(base.NativePtr);
		}

		// Token: 0x06018ACE RID: 101070 RVA: 0x002463F2 File Offset: 0x002445F2
		[NullableContext(2)]
		public void Send(in TArray<byte> Data)
		{
			UKuroTcpClient.__Send_Internal(base.NativePtr, (Data ?? new TArray<byte>()).NativePtr);
		}

		// Token: 0x06018ACF RID: 101071 RVA: 0x0024640F File Offset: 0x0024460F
		public void Disconnect()
		{
			UKuroTcpClient.__Disconnect_Internal(base.NativePtr);
		}

		// Token: 0x06018AD0 RID: 101072 RVA: 0x0024641C File Offset: 0x0024461C
		public unsafe void Connect(string Addr, int Port)
		{
			FString fstring = FString.AllocTemp(Addr);
			UKuroTcpClient.__Connect_Internal(base.NativePtr, fstring, Port);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06018AD1 RID: 101073 RVA: 0x00246447 File Offset: 0x00244647
		public void CloseSocket()
		{
			UKuroTcpClient.__CloseSocket_Internal(base.NativePtr);
		}

		// Token: 0x06018AD2 RID: 101074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TickOutside_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x06018AD3 RID: 101075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShutDownSocket_Internal(IntPtr @this);

		// Token: 0x06018AD4 RID: 101076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Send_Internal(IntPtr @this, IntPtr Data);

		// Token: 0x06018AD5 RID: 101077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Disconnect_Internal(IntPtr @this);

		// Token: 0x06018AD6 RID: 101078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Connect_Internal(IntPtr @this, in FString Addr, int Port);

		// Token: 0x06018AD7 RID: 101079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CloseSocket_Internal(IntPtr @this);

		// Token: 0x06018AD8 RID: 101080 RVA: 0x00246454 File Offset: 0x00244654
		static UKuroTcpClient()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroTcpClient");
		}

		// Token: 0x06018AD9 RID: 101081 RVA: 0x00246462 File Offset: 0x00244662
		protected UKuroTcpClient(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D54A RID: 54602
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroTcpClient";

		// Token: 0x0400D54B RID: 54603
		private static IntPtr _ClassPtr;

		// Token: 0x0400D54C RID: 54604
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D54D RID: 54605
		internal static int __PropertyOffset_IsTickDrivenOutside;

		// Token: 0x0400D54E RID: 54606
		internal static int __PropertyOffset_RecvData;

		// Token: 0x0400D54F RID: 54607
		[Nullable(2)]
		private TArray<byte> _RecvData;
	}
}
