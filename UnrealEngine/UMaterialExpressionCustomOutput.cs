using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DAA RID: 3498
	[UnrealObjectPath("/Script/Engine.MaterialExpressionCustomOutput")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public abstract class UMaterialExpressionCustomOutput : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE65 RID: 48741 RVA: 0x00110A6E File Offset: 0x0010EC6E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionCustomOutput._ClassPtr;
		}

		// Token: 0x0600BE66 RID: 48742 RVA: 0x00110A7A File Offset: 0x0010EC7A
		static UMaterialExpressionCustomOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionCustomOutput");
		}

		// Token: 0x0600BE67 RID: 48743 RVA: 0x00110A88 File Offset: 0x0010EC88
		protected UMaterialExpressionCustomOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCustomOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE68 RID: 48744 RVA: 0x00110AB0 File Offset: 0x0010ECB0
		protected UMaterialExpressionCustomOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064A2 RID: 25762
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionCustomOutput";

		// Token: 0x040064A3 RID: 25763
		private static IntPtr _ClassPtr;

		// Token: 0x040064A4 RID: 25764
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
