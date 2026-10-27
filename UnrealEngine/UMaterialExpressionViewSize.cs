using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E7A RID: 3706
	[UnrealObjectPath("/Script/Engine.MaterialExpressionViewSize")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionViewSize : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C5F1 RID: 50673 RVA: 0x0011EB0B File Offset: 0x0011CD0B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionViewSize._ClassPtr;
		}

		// Token: 0x0600C5F2 RID: 50674 RVA: 0x0011EB18 File Offset: 0x0011CD18
		public UMaterialExpressionViewSize() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionViewSize.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C5F3 RID: 50675 RVA: 0x0011EB40 File Offset: 0x0011CD40
		[NullableContext(1)]
		public UMaterialExpressionViewSize(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionViewSize.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C5F4 RID: 50676 RVA: 0x0011EB73 File Offset: 0x0011CD73
		static UMaterialExpressionViewSize()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionViewSize");
		}

		// Token: 0x0600C5F5 RID: 50677 RVA: 0x0011EB81 File Offset: 0x0011CD81
		protected UMaterialExpressionViewSize(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069EB RID: 27115
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionViewSize";

		// Token: 0x040069EC RID: 27116
		private static IntPtr _ClassPtr;

		// Token: 0x040069ED RID: 27117
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
