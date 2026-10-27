using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EAD RID: 7853
	[UnrealObjectPath("/Script/KuroUtility.KuroBlockingVolume")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class AKuroBlockingVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD15 RID: 122133 RVA: 0x002C1C10 File Offset: 0x002BFE10
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroBlockingVolume._ClassPtr;
		}

		// Token: 0x0601DD16 RID: 122134 RVA: 0x002C1C1C File Offset: 0x002BFE1C
		public AKuroBlockingVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroBlockingVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD17 RID: 122135 RVA: 0x002C1C44 File Offset: 0x002BFE44
		[NullableContext(1)]
		public AKuroBlockingVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroBlockingVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007798 RID: 30616
		// (get) Token: 0x0601DD18 RID: 122136 RVA: 0x002C1C77 File Offset: 0x002BFE77
		// (set) Token: 0x0601DD19 RID: 122137 RVA: 0x002C1C8B File Offset: 0x002BFE8B
		public unsafe FName VolumeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBlockingVolume.__PropertyOffset_VolumeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBlockingVolume.__PropertyOffset_VolumeId) = value;
			}
		}

		// Token: 0x0601DD1A RID: 122138 RVA: 0x002C1CA0 File Offset: 0x002BFEA0
		static AKuroBlockingVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroBlockingVolume");
		}

		// Token: 0x0601DD1B RID: 122139 RVA: 0x002C1CAE File Offset: 0x002BFEAE
		protected AKuroBlockingVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401028F RID: 66191
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroBlockingVolume";

		// Token: 0x04010290 RID: 66192
		private static IntPtr _ClassPtr;

		// Token: 0x04010291 RID: 66193
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010292 RID: 66194
		internal static int __PropertyOffset_VolumeId;
	}
}
