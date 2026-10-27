using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E39 RID: 3641
	[UnrealObjectPath("/Script/Engine.MaterialExpressionScreenPosition")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionScreenPosition : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C3AF RID: 50095 RVA: 0x0011A9CC File Offset: 0x00118BCC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionScreenPosition._ClassPtr;
		}

		// Token: 0x0600C3B0 RID: 50096 RVA: 0x0011A9D8 File Offset: 0x00118BD8
		public UMaterialExpressionScreenPosition() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionScreenPosition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C3B1 RID: 50097 RVA: 0x0011AA00 File Offset: 0x00118C00
		[NullableContext(1)]
		public UMaterialExpressionScreenPosition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionScreenPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C3B2 RID: 50098 RVA: 0x0011AA33 File Offset: 0x00118C33
		static UMaterialExpressionScreenPosition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionScreenPosition");
		}

		// Token: 0x0600C3B3 RID: 50099 RVA: 0x0011AA41 File Offset: 0x00118C41
		protected UMaterialExpressionScreenPosition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400685C RID: 26716
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionScreenPosition";

		// Token: 0x0400685D RID: 26717
		private static IntPtr _ClassPtr;

		// Token: 0x0400685E RID: 26718
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
