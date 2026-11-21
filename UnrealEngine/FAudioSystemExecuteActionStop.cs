using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B1 RID: 945
	public sealed class FAudioSystemExecuteActionStop : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005D31 RID: 23857 RVA: 0x000834AE File Offset: 0x000816AE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAudioSystemExecuteActionStop.StaticFunctionPtr();
		}

		// Token: 0x06005D32 RID: 23858 RVA: 0x000834BA File Offset: 0x000816BA
		private static IntPtr StaticFunctionPtr()
		{
			if (FAudioSystemExecuteActionStop._FunctionPtr == IntPtr.Zero)
			{
				FAudioSystemExecuteActionStop._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.AudioSystemExecuteActionStop__DelegateSignature");
			}
			return FAudioSystemExecuteActionStop._FunctionPtr;
		}

		// Token: 0x06005D33 RID: 23859 RVA: 0x000834DD File Offset: 0x000816DD
		public FAudioSystemExecuteActionStop()
		{
		}

		// Token: 0x06005D34 RID: 23860 RVA: 0x000834E5 File Offset: 0x000816E5
		[NullableContext(2)]
		public FAudioSystemExecuteActionStop(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D35 RID: 23861 RVA: 0x000834EF File Offset: 0x000816EF
		public FAudioSystemExecuteActionStop(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D36 RID: 23862 RVA: 0x000834FA File Offset: 0x000816FA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, float>) ?? ((Action<int, float>)Delegate.CreateDelegate(typeof(Action<int, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005D37 RID: 23863 RVA: 0x0008352C File Offset: 0x0008172C
		[NullableContext(1)]
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

		// Token: 0x06005D38 RID: 23864 RVA: 0x00083568 File Offset: 0x00081768
		[SkipLocalsInit]
		public unsafe void Execute(int EventHandle, float FadeOutTime)
		{
			FAudioSystemExecuteActionStop.__FAudioSystemExecuteActionStop_DelegateParams* ptr = stackalloc FAudioSystemExecuteActionStop.__FAudioSystemExecuteActionStop_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FAudioSystemExecuteActionStop.__FAudioSystemExecuteActionStop_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAudioSystemExecuteActionStop.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EventHandle = EventHandle;
			ptr->FadeOutTime = FadeOutTime;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06005D39 RID: 23865 RVA: 0x000835AC File Offset: 0x000817AC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, float> action = target as Action<int, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FAudioSystemExecuteActionStop.__FAudioSystemExecuteActionStop_DelegateParams*)__Parameters)->EventHandle, ((FAudioSystemExecuteActionStop.__FAudioSystemExecuteActionStop_DelegateParams*)__Parameters)->FadeOutTime);
		}

		// Token: 0x040026D8 RID: 9944
		internal static IntPtr _FunctionPtr;

		// Token: 0x040026D9 RID: 9945
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.AudioSystemExecuteActionStop__DelegateSignature";

		// Token: 0x040026DA RID: 9946
		private static int RegisterId;

		// Token: 0x02000AAD RID: 2733
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FAudioSystemExecuteActionStop_DelegateParams
		{
			// Token: 0x04005B0A RID: 23306
			[FieldOffset(0)]
			public int EventHandle;

			// Token: 0x04005B0B RID: 23307
			[FieldOffset(4)]
			public float FadeOutTime;
		}

		// Token: 0x02000AAE RID: 2734
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B0C RID: 23308
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
