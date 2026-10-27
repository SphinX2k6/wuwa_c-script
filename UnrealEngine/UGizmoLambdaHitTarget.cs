using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001559 RID: 5465
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoLambdaHitTarget")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UGizmoLambdaHitTarget : UObject, IUnrealUObject, IUnrealObject, IGizmoClickTarget, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013CEF RID: 81135 RVA: 0x001D160C File Offset: 0x001CF80C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoLambdaHitTarget._ClassPtr;
		}

		// Token: 0x06013CF0 RID: 81136 RVA: 0x001D1618 File Offset: 0x001CF818
		int IGizmoClickTarget.InterfaceOffset()
		{
			return UGizmoLambdaHitTarget.__InterfaceOffset_IGizmoClickTarget;
		}

		// Token: 0x06013CF1 RID: 81137 RVA: 0x001D1620 File Offset: 0x001CF820
		public UGizmoLambdaHitTarget() : this(BuiltinUtils.AllocNativeUObject(UGizmoLambdaHitTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013CF2 RID: 81138 RVA: 0x001D1648 File Offset: 0x001CF848
		[NullableContext(1)]
		public UGizmoLambdaHitTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoLambdaHitTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013CF3 RID: 81139 RVA: 0x001D167B File Offset: 0x001CF87B
		static UGizmoLambdaHitTarget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoLambdaHitTarget");
		}

		// Token: 0x06013CF4 RID: 81140 RVA: 0x001D1689 File Offset: 0x001CF889
		protected UGizmoLambdaHitTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB72 RID: 43890
		internal static int __InterfaceOffset_IGizmoClickTarget;

		// Token: 0x0400AB73 RID: 43891
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoLambdaHitTarget";

		// Token: 0x0400AB74 RID: 43892
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB75 RID: 43893
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
