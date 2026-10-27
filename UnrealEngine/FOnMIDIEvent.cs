using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022F1 RID: 8945
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMIDIEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021E9E RID: 138910 RVA: 0x00322355 File Offset: 0x00320555
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMIDIEvent.StaticFunctionPtr();
		}

		// Token: 0x06021E9F RID: 138911 RVA: 0x00322361 File Offset: 0x00320561
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMIDIEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnMIDIEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MIDIDevice.OnMIDIEvent__DelegateSignature");
			}
			return FOnMIDIEvent._FunctionPtr;
		}

		// Token: 0x06021EA0 RID: 138912 RVA: 0x00322384 File Offset: 0x00320584
		public FOnMIDIEvent()
		{
		}

		// Token: 0x06021EA1 RID: 138913 RVA: 0x0032238C File Offset: 0x0032058C
		[NullableContext(2)]
		public FOnMIDIEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021EA2 RID: 138914 RVA: 0x00322396 File Offset: 0x00320596
		public FOnMIDIEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021EA3 RID: 138915 RVA: 0x003223A1 File Offset: 0x003205A1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UMIDIDeviceController, int, EMIDIEventType, int, int, int, int>) ?? ((Action<UMIDIDeviceController, int, EMIDIEventType, int, int, int, int>)Delegate.CreateDelegate(typeof(Action<UMIDIDeviceController, int, EMIDIEventType, int, int, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021EA4 RID: 138916 RVA: 0x003223D3 File Offset: 0x003205D3
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceController, int, EMIDIEventType, int, int, int, int> Callback)
		{
			if (FOnMIDIEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMIDIEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMIDIEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMIDIEvent.OnScriptCallback));
				}
				FOnMIDIEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMIDIEvent.RegisterId);
		}

		// Token: 0x06021EA5 RID: 138917 RVA: 0x0032240D File Offset: 0x0032060D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceController, int, EMIDIEventType, int, int, int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021EA6 RID: 138918 RVA: 0x00322418 File Offset: 0x00320618
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UMIDIDeviceController MIDIDeviceController, int Timestamp, EMIDIEventType EventType, int Channel, int ControlID, int Velocity, int RawEventType)
		{
			FOnMIDIEvent.__FOnMIDIEvent_DelegateParams* ptr = stackalloc FOnMIDIEvent.__FOnMIDIEvent_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnMIDIEvent.__FOnMIDIEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMIDIEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->MIDIDeviceController = ((MIDIDeviceController != null) ? MIDIDeviceController.NativePtr : IntPtr.Zero);
			ptr->Timestamp = Timestamp;
			ptr->EventType = EventType;
			ptr->Channel = Channel;
			ptr->ControlID = ControlID;
			ptr->Velocity = Velocity;
			ptr->RawEventType = RawEventType;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06021EA7 RID: 138919 RVA: 0x00322494 File Offset: 0x00320694
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UMIDIDeviceController, int, EMIDIEventType, int, int, int, int> action = target as Action<UMIDIDeviceController, int, EMIDIEventType, int, int, int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UMIDIDeviceController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMIDIDeviceController>(((FOnMIDIEvent.__FOnMIDIEvent_DelegateParams*)__Parameters)->MIDIDeviceController);
			action(orCreateUObjectByNativePointer, ((FOnMIDIEvent.__FOnMIDIEvent_DelegateParams*)__Parameters)->Timestamp, ((FOnMIDIEvent.__FOnMIDIEvent_DelegateParams*)__Parameters)->EventType, ((FOnMIDIEvent.__FOnMIDIEvent_DelegateParams*)__Parameters)->Channel, ((FOnMIDIEvent.__FOnMIDIEvent_DelegateParams*)__Parameters)->ControlID, ((FOnMIDIEvent.__FOnMIDIEvent_DelegateParams*)__Parameters)->Velocity, ((FOnMIDIEvent.__FOnMIDIEvent_DelegateParams*)__Parameters)->RawEventType);
		}

		// Token: 0x0401218C RID: 74124
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401218D RID: 74125
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MIDIDevice.OnMIDIEvent__DelegateSignature";

		// Token: 0x0401218E RID: 74126
		private static int RegisterId;

		// Token: 0x02003634 RID: 13876
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnMIDIEvent_DelegateParams
		{
			// Token: 0x040176E5 RID: 95973
			[FieldOffset(0)]
			public IntPtr MIDIDeviceController;

			// Token: 0x040176E6 RID: 95974
			[FieldOffset(8)]
			public int Timestamp;

			// Token: 0x040176E7 RID: 95975
			[FieldOffset(12)]
			public EMIDIEventType EventType;

			// Token: 0x040176E8 RID: 95976
			[FieldOffset(16)]
			public int Channel;

			// Token: 0x040176E9 RID: 95977
			[FieldOffset(20)]
			public int ControlID;

			// Token: 0x040176EA RID: 95978
			[FieldOffset(24)]
			public int Velocity;

			// Token: 0x040176EB RID: 95979
			[FieldOffset(28)]
			public int RawEventType;
		}

		// Token: 0x02003635 RID: 13877
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040176EC RID: 95980
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
