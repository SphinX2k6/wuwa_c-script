using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200131B RID: 4891
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTriggerData")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAbilityTriggerData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012054 RID: 73812 RVA: 0x001A75D0 File Offset: 0x001A57D0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAbilityTriggerData._ScriptStructPtr != 0) ? FAbilityTriggerData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.AbilityTriggerData", ref FAbilityTriggerData._ScriptStructPtr);
		}

		// Token: 0x17004649 RID: 17993
		// (get) Token: 0x06012055 RID: 73813 RVA: 0x001A75F4 File Offset: 0x001A57F4
		// (set) Token: 0x06012056 RID: 73814 RVA: 0x001A7608 File Offset: 0x001A5808
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

		// Token: 0x1700464A RID: 17994
		// (get) Token: 0x06012057 RID: 73815 RVA: 0x001A761D File Offset: 0x001A581D
		// (set) Token: 0x06012058 RID: 73816 RVA: 0x001A7631 File Offset: 0x001A5831
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

		// Token: 0x06012059 RID: 73817 RVA: 0x001A7646 File Offset: 0x001A5846
		public FAbilityTriggerData()
		{
		}

		// Token: 0x0601205A RID: 73818 RVA: 0x001A764E File Offset: 0x001A584E
		public FAbilityTriggerData(FGameplayTag TriggerTag, TEnumAsByte<EGameplayAbilityTriggerSource> TriggerSource)
		{
			this.TriggerTag = TriggerTag;
			this.TriggerSource = TriggerSource;
		}

		// Token: 0x0601205B RID: 73819 RVA: 0x001A7664 File Offset: 0x001A5864
		protected override IntPtr GetUStructPtr()
		{
			return FAbilityTriggerData.StaticStruct();
		}

		// Token: 0x0601205C RID: 73820 RVA: 0x001A7670 File Offset: 0x001A5870
		[NullableContext(2)]
		public FAbilityTriggerData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601205D RID: 73821 RVA: 0x001A767A File Offset: 0x001A587A
		public FAbilityTriggerData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601205E RID: 73822 RVA: 0x001A7685 File Offset: 0x001A5885
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAbilityTriggerData(Pointer, false, true);
		}

		// Token: 0x0601205F RID: 73823 RVA: 0x001A768F File Offset: 0x001A588F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAbilityTriggerData(Pointer, MemoryOwner);
		}

		// Token: 0x04009A0A RID: 39434
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.AbilityTriggerData";

		// Token: 0x04009A0B RID: 39435
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009A0C RID: 39436
		internal static int __PropertyOffset_TriggerTag;

		// Token: 0x04009A0D RID: 39437
		internal static int __PropertyOffset_TriggerSource;
	}
}
