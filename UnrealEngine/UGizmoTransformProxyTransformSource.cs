using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001566 RID: 5478
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoTransformProxyTransformSource")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UGizmoTransformProxyTransformSource : UGizmoBaseTransformSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013D81 RID: 81281 RVA: 0x001D2386 File Offset: 0x001D0586
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoTransformProxyTransformSource._ClassPtr;
		}

		// Token: 0x06013D82 RID: 81282 RVA: 0x001D2394 File Offset: 0x001D0594
		public UGizmoTransformProxyTransformSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoTransformProxyTransformSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013D83 RID: 81283 RVA: 0x001D23BC File Offset: 0x001D05BC
		[NullableContext(1)]
		public UGizmoTransformProxyTransformSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoTransformProxyTransformSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DBD RID: 19901
		// (get) Token: 0x06013D84 RID: 81284 RVA: 0x001D23EF File Offset: 0x001D05EF
		// (set) Token: 0x06013D85 RID: 81285 RVA: 0x001D2403 File Offset: 0x001D0603
		[Nullable(2)]
		public unsafe UTransformProxy Proxy
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTransformProxy>(base.NativePtr / (IntPtr)sizeof(void*) + UGizmoTransformProxyTransformSource.__PropertyOffset_Proxy);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGizmoTransformProxyTransformSource.__PropertyOffset_Proxy, value);
			}
		}

		// Token: 0x06013D86 RID: 81286 RVA: 0x001D2418 File Offset: 0x001D0618
		static UGizmoTransformProxyTransformSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoTransformProxyTransformSource");
		}

		// Token: 0x06013D87 RID: 81287 RVA: 0x001D2426 File Offset: 0x001D0626
		protected UGizmoTransformProxyTransformSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ABC7 RID: 43975
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoTransformProxyTransformSource";

		// Token: 0x0400ABC8 RID: 43976
		private static IntPtr _ClassPtr;

		// Token: 0x0400ABC9 RID: 43977
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ABCA RID: 43978
		internal static int __PropertyOffset_Proxy;
	}
}
