using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001322 RID: 4898
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.ActiveGameplayEffectsContainer")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1216)]
	public class FActiveGameplayEffectsContainer : FFastArraySerializer, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060120AE RID: 73902 RVA: 0x001A7E22 File Offset: 0x001A6022
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActiveGameplayEffectsContainer._ScriptStructPtr != 0) ? FActiveGameplayEffectsContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.ActiveGameplayEffectsContainer", ref FActiveGameplayEffectsContainer._ScriptStructPtr);
		}

		// Token: 0x1700465A RID: 18010
		// (get) Token: 0x060120AF RID: 73903 RVA: 0x001A7E48 File Offset: 0x001A6048
		// (set) Token: 0x060120B0 RID: 73904 RVA: 0x001A7E8B File Offset: 0x001A608B
		public TArray<FActiveGameplayEffect> GameplayEffects_Internal
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FActiveGameplayEffect> result;
				if ((result = this._GameplayEffects_Internal) == null)
				{
					result = (this._GameplayEffects_Internal = new TArray<FActiveGameplayEffect>(base.NativePtr + (IntPtr)FActiveGameplayEffectsContainer.__PropertyOffset_GameplayEffects_Internal, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GameplayEffects_Internal.CopyAssign(value);
			}
		}

		// Token: 0x1700465B RID: 18011
		// (get) Token: 0x060120B1 RID: 73905 RVA: 0x001A7E9C File Offset: 0x001A609C
		// (set) Token: 0x060120B2 RID: 73906 RVA: 0x001A7EDF File Offset: 0x001A60DF
		public TArray<UGameplayEffect> ApplicationImmunityQueryEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UGameplayEffect> result;
				if ((result = this._ApplicationImmunityQueryEffects) == null)
				{
					result = (this._ApplicationImmunityQueryEffects = new TArray<UGameplayEffect>(base.NativePtr + (IntPtr)FActiveGameplayEffectsContainer.__PropertyOffset_ApplicationImmunityQueryEffects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ApplicationImmunityQueryEffects.CopyAssign(value);
			}
		}

		// Token: 0x060120B3 RID: 73907 RVA: 0x001A7EED File Offset: 0x001A60ED
		public FActiveGameplayEffectsContainer()
		{
		}

		// Token: 0x060120B4 RID: 73908 RVA: 0x001A7EF5 File Offset: 0x001A60F5
		public FActiveGameplayEffectsContainer(TArray<FActiveGameplayEffect> GameplayEffects_Internal, TArray<UGameplayEffect> ApplicationImmunityQueryEffects, int ArrayReplicationKey, EFastArraySerializerDeltaFlags DeltaFlags)
		{
			this.GameplayEffects_Internal = GameplayEffects_Internal;
			this.ApplicationImmunityQueryEffects = ApplicationImmunityQueryEffects;
			base.ArrayReplicationKey = ArrayReplicationKey;
			base.DeltaFlags = DeltaFlags;
		}

		// Token: 0x060120B5 RID: 73909 RVA: 0x001A7F1A File Offset: 0x001A611A
		protected override IntPtr GetUStructPtr()
		{
			return FActiveGameplayEffectsContainer.StaticStruct();
		}

		// Token: 0x060120B6 RID: 73910 RVA: 0x001A7F26 File Offset: 0x001A6126
		[NullableContext(2)]
		public FActiveGameplayEffectsContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060120B7 RID: 73911 RVA: 0x001A7F30 File Offset: 0x001A6130
		public FActiveGameplayEffectsContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060120B8 RID: 73912 RVA: 0x001A7F3B File Offset: 0x001A613B
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActiveGameplayEffectsContainer(Pointer, false, true);
		}

		// Token: 0x060120B9 RID: 73913 RVA: 0x001A7F45 File Offset: 0x001A6145
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActiveGameplayEffectsContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04009A2F RID: 39471
		public new const string __ObjectPath = "/Script/GameplayAbilities.ActiveGameplayEffectsContainer";

		// Token: 0x04009A30 RID: 39472
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009A31 RID: 39473
		internal static int __PropertyOffset_GameplayEffects_Internal;

		// Token: 0x04009A32 RID: 39474
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FActiveGameplayEffect> _GameplayEffects_Internal;

		// Token: 0x04009A33 RID: 39475
		internal static int __PropertyOffset_ApplicationImmunityQueryEffects;

		// Token: 0x04009A34 RID: 39476
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayEffect> _ApplicationImmunityQueryEffects;
	}
}
