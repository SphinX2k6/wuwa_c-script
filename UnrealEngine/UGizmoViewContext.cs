using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200156B RID: 5483
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoViewContext")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UGizmoViewContext : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013DB5 RID: 81333 RVA: 0x001D28BC File Offset: 0x001D0ABC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoViewContext._ClassPtr;
		}

		// Token: 0x06013DB6 RID: 81334 RVA: 0x001D28C8 File Offset: 0x001D0AC8
		public UGizmoViewContext() : this(BuiltinUtils.AllocNativeUObject(UGizmoViewContext.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013DB7 RID: 81335 RVA: 0x001D28F0 File Offset: 0x001D0AF0
		[NullableContext(1)]
		public UGizmoViewContext(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoViewContext.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013DB8 RID: 81336 RVA: 0x001D2923 File Offset: 0x001D0B23
		static UGizmoViewContext()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoViewContext");
		}

		// Token: 0x06013DB9 RID: 81337 RVA: 0x001D2931 File Offset: 0x001D0B31
		protected UGizmoViewContext(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ABDF RID: 43999
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoViewContext";

		// Token: 0x0400ABE0 RID: 44000
		private static IntPtr _ClassPtr;

		// Token: 0x0400ABE1 RID: 44001
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
