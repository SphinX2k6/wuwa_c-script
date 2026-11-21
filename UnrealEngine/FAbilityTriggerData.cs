using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002BC RID: 700
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTriggerData")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAbilityTriggerData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004CE2 RID: 19682 RVA: 0x0006B9F5 File Offset: 0x00069BF5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAbilityTriggerData._ScriptStructPtr != 0) ? FAbilityTriggerData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.AbilityTriggerData", ref FAbilityTriggerData._ScriptStructPtr);
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06004CE3 RID: 19683 RVA: 0x0006BA19 File Offset: 0x00069C19
		// (set) Token: 0x06004CE4 RID: 19684 RVA: 0x0006BA2D File Offset: 0x00069C2D
		public unsafe FGameplayTag TriggerTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAbilityTriggerData.__PropertyOffset_TriggerTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAbilityTriggerData.__PropertyOffset_TriggerTag) = value;
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06004CE5 RID: 19685 RVA: 0x0006BA42 File Offset: 0x00069C42
		// (set) Token: 0x06004CE6 RID: 19686 RVA: 0x0006BA56 File Offset: 0x00069C56
		public unsafe TEnumAsByte<EGameplayAbilityTriggerSource> TriggerSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAbilityTriggerData.__PropertyOffset_TriggerSource);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAbilityTriggerData.__PropertyOffset_TriggerSource) = value;
			}
		}

		// Token: 0x06004CE7 RID: 19687 RVA: 0x0006BA6B File Offset: 0x00069C6B
		public FAbilityTriggerData()
		{
		}

		// Token: 0x06004CE8 RID: 19688 RVA: 0x0006BA73 File Offset: 0x00069C73
		protected override IntPtr GetUStructPtr()
		{
			return FAbilityTriggerData.StaticStruct();
		}

		// Token: 0x06004CE9 RID: 19689 RVA: 0x0006BA7F File Offset: 0x00069C7F
		[NullableContext(2)]
		public FAbilityTriggerData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004CEA RID: 19690 RVA: 0x0006BA89 File Offset: 0x00069C89
		public FAbilityTriggerData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004CEB RID: 19691 RVA: 0x0006BA94 File Offset: 0x00069C94
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAbilityTriggerData(Pointer, false, true);
		}

		// Token: 0x06004CEC RID: 19692 RVA: 0x0006BA9E File Offset: 0x00069C9E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAbilityTriggerData(Pointer, MemoryOwner);
		}

		// Token: 0x04001EAA RID: 7850
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.AbilityTriggerData";

		// Token: 0x04001EAB RID: 7851
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001EAC RID: 7852
		internal static int __PropertyOffset_TriggerTag;

		// Token: 0x04001EAD RID: 7853
		internal static int __PropertyOffset_TriggerSource;
	}
}
