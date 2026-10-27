using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E02 RID: 3586
	[UnrealObjectPath("/Script/Engine.MaterialExpressionObjectOrientation")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionObjectOrientation : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C1DF RID: 49631 RVA: 0x001175DE File Offset: 0x001157DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionObjectOrientation._ClassPtr;
		}

		// Token: 0x0600C1E0 RID: 49632 RVA: 0x001175EC File Offset: 0x001157EC
		public UMaterialExpressionObjectOrientation() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionObjectOrientation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C1E1 RID: 49633 RVA: 0x00117614 File Offset: 0x00115814
		[NullableContext(1)]
		public UMaterialExpressionObjectOrientation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionObjectOrientation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C1E2 RID: 49634 RVA: 0x00117647 File Offset: 0x00115847
		static UMaterialExpressionObjectOrientation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionObjectOrientation");
		}

		// Token: 0x0600C1E3 RID: 49635 RVA: 0x00117655 File Offset: 0x00115855
		protected UMaterialExpressionObjectOrientation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006723 RID: 26403
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionObjectOrientation";

		// Token: 0x04006724 RID: 26404
		private static IntPtr _ClassPtr;

		// Token: 0x04006725 RID: 26405
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
