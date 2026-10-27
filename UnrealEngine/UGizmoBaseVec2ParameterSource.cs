using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200154E RID: 5454
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoBaseVec2ParameterSource")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UGizmoBaseVec2ParameterSource : UObject, IUnrealUObject, IUnrealObject, IGizmoVec2ParameterSource, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013C7F RID: 81023 RVA: 0x001D0CB6 File Offset: 0x001CEEB6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoBaseVec2ParameterSource._ClassPtr;
		}

		// Token: 0x06013C80 RID: 81024 RVA: 0x001D0CC2 File Offset: 0x001CEEC2
		int IGizmoVec2ParameterSource.InterfaceOffset()
		{
			return UGizmoBaseVec2ParameterSource.__InterfaceOffset_IGizmoVec2ParameterSource;
		}

		// Token: 0x06013C81 RID: 81025 RVA: 0x001D0CCC File Offset: 0x001CEECC
		public UGizmoBaseVec2ParameterSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoBaseVec2ParameterSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013C82 RID: 81026 RVA: 0x001D0CF4 File Offset: 0x001CEEF4
		[NullableContext(1)]
		public UGizmoBaseVec2ParameterSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoBaseVec2ParameterSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013C83 RID: 81027 RVA: 0x001D0D27 File Offset: 0x001CEF27
		static UGizmoBaseVec2ParameterSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoBaseVec2ParameterSource");
		}

		// Token: 0x06013C84 RID: 81028 RVA: 0x001D0D35 File Offset: 0x001CEF35
		protected UGizmoBaseVec2ParameterSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB37 RID: 43831
		internal static int __InterfaceOffset_IGizmoVec2ParameterSource;

		// Token: 0x0400AB38 RID: 43832
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoBaseVec2ParameterSource";

		// Token: 0x0400AB39 RID: 43833
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB3A RID: 43834
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
