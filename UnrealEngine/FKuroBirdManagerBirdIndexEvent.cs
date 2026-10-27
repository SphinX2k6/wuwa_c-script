using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AB3 RID: 6835
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroBirdManagerBirdIndexEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060195E6 RID: 103910 RVA: 0x00257BC9 File Offset: 0x00255DC9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroBirdManagerBirdIndexEvent.StaticFunctionPtr();
		}

		// Token: 0x060195E7 RID: 103911 RVA: 0x00257BD5 File Offset: 0x00255DD5
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroBirdManagerBirdIndexEvent._FunctionPtr == IntPtr.Zero)
			{
				FKuroBirdManagerBirdIndexEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBirdManagerBirdIndexEvent__DelegateSignature");
			}
			return FKuroBirdManagerBirdIndexEvent._FunctionPtr;
		}

		// Token: 0x060195E8 RID: 103912 RVA: 0x00257BF8 File Offset: 0x00255DF8
		public FKuroBirdManagerBirdIndexEvent()
		{
		}

		// Token: 0x060195E9 RID: 103913 RVA: 0x00257C00 File Offset: 0x00255E00
		[NullableContext(2)]
		public FKuroBirdManagerBirdIndexEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060195EA RID: 103914 RVA: 0x00257C0A File Offset: 0x00255E0A
		public FKuroBirdManagerBirdIndexEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060195EB RID: 103915 RVA: 0x00257C15 File Offset: 0x00255E15
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060195EC RID: 103916 RVA: 0x00257C47 File Offset: 0x00255E47
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FKuroBirdManagerBirdIndexEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroBirdManagerBirdIndexEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroBirdManagerBirdIndexEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroBirdManagerBirdIndexEvent.OnScriptCallback));
				}
				FKuroBirdManagerBirdIndexEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroBirdManagerBirdIndexEvent.RegisterId);
		}

		// Token: 0x060195ED RID: 103917 RVA: 0x00257C81 File Offset: 0x00255E81
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060195EE RID: 103918 RVA: 0x00257C8C File Offset: 0x00255E8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int BirdIndex)
		{
			FKuroBirdManagerBirdIndexEvent.__FKuroBirdManagerBirdIndexEvent_DelegateParams* ptr = stackalloc FKuroBirdManagerBirdIndexEvent.__FKuroBirdManagerBirdIndexEvent_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroBirdManagerBirdIndexEvent.__FKuroBirdManagerBirdIndexEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroBirdManagerBirdIndexEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->BirdIndex = BirdIndex;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060195EF RID: 103919 RVA: 0x00257CC8 File Offset: 0x00255EC8
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
			action(((FKuroBirdManagerBirdIndexEvent.__FKuroBirdManagerBirdIndexEvent_DelegateParams*)__Parameters)->BirdIndex);
		}

		// Token: 0x0400DD34 RID: 56628
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400DD35 RID: 56629
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBirdManagerBirdIndexEvent__DelegateSignature";

		// Token: 0x0400DD36 RID: 56630
		private static int RegisterId;

		// Token: 0x02003133 RID: 12595
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FKuroBirdManagerBirdIndexEvent_DelegateParams
		{
			// Token: 0x04016F43 RID: 94019
			[FieldOffset(0)]
			public int BirdIndex;
		}

		// Token: 0x02003134 RID: 12596
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016F44 RID: 94020
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
