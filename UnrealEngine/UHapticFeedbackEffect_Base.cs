using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C15 RID: 3093
	[UnrealObjectPath("/Script/Engine.HapticFeedbackEffect_Base")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UHapticFeedbackEffect_Base : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009C5B RID: 40027 RVA: 0x000DE54E File Offset: 0x000DC74E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHapticFeedbackEffect_Base._ClassPtr;
		}

		// Token: 0x06009C5C RID: 40028 RVA: 0x000DE55C File Offset: 0x000DC75C
		public UHapticFeedbackEffect_Base() : this(BuiltinUtils.AllocNativeUObject(UHapticFeedbackEffect_Base.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009C5D RID: 40029 RVA: 0x000DE584 File Offset: 0x000DC784
		[NullableContext(1)]
		public UHapticFeedbackEffect_Base(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHapticFeedbackEffect_Base.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06009C5E RID: 40030 RVA: 0x000DE5B7 File Offset: 0x000DC7B7
		static UHapticFeedbackEffect_Base()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HapticFeedbackEffect_Base");
		}

		// Token: 0x06009C5F RID: 40031 RVA: 0x000DE5C5 File Offset: 0x000DC7C5
		protected UHapticFeedbackEffect_Base(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400564B RID: 22091
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HapticFeedbackEffect_Base";

		// Token: 0x0400564C RID: 22092
		private static IntPtr _ClassPtr;

		// Token: 0x0400564D RID: 22093
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
