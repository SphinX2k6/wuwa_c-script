using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022F3 RID: 8947
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMIDINoteOn : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021EB2 RID: 138930 RVA: 0x003226A1 File Offset: 0x003208A1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMIDINoteOn.StaticFunctionPtr();
		}

		// Token: 0x06021EB3 RID: 138931 RVA: 0x003226AD File Offset: 0x003208AD
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMIDINoteOn._FunctionPtr == IntPtr.Zero)
			{
				FOnMIDINoteOn._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MIDIDevice.OnMIDINoteOn__DelegateSignature");
			}
			return FOnMIDINoteOn._FunctionPtr;
		}

		// Token: 0x06021EB4 RID: 138932 RVA: 0x003226D0 File Offset: 0x003208D0
		public FOnMIDINoteOn()
		{
		}

		// Token: 0x06021EB5 RID: 138933 RVA: 0x003226D8 File Offset: 0x003208D8
		[NullableContext(2)]
		public FOnMIDINoteOn(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021EB6 RID: 138934 RVA: 0x003226E2 File Offset: 0x003208E2
		public FOnMIDINoteOn(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021EB7 RID: 138935 RVA: 0x003226ED File Offset: 0x003208ED
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UMIDIDeviceInputController, int, int, int, int>) ?? ((Action<UMIDIDeviceInputController, int, int, int, int>)Delegate.CreateDelegate(typeof(Action<UMIDIDeviceInputController, int, int, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021EB8 RID: 138936 RVA: 0x0032271F File Offset: 0x0032091F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceInputController, int, int, int, int> Callback)
		{
			if (FOnMIDINoteOn.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMIDINoteOn.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMIDINoteOn.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMIDINoteOn.OnScriptCallback));
				}
				FOnMIDINoteOn.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMIDINoteOn.RegisterId);
		}

		// Token: 0x06021EB9 RID: 138937 RVA: 0x00322759 File Offset: 0x00320959
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceInputController, int, int, int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021EBA RID: 138938 RVA: 0x00322764 File Offset: 0x00320964
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UMIDIDeviceInputController MIDIDeviceController, int Timestamp, int Channel, int Note, int Velocity)
		{
			FOnMIDINoteOn.__FOnMIDINoteOn_DelegateParams* ptr = stackalloc FOnMIDINoteOn.__FOnMIDINoteOn_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnMIDINoteOn.__FOnMIDINoteOn_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMIDINoteOn.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->MIDIDeviceController = ((MIDIDeviceController != null) ? MIDIDeviceController.NativePtr : IntPtr.Zero);
			ptr->Timestamp = Timestamp;
			ptr->Channel = Channel;
			ptr->Note = Note;
			ptr->Velocity = Velocity;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06021EBB RID: 138939 RVA: 0x003227D0 File Offset: 0x003209D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UMIDIDeviceInputController, int, int, int, int> action = target as Action<UMIDIDeviceInputController, int, int, int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UMIDIDeviceInputController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMIDIDeviceInputController>(((FOnMIDINoteOn.__FOnMIDINoteOn_DelegateParams*)__Parameters)->MIDIDeviceController);
			action(orCreateUObjectByNativePointer, ((FOnMIDINoteOn.__FOnMIDINoteOn_DelegateParams*)__Parameters)->Timestamp, ((FOnMIDINoteOn.__FOnMIDINoteOn_DelegateParams*)__Parameters)->Channel, ((FOnMIDINoteOn.__FOnMIDINoteOn_DelegateParams*)__Parameters)->Note, ((FOnMIDINoteOn.__FOnMIDINoteOn_DelegateParams*)__Parameters)->Velocity);
		}

		// Token: 0x04012192 RID: 74130
		internal static IntPtr _FunctionPtr;

		// Token: 0x04012193 RID: 74131
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MIDIDevice.OnMIDINoteOn__DelegateSignature";

		// Token: 0x04012194 RID: 74132
		private static int RegisterId;

		// Token: 0x02003638 RID: 13880
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnMIDINoteOn_DelegateParams
		{
			// Token: 0x040176F3 RID: 95987
			[FieldOffset(0)]
			public IntPtr MIDIDeviceController;

			// Token: 0x040176F4 RID: 95988
			[FieldOffset(8)]
			public int Timestamp;

			// Token: 0x040176F5 RID: 95989
			[FieldOffset(12)]
			public int Channel;

			// Token: 0x040176F6 RID: 95990
			[FieldOffset(16)]
			public int Note;

			// Token: 0x040176F7 RID: 95991
			[FieldOffset(20)]
			public int Velocity;
		}

		// Token: 0x02003639 RID: 13881
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040176F8 RID: 95992
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
