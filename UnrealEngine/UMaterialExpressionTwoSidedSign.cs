using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E70 RID: 3696
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTwoSidedSign")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionTwoSidedSign : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C5A9 RID: 50601 RVA: 0x0011E3E9 File Offset: 0x0011C5E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTwoSidedSign._ClassPtr;
		}

		// Token: 0x0600C5AA RID: 50602 RVA: 0x0011E3F8 File Offset: 0x0011C5F8
		public UMaterialExpressionTwoSidedSign() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTwoSidedSign.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C5AB RID: 50603 RVA: 0x0011E420 File Offset: 0x0011C620
		[NullableContext(1)]
		public UMaterialExpressionTwoSidedSign(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTwoSidedSign.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C5AC RID: 50604 RVA: 0x0011E453 File Offset: 0x0011C653
		static UMaterialExpressionTwoSidedSign()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTwoSidedSign");
		}

		// Token: 0x0600C5AD RID: 50605 RVA: 0x0011E461 File Offset: 0x0011C661
		protected UMaterialExpressionTwoSidedSign(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069BF RID: 27071
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTwoSidedSign";

		// Token: 0x040069C0 RID: 27072
		private static IntPtr _ClassPtr;

		// Token: 0x040069C1 RID: 27073
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
