using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022F4 RID: 8948
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMIDIPitchBend : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021EBC RID: 138940 RVA: 0x00322839 File Offset: 0x00320A39
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMIDIPitchBend.StaticFunctionPtr();
		}

		// Token: 0x06021EBD RID: 138941 RVA: 0x00322845 File Offset: 0x00320A45
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMIDIPitchBend._FunctionPtr == IntPtr.Zero)
			{
				FOnMIDIPitchBend._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MIDIDevice.OnMIDIPitchBend__DelegateSignature");
			}
			return FOnMIDIPitchBend._FunctionPtr;
		}

		// Token: 0x06021EBE RID: 138942 RVA: 0x00322868 File Offset: 0x00320A68
		public FOnMIDIPitchBend()
		{
		}

		// Token: 0x06021EBF RID: 138943 RVA: 0x00322870 File Offset: 0x00320A70
		[NullableContext(2)]
		public FOnMIDIPitchBend(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021EC0 RID: 138944 RVA: 0x0032287A File Offset: 0x00320A7A
		public FOnMIDIPitchBend(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021EC1 RID: 138945 RVA: 0x00322885 File Offset: 0x00320A85
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UMIDIDeviceInputController, int, int, int>) ?? ((Action<UMIDIDeviceInputController, int, int, int>)Delegate.CreateDelegate(typeof(Action<UMIDIDeviceInputController, int, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021EC2 RID: 138946 RVA: 0x003228B7 File Offset: 0x00320AB7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceInputController, int, int, int> Callback)
		{
			if (FOnMIDIPitchBend.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMIDIPitchBend.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMIDIPitchBend.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMIDIPitchBend.OnScriptCallback));
				}
				FOnMIDIPitchBend.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMIDIPitchBend.RegisterId);
		}

		// Token: 0x06021EC3 RID: 138947 RVA: 0x003228F1 File Offset: 0x00320AF1
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceInputController, int, int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021EC4 RID: 138948 RVA: 0x003228FC File Offset: 0x00320AFC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UMIDIDeviceInputController MIDIDeviceController, int Timestamp, int Channel, int Pitch)
		{
			FOnMIDIPitchBend.__FOnMIDIPitchBend_DelegateParams* ptr = stackalloc FOnMIDIPitchBend.__FOnMIDIPitchBend_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnMIDIPitchBend.__FOnMIDIPitchBend_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMIDIPitchBend.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->MIDIDeviceController = ((MIDIDeviceController != null) ? MIDIDeviceController.NativePtr : IntPtr.Zero);
			ptr->Timestamp = Timestamp;
			ptr->Channel = Channel;
			ptr->Pitch = Pitch;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06021EC5 RID: 138949 RVA: 0x00322960 File Offset: 0x00320B60
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
			UMIDIDeviceInputController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMIDIDeviceInputController>(((FOnMIDIPitchBend.__FOnMIDIPitchBend_DelegateParams*)__Parameters)->MIDIDeviceController);
			action(orCreateUObjectByNativePointer, ((FOnMIDIPitchBend.__FOnMIDIPitchBend_DelegateParams*)__Parameters)->Timestamp, ((FOnMIDIPitchBend.__FOnMIDIPitchBend_DelegateParams*)__Parameters)->Channel, ((FOnMIDIPitchBend.__FOnMIDIPitchBend_DelegateParams*)__Parameters)->Pitch);
		}

		// Token: 0x04012195 RID: 74133
		internal static IntPtr _FunctionPtr;

		// Token: 0x04012196 RID: 74134
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MIDIDevice.OnMIDIPitchBend__DelegateSignature";

		// Token: 0x04012197 RID: 74135
		private static int RegisterId;

		// Token: 0x0200363A RID: 13882
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnMIDIPitchBend_DelegateParams
		{
			// Token: 0x040176F9 RID: 95993
			[FieldOffset(0)]
			public IntPtr MIDIDeviceController;

			// Token: 0x040176FA RID: 95994
			[FieldOffset(8)]
			public int Timestamp;

			// Token: 0x040176FB RID: 95995
			[FieldOffset(12)]
			public int Channel;

			// Token: 0x040176FC RID: 95996
			[FieldOffset(16)]
			public int Pitch;
		}

		// Token: 0x0200363B RID: 13883
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040176FD RID: 95997
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
