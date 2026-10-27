using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001354 RID: 4948
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilitySpecContainer")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class FGameplayAbilitySpecContainer : FFastArraySerializer, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012285 RID: 74373 RVA: 0x001AA994 File Offset: 0x001A8B94
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilitySpecContainer._ScriptStructPtr != 0) ? FGameplayAbilitySpecContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilitySpecContainer", ref FGameplayAbilitySpecContainer._ScriptStructPtr);
		}

		// Token: 0x170046BD RID: 18109
		// (get) Token: 0x06012286 RID: 74374 RVA: 0x001AA9B8 File Offset: 0x001A8BB8
		// (set) Token: 0x06012287 RID: 74375 RVA: 0x001AA9FB File Offset: 0x001A8BFB
		public TArray<FGameplayAbilitySpec> Items
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayAbilitySpec> result;
				if ((result = this._Items) == null)
				{
					result = (this._Items = new TArray<FGameplayAbilitySpec>(base.NativePtr + (IntPtr)FGameplayAbilitySpecContainer.__PropertyOffset_Items, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Items.CopyAssign(value);
			}
		}

		// Token: 0x170046BE RID: 18110
		// (get) Token: 0x06012288 RID: 74376 RVA: 0x001AAA09 File Offset: 0x001A8C09
		// (set) Token: 0x06012289 RID: 74377 RVA: 0x001AAA1D File Offset: 0x001A8C1D
		[Nullable(2)]
		public unsafe UAbilitySystemComponent Owner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilitySpecContainer.__PropertyOffset_Owner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilitySpecContainer.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x0601228A RID: 74378 RVA: 0x001AAA32 File Offset: 0x001A8C32
		public FGameplayAbilitySpecContainer()
		{
		}

		// Token: 0x0601228B RID: 74379 RVA: 0x001AAA3A File Offset: 0x001A8C3A
		public FGameplayAbilitySpecContainer(TArray<FGameplayAbilitySpec> Items, UAbilitySystemComponent Owner, int ArrayReplicationKey, EFastArraySerializerDeltaFlags DeltaFlags)
		{
			this.Items = Items;
			this.Owner = Owner;
			base.ArrayReplicationKey = ArrayReplicationKey;
			base.DeltaFlags = DeltaFlags;
		}

		// Token: 0x0601228C RID: 74380 RVA: 0x001AAA5F File Offset: 0x001A8C5F
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilitySpecContainer.StaticStruct();
		}

		// Token: 0x0601228D RID: 74381 RVA: 0x001AAA6B File Offset: 0x001A8C6B
		[NullableContext(2)]
		public FGameplayAbilitySpecContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601228E RID: 74382 RVA: 0x001AAA75 File Offset: 0x001A8C75
		public FGameplayAbilitySpecContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601228F RID: 74383 RVA: 0x001AAA80 File Offset: 0x001A8C80
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilitySpecContainer(Pointer, false, true);
		}

		// Token: 0x06012290 RID: 74384 RVA: 0x001AAA8A File Offset: 0x001A8C8A
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilitySpecContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04009BA6 RID: 39846
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilitySpecContainer";

		// Token: 0x04009BA7 RID: 39847
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009BA8 RID: 39848
		internal static int __PropertyOffset_Items;

		// Token: 0x04009BA9 RID: 39849
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayAbilitySpec> _Items;

		// Token: 0x04009BAA RID: 39850
		internal static int __PropertyOffset_Owner;
	}
}
