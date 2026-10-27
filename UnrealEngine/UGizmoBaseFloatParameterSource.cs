using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200154C RID: 5452
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoBaseFloatParameterSource")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UGizmoBaseFloatParameterSource : UObject, IUnrealUObject, IUnrealObject, IGizmoFloatParameterSource, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013C73 RID: 81011 RVA: 0x001D0BA9 File Offset: 0x001CEDA9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoBaseFloatParameterSource._ClassPtr;
		}

		// Token: 0x06013C74 RID: 81012 RVA: 0x001D0BB5 File Offset: 0x001CEDB5
		int IGizmoFloatParameterSource.InterfaceOffset()
		{
			return UGizmoBaseFloatParameterSource.__InterfaceOffset_IGizmoFloatParameterSource;
		}

		// Token: 0x06013C75 RID: 81013 RVA: 0x001D0BBC File Offset: 0x001CEDBC
		public UGizmoBaseFloatParameterSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoBaseFloatParameterSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013C76 RID: 81014 RVA: 0x001D0BE4 File Offset: 0x001CEDE4
		[NullableContext(1)]
		public UGizmoBaseFloatParameterSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoBaseFloatParameterSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013C77 RID: 81015 RVA: 0x001D0C17 File Offset: 0x001CEE17
		static UGizmoBaseFloatParameterSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoBaseFloatParameterSource");
		}

		// Token: 0x06013C78 RID: 81016 RVA: 0x001D0C25 File Offset: 0x001CEE25
		protected UGizmoBaseFloatParameterSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB2F RID: 43823
		internal static int __InterfaceOffset_IGizmoFloatParameterSource;

		// Token: 0x0400AB30 RID: 43824
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoBaseFloatParameterSource";

		// Token: 0x0400AB31 RID: 43825
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB32 RID: 43826
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
