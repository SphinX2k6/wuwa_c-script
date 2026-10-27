using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013B6 RID: 5046
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.TagContainerAggregator")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FTagContainerAggregator : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012824 RID: 75812 RVA: 0x001B35F5 File Offset: 0x001B17F5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTagContainerAggregator._ScriptStructPtr != 0) ? FTagContainerAggregator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.TagContainerAggregator", ref FTagContainerAggregator._ScriptStructPtr);
		}

		// Token: 0x17004809 RID: 18441
		// (get) Token: 0x06012825 RID: 75813 RVA: 0x001B361C File Offset: 0x001B181C
		// (set) Token: 0x06012826 RID: 75814 RVA: 0x001B365F File Offset: 0x001B185F
		public FGameplayTagContainer CapturedActorTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._CapturedActorTags) == null)
				{
					result = (this._CapturedActorTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FTagContainerAggregator.__PropertyOffset_CapturedActorTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FTagContainerAggregator.__PropertyOffset_CapturedActorTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700480A RID: 18442
		// (get) Token: 0x06012827 RID: 75815 RVA: 0x001B3680 File Offset: 0x001B1880
		// (set) Token: 0x06012828 RID: 75816 RVA: 0x001B36C3 File Offset: 0x001B18C3
		public FGameplayTagContainer CapturedSpecTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._CapturedSpecTags) == null)
				{
					result = (this._CapturedSpecTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FTagContainerAggregator.__PropertyOffset_CapturedSpecTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FTagContainerAggregator.__PropertyOffset_CapturedSpecTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700480B RID: 18443
		// (get) Token: 0x06012829 RID: 75817 RVA: 0x001B36E4 File Offset: 0x001B18E4
		// (set) Token: 0x0601282A RID: 75818 RVA: 0x001B3727 File Offset: 0x001B1927
		public FGameplayTagContainer ScopedTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ScopedTags) == null)
				{
					result = (this._ScopedTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FTagContainerAggregator.__PropertyOffset_ScopedTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FTagContainerAggregator.__PropertyOffset_ScopedTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601282B RID: 75819 RVA: 0x001B3748 File Offset: 0x001B1948
		public FTagContainerAggregator()
		{
		}

		// Token: 0x0601282C RID: 75820 RVA: 0x001B3750 File Offset: 0x001B1950
		public FTagContainerAggregator(FGameplayTagContainer CapturedActorTags, FGameplayTagContainer CapturedSpecTags, FGameplayTagContainer ScopedTags)
		{
			this.CapturedActorTags = CapturedActorTags;
			this.CapturedSpecTags = CapturedSpecTags;
			this.ScopedTags = ScopedTags;
		}

		// Token: 0x0601282D RID: 75821 RVA: 0x001B376D File Offset: 0x001B196D
		protected override IntPtr GetUStructPtr()
		{
			return FTagContainerAggregator.StaticStruct();
		}

		// Token: 0x0601282E RID: 75822 RVA: 0x001B3779 File Offset: 0x001B1979
		[NullableContext(2)]
		public FTagContainerAggregator(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601282F RID: 75823 RVA: 0x001B3783 File Offset: 0x001B1983
		public FTagContainerAggregator(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012830 RID: 75824 RVA: 0x001B378E File Offset: 0x001B198E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTagContainerAggregator(Pointer, false, true);
		}

		// Token: 0x06012831 RID: 75825 RVA: 0x001B3798 File Offset: 0x001B1998
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTagContainerAggregator(Pointer, MemoryOwner);
		}

		// Token: 0x04009E6A RID: 40554
		public const string __ObjectPath = "/Script/GameplayAbilities.TagContainerAggregator";

		// Token: 0x04009E6B RID: 40555
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E6C RID: 40556
		internal static int __PropertyOffset_CapturedActorTags;

		// Token: 0x04009E6D RID: 40557
		[Nullable(2)]
		private FGameplayTagContainer _CapturedActorTags;

		// Token: 0x04009E6E RID: 40558
		internal static int __PropertyOffset_CapturedSpecTags;

		// Token: 0x04009E6F RID: 40559
		[Nullable(2)]
		private FGameplayTagContainer _CapturedSpecTags;

		// Token: 0x04009E70 RID: 40560
		internal static int __PropertyOffset_ScopedTags;

		// Token: 0x04009E71 RID: 40561
		[Nullable(2)]
		private FGameplayTagContainer _ScopedTags;
	}
}
