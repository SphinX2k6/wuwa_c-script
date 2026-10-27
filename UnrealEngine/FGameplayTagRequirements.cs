using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200139E RID: 5022
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayTagRequirements")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FGameplayTagRequirements : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601270D RID: 75533 RVA: 0x001B1BFF File Offset: 0x001AFDFF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagRequirements._ScriptStructPtr != 0) ? FGameplayTagRequirements._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayTagRequirements", ref FGameplayTagRequirements._ScriptStructPtr);
		}

		// Token: 0x170047E5 RID: 18405
		// (get) Token: 0x0601270E RID: 75534 RVA: 0x001B1C24 File Offset: 0x001AFE24
		// (set) Token: 0x0601270F RID: 75535 RVA: 0x001B1C67 File Offset: 0x001AFE67
		public FGameplayTagContainer RequireTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._RequireTags) == null)
				{
					result = (this._RequireTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FGameplayTagRequirements.__PropertyOffset_RequireTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FGameplayTagRequirements.__PropertyOffset_RequireTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047E6 RID: 18406
		// (get) Token: 0x06012710 RID: 75536 RVA: 0x001B1C88 File Offset: 0x001AFE88
		// (set) Token: 0x06012711 RID: 75537 RVA: 0x001B1CCB File Offset: 0x001AFECB
		public FGameplayTagContainer IgnoreTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._IgnoreTags) == null)
				{
					result = (this._IgnoreTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FGameplayTagRequirements.__PropertyOffset_IgnoreTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FGameplayTagRequirements.__PropertyOffset_IgnoreTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047E7 RID: 18407
		// (get) Token: 0x06012712 RID: 75538 RVA: 0x001B1CEC File Offset: 0x001AFEEC
		// (set) Token: 0x06012713 RID: 75539 RVA: 0x001B1CFC File Offset: 0x001AFEFC
		public unsafe bool bRequireLogicalOperator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagRequirements.__PropertyOffset_bRequireLogicalOperator) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagRequirements.__PropertyOffset_bRequireLogicalOperator) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047E8 RID: 18408
		// (get) Token: 0x06012714 RID: 75540 RVA: 0x001B1D0D File Offset: 0x001AFF0D
		// (set) Token: 0x06012715 RID: 75541 RVA: 0x001B1D1D File Offset: 0x001AFF1D
		public unsafe bool bIgnoreLogicalOperator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagRequirements.__PropertyOffset_bIgnoreLogicalOperator) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagRequirements.__PropertyOffset_bIgnoreLogicalOperator) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047E9 RID: 18409
		// (get) Token: 0x06012716 RID: 75542 RVA: 0x001B1D2E File Offset: 0x001AFF2E
		// (set) Token: 0x06012717 RID: 75543 RVA: 0x001B1D3E File Offset: 0x001AFF3E
		public unsafe bool bCombineLogicalOperator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagRequirements.__PropertyOffset_bCombineLogicalOperator) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagRequirements.__PropertyOffset_bCombineLogicalOperator) = (value ? 1 : 0);
			}
		}

		// Token: 0x06012718 RID: 75544 RVA: 0x001B1D4F File Offset: 0x001AFF4F
		public FGameplayTagRequirements()
		{
		}

		// Token: 0x06012719 RID: 75545 RVA: 0x001B1D57 File Offset: 0x001AFF57
		public FGameplayTagRequirements(FGameplayTagContainer RequireTags, FGameplayTagContainer IgnoreTags, bool bRequireLogicalOperator, bool bIgnoreLogicalOperator, bool bCombineLogicalOperator)
		{
			this.RequireTags = RequireTags;
			this.IgnoreTags = IgnoreTags;
			this.bRequireLogicalOperator = bRequireLogicalOperator;
			this.bIgnoreLogicalOperator = bIgnoreLogicalOperator;
			this.bCombineLogicalOperator = bCombineLogicalOperator;
		}

		// Token: 0x0601271A RID: 75546 RVA: 0x001B1D84 File Offset: 0x001AFF84
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTagRequirements.StaticStruct();
		}

		// Token: 0x0601271B RID: 75547 RVA: 0x001B1D90 File Offset: 0x001AFF90
		[NullableContext(2)]
		public FGameplayTagRequirements(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601271C RID: 75548 RVA: 0x001B1D9A File Offset: 0x001AFF9A
		public FGameplayTagRequirements(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601271D RID: 75549 RVA: 0x001B1DA5 File Offset: 0x001AFFA5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTagRequirements(Pointer, false, true);
		}

		// Token: 0x0601271E RID: 75550 RVA: 0x001B1DAF File Offset: 0x001AFFAF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTagRequirements(Pointer, MemoryOwner);
		}

		// Token: 0x04009DFF RID: 40447
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayTagRequirements";

		// Token: 0x04009E00 RID: 40448
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E01 RID: 40449
		internal static int __PropertyOffset_RequireTags;

		// Token: 0x04009E02 RID: 40450
		[Nullable(2)]
		private FGameplayTagContainer _RequireTags;

		// Token: 0x04009E03 RID: 40451
		internal static int __PropertyOffset_IgnoreTags;

		// Token: 0x04009E04 RID: 40452
		[Nullable(2)]
		private FGameplayTagContainer _IgnoreTags;

		// Token: 0x04009E05 RID: 40453
		internal static int __PropertyOffset_bRequireLogicalOperator;

		// Token: 0x04009E06 RID: 40454
		internal static int __PropertyOffset_bIgnoreLogicalOperator;

		// Token: 0x04009E07 RID: 40455
		internal static int __PropertyOffset_bCombineLogicalOperator;
	}
}
