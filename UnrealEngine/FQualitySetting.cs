using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002287 RID: 8839
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MagtModule.QualitySetting")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FQualitySetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060219AB RID: 137643 RVA: 0x0031B7C0 File Offset: 0x003199C0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQualitySetting._ScriptStructPtr != 0) ? FQualitySetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MagtModule.QualitySetting", ref FQualitySetting._ScriptStructPtr);
		}

		// Token: 0x1700828D RID: 33421
		// (get) Token: 0x060219AC RID: 137644 RVA: 0x0031B7E4 File Offset: 0x003199E4
		// (set) Token: 0x060219AD RID: 137645 RVA: 0x0031B7F4 File Offset: 0x003199F4
		public unsafe int SettingId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQualitySetting.__PropertyOffset_SettingId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualitySetting.__PropertyOffset_SettingId) = value;
			}
		}

		// Token: 0x1700828E RID: 33422
		// (get) Token: 0x060219AE RID: 137646 RVA: 0x0031B805 File Offset: 0x00319A05
		// (set) Token: 0x060219AF RID: 137647 RVA: 0x0031B815 File Offset: 0x00319A15
		public unsafe int SettingIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQualitySetting.__PropertyOffset_SettingIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualitySetting.__PropertyOffset_SettingIndex) = value;
			}
		}

		// Token: 0x1700828F RID: 33423
		// (get) Token: 0x060219B0 RID: 137648 RVA: 0x0031B826 File Offset: 0x00319A26
		// (set) Token: 0x060219B1 RID: 137649 RVA: 0x0031B83A File Offset: 0x00319A3A
		public unsafe string SettingName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FQualitySetting.__PropertyOffset_SettingName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FQualitySetting.__PropertyOffset_SettingName)), value);
			}
		}

		// Token: 0x17008290 RID: 33424
		// (get) Token: 0x060219B2 RID: 137650 RVA: 0x0031B84F File Offset: 0x00319A4F
		// (set) Token: 0x060219B3 RID: 137651 RVA: 0x0031B85F File Offset: 0x00319A5F
		public unsafe int DefaultQualityBase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQualitySetting.__PropertyOffset_DefaultQualityBase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualitySetting.__PropertyOffset_DefaultQualityBase) = value;
			}
		}

		// Token: 0x17008291 RID: 33425
		// (get) Token: 0x060219B4 RID: 137652 RVA: 0x0031B870 File Offset: 0x00319A70
		// (set) Token: 0x060219B5 RID: 137653 RVA: 0x0031B880 File Offset: 0x00319A80
		public unsafe int PowerPreference
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQualitySetting.__PropertyOffset_PowerPreference);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualitySetting.__PropertyOffset_PowerPreference) = value;
			}
		}

		// Token: 0x17008292 RID: 33426
		// (get) Token: 0x060219B6 RID: 137654 RVA: 0x0031B894 File Offset: 0x00319A94
		// (set) Token: 0x060219B7 RID: 137655 RVA: 0x0031B8D7 File Offset: 0x00319AD7
		public TArray<FQualityFeature> FeatureSettings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FQualityFeature> result;
				if ((result = this._FeatureSettings) == null)
				{
					result = (this._FeatureSettings = new TArray<FQualityFeature>(base.NativePtr + (IntPtr)FQualitySetting.__PropertyOffset_FeatureSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FeatureSettings.CopyAssign(value);
			}
		}

		// Token: 0x060219B8 RID: 137656 RVA: 0x0031B8E5 File Offset: 0x00319AE5
		public FQualitySetting()
		{
		}

		// Token: 0x060219B9 RID: 137657 RVA: 0x0031B8ED File Offset: 0x00319AED
		public FQualitySetting(int SettingId, int SettingIndex, string SettingName, int DefaultQualityBase, int PowerPreference, TArray<FQualityFeature> FeatureSettings)
		{
			this.SettingId = SettingId;
			this.SettingIndex = SettingIndex;
			this.SettingName = SettingName;
			this.DefaultQualityBase = DefaultQualityBase;
			this.PowerPreference = PowerPreference;
			this.FeatureSettings = FeatureSettings;
		}

		// Token: 0x060219BA RID: 137658 RVA: 0x0031B922 File Offset: 0x00319B22
		protected override IntPtr GetUStructPtr()
		{
			return FQualitySetting.StaticStruct();
		}

		// Token: 0x060219BB RID: 137659 RVA: 0x0031B92E File Offset: 0x00319B2E
		[NullableContext(2)]
		public FQualitySetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060219BC RID: 137660 RVA: 0x0031B938 File Offset: 0x00319B38
		public FQualitySetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060219BD RID: 137661 RVA: 0x0031B943 File Offset: 0x00319B43
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FQualitySetting(Pointer, false, true);
		}

		// Token: 0x060219BE RID: 137662 RVA: 0x0031B94D File Offset: 0x00319B4D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FQualitySetting(Pointer, MemoryOwner);
		}

		// Token: 0x04011F14 RID: 73492
		public const string __ObjectPath = "/Script/MagtModule.QualitySetting";

		// Token: 0x04011F15 RID: 73493
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011F16 RID: 73494
		internal static int __PropertyOffset_SettingId;

		// Token: 0x04011F17 RID: 73495
		internal static int __PropertyOffset_SettingIndex;

		// Token: 0x04011F18 RID: 73496
		internal static int __PropertyOffset_SettingName;

		// Token: 0x04011F19 RID: 73497
		internal static int __PropertyOffset_DefaultQualityBase;

		// Token: 0x04011F1A RID: 73498
		internal static int __PropertyOffset_PowerPreference;

		// Token: 0x04011F1B RID: 73499
		internal static int __PropertyOffset_FeatureSettings;

		// Token: 0x04011F1C RID: 73500
		[Nullable(2)]
		private TArray<FQualityFeature> _FeatureSettings;
	}
}
