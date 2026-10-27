using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F9A RID: 8090
	[UnrealObjectPath("/Script/Landscape.MaterialExpressionLandscapeLayerCoords")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UMaterialExpressionLandscapeLayerCoords : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB56 RID: 125782 RVA: 0x002DA6F7 File Offset: 0x002D88F7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeLayerCoords._ClassPtr;
		}

		// Token: 0x0601EB57 RID: 125783 RVA: 0x002DA704 File Offset: 0x002D8904
		public UMaterialExpressionLandscapeLayerCoords() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeLayerCoords.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB58 RID: 125784 RVA: 0x002DA72C File Offset: 0x002D892C
		[NullableContext(1)]
		public UMaterialExpressionLandscapeLayerCoords(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeLayerCoords.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A52 RID: 31314
		// (get) Token: 0x0601EB59 RID: 125785 RVA: 0x002DA75F File Offset: 0x002D895F
		// (set) Token: 0x0601EB5A RID: 125786 RVA: 0x002DA773 File Offset: 0x002D8973
		public unsafe TEnumAsByte<ETerrainCoordMappingType> MappingType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerCoords.__PropertyOffset_MappingType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerCoords.__PropertyOffset_MappingType) = value;
			}
		}

		// Token: 0x17007A53 RID: 31315
		// (get) Token: 0x0601EB5B RID: 125787 RVA: 0x002DA788 File Offset: 0x002D8988
		// (set) Token: 0x0601EB5C RID: 125788 RVA: 0x002DA79C File Offset: 0x002D899C
		public unsafe TEnumAsByte<ELandscapeCustomizedCoordType> CustomUVType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerCoords.__PropertyOffset_CustomUVType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerCoords.__PropertyOffset_CustomUVType) = value;
			}
		}

		// Token: 0x17007A54 RID: 31316
		// (get) Token: 0x0601EB5D RID: 125789 RVA: 0x002DA7B1 File Offset: 0x002D89B1
		// (set) Token: 0x0601EB5E RID: 125790 RVA: 0x002DA7C1 File Offset: 0x002D89C1
		public unsafe float MappingScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerCoords.__PropertyOffset_MappingScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerCoords.__PropertyOffset_MappingScale) = value;
			}
		}

		// Token: 0x17007A55 RID: 31317
		// (get) Token: 0x0601EB5F RID: 125791 RVA: 0x002DA7D2 File Offset: 0x002D89D2
		// (set) Token: 0x0601EB60 RID: 125792 RVA: 0x002DA7E2 File Offset: 0x002D89E2
		public unsafe float MappingRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerCoords.__PropertyOffset_MappingRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerCoords.__PropertyOffset_MappingRotation) = value;
			}
		}

		// Token: 0x17007A56 RID: 31318
		// (get) Token: 0x0601EB61 RID: 125793 RVA: 0x002DA7F3 File Offset: 0x002D89F3
		// (set) Token: 0x0601EB62 RID: 125794 RVA: 0x002DA803 File Offset: 0x002D8A03
		public unsafe float MappingPanU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerCoords.__PropertyOffset_MappingPanU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerCoords.__PropertyOffset_MappingPanU) = value;
			}
		}

		// Token: 0x17007A57 RID: 31319
		// (get) Token: 0x0601EB63 RID: 125795 RVA: 0x002DA814 File Offset: 0x002D8A14
		// (set) Token: 0x0601EB64 RID: 125796 RVA: 0x002DA824 File Offset: 0x002D8A24
		public unsafe float MappingPanV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerCoords.__PropertyOffset_MappingPanV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerCoords.__PropertyOffset_MappingPanV) = value;
			}
		}

		// Token: 0x0601EB65 RID: 125797 RVA: 0x002DA835 File Offset: 0x002D8A35
		static UMaterialExpressionLandscapeLayerCoords()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.MaterialExpressionLandscapeLayerCoords");
		}

		// Token: 0x0601EB66 RID: 125798 RVA: 0x002DA843 File Offset: 0x002D8A43
		protected UMaterialExpressionLandscapeLayerCoords(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109A6 RID: 68006
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.MaterialExpressionLandscapeLayerCoords";

		// Token: 0x040109A7 RID: 68007
		private static IntPtr _ClassPtr;

		// Token: 0x040109A8 RID: 68008
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109A9 RID: 68009
		internal static int __PropertyOffset_MappingType;

		// Token: 0x040109AA RID: 68010
		internal static int __PropertyOffset_CustomUVType;

		// Token: 0x040109AB RID: 68011
		internal static int __PropertyOffset_MappingScale;

		// Token: 0x040109AC RID: 68012
		internal static int __PropertyOffset_MappingRotation;

		// Token: 0x040109AD RID: 68013
		internal static int __PropertyOffset_MappingPanU;

		// Token: 0x040109AE RID: 68014
		internal static int __PropertyOffset_MappingPanV;
	}
}
