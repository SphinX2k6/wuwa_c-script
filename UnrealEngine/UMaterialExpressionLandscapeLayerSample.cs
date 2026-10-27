using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F9D RID: 8093
	[UnrealObjectPath("/Script/Landscape.MaterialExpressionLandscapeLayerSample")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UMaterialExpressionLandscapeLayerSample : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB7B RID: 125819 RVA: 0x002DAA73 File Offset: 0x002D8C73
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeLayerSample._ClassPtr;
		}

		// Token: 0x0601EB7C RID: 125820 RVA: 0x002DAA80 File Offset: 0x002D8C80
		public UMaterialExpressionLandscapeLayerSample() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeLayerSample.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB7D RID: 125821 RVA: 0x002DAAA8 File Offset: 0x002D8CA8
		[NullableContext(1)]
		public UMaterialExpressionLandscapeLayerSample(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeLayerSample.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A5D RID: 31325
		// (get) Token: 0x0601EB7E RID: 125822 RVA: 0x002DAADB File Offset: 0x002D8CDB
		// (set) Token: 0x0601EB7F RID: 125823 RVA: 0x002DAAEF File Offset: 0x002D8CEF
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSample.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSample.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17007A5E RID: 31326
		// (get) Token: 0x0601EB80 RID: 125824 RVA: 0x002DAB04 File Offset: 0x002D8D04
		// (set) Token: 0x0601EB81 RID: 125825 RVA: 0x002DAB14 File Offset: 0x002D8D14
		public unsafe float PreviewWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSample.__PropertyOffset_PreviewWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSample.__PropertyOffset_PreviewWeight) = value;
			}
		}

		// Token: 0x17007A5F RID: 31327
		// (get) Token: 0x0601EB82 RID: 125826 RVA: 0x002DAB25 File Offset: 0x002D8D25
		// (set) Token: 0x0601EB83 RID: 125827 RVA: 0x002DAB39 File Offset: 0x002D8D39
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSample.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerSample.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x0601EB84 RID: 125828 RVA: 0x002DAB4E File Offset: 0x002D8D4E
		static UMaterialExpressionLandscapeLayerSample()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.MaterialExpressionLandscapeLayerSample");
		}

		// Token: 0x0601EB85 RID: 125829 RVA: 0x002DAB5C File Offset: 0x002D8D5C
		protected UMaterialExpressionLandscapeLayerSample(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109BC RID: 68028
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.MaterialExpressionLandscapeLayerSample";

		// Token: 0x040109BD RID: 68029
		private static IntPtr _ClassPtr;

		// Token: 0x040109BE RID: 68030
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109BF RID: 68031
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x040109C0 RID: 68032
		internal static int __PropertyOffset_PreviewWeight;

		// Token: 0x040109C1 RID: 68033
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
