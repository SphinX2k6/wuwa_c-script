using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E82 RID: 3714
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialFunctionInstance")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UMaterialFunctionInstance : UMaterialFunctionInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C650 RID: 50768 RVA: 0x0011F4D9 File Offset: 0x0011D6D9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialFunctionInstance._ClassPtr;
		}

		// Token: 0x0600C651 RID: 50769 RVA: 0x0011F4E8 File Offset: 0x0011D6E8
		public UMaterialFunctionInstance() : this(BuiltinUtils.AllocNativeUObject(UMaterialFunctionInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C652 RID: 50770 RVA: 0x0011F510 File Offset: 0x0011D710
		public UMaterialFunctionInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialFunctionInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x0600C653 RID: 50771 RVA: 0x0011F543 File Offset: 0x0011D743
		// (set) Token: 0x0600C654 RID: 50772 RVA: 0x0011F557 File Offset: 0x0011D757
		[Nullable(2)]
		public unsafe UMaterialFunctionInterface Parent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialFunctionInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialFunctionInstance.__PropertyOffset_Parent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialFunctionInstance.__PropertyOffset_Parent, value);
			}
		}

		// Token: 0x17002E07 RID: 11783
		// (get) Token: 0x0600C655 RID: 50773 RVA: 0x0011F56C File Offset: 0x0011D76C
		// (set) Token: 0x0600C656 RID: 50774 RVA: 0x0011F580 File Offset: 0x0011D780
		[Nullable(2)]
		public unsafe UMaterialFunctionInterface Base
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialFunctionInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialFunctionInstance.__PropertyOffset_Base);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialFunctionInstance.__PropertyOffset_Base, value);
			}
		}

		// Token: 0x17002E08 RID: 11784
		// (get) Token: 0x0600C657 RID: 50775 RVA: 0x0011F598 File Offset: 0x0011D798
		// (set) Token: 0x0600C658 RID: 50776 RVA: 0x0011F5D1 File Offset: 0x0011D7D1
		public TArray<FScalarParameterValue> ScalarParameterValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FScalarParameterValue> result;
				if ((result = this._ScalarParameterValues) == null)
				{
					result = (this._ScalarParameterValues = new TArray<FScalarParameterValue>(base.NativePtr + (IntPtr)UMaterialFunctionInstance.__PropertyOffset_ScalarParameterValues, this));
				}
				return result;
			}
			set
			{
				this.ScalarParameterValues.CopyAssign(value);
			}
		}

		// Token: 0x17002E09 RID: 11785
		// (get) Token: 0x0600C659 RID: 50777 RVA: 0x0011F5E0 File Offset: 0x0011D7E0
		// (set) Token: 0x0600C65A RID: 50778 RVA: 0x0011F619 File Offset: 0x0011D819
		public TArray<FVectorParameterValue> VectorParameterValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorParameterValue> result;
				if ((result = this._VectorParameterValues) == null)
				{
					result = (this._VectorParameterValues = new TArray<FVectorParameterValue>(base.NativePtr + (IntPtr)UMaterialFunctionInstance.__PropertyOffset_VectorParameterValues, this));
				}
				return result;
			}
			set
			{
				this.VectorParameterValues.CopyAssign(value);
			}
		}

		// Token: 0x17002E0A RID: 11786
		// (get) Token: 0x0600C65B RID: 50779 RVA: 0x0011F628 File Offset: 0x0011D828
		// (set) Token: 0x0600C65C RID: 50780 RVA: 0x0011F661 File Offset: 0x0011D861
		public TArray<FTextureParameterValue> TextureParameterValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTextureParameterValue> result;
				if ((result = this._TextureParameterValues) == null)
				{
					result = (this._TextureParameterValues = new TArray<FTextureParameterValue>(base.NativePtr + (IntPtr)UMaterialFunctionInstance.__PropertyOffset_TextureParameterValues, this));
				}
				return result;
			}
			set
			{
				this.TextureParameterValues.CopyAssign(value);
			}
		}

		// Token: 0x17002E0B RID: 11787
		// (get) Token: 0x0600C65D RID: 50781 RVA: 0x0011F670 File Offset: 0x0011D870
		// (set) Token: 0x0600C65E RID: 50782 RVA: 0x0011F6A9 File Offset: 0x0011D8A9
		public TArray<FFontParameterValue> FontParameterValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFontParameterValue> result;
				if ((result = this._FontParameterValues) == null)
				{
					result = (this._FontParameterValues = new TArray<FFontParameterValue>(base.NativePtr + (IntPtr)UMaterialFunctionInstance.__PropertyOffset_FontParameterValues, this));
				}
				return result;
			}
			set
			{
				this.FontParameterValues.CopyAssign(value);
			}
		}

		// Token: 0x17002E0C RID: 11788
		// (get) Token: 0x0600C65F RID: 50783 RVA: 0x0011F6B8 File Offset: 0x0011D8B8
		// (set) Token: 0x0600C660 RID: 50784 RVA: 0x0011F6F1 File Offset: 0x0011D8F1
		public TArray<FStaticSwitchParameter> StaticSwitchParameterValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStaticSwitchParameter> result;
				if ((result = this._StaticSwitchParameterValues) == null)
				{
					result = (this._StaticSwitchParameterValues = new TArray<FStaticSwitchParameter>(base.NativePtr + (IntPtr)UMaterialFunctionInstance.__PropertyOffset_StaticSwitchParameterValues, this));
				}
				return result;
			}
			set
			{
				this.StaticSwitchParameterValues.CopyAssign(value);
			}
		}

		// Token: 0x17002E0D RID: 11789
		// (get) Token: 0x0600C661 RID: 50785 RVA: 0x0011F700 File Offset: 0x0011D900
		// (set) Token: 0x0600C662 RID: 50786 RVA: 0x0011F739 File Offset: 0x0011D939
		public TArray<FStaticComponentMaskParameter> StaticComponentMaskParameterValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStaticComponentMaskParameter> result;
				if ((result = this._StaticComponentMaskParameterValues) == null)
				{
					result = (this._StaticComponentMaskParameterValues = new TArray<FStaticComponentMaskParameter>(base.NativePtr + (IntPtr)UMaterialFunctionInstance.__PropertyOffset_StaticComponentMaskParameterValues, this));
				}
				return result;
			}
			set
			{
				this.StaticComponentMaskParameterValues.CopyAssign(value);
			}
		}

		// Token: 0x17002E0E RID: 11790
		// (get) Token: 0x0600C663 RID: 50787 RVA: 0x0011F748 File Offset: 0x0011D948
		// (set) Token: 0x0600C664 RID: 50788 RVA: 0x0011F781 File Offset: 0x0011D981
		public TArray<FRuntimeVirtualTextureParameterValue> RuntimeVirtualTextureParameterValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRuntimeVirtualTextureParameterValue> result;
				if ((result = this._RuntimeVirtualTextureParameterValues) == null)
				{
					result = (this._RuntimeVirtualTextureParameterValues = new TArray<FRuntimeVirtualTextureParameterValue>(base.NativePtr + (IntPtr)UMaterialFunctionInstance.__PropertyOffset_RuntimeVirtualTextureParameterValues, this));
				}
				return result;
			}
			set
			{
				this.RuntimeVirtualTextureParameterValues.CopyAssign(value);
			}
		}

		// Token: 0x0600C665 RID: 50789 RVA: 0x0011F78F File Offset: 0x0011D98F
		static UMaterialFunctionInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialFunctionInstance");
		}

		// Token: 0x0600C666 RID: 50790 RVA: 0x0011F79D File Offset: 0x0011D99D
		protected UMaterialFunctionInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006A27 RID: 27175
		public new const string __ObjectPath = "/Script/Engine.MaterialFunctionInstance";

		// Token: 0x04006A28 RID: 27176
		private static IntPtr _ClassPtr;

		// Token: 0x04006A29 RID: 27177
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006A2A RID: 27178
		internal static int __PropertyOffset_Parent;

		// Token: 0x04006A2B RID: 27179
		internal static int __PropertyOffset_Base;

		// Token: 0x04006A2C RID: 27180
		internal static int __PropertyOffset_ScalarParameterValues;

		// Token: 0x04006A2D RID: 27181
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FScalarParameterValue> _ScalarParameterValues;

		// Token: 0x04006A2E RID: 27182
		internal static int __PropertyOffset_VectorParameterValues;

		// Token: 0x04006A2F RID: 27183
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVectorParameterValue> _VectorParameterValues;

		// Token: 0x04006A30 RID: 27184
		internal static int __PropertyOffset_TextureParameterValues;

		// Token: 0x04006A31 RID: 27185
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTextureParameterValue> _TextureParameterValues;

		// Token: 0x04006A32 RID: 27186
		internal static int __PropertyOffset_FontParameterValues;

		// Token: 0x04006A33 RID: 27187
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFontParameterValue> _FontParameterValues;

		// Token: 0x04006A34 RID: 27188
		internal static int __PropertyOffset_StaticSwitchParameterValues;

		// Token: 0x04006A35 RID: 27189
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStaticSwitchParameter> _StaticSwitchParameterValues;

		// Token: 0x04006A36 RID: 27190
		internal static int __PropertyOffset_StaticComponentMaskParameterValues;

		// Token: 0x04006A37 RID: 27191
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStaticComponentMaskParameter> _StaticComponentMaskParameterValues;

		// Token: 0x04006A38 RID: 27192
		internal static int __PropertyOffset_RuntimeVirtualTextureParameterValues;

		// Token: 0x04006A39 RID: 27193
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRuntimeVirtualTextureParameterValue> _RuntimeVirtualTextureParameterValues;
	}
}
