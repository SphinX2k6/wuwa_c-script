using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000506 RID: 1286
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAllNotesFinished : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060078E6 RID: 30950 RVA: 0x000B1291 File Offset: 0x000AF491
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAllNotesFinished.StaticFunctionPtr();
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x000B129D File Offset: 0x000AF49D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAllNotesFinished._FunctionPtr == IntPtr.Zero)
			{
				FOnAllNotesFinished._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnAllNotesFinished__DelegateSignature");
			}
			return FOnAllNotesFinished._FunctionPtr;
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x000B12C0 File Offset: 0x000AF4C0
		public FOnAllNotesFinished()
		{
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x000B12C8 File Offset: 0x000AF4C8
		[NullableContext(2)]
		public FOnAllNotesFinished(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060078EA RID: 30954 RVA: 0x000B12D2 File Offset: 0x000AF4D2
		public FOnAllNotesFinished(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060078EB RID: 30955 RVA: 0x000B12DD File Offset: 0x000AF4DD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060078EC RID: 30956 RVA: 0x000B130F File Offset: 0x000AF50F
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FOnAllNotesFinished.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAllNotesFinished.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAllNotesFinished.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAllNotesFinished.OnScriptCallback));
				}
				FOnAllNotesFinished.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAllNotesFinished.RegisterId);
		}

		// Token: 0x060078ED RID: 30957 RVA: 0x000B1349 File Offset: 0x000AF549
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x000B1352 File Offset: 0x000AF552
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060078EF RID: 30959 RVA: 0x000B135C File Offset: 0x000AF55C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x0400336F RID: 13167
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003370 RID: 13168
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnAllNotesFinished__DelegateSignature";

		// Token: 0x04003371 RID: 13169
		private static int RegisterId;

		// Token: 0x02000C66 RID: 3174
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005EBF RID: 24255
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
