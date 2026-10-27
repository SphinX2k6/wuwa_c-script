using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DA4 RID: 3492
	[UnrealObjectPath("/Script/Engine.MaterialExpressionConstant4Vector")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UMaterialExpressionConstant4Vector : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE23 RID: 48675 RVA: 0x0011032B File Offset: 0x0010E52B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionConstant4Vector._ClassPtr;
		}

		// Token: 0x0600BE24 RID: 48676 RVA: 0x00110338 File Offset: 0x0010E538
		public UMaterialExpressionConstant4Vector() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionConstant4Vector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE25 RID: 48677 RVA: 0x00110360 File Offset: 0x0010E560
		[NullableContext(1)]
		public UMaterialExpressionConstant4Vector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionConstant4Vector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C19 RID: 11289
		// (get) Token: 0x0600BE26 RID: 48678 RVA: 0x00110393 File Offset: 0x0010E593
		// (set) Token: 0x0600BE27 RID: 48679 RVA: 0x001103A7 File Offset: 0x0010E5A7
		public unsafe FLinearColor Constant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionConstant4Vector.__PropertyOffset_Constant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionConstant4Vector.__PropertyOffset_Constant) = value;
			}
		}

		// Token: 0x0600BE28 RID: 48680 RVA: 0x001103BC File Offset: 0x0010E5BC
		static UMaterialExpressionConstant4Vector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionConstant4Vector");
		}

		// Token: 0x0600BE29 RID: 48681 RVA: 0x001103CA File Offset: 0x0010E5CA
		protected UMaterialExpressionConstant4Vector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006475 RID: 25717
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionConstant4Vector";

		// Token: 0x04006476 RID: 25718
		private static IntPtr _ClassPtr;

		// Token: 0x04006477 RID: 25719
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006478 RID: 25720
		internal static int __PropertyOffset_Constant;
	}
}
