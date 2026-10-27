using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007BE RID: 1982
	[UnrealObjectPath("/Script/Engine.ActorDescContainerSubsystem")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UActorDescContainerSubsystem : UEngineSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006A00 RID: 27136 RVA: 0x0009834A File Offset: 0x0009654A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActorDescContainerSubsystem._ClassPtr;
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x00098358 File Offset: 0x00096558
		public UActorDescContainerSubsystem() : this(BuiltinUtils.AllocNativeUObject(UActorDescContainerSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x00098380 File Offset: 0x00096580
		[NullableContext(1)]
		public UActorDescContainerSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActorDescContainerSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006A03 RID: 27139 RVA: 0x000983B3 File Offset: 0x000965B3
		static UActorDescContainerSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ActorDescContainerSubsystem");
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x000983C1 File Offset: 0x000965C1
		protected UActorDescContainerSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003319 RID: 13081
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ActorDescContainerSubsystem";

		// Token: 0x0400331A RID: 13082
		private static IntPtr _ClassPtr;

		// Token: 0x0400331B RID: 13083
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
