using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019CD RID: 6605
	[UnrealObjectPath("/Script/KuroMechanismSequenceRuntime.KuroMechanismTimelineSubsystem")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKuroMechanismTimelineSubsystem : UGameInstanceSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601889D RID: 100509 RVA: 0x00242330 File Offset: 0x00240530
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMechanismTimelineSubsystem._ClassPtr;
		}

		// Token: 0x0601889E RID: 100510 RVA: 0x0024233C File Offset: 0x0024053C
		public UKuroMechanismTimelineSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroMechanismTimelineSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601889F RID: 100511 RVA: 0x00242364 File Offset: 0x00240564
		[NullableContext(1)]
		public UKuroMechanismTimelineSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMechanismTimelineSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060188A0 RID: 100512 RVA: 0x00242397 File Offset: 0x00240597
		[NullableContext(2)]
		public static UKuroMechanismTimelineSubsystem GetSubSystem(UGameInstance GameInstance)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroMechanismTimelineSubsystem>(UKuroMechanismTimelineSubsystem.__GetSubSystem_Internal((GameInstance != null) ? GameInstance.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060188A1 RID: 100513 RVA: 0x002423B3 File Offset: 0x002405B3
		[NullableContext(2)]
		public void BindMechanismEvent(FTriggerMechanismEventDelegate MechanismEventHandler)
		{
			UKuroMechanismTimelineSubsystem.__BindMechanismEvent_Internal(base.NativePtr, (MechanismEventHandler != null) ? MechanismEventHandler.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060188A2 RID: 100514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSubSystem_Internal(IntPtr GameInstance);

		// Token: 0x060188A3 RID: 100515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindMechanismEvent_Internal(IntPtr @this, IntPtr MechanismEventHandler);

		// Token: 0x060188A4 RID: 100516 RVA: 0x002423CD File Offset: 0x002405CD
		static UKuroMechanismTimelineSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMechanismSequenceRuntime.KuroMechanismTimelineSubsystem");
		}

		// Token: 0x060188A5 RID: 100517 RVA: 0x002423DB File Offset: 0x002405DB
		protected UKuroMechanismTimelineSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D423 RID: 54307
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMechanismSequenceRuntime.KuroMechanismTimelineSubsystem";

		// Token: 0x0400D424 RID: 54308
		private static IntPtr _ClassPtr;

		// Token: 0x0400D425 RID: 54309
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
