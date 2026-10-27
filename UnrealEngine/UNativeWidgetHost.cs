using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002992 RID: 10642
	[UnrealObjectPath("/Script/UMG.NativeWidgetHost")]
	[UnrealStructLayout(672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class UNativeWidgetHost : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027646 RID: 161350 RVA: 0x003C0ED2 File Offset: 0x003BF0D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNativeWidgetHost._ClassPtr;
		}

		// Token: 0x06027647 RID: 161351 RVA: 0x003C0EE0 File Offset: 0x003BF0E0
		public UNativeWidgetHost() : this(BuiltinUtils.AllocNativeUObject(UNativeWidgetHost.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027648 RID: 161352 RVA: 0x003C0F08 File Offset: 0x003BF108
		[NullableContext(1)]
		public UNativeWidgetHost(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNativeWidgetHost.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027649 RID: 161353 RVA: 0x003C0F3B File Offset: 0x003BF13B
		static UNativeWidgetHost()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.NativeWidgetHost");
		}

		// Token: 0x0602764A RID: 161354 RVA: 0x003C0F49 File Offset: 0x003BF149
		protected UNativeWidgetHost(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015A1B RID: 88603
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.NativeWidgetHost";

		// Token: 0x04015A1C RID: 88604
		private static IntPtr _ClassPtr;

		// Token: 0x04015A1D RID: 88605
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
