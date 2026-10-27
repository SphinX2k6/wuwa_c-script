using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200228E RID: 8846
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MaterialShaderQualitySettings.ShaderPlatformQualitySettings")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UShaderPlatformQualitySettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060219F0 RID: 137712 RVA: 0x0031BD42 File Offset: 0x00319F42
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UShaderPlatformQualitySettings._ClassPtr;
		}

		// Token: 0x060219F1 RID: 137713 RVA: 0x0031BD50 File Offset: 0x00319F50
		public UShaderPlatformQualitySettings() : this(BuiltinUtils.AllocNativeUObject(UShaderPlatformQualitySettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060219F2 RID: 137714 RVA: 0x0031BD78 File Offset: 0x00319F78
		public UShaderPlatformQualitySettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UShaderPlatformQualitySettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082A1 RID: 33441
		// (get) Token: 0x060219F3 RID: 137715 RVA: 0x0031BDAC File Offset: 0x00319FAC
		// (set) Token: 0x060219F4 RID: 137716 RVA: 0x0031BDE6 File Offset: 0x00319FE6
		public TFixedArray<FMaterialQualityOverrides> QualityOverrides
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMaterialQualityOverrides> result;
				if ((result = this._QualityOverrides) == null)
				{
					result = (this._QualityOverrides = new TFixedArray<FMaterialQualityOverrides>(base.NativePtr + (IntPtr)UShaderPlatformQualitySettings.__PropertyOffset_QualityOverrides, 4, this));
				}
				return result;
			}
			set
			{
				this.QualityOverrides.CopyAssign(value);
			}
		}

		// Token: 0x060219F5 RID: 137717 RVA: 0x0031BDF4 File Offset: 0x00319FF4
		static UShaderPlatformQualitySettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MaterialShaderQualitySettings.ShaderPlatformQualitySettings");
		}

		// Token: 0x060219F6 RID: 137718 RVA: 0x0031BE02 File Offset: 0x0031A002
		protected UShaderPlatformQualitySettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F43 RID: 73539
		public new const string __ObjectPath = "/Script/MaterialShaderQualitySettings.ShaderPlatformQualitySettings";

		// Token: 0x04011F44 RID: 73540
		private static IntPtr _ClassPtr;

		// Token: 0x04011F45 RID: 73541
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F46 RID: 73542
		internal static int __PropertyOffset_QualityOverrides;

		// Token: 0x04011F47 RID: 73543
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMaterialQualityOverrides> _QualityOverrides;
	}
}
