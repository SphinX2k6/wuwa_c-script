using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E7F RID: 3711
	[UnrealObjectPath("/Script/Engine.MaterialExpressionWorldPosition")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UMaterialExpressionWorldPosition : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C632 RID: 50738 RVA: 0x0011F230 File Offset: 0x0011D430
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionWorldPosition._ClassPtr;
		}

		// Token: 0x0600C633 RID: 50739 RVA: 0x0011F23C File Offset: 0x0011D43C
		public UMaterialExpressionWorldPosition() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionWorldPosition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C634 RID: 50740 RVA: 0x0011F264 File Offset: 0x0011D464
		[NullableContext(1)]
		public UMaterialExpressionWorldPosition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionWorldPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002E00 RID: 11776
		// (get) Token: 0x0600C635 RID: 50741 RVA: 0x0011F297 File Offset: 0x0011D497
		// (set) Token: 0x0600C636 RID: 50742 RVA: 0x0011F2AB File Offset: 0x0011D4AB
		public unsafe TEnumAsByte<EWorldPositionIncludedOffsets> WorldPositionShaderOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionWorldPosition.__PropertyOffset_WorldPositionShaderOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionWorldPosition.__PropertyOffset_WorldPositionShaderOffset) = value;
			}
		}

		// Token: 0x0600C637 RID: 50743 RVA: 0x0011F2C0 File Offset: 0x0011D4C0
		static UMaterialExpressionWorldPosition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionWorldPosition");
		}

		// Token: 0x0600C638 RID: 50744 RVA: 0x0011F2CE File Offset: 0x0011D4CE
		protected UMaterialExpressionWorldPosition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006A17 RID: 27159
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionWorldPosition";

		// Token: 0x04006A18 RID: 27160
		private static IntPtr _ClassPtr;

		// Token: 0x04006A19 RID: 27161
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006A1A RID: 27162
		internal static int __PropertyOffset_WorldPositionShaderOffset;
	}
}
