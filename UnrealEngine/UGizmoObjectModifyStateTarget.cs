using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200155F RID: 5471
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoObjectModifyStateTarget")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UGizmoObjectModifyStateTarget : UObject, IUnrealUObject, IUnrealObject, IGizmoStateTarget, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013D24 RID: 81188 RVA: 0x001D1AF2 File Offset: 0x001CFCF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoObjectModifyStateTarget._ClassPtr;
		}

		// Token: 0x06013D25 RID: 81189 RVA: 0x001D1AFE File Offset: 0x001CFCFE
		int IGizmoStateTarget.InterfaceOffset()
		{
			return UGizmoObjectModifyStateTarget.__InterfaceOffset_IGizmoStateTarget;
		}

		// Token: 0x06013D26 RID: 81190 RVA: 0x001D1B08 File Offset: 0x001CFD08
		public UGizmoObjectModifyStateTarget() : this(BuiltinUtils.AllocNativeUObject(UGizmoObjectModifyStateTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013D27 RID: 81191 RVA: 0x001D1B30 File Offset: 0x001CFD30
		[NullableContext(1)]
		public UGizmoObjectModifyStateTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoObjectModifyStateTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013D28 RID: 81192 RVA: 0x001D1B63 File Offset: 0x001CFD63
		static UGizmoObjectModifyStateTarget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoObjectModifyStateTarget");
		}

		// Token: 0x06013D29 RID: 81193 RVA: 0x001D1B71 File Offset: 0x001CFD71
		protected UGizmoObjectModifyStateTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB93 RID: 43923
		internal static int __InterfaceOffset_IGizmoStateTarget;

		// Token: 0x0400AB94 RID: 43924
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoObjectModifyStateTarget";

		// Token: 0x0400AB95 RID: 43925
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB96 RID: 43926
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
