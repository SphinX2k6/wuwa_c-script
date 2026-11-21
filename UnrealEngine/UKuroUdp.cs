using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000484 RID: 1156
	[UnrealObjectPath("/Script/KuroNetwork.KuroUdp")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroUdp : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006D2D RID: 27949 RVA: 0x0009F82F File Offset: 0x0009DA2F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroUdp._ClassPtr;
		}

		// Token: 0x06006D2E RID: 27950 RVA: 0x0009F83C File Offset: 0x0009DA3C
		public UKuroUdp() : this(BuiltinUtils.AllocNativeUObject(UKuroUdp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006D2F RID: 27951 RVA: 0x0009F864 File Offset: 0x0009DA64
		[NullableContext(1)]
		public UKuroUdp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroUdp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006D30 RID: 27952 RVA: 0x0009F898 File Offset: 0x0009DA98
		[NullableContext(1)]
		public unsafe static void SendUdpMessage(string Ip, int Port, string Message, int MaxRecvSize, [Nullable(2)] FUdpDelegate Callback)
		{
			FString fstring = FString.AllocTemp(Ip);
			FString fstring2 = FString.AllocTemp(Message);
			UKuroUdp.__SendUdpMessage_Internal(fstring, Port, fstring2, MaxRecvSize, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06006D31 RID: 27953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SendUdpMessage_Internal(in FString Ip, int Port, in FString Message, int MaxRecvSize, IntPtr Callback);

		// Token: 0x06006D32 RID: 27954 RVA: 0x0009F8DF File Offset: 0x0009DADF
		static UKuroUdp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroUdp");
		}

		// Token: 0x06006D33 RID: 27955 RVA: 0x0009F8ED File Offset: 0x0009DAED
		protected UKuroUdp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E9D RID: 11933
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroUdp";

		// Token: 0x04002E9E RID: 11934
		private static IntPtr _ClassPtr;

		// Token: 0x04002E9F RID: 11935
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
