using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000795 RID: 1941
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMovieSceneSequencePlayerEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A798 RID: 42904 RVA: 0x000F75D1 File Offset: 0x000F57D1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMovieSceneSequencePlayerEvent.StaticFunctionPtr();
		}

		// Token: 0x0600A799 RID: 42905 RVA: 0x000F75DD File Offset: 0x000F57DD
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMovieSceneSequencePlayerEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnMovieSceneSequencePlayerEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MovieScene.OnMovieSceneSequencePlayerEvent__DelegateSignature");
			}
			return FOnMovieSceneSequencePlayerEvent._FunctionPtr;
		}

		// Token: 0x0600A79A RID: 42906 RVA: 0x000F7600 File Offset: 0x000F5800
		public FOnMovieSceneSequencePlayerEvent()
		{
		}

		// Token: 0x0600A79B RID: 42907 RVA: 0x000F7608 File Offset: 0x000F5808
		[NullableContext(2)]
		public FOnMovieSceneSequencePlayerEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A79C RID: 42908 RVA: 0x000F7612 File Offset: 0x000F5812
		public FOnMovieSceneSequencePlayerEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A79D RID: 42909 RVA: 0x000F761D File Offset: 0x000F581D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A79E RID: 42910 RVA: 0x000F764F File Offset: 0x000F584F
		[NullableContext(1)]
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

		// Token: 0x0600A79F RID: 42911 RVA: 0x000F7689 File Offset: 0x000F5889
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x000F7692 File Offset: 0x000F5892
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600A7A1 RID: 42913 RVA: 0x000F769C File Offset: 0x000F589C
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

		// Token: 0x040047CF RID: 18383
		internal static IntPtr _FunctionPtr;

		// Token: 0x040047D0 RID: 18384
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.OnMovieSceneSequencePlayerEvent__DelegateSignature";

		// Token: 0x040047D1 RID: 18385
		private static int RegisterId;

		// Token: 0x02000F5B RID: 3931
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006331 RID: 25393
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
