using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020F4 RID: 8436
	public sealed class FOnSequencePlayEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FC1E RID: 130078 RVA: 0x002F38C1 File Offset: 0x002F1AC1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSequencePlayEvent.StaticFunctionPtr();
		}

		// Token: 0x0601FC1F RID: 130079 RVA: 0x002F38CD File Offset: 0x002F1ACD
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSequencePlayEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnSequencePlayEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.OnSequencePlayEvent__DelegateSignature");
			}
			return FOnSequencePlayEvent._FunctionPtr;
		}

		// Token: 0x0601FC20 RID: 130080 RVA: 0x002F38F0 File Offset: 0x002F1AF0
		public FOnSequencePlayEvent()
		{
		}

		// Token: 0x0601FC21 RID: 130081 RVA: 0x002F38F8 File Offset: 0x002F1AF8
		[NullableContext(2)]
		public FOnSequencePlayEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC22 RID: 130082 RVA: 0x002F3902 File Offset: 0x002F1B02
		public FOnSequencePlayEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC23 RID: 130083 RVA: 0x002F390D File Offset: 0x002F1B0D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, string>) ?? ((Action<string, string>)Delegate.CreateDelegate(typeof(Action<string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FC24 RID: 130084 RVA: 0x002F393F File Offset: 0x002F1B3F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string, string> Callback)
		{
			if (FOnSequencePlayEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSequencePlayEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSequencePlayEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSequencePlayEvent.OnScriptCallback));
				}
				FOnSequencePlayEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnSequencePlayEvent.RegisterId);
		}

		// Token: 0x0601FC25 RID: 130085 RVA: 0x002F397C File Offset: 0x002F1B7C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string sequenceName, string eventName)
		{
			FOnSequencePlayEvent.__FOnSequencePlayEvent_DelegateParams* ptr = stackalloc FOnSequencePlayEvent.__FOnSequencePlayEvent_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnSequencePlayEvent.__FOnSequencePlayEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSequencePlayEvent.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->sequenceName), sequenceName);
			FString.CopyFrom((void*)(&ptr->eventName), eventName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnSequencePlayEvent._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601FC26 RID: 130086 RVA: 0x002F39E0 File Offset: 0x002F1BE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, string> action = target as Action<string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FOnSequencePlayEvent.__FOnSequencePlayEvent_DelegateParams*)__Parameters)->sequenceName));
			string arg2 = FString.ToString((void*)(&((FOnSequencePlayEvent.__FOnSequencePlayEvent_DelegateParams*)__Parameters)->eventName));
			action(arg, arg2);
		}

		// Token: 0x040111E9 RID: 70121
		internal static IntPtr _FunctionPtr;

		// Token: 0x040111EA RID: 70122
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.OnSequencePlayEvent__DelegateSignature";

		// Token: 0x040111EB RID: 70123
		private static int RegisterId;

		// Token: 0x020034D9 RID: 13529
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnSequencePlayEvent_DelegateParams
		{
			// Token: 0x040174EC RID: 95468
			[FieldOffset(0)]
			public FString sequenceName;

			// Token: 0x040174ED RID: 95469
			[FieldOffset(16)]
			public FString eventName;
		}

		// Token: 0x020034DA RID: 13530
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174EE RID: 95470
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
