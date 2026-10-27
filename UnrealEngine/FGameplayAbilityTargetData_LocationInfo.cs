using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001361 RID: 4961
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityTargetData_LocationInfo")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FGameplayAbilityTargetData_LocationInfo : FGameplayAbilityTargetData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601231B RID: 74523 RVA: 0x001AB643 File Offset: 0x001A9843
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilityTargetData_LocationInfo._ScriptStructPtr != 0) ? FGameplayAbilityTargetData_LocationInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilityTargetData_LocationInfo", ref FGameplayAbilityTargetData_LocationInfo._ScriptStructPtr);
		}

		// Token: 0x170046DD RID: 18141
		// (get) Token: 0x0601231C RID: 74524 RVA: 0x001AB668 File Offset: 0x001A9868
		// (set) Token: 0x0601231D RID: 74525 RVA: 0x001AB6AB File Offset: 0x001A98AB
		public FGameplayAbilityTargetingLocationInfo SourceLocation
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilityTargetingLocationInfo result;
				if ((result = this._SourceLocation) == null)
				{
					result = (this._SourceLocation = new FGameplayAbilityTargetingLocationInfo(base.NativePtr + (IntPtr)FGameplayAbilityTargetData_LocationInfo.__PropertyOffset_SourceLocation, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityTargetingLocationInfo.StaticStruct(), base.NativePtr + (IntPtr)FGameplayAbilityTargetData_LocationInfo.__PropertyOffset_SourceLocation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046DE RID: 18142
		// (get) Token: 0x0601231E RID: 74526 RVA: 0x001AB6CC File Offset: 0x001A98CC
		// (set) Token: 0x0601231F RID: 74527 RVA: 0x001AB70F File Offset: 0x001A990F
		public FGameplayAbilityTargetingLocationInfo TargetLocation
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilityTargetingLocationInfo result;
				if ((result = this._TargetLocation) == null)
				{
					result = (this._TargetLocation = new FGameplayAbilityTargetingLocationInfo(base.NativePtr + (IntPtr)FGameplayAbilityTargetData_LocationInfo.__PropertyOffset_TargetLocation, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityTargetingLocationInfo.StaticStruct(), base.NativePtr + (IntPtr)FGameplayAbilityTargetData_LocationInfo.__PropertyOffset_TargetLocation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012320 RID: 74528 RVA: 0x001AB730 File Offset: 0x001A9930
		public FGameplayAbilityTargetData_LocationInfo()
		{
		}

		// Token: 0x06012321 RID: 74529 RVA: 0x001AB738 File Offset: 0x001A9938
		public FGameplayAbilityTargetData_LocationInfo(FGameplayAbilityTargetingLocationInfo SourceLocation, FGameplayAbilityTargetingLocationInfo TargetLocation)
		{
			this.SourceLocation = SourceLocation;
			this.TargetLocation = TargetLocation;
		}

		// Token: 0x06012322 RID: 74530 RVA: 0x001AB74E File Offset: 0x001A994E
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilityTargetData_LocationInfo.StaticStruct();
		}

		// Token: 0x06012323 RID: 74531 RVA: 0x001AB75A File Offset: 0x001A995A
		[NullableContext(2)]
		public FGameplayAbilityTargetData_LocationInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012324 RID: 74532 RVA: 0x001AB764 File Offset: 0x001A9964
		public FGameplayAbilityTargetData_LocationInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012325 RID: 74533 RVA: 0x001AB76F File Offset: 0x001A996F
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilityTargetData_LocationInfo(Pointer, false, true);
		}

		// Token: 0x06012326 RID: 74534 RVA: 0x001AB779 File Offset: 0x001A9979
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilityTargetData_LocationInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009BF0 RID: 39920
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityTargetData_LocationInfo";

		// Token: 0x04009BF1 RID: 39921
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009BF2 RID: 39922
		internal static int __PropertyOffset_SourceLocation;

		// Token: 0x04009BF3 RID: 39923
		[Nullable(2)]
		private FGameplayAbilityTargetingLocationInfo _SourceLocation;

		// Token: 0x04009BF4 RID: 39924
		internal static int __PropertyOffset_TargetLocation;

		// Token: 0x04009BF5 RID: 39925
		[Nullable(2)]
		private FGameplayAbilityTargetingLocationInfo _TargetLocation;
	}
}
