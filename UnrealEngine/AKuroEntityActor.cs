using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EB7 RID: 7863
	[UnrealObjectPath("/Script/KuroUtility.KuroEntityActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AKuroEntityActor : AKuroActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD80 RID: 122240 RVA: 0x002C2605 File Offset: 0x002C0805
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroEntityActor._ClassPtr;
		}

		// Token: 0x0601DD81 RID: 122241 RVA: 0x002C2614 File Offset: 0x002C0814
		public AKuroEntityActor() : this(BuiltinUtils.AllocNativeUObject(AKuroEntityActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD82 RID: 122242 RVA: 0x002C263C File Offset: 0x002C083C
		[NullableContext(1)]
		public AKuroEntityActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroEntityActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700779F RID: 30623
		// (get) Token: 0x0601DD83 RID: 122243 RVA: 0x002C266F File Offset: 0x002C086F
		// (set) Token: 0x0601DD84 RID: 122244 RVA: 0x002C267F File Offset: 0x002C087F
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

		// Token: 0x0601DD85 RID: 122245 RVA: 0x002C2690 File Offset: 0x002C0890
		static AKuroEntityActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroEntityActor");
		}

		// Token: 0x0601DD86 RID: 122246 RVA: 0x002C269E File Offset: 0x002C089E
		protected AKuroEntityActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102BB RID: 66235
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroEntityActor";

		// Token: 0x040102BC RID: 66236
		private static IntPtr _ClassPtr;

		// Token: 0x040102BD RID: 66237
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040102BE RID: 66238
		internal static int __PropertyOffset_EntityId;
	}
}
