using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003F5 RID: 1013
	public sealed class FKuroLoadResourceDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060063A5 RID: 25509 RVA: 0x0008E7F1 File Offset: 0x0008C9F1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroLoadResourceDelegate.StaticFunctionPtr();
		}

		// Token: 0x060063A6 RID: 25510 RVA: 0x0008E7FD File Offset: 0x0008C9FD
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroLoadResourceDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroLoadResourceDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KuroLoadResourceDelegate__DelegateSignature");
			}
			return FKuroLoadResourceDelegate._FunctionPtr;
		}

		// Token: 0x060063A7 RID: 25511 RVA: 0x0008E820 File Offset: 0x0008CA20
		public FKuroLoadResourceDelegate()
		{
		}

		// Token: 0x060063A8 RID: 25512 RVA: 0x0008E828 File Offset: 0x0008CA28
		[NullableContext(2)]
		public FKuroLoadResourceDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060063A9 RID: 25513 RVA: 0x0008E832 File Offset: 0x0008CA32
		public FKuroLoadResourceDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060063AA RID: 25514 RVA: 0x0008E83D File Offset: 0x0008CA3D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060063AB RID: 25515 RVA: 0x0008E86F File Offset: 0x0008CA6F
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FKuroLoadResourceDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroLoadResourceDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroLoadResourceDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroLoadResourceDelegate.OnScriptCallback));
				}
				FKuroLoadResourceDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroLoadResourceDelegate.RegisterId);
		}

		// Token: 0x060063AC RID: 25516 RVA: 0x0008E8AC File Offset: 0x0008CAAC
		[SkipLocalsInit]
		public unsafe void Execute(int HandleId)
		{
			FKuroLoadResourceDelegate.__FKuroLoadResourceDelegate_DelegateParams* ptr = stackalloc FKuroLoadResourceDelegate.__FKuroLoadResourceDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroLoadResourceDelegate.__FKuroLoadResourceDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroLoadResourceDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->HandleId = HandleId;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x0008E8EC File Offset: 0x0008CAEC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroLoadResourceDelegate.__FKuroLoadResourceDelegate_DelegateParams*)__Parameters)->HandleId);
		}

		// Token: 0x04002A1E RID: 10782
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002A1F RID: 10783
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroLoadResourceDelegate__DelegateSignature";

		// Token: 0x04002A20 RID: 10784
		private static int RegisterId;

		// Token: 0x02000AEC RID: 2796
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FKuroLoadResourceDelegate_DelegateParams
		{
			// Token: 0x04005B72 RID: 23410
			[FieldOffset(0)]
			public int HandleId;
		}

		// Token: 0x02000AED RID: 2797
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B73 RID: 23411
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
