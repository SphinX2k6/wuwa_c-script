using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B1C RID: 6940
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGrassInteractionWorldSubsystem")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroGrassInteractionWorldSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A1CC RID: 106956 RVA: 0x00268A1C File Offset: 0x00266C1C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGrassInteractionWorldSubsystem._ClassPtr;
		}

		// Token: 0x0601A1CD RID: 106957 RVA: 0x00268A28 File Offset: 0x00266C28
		public UKuroGrassInteractionWorldSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroGrassInteractionWorldSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A1CE RID: 106958 RVA: 0x00268A50 File Offset: 0x00266C50
		[NullableContext(1)]
		public UKuroGrassInteractionWorldSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGrassInteractionWorldSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601A1CF RID: 106959 RVA: 0x00268A83 File Offset: 0x00266C83
		static UKuroGrassInteractionWorldSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGrassInteractionWorldSubsystem");
		}

		// Token: 0x0601A1D0 RID: 106960 RVA: 0x00268A91 File Offset: 0x00266C91
		protected UKuroGrassInteractionWorldSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E2DE RID: 58078
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGrassInteractionWorldSubsystem";

		// Token: 0x0400E2DF RID: 58079
		private static IntPtr _ClassPtr;

		// Token: 0x0400E2E0 RID: 58080
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
