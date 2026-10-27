using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DBF RID: 3519
	[UnrealObjectPath("/Script/Engine.MaterialExpressionElseCondition")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UMaterialExpressionElseCondition : UMaterialExpressionBranchCondition, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF09 RID: 48905 RVA: 0x00111D2E File Offset: 0x0010FF2E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionElseCondition._ClassPtr;
		}

		// Token: 0x0600BF0A RID: 48906 RVA: 0x00111D3C File Offset: 0x0010FF3C
		public UMaterialExpressionElseCondition() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionElseCondition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF0B RID: 48907 RVA: 0x00111D64 File Offset: 0x0010FF64
		[NullableContext(1)]
		public UMaterialExpressionElseCondition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionElseCondition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BF0C RID: 48908 RVA: 0x00111D97 File Offset: 0x0010FF97
		static UMaterialExpressionElseCondition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionElseCondition");
		}

		// Token: 0x0600BF0D RID: 48909 RVA: 0x00111DA5 File Offset: 0x0010FFA5
		protected UMaterialExpressionElseCondition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006513 RID: 25875
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionElseCondition";

		// Token: 0x04006514 RID: 25876
		private static IntPtr _ClassPtr;

		// Token: 0x04006515 RID: 25877
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
