using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000456 RID: 1110
	public sealed class FLogDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006B1D RID: 27421 RVA: 0x0009BF2A File Offset: 0x0009A12A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLogDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006B1E RID: 27422 RVA: 0x0009BF36 File Offset: 0x0009A136
		private static IntPtr StaticFunctionPtr()
		{
			if (FLogDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLogDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroLogAnalyzer.LogDelegate__DelegateSignature");
			}
			return FLogDelegate._FunctionPtr;
		}

		// Token: 0x06006B1F RID: 27423 RVA: 0x0009BF59 File Offset: 0x0009A159
		public FLogDelegate()
		{
		}

		// Token: 0x06006B20 RID: 27424 RVA: 0x0009BF61 File Offset: 0x0009A161
		[NullableContext(2)]
		public FLogDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006B21 RID: 27425 RVA: 0x0009BF6B File Offset: 0x0009A16B
		public FLogDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006B22 RID: 27426 RVA: 0x0009BF76 File Offset: 0x0009A176
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FName, int, string, string>) ?? ((Action<FName, int, string, string>)Delegate.CreateDelegate(typeof(Action<FName, int, string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006B23 RID: 27427 RVA: 0x0009BFA8 File Offset: 0x0009A1A8
		[NullableContext(1)]
		public void Bind(Action<FName, int, string, string> Callback)
		{
			if (FLogDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLogDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLogDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLogDelegate.OnScriptCallback));
				}
				FLogDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLogDelegate.RegisterId);
		}

		// Token: 0x06006B24 RID: 27428 RVA: 0x0009BFE4 File Offset: 0x0009A1E4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(in FName Category, int Verbosity, string Format, string Message)
		{
			FLogDelegate.__FLogDelegate_DelegateParams* ptr = stackalloc FLogDelegate.__FLogDelegate_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FLogDelegate.__FLogDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLogDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Category = Category;
			ptr->Verbosity = Verbosity;
			FString.CopyFrom((void*)(&ptr->Format), Format);
			FString.CopyFrom((void*)(&ptr->Message), Message);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FLogDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006B25 RID: 27429 RVA: 0x0009C05C File Offset: 0x0009A25C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName, int, string, string> action = target as Action<FName, int, string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FLogDelegate.__FLogDelegate_DelegateParams*)__Parameters)->Format));
			string arg2 = FString.ToString((void*)(&((FLogDelegate.__FLogDelegate_DelegateParams*)__Parameters)->Message));
			action(((FLogDelegate.__FLogDelegate_DelegateParams*)__Parameters)->Category, ((FLogDelegate.__FLogDelegate_DelegateParams*)__Parameters)->Verbosity, arg, arg2);
		}

		// Token: 0x04002D6C RID: 11628
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002D6D RID: 11629
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroLogAnalyzer.LogDelegate__DelegateSignature";

		// Token: 0x04002D6E RID: 11630
		private static int RegisterId;

		// Token: 0x02000B6C RID: 2924
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		private ref struct __FLogDelegate_DelegateParams
		{
			// Token: 0x04005C8A RID: 23690
			[FieldOffset(0)]
			public FName Category;

			// Token: 0x04005C8B RID: 23691
			[FieldOffset(12)]
			public int Verbosity;

			// Token: 0x04005C8C RID: 23692
			[FieldOffset(16)]
			public FString Format;

			// Token: 0x04005C8D RID: 23693
			[FieldOffset(32)]
			public FString Message;
		}

		// Token: 0x02000B6D RID: 2925
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005C8E RID: 23694
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
