using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001537 RID: 5431
	[UnrealObjectPath("/Script/InteractiveToolsFramework.AxisPositionGizmoBuilder")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAxisPositionGizmoBuilder : UInteractiveGizmoBuilder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013B8E RID: 80782 RVA: 0x001CF6EB File Offset: 0x001CD8EB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAxisPositionGizmoBuilder._ClassPtr;
		}

		// Token: 0x06013B8F RID: 80783 RVA: 0x001CF6F8 File Offset: 0x001CD8F8
		public UAxisPositionGizmoBuilder() : this(BuiltinUtils.AllocNativeUObject(UAxisPositionGizmoBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013B90 RID: 80784 RVA: 0x001CF720 File Offset: 0x001CD920
		[NullableContext(1)]
		public UAxisPositionGizmoBuilder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAxisPositionGizmoBuilder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013B91 RID: 80785 RVA: 0x001CF753 File Offset: 0x001CD953
		static UAxisPositionGizmoBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.AxisPositionGizmoBuilder");
		}

		// Token: 0x06013B92 RID: 80786 RVA: 0x001CF761 File Offset: 0x001CD961
		protected UAxisPositionGizmoBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AAB2 RID: 43698
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.AxisPositionGizmoBuilder";

		// Token: 0x0400AAB3 RID: 43699
		private static IntPtr _ClassPtr;

		// Token: 0x0400AAB4 RID: 43700
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
