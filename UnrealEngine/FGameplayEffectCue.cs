using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001385 RID: 4997
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectCue")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FGameplayEffectCue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601258B RID: 75147 RVA: 0x001AF2E4 File Offset: 0x001AD4E4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectCue._ScriptStructPtr != 0) ? FGameplayEffectCue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectCue", ref FGameplayEffectCue._ScriptStructPtr);
		}

		// Token: 0x1700477F RID: 18303
		// (get) Token: 0x0601258C RID: 75148 RVA: 0x001AF308 File Offset: 0x001AD508
		// (set) Token: 0x0601258D RID: 75149 RVA: 0x001AF34B File Offset: 0x001AD54B
		public FGameplayAttribute MagnitudeAttribute
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttribute result;
				if ((result = this._MagnitudeAttribute) == null)
				{
					result = (this._MagnitudeAttribute = new FGameplayAttribute(base.NativePtr + (IntPtr)FGameplayEffectCue.__PropertyOffset_MagnitudeAttribute, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttribute.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectCue.__PropertyOffset_MagnitudeAttribute, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004780 RID: 18304
		// (get) Token: 0x0601258E RID: 75150 RVA: 0x001AF36C File Offset: 0x001AD56C
		// (set) Token: 0x0601258F RID: 75151 RVA: 0x001AF37C File Offset: 0x001AD57C
		public unsafe float MinLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectCue.__PropertyOffset_MinLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectCue.__PropertyOffset_MinLevel) = value;
			}
		}

		// Token: 0x17004781 RID: 18305
		// (get) Token: 0x06012590 RID: 75152 RVA: 0x001AF38D File Offset: 0x001AD58D
		// (set) Token: 0x06012591 RID: 75153 RVA: 0x001AF39D File Offset: 0x001AD59D
		public unsafe float MaxLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectCue.__PropertyOffset_MaxLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectCue.__PropertyOffset_MaxLevel) = value;
			}
		}

		// Token: 0x17004782 RID: 18306
		// (get) Token: 0x06012592 RID: 75154 RVA: 0x001AF3B0 File Offset: 0x001AD5B0
		// (set) Token: 0x06012593 RID: 75155 RVA: 0x001AF3F3 File Offset: 0x001AD5F3
		public FGameplayTagContainer GameplayCueTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._GameplayCueTags) == null)
				{
					result = (this._GameplayCueTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FGameplayEffectCue.__PropertyOffset_GameplayCueTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectCue.__PropertyOffset_GameplayCueTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012594 RID: 75156 RVA: 0x001AF414 File Offset: 0x001AD614
		public FGameplayEffectCue()
		{
		}

		// Token: 0x06012595 RID: 75157 RVA: 0x001AF41C File Offset: 0x001AD61C
		public FGameplayEffectCue(FGameplayAttribute MagnitudeAttribute, float MinLevel, float MaxLevel, FGameplayTagContainer GameplayCueTags)
		{
			this.MagnitudeAttribute = MagnitudeAttribute;
			this.MinLevel = MinLevel;
			this.MaxLevel = MaxLevel;
			this.GameplayCueTags = GameplayCueTags;
		}

		// Token: 0x06012596 RID: 75158 RVA: 0x001AF441 File Offset: 0x001AD641
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectCue.StaticStruct();
		}

		// Token: 0x06012597 RID: 75159 RVA: 0x001AF44D File Offset: 0x001AD64D
		[NullableContext(2)]
		public FGameplayEffectCue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012598 RID: 75160 RVA: 0x001AF457 File Offset: 0x001AD657
		public FGameplayEffectCue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012599 RID: 75161 RVA: 0x001AF462 File Offset: 0x001AD662
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectCue(Pointer, false, true);
		}

		// Token: 0x0601259A RID: 75162 RVA: 0x001AF46C File Offset: 0x001AD66C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectCue(Pointer, MemoryOwner);
		}

		// Token: 0x04009D27 RID: 40231
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectCue";

		// Token: 0x04009D28 RID: 40232
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009D29 RID: 40233
		internal static int __PropertyOffset_MagnitudeAttribute;

		// Token: 0x04009D2A RID: 40234
		[Nullable(2)]
		private FGameplayAttribute _MagnitudeAttribute;

		// Token: 0x04009D2B RID: 40235
		internal static int __PropertyOffset_MinLevel;

		// Token: 0x04009D2C RID: 40236
		internal static int __PropertyOffset_MaxLevel;

		// Token: 0x04009D2D RID: 40237
		internal static int __PropertyOffset_GameplayCueTags;

		// Token: 0x04009D2E RID: 40238
		[Nullable(2)]
		private FGameplayTagContainer _GameplayCueTags;
	}
}
