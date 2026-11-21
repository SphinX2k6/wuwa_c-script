using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003A6 RID: 934
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.DamageConfig")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FDamageConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005C59 RID: 23641 RVA: 0x0008229C File Offset: 0x0008049C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDamageConfig._ScriptStructPtr != 0) ? FDamageConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplayUI.DamageConfig", ref FDamageConfig._ScriptStructPtr);
		}

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x06005C5A RID: 23642 RVA: 0x000822C0 File Offset: 0x000804C0
		// (set) Token: 0x06005C5B RID: 23643 RVA: 0x000822D0 File Offset: 0x000804D0
		public unsafe int MaxDamagePerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_MaxDamagePerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_MaxDamagePerFrame) = value;
			}
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x06005C5C RID: 23644 RVA: 0x000822E1 File Offset: 0x000804E1
		// (set) Token: 0x06005C5D RID: 23645 RVA: 0x000822F1 File Offset: 0x000804F1
		public unsafe float MinDamageOffsetScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_MinDamageOffsetScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_MinDamageOffsetScale) = value;
			}
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x06005C5E RID: 23646 RVA: 0x00082302 File Offset: 0x00080502
		// (set) Token: 0x06005C5F RID: 23647 RVA: 0x00082312 File Offset: 0x00080512
		public unsafe float MaxDamageOffsetScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_MaxDamageOffsetScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_MaxDamageOffsetScale) = value;
			}
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x06005C60 RID: 23648 RVA: 0x00082323 File Offset: 0x00080523
		// (set) Token: 0x06005C61 RID: 23649 RVA: 0x00082333 File Offset: 0x00080533
		public unsafe int MinDamageOffsetDistSquared
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_MinDamageOffsetDistSquared);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_MinDamageOffsetDistSquared) = value;
			}
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x06005C62 RID: 23650 RVA: 0x00082344 File Offset: 0x00080544
		// (set) Token: 0x06005C63 RID: 23651 RVA: 0x00082354 File Offset: 0x00080554
		public unsafe int MaxDamageOffsetDistSquared
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_MaxDamageOffsetDistSquared);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_MaxDamageOffsetDistSquared) = value;
			}
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x06005C64 RID: 23652 RVA: 0x00082365 File Offset: 0x00080565
		// (set) Token: 0x06005C65 RID: 23653 RVA: 0x00082375 File Offset: 0x00080575
		public unsafe float PcFontSizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_PcFontSizeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_PcFontSizeScale) = value;
			}
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x06005C66 RID: 23654 RVA: 0x00082386 File Offset: 0x00080586
		// (set) Token: 0x06005C67 RID: 23655 RVA: 0x00082396 File Offset: 0x00080596
		public unsafe float MobileFontSizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_MobileFontSizeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_MobileFontSizeScale) = value;
			}
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x06005C68 RID: 23656 RVA: 0x000823A7 File Offset: 0x000805A7
		// (set) Token: 0x06005C69 RID: 23657 RVA: 0x000823B7 File Offset: 0x000805B7
		public unsafe float CritOffsetScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_CritOffsetScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_CritOffsetScale) = value;
			}
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x06005C6A RID: 23658 RVA: 0x000823C8 File Offset: 0x000805C8
		// (set) Token: 0x06005C6B RID: 23659 RVA: 0x000823D8 File Offset: 0x000805D8
		public unsafe float AnimTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_AnimTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_AnimTime) = value;
			}
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x06005C6C RID: 23660 RVA: 0x000823E9 File Offset: 0x000805E9
		// (set) Token: 0x06005C6D RID: 23661 RVA: 0x000823F9 File Offset: 0x000805F9
		public unsafe float CritAnimTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_CritAnimTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_CritAnimTime) = value;
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x06005C6E RID: 23662 RVA: 0x0008240A File Offset: 0x0008060A
		// (set) Token: 0x06005C6F RID: 23663 RVA: 0x0008241A File Offset: 0x0008061A
		public unsafe float CritEffectTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_CritEffectTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_CritEffectTime) = value;
			}
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x06005C70 RID: 23664 RVA: 0x0008242B File Offset: 0x0008062B
		// (set) Token: 0x06005C71 RID: 23665 RVA: 0x0008243B File Offset: 0x0008063B
		public unsafe int CureDamageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_CureDamageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_CureDamageId) = value;
			}
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x06005C72 RID: 23666 RVA: 0x0008244C File Offset: 0x0008064C
		// (set) Token: 0x06005C73 RID: 23667 RVA: 0x0008245C File Offset: 0x0008065C
		public unsafe int ShieldDamageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_ShieldDamageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_ShieldDamageId) = value;
			}
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06005C74 RID: 23668 RVA: 0x0008246D File Offset: 0x0008066D
		// (set) Token: 0x06005C75 RID: 23669 RVA: 0x0008247D File Offset: 0x0008067D
		public unsafe int ImmunityDamageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_ImmunityDamageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_ImmunityDamageId) = value;
			}
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06005C76 RID: 23670 RVA: 0x0008248E File Offset: 0x0008068E
		// (set) Token: 0x06005C77 RID: 23671 RVA: 0x0008249E File Offset: 0x0008069E
		public unsafe int AtkDamageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_AtkDamageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_AtkDamageId) = value;
			}
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06005C78 RID: 23672 RVA: 0x000824AF File Offset: 0x000806AF
		// (set) Token: 0x06005C79 RID: 23673 RVA: 0x000824BF File Offset: 0x000806BF
		public unsafe int SpecialElement1DamageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_SpecialElement1DamageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_SpecialElement1DamageId) = value;
			}
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x06005C7A RID: 23674 RVA: 0x000824D0 File Offset: 0x000806D0
		// (set) Token: 0x06005C7B RID: 23675 RVA: 0x000824E0 File Offset: 0x000806E0
		public unsafe int SpecialElement2DamageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_SpecialElement2DamageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_SpecialElement2DamageId) = value;
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x06005C7C RID: 23676 RVA: 0x000824F1 File Offset: 0x000806F1
		// (set) Token: 0x06005C7D RID: 23677 RVA: 0x00082501 File Offset: 0x00080701
		public unsafe int SpecialElement3DamageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_SpecialElement3DamageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_SpecialElement3DamageId) = value;
			}
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x06005C7E RID: 23678 RVA: 0x00082512 File Offset: 0x00080712
		// (set) Token: 0x06005C7F RID: 23679 RVA: 0x00082522 File Offset: 0x00080722
		public unsafe int SpecialElement4DamageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_SpecialElement4DamageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_SpecialElement4DamageId) = value;
			}
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x06005C80 RID: 23680 RVA: 0x00082533 File Offset: 0x00080733
		// (set) Token: 0x06005C81 RID: 23681 RVA: 0x00082543 File Offset: 0x00080743
		public unsafe int SpecialElement5DamageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_SpecialElement5DamageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_SpecialElement5DamageId) = value;
			}
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x06005C82 RID: 23682 RVA: 0x00082554 File Offset: 0x00080754
		// (set) Token: 0x06005C83 RID: 23683 RVA: 0x00082597 File Offset: 0x00080797
		public TMap<int, float> MergeDurationByDamageId
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, float> result;
				if ((result = this._MergeDurationByDamageId) == null)
				{
					result = (this._MergeDurationByDamageId = new TMap<int, float>(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_MergeDurationByDamageId, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MergeDurationByDamageId.CopyAssign(value);
			}
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x06005C84 RID: 23684 RVA: 0x000825A5 File Offset: 0x000807A5
		// (set) Token: 0x06005C85 RID: 23685 RVA: 0x000825B5 File Offset: 0x000807B5
		public unsafe bool EnableCompactNumberFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_EnableCompactNumberFormat) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_EnableCompactNumberFormat) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06005C86 RID: 23686 RVA: 0x000825C6 File Offset: 0x000807C6
		// (set) Token: 0x06005C87 RID: 23687 RVA: 0x000825D6 File Offset: 0x000807D6
		public unsafe EDamageFormatType DamageFormatType
		{
			get
			{
				return (EDamageFormatType)(*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_DamageFormatType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_DamageFormatType) = (byte)value;
			}
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06005C88 RID: 23688 RVA: 0x000825E7 File Offset: 0x000807E7
		// (set) Token: 0x06005C89 RID: 23689 RVA: 0x000825F7 File Offset: 0x000807F7
		public unsafe float ValidTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_ValidTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageConfig.__PropertyOffset_ValidTime) = value;
			}
		}

		// Token: 0x06005C8A RID: 23690 RVA: 0x00082608 File Offset: 0x00080808
		public FDamageConfig()
		{
		}

		// Token: 0x06005C8B RID: 23691 RVA: 0x00082610 File Offset: 0x00080810
		protected override IntPtr GetUStructPtr()
		{
			return FDamageConfig.StaticStruct();
		}

		// Token: 0x06005C8C RID: 23692 RVA: 0x0008261C File Offset: 0x0008081C
		[NullableContext(2)]
		public FDamageConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005C8D RID: 23693 RVA: 0x00082626 File Offset: 0x00080826
		public FDamageConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005C8E RID: 23694 RVA: 0x00082631 File Offset: 0x00080831
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDamageConfig(Pointer, false, true);
		}

		// Token: 0x06005C8F RID: 23695 RVA: 0x0008263B File Offset: 0x0008083B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDamageConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400267D RID: 9853
		public const string __ObjectPath = "/Script/KuroGameplayUI.DamageConfig";

		// Token: 0x0400267E RID: 9854
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400267F RID: 9855
		internal static int __PropertyOffset_MaxDamagePerFrame;

		// Token: 0x04002680 RID: 9856
		internal static int __PropertyOffset_MinDamageOffsetScale;

		// Token: 0x04002681 RID: 9857
		internal static int __PropertyOffset_MaxDamageOffsetScale;

		// Token: 0x04002682 RID: 9858
		internal static int __PropertyOffset_MinDamageOffsetDistSquared;

		// Token: 0x04002683 RID: 9859
		internal static int __PropertyOffset_MaxDamageOffsetDistSquared;

		// Token: 0x04002684 RID: 9860
		internal static int __PropertyOffset_PcFontSizeScale;

		// Token: 0x04002685 RID: 9861
		internal static int __PropertyOffset_MobileFontSizeScale;

		// Token: 0x04002686 RID: 9862
		internal static int __PropertyOffset_CritOffsetScale;

		// Token: 0x04002687 RID: 9863
		internal static int __PropertyOffset_AnimTime;

		// Token: 0x04002688 RID: 9864
		internal static int __PropertyOffset_CritAnimTime;

		// Token: 0x04002689 RID: 9865
		internal static int __PropertyOffset_CritEffectTime;

		// Token: 0x0400268A RID: 9866
		internal static int __PropertyOffset_CureDamageId;

		// Token: 0x0400268B RID: 9867
		internal static int __PropertyOffset_ShieldDamageId;

		// Token: 0x0400268C RID: 9868
		internal static int __PropertyOffset_ImmunityDamageId;

		// Token: 0x0400268D RID: 9869
		internal static int __PropertyOffset_AtkDamageId;

		// Token: 0x0400268E RID: 9870
		internal static int __PropertyOffset_SpecialElement1DamageId;

		// Token: 0x0400268F RID: 9871
		internal static int __PropertyOffset_SpecialElement2DamageId;

		// Token: 0x04002690 RID: 9872
		internal static int __PropertyOffset_SpecialElement3DamageId;

		// Token: 0x04002691 RID: 9873
		internal static int __PropertyOffset_SpecialElement4DamageId;

		// Token: 0x04002692 RID: 9874
		internal static int __PropertyOffset_SpecialElement5DamageId;

		// Token: 0x04002693 RID: 9875
		internal static int __PropertyOffset_MergeDurationByDamageId;

		// Token: 0x04002694 RID: 9876
		[Nullable(2)]
		private TMap<int, float> _MergeDurationByDamageId;

		// Token: 0x04002695 RID: 9877
		internal static int __PropertyOffset_EnableCompactNumberFormat;

		// Token: 0x04002696 RID: 9878
		internal static int __PropertyOffset_DamageFormatType;

		// Token: 0x04002697 RID: 9879
		internal static int __PropertyOffset_ValidTime;
	}
}
