using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C6C RID: 7276
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnNoteResult : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C362 RID: 115554 RVA: 0x00299772 File Offset: 0x00297972
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnNoteResult.StaticFunctionPtr();
		}

		// Token: 0x0601C363 RID: 115555 RVA: 0x0029977E File Offset: 0x0029797E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnNoteResult._FunctionPtr == IntPtr.Zero)
			{
				FOnNoteResult._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnNoteResult__DelegateSignature");
			}
			return FOnNoteResult._FunctionPtr;
		}

		// Token: 0x0601C364 RID: 115556 RVA: 0x002997A1 File Offset: 0x002979A1
		public FOnNoteResult()
		{
		}

		// Token: 0x0601C365 RID: 115557 RVA: 0x002997A9 File Offset: 0x002979A9
		[NullableContext(2)]
		public FOnNoteResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C366 RID: 115558 RVA: 0x002997B3 File Offset: 0x002979B3
		public FOnNoteResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C367 RID: 115559 RVA: 0x002997BE File Offset: 0x002979BE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, EKuroRhythmGameNoteType, EKuroRhythmGameRating, FVectorDouble, FQuat>) ?? ((Action<int, EKuroRhythmGameNoteType, EKuroRhythmGameRating, FVectorDouble, FQuat>)Delegate.CreateDelegate(typeof(Action<int, EKuroRhythmGameNoteType, EKuroRhythmGameRating, FVectorDouble, FQuat>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C368 RID: 115560 RVA: 0x002997F0 File Offset: 0x002979F0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, EKuroRhythmGameNoteType, EKuroRhythmGameRating, FVectorDouble, FQuat> Callback)
		{
			if (FOnNoteResult.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnNoteResult.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnNoteResult.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnNoteResult.OnScriptCallback));
				}
				FOnNoteResult.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnNoteResult.RegisterId);
		}

		// Token: 0x0601C369 RID: 115561 RVA: 0x0029982A File Offset: 0x00297A2A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, EKuroRhythmGameNoteType, EKuroRhythmGameRating, FVectorDouble, FQuat> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C36A RID: 115562 RVA: 0x00299834 File Offset: 0x00297A34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int NoteIndex, EKuroRhythmGameNoteType NoteType, EKuroRhythmGameRating Result, FVectorDouble WorldPosition, FQuat Rotation)
		{
			FOnNoteResult.__FOnNoteResult_DelegateParams* ptr = stackalloc FOnNoteResult.__FOnNoteResult_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FOnNoteResult.__FOnNoteResult_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnNoteResult.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NoteIndex = NoteIndex;
			ptr->NoteType = NoteType;
			ptr->Result = Result;
			ptr->WorldPosition = WorldPosition;
			ptr->Rotation = Rotation;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C36B RID: 115563 RVA: 0x00299890 File Offset: 0x00297A90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, EKuroRhythmGameNoteType, EKuroRhythmGameRating, FVectorDouble, FQuat> action = target as Action<int, EKuroRhythmGameNoteType, EKuroRhythmGameRating, FVectorDouble, FQuat>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnNoteResult.__FOnNoteResult_DelegateParams*)__Parameters)->NoteIndex, ((FOnNoteResult.__FOnNoteResult_DelegateParams*)__Parameters)->NoteType, ((FOnNoteResult.__FOnNoteResult_DelegateParams*)__Parameters)->Result, ((FOnNoteResult.__FOnNoteResult_DelegateParams*)__Parameters)->WorldPosition, ((FOnNoteResult.__FOnNoteResult_DelegateParams*)__Parameters)->Rotation);
		}

		// Token: 0x0400F2C8 RID: 62152
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F2C9 RID: 62153
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnNoteResult__DelegateSignature";

		// Token: 0x0400F2CA RID: 62154
		private static int RegisterId;

		// Token: 0x02003205 RID: 12805
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __FOnNoteResult_DelegateParams
		{
			// Token: 0x04017063 RID: 94307
			[FieldOffset(0)]
			public int NoteIndex;

			// Token: 0x04017064 RID: 94308
			[FieldOffset(4)]
			public EKuroRhythmGameNoteType NoteType;

			// Token: 0x04017065 RID: 94309
			[FieldOffset(5)]
			public EKuroRhythmGameRating Result;

			// Token: 0x04017066 RID: 94310
			[FieldOffset(8)]
			public FVectorDouble WorldPosition;

			// Token: 0x04017067 RID: 94311
			[FieldOffset(32)]
			public FQuat Rotation;
		}

		// Token: 0x02003206 RID: 12806
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017068 RID: 94312
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
