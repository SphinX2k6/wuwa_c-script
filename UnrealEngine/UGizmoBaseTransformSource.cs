using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200154D RID: 5453
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoBaseTransformSource")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UGizmoBaseTransformSource : UObject, IUnrealUObject, IUnrealObject, IGizmoTransformSource, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013C79 RID: 81017 RVA: 0x001D0C2E File Offset: 0x001CEE2E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoBaseTransformSource._ClassPtr;
		}

		// Token: 0x06013C7A RID: 81018 RVA: 0x001D0C3A File Offset: 0x001CEE3A
		int IGizmoTransformSource.InterfaceOffset()
		{
			return UGizmoBaseTransformSource.__InterfaceOffset_IGizmoTransformSource;
		}

		// Token: 0x06013C7B RID: 81019 RVA: 0x001D0C44 File Offset: 0x001CEE44
		public UGizmoBaseTransformSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoBaseTransformSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013C7C RID: 81020 RVA: 0x001D0C6C File Offset: 0x001CEE6C
		[NullableContext(1)]
		public UGizmoBaseTransformSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoBaseTransformSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013C7D RID: 81021 RVA: 0x001D0C9F File Offset: 0x001CEE9F
		static UGizmoBaseTransformSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoBaseTransformSource");
		}

		// Token: 0x06013C7E RID: 81022 RVA: 0x001D0CAD File Offset: 0x001CEEAD
		protected UGizmoBaseTransformSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB33 RID: 43827
		internal static int __InterfaceOffset_IGizmoTransformSource;

		// Token: 0x0400AB34 RID: 43828
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoBaseTransformSource";

		// Token: 0x0400AB35 RID: 43829
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB36 RID: 43830
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
