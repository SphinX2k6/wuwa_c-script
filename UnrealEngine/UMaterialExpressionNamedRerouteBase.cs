using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DFB RID: 3579
	[UnrealObjectPath("/Script/Engine.MaterialExpressionNamedRerouteBase")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public abstract class UMaterialExpressionNamedRerouteBase : UMaterialExpressionRerouteBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C197 RID: 49559 RVA: 0x00116E83 File Offset: 0x00115083
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionNamedRerouteBase._ClassPtr;
		}

		// Token: 0x0600C198 RID: 49560 RVA: 0x00116E8F File Offset: 0x0011508F
		static UMaterialExpressionNamedRerouteBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionNamedRerouteBase");
		}

		// Token: 0x0600C199 RID: 49561 RVA: 0x00116EA0 File Offset: 0x001150A0
		protected UMaterialExpressionNamedRerouteBase() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionNamedRerouteBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C19A RID: 49562 RVA: 0x00116EC8 File Offset: 0x001150C8
		protected UMaterialExpressionNamedRerouteBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040066F4 RID: 26356
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionNamedRerouteBase";

		// Token: 0x040066F5 RID: 26357
		private static IntPtr _ClassPtr;

		// Token: 0x040066F6 RID: 26358
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
