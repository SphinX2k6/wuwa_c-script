using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001365 RID: 4965
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityWorldReticle_ActorVisualization")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1096)]
	public class AGameplayAbilityWorldReticle_ActorVisualization : AGameplayAbilityWorldReticle, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012366 RID: 74598 RVA: 0x001ABC10 File Offset: 0x001A9E10
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameplayAbilityWorldReticle_ActorVisualization._ClassPtr;
		}

		// Token: 0x06012367 RID: 74599 RVA: 0x001ABC1C File Offset: 0x001A9E1C
		public AGameplayAbilityWorldReticle_ActorVisualization() : this(BuiltinUtils.AllocNativeUObject(AGameplayAbilityWorldReticle_ActorVisualization.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012368 RID: 74600 RVA: 0x001ABC44 File Offset: 0x001A9E44
		public AGameplayAbilityWorldReticle_ActorVisualization(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGameplayAbilityWorldReticle_ActorVisualization.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170046EE RID: 18158
		// (get) Token: 0x06012369 RID: 74601 RVA: 0x001ABC77 File Offset: 0x001A9E77
		// (set) Token: 0x0601236A RID: 74602 RVA: 0x001ABC8B File Offset: 0x001A9E8B
		[Nullable(2)]
		public unsafe UCapsuleComponent CollisionComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityWorldReticle_ActorVisualization.__PropertyOffset_CollisionComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityWorldReticle_ActorVisualization.__PropertyOffset_CollisionComponent, value);
			}
		}

		// Token: 0x170046EF RID: 18159
		// (get) Token: 0x0601236B RID: 74603 RVA: 0x001ABCA0 File Offset: 0x001A9EA0
		// (set) Token: 0x0601236C RID: 74604 RVA: 0x001ABCD9 File Offset: 0x001A9ED9
		public TArray<UActorComponent> VisualizationComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UActorComponent> result;
				if ((result = this._VisualizationComponents) == null)
				{
					result = (this._VisualizationComponents = new TArray<UActorComponent>(base.NativePtr + (IntPtr)AGameplayAbilityWorldReticle_ActorVisualization.__PropertyOffset_VisualizationComponents, this));
				}
				return result;
			}
			set
			{
				this.VisualizationComponents.CopyAssign(value);
			}
		}

		// Token: 0x0601236D RID: 74605 RVA: 0x001ABCE7 File Offset: 0x001A9EE7
		static AGameplayAbilityWorldReticle_ActorVisualization()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayAbilityWorldReticle_ActorVisualization");
		}

		// Token: 0x0601236E RID: 74606 RVA: 0x001ABCF5 File Offset: 0x001A9EF5
		protected AGameplayAbilityWorldReticle_ActorVisualization(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009C0E RID: 39950
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityWorldReticle_ActorVisualization";

		// Token: 0x04009C0F RID: 39951
		private static IntPtr _ClassPtr;

		// Token: 0x04009C10 RID: 39952
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009C11 RID: 39953
		internal static int __PropertyOffset_CollisionComponent;

		// Token: 0x04009C12 RID: 39954
		internal static int __PropertyOffset_VisualizationComponents;

		// Token: 0x04009C13 RID: 39955
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _VisualizationComponents;
	}
}
