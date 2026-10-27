using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EE7 RID: 7911
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnIntEventTrigger : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E126 RID: 123174 RVA: 0x002CA40E File Offset: 0x002C860E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnIntEventTrigger.StaticFunctionPtr();
		}

		// Token: 0x0601E127 RID: 123175 RVA: 0x002CA41A File Offset: 0x002C861A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnIntEventTrigger._FunctionPtr == IntPtr.Zero)
			{
				FOnIntEventTrigger._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnIntEventTrigger__DelegateSignature");
			}
			return FOnIntEventTrigger._FunctionPtr;
		}

		// Token: 0x0601E128 RID: 123176 RVA: 0x002CA43D File Offset: 0x002C863D
		public FOnIntEventTrigger()
		{
		}

		// Token: 0x0601E129 RID: 123177 RVA: 0x002CA445 File Offset: 0x002C8645
		[NullableContext(2)]
		public FOnIntEventTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E12A RID: 123178 RVA: 0x002CA44F File Offset: 0x002C864F
		public FOnIntEventTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E12B RID: 123179 RVA: 0x002CA45A File Offset: 0x002C865A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E12C RID: 123180 RVA: 0x002CA48C File Offset: 0x002C868C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FOnIntEventTrigger.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnIntEventTrigger.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnIntEventTrigger.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnIntEventTrigger.OnScriptCallback));
				}
				FOnIntEventTrigger.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnIntEventTrigger.RegisterId);
		}

		// Token: 0x0601E12D RID: 123181 RVA: 0x002CA4C6 File Offset: 0x002C86C6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601E12E RID: 123182 RVA: 0x002CA4D0 File Offset: 0x002C86D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int Number)
		{
			FOnIntEventTrigger.__FOnIntEventTrigger_DelegateParams* ptr = stackalloc FOnIntEventTrigger.__FOnIntEventTrigger_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnIntEventTrigger.__FOnIntEventTrigger_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnIntEventTrigger.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Number = Number;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601E12F RID: 123183 RVA: 0x002CA50C File Offset: 0x002C870C
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
			action(((FOnIntEventTrigger.__FOnIntEventTrigger_DelegateParams*)__Parameters)->Number);
		}

		// Token: 0x0401040F RID: 66575
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010410 RID: 66576
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnIntEventTrigger__DelegateSignature";

		// Token: 0x04010411 RID: 66577
		private static int RegisterId;

		// Token: 0x020033B6 RID: 13238
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnIntEventTrigger_DelegateParams
		{
			// Token: 0x0401736A RID: 95082
			[FieldOffset(0)]
			public int Number;
		}

		// Token: 0x020033B7 RID: 13239
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401736B RID: 95083
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
