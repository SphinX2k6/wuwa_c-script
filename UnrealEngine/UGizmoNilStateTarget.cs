using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200155E RID: 5470
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoNilStateTarget")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UGizmoNilStateTarget : UObject, IUnrealUObject, IUnrealObject, IGizmoStateTarget, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013D1E RID: 81182 RVA: 0x001D1A6D File Offset: 0x001CFC6D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoNilStateTarget._ClassPtr;
		}

		// Token: 0x06013D1F RID: 81183 RVA: 0x001D1A79 File Offset: 0x001CFC79
		int IGizmoStateTarget.InterfaceOffset()
		{
			return UGizmoNilStateTarget.__InterfaceOffset_IGizmoStateTarget;
		}

		// Token: 0x06013D20 RID: 81184 RVA: 0x001D1A80 File Offset: 0x001CFC80
		public UGizmoNilStateTarget() : this(BuiltinUtils.AllocNativeUObject(UGizmoNilStateTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013D21 RID: 81185 RVA: 0x001D1AA8 File Offset: 0x001CFCA8
		[NullableContext(1)]
		public UGizmoNilStateTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoNilStateTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013D22 RID: 81186 RVA: 0x001D1ADB File Offset: 0x001CFCDB
		static UGizmoNilStateTarget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoNilStateTarget");
		}

		// Token: 0x06013D23 RID: 81187 RVA: 0x001D1AE9 File Offset: 0x001CFCE9
		protected UGizmoNilStateTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB8F RID: 43919
		internal static int __InterfaceOffset_IGizmoStateTarget;

		// Token: 0x0400AB90 RID: 43920
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoNilStateTarget";

		// Token: 0x0400AB91 RID: 43921
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB92 RID: 43922
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
