using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E19 RID: 3609
	[UnrealObjectPath("/Script/Engine.MaterialExpressionPixelDepth")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionPixelDepth : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C274 RID: 49780 RVA: 0x00118522 File Offset: 0x00116722
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionPixelDepth._ClassPtr;
		}

		// Token: 0x0600C275 RID: 49781 RVA: 0x00118530 File Offset: 0x00116730
		public UMaterialExpressionPixelDepth() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPixelDepth.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C276 RID: 49782 RVA: 0x00118558 File Offset: 0x00116758
		[NullableContext(1)]
		public UMaterialExpressionPixelDepth(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPixelDepth.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C277 RID: 49783 RVA: 0x0011858B File Offset: 0x0011678B
		static UMaterialExpressionPixelDepth()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionPixelDepth");
		}

		// Token: 0x0600C278 RID: 49784 RVA: 0x00118599 File Offset: 0x00116799
		protected UMaterialExpressionPixelDepth(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006780 RID: 26496
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionPixelDepth";

		// Token: 0x04006781 RID: 26497
		private static IntPtr _ClassPtr;

		// Token: 0x04006782 RID: 26498
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
