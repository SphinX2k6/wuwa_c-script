using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001628 RID: 5672
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.BoneFeedbackAnimConfig")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FBoneFeedbackAnimConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601485A RID: 84058 RVA: 0x001E308F File Offset: 0x001E128F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneFeedbackAnimConfig._ScriptStructPtr != 0) ? FBoneFeedbackAnimConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.BoneFeedbackAnimConfig", ref FBoneFeedbackAnimConfig._ScriptStructPtr);
		}

		// Token: 0x170050CF RID: 20687
		// (get) Token: 0x0601485B RID: 84059 RVA: 0x001E30B4 File Offset: 0x001E12B4
		// (set) Token: 0x0601485C RID: 84060 RVA: 0x001E30F7 File Offset: 0x001E12F7
		public TArray<FName> BoneGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BoneGroups) == null)
				{
					result = (this._BoneGroups = new TArray<FName>(base.NativePtr + (IntPtr)FBoneFeedbackAnimConfig.__PropertyOffset_BoneGroups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneGroups.CopyAssign(value);
			}
		}

		// Token: 0x170050D0 RID: 20688
		// (get) Token: 0x0601485D RID: 84061 RVA: 0x001E3105 File Offset: 0x001E1305
		// (set) Token: 0x0601485E RID: 84062 RVA: 0x001E3119 File Offset: 0x001E1319
		public unsafe FName EffectBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneFeedbackAnimConfig.__PropertyOffset_EffectBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneFeedbackAnimConfig.__PropertyOffset_EffectBoneName) = value;
			}
		}

		// Token: 0x170050D1 RID: 20689
		// (get) Token: 0x0601485F RID: 84063 RVA: 0x001E312E File Offset: 0x001E132E
		// (set) Token: 0x06014860 RID: 84064 RVA: 0x001E3142 File Offset: 0x001E1342
		public unsafe FVector Up
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneFeedbackAnimConfig.__PropertyOffset_Up);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneFeedbackAnimConfig.__PropertyOffset_Up) = value;
			}
		}

		// Token: 0x170050D2 RID: 20690
		// (get) Token: 0x06014861 RID: 84065 RVA: 0x001E3157 File Offset: 0x001E1357
		// (set) Token: 0x06014862 RID: 84066 RVA: 0x001E316B File Offset: 0x001E136B
		public unsafe FVector Forward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneFeedbackAnimConfig.__PropertyOffset_Forward);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneFeedbackAnimConfig.__PropertyOffset_Forward) = value;
			}
		}

		// Token: 0x170050D3 RID: 20691
		// (get) Token: 0x06014863 RID: 84067 RVA: 0x001E3180 File Offset: 0x001E1380
		// (set) Token: 0x06014864 RID: 84068 RVA: 0x001E31C3 File Offset: 0x001E13C3
		public TArray<float> AngleSplit
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._AngleSplit) == null)
				{
					result = (this._AngleSplit = new TArray<float>(base.NativePtr + (IntPtr)FBoneFeedbackAnimConfig.__PropertyOffset_AngleSplit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AngleSplit.CopyAssign(value);
			}
		}

		// Token: 0x170050D4 RID: 20692
		// (get) Token: 0x06014865 RID: 84069 RVA: 0x001E31D4 File Offset: 0x001E13D4
		// (set) Token: 0x06014866 RID: 84070 RVA: 0x001E3217 File Offset: 0x001E1417
		public TArray<UAnimSequence> AnimSequences
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimSequence> result;
				if ((result = this._AnimSequences) == null)
				{
					result = (this._AnimSequences = new TArray<UAnimSequence>(base.NativePtr + (IntPtr)FBoneFeedbackAnimConfig.__PropertyOffset_AnimSequences, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AnimSequences.CopyAssign(value);
			}
		}

		// Token: 0x170050D5 RID: 20693
		// (get) Token: 0x06014867 RID: 84071 RVA: 0x001E3228 File Offset: 0x001E1428
		// (set) Token: 0x06014868 RID: 84072 RVA: 0x001E326C File Offset: 0x001E146C
		public TFixedArray<float> StateAlpha
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._StateAlpha) == null)
				{
					result = (this._StateAlpha = new TFixedArray<float>(base.NativePtr + (IntPtr)FBoneFeedbackAnimConfig.__PropertyOffset_StateAlpha, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StateAlpha.CopyAssign(value);
			}
		}

		// Token: 0x170050D6 RID: 20694
		// (get) Token: 0x06014869 RID: 84073 RVA: 0x001E327C File Offset: 0x001E147C
		// (set) Token: 0x0601486A RID: 84074 RVA: 0x001E32C0 File Offset: 0x001E14C0
		public TFixedArray<float> HitAlpha
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._HitAlpha) == null)
				{
					result = (this._HitAlpha = new TFixedArray<float>(base.NativePtr + (IntPtr)FBoneFeedbackAnimConfig.__PropertyOffset_HitAlpha, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HitAlpha.CopyAssign(value);
			}
		}

		// Token: 0x170050D7 RID: 20695
		// (get) Token: 0x0601486B RID: 84075 RVA: 0x001E32CE File Offset: 0x001E14CE
		// (set) Token: 0x0601486C RID: 84076 RVA: 0x001E32DE File Offset: 0x001E14DE
		public unsafe float LinkAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneFeedbackAnimConfig.__PropertyOffset_LinkAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneFeedbackAnimConfig.__PropertyOffset_LinkAlpha) = value;
			}
		}

		// Token: 0x0601486D RID: 84077 RVA: 0x001E32EF File Offset: 0x001E14EF
		public FBoneFeedbackAnimConfig()
		{
		}

		// Token: 0x0601486E RID: 84078 RVA: 0x001E32F8 File Offset: 0x001E14F8
		public FBoneFeedbackAnimConfig(TArray<FName> BoneGroups, FName EffectBoneName, FVector Up, FVector Forward, TArray<float> AngleSplit, TArray<UAnimSequence> AnimSequences, TFixedArray<float> StateAlpha, TFixedArray<float> HitAlpha, float LinkAlpha)
		{
			this.BoneGroups = BoneGroups;
			this.EffectBoneName = EffectBoneName;
			this.Up = Up;
			this.Forward = Forward;
			this.AngleSplit = AngleSplit;
			this.AnimSequences = AnimSequences;
			this.StateAlpha = StateAlpha;
			this.HitAlpha = HitAlpha;
			this.LinkAlpha = LinkAlpha;
		}

		// Token: 0x0601486F RID: 84079 RVA: 0x001E3350 File Offset: 0x001E1550
		protected override IntPtr GetUStructPtr()
		{
			return FBoneFeedbackAnimConfig.StaticStruct();
		}

		// Token: 0x06014870 RID: 84080 RVA: 0x001E335C File Offset: 0x001E155C
		[NullableContext(2)]
		public FBoneFeedbackAnimConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014871 RID: 84081 RVA: 0x001E3366 File Offset: 0x001E1566
		public FBoneFeedbackAnimConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014872 RID: 84082 RVA: 0x001E3371 File Offset: 0x001E1571
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneFeedbackAnimConfig(Pointer, false, true);
		}

		// Token: 0x06014873 RID: 84083 RVA: 0x001E337B File Offset: 0x001E157B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneFeedbackAnimConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400B290 RID: 45712
		public const string __ObjectPath = "/Script/KuroAnim.BoneFeedbackAnimConfig";

		// Token: 0x0400B291 RID: 45713
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B292 RID: 45714
		internal static int __PropertyOffset_BoneGroups;

		// Token: 0x0400B293 RID: 45715
		[Nullable(2)]
		private TArray<FName> _BoneGroups;

		// Token: 0x0400B294 RID: 45716
		internal static int __PropertyOffset_EffectBoneName;

		// Token: 0x0400B295 RID: 45717
		internal static int __PropertyOffset_Up;

		// Token: 0x0400B296 RID: 45718
		internal static int __PropertyOffset_Forward;

		// Token: 0x0400B297 RID: 45719
		internal static int __PropertyOffset_AngleSplit;

		// Token: 0x0400B298 RID: 45720
		[Nullable(2)]
		private TArray<float> _AngleSplit;

		// Token: 0x0400B299 RID: 45721
		internal static int __PropertyOffset_AnimSequences;

		// Token: 0x0400B29A RID: 45722
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimSequence> _AnimSequences;

		// Token: 0x0400B29B RID: 45723
		internal static int __PropertyOffset_StateAlpha;

		// Token: 0x0400B29C RID: 45724
		[Nullable(2)]
		private TFixedArray<float> _StateAlpha;

		// Token: 0x0400B29D RID: 45725
		internal static int __PropertyOffset_HitAlpha;

		// Token: 0x0400B29E RID: 45726
		[Nullable(2)]
		private TFixedArray<float> _HitAlpha;

		// Token: 0x0400B29F RID: 45727
		internal static int __PropertyOffset_LinkAlpha;
	}
}
