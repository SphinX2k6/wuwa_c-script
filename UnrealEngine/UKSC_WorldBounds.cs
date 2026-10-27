using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E5E RID: 7774
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_WorldBounds")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKSC_WorldBounds : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DA0E RID: 121358 RVA: 0x002BBDF4 File Offset: 0x002B9FF4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_WorldBounds._ClassPtr;
		}

		// Token: 0x0601DA0F RID: 121359 RVA: 0x002BBE00 File Offset: 0x002BA000
		public UKSC_WorldBounds() : this(BuiltinUtils.AllocNativeUObject(UKSC_WorldBounds.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DA10 RID: 121360 RVA: 0x002BBE28 File Offset: 0x002BA028
		[NullableContext(1)]
		public UKSC_WorldBounds(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_WorldBounds.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DA11 RID: 121361 RVA: 0x002BBE5B File Offset: 0x002BA05B
		static UKSC_WorldBounds()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_WorldBounds");
		}

		// Token: 0x0601DA12 RID: 121362 RVA: 0x002BBE69 File Offset: 0x002BA069
		protected UKSC_WorldBounds(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040100E4 RID: 65764
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_WorldBounds";

		// Token: 0x040100E5 RID: 65765
		private static IntPtr _ClassPtr;

		// Token: 0x040100E6 RID: 65766
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
