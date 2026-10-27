using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001575 RID: 5493
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InteractiveGizmoManager")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UInteractiveGizmoManager : UObject, IUnrealUObject, IUnrealObject, IToolContextTransactionProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013DF4 RID: 81396 RVA: 0x001D2E1D File Offset: 0x001D101D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInteractiveGizmoManager._ClassPtr;
		}

		// Token: 0x06013DF5 RID: 81397 RVA: 0x001D2E29 File Offset: 0x001D1029
		int IToolContextTransactionProvider.InterfaceOffset()
		{
			return UInteractiveGizmoManager.__InterfaceOffset_IToolContextTransactionProvider;
		}

		// Token: 0x06013DF6 RID: 81398 RVA: 0x001D2E30 File Offset: 0x001D1030
		public UInteractiveGizmoManager() : this(BuiltinUtils.AllocNativeUObject(UInteractiveGizmoManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013DF7 RID: 81399 RVA: 0x001D2E58 File Offset: 0x001D1058
		public UInteractiveGizmoManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInteractiveGizmoManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DD1 RID: 19921
		// (get) Token: 0x06013DF8 RID: 81400 RVA: 0x001D2E8C File Offset: 0x001D108C
		// (set) Token: 0x06013DF9 RID: 81401 RVA: 0x001D2EC5 File Offset: 0x001D10C5
		public TArray<FActiveGizmo> ActiveGizmos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FActiveGizmo> result;
				if ((result = this._ActiveGizmos) == null)
				{
					result = (this._ActiveGizmos = new TArray<FActiveGizmo>(base.NativePtr + (IntPtr)UInteractiveGizmoManager.__PropertyOffset_ActiveGizmos, this));
				}
				return result;
			}
			set
			{
				this.ActiveGizmos.CopyAssign(value);
			}
		}

		// Token: 0x17004DD2 RID: 19922
		// (get) Token: 0x06013DFA RID: 81402 RVA: 0x001D2ED4 File Offset: 0x001D10D4
		// (set) Token: 0x06013DFB RID: 81403 RVA: 0x001D2F0D File Offset: 0x001D110D
		public TMap<string, UInteractiveGizmoBuilder> GizmoBuilders
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UInteractiveGizmoBuilder> result;
				if ((result = this._GizmoBuilders) == null)
				{
					result = (this._GizmoBuilders = new TMap<string, UInteractiveGizmoBuilder>(base.NativePtr + (IntPtr)UInteractiveGizmoManager.__PropertyOffset_GizmoBuilders, this));
				}
				return result;
			}
			set
			{
				this.GizmoBuilders.CopyAssign(value);
			}
		}

		// Token: 0x06013DFC RID: 81404 RVA: 0x001D2F1B File Offset: 0x001D111B
		static UInteractiveGizmoManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.InteractiveGizmoManager");
		}

		// Token: 0x06013DFD RID: 81405 RVA: 0x001D2F29 File Offset: 0x001D1129
		protected UInteractiveGizmoManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC04 RID: 44036
		internal static int __InterfaceOffset_IToolContextTransactionProvider;

		// Token: 0x0400AC05 RID: 44037
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.InteractiveGizmoManager";

		// Token: 0x0400AC06 RID: 44038
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC07 RID: 44039
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AC08 RID: 44040
		internal static int __PropertyOffset_ActiveGizmos;

		// Token: 0x0400AC09 RID: 44041
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FActiveGizmo> _ActiveGizmos;

		// Token: 0x0400AC0A RID: 44042
		internal static int __PropertyOffset_GizmoBuilders;

		// Token: 0x0400AC0B RID: 44043
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UInteractiveGizmoBuilder> _GizmoBuilders;
	}
}
