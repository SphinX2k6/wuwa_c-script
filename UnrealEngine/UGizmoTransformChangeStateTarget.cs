using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001565 RID: 5477
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoTransformChangeStateTarget")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UGizmoTransformChangeStateTarget : UObject, IUnrealUObject, IUnrealObject, IGizmoStateTarget, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013D79 RID: 81273 RVA: 0x001D22C0 File Offset: 0x001D04C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoTransformChangeStateTarget._ClassPtr;
		}

		// Token: 0x06013D7A RID: 81274 RVA: 0x001D22CC File Offset: 0x001D04CC
		int IGizmoStateTarget.InterfaceOffset()
		{
			return UGizmoTransformChangeStateTarget.__InterfaceOffset_IGizmoStateTarget;
		}

		// Token: 0x06013D7B RID: 81275 RVA: 0x001D22D4 File Offset: 0x001D04D4
		public UGizmoTransformChangeStateTarget() : this(BuiltinUtils.AllocNativeUObject(UGizmoTransformChangeStateTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013D7C RID: 81276 RVA: 0x001D22FC File Offset: 0x001D04FC
		[NullableContext(1)]
		public UGizmoTransformChangeStateTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoTransformChangeStateTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DBC RID: 19900
		// (get) Token: 0x06013D7D RID: 81277 RVA: 0x001D232F File Offset: 0x001D052F
		// (set) Token: 0x06013D7E RID: 81278 RVA: 0x001D2349 File Offset: 0x001D0549
		[Nullable(2)]
		public unsafe IToolContextTransactionProvider TransactionManager
		{
			[NullableContext(2)]
			get
			{
				return (IToolContextTransactionProvider)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UGizmoTransformChangeStateTarget.__PropertyOffset_TransactionManager));
			}
			[NullableContext(2)]
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoTransformChangeStateTarget.__PropertyOffset_TransactionManager) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x06013D7F RID: 81279 RVA: 0x001D236F File Offset: 0x001D056F
		static UGizmoTransformChangeStateTarget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoTransformChangeStateTarget");
		}

		// Token: 0x06013D80 RID: 81280 RVA: 0x001D237D File Offset: 0x001D057D
		protected UGizmoTransformChangeStateTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ABC2 RID: 43970
		internal static int __InterfaceOffset_IGizmoStateTarget;

		// Token: 0x0400ABC3 RID: 43971
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoTransformChangeStateTarget";

		// Token: 0x0400ABC4 RID: 43972
		private static IntPtr _ClassPtr;

		// Token: 0x0400ABC5 RID: 43973
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ABC6 RID: 43974
		internal static int __PropertyOffset_TransactionManager;
	}
}
