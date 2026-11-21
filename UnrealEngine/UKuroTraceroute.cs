using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000483 RID: 1155
	[UnrealObjectPath("/Script/KuroNetwork.KuroTraceroute")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroTraceroute : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006D24 RID: 27940 RVA: 0x0009F76A File Offset: 0x0009D96A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTraceroute._ClassPtr;
		}

		// Token: 0x06006D25 RID: 27941 RVA: 0x0009F778 File Offset: 0x0009D978
		public UKuroTraceroute() : this(BuiltinUtils.AllocNativeUObject(UKuroTraceroute.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006D26 RID: 27942 RVA: 0x0009F7A0 File Offset: 0x0009D9A0
		[NullableContext(1)]
		public UKuroTraceroute(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTraceroute.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006D27 RID: 27943 RVA: 0x0009F7D4 File Offset: 0x0009D9D4
		[NullableContext(1)]
		public unsafe void Traceroute(string Target, [Nullable(2)] FTracerouteDelegate Callback)
		{
			FString fstring = FString.AllocTemp(Target);
			UKuroTraceroute.__Traceroute_Internal(base.NativePtr, fstring, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06006D28 RID: 27944 RVA: 0x0009F80B File Offset: 0x0009DA0B
		public void Abort()
		{
			UKuroTraceroute.__Abort_Internal(base.NativePtr);
		}

		// Token: 0x06006D29 RID: 27945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Traceroute_Internal(IntPtr @this, in FString Target, IntPtr Callback);

		// Token: 0x06006D2A RID: 27946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Abort_Internal(IntPtr @this);

		// Token: 0x06006D2B RID: 27947 RVA: 0x0009F818 File Offset: 0x0009DA18
		static UKuroTraceroute()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroTraceroute");
		}

		// Token: 0x06006D2C RID: 27948 RVA: 0x0009F826 File Offset: 0x0009DA26
		protected UKuroTraceroute(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E9A RID: 11930
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroTraceroute";

		// Token: 0x04002E9B RID: 11931
		private static IntPtr _ClassPtr;

		// Token: 0x04002E9C RID: 11932
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
