using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CC3 RID: 3267
	[UnrealObjectPath("/Script/Engine.ISMPartitionActor")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public abstract class AISMPartitionActor : APartitionActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A51D RID: 42269 RVA: 0x000EAD54 File Offset: 0x000E8F54
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AISMPartitionActor._ClassPtr;
		}

		// Token: 0x0600A51E RID: 42270 RVA: 0x000EAD60 File Offset: 0x000E8F60
		static AISMPartitionActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ISMPartitionActor");
		}

		// Token: 0x0600A51F RID: 42271 RVA: 0x000EAD70 File Offset: 0x000E8F70
		protected AISMPartitionActor() : this(BuiltinUtils.AllocNativeUObject(AISMPartitionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A520 RID: 42272 RVA: 0x000EAD98 File Offset: 0x000E8F98
		protected AISMPartitionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005AD2 RID: 23250
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ISMPartitionActor";

		// Token: 0x04005AD3 RID: 23251
		private static IntPtr _ClassPtr;

		// Token: 0x04005AD4 RID: 23252
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
