using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000909 RID: 2313
	[UnrealObjectPath("/Script/Engine.CameraBlockingVolume")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class ACameraBlockingVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007F00 RID: 32512 RVA: 0x000B62E2 File Offset: 0x000B44E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACameraBlockingVolume._ClassPtr;
		}

		// Token: 0x06007F01 RID: 32513 RVA: 0x000B62F0 File Offset: 0x000B44F0
		public ACameraBlockingVolume() : this(BuiltinUtils.AllocNativeUObject(ACameraBlockingVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007F02 RID: 32514 RVA: 0x000B6318 File Offset: 0x000B4518
		[NullableContext(1)]
		public ACameraBlockingVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACameraBlockingVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007F03 RID: 32515 RVA: 0x000B634B File Offset: 0x000B454B
		static ACameraBlockingVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CameraBlockingVolume");
		}

		// Token: 0x06007F04 RID: 32516 RVA: 0x000B6359 File Offset: 0x000B4559
		protected ACameraBlockingVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003CF0 RID: 15600
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CameraBlockingVolume";

		// Token: 0x04003CF1 RID: 15601
		private static IntPtr _ClassPtr;

		// Token: 0x04003CF2 RID: 15602
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
