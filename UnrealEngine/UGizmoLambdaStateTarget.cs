using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200155A RID: 5466
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoLambdaStateTarget")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UGizmoLambdaStateTarget : UObject, IUnrealUObject, IUnrealObject, IGizmoStateTarget, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013CF5 RID: 81141 RVA: 0x001D1692 File Offset: 0x001CF892
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoLambdaStateTarget._ClassPtr;
		}

		// Token: 0x06013CF6 RID: 81142 RVA: 0x001D169E File Offset: 0x001CF89E
		int IGizmoStateTarget.InterfaceOffset()
		{
			return UGizmoLambdaStateTarget.__InterfaceOffset_IGizmoStateTarget;
		}

		// Token: 0x06013CF7 RID: 81143 RVA: 0x001D16A8 File Offset: 0x001CF8A8
		public UGizmoLambdaStateTarget() : this(BuiltinUtils.AllocNativeUObject(UGizmoLambdaStateTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013CF8 RID: 81144 RVA: 0x001D16D0 File Offset: 0x001CF8D0
		[NullableContext(1)]
		public UGizmoLambdaStateTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoLambdaStateTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013CF9 RID: 81145 RVA: 0x001D1703 File Offset: 0x001CF903
		static UGizmoLambdaStateTarget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoLambdaStateTarget");
		}

		// Token: 0x06013CFA RID: 81146 RVA: 0x001D1711 File Offset: 0x001CF911
		protected UGizmoLambdaStateTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB76 RID: 43894
		internal static int __InterfaceOffset_IGizmoStateTarget;

		// Token: 0x0400AB77 RID: 43895
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoLambdaStateTarget";

		// Token: 0x0400AB78 RID: 43896
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB79 RID: 43897
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
