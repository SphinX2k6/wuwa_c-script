using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F72 RID: 8050
	[UnrealObjectPath("/Script/Landscape.LandscapeGizmoActor")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class ALandscapeGizmoActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E8BE RID: 125118 RVA: 0x002D6696 File Offset: 0x002D4896
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALandscapeGizmoActor._ClassPtr;
		}

		// Token: 0x0601E8BF RID: 125119 RVA: 0x002D66A4 File Offset: 0x002D48A4
		public ALandscapeGizmoActor() : this(BuiltinUtils.AllocNativeUObject(ALandscapeGizmoActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E8C0 RID: 125120 RVA: 0x002D66CC File Offset: 0x002D48CC
		[NullableContext(1)]
		public ALandscapeGizmoActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALandscapeGizmoActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E8C1 RID: 125121 RVA: 0x002D66FF File Offset: 0x002D48FF
		static ALandscapeGizmoActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeGizmoActor");
		}

		// Token: 0x0601E8C2 RID: 125122 RVA: 0x002D670D File Offset: 0x002D490D
		protected ALandscapeGizmoActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401081F RID: 67615
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.LandscapeGizmoActor";

		// Token: 0x04010820 RID: 67616
		private static IntPtr _ClassPtr;

		// Token: 0x04010821 RID: 67617
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
