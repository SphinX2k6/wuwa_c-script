using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200144F RID: 5199
	[UnrealObjectPath("/Script/GLTFExporter.GLTFProxyOptions")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UGLTFProxyOptions : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601303E RID: 77886 RVA: 0x001BF491 File Offset: 0x001BD691
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGLTFProxyOptions._ClassPtr;
		}

		// Token: 0x0601303F RID: 77887 RVA: 0x001BF4A0 File Offset: 0x001BD6A0
		public UGLTFProxyOptions() : this(BuiltinUtils.AllocNativeUObject(UGLTFProxyOptions.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013040 RID: 77888 RVA: 0x001BF4C8 File Offset: 0x001BD6C8
		[NullableContext(1)]
		public UGLTFProxyOptions(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGLTFProxyOptions.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170049FB RID: 18939
		// (get) Token: 0x06013041 RID: 77889 RVA: 0x001BF4FB File Offset: 0x001BD6FB
		// (set) Token: 0x06013042 RID: 77890 RVA: 0x001BF50B File Offset: 0x001BD70B
		public unsafe bool bBakeMaterialInputs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFProxyOptions.__PropertyOffset_bBakeMaterialInputs) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFProxyOptions.__PropertyOffset_bBakeMaterialInputs) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049FC RID: 18940
		// (get) Token: 0x06013043 RID: 77891 RVA: 0x001BF51C File Offset: 0x001BD71C
		// (set) Token: 0x06013044 RID: 77892 RVA: 0x001BF52C File Offset: 0x001BD72C
		public unsafe EGLTFMaterialBakeSizePOT DefaultMaterialBakeSize
		{
			get
			{
				return (EGLTFMaterialBakeSizePOT)(*(base.NativePtr + (IntPtr)UGLTFProxyOptions.__PropertyOffset_DefaultMaterialBakeSize));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFProxyOptions.__PropertyOffset_DefaultMaterialBakeSize) = (byte)value;
			}
		}

		// Token: 0x170049FD RID: 18941
		// (get) Token: 0x06013045 RID: 77893 RVA: 0x001BF53D File Offset: 0x001BD73D
		// (set) Token: 0x06013046 RID: 77894 RVA: 0x001BF551 File Offset: 0x001BD751
		public unsafe TEnumAsByte<TextureFilter> DefaultMaterialBakeFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFProxyOptions.__PropertyOffset_DefaultMaterialBakeFilter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFProxyOptions.__PropertyOffset_DefaultMaterialBakeFilter) = value;
			}
		}

		// Token: 0x170049FE RID: 18942
		// (get) Token: 0x06013047 RID: 77895 RVA: 0x001BF566 File Offset: 0x001BD766
		// (set) Token: 0x06013048 RID: 77896 RVA: 0x001BF57A File Offset: 0x001BD77A
		public unsafe TEnumAsByte<TextureAddress> DefaultMaterialBakeTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFProxyOptions.__PropertyOffset_DefaultMaterialBakeTiling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFProxyOptions.__PropertyOffset_DefaultMaterialBakeTiling) = value;
			}
		}

		// Token: 0x170049FF RID: 18943
		// (get) Token: 0x06013049 RID: 77897 RVA: 0x001BF590 File Offset: 0x001BD790
		// (set) Token: 0x0601304A RID: 77898 RVA: 0x001BF5C9 File Offset: 0x001BD7C9
		[Nullable(1)]
		public TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings> DefaultInputBakeSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings> result;
				if ((result = this._DefaultInputBakeSettings) == null)
				{
					result = (this._DefaultInputBakeSettings = new TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings>(base.NativePtr + (IntPtr)UGLTFProxyOptions.__PropertyOffset_DefaultInputBakeSettings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DefaultInputBakeSettings.CopyAssign(value);
			}
		}

		// Token: 0x0601304B RID: 77899 RVA: 0x001BF5D7 File Offset: 0x001BD7D7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ResetToDefault()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UGLTFProxyOptions.__ResetToDefault_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601304C RID: 77900 RVA: 0x001BF5EC File Offset: 0x001BD7EC
		static UGLTFProxyOptions()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GLTFExporter.GLTFProxyOptions");
		}

		// Token: 0x0601304D RID: 77901 RVA: 0x001BF5FA File Offset: 0x001BD7FA
		protected UGLTFProxyOptions(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A2B5 RID: 41653
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GLTFExporter.GLTFProxyOptions";

		// Token: 0x0400A2B6 RID: 41654
		private static IntPtr _ClassPtr;

		// Token: 0x0400A2B7 RID: 41655
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A2B8 RID: 41656
		internal static int __PropertyOffset_bBakeMaterialInputs;

		// Token: 0x0400A2B9 RID: 41657
		internal static int __PropertyOffset_DefaultMaterialBakeSize;

		// Token: 0x0400A2BA RID: 41658
		internal static int __PropertyOffset_DefaultMaterialBakeFilter;

		// Token: 0x0400A2BB RID: 41659
		internal static int __PropertyOffset_DefaultMaterialBakeTiling;

		// Token: 0x0400A2BC RID: 41660
		internal static int __PropertyOffset_DefaultInputBakeSettings;

		// Token: 0x0400A2BD RID: 41661
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings> _DefaultInputBakeSettings;

		// Token: 0x0400A2BE RID: 41662
		private static IntPtr __ResetToDefault_NativeFunctionPtr;
	}
}
