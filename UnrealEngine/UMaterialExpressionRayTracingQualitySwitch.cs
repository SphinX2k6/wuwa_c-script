using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E23 RID: 3619
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionRayTracingQualitySwitch")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionRayTracingQualitySwitch : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C2B6 RID: 49846 RVA: 0x00118C9E File Offset: 0x00116E9E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionRayTracingQualitySwitch._ClassPtr;
		}

		// Token: 0x0600C2B7 RID: 49847 RVA: 0x00118CAC File Offset: 0x00116EAC
		public UMaterialExpressionRayTracingQualitySwitch() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRayTracingQualitySwitch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C2B8 RID: 49848 RVA: 0x00118CD4 File Offset: 0x00116ED4
		public UMaterialExpressionRayTracingQualitySwitch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRayTracingQualitySwitch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D26 RID: 11558
		// (get) Token: 0x0600C2B9 RID: 49849 RVA: 0x00118D08 File Offset: 0x00116F08
		// (set) Token: 0x0600C2BA RID: 49850 RVA: 0x00118D41 File Offset: 0x00116F41
		public FExpressionInput Normal
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Normal) == null)
				{
					result = (this._Normal = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRayTracingQualitySwitch.__PropertyOffset_Normal, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRayTracingQualitySwitch.__PropertyOffset_Normal, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D27 RID: 11559
		// (get) Token: 0x0600C2BB RID: 49851 RVA: 0x00118D64 File Offset: 0x00116F64
		// (set) Token: 0x0600C2BC RID: 49852 RVA: 0x00118D9D File Offset: 0x00116F9D
		public FExpressionInput RayTraced
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._RayTraced) == null)
				{
					result = (this._RayTraced = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRayTracingQualitySwitch.__PropertyOffset_RayTraced, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRayTracingQualitySwitch.__PropertyOffset_RayTraced, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C2BD RID: 49853 RVA: 0x00118DBE File Offset: 0x00116FBE
		static UMaterialExpressionRayTracingQualitySwitch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionRayTracingQualitySwitch");
		}

		// Token: 0x0600C2BE RID: 49854 RVA: 0x00118DCC File Offset: 0x00116FCC
		protected UMaterialExpressionRayTracingQualitySwitch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040067AD RID: 26541
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionRayTracingQualitySwitch";

		// Token: 0x040067AE RID: 26542
		private static IntPtr _ClassPtr;

		// Token: 0x040067AF RID: 26543
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040067B0 RID: 26544
		internal static int __PropertyOffset_Normal;

		// Token: 0x040067B1 RID: 26545
		[Nullable(2)]
		private FExpressionInput _Normal;

		// Token: 0x040067B2 RID: 26546
		internal static int __PropertyOffset_RayTraced;

		// Token: 0x040067B3 RID: 26547
		[Nullable(2)]
		private FExpressionInput _RayTraced;
	}
}
