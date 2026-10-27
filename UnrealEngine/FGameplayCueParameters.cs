using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001371 RID: 4977
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueParameters")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FGameplayCueParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012436 RID: 74806 RVA: 0x001ACE74 File Offset: 0x001AB074
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayCueParameters._ScriptStructPtr != 0) ? FGameplayCueParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayCueParameters", ref FGameplayCueParameters._ScriptStructPtr);
		}

		// Token: 0x1700471F RID: 18207
		// (get) Token: 0x06012437 RID: 74807 RVA: 0x001ACE98 File Offset: 0x001AB098
		// (set) Token: 0x06012438 RID: 74808 RVA: 0x001ACEA8 File Offset: 0x001AB0A8
		public unsafe float NormalizedMagnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_NormalizedMagnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_NormalizedMagnitude) = value;
			}
		}

		// Token: 0x17004720 RID: 18208
		// (get) Token: 0x06012439 RID: 74809 RVA: 0x001ACEB9 File Offset: 0x001AB0B9
		// (set) Token: 0x0601243A RID: 74810 RVA: 0x001ACEC9 File Offset: 0x001AB0C9
		public unsafe float RawMagnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_RawMagnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_RawMagnitude) = value;
			}
		}

		// Token: 0x17004721 RID: 18209
		// (get) Token: 0x0601243B RID: 74811 RVA: 0x001ACEDC File Offset: 0x001AB0DC
		// (set) Token: 0x0601243C RID: 74812 RVA: 0x001ACF1F File Offset: 0x001AB11F
		public FGameplayEffectContextHandle EffectContext
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectContextHandle result;
				if ((result = this._EffectContext) == null)
				{
					result = (this._EffectContext = new FGameplayEffectContextHandle(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_EffectContext, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectContextHandle.StaticStruct(), base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_EffectContext, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004722 RID: 18210
		// (get) Token: 0x0601243D RID: 74813 RVA: 0x001ACF40 File Offset: 0x001AB140
		// (set) Token: 0x0601243E RID: 74814 RVA: 0x001ACF54 File Offset: 0x001AB154
		public unsafe FGameplayTag MatchedTagName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_MatchedTagName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_MatchedTagName) = value;
			}
		}

		// Token: 0x17004723 RID: 18211
		// (get) Token: 0x0601243F RID: 74815 RVA: 0x001ACF69 File Offset: 0x001AB169
		// (set) Token: 0x06012440 RID: 74816 RVA: 0x001ACF7D File Offset: 0x001AB17D
		public unsafe FGameplayTag OriginalTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_OriginalTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_OriginalTag) = value;
			}
		}

		// Token: 0x17004724 RID: 18212
		// (get) Token: 0x06012441 RID: 74817 RVA: 0x001ACF94 File Offset: 0x001AB194
		// (set) Token: 0x06012442 RID: 74818 RVA: 0x001ACFD7 File Offset: 0x001AB1D7
		public FGameplayTagContainer AggregatedSourceTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._AggregatedSourceTags) == null)
				{
					result = (this._AggregatedSourceTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_AggregatedSourceTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_AggregatedSourceTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004725 RID: 18213
		// (get) Token: 0x06012443 RID: 74819 RVA: 0x001ACFF8 File Offset: 0x001AB1F8
		// (set) Token: 0x06012444 RID: 74820 RVA: 0x001AD03B File Offset: 0x001AB23B
		public FGameplayTagContainer AggregatedTargetTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._AggregatedTargetTags) == null)
				{
					result = (this._AggregatedTargetTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_AggregatedTargetTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_AggregatedTargetTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004726 RID: 18214
		// (get) Token: 0x06012445 RID: 74821 RVA: 0x001AD05C File Offset: 0x001AB25C
		// (set) Token: 0x06012446 RID: 74822 RVA: 0x001AD070 File Offset: 0x001AB270
		public unsafe FVector_NetQuantize10 Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17004727 RID: 18215
		// (get) Token: 0x06012447 RID: 74823 RVA: 0x001AD085 File Offset: 0x001AB285
		// (set) Token: 0x06012448 RID: 74824 RVA: 0x001AD099 File Offset: 0x001AB299
		public unsafe FVector_NetQuantizeNormal Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x17004728 RID: 18216
		// (get) Token: 0x06012449 RID: 74825 RVA: 0x001AD0AE File Offset: 0x001AB2AE
		// (set) Token: 0x0601244A RID: 74826 RVA: 0x001AD0C2 File Offset: 0x001AB2C2
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> Instigator
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_Instigator);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_Instigator) = value;
			}
		}

		// Token: 0x17004729 RID: 18217
		// (get) Token: 0x0601244B RID: 74827 RVA: 0x001AD0D7 File Offset: 0x001AB2D7
		// (set) Token: 0x0601244C RID: 74828 RVA: 0x001AD0EB File Offset: 0x001AB2EB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> EffectCauser
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_EffectCauser);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_EffectCauser) = value;
			}
		}

		// Token: 0x1700472A RID: 18218
		// (get) Token: 0x0601244D RID: 74829 RVA: 0x001AD100 File Offset: 0x001AB300
		// (set) Token: 0x0601244E RID: 74830 RVA: 0x001AD114 File Offset: 0x001AB314
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UObject> SourceObject
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_SourceObject);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_SourceObject) = value;
			}
		}

		// Token: 0x1700472B RID: 18219
		// (get) Token: 0x0601244F RID: 74831 RVA: 0x001AD129 File Offset: 0x001AB329
		// (set) Token: 0x06012450 RID: 74832 RVA: 0x001AD13D File Offset: 0x001AB33D
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UPhysicalMaterial> PhysicalMaterial
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_PhysicalMaterial);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_PhysicalMaterial) = value;
			}
		}

		// Token: 0x1700472C RID: 18220
		// (get) Token: 0x06012451 RID: 74833 RVA: 0x001AD152 File Offset: 0x001AB352
		// (set) Token: 0x06012452 RID: 74834 RVA: 0x001AD162 File Offset: 0x001AB362
		public unsafe int GameplayEffectLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_GameplayEffectLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_GameplayEffectLevel) = value;
			}
		}

		// Token: 0x1700472D RID: 18221
		// (get) Token: 0x06012453 RID: 74835 RVA: 0x001AD173 File Offset: 0x001AB373
		// (set) Token: 0x06012454 RID: 74836 RVA: 0x001AD183 File Offset: 0x001AB383
		public unsafe int AbilityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_AbilityLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_AbilityLevel) = value;
			}
		}

		// Token: 0x1700472E RID: 18222
		// (get) Token: 0x06012455 RID: 74837 RVA: 0x001AD194 File Offset: 0x001AB394
		// (set) Token: 0x06012456 RID: 74838 RVA: 0x001AD1A8 File Offset: 0x001AB3A8
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USceneComponent> TargetAttachComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_TargetAttachComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueParameters.__PropertyOffset_TargetAttachComponent) = value;
			}
		}

		// Token: 0x06012457 RID: 74839 RVA: 0x001AD1BD File Offset: 0x001AB3BD
		public FGameplayCueParameters()
		{
		}

		// Token: 0x06012458 RID: 74840 RVA: 0x001AD1C8 File Offset: 0x001AB3C8
		public FGameplayCueParameters(float NormalizedMagnitude, float RawMagnitude, FGameplayEffectContextHandle EffectContext, FGameplayTag MatchedTagName, FGameplayTag OriginalTag, FGameplayTagContainer AggregatedSourceTags, FGameplayTagContainer AggregatedTargetTags, FVector_NetQuantize10 Location, FVector_NetQuantizeNormal Normal, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AActor> Instigator, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AActor> EffectCauser, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UObject> SourceObject, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UPhysicalMaterial> PhysicalMaterial, int GameplayEffectLevel, int AbilityLevel, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<USceneComponent> TargetAttachComponent)
		{
			this.NormalizedMagnitude = NormalizedMagnitude;
			this.RawMagnitude = RawMagnitude;
			this.EffectContext = EffectContext;
			this.MatchedTagName = MatchedTagName;
			this.OriginalTag = OriginalTag;
			this.AggregatedSourceTags = AggregatedSourceTags;
			this.AggregatedTargetTags = AggregatedTargetTags;
			this.Location = Location;
			this.Normal = Normal;
			this.Instigator = Instigator;
			this.EffectCauser = EffectCauser;
			this.SourceObject = SourceObject;
			this.PhysicalMaterial = PhysicalMaterial;
			this.GameplayEffectLevel = GameplayEffectLevel;
			this.AbilityLevel = AbilityLevel;
			this.TargetAttachComponent = TargetAttachComponent;
		}

		// Token: 0x06012459 RID: 74841 RVA: 0x001AD258 File Offset: 0x001AB458
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayCueParameters.StaticStruct();
		}

		// Token: 0x0601245A RID: 74842 RVA: 0x001AD264 File Offset: 0x001AB464
		[NullableContext(2)]
		public FGameplayCueParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601245B RID: 74843 RVA: 0x001AD26E File Offset: 0x001AB46E
		public FGameplayCueParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601245C RID: 74844 RVA: 0x001AD279 File Offset: 0x001AB479
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayCueParameters(Pointer, false, true);
		}

		// Token: 0x0601245D RID: 74845 RVA: 0x001AD283 File Offset: 0x001AB483
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayCueParameters(Pointer, MemoryOwner);
		}

		// Token: 0x04009C68 RID: 40040
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueParameters";

		// Token: 0x04009C69 RID: 40041
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009C6A RID: 40042
		internal static int __PropertyOffset_NormalizedMagnitude;

		// Token: 0x04009C6B RID: 40043
		internal static int __PropertyOffset_RawMagnitude;

		// Token: 0x04009C6C RID: 40044
		internal static int __PropertyOffset_EffectContext;

		// Token: 0x04009C6D RID: 40045
		[Nullable(2)]
		private FGameplayEffectContextHandle _EffectContext;

		// Token: 0x04009C6E RID: 40046
		internal static int __PropertyOffset_MatchedTagName;

		// Token: 0x04009C6F RID: 40047
		internal static int __PropertyOffset_OriginalTag;

		// Token: 0x04009C70 RID: 40048
		internal static int __PropertyOffset_AggregatedSourceTags;

		// Token: 0x04009C71 RID: 40049
		[Nullable(2)]
		private FGameplayTagContainer _AggregatedSourceTags;

		// Token: 0x04009C72 RID: 40050
		internal static int __PropertyOffset_AggregatedTargetTags;

		// Token: 0x04009C73 RID: 40051
		[Nullable(2)]
		private FGameplayTagContainer _AggregatedTargetTags;

		// Token: 0x04009C74 RID: 40052
		internal static int __PropertyOffset_Location;

		// Token: 0x04009C75 RID: 40053
		internal static int __PropertyOffset_Normal;

		// Token: 0x04009C76 RID: 40054
		internal static int __PropertyOffset_Instigator;

		// Token: 0x04009C77 RID: 40055
		internal static int __PropertyOffset_EffectCauser;

		// Token: 0x04009C78 RID: 40056
		internal static int __PropertyOffset_SourceObject;

		// Token: 0x04009C79 RID: 40057
		internal static int __PropertyOffset_PhysicalMaterial;

		// Token: 0x04009C7A RID: 40058
		internal static int __PropertyOffset_GameplayEffectLevel;

		// Token: 0x04009C7B RID: 40059
		internal static int __PropertyOffset_AbilityLevel;

		// Token: 0x04009C7C RID: 40060
		internal static int __PropertyOffset_TargetAttachComponent;
	}
}
