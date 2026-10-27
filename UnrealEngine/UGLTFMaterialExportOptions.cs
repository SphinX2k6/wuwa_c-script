using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200144D RID: 5197
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GLTFExporter.GLTFMaterialExportOptions")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UGLTFMaterialExportOptions : UAssetUserData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601301F RID: 77855 RVA: 0x001BF1DB File Offset: 0x001BD3DB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGLTFMaterialExportOptions._ClassPtr;
		}

		// Token: 0x06013020 RID: 77856 RVA: 0x001BF1E8 File Offset: 0x001BD3E8
		public UGLTFMaterialExportOptions() : this(BuiltinUtils.AllocNativeUObject(UGLTFMaterialExportOptions.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013021 RID: 77857 RVA: 0x001BF210 File Offset: 0x001BD410
		public UGLTFMaterialExportOptions(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGLTFMaterialExportOptions.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170049F2 RID: 18930
		// (get) Token: 0x06013022 RID: 77858 RVA: 0x001BF243 File Offset: 0x001BD443
		// (set) Token: 0x06013023 RID: 77859 RVA: 0x001BF257 File Offset: 0x001BD457
		[Nullable(2)]
		public unsafe UMaterialInterface Proxy
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UGLTFMaterialExportOptions.__PropertyOffset_Proxy);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGLTFMaterialExportOptions.__PropertyOffset_Proxy, value);
			}
		}

		// Token: 0x170049F3 RID: 18931
		// (get) Token: 0x06013024 RID: 77860 RVA: 0x001BF26C File Offset: 0x001BD46C
		// (set) Token: 0x06013025 RID: 77861 RVA: 0x001BF2A5 File Offset: 0x001BD4A5
		public FGLTFOverrideMaterialBakeSettings Default
		{
			get
			{
				base.FastCheckIsValid();
				FGLTFOverrideMaterialBakeSettings result;
				if ((result = this._Default) == null)
				{
					result = (this._Default = new FGLTFOverrideMaterialBakeSettings(base.NativePtr + (IntPtr)UGLTFMaterialExportOptions.__PropertyOffset_Default, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGLTFOverrideMaterialBakeSettings.StaticStruct(), base.NativePtr + (IntPtr)UGLTFMaterialExportOptions.__PropertyOffset_Default, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170049F4 RID: 18932
		// (get) Token: 0x06013026 RID: 77862 RVA: 0x001BF2C8 File Offset: 0x001BD4C8
		// (set) Token: 0x06013027 RID: 77863 RVA: 0x001BF301 File Offset: 0x001BD501
		public TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings> Inputs
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings> result;
				if ((result = this._Inputs) == null)
				{
					result = (this._Inputs = new TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings>(base.NativePtr + (IntPtr)UGLTFMaterialExportOptions.__PropertyOffset_Inputs, this));
				}
				return result;
			}
			set
			{
				this.Inputs.CopyAssign(value);
			}
		}

		// Token: 0x06013028 RID: 77864 RVA: 0x001BF30F File Offset: 0x001BD50F
		static UGLTFMaterialExportOptions()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GLTFExporter.GLTFMaterialExportOptions");
		}

		// Token: 0x06013029 RID: 77865 RVA: 0x001BF31D File Offset: 0x001BD51D
		protected UGLTFMaterialExportOptions(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A2A5 RID: 41637
		public new const string __ObjectPath = "/Script/GLTFExporter.GLTFMaterialExportOptions";

		// Token: 0x0400A2A6 RID: 41638
		private static IntPtr _ClassPtr;

		// Token: 0x0400A2A7 RID: 41639
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A2A8 RID: 41640
		internal static int __PropertyOffset_Proxy;

		// Token: 0x0400A2A9 RID: 41641
		internal static int __PropertyOffset_Default;

		// Token: 0x0400A2AA RID: 41642
		[Nullable(2)]
		private FGLTFOverrideMaterialBakeSettings _Default;

		// Token: 0x0400A2AB RID: 41643
		internal static int __PropertyOffset_Inputs;

		// Token: 0x0400A2AC RID: 41644
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings> _Inputs;
	}
}
