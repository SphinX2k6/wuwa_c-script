using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001590 RID: 5520
	[UnrealObjectPath("/Script/InteractiveToolsFramework.PlanePositionGizmoBuilder")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UPlanePositionGizmoBuilder : UInteractiveGizmoBuilder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013EC0 RID: 81600 RVA: 0x001D411F File Offset: 0x001D231F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlanePositionGizmoBuilder._ClassPtr;
		}

		// Token: 0x06013EC1 RID: 81601 RVA: 0x001D412C File Offset: 0x001D232C
		public UPlanePositionGizmoBuilder() : this(BuiltinUtils.AllocNativeUObject(UPlanePositionGizmoBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013EC2 RID: 81602 RVA: 0x001D4154 File Offset: 0x001D2354
		[NullableContext(1)]
		public UPlanePositionGizmoBuilder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlanePositionGizmoBuilder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013EC3 RID: 81603 RVA: 0x001D4187 File Offset: 0x001D2387
		static UPlanePositionGizmoBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.PlanePositionGizmoBuilder");
		}

		// Token: 0x06013EC4 RID: 81604 RVA: 0x001D4195 File Offset: 0x001D2395
		protected UPlanePositionGizmoBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC84 RID: 44164
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.PlanePositionGizmoBuilder";

		// Token: 0x0400AC85 RID: 44165
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC86 RID: 44166
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
