using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022F5 RID: 8949
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMIDIProgramChange : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021EC6 RID: 138950 RVA: 0x003229C3 File Offset: 0x00320BC3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMIDIProgramChange.StaticFunctionPtr();
		}

		// Token: 0x06021EC7 RID: 138951 RVA: 0x003229CF File Offset: 0x00320BCF
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMIDIProgramChange._FunctionPtr == IntPtr.Zero)
			{
				FOnMIDIProgramChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MIDIDevice.OnMIDIProgramChange__DelegateSignature");
			}
			return FOnMIDIProgramChange._FunctionPtr;
		}

		// Token: 0x06021EC8 RID: 138952 RVA: 0x003229F2 File Offset: 0x00320BF2
		public FOnMIDIProgramChange()
		{
		}

		// Token: 0x06021EC9 RID: 138953 RVA: 0x003229FA File Offset: 0x00320BFA
		[NullableContext(2)]
		public FOnMIDIProgramChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021ECA RID: 138954 RVA: 0x00322A04 File Offset: 0x00320C04
		public FOnMIDIProgramChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021ECB RID: 138955 RVA: 0x00322A0F File Offset: 0x00320C0F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UMIDIDeviceInputController, int, int, int, int>) ?? ((Action<UMIDIDeviceInputController, int, int, int, int>)Delegate.CreateDelegate(typeof(Action<UMIDIDeviceInputController, int, int, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021ECC RID: 138956 RVA: 0x00322A41 File Offset: 0x00320C41
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceInputController, int, int, int, int> Callback)
		{
			if (FOnMIDIProgramChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMIDIProgramChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMIDIProgramChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMIDIProgramChange.OnScriptCallback));
				}
				FOnMIDIProgramChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMIDIProgramChange.RegisterId);
		}

		// Token: 0x06021ECD RID: 138957 RVA: 0x00322A7B File Offset: 0x00320C7B
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceInputController, int, int, int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021ECE RID: 138958 RVA: 0x00322A84 File Offset: 0x00320C84
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UMIDIDeviceInputController MIDIDeviceController, int Timestamp, int Channel, int ControlID, int Velocity)
		{
			FOnMIDIProgramChange.__FOnMIDIProgramChange_DelegateParams* ptr = stackalloc FOnMIDIProgramChange.__FOnMIDIProgramChange_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnMIDIProgramChange.__FOnMIDIProgramChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMIDIProgramChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->MIDIDeviceController = ((MIDIDeviceController != null) ? MIDIDeviceController.NativePtr : IntPtr.Zero);
			ptr->Timestamp = Timestamp;
			ptr->Channel = Channel;
			ptr->ControlID = ControlID;
			ptr->Velocity = Velocity;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06021ECF RID: 138959 RVA: 0x00322AF0 File Offset: 0x00320CF0
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
			UMIDIDeviceInputController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMIDIDeviceInputController>(((FOnMIDIProgramChange.__FOnMIDIProgramChange_DelegateParams*)__Parameters)->MIDIDeviceController);
			action(orCreateUObjectByNativePointer, ((FOnMIDIProgramChange.__FOnMIDIProgramChange_DelegateParams*)__Parameters)->Timestamp, ((FOnMIDIProgramChange.__FOnMIDIProgramChange_DelegateParams*)__Parameters)->Channel, ((FOnMIDIProgramChange.__FOnMIDIProgramChange_DelegateParams*)__Parameters)->ControlID, ((FOnMIDIProgramChange.__FOnMIDIProgramChange_DelegateParams*)__Parameters)->Velocity);
		}

		// Token: 0x04012198 RID: 74136
		internal static IntPtr _FunctionPtr;

		// Token: 0x04012199 RID: 74137
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MIDIDevice.OnMIDIProgramChange__DelegateSignature";

		// Token: 0x0401219A RID: 74138
		private static int RegisterId;

		// Token: 0x0200363C RID: 13884
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnMIDIProgramChange_DelegateParams
		{
			// Token: 0x040176FE RID: 95998
			[FieldOffset(0)]
			public IntPtr MIDIDeviceController;

			// Token: 0x040176FF RID: 95999
			[FieldOffset(8)]
			public int Timestamp;

			// Token: 0x04017700 RID: 96000
			[FieldOffset(12)]
			public int Channel;

			// Token: 0x04017701 RID: 96001
			[FieldOffset(16)]
			public int ControlID;

			// Token: 0x04017702 RID: 96002
			[FieldOffset(20)]
			public int Velocity;
		}

		// Token: 0x0200363D RID: 13885
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017703 RID: 96003
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
