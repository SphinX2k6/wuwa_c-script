using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022EE RID: 8942
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMIDIAftertouch : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021E80 RID: 138880 RVA: 0x00321E9D File Offset: 0x0032009D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMIDIAftertouch.StaticFunctionPtr();
		}

		// Token: 0x06021E81 RID: 138881 RVA: 0x00321EA9 File Offset: 0x003200A9
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMIDIAftertouch._FunctionPtr == IntPtr.Zero)
			{
				FOnMIDIAftertouch._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MIDIDevice.OnMIDIAftertouch__DelegateSignature");
			}
			return FOnMIDIAftertouch._FunctionPtr;
		}

		// Token: 0x06021E82 RID: 138882 RVA: 0x00321ECC File Offset: 0x003200CC
		public FOnMIDIAftertouch()
		{
		}

		// Token: 0x06021E83 RID: 138883 RVA: 0x00321ED4 File Offset: 0x003200D4
		[NullableContext(2)]
		public FOnMIDIAftertouch(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021E84 RID: 138884 RVA: 0x00321EDE File Offset: 0x003200DE
		public FOnMIDIAftertouch(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021E85 RID: 138885 RVA: 0x00321EE9 File Offset: 0x003200E9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UMIDIDeviceInputController, int, int, int, int>) ?? ((Action<UMIDIDeviceInputController, int, int, int, int>)Delegate.CreateDelegate(typeof(Action<UMIDIDeviceInputController, int, int, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021E86 RID: 138886 RVA: 0x00321F1B File Offset: 0x0032011B
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceInputController, int, int, int, int> Callback)
		{
			if (FOnMIDIAftertouch.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMIDIAftertouch.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMIDIAftertouch.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMIDIAftertouch.OnScriptCallback));
				}
				FOnMIDIAftertouch.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMIDIAftertouch.RegisterId);
		}

		// Token: 0x06021E87 RID: 138887 RVA: 0x00321F55 File Offset: 0x00320155
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceInputController, int, int, int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021E88 RID: 138888 RVA: 0x00321F60 File Offset: 0x00320160
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UMIDIDeviceInputController MIDIDeviceController, int Timestamp, int Channel, int Note, int Amount)
		{
			FOnMIDIAftertouch.__FOnMIDIAftertouch_DelegateParams* ptr = stackalloc FOnMIDIAftertouch.__FOnMIDIAftertouch_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnMIDIAftertouch.__FOnMIDIAftertouch_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMIDIAftertouch.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->MIDIDeviceController = ((MIDIDeviceController != null) ? MIDIDeviceController.NativePtr : IntPtr.Zero);
			ptr->Timestamp = Timestamp;
			ptr->Channel = Channel;
			ptr->Note = Note;
			ptr->Amount = Amount;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06021E89 RID: 138889 RVA: 0x00321FCC File Offset: 0x003201CC
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
			UMIDIDeviceInputController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMIDIDeviceInputController>(((FOnMIDIAftertouch.__FOnMIDIAftertouch_DelegateParams*)__Parameters)->MIDIDeviceController);
			action(orCreateUObjectByNativePointer, ((FOnMIDIAftertouch.__FOnMIDIAftertouch_DelegateParams*)__Parameters)->Timestamp, ((FOnMIDIAftertouch.__FOnMIDIAftertouch_DelegateParams*)__Parameters)->Channel, ((FOnMIDIAftertouch.__FOnMIDIAftertouch_DelegateParams*)__Parameters)->Note, ((FOnMIDIAftertouch.__FOnMIDIAftertouch_DelegateParams*)__Parameters)->Amount);
		}

		// Token: 0x04012183 RID: 74115
		internal static IntPtr _FunctionPtr;

		// Token: 0x04012184 RID: 74116
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MIDIDevice.OnMIDIAftertouch__DelegateSignature";

		// Token: 0x04012185 RID: 74117
		private static int RegisterId;

		// Token: 0x0200362E RID: 13870
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnMIDIAftertouch_DelegateParams
		{
			// Token: 0x040176D4 RID: 95956
			[FieldOffset(0)]
			public IntPtr MIDIDeviceController;

			// Token: 0x040176D5 RID: 95957
			[FieldOffset(8)]
			public int Timestamp;

			// Token: 0x040176D6 RID: 95958
			[FieldOffset(12)]
			public int Channel;

			// Token: 0x040176D7 RID: 95959
			[FieldOffset(16)]
			public int Note;

			// Token: 0x040176D8 RID: 95960
			[FieldOffset(20)]
			public int Amount;
		}

		// Token: 0x0200362F RID: 13871
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040176D9 RID: 95961
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
