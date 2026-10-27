using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022F2 RID: 8946
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMIDINoteOff : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021EA8 RID: 138920 RVA: 0x00322509 File Offset: 0x00320709
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMIDINoteOff.StaticFunctionPtr();
		}

		// Token: 0x06021EA9 RID: 138921 RVA: 0x00322515 File Offset: 0x00320715
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMIDINoteOff._FunctionPtr == IntPtr.Zero)
			{
				FOnMIDINoteOff._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MIDIDevice.OnMIDINoteOff__DelegateSignature");
			}
			return FOnMIDINoteOff._FunctionPtr;
		}

		// Token: 0x06021EAA RID: 138922 RVA: 0x00322538 File Offset: 0x00320738
		public FOnMIDINoteOff()
		{
		}

		// Token: 0x06021EAB RID: 138923 RVA: 0x00322540 File Offset: 0x00320740
		[NullableContext(2)]
		public FOnMIDINoteOff(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021EAC RID: 138924 RVA: 0x0032254A File Offset: 0x0032074A
		public FOnMIDINoteOff(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021EAD RID: 138925 RVA: 0x00322555 File Offset: 0x00320755
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UMIDIDeviceInputController, int, int, int, int>) ?? ((Action<UMIDIDeviceInputController, int, int, int, int>)Delegate.CreateDelegate(typeof(Action<UMIDIDeviceInputController, int, int, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021EAE RID: 138926 RVA: 0x00322587 File Offset: 0x00320787
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceInputController, int, int, int, int> Callback)
		{
			if (FOnMIDINoteOff.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMIDINoteOff.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMIDINoteOff.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMIDINoteOff.OnScriptCallback));
				}
				FOnMIDINoteOff.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMIDINoteOff.RegisterId);
		}

		// Token: 0x06021EAF RID: 138927 RVA: 0x003225C1 File Offset: 0x003207C1
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceInputController, int, int, int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021EB0 RID: 138928 RVA: 0x003225CC File Offset: 0x003207CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UMIDIDeviceInputController MIDIDeviceController, int Timestamp, int Channel, int Note, int Velocity)
		{
			FOnMIDINoteOff.__FOnMIDINoteOff_DelegateParams* ptr = stackalloc FOnMIDINoteOff.__FOnMIDINoteOff_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnMIDINoteOff.__FOnMIDINoteOff_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMIDINoteOff.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->MIDIDeviceController = ((MIDIDeviceController != null) ? MIDIDeviceController.NativePtr : IntPtr.Zero);
			ptr->Timestamp = Timestamp;
			ptr->Channel = Channel;
			ptr->Note = Note;
			ptr->Velocity = Velocity;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06021EB1 RID: 138929 RVA: 0x00322638 File Offset: 0x00320838
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
			UMIDIDeviceInputController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMIDIDeviceInputController>(((FOnMIDINoteOff.__FOnMIDINoteOff_DelegateParams*)__Parameters)->MIDIDeviceController);
			action(orCreateUObjectByNativePointer, ((FOnMIDINoteOff.__FOnMIDINoteOff_DelegateParams*)__Parameters)->Timestamp, ((FOnMIDINoteOff.__FOnMIDINoteOff_DelegateParams*)__Parameters)->Channel, ((FOnMIDINoteOff.__FOnMIDINoteOff_DelegateParams*)__Parameters)->Note, ((FOnMIDINoteOff.__FOnMIDINoteOff_DelegateParams*)__Parameters)->Velocity);
		}

		// Token: 0x0401218F RID: 74127
		internal static IntPtr _FunctionPtr;

		// Token: 0x04012190 RID: 74128
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MIDIDevice.OnMIDINoteOff__DelegateSignature";

		// Token: 0x04012191 RID: 74129
		private static int RegisterId;

		// Token: 0x02003636 RID: 13878
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnMIDINoteOff_DelegateParams
		{
			// Token: 0x040176ED RID: 95981
			[FieldOffset(0)]
			public IntPtr MIDIDeviceController;

			// Token: 0x040176EE RID: 95982
			[FieldOffset(8)]
			public int Timestamp;

			// Token: 0x040176EF RID: 95983
			[FieldOffset(12)]
			public int Channel;

			// Token: 0x040176F0 RID: 95984
			[FieldOffset(16)]
			public int Note;

			// Token: 0x040176F1 RID: 95985
			[FieldOffset(20)]
			public int Velocity;
		}

		// Token: 0x02003637 RID: 13879
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040176F2 RID: 95986
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
