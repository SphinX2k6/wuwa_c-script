using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E2D RID: 3629
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionRuntimeVirtualTextureOutput")]
	[UnrealStructLayout(584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 584)]
	public class UMaterialExpressionRuntimeVirtualTextureOutput : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C319 RID: 49945 RVA: 0x001198F5 File Offset: 0x00117AF5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionRuntimeVirtualTextureOutput._ClassPtr;
		}

		// Token: 0x0600C31A RID: 49946 RVA: 0x00119904 File Offset: 0x00117B04
		public UMaterialExpressionRuntimeVirtualTextureOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRuntimeVirtualTextureOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C31B RID: 49947 RVA: 0x0011992C File Offset: 0x00117B2C
		public UMaterialExpressionRuntimeVirtualTextureOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRuntimeVirtualTextureOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D3F RID: 11583
		// (get) Token: 0x0600C31C RID: 49948 RVA: 0x00119960 File Offset: 0x00117B60
		// (set) Token: 0x0600C31D RID: 49949 RVA: 0x00119999 File Offset: 0x00117B99
		public FExpressionInput BaseColor
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._BaseColor) == null)
				{
					result = (this._BaseColor = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureOutput.__PropertyOffset_BaseColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureOutput.__PropertyOffset_BaseColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D40 RID: 11584
		// (get) Token: 0x0600C31E RID: 49950 RVA: 0x001199BC File Offset: 0x00117BBC
		// (set) Token: 0x0600C31F RID: 49951 RVA: 0x001199F5 File Offset: 0x00117BF5
		public FExpressionInput Specular
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Specular) == null)
				{
					result = (this._Specular = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureOutput.__PropertyOffset_Specular, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureOutput.__PropertyOffset_Specular, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D41 RID: 11585
		// (get) Token: 0x0600C320 RID: 49952 RVA: 0x00119A18 File Offset: 0x00117C18
		// (set) Token: 0x0600C321 RID: 49953 RVA: 0x00119A51 File Offset: 0x00117C51
		public FExpressionInput Roughness
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Roughness) == null)
				{
					result = (this._Roughness = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureOutput.__PropertyOffset_Roughness, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureOutput.__PropertyOffset_Roughness, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D42 RID: 11586
		// (get) Token: 0x0600C322 RID: 49954 RVA: 0x00119A74 File Offset: 0x00117C74
		// (set) Token: 0x0600C323 RID: 49955 RVA: 0x00119AAD File Offset: 0x00117CAD
		public FExpressionInput Normal
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Normal) == null)
				{
					result = (this._Normal = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureOutput.__PropertyOffset_Normal, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureOutput.__PropertyOffset_Normal, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D43 RID: 11587
		// (get) Token: 0x0600C324 RID: 49956 RVA: 0x00119AD0 File Offset: 0x00117CD0
		// (set) Token: 0x0600C325 RID: 49957 RVA: 0x00119B09 File Offset: 0x00117D09
		public FExpressionInput WorldHeight
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._WorldHeight) == null)
				{
					result = (this._WorldHeight = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureOutput.__PropertyOffset_WorldHeight, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureOutput.__PropertyOffset_WorldHeight, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D44 RID: 11588
		// (get) Token: 0x0600C326 RID: 49958 RVA: 0x00119B2C File Offset: 0x00117D2C
		// (set) Token: 0x0600C327 RID: 49959 RVA: 0x00119B65 File Offset: 0x00117D65
		public FExpressionInput Opacity
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Opacity) == null)
				{
					result = (this._Opacity = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureOutput.__PropertyOffset_Opacity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureOutput.__PropertyOffset_Opacity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D45 RID: 11589
		// (get) Token: 0x0600C328 RID: 49960 RVA: 0x00119B88 File Offset: 0x00117D88
		// (set) Token: 0x0600C329 RID: 49961 RVA: 0x00119BC1 File Offset: 0x00117DC1
		public FExpressionInput Mask
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Mask) == null)
				{
					result = (this._Mask = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureOutput.__PropertyOffset_Mask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureOutput.__PropertyOffset_Mask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C32A RID: 49962 RVA: 0x00119BE2 File Offset: 0x00117DE2
		static UMaterialExpressionRuntimeVirtualTextureOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionRuntimeVirtualTextureOutput");
		}

		// Token: 0x0600C32B RID: 49963 RVA: 0x00119BF0 File Offset: 0x00117DF0
		protected UMaterialExpressionRuntimeVirtualTextureOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040067F7 RID: 26615
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionRuntimeVirtualTextureOutput";

		// Token: 0x040067F8 RID: 26616
		private static IntPtr _ClassPtr;

		// Token: 0x040067F9 RID: 26617
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040067FA RID: 26618
		internal static int __PropertyOffset_BaseColor;

		// Token: 0x040067FB RID: 26619
		[Nullable(2)]
		private FExpressionInput _BaseColor;

		// Token: 0x040067FC RID: 26620
		internal static int __PropertyOffset_Specular;

		// Token: 0x040067FD RID: 26621
		[Nullable(2)]
		private FExpressionInput _Specular;

		// Token: 0x040067FE RID: 26622
		internal static int __PropertyOffset_Roughness;

		// Token: 0x040067FF RID: 26623
		[Nullable(2)]
		private FExpressionInput _Roughness;

		// Token: 0x04006800 RID: 26624
		internal static int __PropertyOffset_Normal;

		// Token: 0x04006801 RID: 26625
		[Nullable(2)]
		private FExpressionInput _Normal;

		// Token: 0x04006802 RID: 26626
		internal static int __PropertyOffset_WorldHeight;

		// Token: 0x04006803 RID: 26627
		[Nullable(2)]
		private FExpressionInput _WorldHeight;

		// Token: 0x04006804 RID: 26628
		internal static int __PropertyOffset_Opacity;

		// Token: 0x04006805 RID: 26629
		[Nullable(2)]
		private FExpressionInput _Opacity;

		// Token: 0x04006806 RID: 26630
		internal static int __PropertyOffset_Mask;

		// Token: 0x04006807 RID: 26631
		[Nullable(2)]
		private FExpressionInput _Mask;
	}
}
