using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022F0 RID: 8944
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMIDIControlChange : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021E94 RID: 138900 RVA: 0x003221BF File Offset: 0x003203BF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMIDIControlChange.StaticFunctionPtr();
		}

		// Token: 0x06021E95 RID: 138901 RVA: 0x003221CB File Offset: 0x003203CB
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMIDIControlChange._FunctionPtr == IntPtr.Zero)
			{
				FOnMIDIControlChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MIDIDevice.OnMIDIControlChange__DelegateSignature");
			}
			return FOnMIDIControlChange._FunctionPtr;
		}

		// Token: 0x06021E96 RID: 138902 RVA: 0x003221EE File Offset: 0x003203EE
		public FOnMIDIControlChange()
		{
		}

		// Token: 0x06021E97 RID: 138903 RVA: 0x003221F6 File Offset: 0x003203F6
		[NullableContext(2)]
		public FOnMIDIControlChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021E98 RID: 138904 RVA: 0x00322200 File Offset: 0x00320400
		public FOnMIDIControlChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021E99 RID: 138905 RVA: 0x0032220B File Offset: 0x0032040B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UMIDIDeviceInputController, int, int, int, int>) ?? ((Action<UMIDIDeviceInputController, int, int, int, int>)Delegate.CreateDelegate(typeof(Action<UMIDIDeviceInputController, int, int, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021E9A RID: 138906 RVA: 0x0032223D File Offset: 0x0032043D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceInputController, int, int, int, int> Callback)
		{
			if (FOnMIDIControlChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMIDIControlChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMIDIControlChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMIDIControlChange.OnScriptCallback));
				}
				FOnMIDIControlChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMIDIControlChange.RegisterId);
		}

		// Token: 0x06021E9B RID: 138907 RVA: 0x00322277 File Offset: 0x00320477
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMIDIDeviceInputController, int, int, int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021E9C RID: 138908 RVA: 0x00322280 File Offset: 0x00320480
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UMIDIDeviceInputController MIDIDeviceController, int Timestamp, int Channel, int Type, int Value)
		{
			FOnMIDIControlChange.__FOnMIDIControlChange_DelegateParams* ptr = stackalloc FOnMIDIControlChange.__FOnMIDIControlChange_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnMIDIControlChange.__FOnMIDIControlChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMIDIControlChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->MIDIDeviceController = ((MIDIDeviceController != null) ? MIDIDeviceController.NativePtr : IntPtr.Zero);
			ptr->Timestamp = Timestamp;
			ptr->Channel = Channel;
			ptr->Type = Type;
			ptr->Value = Value;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06021E9D RID: 138909 RVA: 0x003222EC File Offset: 0x003204EC
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
			UMIDIDeviceInputController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMIDIDeviceInputController>(((FOnMIDIControlChange.__FOnMIDIControlChange_DelegateParams*)__Parameters)->MIDIDeviceController);
			action(orCreateUObjectByNativePointer, ((FOnMIDIControlChange.__FOnMIDIControlChange_DelegateParams*)__Parameters)->Timestamp, ((FOnMIDIControlChange.__FOnMIDIControlChange_DelegateParams*)__Parameters)->Channel, ((FOnMIDIControlChange.__FOnMIDIControlChange_DelegateParams*)__Parameters)->Type, ((FOnMIDIControlChange.__FOnMIDIControlChange_DelegateParams*)__Parameters)->Value);
		}

		// Token: 0x04012189 RID: 74121
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401218A RID: 74122
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MIDIDevice.OnMIDIControlChange__DelegateSignature";

		// Token: 0x0401218B RID: 74123
		private static int RegisterId;

		// Token: 0x02003632 RID: 13874
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnMIDIControlChange_DelegateParams
		{
			// Token: 0x040176DF RID: 95967
			[FieldOffset(0)]
			public IntPtr MIDIDeviceController;

			// Token: 0x040176E0 RID: 95968
			[FieldOffset(8)]
			public int Timestamp;

			// Token: 0x040176E1 RID: 95969
			[FieldOffset(12)]
			public int Channel;

			// Token: 0x040176E2 RID: 95970
			[FieldOffset(16)]
			public int Type;

			// Token: 0x040176E3 RID: 95971
			[FieldOffset(20)]
			public int Value;
		}

		// Token: 0x02003633 RID: 13875
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040176E4 RID: 95972
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
