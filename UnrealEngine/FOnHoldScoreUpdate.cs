using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200050E RID: 1294
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnHoldScoreUpdate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007936 RID: 31030 RVA: 0x000B1C42 File Offset: 0x000AFE42
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnHoldScoreUpdate.StaticFunctionPtr();
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x000B1C4E File Offset: 0x000AFE4E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnHoldScoreUpdate._FunctionPtr == IntPtr.Zero)
			{
				FOnHoldScoreUpdate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnHoldScoreUpdate__DelegateSignature");
			}
			return FOnHoldScoreUpdate._FunctionPtr;
		}

		// Token: 0x06007938 RID: 31032 RVA: 0x000B1C71 File Offset: 0x000AFE71
		public FOnHoldScoreUpdate()
		{
		}

		// Token: 0x06007939 RID: 31033 RVA: 0x000B1C79 File Offset: 0x000AFE79
		[NullableContext(2)]
		public FOnHoldScoreUpdate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600793A RID: 31034 RVA: 0x000B1C83 File Offset: 0x000AFE83
		public FOnHoldScoreUpdate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600793B RID: 31035 RVA: 0x000B1C8E File Offset: 0x000AFE8E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600793C RID: 31036 RVA: 0x000B1CC0 File Offset: 0x000AFEC0
		[NullableContext(1)]
		public void Add(Action<int, int> Callback)
		{
			if (FOnHoldScoreUpdate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnHoldScoreUpdate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnHoldScoreUpdate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnHoldScoreUpdate.OnScriptCallback));
				}
				FOnHoldScoreUpdate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnHoldScoreUpdate.RegisterId);
		}

		// Token: 0x0600793D RID: 31037 RVA: 0x000B1CFA File Offset: 0x000AFEFA
		[NullableContext(1)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600793E RID: 31038 RVA: 0x000B1D04 File Offset: 0x000AFF04
		[SkipLocalsInit]
		public unsafe void Broadcast(int ScoreGained, int CurrentBeat)
		{
			FOnHoldScoreUpdate.__FOnHoldScoreUpdate_DelegateParams* ptr = stackalloc FOnHoldScoreUpdate.__FOnHoldScoreUpdate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnHoldScoreUpdate.__FOnHoldScoreUpdate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnHoldScoreUpdate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ScoreGained = ScoreGained;
			ptr->CurrentBeat = CurrentBeat;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600793F RID: 31039 RVA: 0x000B1D48 File Offset: 0x000AFF48
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnHoldScoreUpdate.__FOnHoldScoreUpdate_DelegateParams*)__Parameters)->ScoreGained, ((FOnHoldScoreUpdate.__FOnHoldScoreUpdate_DelegateParams*)__Parameters)->CurrentBeat);
		}

		// Token: 0x04003387 RID: 13191
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003388 RID: 13192
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnHoldScoreUpdate__DelegateSignature";

		// Token: 0x04003389 RID: 13193
		private static int RegisterId;

		// Token: 0x02000C73 RID: 3187
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnHoldScoreUpdate_DelegateParams
		{
			// Token: 0x04005ECE RID: 24270
			[FieldOffset(0)]
			public int ScoreGained;

			// Token: 0x04005ECF RID: 24271
			[FieldOffset(4)]
			public int CurrentBeat;
		}

		// Token: 0x02000C74 RID: 3188
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005ED0 RID: 24272
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
