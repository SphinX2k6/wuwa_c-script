using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000512 RID: 1298
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnNoteResult : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600795E RID: 31070 RVA: 0x000B214A File Offset: 0x000B034A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnNoteResult.StaticFunctionPtr();
		}

		// Token: 0x0600795F RID: 31071 RVA: 0x000B2156 File Offset: 0x000B0356
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnNoteResult._FunctionPtr == IntPtr.Zero)
			{
				FOnNoteResult._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnNoteResult__DelegateSignature");
			}
			return FOnNoteResult._FunctionPtr;
		}

		// Token: 0x06007960 RID: 31072 RVA: 0x000B2179 File Offset: 0x000B0379
		public FOnNoteResult()
		{
		}

		// Token: 0x06007961 RID: 31073 RVA: 0x000B2181 File Offset: 0x000B0381
		[NullableContext(2)]
		public FOnNoteResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007962 RID: 31074 RVA: 0x000B218B File Offset: 0x000B038B
		public FOnNoteResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007963 RID: 31075 RVA: 0x000B2196 File Offset: 0x000B0396
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, EKuroRhythmGameNoteType, EKuroRhythmGameRating, FVectorDouble, FQuat>) ?? ((Action<int, EKuroRhythmGameNoteType, EKuroRhythmGameRating, FVectorDouble, FQuat>)Delegate.CreateDelegate(typeof(Action<int, EKuroRhythmGameNoteType, EKuroRhythmGameRating, FVectorDouble, FQuat>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007964 RID: 31076 RVA: 0x000B21C8 File Offset: 0x000B03C8
		[NullableContext(1)]
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

		// Token: 0x06007965 RID: 31077 RVA: 0x000B2202 File Offset: 0x000B0402
		[NullableContext(1)]
		public void Remove(Action<int, EKuroRhythmGameNoteType, EKuroRhythmGameRating, FVectorDouble, FQuat> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007966 RID: 31078 RVA: 0x000B220C File Offset: 0x000B040C
		[SkipLocalsInit]
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

		// Token: 0x06007967 RID: 31079 RVA: 0x000B2268 File Offset: 0x000B0468
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, EKuroRhythmGameNoteType, EKuroRhythmGameRating, FVectorDouble, FQuat> action = target as Action<int, EKuroRhythmGameNoteType, EKuroRhythmGameRating, FVectorDouble, FQuat>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnNoteResult.__FOnNoteResult_DelegateParams*)__Parameters)->NoteIndex, ((FOnNoteResult.__FOnNoteResult_DelegateParams*)__Parameters)->NoteType, ((FOnNoteResult.__FOnNoteResult_DelegateParams*)__Parameters)->Result, ((FOnNoteResult.__FOnNoteResult_DelegateParams*)__Parameters)->WorldPosition, ((FOnNoteResult.__FOnNoteResult_DelegateParams*)__Parameters)->Rotation);
		}

		// Token: 0x04003393 RID: 13203
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003394 RID: 13204
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnNoteResult__DelegateSignature";

		// Token: 0x04003395 RID: 13205
		private static int RegisterId;

		// Token: 0x02000C7A RID: 3194
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		private ref struct __FOnNoteResult_DelegateParams
		{
			// Token: 0x04005ED7 RID: 24279
			[FieldOffset(0)]
			public int NoteIndex;

			// Token: 0x04005ED8 RID: 24280
			[FieldOffset(4)]
			public EKuroRhythmGameNoteType NoteType;

			// Token: 0x04005ED9 RID: 24281
			[FieldOffset(5)]
			public EKuroRhythmGameRating Result;

			// Token: 0x04005EDA RID: 24282
			[FieldOffset(8)]
			public FVectorDouble WorldPosition;

			// Token: 0x04005EDB RID: 24283
			[FieldOffset(32)]
			public FQuat Rotation;
		}

		// Token: 0x02000C7B RID: 3195
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005EDC RID: 24284
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
