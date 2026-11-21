using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000461 RID: 1121
	[UnrealObjectPath("/Script/KuroMechanismSequenceRuntime.KuroMechanismTimelineSubsystem")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKuroMechanismTimelineSubsystem : UGameInstanceSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006B69 RID: 27497 RVA: 0x0009C59E File Offset: 0x0009A79E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMechanismTimelineSubsystem._ClassPtr;
		}

		// Token: 0x06006B6A RID: 27498 RVA: 0x0009C5AC File Offset: 0x0009A7AC
		public UKuroMechanismTimelineSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroMechanismTimelineSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006B6B RID: 27499 RVA: 0x0009C5D4 File Offset: 0x0009A7D4
		[NullableContext(1)]
		public UKuroMechanismTimelineSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMechanismTimelineSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006B6C RID: 27500 RVA: 0x0009C607 File Offset: 0x0009A807
		[NullableContext(2)]
		public static UKuroMechanismTimelineSubsystem GetSubSystem(UGameInstance GameInstance)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroMechanismTimelineSubsystem>(UKuroMechanismTimelineSubsystem.__GetSubSystem_Internal((GameInstance != null) ? GameInstance.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06006B6D RID: 27501 RVA: 0x0009C623 File Offset: 0x0009A823
		[NullableContext(2)]
		public void BindMechanismEvent(FTriggerMechanismEventDelegate MechanismEventHandler)
		{
			UKuroMechanismTimelineSubsystem.__BindMechanismEvent_Internal(base.NativePtr, (MechanismEventHandler != null) ? MechanismEventHandler.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06006B6E RID: 27502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSubSystem_Internal(IntPtr GameInstance);

		// Token: 0x06006B6F RID: 27503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindMechanismEvent_Internal(IntPtr @this, IntPtr MechanismEventHandler);

		// Token: 0x06006B70 RID: 27504 RVA: 0x0009C63D File Offset: 0x0009A83D
		static UKuroMechanismTimelineSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMechanismSequenceRuntime.KuroMechanismTimelineSubsystem");
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x0009C64B File Offset: 0x0009A84B
		protected UKuroMechanismTimelineSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002DB8 RID: 11704
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMechanismSequenceRuntime.KuroMechanismTimelineSubsystem";

		// Token: 0x04002DB9 RID: 11705
		private static IntPtr _ClassPtr;

		// Token: 0x04002DBA RID: 11706
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
