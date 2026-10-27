using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E03 RID: 3587
	[UnrealObjectPath("/Script/Engine.MaterialExpressionObjectPositionWS")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionObjectPositionWS : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C1E4 RID: 49636 RVA: 0x0011765E File Offset: 0x0011585E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionObjectPositionWS._ClassPtr;
		}

		// Token: 0x0600C1E5 RID: 49637 RVA: 0x0011766C File Offset: 0x0011586C
		public UMaterialExpressionObjectPositionWS() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionObjectPositionWS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C1E6 RID: 49638 RVA: 0x00117694 File Offset: 0x00115894
		[NullableContext(1)]
		public UMaterialExpressionObjectPositionWS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionObjectPositionWS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C1E7 RID: 49639 RVA: 0x001176C7 File Offset: 0x001158C7
		static UMaterialExpressionObjectPositionWS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionObjectPositionWS");
		}

		// Token: 0x0600C1E8 RID: 49640 RVA: 0x001176D5 File Offset: 0x001158D5
		protected UMaterialExpressionObjectPositionWS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006726 RID: 26406
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionObjectPositionWS";

		// Token: 0x04006727 RID: 26407
		private static IntPtr _ClassPtr;

		// Token: 0x04006728 RID: 26408
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
