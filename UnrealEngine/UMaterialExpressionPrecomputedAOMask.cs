using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E1C RID: 3612
	[UnrealObjectPath("/Script/Engine.MaterialExpressionPrecomputedAOMask")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionPrecomputedAOMask : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C289 RID: 49801 RVA: 0x0011877A File Offset: 0x0011697A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionPrecomputedAOMask._ClassPtr;
		}

		// Token: 0x0600C28A RID: 49802 RVA: 0x00118788 File Offset: 0x00116988
		public UMaterialExpressionPrecomputedAOMask() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPrecomputedAOMask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C28B RID: 49803 RVA: 0x001187B0 File Offset: 0x001169B0
		[NullableContext(1)]
		public UMaterialExpressionPrecomputedAOMask(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPrecomputedAOMask.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C28C RID: 49804 RVA: 0x001187E3 File Offset: 0x001169E3
		static UMaterialExpressionPrecomputedAOMask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionPrecomputedAOMask");
		}

		// Token: 0x0600C28D RID: 49805 RVA: 0x001187F1 File Offset: 0x001169F1
		protected UMaterialExpressionPrecomputedAOMask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400678E RID: 26510
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionPrecomputedAOMask";

		// Token: 0x0400678F RID: 26511
		private static IntPtr _ClassPtr;

		// Token: 0x04006790 RID: 26512
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
