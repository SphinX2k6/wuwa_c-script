using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E1E RID: 3614
	[UnrealObjectPath("/Script/Engine.MaterialExpressionPreSkinnedNormal")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionPreSkinnedNormal : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C293 RID: 49811 RVA: 0x0011887A File Offset: 0x00116A7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionPreSkinnedNormal._ClassPtr;
		}

		// Token: 0x0600C294 RID: 49812 RVA: 0x00118888 File Offset: 0x00116A88
		public UMaterialExpressionPreSkinnedNormal() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPreSkinnedNormal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C295 RID: 49813 RVA: 0x001188B0 File Offset: 0x00116AB0
		[NullableContext(1)]
		public UMaterialExpressionPreSkinnedNormal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPreSkinnedNormal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C296 RID: 49814 RVA: 0x001188E3 File Offset: 0x00116AE3
		static UMaterialExpressionPreSkinnedNormal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionPreSkinnedNormal");
		}

		// Token: 0x0600C297 RID: 49815 RVA: 0x001188F1 File Offset: 0x00116AF1
		protected UMaterialExpressionPreSkinnedNormal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006794 RID: 26516
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionPreSkinnedNormal";

		// Token: 0x04006795 RID: 26517
		private static IntPtr _ClassPtr;

		// Token: 0x04006796 RID: 26518
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
