using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028A7 RID: 10407
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineAnimationEventDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06026970 RID: 158064 RVA: 0x003AE299 File Offset: 0x003AC499
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineAnimationEventDelegate.StaticFunctionPtr();
		}

		// Token: 0x06026971 RID: 158065 RVA: 0x003AE2A5 File Offset: 0x003AC4A5
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineAnimationEventDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineAnimationEventDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineAnimationEventDelegate__DelegateSignature");
			}
			return FSpineAnimationEventDelegate._FunctionPtr;
		}

		// Token: 0x06026972 RID: 158066 RVA: 0x003AE2C8 File Offset: 0x003AC4C8
		public FSpineAnimationEventDelegate()
		{
		}

		// Token: 0x06026973 RID: 158067 RVA: 0x003AE2D0 File Offset: 0x003AC4D0
		[NullableContext(2)]
		public FSpineAnimationEventDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026974 RID: 158068 RVA: 0x003AE2DA File Offset: 0x003AC4DA
		public FSpineAnimationEventDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026975 RID: 158069 RVA: 0x003AE2E5 File Offset: 0x003AC4E5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UTrackEntry, FSpineEvent>) ?? ((Action<UTrackEntry, FSpineEvent>)Delegate.CreateDelegate(typeof(Action<UTrackEntry, FSpineEvent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06026976 RID: 158070 RVA: 0x003AE317 File Offset: 0x003AC517
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<UTrackEntry, FSpineEvent> Callback)
		{
			if (FSpineAnimationEventDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpineAnimationEventDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpineAnimationEventDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpineAnimationEventDelegate.OnScriptCallback));
				}
				FSpineAnimationEventDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpineAnimationEventDelegate.RegisterId);
		}

		// Token: 0x06026977 RID: 158071 RVA: 0x003AE351 File Offset: 0x003AC551
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<UTrackEntry, FSpineEvent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06026978 RID: 158072 RVA: 0x003AE35C File Offset: 0x003AC55C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UTrackEntry entry, FSpineEvent evt)
		{
			FSpineAnimationEventDelegate.__FSpineAnimationEventDelegate_DelegateParams* ptr = stackalloc FSpineAnimationEventDelegate.__FSpineAnimationEventDelegate_DelegateParams[(UIntPtr)71] + 15L / (long)sizeof(FSpineAnimationEventDelegate.__FSpineAnimationEventDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineAnimationEventDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->entry = ((entry != null) ? entry.NativePtr : IntPtr.Zero);
			if (evt != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpineEvent.StaticStruct(), &ptr->evt, evt.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSpineAnimationEventDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026979 RID: 158073 RVA: 0x003AE3DC File Offset: 0x003AC5DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UTrackEntry, FSpineEvent> action = target as Action<UTrackEntry, FSpineEvent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UTrackEntry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(((FSpineAnimationEventDelegate.__FSpineAnimationEventDelegate_DelegateParams*)__Parameters)->entry);
			FSpineEvent arg = new FSpineEvent(&((FSpineAnimationEventDelegate.__FSpineAnimationEventDelegate_DelegateParams*)__Parameters)->evt, true, true);
			action(orCreateUObjectByNativePointer, arg);
		}

		// Token: 0x0401532A RID: 86826
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401532B RID: 86827
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineAnimationEventDelegate__DelegateSignature";

		// Token: 0x0401532C RID: 86828
		private static int RegisterId;

		// Token: 0x02003B40 RID: 15168
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __FSpineAnimationEventDelegate_DelegateParams
		{
			// Token: 0x04017CE4 RID: 97508
			[FieldOffset(0)]
			public IntPtr entry;

			// Token: 0x04017CE5 RID: 97509
			[FieldOffset(8)]
			public byte evt;
		}

		// Token: 0x02003B41 RID: 15169
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017CE6 RID: 97510
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
