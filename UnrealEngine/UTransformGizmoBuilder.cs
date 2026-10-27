using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015A0 RID: 5536
	[UnrealObjectPath("/Script/InteractiveToolsFramework.TransformGizmoBuilder")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UTransformGizmoBuilder : UInteractiveGizmoBuilder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013F56 RID: 81750 RVA: 0x001D4DF1 File Offset: 0x001D2FF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTransformGizmoBuilder._ClassPtr;
		}

		// Token: 0x06013F57 RID: 81751 RVA: 0x001D4E00 File Offset: 0x001D3000
		public UTransformGizmoBuilder() : this(BuiltinUtils.AllocNativeUObject(UTransformGizmoBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013F58 RID: 81752 RVA: 0x001D4E28 File Offset: 0x001D3028
		[NullableContext(1)]
		public UTransformGizmoBuilder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTransformGizmoBuilder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013F59 RID: 81753 RVA: 0x001D4E5B File Offset: 0x001D305B
		static UTransformGizmoBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.TransformGizmoBuilder");
		}

		// Token: 0x06013F5A RID: 81754 RVA: 0x001D4E69 File Offset: 0x001D3069
		protected UTransformGizmoBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ACDC RID: 44252
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.TransformGizmoBuilder";

		// Token: 0x0400ACDD RID: 44253
		private static IntPtr _ClassPtr;

		// Token: 0x0400ACDE RID: 44254
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
