using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E3D RID: 3645
	[UnrealObjectPath("/Script/Engine.MaterialExpressionShadingModel")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UMaterialExpressionShadingModel : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C3CB RID: 50123 RVA: 0x0011AD11 File Offset: 0x00118F11
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionShadingModel._ClassPtr;
		}

		// Token: 0x0600C3CC RID: 50124 RVA: 0x0011AD20 File Offset: 0x00118F20
		public UMaterialExpressionShadingModel() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionShadingModel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C3CD RID: 50125 RVA: 0x0011AD48 File Offset: 0x00118F48
		[NullableContext(1)]
		public UMaterialExpressionShadingModel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionShadingModel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D70 RID: 11632
		// (get) Token: 0x0600C3CE RID: 50126 RVA: 0x0011AD7B File Offset: 0x00118F7B
		// (set) Token: 0x0600C3CF RID: 50127 RVA: 0x0011AD8F File Offset: 0x00118F8F
		public unsafe TEnumAsByte<EMaterialShadingModel> ShadingModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionShadingModel.__PropertyOffset_ShadingModel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionShadingModel.__PropertyOffset_ShadingModel) = value;
			}
		}

		// Token: 0x0600C3D0 RID: 50128 RVA: 0x0011ADA4 File Offset: 0x00118FA4
		static UMaterialExpressionShadingModel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionShadingModel");
		}

		// Token: 0x0600C3D1 RID: 50129 RVA: 0x0011ADB2 File Offset: 0x00118FB2
		protected UMaterialExpressionShadingModel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006870 RID: 26736
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionShadingModel";

		// Token: 0x04006871 RID: 26737
		private static IntPtr _ClassPtr;

		// Token: 0x04006872 RID: 26738
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006873 RID: 26739
		internal static int __PropertyOffset_ShadingModel;
	}
}
