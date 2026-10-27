using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A00 RID: 6656
	[UnrealObjectPath("/Script/KuroNetwork.KuroTraceroute")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroTraceroute : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018ADA RID: 101082 RVA: 0x0024646B File Offset: 0x0024466B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTraceroute._ClassPtr;
		}

		// Token: 0x06018ADB RID: 101083 RVA: 0x00246478 File Offset: 0x00244678
		public UKuroTraceroute() : this(BuiltinUtils.AllocNativeUObject(UKuroTraceroute.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018ADC RID: 101084 RVA: 0x002464A0 File Offset: 0x002446A0
		[NullableContext(1)]
		public UKuroTraceroute(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTraceroute.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018ADD RID: 101085 RVA: 0x002464D4 File Offset: 0x002446D4
		[NullableContext(1)]
		public unsafe void Traceroute(string Target, [Nullable(2)] FTracerouteDelegate Callback)
		{
			FString fstring = FString.AllocTemp(Target);
			UKuroTraceroute.__Traceroute_Internal(base.NativePtr, fstring, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06018ADE RID: 101086 RVA: 0x0024650B File Offset: 0x0024470B
		public void Abort()
		{
			UKuroTraceroute.__Abort_Internal(base.NativePtr);
		}

		// Token: 0x06018ADF RID: 101087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Traceroute_Internal(IntPtr @this, in FString Target, IntPtr Callback);

		// Token: 0x06018AE0 RID: 101088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Abort_Internal(IntPtr @this);

		// Token: 0x06018AE1 RID: 101089 RVA: 0x00246518 File Offset: 0x00244718
		static UKuroTraceroute()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroTraceroute");
		}

		// Token: 0x06018AE2 RID: 101090 RVA: 0x00246526 File Offset: 0x00244726
		protected UKuroTraceroute(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D550 RID: 54608
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroTraceroute";

		// Token: 0x0400D551 RID: 54609
		private static IntPtr _ClassPtr;

		// Token: 0x0400D552 RID: 54610
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
