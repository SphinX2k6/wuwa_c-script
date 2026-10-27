using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001543 RID: 5443
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoActor")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AGizmoActor : AInternalToolFrameworkActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013C06 RID: 80902 RVA: 0x001D00CE File Offset: 0x001CE2CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGizmoActor._ClassPtr;
		}

		// Token: 0x06013C07 RID: 80903 RVA: 0x001D00DC File Offset: 0x001CE2DC
		public AGizmoActor() : this(BuiltinUtils.AllocNativeUObject(AGizmoActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013C08 RID: 80904 RVA: 0x001D0104 File Offset: 0x001CE304
		[NullableContext(1)]
		public AGizmoActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGizmoActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013C09 RID: 80905 RVA: 0x001D0137 File Offset: 0x001CE337
		static AGizmoActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoActor");
		}

		// Token: 0x06013C0A RID: 80906 RVA: 0x001D0145 File Offset: 0x001CE345
		protected AGizmoActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AAF5 RID: 43765
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoActor";

		// Token: 0x0400AAF6 RID: 43766
		private static IntPtr _ClassPtr;

		// Token: 0x0400AAF7 RID: 43767
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
