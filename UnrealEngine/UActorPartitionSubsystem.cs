using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007CA RID: 1994
	[UnrealObjectPath("/Script/Engine.ActorPartitionSubsystem")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UActorPartitionSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006A66 RID: 27238 RVA: 0x0009953A File Offset: 0x0009773A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActorPartitionSubsystem._ClassPtr;
		}

		// Token: 0x06006A67 RID: 27239 RVA: 0x00099548 File Offset: 0x00097748
		public UActorPartitionSubsystem() : this(BuiltinUtils.AllocNativeUObject(UActorPartitionSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006A68 RID: 27240 RVA: 0x00099570 File Offset: 0x00097770
		[NullableContext(1)]
		public UActorPartitionSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActorPartitionSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x000995A3 File Offset: 0x000977A3
		static UActorPartitionSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ActorPartitionSubsystem");
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x000995B1 File Offset: 0x000977B1
		protected UActorPartitionSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400333C RID: 13116
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ActorPartitionSubsystem";

		// Token: 0x0400333D RID: 13117
		private static IntPtr _ClassPtr;

		// Token: 0x0400333E RID: 13118
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
