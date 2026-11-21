using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005D5 RID: 1493
	[UnrealObjectPath("/Script/KuroUtility.KuroEntityActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AKuroEntityActor : AKuroActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600844D RID: 33869 RVA: 0x000C46A1 File Offset: 0x000C28A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroEntityActor._ClassPtr;
		}

		// Token: 0x0600844E RID: 33870 RVA: 0x000C46B0 File Offset: 0x000C28B0
		public AKuroEntityActor() : this(BuiltinUtils.AllocNativeUObject(AKuroEntityActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600844F RID: 33871 RVA: 0x000C46D8 File Offset: 0x000C28D8
		[NullableContext(1)]
		public AKuroEntityActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroEntityActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x06008450 RID: 33872 RVA: 0x000C470B File Offset: 0x000C290B
		// (set) Token: 0x06008451 RID: 33873 RVA: 0x000C471B File Offset: 0x000C291B
		public unsafe int EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroEntityActor.__PropertyOffset_EntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroEntityActor.__PropertyOffset_EntityId) = value;
			}
		}

		// Token: 0x06008452 RID: 33874 RVA: 0x000C472C File Offset: 0x000C292C
		static AKuroEntityActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroEntityActor");
		}

		// Token: 0x06008453 RID: 33875 RVA: 0x000C473A File Offset: 0x000C293A
		protected AKuroEntityActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039D1 RID: 14801
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroEntityActor";

		// Token: 0x040039D2 RID: 14802
		private static IntPtr _ClassPtr;

		// Token: 0x040039D3 RID: 14803
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040039D4 RID: 14804
		internal static int __PropertyOffset_EntityId;
	}
}
