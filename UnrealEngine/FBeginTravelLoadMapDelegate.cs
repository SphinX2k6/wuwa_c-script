using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B6 RID: 1462
	public sealed class FBeginTravelLoadMapDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600833C RID: 33596 RVA: 0x000C22D2 File Offset: 0x000C04D2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FBeginTravelLoadMapDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600833D RID: 33597 RVA: 0x000C22DE File Offset: 0x000C04DE
		private static IntPtr StaticFunctionPtr()
		{
			if (FBeginTravelLoadMapDelegate._FunctionPtr == IntPtr.Zero)
			{
				FBeginTravelLoadMapDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.BeginTravelLoadMapDelegate__DelegateSignature");
			}
			return FBeginTravelLoadMapDelegate._FunctionPtr;
		}

		// Token: 0x0600833E RID: 33598 RVA: 0x000C2301 File Offset: 0x000C0501
		public FBeginTravelLoadMapDelegate()
		{
		}

		// Token: 0x0600833F RID: 33599 RVA: 0x000C2309 File Offset: 0x000C0509
		[NullableContext(2)]
		public FBeginTravelLoadMapDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008340 RID: 33600 RVA: 0x000C2313 File Offset: 0x000C0513
		public FBeginTravelLoadMapDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008341 RID: 33601 RVA: 0x000C231E File Offset: 0x000C051E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008342 RID: 33602 RVA: 0x000C2350 File Offset: 0x000C0550
		[NullableContext(1)]
		public void Bind(Action<string> Callback)
		{
			if (FBeginTravelLoadMapDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FBeginTravelLoadMapDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FBeginTravelLoadMapDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FBeginTravelLoadMapDelegate.OnScriptCallback));
				}
				FBeginTravelLoadMapDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FBeginTravelLoadMapDelegate.RegisterId);
		}

		// Token: 0x06008343 RID: 33603 RVA: 0x000C238C File Offset: 0x000C058C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string MapName)
		{
			FBeginTravelLoadMapDelegate.__FBeginTravelLoadMapDelegate_DelegateParams* ptr = stackalloc FBeginTravelLoadMapDelegate.__FBeginTravelLoadMapDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FBeginTravelLoadMapDelegate.__FBeginTravelLoadMapDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FBeginTravelLoadMapDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->MapName), MapName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FBeginTravelLoadMapDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008344 RID: 33604 RVA: 0x000C23E0 File Offset: 0x000C05E0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FBeginTravelLoadMapDelegate.__FBeginTravelLoadMapDelegate_DelegateParams*)__Parameters)->MapName));
			action(obj);
		}

		// Token: 0x04003913 RID: 14611
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003914 RID: 14612
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.BeginTravelLoadMapDelegate__DelegateSignature";

		// Token: 0x04003915 RID: 14613
		private static int RegisterId;

		// Token: 0x02000D39 RID: 3385
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FBeginTravelLoadMapDelegate_DelegateParams
		{
			// Token: 0x04005FD3 RID: 24531
			[FieldOffset(0)]
			public FString MapName;
		}

		// Token: 0x02000D3A RID: 3386
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FD4 RID: 24532
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
