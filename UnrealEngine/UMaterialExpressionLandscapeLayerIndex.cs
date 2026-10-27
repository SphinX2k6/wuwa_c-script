using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F9B RID: 8091
	[UnrealObjectPath("/Script/Landscape.MaterialExpressionLandscapeLayerIndex")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UMaterialExpressionLandscapeLayerIndex : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB67 RID: 125799 RVA: 0x002DA84C File Offset: 0x002D8A4C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeLayerIndex._ClassPtr;
		}

		// Token: 0x0601EB68 RID: 125800 RVA: 0x002DA858 File Offset: 0x002D8A58
		public UMaterialExpressionLandscapeLayerIndex() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeLayerIndex.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB69 RID: 125801 RVA: 0x002DA880 File Offset: 0x002D8A80
		[NullableContext(1)]
		public UMaterialExpressionLandscapeLayerIndex(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeLayerIndex.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A58 RID: 31320
		// (get) Token: 0x0601EB6A RID: 125802 RVA: 0x002DA8B3 File Offset: 0x002D8AB3
		// (set) Token: 0x0601EB6B RID: 125803 RVA: 0x002DA8C7 File Offset: 0x002D8AC7
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerIndex.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerIndex.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x0601EB6C RID: 125804 RVA: 0x002DA8DC File Offset: 0x002D8ADC
		static UMaterialExpressionLandscapeLayerIndex()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.MaterialExpressionLandscapeLayerIndex");
		}

		// Token: 0x0601EB6D RID: 125805 RVA: 0x002DA8EA File Offset: 0x002D8AEA
		protected UMaterialExpressionLandscapeLayerIndex(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109AF RID: 68015
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.MaterialExpressionLandscapeLayerIndex";

		// Token: 0x040109B0 RID: 68016
		private static IntPtr _ClassPtr;

		// Token: 0x040109B1 RID: 68017
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109B2 RID: 68018
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
