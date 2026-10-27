using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D4C RID: 7500
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKSC_DA_Buff : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CB7A RID: 117626 RVA: 0x002A73D6 File Offset: 0x002A55D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff._ClassPtr;
		}

		// Token: 0x0601CB7B RID: 117627 RVA: 0x002A73E4 File Offset: 0x002A55E4
		public UKSC_DA_Buff() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CB7C RID: 117628 RVA: 0x002A740C File Offset: 0x002A560C
		[NullableContext(1)]
		public UKSC_DA_Buff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007382 RID: 29570
		// (get) Token: 0x0601CB7D RID: 117629 RVA: 0x002A743F File Offset: 0x002A563F
		// (set) Token: 0x0601CB7E RID: 117630 RVA: 0x002A7453 File Offset: 0x002A5653
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UKSC_Buff> RuntimeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_RuntimeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_RuntimeClass) = value;
			}
		}

		// Token: 0x17007383 RID: 29571
		// (get) Token: 0x0601CB7F RID: 117631 RVA: 0x002A7468 File Offset: 0x002A5668
		// (set) Token: 0x0601CB80 RID: 117632 RVA: 0x002A74A1 File Offset: 0x002A56A1
		[Nullable(1)]
		public FKSC_TagFilter TagFilter
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._TagFilter) == null)
				{
					result = (this._TagFilter = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_TagFilter, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_TagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007384 RID: 29572
		// (get) Token: 0x0601CB81 RID: 117633 RVA: 0x002A74C2 File Offset: 0x002A56C2
		// (set) Token: 0x0601CB82 RID: 117634 RVA: 0x002A74D2 File Offset: 0x002A56D2
		public unsafe EKSC_Buff_DurationType DurationType
		{
			get
			{
				return (EKSC_Buff_DurationType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_DurationType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_DurationType) = (byte)value;
			}
		}

		// Token: 0x17007385 RID: 29573
		// (get) Token: 0x0601CB83 RID: 117635 RVA: 0x002A74E3 File Offset: 0x002A56E3
		// (set) Token: 0x0601CB84 RID: 117636 RVA: 0x002A74F3 File Offset: 0x002A56F3
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17007386 RID: 29574
		// (get) Token: 0x0601CB85 RID: 117637 RVA: 0x002A7504 File Offset: 0x002A5704
		// (set) Token: 0x0601CB86 RID: 117638 RVA: 0x002A7514 File Offset: 0x002A5714
		public unsafe bool RefreshTagWhenBuffRefresh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_RefreshTagWhenBuffRefresh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_RefreshTagWhenBuffRefresh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007387 RID: 29575
		// (get) Token: 0x0601CB87 RID: 117639 RVA: 0x002A7525 File Offset: 0x002A5725
		// (set) Token: 0x0601CB88 RID: 117640 RVA: 0x002A7535 File Offset: 0x002A5735
		public unsafe bool InstantNeedUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_InstantNeedUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_InstantNeedUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007388 RID: 29576
		// (get) Token: 0x0601CB89 RID: 117641 RVA: 0x002A7548 File Offset: 0x002A5748
		// (set) Token: 0x0601CB8A RID: 117642 RVA: 0x002A7581 File Offset: 0x002A5781
		[Nullable(1)]
		public FGameplayTagContainer BuffTags
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._BuffTags) == null)
				{
					result = (this._BuffTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffTags, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007389 RID: 29577
		// (get) Token: 0x0601CB8B RID: 117643 RVA: 0x002A75A4 File Offset: 0x002A57A4
		// (set) Token: 0x0601CB8C RID: 117644 RVA: 0x002A75DD File Offset: 0x002A57DD
		[Nullable(1)]
		public TArray<UKSC_DA_Buff> BuffAddBuffs
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_Buff> result;
				if ((result = this._BuffAddBuffs) == null)
				{
					result = (this._BuffAddBuffs = new TArray<UKSC_DA_Buff>(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffAddBuffs, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BuffAddBuffs.CopyAssign(value);
			}
		}

		// Token: 0x1700738A RID: 29578
		// (get) Token: 0x0601CB8D RID: 117645 RVA: 0x002A75EB File Offset: 0x002A57EB
		// (set) Token: 0x0601CB8E RID: 117646 RVA: 0x002A75FB File Offset: 0x002A57FB
		public unsafe bool RemoveChildBuffWhenEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_RemoveChildBuffWhenEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_RemoveChildBuffWhenEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700738B RID: 29579
		// (get) Token: 0x0601CB8F RID: 117647 RVA: 0x002A760C File Offset: 0x002A580C
		// (set) Token: 0x0601CB90 RID: 117648 RVA: 0x002A7620 File Offset: 0x002A5820
		public unsafe UEffectModelBase BuffFX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_BuffFX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_BuffFX, value);
			}
		}

		// Token: 0x1700738C RID: 29580
		// (get) Token: 0x0601CB91 RID: 117649 RVA: 0x002A7635 File Offset: 0x002A5835
		// (set) Token: 0x0601CB92 RID: 117650 RVA: 0x002A7649 File Offset: 0x002A5849
		public unsafe FTransform BuffFX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_Offset) = value;
			}
		}

		// Token: 0x1700738D RID: 29581
		// (get) Token: 0x0601CB93 RID: 117651 RVA: 0x002A765E File Offset: 0x002A585E
		// (set) Token: 0x0601CB94 RID: 117652 RVA: 0x002A7672 File Offset: 0x002A5872
		public unsafe FName Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Socket) = value;
			}
		}

		// Token: 0x1700738E RID: 29582
		// (get) Token: 0x0601CB95 RID: 117653 RVA: 0x002A7687 File Offset: 0x002A5887
		// (set) Token: 0x0601CB96 RID: 117654 RVA: 0x002A7697 File Offset: 0x002A5897
		public unsafe bool BuffFX_AttackLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackLocation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackLocation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700738F RID: 29583
		// (get) Token: 0x0601CB97 RID: 117655 RVA: 0x002A76A8 File Offset: 0x002A58A8
		// (set) Token: 0x0601CB98 RID: 117656 RVA: 0x002A76B8 File Offset: 0x002A58B8
		public unsafe bool BuffFX_AttackRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007390 RID: 29584
		// (get) Token: 0x0601CB99 RID: 117657 RVA: 0x002A76C9 File Offset: 0x002A58C9
		// (set) Token: 0x0601CB9A RID: 117658 RVA: 0x002A76D9 File Offset: 0x002A58D9
		public unsafe bool BuffFX_AttackScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007391 RID: 29585
		// (get) Token: 0x0601CB9B RID: 117659 RVA: 0x002A76EA File Offset: 0x002A58EA
		// (set) Token: 0x0601CB9C RID: 117660 RVA: 0x002A76FA File Offset: 0x002A58FA
		public unsafe bool BuffFX_DetachOnEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_DetachOnEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_DetachOnEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007392 RID: 29586
		// (get) Token: 0x0601CB9D RID: 117661 RVA: 0x002A770B File Offset: 0x002A590B
		// (set) Token: 0x0601CB9E RID: 117662 RVA: 0x002A771B File Offset: 0x002A591B
		public unsafe bool MobileInvisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_MobileInvisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_MobileInvisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007393 RID: 29587
		// (get) Token: 0x0601CB9F RID: 117663 RVA: 0x002A772C File Offset: 0x002A592C
		// (set) Token: 0x0601CBA0 RID: 117664 RVA: 0x002A7740 File Offset: 0x002A5940
		public unsafe UEffectModelBase BuffFX_Add
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_BuffFX_Add);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_BuffFX_Add, value);
			}
		}

		// Token: 0x17007394 RID: 29588
		// (get) Token: 0x0601CBA1 RID: 117665 RVA: 0x002A7755 File Offset: 0x002A5955
		// (set) Token: 0x0601CBA2 RID: 117666 RVA: 0x002A7769 File Offset: 0x002A5969
		public unsafe FTransform BuffFX_Offset_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_Offset_Add);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_Offset_Add) = value;
			}
		}

		// Token: 0x17007395 RID: 29589
		// (get) Token: 0x0601CBA3 RID: 117667 RVA: 0x002A777E File Offset: 0x002A597E
		// (set) Token: 0x0601CBA4 RID: 117668 RVA: 0x002A7792 File Offset: 0x002A5992
		public unsafe FName Socket_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Socket_Add);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Socket_Add) = value;
			}
		}

		// Token: 0x17007396 RID: 29590
		// (get) Token: 0x0601CBA5 RID: 117669 RVA: 0x002A77A7 File Offset: 0x002A59A7
		// (set) Token: 0x0601CBA6 RID: 117670 RVA: 0x002A77B7 File Offset: 0x002A59B7
		public unsafe bool BuffFX_AttackLocation_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackLocation_Add) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackLocation_Add) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007397 RID: 29591
		// (get) Token: 0x0601CBA7 RID: 117671 RVA: 0x002A77C8 File Offset: 0x002A59C8
		// (set) Token: 0x0601CBA8 RID: 117672 RVA: 0x002A77D8 File Offset: 0x002A59D8
		public unsafe bool BuffFX_AttackRotation_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackRotation_Add) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackRotation_Add) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007398 RID: 29592
		// (get) Token: 0x0601CBA9 RID: 117673 RVA: 0x002A77E9 File Offset: 0x002A59E9
		// (set) Token: 0x0601CBAA RID: 117674 RVA: 0x002A77F9 File Offset: 0x002A59F9
		public unsafe bool BuffFX_AttackScale_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackScale_Add) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackScale_Add) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007399 RID: 29593
		// (get) Token: 0x0601CBAB RID: 117675 RVA: 0x002A780A File Offset: 0x002A5A0A
		// (set) Token: 0x0601CBAC RID: 117676 RVA: 0x002A781E File Offset: 0x002A5A1E
		public unsafe UEffectModelBase BuffFX_Remove
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_BuffFX_Remove);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_BuffFX_Remove, value);
			}
		}

		// Token: 0x1700739A RID: 29594
		// (get) Token: 0x0601CBAD RID: 117677 RVA: 0x002A7833 File Offset: 0x002A5A33
		// (set) Token: 0x0601CBAE RID: 117678 RVA: 0x002A7847 File Offset: 0x002A5A47
		public unsafe FTransform BuffFX_Offset_Remove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_Offset_Remove);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_Offset_Remove) = value;
			}
		}

		// Token: 0x1700739B RID: 29595
		// (get) Token: 0x0601CBAF RID: 117679 RVA: 0x002A785C File Offset: 0x002A5A5C
		// (set) Token: 0x0601CBB0 RID: 117680 RVA: 0x002A7870 File Offset: 0x002A5A70
		public unsafe FName Socket_Remove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Socket_Remove);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Socket_Remove) = value;
			}
		}

		// Token: 0x1700739C RID: 29596
		// (get) Token: 0x0601CBB1 RID: 117681 RVA: 0x002A7885 File Offset: 0x002A5A85
		// (set) Token: 0x0601CBB2 RID: 117682 RVA: 0x002A7895 File Offset: 0x002A5A95
		public unsafe bool BuffFX_AttackLocation_Remove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackLocation_Remove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackLocation_Remove) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700739D RID: 29597
		// (get) Token: 0x0601CBB3 RID: 117683 RVA: 0x002A78A6 File Offset: 0x002A5AA6
		// (set) Token: 0x0601CBB4 RID: 117684 RVA: 0x002A78B6 File Offset: 0x002A5AB6
		public unsafe bool BuffFX_AttackRotation_Remove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackRotation_Remove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackRotation_Remove) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700739E RID: 29598
		// (get) Token: 0x0601CBB5 RID: 117685 RVA: 0x002A78C7 File Offset: 0x002A5AC7
		// (set) Token: 0x0601CBB6 RID: 117686 RVA: 0x002A78D7 File Offset: 0x002A5AD7
		public unsafe bool BuffFX_AttackScale_Remove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackScale_Remove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackScale_Remove) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700739F RID: 29599
		// (get) Token: 0x0601CBB7 RID: 117687 RVA: 0x002A78E8 File Offset: 0x002A5AE8
		// (set) Token: 0x0601CBB8 RID: 117688 RVA: 0x002A78FC File Offset: 0x002A5AFC
		public unsafe UKuroMaterialControllerDataAsset Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x0601CBB9 RID: 117689 RVA: 0x002A7911 File Offset: 0x002A5B11
		static UKSC_DA_Buff()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff");
		}

		// Token: 0x0601CBBA RID: 117690 RVA: 0x002A791F File Offset: 0x002A5B1F
		protected UKSC_DA_Buff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F921 RID: 63777
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff";

		// Token: 0x0400F922 RID: 63778
		private static IntPtr _ClassPtr;

		// Token: 0x0400F923 RID: 63779
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F924 RID: 63780
		internal static int __PropertyOffset_RuntimeClass;

		// Token: 0x0400F925 RID: 63781
		internal static int __PropertyOffset_TagFilter;

		// Token: 0x0400F926 RID: 63782
		private FKSC_TagFilter _TagFilter;

		// Token: 0x0400F927 RID: 63783
		internal static int __PropertyOffset_DurationType;

		// Token: 0x0400F928 RID: 63784
		internal static int __PropertyOffset_Duration;

		// Token: 0x0400F929 RID: 63785
		internal static int __PropertyOffset_RefreshTagWhenBuffRefresh;

		// Token: 0x0400F92A RID: 63786
		internal static int __PropertyOffset_InstantNeedUpdate;

		// Token: 0x0400F92B RID: 63787
		internal static int __PropertyOffset_BuffTags;

		// Token: 0x0400F92C RID: 63788
		private FGameplayTagContainer _BuffTags;

		// Token: 0x0400F92D RID: 63789
		internal static int __PropertyOffset_BuffAddBuffs;

		// Token: 0x0400F92E RID: 63790
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_Buff> _BuffAddBuffs;

		// Token: 0x0400F92F RID: 63791
		internal static int __PropertyOffset_RemoveChildBuffWhenEnd;

		// Token: 0x0400F930 RID: 63792
		internal static int __PropertyOffset_BuffFX;

		// Token: 0x0400F931 RID: 63793
		internal static int __PropertyOffset_BuffFX_Offset;

		// Token: 0x0400F932 RID: 63794
		internal static int __PropertyOffset_Socket;

		// Token: 0x0400F933 RID: 63795
		internal static int __PropertyOffset_BuffFX_AttackLocation;

		// Token: 0x0400F934 RID: 63796
		internal static int __PropertyOffset_BuffFX_AttackRotation;

		// Token: 0x0400F935 RID: 63797
		internal static int __PropertyOffset_BuffFX_AttackScale;

		// Token: 0x0400F936 RID: 63798
		internal static int __PropertyOffset_BuffFX_DetachOnEnd;

		// Token: 0x0400F937 RID: 63799
		internal static int __PropertyOffset_MobileInvisible;

		// Token: 0x0400F938 RID: 63800
		internal static int __PropertyOffset_BuffFX_Add;

		// Token: 0x0400F939 RID: 63801
		internal static int __PropertyOffset_BuffFX_Offset_Add;

		// Token: 0x0400F93A RID: 63802
		internal static int __PropertyOffset_Socket_Add;

		// Token: 0x0400F93B RID: 63803
		internal static int __PropertyOffset_BuffFX_AttackLocation_Add;

		// Token: 0x0400F93C RID: 63804
		internal static int __PropertyOffset_BuffFX_AttackRotation_Add;

		// Token: 0x0400F93D RID: 63805
		internal static int __PropertyOffset_BuffFX_AttackScale_Add;

		// Token: 0x0400F93E RID: 63806
		internal static int __PropertyOffset_BuffFX_Remove;

		// Token: 0x0400F93F RID: 63807
		internal static int __PropertyOffset_BuffFX_Offset_Remove;

		// Token: 0x0400F940 RID: 63808
		internal static int __PropertyOffset_Socket_Remove;

		// Token: 0x0400F941 RID: 63809
		internal static int __PropertyOffset_BuffFX_AttackLocation_Remove;

		// Token: 0x0400F942 RID: 63810
		internal static int __PropertyOffset_BuffFX_AttackRotation_Remove;

		// Token: 0x0400F943 RID: 63811
		internal static int __PropertyOffset_BuffFX_AttackScale_Remove;

		// Token: 0x0400F944 RID: 63812
		internal static int __PropertyOffset_Material;
	}
}
