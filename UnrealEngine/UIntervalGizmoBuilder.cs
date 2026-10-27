using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001585 RID: 5509
	[UnrealObjectPath("/Script/InteractiveToolsFramework.IntervalGizmoBuilder")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UIntervalGizmoBuilder : UInteractiveGizmoBuilder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E5D RID: 81501 RVA: 0x001D3761 File Offset: 0x001D1961
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UIntervalGizmoBuilder._ClassPtr;
		}

		// Token: 0x06013E5E RID: 81502 RVA: 0x001D3770 File Offset: 0x001D1970
		public UIntervalGizmoBuilder() : this(BuiltinUtils.AllocNativeUObject(UIntervalGizmoBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E5F RID: 81503 RVA: 0x001D3798 File Offset: 0x001D1998
		[NullableContext(1)]
		public UIntervalGizmoBuilder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UIntervalGizmoBuilder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013E60 RID: 81504 RVA: 0x001D37CB File Offset: 0x001D19CB
		static UIntervalGizmoBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.IntervalGizmoBuilder");
		}

		// Token: 0x06013E61 RID: 81505 RVA: 0x001D37D9 File Offset: 0x001D19D9
		protected UIntervalGizmoBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC49 RID: 44105
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.IntervalGizmoBuilder";

		// Token: 0x0400AC4A RID: 44106
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC4B RID: 44107
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
