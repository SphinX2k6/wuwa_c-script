using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200187D RID: 6269
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.DamageConfig")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FDamageConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017156 RID: 94550 RVA: 0x0021A508 File Offset: 0x00218708
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDamageConfig._ScriptStructPtr != 0) ? FDamageConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplayUI.DamageConfig", ref FDamageConfig._ScriptStructPtr);
		}

		// Token: 0x17005CD5 RID: 23765
		// (get) Token: 0x06017157 RID: 94551 RVA: 0x0021A52C File Offset: 0x0021872C
		// (set) Token: 0x06017158 RID: 94552 RVA: 0x0021A53C File Offset: 0x0021873C
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

		// Token: 0x17005CD6 RID: 23766
		// (get) Token: 0x06017159 RID: 94553 RVA: 0x0021A54D File Offset: 0x0021874D
		// (set) Token: 0x0601715A RID: 94554 RVA: 0x0021A55D File Offset: 0x0021875D
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

		// Token: 0x17005CD7 RID: 23767
		// (get) Token: 0x0601715B RID: 94555 RVA: 0x0021A56E File Offset: 0x0021876E
		// (set) Token: 0x0601715C RID: 94556 RVA: 0x0021A57E File Offset: 0x0021877E
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

		// Token: 0x17005CD8 RID: 23768
		// (get) Token: 0x0601715D RID: 94557 RVA: 0x0021A58F File Offset: 0x0021878F
		// (set) Token: 0x0601715E RID: 94558 RVA: 0x0021A59F File Offset: 0x0021879F
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

		// Token: 0x17005CD9 RID: 23769
		// (get) Token: 0x0601715F RID: 94559 RVA: 0x0021A5B0 File Offset: 0x002187B0
		// (set) Token: 0x06017160 RID: 94560 RVA: 0x0021A5C0 File Offset: 0x002187C0
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

		// Token: 0x17005CDA RID: 23770
		// (get) Token: 0x06017161 RID: 94561 RVA: 0x0021A5D1 File Offset: 0x002187D1
		// (set) Token: 0x06017162 RID: 94562 RVA: 0x0021A5E1 File Offset: 0x002187E1
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

		// Token: 0x17005CDB RID: 23771
		// (get) Token: 0x06017163 RID: 94563 RVA: 0x0021A5F2 File Offset: 0x002187F2
		// (set) Token: 0x06017164 RID: 94564 RVA: 0x0021A602 File Offset: 0x00218802
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

		// Token: 0x17005CDC RID: 23772
		// (get) Token: 0x06017165 RID: 94565 RVA: 0x0021A613 File Offset: 0x00218813
		// (set) Token: 0x06017166 RID: 94566 RVA: 0x0021A623 File Offset: 0x00218823
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

		// Token: 0x17005CDD RID: 23773
		// (get) Token: 0x06017167 RID: 94567 RVA: 0x0021A634 File Offset: 0x00218834
		// (set) Token: 0x06017168 RID: 94568 RVA: 0x0021A644 File Offset: 0x00218844
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

		// Token: 0x17005CDE RID: 23774
		// (get) Token: 0x06017169 RID: 94569 RVA: 0x0021A655 File Offset: 0x00218855
		// (set) Token: 0x0601716A RID: 94570 RVA: 0x0021A665 File Offset: 0x00218865
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

		// Token: 0x17005CDF RID: 23775
		// (get) Token: 0x0601716B RID: 94571 RVA: 0x0021A676 File Offset: 0x00218876
		// (set) Token: 0x0601716C RID: 94572 RVA: 0x0021A686 File Offset: 0x00218886
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

		// Token: 0x17005CE0 RID: 23776
		// (get) Token: 0x0601716D RID: 94573 RVA: 0x0021A697 File Offset: 0x00218897
		// (set) Token: 0x0601716E RID: 94574 RVA: 0x0021A6A7 File Offset: 0x002188A7
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

		// Token: 0x17005CE1 RID: 23777
		// (get) Token: 0x0601716F RID: 94575 RVA: 0x0021A6B8 File Offset: 0x002188B8
		// (set) Token: 0x06017170 RID: 94576 RVA: 0x0021A6C8 File Offset: 0x002188C8
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

		// Token: 0x17005CE2 RID: 23778
		// (get) Token: 0x06017171 RID: 94577 RVA: 0x0021A6D9 File Offset: 0x002188D9
		// (set) Token: 0x06017172 RID: 94578 RVA: 0x0021A6E9 File Offset: 0x002188E9
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

		// Token: 0x17005CE3 RID: 23779
		// (get) Token: 0x06017173 RID: 94579 RVA: 0x0021A6FA File Offset: 0x002188FA
		// (set) Token: 0x06017174 RID: 94580 RVA: 0x0021A70A File Offset: 0x0021890A
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

		// Token: 0x17005CE4 RID: 23780
		// (get) Token: 0x06017175 RID: 94581 RVA: 0x0021A71B File Offset: 0x0021891B
		// (set) Token: 0x06017176 RID: 94582 RVA: 0x0021A72B File Offset: 0x0021892B
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

		// Token: 0x17005CE5 RID: 23781
		// (get) Token: 0x06017177 RID: 94583 RVA: 0x0021A73C File Offset: 0x0021893C
		// (set) Token: 0x06017178 RID: 94584 RVA: 0x0021A74C File Offset: 0x0021894C
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

		// Token: 0x17005CE6 RID: 23782
		// (get) Token: 0x06017179 RID: 94585 RVA: 0x0021A75D File Offset: 0x0021895D
		// (set) Token: 0x0601717A RID: 94586 RVA: 0x0021A76D File Offset: 0x0021896D
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

		// Token: 0x17005CE7 RID: 23783
		// (get) Token: 0x0601717B RID: 94587 RVA: 0x0021A77E File Offset: 0x0021897E
		// (set) Token: 0x0601717C RID: 94588 RVA: 0x0021A78E File Offset: 0x0021898E
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

		// Token: 0x17005CE8 RID: 23784
		// (get) Token: 0x0601717D RID: 94589 RVA: 0x0021A79F File Offset: 0x0021899F
		// (set) Token: 0x0601717E RID: 94590 RVA: 0x0021A7AF File Offset: 0x002189AF
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

		// Token: 0x17005CE9 RID: 23785
		// (get) Token: 0x0601717F RID: 94591 RVA: 0x0021A7C0 File Offset: 0x002189C0
		// (set) Token: 0x06017180 RID: 94592 RVA: 0x0021A803 File Offset: 0x00218A03
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

		// Token: 0x17005CEA RID: 23786
		// (get) Token: 0x06017181 RID: 94593 RVA: 0x0021A811 File Offset: 0x00218A11
		// (set) Token: 0x06017182 RID: 94594 RVA: 0x0021A821 File Offset: 0x00218A21
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

		// Token: 0x17005CEB RID: 23787
		// (get) Token: 0x06017183 RID: 94595 RVA: 0x0021A832 File Offset: 0x00218A32
		// (set) Token: 0x06017184 RID: 94596 RVA: 0x0021A842 File Offset: 0x00218A42
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

		// Token: 0x17005CEC RID: 23788
		// (get) Token: 0x06017185 RID: 94597 RVA: 0x0021A853 File Offset: 0x00218A53
		// (set) Token: 0x06017186 RID: 94598 RVA: 0x0021A863 File Offset: 0x00218A63
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

		// Token: 0x06017187 RID: 94599 RVA: 0x0021A874 File Offset: 0x00218A74
		public FDamageConfig()
		{
		}

		// Token: 0x06017188 RID: 94600 RVA: 0x0021A87C File Offset: 0x00218A7C
		public FDamageConfig(int MaxDamagePerFrame, float MinDamageOffsetScale, float MaxDamageOffsetScale, int MinDamageOffsetDistSquared, int MaxDamageOffsetDistSquared, float PcFontSizeScale, float MobileFontSizeScale, float CritOffsetScale, float AnimTime, float CritAnimTime, float CritEffectTime, int CureDamageId, int ShieldDamageId, int ImmunityDamageId, int AtkDamageId, int SpecialElement1DamageId, int SpecialElement2DamageId, int SpecialElement3DamageId, int SpecialElement4DamageId, int SpecialElement5DamageId, TMap<int, float> MergeDurationByDamageId, bool EnableCompactNumberFormat, EDamageFormatType DamageFormatType, float ValidTime)
		{
			this.MaxDamagePerFrame = MaxDamagePerFrame;
			this.MinDamageOffsetScale = MinDamageOffsetScale;
			this.MaxDamageOffsetScale = MaxDamageOffsetScale;
			this.MinDamageOffsetDistSquared = MinDamageOffsetDistSquared;
			this.MaxDamageOffsetDistSquared = MaxDamageOffsetDistSquared;
			this.PcFontSizeScale = PcFontSizeScale;
			this.MobileFontSizeScale = MobileFontSizeScale;
			this.CritOffsetScale = CritOffsetScale;
			this.AnimTime = AnimTime;
			this.CritAnimTime = CritAnimTime;
			this.CritEffectTime = CritEffectTime;
			this.CureDamageId = CureDamageId;
			this.ShieldDamageId = ShieldDamageId;
			this.ImmunityDamageId = ImmunityDamageId;
			this.AtkDamageId = AtkDamageId;
			this.SpecialElement1DamageId = SpecialElement1DamageId;
			this.SpecialElement2DamageId = SpecialElement2DamageId;
			this.SpecialElement3DamageId = SpecialElement3DamageId;
			this.SpecialElement4DamageId = SpecialElement4DamageId;
			this.SpecialElement5DamageId = SpecialElement5DamageId;
			this.MergeDurationByDamageId = MergeDurationByDamageId;
			this.EnableCompactNumberFormat = EnableCompactNumberFormat;
			this.DamageFormatType = DamageFormatType;
			this.ValidTime = ValidTime;
		}

		// Token: 0x06017189 RID: 94601 RVA: 0x0021A94C File Offset: 0x00218B4C
		protected override IntPtr GetUStructPtr()
		{
			return FDamageConfig.StaticStruct();
		}

		// Token: 0x0601718A RID: 94602 RVA: 0x0021A958 File Offset: 0x00218B58
		[NullableContext(2)]
		public FDamageConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601718B RID: 94603 RVA: 0x0021A962 File Offset: 0x00218B62
		public FDamageConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601718C RID: 94604 RVA: 0x0021A96D File Offset: 0x00218B6D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDamageConfig(Pointer, false, true);
		}

		// Token: 0x0601718D RID: 94605 RVA: 0x0021A977 File Offset: 0x00218B77
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDamageConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400C869 RID: 51305
		public const string __ObjectPath = "/Script/KuroGameplayUI.DamageConfig";

		// Token: 0x0400C86A RID: 51306
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C86B RID: 51307
		internal static int __PropertyOffset_MaxDamagePerFrame;

		// Token: 0x0400C86C RID: 51308
		internal static int __PropertyOffset_MinDamageOffsetScale;

		// Token: 0x0400C86D RID: 51309
		internal static int __PropertyOffset_MaxDamageOffsetScale;

		// Token: 0x0400C86E RID: 51310
		internal static int __PropertyOffset_MinDamageOffsetDistSquared;

		// Token: 0x0400C86F RID: 51311
		internal static int __PropertyOffset_MaxDamageOffsetDistSquared;

		// Token: 0x0400C870 RID: 51312
		internal static int __PropertyOffset_PcFontSizeScale;

		// Token: 0x0400C871 RID: 51313
		internal static int __PropertyOffset_MobileFontSizeScale;

		// Token: 0x0400C872 RID: 51314
		internal static int __PropertyOffset_CritOffsetScale;

		// Token: 0x0400C873 RID: 51315
		internal static int __PropertyOffset_AnimTime;

		// Token: 0x0400C874 RID: 51316
		internal static int __PropertyOffset_CritAnimTime;

		// Token: 0x0400C875 RID: 51317
		internal static int __PropertyOffset_CritEffectTime;

		// Token: 0x0400C876 RID: 51318
		internal static int __PropertyOffset_CureDamageId;

		// Token: 0x0400C877 RID: 51319
		internal static int __PropertyOffset_ShieldDamageId;

		// Token: 0x0400C878 RID: 51320
		internal static int __PropertyOffset_ImmunityDamageId;

		// Token: 0x0400C879 RID: 51321
		internal static int __PropertyOffset_AtkDamageId;

		// Token: 0x0400C87A RID: 51322
		internal static int __PropertyOffset_SpecialElement1DamageId;

		// Token: 0x0400C87B RID: 51323
		internal static int __PropertyOffset_SpecialElement2DamageId;

		// Token: 0x0400C87C RID: 51324
		internal static int __PropertyOffset_SpecialElement3DamageId;

		// Token: 0x0400C87D RID: 51325
		internal static int __PropertyOffset_SpecialElement4DamageId;

		// Token: 0x0400C87E RID: 51326
		internal static int __PropertyOffset_SpecialElement5DamageId;

		// Token: 0x0400C87F RID: 51327
		internal static int __PropertyOffset_MergeDurationByDamageId;

		// Token: 0x0400C880 RID: 51328
		[Nullable(2)]
		private TMap<int, float> _MergeDurationByDamageId;

		// Token: 0x0400C881 RID: 51329
		internal static int __PropertyOffset_EnableCompactNumberFormat;

		// Token: 0x0400C882 RID: 51330
		internal static int __PropertyOffset_DamageFormatType;

		// Token: 0x0400C883 RID: 51331
		internal static int __PropertyOffset_ValidTime;
	}
}
