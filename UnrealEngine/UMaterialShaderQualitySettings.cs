using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200228D RID: 8845
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MaterialShaderQualitySettings.MaterialShaderQualitySettings")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UMaterialShaderQualitySettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060219E9 RID: 137705 RVA: 0x0031BC7C File Offset: 0x00319E7C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialShaderQualitySettings._ClassPtr;
		}

		// Token: 0x060219EA RID: 137706 RVA: 0x0031BC88 File Offset: 0x00319E88
		public UMaterialShaderQualitySettings() : this(BuiltinUtils.AllocNativeUObject(UMaterialShaderQualitySettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060219EB RID: 137707 RVA: 0x0031BCB0 File Offset: 0x00319EB0
		public UMaterialShaderQualitySettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialShaderQualitySettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082A0 RID: 33440
		// (get) Token: 0x060219EC RID: 137708 RVA: 0x0031BCE4 File Offset: 0x00319EE4
		// (set) Token: 0x060219ED RID: 137709 RVA: 0x0031BD1D File Offset: 0x00319F1D
		public TMap<FName, UShaderPlatformQualitySettings> ForwardSettingMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UShaderPlatformQualitySettings> result;
				if ((result = this._ForwardSettingMap) == null)
				{
					result = (this._ForwardSettingMap = new TMap<FName, UShaderPlatformQualitySettings>(base.NativePtr + (IntPtr)UMaterialShaderQualitySettings.__PropertyOffset_ForwardSettingMap, this));
				}
				return result;
			}
			set
			{
				this.ForwardSettingMap.CopyAssign(value);
			}
		}

		// Token: 0x060219EE RID: 137710 RVA: 0x0031BD2B File Offset: 0x00319F2B
		static UMaterialShaderQualitySettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MaterialShaderQualitySettings.MaterialShaderQualitySettings");
		}

		// Token: 0x060219EF RID: 137711 RVA: 0x0031BD39 File Offset: 0x00319F39
		protected UMaterialShaderQualitySettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F3E RID: 73534
		public new const string __ObjectPath = "/Script/MaterialShaderQualitySettings.MaterialShaderQualitySettings";

		// Token: 0x04011F3F RID: 73535
		private static IntPtr _ClassPtr;

		// Token: 0x04011F40 RID: 73536
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F41 RID: 73537
		internal static int __PropertyOffset_ForwardSettingMap;

		// Token: 0x04011F42 RID: 73538
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UShaderPlatformQualitySettings> _ForwardSettingMap;
	}
}
