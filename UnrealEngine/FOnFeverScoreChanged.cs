using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000508 RID: 1288
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnFeverScoreChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060078FA RID: 30970 RVA: 0x000B14E6 File Offset: 0x000AF6E6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnFeverScoreChanged.StaticFunctionPtr();
		}

		// Token: 0x060078FB RID: 30971 RVA: 0x000B14F2 File Offset: 0x000AF6F2
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnFeverScoreChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnFeverScoreChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnFeverScoreChanged__DelegateSignature");
			}
			return FOnFeverScoreChanged._FunctionPtr;
		}

		// Token: 0x060078FC RID: 30972 RVA: 0x000B1515 File Offset: 0x000AF715
		public FOnFeverScoreChanged()
		{
		}

		// Token: 0x060078FD RID: 30973 RVA: 0x000B151D File Offset: 0x000AF71D
		[NullableContext(2)]
		public FOnFeverScoreChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060078FE RID: 30974 RVA: 0x000B1527 File Offset: 0x000AF727
		public FOnFeverScoreChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x000B1532 File Offset: 0x000AF732
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x000B1564 File Offset: 0x000AF764
		[NullableContext(1)]
		public void Add(Action<int, int> Callback)
		{
			if (FOnFeverScoreChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnFeverScoreChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnFeverScoreChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnFeverScoreChanged.OnScriptCallback));
				}
				FOnFeverScoreChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnFeverScoreChanged.RegisterId);
		}

		// Token: 0x06007901 RID: 30977 RVA: 0x000B159E File Offset: 0x000AF79E
		[NullableContext(1)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007902 RID: 30978 RVA: 0x000B15A8 File Offset: 0x000AF7A8
		[SkipLocalsInit]
		public unsafe void Broadcast(int NewFeverScore, int OldFeverScore)
		{
			FOnFeverScoreChanged.__FOnFeverScoreChanged_DelegateParams* ptr = stackalloc FOnFeverScoreChanged.__FOnFeverScoreChanged_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnFeverScoreChanged.__FOnFeverScoreChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnFeverScoreChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NewFeverScore = NewFeverScore;
			ptr->OldFeverScore = OldFeverScore;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06007903 RID: 30979 RVA: 0x000B15EC File Offset: 0x000AF7EC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnFeverScoreChanged.__FOnFeverScoreChanged_DelegateParams*)__Parameters)->NewFeverScore, ((FOnFeverScoreChanged.__FOnFeverScoreChanged_DelegateParams*)__Parameters)->OldFeverScore);
		}

		// Token: 0x04003375 RID: 13173
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003376 RID: 13174
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnFeverScoreChanged__DelegateSignature";

		// Token: 0x04003377 RID: 13175
		private static int RegisterId;

		// Token: 0x02000C69 RID: 3177
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnFeverScoreChanged_DelegateParams
		{
			// Token: 0x04005EC2 RID: 24258
			[FieldOffset(0)]
			public int NewFeverScore;

			// Token: 0x04005EC3 RID: 24259
			[FieldOffset(4)]
			public int OldFeverScore;
		}

		// Token: 0x02000C6A RID: 3178
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005EC4 RID: 24260
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
