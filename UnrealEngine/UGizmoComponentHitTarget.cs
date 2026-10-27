using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001553 RID: 5459
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoComponentHitTarget")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UGizmoComponentHitTarget : UObject, IUnrealUObject, IUnrealObject, IGizmoClickTarget, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013CB5 RID: 81077 RVA: 0x001D1121 File Offset: 0x001CF321
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoComponentHitTarget._ClassPtr;
		}

		// Token: 0x06013CB6 RID: 81078 RVA: 0x001D112D File Offset: 0x001CF32D
		int IGizmoClickTarget.InterfaceOffset()
		{
			return UGizmoComponentHitTarget.__InterfaceOffset_IGizmoClickTarget;
		}

		// Token: 0x06013CB7 RID: 81079 RVA: 0x001D1134 File Offset: 0x001CF334
		public UGizmoComponentHitTarget() : this(BuiltinUtils.AllocNativeUObject(UGizmoComponentHitTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013CB8 RID: 81080 RVA: 0x001D115C File Offset: 0x001CF35C
		[NullableContext(1)]
		public UGizmoComponentHitTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoComponentHitTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D8B RID: 19851
		// (get) Token: 0x06013CB9 RID: 81081 RVA: 0x001D118F File Offset: 0x001CF38F
		// (set) Token: 0x06013CBA RID: 81082 RVA: 0x001D11A3 File Offset: 0x001CF3A3
		[Nullable(2)]
		public unsafe UPrimitiveComponent Component
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UGizmoComponentHitTarget.__PropertyOffset_Component);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGizmoComponentHitTarget.__PropertyOffset_Component, value);
			}
		}

		// Token: 0x06013CBB RID: 81083 RVA: 0x001D11B8 File Offset: 0x001CF3B8
		static UGizmoComponentHitTarget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoComponentHitTarget");
		}

		// Token: 0x06013CBC RID: 81084 RVA: 0x001D11C6 File Offset: 0x001CF3C6
		protected UGizmoComponentHitTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB55 RID: 43861
		internal static int __InterfaceOffset_IGizmoClickTarget;

		// Token: 0x0400AB56 RID: 43862
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoComponentHitTarget";

		// Token: 0x0400AB57 RID: 43863
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB58 RID: 43864
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB59 RID: 43865
		internal static int __PropertyOffset_Component;
	}
}
