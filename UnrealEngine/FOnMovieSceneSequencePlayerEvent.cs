using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200245E RID: 9310
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMovieSceneSequencePlayerEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06022E04 RID: 142852 RVA: 0x00339104 File Offset: 0x00337304
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMovieSceneSequencePlayerEvent.StaticFunctionPtr();
		}

		// Token: 0x06022E05 RID: 142853 RVA: 0x00339110 File Offset: 0x00337310
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMovieSceneSequencePlayerEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnMovieSceneSequencePlayerEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MovieScene.OnMovieSceneSequencePlayerEvent__DelegateSignature");
			}
			return FOnMovieSceneSequencePlayerEvent._FunctionPtr;
		}

		// Token: 0x06022E06 RID: 142854 RVA: 0x00339133 File Offset: 0x00337333
		public FOnMovieSceneSequencePlayerEvent()
		{
		}

		// Token: 0x06022E07 RID: 142855 RVA: 0x0033913B File Offset: 0x0033733B
		[NullableContext(2)]
		public FOnMovieSceneSequencePlayerEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022E08 RID: 142856 RVA: 0x00339145 File Offset: 0x00337345
		public FOnMovieSceneSequencePlayerEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022E09 RID: 142857 RVA: 0x00339150 File Offset: 0x00337350
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06022E0A RID: 142858 RVA: 0x00339182 File Offset: 0x00337382
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnMovieSceneSequencePlayerEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMovieSceneSequencePlayerEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMovieSceneSequencePlayerEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMovieSceneSequencePlayerEvent.OnScriptCallback));
				}
				FOnMovieSceneSequencePlayerEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMovieSceneSequencePlayerEvent.RegisterId);
		}

		// Token: 0x06022E0B RID: 142859 RVA: 0x003391BC File Offset: 0x003373BC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06022E0C RID: 142860 RVA: 0x003391C5 File Offset: 0x003373C5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06022E0D RID: 142861 RVA: 0x003391D0 File Offset: 0x003373D0
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

		// Token: 0x040129E9 RID: 76265
		internal static IntPtr _FunctionPtr;

		// Token: 0x040129EA RID: 76266
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.OnMovieSceneSequencePlayerEvent__DelegateSignature";

		// Token: 0x040129EB RID: 76267
		private static int RegisterId;

		// Token: 0x02003663 RID: 13923
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017731 RID: 96049
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
