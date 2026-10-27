using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E1F RID: 3615
	[UnrealObjectPath("/Script/Engine.MaterialExpressionPreSkinnedPosition")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionPreSkinnedPosition : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C298 RID: 49816 RVA: 0x001188FA File Offset: 0x00116AFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionPreSkinnedPosition._ClassPtr;
		}

		// Token: 0x0600C299 RID: 49817 RVA: 0x00118908 File Offset: 0x00116B08
		public UMaterialExpressionPreSkinnedPosition() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPreSkinnedPosition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C29A RID: 49818 RVA: 0x00118930 File Offset: 0x00116B30
		[NullableContext(1)]
		public UMaterialExpressionPreSkinnedPosition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPreSkinnedPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C29B RID: 49819 RVA: 0x00118963 File Offset: 0x00116B63
		static UMaterialExpressionPreSkinnedPosition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionPreSkinnedPosition");
		}

		// Token: 0x0600C29C RID: 49820 RVA: 0x00118971 File Offset: 0x00116B71
		protected UMaterialExpressionPreSkinnedPosition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006797 RID: 26519
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionPreSkinnedPosition";

		// Token: 0x04006798 RID: 26520
		private static IntPtr _ClassPtr;

		// Token: 0x04006799 RID: 26521
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
