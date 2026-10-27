using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200157F RID: 5503
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InteractiveToolsContext")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UInteractiveToolsContext : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E26 RID: 81446 RVA: 0x001D3260 File Offset: 0x001D1460
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInteractiveToolsContext._ClassPtr;
		}

		// Token: 0x06013E27 RID: 81447 RVA: 0x001D326C File Offset: 0x001D146C
		public UInteractiveToolsContext() : this(BuiltinUtils.AllocNativeUObject(UInteractiveToolsContext.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E28 RID: 81448 RVA: 0x001D3294 File Offset: 0x001D1494
		[NullableContext(1)]
		public UInteractiveToolsContext(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInteractiveToolsContext.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DDA RID: 19930
		// (get) Token: 0x06013E29 RID: 81449 RVA: 0x001D32C7 File Offset: 0x001D14C7
		// (set) Token: 0x06013E2A RID: 81450 RVA: 0x001D32DB File Offset: 0x001D14DB
		public unsafe UInputRouter InputRouter
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInputRouter>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolsContext.__PropertyOffset_InputRouter);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolsContext.__PropertyOffset_InputRouter, value);
			}
		}

		// Token: 0x17004DDB RID: 19931
		// (get) Token: 0x06013E2B RID: 81451 RVA: 0x001D32F0 File Offset: 0x001D14F0
		// (set) Token: 0x06013E2C RID: 81452 RVA: 0x001D3304 File Offset: 0x001D1504
		public unsafe UToolTargetManager TargetManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UToolTargetManager>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolsContext.__PropertyOffset_TargetManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolsContext.__PropertyOffset_TargetManager, value);
			}
		}

		// Token: 0x17004DDC RID: 19932
		// (get) Token: 0x06013E2D RID: 81453 RVA: 0x001D3319 File Offset: 0x001D1519
		// (set) Token: 0x06013E2E RID: 81454 RVA: 0x001D332D File Offset: 0x001D152D
		public unsafe UInteractiveToolManager ToolManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInteractiveToolManager>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolsContext.__PropertyOffset_ToolManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolsContext.__PropertyOffset_ToolManager, value);
			}
		}

		// Token: 0x17004DDD RID: 19933
		// (get) Token: 0x06013E2F RID: 81455 RVA: 0x001D3342 File Offset: 0x001D1542
		// (set) Token: 0x06013E30 RID: 81456 RVA: 0x001D3356 File Offset: 0x001D1556
		public unsafe UInteractiveGizmoManager GizmoManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInteractiveGizmoManager>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolsContext.__PropertyOffset_GizmoManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolsContext.__PropertyOffset_GizmoManager, value);
			}
		}

		// Token: 0x17004DDE RID: 19934
		// (get) Token: 0x06013E31 RID: 81457 RVA: 0x001D336B File Offset: 0x001D156B
		// (set) Token: 0x06013E32 RID: 81458 RVA: 0x001D337F File Offset: 0x001D157F
		public unsafe UContextObjectStore ContextObjectStore
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UContextObjectStore>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolsContext.__PropertyOffset_ContextObjectStore);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolsContext.__PropertyOffset_ContextObjectStore, value);
			}
		}

		// Token: 0x17004DDF RID: 19935
		// (get) Token: 0x06013E33 RID: 81459 RVA: 0x001D3394 File Offset: 0x001D1594
		// (set) Token: 0x06013E34 RID: 81460 RVA: 0x001D33A9 File Offset: 0x001D15A9
		[Nullable(1)]
		public TSoftClassPtr<UInteractiveToolManager> ToolManagerClass
		{
			[NullableContext(1)]
			get
			{
				return new TSoftClassPtr<UInteractiveToolManager>(base.NativePtr + (IntPtr)UInteractiveToolsContext.__PropertyOffset_ToolManagerClass, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UInteractiveToolsContext.__PropertyOffset_ToolManagerClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06013E35 RID: 81461 RVA: 0x001D33CE File Offset: 0x001D15CE
		static UInteractiveToolsContext()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.InteractiveToolsContext");
		}

		// Token: 0x06013E36 RID: 81462 RVA: 0x001D33DC File Offset: 0x001D15DC
		protected UInteractiveToolsContext(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC28 RID: 44072
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.InteractiveToolsContext";

		// Token: 0x0400AC29 RID: 44073
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC2A RID: 44074
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AC2B RID: 44075
		internal static int __PropertyOffset_InputRouter;

		// Token: 0x0400AC2C RID: 44076
		internal static int __PropertyOffset_TargetManager;

		// Token: 0x0400AC2D RID: 44077
		internal static int __PropertyOffset_ToolManager;

		// Token: 0x0400AC2E RID: 44078
		internal static int __PropertyOffset_GizmoManager;

		// Token: 0x0400AC2F RID: 44079
		internal static int __PropertyOffset_ContextObjectStore;

		// Token: 0x0400AC30 RID: 44080
		internal static int __PropertyOffset_ToolManagerClass;
	}
}
