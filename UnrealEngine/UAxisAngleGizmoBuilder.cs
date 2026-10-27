using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001535 RID: 5429
	[UnrealObjectPath("/Script/InteractiveToolsFramework.AxisAngleGizmoBuilder")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAxisAngleGizmoBuilder : UInteractiveGizmoBuilder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013B6A RID: 80746 RVA: 0x001CF3A3 File Offset: 0x001CD5A3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAxisAngleGizmoBuilder._ClassPtr;
		}

		// Token: 0x06013B6B RID: 80747 RVA: 0x001CF3B0 File Offset: 0x001CD5B0
		public UAxisAngleGizmoBuilder() : this(BuiltinUtils.AllocNativeUObject(UAxisAngleGizmoBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013B6C RID: 80748 RVA: 0x001CF3D8 File Offset: 0x001CD5D8
		[NullableContext(1)]
		public UAxisAngleGizmoBuilder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAxisAngleGizmoBuilder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013B6D RID: 80749 RVA: 0x001CF40B File Offset: 0x001CD60B
		static UAxisAngleGizmoBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.AxisAngleGizmoBuilder");
		}

		// Token: 0x06013B6E RID: 80750 RVA: 0x001CF419 File Offset: 0x001CD619
		protected UAxisAngleGizmoBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AA9F RID: 43679
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.AxisAngleGizmoBuilder";

		// Token: 0x0400AAA0 RID: 43680
		private static IntPtr _ClassPtr;

		// Token: 0x0400AAA1 RID: 43681
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
