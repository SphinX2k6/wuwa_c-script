using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E04 RID: 3588
	[UnrealObjectPath("/Script/Engine.MaterialExpressionObjectRadius")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionObjectRadius : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C1E9 RID: 49641 RVA: 0x001176DE File Offset: 0x001158DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionObjectRadius._ClassPtr;
		}

		// Token: 0x0600C1EA RID: 49642 RVA: 0x001176EC File Offset: 0x001158EC
		public UMaterialExpressionObjectRadius() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionObjectRadius.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C1EB RID: 49643 RVA: 0x00117714 File Offset: 0x00115914
		[NullableContext(1)]
		public UMaterialExpressionObjectRadius(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionObjectRadius.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C1EC RID: 49644 RVA: 0x00117747 File Offset: 0x00115947
		static UMaterialExpressionObjectRadius()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionObjectRadius");
		}

		// Token: 0x0600C1ED RID: 49645 RVA: 0x00117755 File Offset: 0x00115955
		protected UMaterialExpressionObjectRadius(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006729 RID: 26409
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionObjectRadius";

		// Token: 0x0400672A RID: 26410
		private static IntPtr _ClassPtr;

		// Token: 0x0400672B RID: 26411
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
