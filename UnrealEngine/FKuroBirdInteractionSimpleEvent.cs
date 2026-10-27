using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001AB1 RID: 6833
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroBirdInteractionSimpleEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060195D7 RID: 103895 RVA: 0x00257A29 File Offset: 0x00255C29
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroBirdInteractionSimpleEvent.StaticFunctionPtr();
		}

		// Token: 0x060195D8 RID: 103896 RVA: 0x00257A35 File Offset: 0x00255C35
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroBirdInteractionSimpleEvent._FunctionPtr == IntPtr.Zero)
			{
				FKuroBirdInteractionSimpleEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBirdInteractionSimpleEvent__DelegateSignature");
			}
			return FKuroBirdInteractionSimpleEvent._FunctionPtr;
		}

		// Token: 0x060195D9 RID: 103897 RVA: 0x00257A58 File Offset: 0x00255C58
		public FKuroBirdInteractionSimpleEvent()
		{
		}

		// Token: 0x060195DA RID: 103898 RVA: 0x00257A60 File Offset: 0x00255C60
		[NullableContext(2)]
		public FKuroBirdInteractionSimpleEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060195DB RID: 103899 RVA: 0x00257A6A File Offset: 0x00255C6A
		public FKuroBirdInteractionSimpleEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060195DC RID: 103900 RVA: 0x00257A75 File Offset: 0x00255C75
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060195DD RID: 103901 RVA: 0x00257AA7 File Offset: 0x00255CA7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FKuroBirdInteractionSimpleEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroBirdInteractionSimpleEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroBirdInteractionSimpleEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroBirdInteractionSimpleEvent.OnScriptCallback));
				}
				FKuroBirdInteractionSimpleEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroBirdInteractionSimpleEvent.RegisterId);
		}

		// Token: 0x060195DE RID: 103902 RVA: 0x00257AE1 File Offset: 0x00255CE1
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060195DF RID: 103903 RVA: 0x00257AEA File Offset: 0x00255CEA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060195E0 RID: 103904 RVA: 0x00257AF4 File Offset: 0x00255CF4
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

		// Token: 0x0400DD2F RID: 56623
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400DD30 RID: 56624
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBirdInteractionSimpleEvent__DelegateSignature";

		// Token: 0x0400DD31 RID: 56625
		private static int RegisterId;

		// Token: 0x02003132 RID: 12594
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016F42 RID: 94018
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
