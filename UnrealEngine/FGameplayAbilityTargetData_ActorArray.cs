using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001360 RID: 4960
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityTargetData_ActorArray")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FGameplayAbilityTargetData_ActorArray : FGameplayAbilityTargetData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601230F RID: 74511 RVA: 0x001AB515 File Offset: 0x001A9715
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilityTargetData_ActorArray._ScriptStructPtr != 0) ? FGameplayAbilityTargetData_ActorArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilityTargetData_ActorArray", ref FGameplayAbilityTargetData_ActorArray._ScriptStructPtr);
		}

		// Token: 0x170046DB RID: 18139
		// (get) Token: 0x06012310 RID: 74512 RVA: 0x001AB53C File Offset: 0x001A973C
		// (set) Token: 0x06012311 RID: 74513 RVA: 0x001AB57F File Offset: 0x001A977F
		public FGameplayAbilityTargetingLocationInfo SourceLocation
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilityTargetingLocationInfo result;
				if ((result = this._SourceLocation) == null)
				{
					result = (this._SourceLocation = new FGameplayAbilityTargetingLocationInfo(base.NativePtr + (IntPtr)FGameplayAbilityTargetData_ActorArray.__PropertyOffset_SourceLocation, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityTargetingLocationInfo.StaticStruct(), base.NativePtr + (IntPtr)FGameplayAbilityTargetData_ActorArray.__PropertyOffset_SourceLocation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046DC RID: 18140
		// (get) Token: 0x06012312 RID: 74514 RVA: 0x001AB5A0 File Offset: 0x001A97A0
		// (set) Token: 0x06012313 RID: 74515 RVA: 0x001AB5E3 File Offset: 0x001A97E3
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<AActor>> TargetActorArray
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<AActor>> result;
				if ((result = this._TargetActorArray) == null)
				{
					result = (this._TargetActorArray = new TArray<TWeakObjectPtr<AActor>>(base.NativePtr + (IntPtr)FGameplayAbilityTargetData_ActorArray.__PropertyOffset_TargetActorArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.TargetActorArray.CopyAssign(value);
			}
		}

		// Token: 0x06012314 RID: 74516 RVA: 0x001AB5F1 File Offset: 0x001A97F1
		public FGameplayAbilityTargetData_ActorArray()
		{
		}

		// Token: 0x06012315 RID: 74517 RVA: 0x001AB5F9 File Offset: 0x001A97F9
		public FGameplayAbilityTargetData_ActorArray(FGameplayAbilityTargetingLocationInfo SourceLocation, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TWeakObjectPtr<AActor>> TargetActorArray)
		{
			this.SourceLocation = SourceLocation;
			this.TargetActorArray = TargetActorArray;
		}

		// Token: 0x06012316 RID: 74518 RVA: 0x001AB60F File Offset: 0x001A980F
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilityTargetData_ActorArray.StaticStruct();
		}

		// Token: 0x06012317 RID: 74519 RVA: 0x001AB61B File Offset: 0x001A981B
		[NullableContext(2)]
		public FGameplayAbilityTargetData_ActorArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012318 RID: 74520 RVA: 0x001AB625 File Offset: 0x001A9825
		public FGameplayAbilityTargetData_ActorArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012319 RID: 74521 RVA: 0x001AB630 File Offset: 0x001A9830
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilityTargetData_ActorArray(Pointer, false, true);
		}

		// Token: 0x0601231A RID: 74522 RVA: 0x001AB63A File Offset: 0x001A983A
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilityTargetData_ActorArray(Pointer, MemoryOwner);
		}

		// Token: 0x04009BEA RID: 39914
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityTargetData_ActorArray";

		// Token: 0x04009BEB RID: 39915
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009BEC RID: 39916
		internal static int __PropertyOffset_SourceLocation;

		// Token: 0x04009BED RID: 39917
		[Nullable(2)]
		private FGameplayAbilityTargetingLocationInfo _SourceLocation;

		// Token: 0x04009BEE RID: 39918
		internal static int __PropertyOffset_TargetActorArray;

		// Token: 0x04009BEF RID: 39919
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AActor>> _TargetActorArray;
	}
}
