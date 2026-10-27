using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E37 RID: 3639
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSceneTexelSize")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionSceneTexelSize : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C39D RID: 50077 RVA: 0x0011A807 File Offset: 0x00118A07
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSceneTexelSize._ClassPtr;
		}

		// Token: 0x0600C39E RID: 50078 RVA: 0x0011A814 File Offset: 0x00118A14
		public UMaterialExpressionSceneTexelSize() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSceneTexelSize.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C39F RID: 50079 RVA: 0x0011A83C File Offset: 0x00118A3C
		[NullableContext(1)]
		public UMaterialExpressionSceneTexelSize(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSceneTexelSize.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C3A0 RID: 50080 RVA: 0x0011A86F File Offset: 0x00118A6F
		static UMaterialExpressionSceneTexelSize()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSceneTexelSize");
		}

		// Token: 0x0600C3A1 RID: 50081 RVA: 0x0011A87D File Offset: 0x00118A7D
		protected UMaterialExpressionSceneTexelSize(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006851 RID: 26705
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSceneTexelSize";

		// Token: 0x04006852 RID: 26706
		private static IntPtr _ClassPtr;

		// Token: 0x04006853 RID: 26707
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
