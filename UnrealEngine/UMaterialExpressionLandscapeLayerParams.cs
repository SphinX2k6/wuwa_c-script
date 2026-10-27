using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F9C RID: 8092
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.MaterialExpressionLandscapeLayerParams")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UMaterialExpressionLandscapeLayerParams : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB6E RID: 125806 RVA: 0x002DA8F3 File Offset: 0x002D8AF3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeLayerParams._ClassPtr;
		}

		// Token: 0x0601EB6F RID: 125807 RVA: 0x002DA900 File Offset: 0x002D8B00
		public UMaterialExpressionLandscapeLayerParams() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeLayerParams.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB70 RID: 125808 RVA: 0x002DA928 File Offset: 0x002D8B28
		public UMaterialExpressionLandscapeLayerParams(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeLayerParams.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A59 RID: 31321
		// (get) Token: 0x0601EB71 RID: 125809 RVA: 0x002DA95C File Offset: 0x002D8B5C
		// (set) Token: 0x0601EB72 RID: 125810 RVA: 0x002DA995 File Offset: 0x002D8B95
		public FExpressionInput BufferIndex
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._BufferIndex) == null)
				{
					result = (this._BufferIndex = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerParams.__PropertyOffset_BufferIndex, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerParams.__PropertyOffset_BufferIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007A5A RID: 31322
		// (get) Token: 0x0601EB73 RID: 125811 RVA: 0x002DA9B8 File Offset: 0x002D8BB8
		// (set) Token: 0x0601EB74 RID: 125812 RVA: 0x002DA9F1 File Offset: 0x002D8BF1
		public FExpressionInput LayerIndex
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._LayerIndex) == null)
				{
					result = (this._LayerIndex = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerParams.__PropertyOffset_LayerIndex, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerParams.__PropertyOffset_LayerIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007A5B RID: 31323
		// (get) Token: 0x0601EB75 RID: 125813 RVA: 0x002DAA12 File Offset: 0x002D8C12
		// (set) Token: 0x0601EB76 RID: 125814 RVA: 0x002DAA22 File Offset: 0x002D8C22
		public unsafe uint LayerCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerParams.__PropertyOffset_LayerCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerParams.__PropertyOffset_LayerCount) = (int)value;
			}
		}

		// Token: 0x17007A5C RID: 31324
		// (get) Token: 0x0601EB77 RID: 125815 RVA: 0x002DAA33 File Offset: 0x002D8C33
		// (set) Token: 0x0601EB78 RID: 125816 RVA: 0x002DAA47 File Offset: 0x002D8C47
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerParams.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerParams.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x0601EB79 RID: 125817 RVA: 0x002DAA5C File Offset: 0x002D8C5C
		static UMaterialExpressionLandscapeLayerParams()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.MaterialExpressionLandscapeLayerParams");
		}

		// Token: 0x0601EB7A RID: 125818 RVA: 0x002DAA6A File Offset: 0x002D8C6A
		protected UMaterialExpressionLandscapeLayerParams(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109B3 RID: 68019
		public new const string __ObjectPath = "/Script/Landscape.MaterialExpressionLandscapeLayerParams";

		// Token: 0x040109B4 RID: 68020
		private static IntPtr _ClassPtr;

		// Token: 0x040109B5 RID: 68021
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109B6 RID: 68022
		internal static int __PropertyOffset_BufferIndex;

		// Token: 0x040109B7 RID: 68023
		[Nullable(2)]
		private FExpressionInput _BufferIndex;

		// Token: 0x040109B8 RID: 68024
		internal static int __PropertyOffset_LayerIndex;

		// Token: 0x040109B9 RID: 68025
		[Nullable(2)]
		private FExpressionInput _LayerIndex;

		// Token: 0x040109BA RID: 68026
		internal static int __PropertyOffset_LayerCount;

		// Token: 0x040109BB RID: 68027
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
