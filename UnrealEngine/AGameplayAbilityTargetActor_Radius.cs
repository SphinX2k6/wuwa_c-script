using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200135B RID: 4955
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityTargetActor_Radius")]
	[UnrealStructLayout(1344, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1344)]
	public class AGameplayAbilityTargetActor_Radius : AGameplayAbilityTargetActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060122EB RID: 74475 RVA: 0x001AB24C File Offset: 0x001A944C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameplayAbilityTargetActor_Radius._ClassPtr;
		}

		// Token: 0x060122EC RID: 74476 RVA: 0x001AB258 File Offset: 0x001A9458
		public AGameplayAbilityTargetActor_Radius() : this(BuiltinUtils.AllocNativeUObject(AGameplayAbilityTargetActor_Radius.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060122ED RID: 74477 RVA: 0x001AB280 File Offset: 0x001A9480
		[NullableContext(1)]
		public AGameplayAbilityTargetActor_Radius(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGameplayAbilityTargetActor_Radius.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170046D7 RID: 18135
		// (get) Token: 0x060122EE RID: 74478 RVA: 0x001AB2B3 File Offset: 0x001A94B3
		// (set) Token: 0x060122EF RID: 74479 RVA: 0x001AB2C3 File Offset: 0x001A94C3
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor_Radius.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor_Radius.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x060122F0 RID: 74480 RVA: 0x001AB2D4 File Offset: 0x001A94D4
		static AGameplayAbilityTargetActor_Radius()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayAbilityTargetActor_Radius");
		}

		// Token: 0x060122F1 RID: 74481 RVA: 0x001AB2E2 File Offset: 0x001A94E2
		protected AGameplayAbilityTargetActor_Radius(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009BD8 RID: 39896
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityTargetActor_Radius";

		// Token: 0x04009BD9 RID: 39897
		private static IntPtr _ClassPtr;

		// Token: 0x04009BDA RID: 39898
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009BDB RID: 39899
		internal static int __PropertyOffset_Radius;
	}
}
