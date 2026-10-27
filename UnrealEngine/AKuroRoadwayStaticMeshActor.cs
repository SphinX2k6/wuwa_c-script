using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001906 RID: 6406
	[UnrealObjectPath("/Script/KuroGameplay.KuroRoadwayStaticMeshActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AKuroRoadwayStaticMeshActor : AStaticMeshActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017C6E RID: 97390 RVA: 0x0022D56A File Offset: 0x0022B76A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroRoadwayStaticMeshActor._ClassPtr;
		}

		// Token: 0x06017C6F RID: 97391 RVA: 0x0022D578 File Offset: 0x0022B778
		public AKuroRoadwayStaticMeshActor() : this(BuiltinUtils.AllocNativeUObject(AKuroRoadwayStaticMeshActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017C70 RID: 97392 RVA: 0x0022D5A0 File Offset: 0x0022B7A0
		[NullableContext(1)]
		public AKuroRoadwayStaticMeshActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroRoadwayStaticMeshActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017C71 RID: 97393 RVA: 0x0022D5D3 File Offset: 0x0022B7D3
		static AKuroRoadwayStaticMeshActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroRoadwayStaticMeshActor");
		}

		// Token: 0x06017C72 RID: 97394 RVA: 0x0022D5E1 File Offset: 0x0022B7E1
		protected AKuroRoadwayStaticMeshActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE58 RID: 52824
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroRoadwayStaticMeshActor";

		// Token: 0x0400CE59 RID: 52825
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE5A RID: 52826
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
