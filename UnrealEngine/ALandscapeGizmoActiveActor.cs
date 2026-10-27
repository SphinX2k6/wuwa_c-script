using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F71 RID: 8049
	[UnrealObjectPath("/Script/Landscape.LandscapeGizmoActiveActor")]
	[UnrealStructLayout(1392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1392)]
	public class ALandscapeGizmoActiveActor : ALandscapeGizmoActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E8B9 RID: 125113 RVA: 0x002D6618 File Offset: 0x002D4818
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALandscapeGizmoActiveActor._ClassPtr;
		}

		// Token: 0x0601E8BA RID: 125114 RVA: 0x002D6624 File Offset: 0x002D4824
		public ALandscapeGizmoActiveActor() : this(BuiltinUtils.AllocNativeUObject(ALandscapeGizmoActiveActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E8BB RID: 125115 RVA: 0x002D664C File Offset: 0x002D484C
		[NullableContext(1)]
		public ALandscapeGizmoActiveActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALandscapeGizmoActiveActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E8BC RID: 125116 RVA: 0x002D667F File Offset: 0x002D487F
		static ALandscapeGizmoActiveActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeGizmoActiveActor");
		}

		// Token: 0x0601E8BD RID: 125117 RVA: 0x002D668D File Offset: 0x002D488D
		protected ALandscapeGizmoActiveActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401081C RID: 67612
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.LandscapeGizmoActiveActor";

		// Token: 0x0401081D RID: 67613
		private static IntPtr _ClassPtr;

		// Token: 0x0401081E RID: 67614
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
