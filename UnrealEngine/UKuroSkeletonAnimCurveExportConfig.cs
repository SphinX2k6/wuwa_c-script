using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000302 RID: 770
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroSkeletonAnimCurveExportConfig")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroSkeletonAnimCurveExportConfig : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060052E7 RID: 21223 RVA: 0x00073E24 File Offset: 0x00072024
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSkeletonAnimCurveExportConfig._ClassPtr;
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x00073E30 File Offset: 0x00072030
		public UKuroSkeletonAnimCurveExportConfig() : this(BuiltinUtils.AllocNativeUObject(UKuroSkeletonAnimCurveExportConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x00073E58 File Offset: 0x00072058
		public UKuroSkeletonAnimCurveExportConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSkeletonAnimCurveExportConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x060052EA RID: 21226 RVA: 0x00073E8B File Offset: 0x0007208B
		// (set) Token: 0x060052EB RID: 21227 RVA: 0x00073E9F File Offset: 0x0007209F
		public unsafe FName ReferenceBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSkeletonAnimCurveExportConfig.__PropertyOffset_ReferenceBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSkeletonAnimCurveExportConfig.__PropertyOffset_ReferenceBoneName) = value;
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x060052EC RID: 21228 RVA: 0x00073EB4 File Offset: 0x000720B4
		// (set) Token: 0x060052ED RID: 21229 RVA: 0x00073EED File Offset: 0x000720ED
		public TArray<FKuroBoneTranslationCurveExportInfo> BoneTranslationCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroBoneTranslationCurveExportInfo> result;
				if ((result = this._BoneTranslationCurves) == null)
				{
					result = (this._BoneTranslationCurves = new TArray<FKuroBoneTranslationCurveExportInfo>(base.NativePtr + (IntPtr)UKuroSkeletonAnimCurveExportConfig.__PropertyOffset_BoneTranslationCurves, this));
				}
				return result;
			}
			set
			{
				this.BoneTranslationCurves.CopyAssign(value);
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x060052EE RID: 21230 RVA: 0x00073EFB File Offset: 0x000720FB
		// (set) Token: 0x060052EF RID: 21231 RVA: 0x00073F10 File Offset: 0x00072110
		public TSoftObjectPtr<UPrimaryDataAsset> SceneBattleInteractConfig
		{
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)UKuroSkeletonAnimCurveExportConfig.__PropertyOffset_SceneBattleInteractConfig, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UKuroSkeletonAnimCurveExportConfig.__PropertyOffset_SceneBattleInteractConfig, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x060052F0 RID: 21232 RVA: 0x00073F35 File Offset: 0x00072135
		// (set) Token: 0x060052F1 RID: 21233 RVA: 0x00073F45 File Offset: 0x00072145
		public unsafe float FootprintTriggerHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSkeletonAnimCurveExportConfig.__PropertyOffset_FootprintTriggerHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSkeletonAnimCurveExportConfig.__PropertyOffset_FootprintTriggerHeight) = value;
			}
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x00073F56 File Offset: 0x00072156
		static UKuroSkeletonAnimCurveExportConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroSkeletonAnimCurveExportConfig");
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x00073F64 File Offset: 0x00072164
		protected UKuroSkeletonAnimCurveExportConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040021CD RID: 8653
		public new const string __ObjectPath = "/Script/KuroAnim.KuroSkeletonAnimCurveExportConfig";

		// Token: 0x040021CE RID: 8654
		private static IntPtr _ClassPtr;

		// Token: 0x040021CF RID: 8655
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040021D0 RID: 8656
		internal static int __PropertyOffset_ReferenceBoneName;

		// Token: 0x040021D1 RID: 8657
		internal static int __PropertyOffset_BoneTranslationCurves;

		// Token: 0x040021D2 RID: 8658
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroBoneTranslationCurveExportInfo> _BoneTranslationCurves;

		// Token: 0x040021D3 RID: 8659
		internal static int __PropertyOffset_SceneBattleInteractConfig;

		// Token: 0x040021D4 RID: 8660
		internal static int __PropertyOffset_FootprintTriggerHeight;
	}
}
