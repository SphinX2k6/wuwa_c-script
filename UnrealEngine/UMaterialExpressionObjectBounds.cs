using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E01 RID: 3585
	[UnrealObjectPath("/Script/Engine.MaterialExpressionObjectBounds")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionObjectBounds : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C1DA RID: 49626 RVA: 0x0011755D File Offset: 0x0011575D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionObjectBounds._ClassPtr;
		}

		// Token: 0x0600C1DB RID: 49627 RVA: 0x0011756C File Offset: 0x0011576C
		public UMaterialExpressionObjectBounds() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionObjectBounds.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C1DC RID: 49628 RVA: 0x00117594 File Offset: 0x00115794
		[NullableContext(1)]
		public UMaterialExpressionObjectBounds(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionObjectBounds.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C1DD RID: 49629 RVA: 0x001175C7 File Offset: 0x001157C7
		static UMaterialExpressionObjectBounds()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionObjectBounds");
		}

		// Token: 0x0600C1DE RID: 49630 RVA: 0x001175D5 File Offset: 0x001157D5
		protected UMaterialExpressionObjectBounds(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006720 RID: 26400
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionObjectBounds";

		// Token: 0x04006721 RID: 26401
		private static IntPtr _ClassPtr;

		// Token: 0x04006722 RID: 26402
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
