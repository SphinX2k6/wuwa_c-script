using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F99 RID: 8089
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.MaterialExpressionLandscapeLayerBlend")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UMaterialExpressionLandscapeLayerBlend : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB4D RID: 125773 RVA: 0x002DA607 File Offset: 0x002D8807
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeLayerBlend._ClassPtr;
		}

		// Token: 0x0601EB4E RID: 125774 RVA: 0x002DA614 File Offset: 0x002D8814
		public UMaterialExpressionLandscapeLayerBlend() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeLayerBlend.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB4F RID: 125775 RVA: 0x002DA63C File Offset: 0x002D883C
		public UMaterialExpressionLandscapeLayerBlend(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeLayerBlend.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A50 RID: 31312
		// (get) Token: 0x0601EB50 RID: 125776 RVA: 0x002DA670 File Offset: 0x002D8870
		// (set) Token: 0x0601EB51 RID: 125777 RVA: 0x002DA6A9 File Offset: 0x002D88A9
		public TArray<FLayerBlendInput> Layers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLayerBlendInput> result;
				if ((result = this._Layers) == null)
				{
					result = (this._Layers = new TArray<FLayerBlendInput>(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerBlend.__PropertyOffset_Layers, this));
				}
				return result;
			}
			set
			{
				this.Layers.CopyAssign(value);
			}
		}

		// Token: 0x17007A51 RID: 31313
		// (get) Token: 0x0601EB52 RID: 125778 RVA: 0x002DA6B7 File Offset: 0x002D88B7
		// (set) Token: 0x0601EB53 RID: 125779 RVA: 0x002DA6CB File Offset: 0x002D88CB
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerBlend.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerBlend.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x0601EB54 RID: 125780 RVA: 0x002DA6E0 File Offset: 0x002D88E0
		static UMaterialExpressionLandscapeLayerBlend()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.MaterialExpressionLandscapeLayerBlend");
		}

		// Token: 0x0601EB55 RID: 125781 RVA: 0x002DA6EE File Offset: 0x002D88EE
		protected UMaterialExpressionLandscapeLayerBlend(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109A0 RID: 68000
		public new const string __ObjectPath = "/Script/Landscape.MaterialExpressionLandscapeLayerBlend";

		// Token: 0x040109A1 RID: 68001
		private static IntPtr _ClassPtr;

		// Token: 0x040109A2 RID: 68002
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109A3 RID: 68003
		internal static int __PropertyOffset_Layers;

		// Token: 0x040109A4 RID: 68004
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLayerBlendInput> _Layers;

		// Token: 0x040109A5 RID: 68005
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
