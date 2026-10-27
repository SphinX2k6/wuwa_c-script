using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002705 RID: 9989
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnJumpToKeyFrameEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602509D RID: 151709 RVA: 0x0036D004 File Offset: 0x0036B204
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnJumpToKeyFrameEvent.StaticFunctionPtr();
		}

		// Token: 0x0602509E RID: 151710 RVA: 0x0036D010 File Offset: 0x0036B210
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnJumpToKeyFrameEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnJumpToKeyFrameEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnJumpToKeyFrameEvent__DelegateSignature");
			}
			return FOnJumpToKeyFrameEvent._FunctionPtr;
		}

		// Token: 0x0602509F RID: 151711 RVA: 0x0036D033 File Offset: 0x0036B233
		public FOnJumpToKeyFrameEvent()
		{
		}

		// Token: 0x060250A0 RID: 151712 RVA: 0x0036D03B File Offset: 0x0036B23B
		[NullableContext(2)]
		public FOnJumpToKeyFrameEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060250A1 RID: 151713 RVA: 0x0036D045 File Offset: 0x0036B245
		public FOnJumpToKeyFrameEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060250A2 RID: 151714 RVA: 0x0036D050 File Offset: 0x0036B250
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060250A3 RID: 151715 RVA: 0x0036D082 File Offset: 0x0036B282
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FOnJumpToKeyFrameEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnJumpToKeyFrameEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnJumpToKeyFrameEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnJumpToKeyFrameEvent.OnScriptCallback));
				}
				FOnJumpToKeyFrameEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnJumpToKeyFrameEvent.RegisterId);
		}

		// Token: 0x060250A4 RID: 151716 RVA: 0x0036D0BC File Offset: 0x0036B2BC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060250A5 RID: 151717 RVA: 0x0036D0C8 File Offset: 0x0036B2C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int Frame)
		{
			FOnJumpToKeyFrameEvent.__FOnJumpToKeyFrameEvent_DelegateParams* ptr = stackalloc FOnJumpToKeyFrameEvent.__FOnJumpToKeyFrameEvent_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnJumpToKeyFrameEvent.__FOnJumpToKeyFrameEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnJumpToKeyFrameEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Frame = Frame;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060250A6 RID: 151718 RVA: 0x0036D104 File Offset: 0x0036B304
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnJumpToKeyFrameEvent.__FOnJumpToKeyFrameEvent_DelegateParams*)__Parameters)->Frame);
		}

		// Token: 0x04013F47 RID: 81735
		internal static IntPtr _FunctionPtr;

		// Token: 0x04013F48 RID: 81736
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnJumpToKeyFrameEvent__DelegateSignature";

		// Token: 0x04013F49 RID: 81737
		private static int RegisterId;

		// Token: 0x020036A6 RID: 13990
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnJumpToKeyFrameEvent_DelegateParams
		{
			// Token: 0x040177B9 RID: 96185
			[FieldOffset(0)]
			public int Frame;
		}

		// Token: 0x020036A7 RID: 13991
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040177BA RID: 96186
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
