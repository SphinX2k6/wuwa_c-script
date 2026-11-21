using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000513 RID: 1299
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnTrackSwitched : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007968 RID: 31080 RVA: 0x000B22CA File Offset: 0x000B04CA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTrackSwitched.StaticFunctionPtr();
		}

		// Token: 0x06007969 RID: 31081 RVA: 0x000B22D6 File Offset: 0x000B04D6
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTrackSwitched._FunctionPtr == IntPtr.Zero)
			{
				FOnTrackSwitched._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnTrackSwitched__DelegateSignature");
			}
			return FOnTrackSwitched._FunctionPtr;
		}

		// Token: 0x0600796A RID: 31082 RVA: 0x000B22F9 File Offset: 0x000B04F9
		public FOnTrackSwitched()
		{
		}

		// Token: 0x0600796B RID: 31083 RVA: 0x000B2301 File Offset: 0x000B0501
		[NullableContext(2)]
		public FOnTrackSwitched(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600796C RID: 31084 RVA: 0x000B230B File Offset: 0x000B050B
		public FOnTrackSwitched(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600796D RID: 31085 RVA: 0x000B2316 File Offset: 0x000B0516
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600796E RID: 31086 RVA: 0x000B2348 File Offset: 0x000B0548
		[NullableContext(1)]
		public void Add(Action<int, int> Callback)
		{
			if (FOnTrackSwitched.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTrackSwitched.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTrackSwitched.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTrackSwitched.OnScriptCallback));
				}
				FOnTrackSwitched.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnTrackSwitched.RegisterId);
		}

		// Token: 0x0600796F RID: 31087 RVA: 0x000B2382 File Offset: 0x000B0582
		[NullableContext(1)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007970 RID: 31088 RVA: 0x000B238C File Offset: 0x000B058C
		[SkipLocalsInit]
		public unsafe void Broadcast(int NewTrackIndex, int OldTrackIndex)
		{
			FOnTrackSwitched.__FOnTrackSwitched_DelegateParams* ptr = stackalloc FOnTrackSwitched.__FOnTrackSwitched_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnTrackSwitched.__FOnTrackSwitched_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTrackSwitched.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NewTrackIndex = NewTrackIndex;
			ptr->OldTrackIndex = OldTrackIndex;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06007971 RID: 31089 RVA: 0x000B23D0 File Offset: 0x000B05D0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnTrackSwitched.__FOnTrackSwitched_DelegateParams*)__Parameters)->NewTrackIndex, ((FOnTrackSwitched.__FOnTrackSwitched_DelegateParams*)__Parameters)->OldTrackIndex);
		}

		// Token: 0x04003396 RID: 13206
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003397 RID: 13207
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnTrackSwitched__DelegateSignature";

		// Token: 0x04003398 RID: 13208
		private static int RegisterId;

		// Token: 0x02000C7C RID: 3196
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnTrackSwitched_DelegateParams
		{
			// Token: 0x04005EDD RID: 24285
			[FieldOffset(0)]
			public int NewTrackIndex;

			// Token: 0x04005EDE RID: 24286
			[FieldOffset(4)]
			public int OldTrackIndex;
		}

		// Token: 0x02000C7D RID: 3197
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005EDF RID: 24287
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
