using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B5 RID: 1461
	public sealed class FBeginLoadMapDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008333 RID: 33587 RVA: 0x000C2172 File Offset: 0x000C0372
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FBeginLoadMapDelegate.StaticFunctionPtr();
		}

		// Token: 0x06008334 RID: 33588 RVA: 0x000C217E File Offset: 0x000C037E
		private static IntPtr StaticFunctionPtr()
		{
			if (FBeginLoadMapDelegate._FunctionPtr == IntPtr.Zero)
			{
				FBeginLoadMapDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.BeginLoadMapDelegate__DelegateSignature");
			}
			return FBeginLoadMapDelegate._FunctionPtr;
		}

		// Token: 0x06008335 RID: 33589 RVA: 0x000C21A1 File Offset: 0x000C03A1
		public FBeginLoadMapDelegate()
		{
		}

		// Token: 0x06008336 RID: 33590 RVA: 0x000C21A9 File Offset: 0x000C03A9
		[NullableContext(2)]
		public FBeginLoadMapDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008337 RID: 33591 RVA: 0x000C21B3 File Offset: 0x000C03B3
		public FBeginLoadMapDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008338 RID: 33592 RVA: 0x000C21BE File Offset: 0x000C03BE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008339 RID: 33593 RVA: 0x000C21F0 File Offset: 0x000C03F0
		[NullableContext(1)]
		public void Bind(Action<string> Callback)
		{
			if (FBeginLoadMapDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FBeginLoadMapDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FBeginLoadMapDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FBeginLoadMapDelegate.OnScriptCallback));
				}
				FBeginLoadMapDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FBeginLoadMapDelegate.RegisterId);
		}

		// Token: 0x0600833A RID: 33594 RVA: 0x000C222C File Offset: 0x000C042C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string MapName)
		{
			FBeginLoadMapDelegate.__FBeginLoadMapDelegate_DelegateParams* ptr = stackalloc FBeginLoadMapDelegate.__FBeginLoadMapDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FBeginLoadMapDelegate.__FBeginLoadMapDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FBeginLoadMapDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->MapName), MapName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FBeginLoadMapDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600833B RID: 33595 RVA: 0x000C2280 File Offset: 0x000C0480
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FBeginLoadMapDelegate.__FBeginLoadMapDelegate_DelegateParams*)__Parameters)->MapName));
			action(obj);
		}

		// Token: 0x04003910 RID: 14608
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003911 RID: 14609
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.BeginLoadMapDelegate__DelegateSignature";

		// Token: 0x04003912 RID: 14610
		private static int RegisterId;

		// Token: 0x02000D37 RID: 3383
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FBeginLoadMapDelegate_DelegateParams
		{
			// Token: 0x04005FD1 RID: 24529
			[FieldOffset(0)]
			public FString MapName;
		}

		// Token: 0x02000D38 RID: 3384
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FD2 RID: 24530
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
