using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001554 RID: 5460
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoComponentWorldTransformSource")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UGizmoComponentWorldTransformSource : UGizmoBaseTransformSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013CBD RID: 81085 RVA: 0x001D11CF File Offset: 0x001CF3CF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoComponentWorldTransformSource._ClassPtr;
		}

		// Token: 0x06013CBE RID: 81086 RVA: 0x001D11DC File Offset: 0x001CF3DC
		public UGizmoComponentWorldTransformSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoComponentWorldTransformSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013CBF RID: 81087 RVA: 0x001D1204 File Offset: 0x001CF404
		[NullableContext(1)]
		public UGizmoComponentWorldTransformSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoComponentWorldTransformSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D8C RID: 19852
		// (get) Token: 0x06013CC0 RID: 81088 RVA: 0x001D1237 File Offset: 0x001CF437
		// (set) Token: 0x06013CC1 RID: 81089 RVA: 0x001D124B File Offset: 0x001CF44B
		[Nullable(2)]
		public unsafe USceneComponent Component
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UGizmoComponentWorldTransformSource.__PropertyOffset_Component);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGizmoComponentWorldTransformSource.__PropertyOffset_Component, value);
			}
		}

		// Token: 0x17004D8D RID: 19853
		// (get) Token: 0x06013CC2 RID: 81090 RVA: 0x001D1260 File Offset: 0x001CF460
		// (set) Token: 0x06013CC3 RID: 81091 RVA: 0x001D1270 File Offset: 0x001CF470
		public unsafe bool bModifyComponentOnTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoComponentWorldTransformSource.__PropertyOffset_bModifyComponentOnTransform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoComponentWorldTransformSource.__PropertyOffset_bModifyComponentOnTransform) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013CC4 RID: 81092 RVA: 0x001D1281 File Offset: 0x001CF481
		static UGizmoComponentWorldTransformSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoComponentWorldTransformSource");
		}

		// Token: 0x06013CC5 RID: 81093 RVA: 0x001D128F File Offset: 0x001CF48F
		protected UGizmoComponentWorldTransformSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB5A RID: 43866
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoComponentWorldTransformSource";

		// Token: 0x0400AB5B RID: 43867
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB5C RID: 43868
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB5D RID: 43869
		internal static int __PropertyOffset_Component;

		// Token: 0x0400AB5E RID: 43870
		internal static int __PropertyOffset_bModifyComponentOnTransform;
	}
}
