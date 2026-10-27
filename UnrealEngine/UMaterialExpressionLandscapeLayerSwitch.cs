using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F9E RID: 8094
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.MaterialExpressionLandscapeLayerSwitch")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UMaterialExpressionLandscapeLayerSwitch : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB86 RID: 125830 RVA: 0x002DAB65 File Offset: 0x002D8D65
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeLayerSwitch._ClassPtr;
		}

		// Token: 0x0601EB87 RID: 125831 RVA: 0x002DAB74 File Offset: 0x002D8D74
		public UMaterialExpressionLandscapeLayerSwitch() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeLayerSwitch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB88 RID: 125832 RVA: 0x002DAB9C File Offset: 0x002D8D9C
		public UMaterialExpressionLandscapeLayerSwitch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeLayerSwitch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A60 RID: 31328
		// (get) Token: 0x0601EB89 RID: 125833 RVA: 0x002DABD0 File Offset: 0x002D8DD0
		// (set) Token: 0x0601EB8A RID: 125834 RVA: 0x002DAC09 File Offset: 0x002D8E09
		public FExpressionInput LayerUsed
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._LayerUsed) == null)
				{
					result = (this._LayerUsed = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSwitch.__PropertyOffset_LayerUsed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSwitch.__PropertyOffset_LayerUsed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007A61 RID: 31329
		// (get) Token: 0x0601EB8B RID: 125835 RVA: 0x002DAC2C File Offset: 0x002D8E2C
		// (set) Token: 0x0601EB8C RID: 125836 RVA: 0x002DAC65 File Offset: 0x002D8E65
		public FExpressionInput LayerNotUsed
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._LayerNotUsed) == null)
				{
					result = (this._LayerNotUsed = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSwitch.__PropertyOffset_LayerNotUsed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSwitch.__PropertyOffset_LayerNotUsed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007A62 RID: 31330
		// (get) Token: 0x0601EB8D RID: 125837 RVA: 0x002DAC86 File Offset: 0x002D8E86
		// (set) Token: 0x0601EB8E RID: 125838 RVA: 0x002DAC9A File Offset: 0x002D8E9A
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSwitch.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSwitch.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17007A63 RID: 31331
		// (get) Token: 0x0601EB8F RID: 125839 RVA: 0x002DACAF File Offset: 0x002D8EAF
		// (set) Token: 0x0601EB90 RID: 125840 RVA: 0x002DACC8 File Offset: 0x002D8EC8
		public unsafe bool PreviewUsed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSwitch.__PropertyOffset_PreviewUsed) & UMaterialExpressionLandscapeLayerSwitch.__PropertyMask_PreviewUsed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSwitch.__PropertyOffset_PreviewUsed) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSwitch.__PropertyOffset_PreviewUsed) & ~UMaterialExpressionLandscapeLayerSwitch.__PropertyMask_PreviewUsed) | (value ? UMaterialExpressionLandscapeLayerSwitch.__PropertyMask_PreviewUsed : 0));
			}
		}

		// Token: 0x17007A64 RID: 31332
		// (get) Token: 0x0601EB91 RID: 125841 RVA: 0x002DACF8 File Offset: 0x002D8EF8
		// (set) Token: 0x0601EB92 RID: 125842 RVA: 0x002DAD0C File Offset: 0x002D8F0C
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSwitch.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSwitch.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x0601EB93 RID: 125843 RVA: 0x002DAD21 File Offset: 0x002D8F21
		static UMaterialExpressionLandscapeLayerSwitch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.MaterialExpressionLandscapeLayerSwitch");
		}

		// Token: 0x0601EB94 RID: 125844 RVA: 0x002DAD2F File Offset: 0x002D8F2F
		protected UMaterialExpressionLandscapeLayerSwitch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109C2 RID: 68034
		public new const string __ObjectPath = "/Script/Landscape.MaterialExpressionLandscapeLayerSwitch";

		// Token: 0x040109C3 RID: 68035
		private static IntPtr _ClassPtr;

		// Token: 0x040109C4 RID: 68036
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109C5 RID: 68037
		internal static int __PropertyOffset_LayerUsed;

		// Token: 0x040109C6 RID: 68038
		[Nullable(2)]
		private FExpressionInput _LayerUsed;

		// Token: 0x040109C7 RID: 68039
		internal static int __PropertyOffset_LayerNotUsed;

		// Token: 0x040109C8 RID: 68040
		[Nullable(2)]
		private FExpressionInput _LayerNotUsed;

		// Token: 0x040109C9 RID: 68041
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x040109CA RID: 68042
		internal static int __PropertyOffset_PreviewUsed;

		// Token: 0x040109CB RID: 68043
		internal static byte __PropertyMask_PreviewUsed;

		// Token: 0x040109CC RID: 68044
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
