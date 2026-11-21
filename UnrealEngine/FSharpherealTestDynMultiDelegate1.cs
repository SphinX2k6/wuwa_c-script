using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007EA RID: 2026
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSharpherealTestDynMultiDelegate1 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600AD99 RID: 44441 RVA: 0x00100DAA File Offset: 0x000FEFAA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealTestDynMultiDelegate1.StaticFunctionPtr();
		}

		// Token: 0x0600AD9A RID: 44442 RVA: 0x00100DB6 File Offset: 0x000FEFB6
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealTestDynMultiDelegate1._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealTestDynMultiDelegate1._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SharpherealTest.SharpherealTestDynMultiDelegate1__DelegateSignature");
			}
			return FSharpherealTestDynMultiDelegate1._FunctionPtr;
		}

		// Token: 0x0600AD9B RID: 44443 RVA: 0x00100DD9 File Offset: 0x000FEFD9
		public FSharpherealTestDynMultiDelegate1()
		{
		}

		// Token: 0x0600AD9C RID: 44444 RVA: 0x00100DE1 File Offset: 0x000FEFE1
		[NullableContext(2)]
		public FSharpherealTestDynMultiDelegate1(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AD9D RID: 44445 RVA: 0x00100DEB File Offset: 0x000FEFEB
		public FSharpherealTestDynMultiDelegate1(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AD9E RID: 44446 RVA: 0x00100DF6 File Offset: 0x000FEFF6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600AD9F RID: 44447 RVA: 0x00100E28 File Offset: 0x000FF028
		[NullableContext(1)]
		public void Add(Action<int> Callback)
		{
			if (FSharpherealTestDynMultiDelegate1.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealTestDynMultiDelegate1.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealTestDynMultiDelegate1.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealTestDynMultiDelegate1.OnScriptCallback));
				}
				FSharpherealTestDynMultiDelegate1.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSharpherealTestDynMultiDelegate1.RegisterId);
		}

		// Token: 0x0600ADA0 RID: 44448 RVA: 0x00100E62 File Offset: 0x000FF062
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600ADA1 RID: 44449 RVA: 0x00100E6C File Offset: 0x000FF06C
		[SkipLocalsInit]
		public unsafe void Broadcast(int Val)
		{
			FSharpherealTestDynMultiDelegate1.__FSharpherealTestDynMultiDelegate1_DelegateParams* ptr = stackalloc FSharpherealTestDynMultiDelegate1.__FSharpherealTestDynMultiDelegate1_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FSharpherealTestDynMultiDelegate1.__FSharpherealTestDynMultiDelegate1_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealTestDynMultiDelegate1.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Val = Val;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600ADA2 RID: 44450 RVA: 0x00100EA8 File Offset: 0x000FF0A8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSharpherealTestDynMultiDelegate1.__FSharpherealTestDynMultiDelegate1_DelegateParams*)__Parameters)->Val);
		}

		// Token: 0x04004AE6 RID: 19174
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004AE7 RID: 19175
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestDynMultiDelegate1__DelegateSignature";

		// Token: 0x04004AE8 RID: 19176
		private static int RegisterId;

		// Token: 0x02000F94 RID: 3988
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FSharpherealTestDynMultiDelegate1_DelegateParams
		{
			// Token: 0x04006394 RID: 25492
			[FieldOffset(0)]
			public int Val;
		}

		// Token: 0x02000F95 RID: 3989
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006395 RID: 25493
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
