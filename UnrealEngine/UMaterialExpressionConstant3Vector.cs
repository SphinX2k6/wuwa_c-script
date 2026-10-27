using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DA3 RID: 3491
	[UnrealObjectPath("/Script/Engine.MaterialExpressionConstant3Vector")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UMaterialExpressionConstant3Vector : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE1C RID: 48668 RVA: 0x00110284 File Offset: 0x0010E484
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionConstant3Vector._ClassPtr;
		}

		// Token: 0x0600BE1D RID: 48669 RVA: 0x00110290 File Offset: 0x0010E490
		public UMaterialExpressionConstant3Vector() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionConstant3Vector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE1E RID: 48670 RVA: 0x001102B8 File Offset: 0x0010E4B8
		[NullableContext(1)]
		public UMaterialExpressionConstant3Vector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionConstant3Vector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C18 RID: 11288
		// (get) Token: 0x0600BE1F RID: 48671 RVA: 0x001102EB File Offset: 0x0010E4EB
		// (set) Token: 0x0600BE20 RID: 48672 RVA: 0x001102FF File Offset: 0x0010E4FF
		public unsafe FLinearColor Constant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionConstant3Vector.__PropertyOffset_Constant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionConstant3Vector.__PropertyOffset_Constant) = value;
			}
		}

		// Token: 0x0600BE21 RID: 48673 RVA: 0x00110314 File Offset: 0x0010E514
		static UMaterialExpressionConstant3Vector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionConstant3Vector");
		}

		// Token: 0x0600BE22 RID: 48674 RVA: 0x00110322 File Offset: 0x0010E522
		protected UMaterialExpressionConstant3Vector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006471 RID: 25713
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionConstant3Vector";

		// Token: 0x04006472 RID: 25714
		private static IntPtr _ClassPtr;

		// Token: 0x04006473 RID: 25715
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006474 RID: 25716
		internal static int __PropertyOffset_Constant;
	}
}
