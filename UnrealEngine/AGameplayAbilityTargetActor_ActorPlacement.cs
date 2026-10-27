using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001359 RID: 4953
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityTargetActor_ActorPlacement")]
	[UnrealStructLayout(1424, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1424)]
	public class AGameplayAbilityTargetActor_ActorPlacement : AGameplayAbilityTargetActor_GroundTrace, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060122D9 RID: 74457 RVA: 0x001AB0B9 File Offset: 0x001A92B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameplayAbilityTargetActor_ActorPlacement._ClassPtr;
		}

		// Token: 0x060122DA RID: 74458 RVA: 0x001AB0C8 File Offset: 0x001A92C8
		public AGameplayAbilityTargetActor_ActorPlacement() : this(BuiltinUtils.AllocNativeUObject(AGameplayAbilityTargetActor_ActorPlacement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060122DB RID: 74459 RVA: 0x001AB0F0 File Offset: 0x001A92F0
		[NullableContext(1)]
		public AGameplayAbilityTargetActor_ActorPlacement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGameplayAbilityTargetActor_ActorPlacement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170046D3 RID: 18131
		// (get) Token: 0x060122DC RID: 74460 RVA: 0x001AB123 File Offset: 0x001A9323
		// (set) Token: 0x060122DD RID: 74461 RVA: 0x001AB137 File Offset: 0x001A9337
		public unsafe UClassStackOnlyPtr PlacedActorClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor_ActorPlacement.__PropertyOffset_PlacedActorClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor_ActorPlacement.__PropertyOffset_PlacedActorClass) = value;
			}
		}

		// Token: 0x170046D4 RID: 18132
		// (get) Token: 0x060122DE RID: 74462 RVA: 0x001AB14C File Offset: 0x001A934C
		// (set) Token: 0x060122DF RID: 74463 RVA: 0x001AB160 File Offset: 0x001A9360
		[Nullable(2)]
		public unsafe UMaterialInterface PlacedActorMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityTargetActor_ActorPlacement.__PropertyOffset_PlacedActorMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityTargetActor_ActorPlacement.__PropertyOffset_PlacedActorMaterial, value);
			}
		}

		// Token: 0x060122E0 RID: 74464 RVA: 0x001AB175 File Offset: 0x001A9375
		static AGameplayAbilityTargetActor_ActorPlacement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayAbilityTargetActor_ActorPlacement");
		}

		// Token: 0x060122E1 RID: 74465 RVA: 0x001AB183 File Offset: 0x001A9383
		protected AGameplayAbilityTargetActor_ActorPlacement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009BCE RID: 39886
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityTargetActor_ActorPlacement";

		// Token: 0x04009BCF RID: 39887
		private static IntPtr _ClassPtr;

		// Token: 0x04009BD0 RID: 39888
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009BD1 RID: 39889
		internal static int __PropertyOffset_PlacedActorClass;

		// Token: 0x04009BD2 RID: 39890
		internal static int __PropertyOffset_PlacedActorMaterial;
	}
}
