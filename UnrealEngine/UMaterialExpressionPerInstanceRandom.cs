using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E18 RID: 3608
	[UnrealObjectPath("/Script/Engine.MaterialExpressionPerInstanceRandom")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionPerInstanceRandom : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C26F RID: 49775 RVA: 0x001184A2 File Offset: 0x001166A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionPerInstanceRandom._ClassPtr;
		}

		// Token: 0x0600C270 RID: 49776 RVA: 0x001184B0 File Offset: 0x001166B0
		public UMaterialExpressionPerInstanceRandom() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPerInstanceRandom.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C271 RID: 49777 RVA: 0x001184D8 File Offset: 0x001166D8
		[NullableContext(1)]
		public UMaterialExpressionPerInstanceRandom(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPerInstanceRandom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C272 RID: 49778 RVA: 0x0011850B File Offset: 0x0011670B
		static UMaterialExpressionPerInstanceRandom()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionPerInstanceRandom");
		}

		// Token: 0x0600C273 RID: 49779 RVA: 0x00118519 File Offset: 0x00116719
		protected UMaterialExpressionPerInstanceRandom(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400677D RID: 26493
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionPerInstanceRandom";

		// Token: 0x0400677E RID: 26494
		private static IntPtr _ClassPtr;

		// Token: 0x0400677F RID: 26495
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
