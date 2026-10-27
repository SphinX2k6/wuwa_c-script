using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A01 RID: 6657
	[UnrealObjectPath("/Script/KuroNetwork.KuroUdp")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroUdp : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018AE3 RID: 101091 RVA: 0x0024652F File Offset: 0x0024472F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroUdp._ClassPtr;
		}

		// Token: 0x06018AE4 RID: 101092 RVA: 0x0024653C File Offset: 0x0024473C
		public UKuroUdp() : this(BuiltinUtils.AllocNativeUObject(UKuroUdp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018AE5 RID: 101093 RVA: 0x00246564 File Offset: 0x00244764
		[NullableContext(1)]
		public UKuroUdp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroUdp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018AE6 RID: 101094 RVA: 0x00246598 File Offset: 0x00244798
		[NullableContext(1)]
		public unsafe static void SendUdpMessage(string Ip, int Port, string Message, int MaxRecvSize, [Nullable(2)] FUdpDelegate Callback)
		{
			FString fstring = FString.AllocTemp(Ip);
			FString fstring2 = FString.AllocTemp(Message);
			UKuroUdp.__SendUdpMessage_Internal(fstring, Port, fstring2, MaxRecvSize, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06018AE7 RID: 101095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SendUdpMessage_Internal(in FString Ip, int Port, in FString Message, int MaxRecvSize, IntPtr Callback);

		// Token: 0x06018AE8 RID: 101096 RVA: 0x002465DF File Offset: 0x002447DF
		static UKuroUdp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroUdp");
		}

		// Token: 0x06018AE9 RID: 101097 RVA: 0x002465ED File Offset: 0x002447ED
		protected UKuroUdp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D553 RID: 54611
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroUdp";

		// Token: 0x0400D554 RID: 54612
		private static IntPtr _ClassPtr;

		// Token: 0x0400D555 RID: 54613
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
