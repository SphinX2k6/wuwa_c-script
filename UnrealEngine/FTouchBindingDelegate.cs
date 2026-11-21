using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000423 RID: 1059
	public sealed class FTouchBindingDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600661A RID: 26138 RVA: 0x0009294C File Offset: 0x00090B4C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTouchBindingDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600661B RID: 26139 RVA: 0x00092958 File Offset: 0x00090B58
		private static IntPtr StaticFunctionPtr()
		{
			if (FTouchBindingDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTouchBindingDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.TouchBindingDelegate__DelegateSignature");
			}
			return FTouchBindingDelegate._FunctionPtr;
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x0009297B File Offset: 0x00090B7B
		public FTouchBindingDelegate()
		{
		}

		// Token: 0x0600661D RID: 26141 RVA: 0x00092983 File Offset: 0x00090B83
		[NullableContext(2)]
		public FTouchBindingDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600661E RID: 26142 RVA: 0x0009298D File Offset: 0x00090B8D
		public FTouchBindingDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600661F RID: 26143 RVA: 0x00092998 File Offset: 0x00090B98
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<TEnumAsByte<ETouchIndex>, FVector>) ?? ((Action<TEnumAsByte<ETouchIndex>, FVector>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006620 RID: 26144 RVA: 0x000929CA File Offset: 0x00090BCA
		public void Bind([Nullable(new byte[]
		{
			1,
			0
		})] Action<TEnumAsByte<ETouchIndex>, FVector> Callback)
		{
			if (FTouchBindingDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTouchBindingDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTouchBindingDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTouchBindingDelegate.OnScriptCallback));
				}
				FTouchBindingDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTouchBindingDelegate.RegisterId);
		}

		// Token: 0x06006621 RID: 26145 RVA: 0x00092A04 File Offset: 0x00090C04
		[SkipLocalsInit]
		public unsafe void Execute(ETouchIndex TouchIndex, FVector Position)
		{
			FTouchBindingDelegate.__FTouchBindingDelegate_DelegateParams* ptr = stackalloc FTouchBindingDelegate.__FTouchBindingDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FTouchBindingDelegate.__FTouchBindingDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTouchBindingDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchIndex = TouchIndex;
			ptr->Position = Position;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006622 RID: 26146 RVA: 0x00092A50 File Offset: 0x00090C50
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<ETouchIndex>, FVector> action = target as Action<TEnumAsByte<ETouchIndex>, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FTouchBindingDelegate.__FTouchBindingDelegate_DelegateParams*)__Parameters)->TouchIndex, ((FTouchBindingDelegate.__FTouchBindingDelegate_DelegateParams*)__Parameters)->Position);
		}

		// Token: 0x04002AED RID: 10989
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002AEE RID: 10990
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.TouchBindingDelegate__DelegateSignature";

		// Token: 0x04002AEF RID: 10991
		private static int RegisterId;

		// Token: 0x02000B1F RID: 2847
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FTouchBindingDelegate_DelegateParams
		{
			// Token: 0x04005BD2 RID: 23506
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> TouchIndex;

			// Token: 0x04005BD3 RID: 23507
			[FieldOffset(4)]
			public FVector Position;
		}

		// Token: 0x02000B20 RID: 2848
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BD4 RID: 23508
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
