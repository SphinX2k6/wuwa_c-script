using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001999 RID: 6553
	[UnrealObjectPath("/Script/KuroInput.KuroInputSetting")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroInputSetting : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018584 RID: 99716 RVA: 0x0023E577 File Offset: 0x0023C777
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInputSetting._ClassPtr;
		}

		// Token: 0x06018585 RID: 99717 RVA: 0x0023E584 File Offset: 0x0023C784
		public UKuroInputSetting() : this(BuiltinUtils.AllocNativeUObject(UKuroInputSetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018586 RID: 99718 RVA: 0x0023E5AC File Offset: 0x0023C7AC
		[NullableContext(1)]
		public UKuroInputSetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInputSetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006120 RID: 24864
		// (get) Token: 0x06018587 RID: 99719 RVA: 0x0023E5DF File Offset: 0x0023C7DF
		// (set) Token: 0x06018588 RID: 99720 RVA: 0x0023E5EF File Offset: 0x0023C7EF
		public unsafe EGlobalKuroForceFeedbackType FeedbackConfig
		{
			get
			{
				return (EGlobalKuroForceFeedbackType)(*(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_FeedbackConfig));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_FeedbackConfig) = (byte)value;
			}
		}

		// Token: 0x17006121 RID: 24865
		// (get) Token: 0x06018589 RID: 99721 RVA: 0x0023E600 File Offset: 0x0023C800
		// (set) Token: 0x0601858A RID: 99722 RVA: 0x0023E610 File Offset: 0x0023C810
		public unsafe float GlobalFeedbackSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_GlobalFeedbackSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_GlobalFeedbackSize) = value;
			}
		}

		// Token: 0x17006122 RID: 24866
		// (get) Token: 0x0601858B RID: 99723 RVA: 0x0023E621 File Offset: 0x0023C821
		// (set) Token: 0x0601858C RID: 99724 RVA: 0x0023E631 File Offset: 0x0023C831
		public unsafe bool IsUseGamepad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_IsUseGamepad) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_IsUseGamepad) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006123 RID: 24867
		// (get) Token: 0x0601858D RID: 99725 RVA: 0x0023E642 File Offset: 0x0023C842
		// (set) Token: 0x0601858E RID: 99726 RVA: 0x0023E652 File Offset: 0x0023C852
		public unsafe bool IsUseSonyFeedback
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_IsUseSonyFeedback) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_IsUseSonyFeedback) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006124 RID: 24868
		// (get) Token: 0x0601858F RID: 99727 RVA: 0x0023E663 File Offset: 0x0023C863
		// (set) Token: 0x06018590 RID: 99728 RVA: 0x0023E673 File Offset: 0x0023C873
		public unsafe EInputMode DefaultInputMode
		{
			get
			{
				return (EInputMode)(*(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_DefaultInputMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_DefaultInputMode) = (byte)value;
			}
		}

		// Token: 0x17006125 RID: 24869
		// (get) Token: 0x06018591 RID: 99729 RVA: 0x0023E684 File Offset: 0x0023C884
		// (set) Token: 0x06018592 RID: 99730 RVA: 0x0023E694 File Offset: 0x0023C894
		public unsafe bool IsDefaultLockMouseToViewport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_IsDefaultLockMouseToViewport) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_IsDefaultLockMouseToViewport) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006126 RID: 24870
		// (get) Token: 0x06018593 RID: 99731 RVA: 0x0023E6A5 File Offset: 0x0023C8A5
		// (set) Token: 0x06018594 RID: 99732 RVA: 0x0023E6B5 File Offset: 0x0023C8B5
		public unsafe bool IsDefaultHideCursorDuringCapture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_IsDefaultHideCursorDuringCapture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_IsDefaultHideCursorDuringCapture) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006127 RID: 24871
		// (get) Token: 0x06018595 RID: 99733 RVA: 0x0023E6C6 File Offset: 0x0023C8C6
		// (set) Token: 0x06018596 RID: 99734 RVA: 0x0023E6D6 File Offset: 0x0023C8D6
		public unsafe bool IsPrintDebugLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_IsPrintDebugLog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInputSetting.__PropertyOffset_IsPrintDebugLog) = (value ? 1 : 0);
			}
		}

		// Token: 0x06018597 RID: 99735 RVA: 0x0023E6E7 File Offset: 0x0023C8E7
		static UKuroInputSetting()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroInput.KuroInputSetting");
		}

		// Token: 0x06018598 RID: 99736 RVA: 0x0023E6F5 File Offset: 0x0023C8F5
		protected UKuroInputSetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D29F RID: 53919
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroInput.KuroInputSetting";

		// Token: 0x0400D2A0 RID: 53920
		private static IntPtr _ClassPtr;

		// Token: 0x0400D2A1 RID: 53921
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D2A2 RID: 53922
		internal static int __PropertyOffset_FeedbackConfig;

		// Token: 0x0400D2A3 RID: 53923
		internal static int __PropertyOffset_GlobalFeedbackSize;

		// Token: 0x0400D2A4 RID: 53924
		internal static int __PropertyOffset_IsUseGamepad;

		// Token: 0x0400D2A5 RID: 53925
		internal static int __PropertyOffset_IsUseSonyFeedback;

		// Token: 0x0400D2A6 RID: 53926
		internal static int __PropertyOffset_DefaultInputMode;

		// Token: 0x0400D2A7 RID: 53927
		internal static int __PropertyOffset_IsDefaultLockMouseToViewport;

		// Token: 0x0400D2A8 RID: 53928
		internal static int __PropertyOffset_IsDefaultHideCursorDuringCapture;

		// Token: 0x0400D2A9 RID: 53929
		internal static int __PropertyOffset_IsPrintDebugLog;
	}
}
