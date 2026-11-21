using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000507 RID: 1287
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAutoJudgeCountChange : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060078F0 RID: 30960 RVA: 0x000B139E File Offset: 0x000AF59E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAutoJudgeCountChange.StaticFunctionPtr();
		}

		// Token: 0x060078F1 RID: 30961 RVA: 0x000B13AA File Offset: 0x000AF5AA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAutoJudgeCountChange._FunctionPtr == IntPtr.Zero)
			{
				FOnAutoJudgeCountChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnAutoJudgeCountChange__DelegateSignature");
			}
			return FOnAutoJudgeCountChange._FunctionPtr;
		}

		// Token: 0x060078F2 RID: 30962 RVA: 0x000B13CD File Offset: 0x000AF5CD
		public FOnAutoJudgeCountChange()
		{
		}

		// Token: 0x060078F3 RID: 30963 RVA: 0x000B13D5 File Offset: 0x000AF5D5
		[NullableContext(2)]
		public FOnAutoJudgeCountChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060078F4 RID: 30964 RVA: 0x000B13DF File Offset: 0x000AF5DF
		public FOnAutoJudgeCountChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060078F5 RID: 30965 RVA: 0x000B13EA File Offset: 0x000AF5EA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060078F6 RID: 30966 RVA: 0x000B141C File Offset: 0x000AF61C
		[NullableContext(1)]
		public void Add(Action<int> Callback)
		{
			if (FOnAutoJudgeCountChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAutoJudgeCountChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAutoJudgeCountChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAutoJudgeCountChange.OnScriptCallback));
				}
				FOnAutoJudgeCountChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAutoJudgeCountChange.RegisterId);
		}

		// Token: 0x060078F7 RID: 30967 RVA: 0x000B1456 File Offset: 0x000AF656
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060078F8 RID: 30968 RVA: 0x000B1460 File Offset: 0x000AF660
		[SkipLocalsInit]
		public unsafe void Broadcast(int RemainCount)
		{
			FOnAutoJudgeCountChange.__FOnAutoJudgeCountChange_DelegateParams* ptr = stackalloc FOnAutoJudgeCountChange.__FOnAutoJudgeCountChange_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnAutoJudgeCountChange.__FOnAutoJudgeCountChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAutoJudgeCountChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->RemainCount = RemainCount;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060078F9 RID: 30969 RVA: 0x000B149C File Offset: 0x000AF69C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnAutoJudgeCountChange.__FOnAutoJudgeCountChange_DelegateParams*)__Parameters)->RemainCount);
		}

		// Token: 0x04003372 RID: 13170
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003373 RID: 13171
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnAutoJudgeCountChange__DelegateSignature";

		// Token: 0x04003374 RID: 13172
		private static int RegisterId;

		// Token: 0x02000C67 RID: 3175
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FOnAutoJudgeCountChange_DelegateParams
		{
			// Token: 0x04005EC0 RID: 24256
			[FieldOffset(0)]
			public int RemainCount;
		}

		// Token: 0x02000C68 RID: 3176
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005EC1 RID: 24257
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
