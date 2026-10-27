using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022EF RID: 8943
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMIDIChannelAftertouch : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021E8A RID: 138890 RVA: 0x00322035 File Offset: 0x00320235
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMIDIChannelAftertouch.StaticFunctionPtr();
		}

		// Token: 0x06021E8B RID: 138891 RVA: 0x00322041 File Offset: 0x00320241
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMIDIChannelAftertouch._FunctionPtr == IntPtr.Zero)
			{
				FOnMIDIChannelAftertouch._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MIDIDevice.OnMIDIChannelAftertouch__DelegateSignature");
			}
			return FOnMIDIChannelAftertouch._FunctionPtr;
		}

		// Token: 0x06021E8C RID: 138892 RVA: 0x00322064 File Offset: 0x00320264
		public FOnMIDIChannelAftertouch()
		{
		}

		// Token: 0x06021E8D RID: 138893 RVA: 0x0032206C File Offset: 0x0032026C
		[NullableContext(2)]
		public FOnMIDIChannelAftertouch(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021E8E RID: 138894 RVA: 0x00322076 File Offset: 0x00320276
		public FOnMIDIChannelAftertouch(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021E8F RID: 138895 RVA: 0x00322081 File Offset: 0x00320281
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UMIDIDeviceInputController, int, int, int>) ?? ((Action<UMIDIDeviceInputController, int, int, int>)Delegate.CreateDelegate(typeof(Action<UMIDIDeviceInputController, int, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021E90 RID: 138896 RVA: 0x003220B3 File Offset: 0x003202B3
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceInputController, int, int, int> Callback)
		{
			if (FOnMIDIChannelAftertouch.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMIDIChannelAftertouch.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMIDIChannelAftertouch.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMIDIChannelAftertouch.OnScriptCallback));
				}
				FOnMIDIChannelAftertouch.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMIDIChannelAftertouch.RegisterId);
		}

		// Token: 0x06021E91 RID: 138897 RVA: 0x003220ED File Offset: 0x003202ED
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceInputController, int, int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021E92 RID: 138898 RVA: 0x003220F8 File Offset: 0x003202F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UMIDIDeviceInputController MIDIDeviceController, int Timestamp, int Channel, int Amount)
		{
			FOnMIDIChannelAftertouch.__FOnMIDIChannelAftertouch_DelegateParams* ptr = stackalloc FOnMIDIChannelAftertouch.__FOnMIDIChannelAftertouch_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnMIDIChannelAftertouch.__FOnMIDIChannelAftertouch_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMIDIChannelAftertouch.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->MIDIDeviceController = ((MIDIDeviceController != null) ? MIDIDeviceController.NativePtr : IntPtr.Zero);
			ptr->Timestamp = Timestamp;
			ptr->Channel = Channel;
			ptr->Amount = Amount;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06021E93 RID: 138899 RVA: 0x0032215C File Offset: 0x0032035C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UMIDIDeviceInputController, int, int, int> action = target as Action<UMIDIDeviceInputController, int, int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UMIDIDeviceInputController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMIDIDeviceInputController>(((FOnMIDIChannelAftertouch.__FOnMIDIChannelAftertouch_DelegateParams*)__Parameters)->MIDIDeviceController);
			action(orCreateUObjectByNativePointer, ((FOnMIDIChannelAftertouch.__FOnMIDIChannelAftertouch_DelegateParams*)__Parameters)->Timestamp, ((FOnMIDIChannelAftertouch.__FOnMIDIChannelAftertouch_DelegateParams*)__Parameters)->Channel, ((FOnMIDIChannelAftertouch.__FOnMIDIChannelAftertouch_DelegateParams*)__Parameters)->Amount);
		}

		// Token: 0x04012186 RID: 74118
		internal static IntPtr _FunctionPtr;

		// Token: 0x04012187 RID: 74119
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MIDIDevice.OnMIDIChannelAftertouch__DelegateSignature";

		// Token: 0x04012188 RID: 74120
		private static int RegisterId;

		// Token: 0x02003630 RID: 13872
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnMIDIChannelAftertouch_DelegateParams
		{
			// Token: 0x040176DA RID: 95962
			[FieldOffset(0)]
			public IntPtr MIDIDeviceController;

			// Token: 0x040176DB RID: 95963
			[FieldOffset(8)]
			public int Timestamp;

			// Token: 0x040176DC RID: 95964
			[FieldOffset(12)]
			public int Channel;

			// Token: 0x040176DD RID: 95965
			[FieldOffset(16)]
			public int Amount;
		}

		// Token: 0x02003631 RID: 13873
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040176DE RID: 95966
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
