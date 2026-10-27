using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200292C RID: 10540
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TriggerEffect.KuroTriggerEffect")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKuroTriggerEffect : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026FED RID: 159725 RVA: 0x003B76EC File Offset: 0x003B58EC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTriggerEffect._ClassPtr;
		}

		// Token: 0x06026FEE RID: 159726 RVA: 0x003B76F8 File Offset: 0x003B58F8
		public UKuroTriggerEffect() : this(BuiltinUtils.AllocNativeUObject(UKuroTriggerEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026FEF RID: 159727 RVA: 0x003B7720 File Offset: 0x003B5920
		public UKuroTriggerEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTriggerEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009616 RID: 38422
		// (get) Token: 0x06026FF0 RID: 159728 RVA: 0x003B7753 File Offset: 0x003B5953
		// (set) Token: 0x06026FF1 RID: 159729 RVA: 0x003B7763 File Offset: 0x003B5963
		public unsafe bool bUseEffectForThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_bUseEffectForThreshold) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_bUseEffectForThreshold) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009617 RID: 38423
		// (get) Token: 0x06026FF2 RID: 159730 RVA: 0x003B7774 File Offset: 0x003B5974
		// (set) Token: 0x06026FF3 RID: 159731 RVA: 0x003B7784 File Offset: 0x003B5984
		public unsafe byte AnalogThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_AnalogThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_AnalogThreshold) = value;
			}
		}

		// Token: 0x17009618 RID: 38424
		// (get) Token: 0x06026FF4 RID: 159732 RVA: 0x003B7795 File Offset: 0x003B5995
		// (set) Token: 0x06026FF5 RID: 159733 RVA: 0x003B77A5 File Offset: 0x003B59A5
		public unsafe EMode Mode
		{
			get
			{
				return (EMode)(*(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x17009619 RID: 38425
		// (get) Token: 0x06026FF6 RID: 159734 RVA: 0x003B77B6 File Offset: 0x003B59B6
		// (set) Token: 0x06026FF7 RID: 159735 RVA: 0x003B77CA File Offset: 0x003B59CA
		public unsafe FFeedbackMode FeedbackMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_FeedbackMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_FeedbackMode) = value;
			}
		}

		// Token: 0x1700961A RID: 38426
		// (get) Token: 0x06026FF8 RID: 159736 RVA: 0x003B77DF File Offset: 0x003B59DF
		// (set) Token: 0x06026FF9 RID: 159737 RVA: 0x003B77F3 File Offset: 0x003B59F3
		public unsafe FVibrationMode VibrationMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_VibrationMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_VibrationMode) = value;
			}
		}

		// Token: 0x1700961B RID: 38427
		// (get) Token: 0x06026FFA RID: 159738 RVA: 0x003B7808 File Offset: 0x003B5A08
		// (set) Token: 0x06026FFB RID: 159739 RVA: 0x003B781C File Offset: 0x003B5A1C
		public unsafe FWeaponMode WeaponMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_WeaponMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_WeaponMode) = value;
			}
		}

		// Token: 0x1700961C RID: 38428
		// (get) Token: 0x06026FFC RID: 159740 RVA: 0x003B7831 File Offset: 0x003B5A31
		// (set) Token: 0x06026FFD RID: 159741 RVA: 0x003B7845 File Offset: 0x003B5A45
		public unsafe FSlopeFeedbackMode SlopeFeedbackMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_SlopeFeedbackMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_SlopeFeedbackMode) = value;
			}
		}

		// Token: 0x1700961D RID: 38429
		// (get) Token: 0x06026FFE RID: 159742 RVA: 0x003B785C File Offset: 0x003B5A5C
		// (set) Token: 0x06026FFF RID: 159743 RVA: 0x003B7895 File Offset: 0x003B5A95
		public FMultiplePositionFeedbackMode MultiplePositionFeedbackMode
		{
			get
			{
				base.FastCheckIsValid();
				FMultiplePositionFeedbackMode result;
				if ((result = this._MultiplePositionFeedbackMode) == null)
				{
					result = (this._MultiplePositionFeedbackMode = new FMultiplePositionFeedbackMode(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_MultiplePositionFeedbackMode, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMultiplePositionFeedbackMode.StaticStruct(), base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_MultiplePositionFeedbackMode, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700961E RID: 38430
		// (get) Token: 0x06027000 RID: 159744 RVA: 0x003B78B8 File Offset: 0x003B5AB8
		// (set) Token: 0x06027001 RID: 159745 RVA: 0x003B78F1 File Offset: 0x003B5AF1
		public FMultiplePositionVibrationMode MultiplePositionVibrationMode
		{
			get
			{
				base.FastCheckIsValid();
				FMultiplePositionVibrationMode result;
				if ((result = this._MultiplePositionVibrationMode) == null)
				{
					result = (this._MultiplePositionVibrationMode = new FMultiplePositionVibrationMode(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_MultiplePositionVibrationMode, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMultiplePositionVibrationMode.StaticStruct(), base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_MultiplePositionVibrationMode, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06027002 RID: 159746 RVA: 0x003B7912 File Offset: 0x003B5B12
		static UKuroTriggerEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TriggerEffect.KuroTriggerEffect");
		}

		// Token: 0x06027003 RID: 159747 RVA: 0x003B7920 File Offset: 0x003B5B20
		protected UKuroTriggerEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040156D3 RID: 87763
		public new const string __ObjectPath = "/Script/TriggerEffect.KuroTriggerEffect";

		// Token: 0x040156D4 RID: 87764
		private static IntPtr _ClassPtr;

		// Token: 0x040156D5 RID: 87765
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040156D6 RID: 87766
		internal static int __PropertyOffset_bUseEffectForThreshold;

		// Token: 0x040156D7 RID: 87767
		internal static int __PropertyOffset_AnalogThreshold;

		// Token: 0x040156D8 RID: 87768
		internal static int __PropertyOffset_Mode;

		// Token: 0x040156D9 RID: 87769
		internal static int __PropertyOffset_FeedbackMode;

		// Token: 0x040156DA RID: 87770
		internal static int __PropertyOffset_VibrationMode;

		// Token: 0x040156DB RID: 87771
		internal static int __PropertyOffset_WeaponMode;

		// Token: 0x040156DC RID: 87772
		internal static int __PropertyOffset_SlopeFeedbackMode;

		// Token: 0x040156DD RID: 87773
		internal static int __PropertyOffset_MultiplePositionFeedbackMode;

		// Token: 0x040156DE RID: 87774
		[Nullable(2)]
		private FMultiplePositionFeedbackMode _MultiplePositionFeedbackMode;

		// Token: 0x040156DF RID: 87775
		internal static int __PropertyOffset_MultiplePositionVibrationMode;

		// Token: 0x040156E0 RID: 87776
		[Nullable(2)]
		private FMultiplePositionVibrationMode _MultiplePositionVibrationMode;
	}
}
