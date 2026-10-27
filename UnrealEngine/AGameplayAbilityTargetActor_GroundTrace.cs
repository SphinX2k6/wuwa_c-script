using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200135A RID: 4954
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityTargetActor_GroundTrace")]
	[UnrealStructLayout(1408, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1408)]
	public class AGameplayAbilityTargetActor_GroundTrace : AGameplayAbilityTargetActor_Trace, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060122E2 RID: 74466 RVA: 0x001AB18C File Offset: 0x001A938C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameplayAbilityTargetActor_GroundTrace._ClassPtr;
		}

		// Token: 0x060122E3 RID: 74467 RVA: 0x001AB198 File Offset: 0x001A9398
		public AGameplayAbilityTargetActor_GroundTrace() : this(BuiltinUtils.AllocNativeUObject(AGameplayAbilityTargetActor_GroundTrace.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060122E4 RID: 74468 RVA: 0x001AB1C0 File Offset: 0x001A93C0
		[NullableContext(1)]
		public AGameplayAbilityTargetActor_GroundTrace(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGameplayAbilityTargetActor_GroundTrace.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170046D5 RID: 18133
		// (get) Token: 0x060122E5 RID: 74469 RVA: 0x001AB1F3 File Offset: 0x001A93F3
		// (set) Token: 0x060122E6 RID: 74470 RVA: 0x001AB203 File Offset: 0x001A9403
		public unsafe float CollisionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor_GroundTrace.__PropertyOffset_CollisionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor_GroundTrace.__PropertyOffset_CollisionRadius) = value;
			}
		}

		// Token: 0x170046D6 RID: 18134
		// (get) Token: 0x060122E7 RID: 74471 RVA: 0x001AB214 File Offset: 0x001A9414
		// (set) Token: 0x060122E8 RID: 74472 RVA: 0x001AB224 File Offset: 0x001A9424
		public unsafe float CollisionHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor_GroundTrace.__PropertyOffset_CollisionHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor_GroundTrace.__PropertyOffset_CollisionHeight) = value;
			}
		}

		// Token: 0x060122E9 RID: 74473 RVA: 0x001AB235 File Offset: 0x001A9435
		static AGameplayAbilityTargetActor_GroundTrace()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayAbilityTargetActor_GroundTrace");
		}

		// Token: 0x060122EA RID: 74474 RVA: 0x001AB243 File Offset: 0x001A9443
		protected AGameplayAbilityTargetActor_GroundTrace(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009BD3 RID: 39891
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityTargetActor_GroundTrace";

		// Token: 0x04009BD4 RID: 39892
		private static IntPtr _ClassPtr;

		// Token: 0x04009BD5 RID: 39893
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009BD6 RID: 39894
		internal static int __PropertyOffset_CollisionRadius;

		// Token: 0x04009BD7 RID: 39895
		internal static int __PropertyOffset_CollisionHeight;
	}
}
