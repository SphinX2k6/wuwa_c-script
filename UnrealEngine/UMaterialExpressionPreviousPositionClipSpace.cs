using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E21 RID: 3617
	[UnrealObjectPath("/Script/Engine.MaterialExpressionPreviousPositionClipSpace")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionPreviousPositionClipSpace : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C2A6 RID: 49830 RVA: 0x00118AB1 File Offset: 0x00116CB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionPreviousPositionClipSpace._ClassPtr;
		}

		// Token: 0x0600C2A7 RID: 49831 RVA: 0x00118AC0 File Offset: 0x00116CC0
		public UMaterialExpressionPreviousPositionClipSpace() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPreviousPositionClipSpace.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C2A8 RID: 49832 RVA: 0x00118AE8 File Offset: 0x00116CE8
		[NullableContext(1)]
		public UMaterialExpressionPreviousPositionClipSpace(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPreviousPositionClipSpace.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C2A9 RID: 49833 RVA: 0x00118B1B File Offset: 0x00116D1B
		static UMaterialExpressionPreviousPositionClipSpace()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionPreviousPositionClipSpace");
		}

		// Token: 0x0600C2AA RID: 49834 RVA: 0x00118B29 File Offset: 0x00116D29
		protected UMaterialExpressionPreviousPositionClipSpace(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040067A1 RID: 26529
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionPreviousPositionClipSpace";

		// Token: 0x040067A2 RID: 26530
		private static IntPtr _ClassPtr;

		// Token: 0x040067A3 RID: 26531
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
