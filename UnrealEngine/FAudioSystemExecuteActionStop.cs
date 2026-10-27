using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200188D RID: 6285
	public sealed class FAudioSystemExecuteActionStop : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017286 RID: 94854 RVA: 0x0021C00E File Offset: 0x0021A20E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAudioSystemExecuteActionStop.StaticFunctionPtr();
		}

		// Token: 0x06017287 RID: 94855 RVA: 0x0021C01A File Offset: 0x0021A21A
		private static IntPtr StaticFunctionPtr()
		{
			if (FAudioSystemExecuteActionStop._FunctionPtr == IntPtr.Zero)
			{
				FAudioSystemExecuteActionStop._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.AudioSystemExecuteActionStop__DelegateSignature");
			}
			return FAudioSystemExecuteActionStop._FunctionPtr;
		}

		// Token: 0x06017288 RID: 94856 RVA: 0x0021C03D File Offset: 0x0021A23D
		public FAudioSystemExecuteActionStop()
		{
		}

		// Token: 0x06017289 RID: 94857 RVA: 0x0021C045 File Offset: 0x0021A245
		[NullableContext(2)]
		public FAudioSystemExecuteActionStop(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601728A RID: 94858 RVA: 0x0021C04F File Offset: 0x0021A24F
		public FAudioSystemExecuteActionStop(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601728B RID: 94859 RVA: 0x0021C05A File Offset: 0x0021A25A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, float>) ?? ((Action<int, float>)Delegate.CreateDelegate(typeof(Action<int, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601728C RID: 94860 RVA: 0x0021C08C File Offset: 0x0021A28C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, float> Callback)
		{
			if (FAudioSystemExecuteActionStop.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAudioSystemExecuteActionStop.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAudioSystemExecuteActionStop.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAudioSystemExecuteActionStop.OnScriptCallback));
				}
				FAudioSystemExecuteActionStop.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FAudioSystemExecuteActionStop.RegisterId);
		}

		// Token: 0x0601728D RID: 94861 RVA: 0x0021C0C8 File Offset: 0x0021A2C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int EventHandle, float FadeOutTime)
		{
			FAudioSystemExecuteActionStop.__FAudioSystemExecuteActionStop_DelegateParams* ptr = stackalloc FAudioSystemExecuteActionStop.__FAudioSystemExecuteActionStop_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FAudioSystemExecuteActionStop.__FAudioSystemExecuteActionStop_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAudioSystemExecuteActionStop.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EventHandle = EventHandle;
			ptr->FadeOutTime = FadeOutTime;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601728E RID: 94862 RVA: 0x0021C10C File Offset: 0x0021A30C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, float> action = target as Action<int, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FAudioSystemExecuteActionStop.__FAudioSystemExecuteActionStop_DelegateParams*)__Parameters)->EventHandle, ((FAudioSystemExecuteActionStop.__FAudioSystemExecuteActionStop_DelegateParams*)__Parameters)->FadeOutTime);
		}

		// Token: 0x0400C8EF RID: 51439
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C8F0 RID: 51440
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.AudioSystemExecuteActionStop__DelegateSignature";

		// Token: 0x0400C8F1 RID: 51441
		private static int RegisterId;

		// Token: 0x02002F8A RID: 12170
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FAudioSystemExecuteActionStop_DelegateParams
		{
			// Token: 0x04016B4D RID: 93005
			[FieldOffset(0)]
			public int EventHandle;

			// Token: 0x04016B4E RID: 93006
			[FieldOffset(4)]
			public float FadeOutTime;
		}

		// Token: 0x02002F8B RID: 12171
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B4F RID: 93007
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
