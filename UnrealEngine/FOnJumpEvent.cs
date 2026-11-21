using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000510 RID: 1296
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnJumpEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600794A RID: 31050 RVA: 0x000B1EF0 File Offset: 0x000B00F0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnJumpEvent.StaticFunctionPtr();
		}

		// Token: 0x0600794B RID: 31051 RVA: 0x000B1EFC File Offset: 0x000B00FC
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnJumpEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnJumpEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnJumpEvent__DelegateSignature");
			}
			return FOnJumpEvent._FunctionPtr;
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x000B1F1F File Offset: 0x000B011F
		public FOnJumpEvent()
		{
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x000B1F27 File Offset: 0x000B0127
		[NullableContext(2)]
		public FOnJumpEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x000B1F31 File Offset: 0x000B0131
		public FOnJumpEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600794F RID: 31055 RVA: 0x000B1F3C File Offset: 0x000B013C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007950 RID: 31056 RVA: 0x000B1F6E File Offset: 0x000B016E
		[NullableContext(1)]
		public void Add(Action<float> Callback)
		{
			if (FOnJumpEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnJumpEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnJumpEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnJumpEvent.OnScriptCallback));
				}
				FOnJumpEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnJumpEvent.RegisterId);
		}

		// Token: 0x06007951 RID: 31057 RVA: 0x000B1FA8 File Offset: 0x000B01A8
		[NullableContext(1)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007952 RID: 31058 RVA: 0x000B1FB4 File Offset: 0x000B01B4
		[SkipLocalsInit]
		public unsafe void Broadcast(float BeatDurationMs)
		{
			FOnJumpEvent.__FOnJumpEvent_DelegateParams* ptr = stackalloc FOnJumpEvent.__FOnJumpEvent_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnJumpEvent.__FOnJumpEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnJumpEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->BeatDurationMs = BeatDurationMs;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06007953 RID: 31059 RVA: 0x000B1FF0 File Offset: 0x000B01F0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnJumpEvent.__FOnJumpEvent_DelegateParams*)__Parameters)->BeatDurationMs);
		}

		// Token: 0x0400338D RID: 13197
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400338E RID: 13198
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnJumpEvent__DelegateSignature";

		// Token: 0x0400338F RID: 13199
		private static int RegisterId;

		// Token: 0x02000C77 RID: 3191
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FOnJumpEvent_DelegateParams
		{
			// Token: 0x04005ED4 RID: 24276
			[FieldOffset(0)]
			public float BeatDurationMs;
		}

		// Token: 0x02000C78 RID: 3192
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005ED5 RID: 24277
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
