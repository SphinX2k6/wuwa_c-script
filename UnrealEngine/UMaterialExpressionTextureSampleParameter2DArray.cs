using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E67 RID: 3687
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTextureSampleParameter2DArray")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class UMaterialExpressionTextureSampleParameter2DArray : UMaterialExpressionTextureSampleParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C564 RID: 50532 RVA: 0x0011DC5E File Offset: 0x0011BE5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTextureSampleParameter2DArray._ClassPtr;
		}

		// Token: 0x0600C565 RID: 50533 RVA: 0x0011DC6C File Offset: 0x0011BE6C
		public UMaterialExpressionTextureSampleParameter2DArray() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureSampleParameter2DArray.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C566 RID: 50534 RVA: 0x0011DC94 File Offset: 0x0011BE94
		[NullableContext(1)]
		public UMaterialExpressionTextureSampleParameter2DArray(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureSampleParameter2DArray.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C567 RID: 50535 RVA: 0x0011DCC7 File Offset: 0x0011BEC7
		static UMaterialExpressionTextureSampleParameter2DArray()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTextureSampleParameter2DArray");
		}

		// Token: 0x0600C568 RID: 50536 RVA: 0x0011DCD5 File Offset: 0x0011BED5
		protected UMaterialExpressionTextureSampleParameter2DArray(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006991 RID: 27025
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTextureSampleParameter2DArray";

		// Token: 0x04006992 RID: 27026
		private static IntPtr _ClassPtr;

		// Token: 0x04006993 RID: 27027
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
