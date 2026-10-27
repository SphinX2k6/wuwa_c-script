using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E1D RID: 3613
	[UnrealObjectPath("/Script/Engine.MaterialExpressionPreSkinnedLocalBounds")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UMaterialExpressionPreSkinnedLocalBounds : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C28E RID: 49806 RVA: 0x001187FA File Offset: 0x001169FA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionPreSkinnedLocalBounds._ClassPtr;
		}

		// Token: 0x0600C28F RID: 49807 RVA: 0x00118808 File Offset: 0x00116A08
		public UMaterialExpressionPreSkinnedLocalBounds() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPreSkinnedLocalBounds.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C290 RID: 49808 RVA: 0x00118830 File Offset: 0x00116A30
		[NullableContext(1)]
		public UMaterialExpressionPreSkinnedLocalBounds(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPreSkinnedLocalBounds.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C291 RID: 49809 RVA: 0x00118863 File Offset: 0x00116A63
		static UMaterialExpressionPreSkinnedLocalBounds()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionPreSkinnedLocalBounds");
		}

		// Token: 0x0600C292 RID: 49810 RVA: 0x00118871 File Offset: 0x00116A71
		protected UMaterialExpressionPreSkinnedLocalBounds(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006791 RID: 26513
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionPreSkinnedLocalBounds";

		// Token: 0x04006792 RID: 26514
		private static IntPtr _ClassPtr;

		// Token: 0x04006793 RID: 26515
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
