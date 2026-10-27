using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C6B RID: 7275
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnLineHitTrigger : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C358 RID: 115544 RVA: 0x00299662 File Offset: 0x00297862
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnLineHitTrigger.StaticFunctionPtr();
		}

		// Token: 0x0601C359 RID: 115545 RVA: 0x0029966E File Offset: 0x0029786E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnLineHitTrigger._FunctionPtr == IntPtr.Zero)
			{
				FOnLineHitTrigger._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnLineHitTrigger__DelegateSignature");
			}
			return FOnLineHitTrigger._FunctionPtr;
		}

		// Token: 0x0601C35A RID: 115546 RVA: 0x00299691 File Offset: 0x00297891
		public FOnLineHitTrigger()
		{
		}

		// Token: 0x0601C35B RID: 115547 RVA: 0x00299699 File Offset: 0x00297899
		[NullableContext(2)]
		public FOnLineHitTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C35C RID: 115548 RVA: 0x002996A3 File Offset: 0x002978A3
		public FOnLineHitTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C35D RID: 115549 RVA: 0x002996AE File Offset: 0x002978AE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C35E RID: 115550 RVA: 0x002996E0 File Offset: 0x002978E0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnLineHitTrigger.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnLineHitTrigger.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnLineHitTrigger.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnLineHitTrigger.OnScriptCallback));
				}
				FOnLineHitTrigger.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnLineHitTrigger.RegisterId);
		}

		// Token: 0x0601C35F RID: 115551 RVA: 0x0029971A File Offset: 0x0029791A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C360 RID: 115552 RVA: 0x00299723 File Offset: 0x00297923
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601C361 RID: 115553 RVA: 0x00299730 File Offset: 0x00297930
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x0400F2C5 RID: 62149
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F2C6 RID: 62150
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnLineHitTrigger__DelegateSignature";

		// Token: 0x0400F2C7 RID: 62151
		private static int RegisterId;

		// Token: 0x02003204 RID: 12804
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017062 RID: 94306
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
