using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015A1 RID: 5537
	[UnrealObjectPath("/Script/InteractiveToolsFramework.TransformGizmoContextObject")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UTransformGizmoContextObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013F5B RID: 81755 RVA: 0x001D4E72 File Offset: 0x001D3072
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTransformGizmoContextObject._ClassPtr;
		}

		// Token: 0x06013F5C RID: 81756 RVA: 0x001D4E80 File Offset: 0x001D3080
		public UTransformGizmoContextObject() : this(BuiltinUtils.AllocNativeUObject(UTransformGizmoContextObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013F5D RID: 81757 RVA: 0x001D4EA8 File Offset: 0x001D30A8
		[NullableContext(1)]
		public UTransformGizmoContextObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTransformGizmoContextObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013F5E RID: 81758 RVA: 0x001D4EDB File Offset: 0x001D30DB
		static UTransformGizmoContextObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.TransformGizmoContextObject");
		}

		// Token: 0x06013F5F RID: 81759 RVA: 0x001D4EE9 File Offset: 0x001D30E9
		protected UTransformGizmoContextObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ACDF RID: 44255
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.TransformGizmoContextObject";

		// Token: 0x0400ACE0 RID: 44256
		private static IntPtr _ClassPtr;

		// Token: 0x0400ACE1 RID: 44257
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
