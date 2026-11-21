using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200022E RID: 558
	public sealed class FKuroRunMapTickDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002D1C RID: 11548 RVA: 0x0003FA91 File Offset: 0x0003DC91
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroRunMapTickDelegate.StaticFunctionPtr();
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x0003FA9D File Offset: 0x0003DC9D
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroRunMapTickDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroRunMapTickDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.KuroRunMapTickDelegate__DelegateSignature");
			}
			return FKuroRunMapTickDelegate._FunctionPtr;
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x0003FAC0 File Offset: 0x0003DCC0
		public FKuroRunMapTickDelegate()
		{
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x0003FAC8 File Offset: 0x0003DCC8
		[NullableContext(2)]
		public FKuroRunMapTickDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x0003FAD2 File Offset: 0x0003DCD2
		public FKuroRunMapTickDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x0003FADD File Offset: 0x0003DCDD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float, float, float>) ?? ((Action<float, float, float>)Delegate.CreateDelegate(typeof(Action<float, float, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x0003FB0F File Offset: 0x0003DD0F
		[NullableContext(1)]
		public void Bind(Action<float, float, float> Callback)
		{
			if (FKuroRunMapTickDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroRunMapTickDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroRunMapTickDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroRunMapTickDelegate.OnScriptCallback));
				}
				FKuroRunMapTickDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroRunMapTickDelegate.RegisterId);
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x0003FB4C File Offset: 0x0003DD4C
		[SkipLocalsInit]
		public unsafe void Execute(float X, float Y, float Z)
		{
			FKuroRunMapTickDelegate.__FKuroRunMapTickDelegate_DelegateParams* ptr = stackalloc FKuroRunMapTickDelegate.__FKuroRunMapTickDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FKuroRunMapTickDelegate.__FKuroRunMapTickDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroRunMapTickDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->X = X;
			ptr->Y = Y;
			ptr->Z = Z;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x0003FB98 File Offset: 0x0003DD98
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float, float, float> action = target as Action<float, float, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroRunMapTickDelegate.__FKuroRunMapTickDelegate_DelegateParams*)__Parameters)->X, ((FKuroRunMapTickDelegate.__FKuroRunMapTickDelegate_DelegateParams*)__Parameters)->Y, ((FKuroRunMapTickDelegate.__FKuroRunMapTickDelegate_DelegateParams*)__Parameters)->Z);
		}

		// Token: 0x04000E4F RID: 3663
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000E50 RID: 3664
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KuroRunMapTickDelegate__DelegateSignature";

		// Token: 0x04000E51 RID: 3665
		private static int RegisterId;

		// Token: 0x020009B6 RID: 2486
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FKuroRunMapTickDelegate_DelegateParams
		{
			// Token: 0x0400593B RID: 22843
			[FieldOffset(0)]
			public float X;

			// Token: 0x0400593C RID: 22844
			[FieldOffset(4)]
			public float Y;

			// Token: 0x0400593D RID: 22845
			[FieldOffset(8)]
			public float Z;
		}

		// Token: 0x020009B7 RID: 2487
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400593E RID: 22846
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
