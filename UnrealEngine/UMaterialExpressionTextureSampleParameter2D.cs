using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E66 RID: 3686
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTextureSampleParameter2D")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class UMaterialExpressionTextureSampleParameter2D : UMaterialExpressionTextureSampleParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C55F RID: 50527 RVA: 0x0011DBDD File Offset: 0x0011BDDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTextureSampleParameter2D._ClassPtr;
		}

		// Token: 0x0600C560 RID: 50528 RVA: 0x0011DBEC File Offset: 0x0011BDEC
		public UMaterialExpressionTextureSampleParameter2D() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureSampleParameter2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C561 RID: 50529 RVA: 0x0011DC14 File Offset: 0x0011BE14
		[NullableContext(1)]
		public UMaterialExpressionTextureSampleParameter2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureSampleParameter2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C562 RID: 50530 RVA: 0x0011DC47 File Offset: 0x0011BE47
		static UMaterialExpressionTextureSampleParameter2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTextureSampleParameter2D");
		}

		// Token: 0x0600C563 RID: 50531 RVA: 0x0011DC55 File Offset: 0x0011BE55
		protected UMaterialExpressionTextureSampleParameter2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400698E RID: 27022
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTextureSampleParameter2D";

		// Token: 0x0400698F RID: 27023
		private static IntPtr _ClassPtr;

		// Token: 0x04006990 RID: 27024
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
