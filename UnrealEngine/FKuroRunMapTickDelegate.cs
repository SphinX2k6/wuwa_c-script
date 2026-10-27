using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D0C RID: 3340
	public sealed class FKuroRunMapTickDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B256 RID: 45654 RVA: 0x000FDADD File Offset: 0x000FBCDD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroRunMapTickDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600B257 RID: 45655 RVA: 0x000FDAE9 File Offset: 0x000FBCE9
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroRunMapTickDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroRunMapTickDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.KuroRunMapTickDelegate__DelegateSignature");
			}
			return FKuroRunMapTickDelegate._FunctionPtr;
		}

		// Token: 0x0600B258 RID: 45656 RVA: 0x000FDB0C File Offset: 0x000FBD0C
		public FKuroRunMapTickDelegate()
		{
		}

		// Token: 0x0600B259 RID: 45657 RVA: 0x000FDB14 File Offset: 0x000FBD14
		[NullableContext(2)]
		public FKuroRunMapTickDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B25A RID: 45658 RVA: 0x000FDB1E File Offset: 0x000FBD1E
		public FKuroRunMapTickDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B25B RID: 45659 RVA: 0x000FDB29 File Offset: 0x000FBD29
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float, float, float>) ?? ((Action<float, float, float>)Delegate.CreateDelegate(typeof(Action<float, float, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B25C RID: 45660 RVA: 0x000FDB5B File Offset: 0x000FBD5B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0600B25D RID: 45661 RVA: 0x000FDB98 File Offset: 0x000FBD98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(float X, float Y, float Z)
		{
			FKuroRunMapTickDelegate.__FKuroRunMapTickDelegate_DelegateParams* ptr = stackalloc FKuroRunMapTickDelegate.__FKuroRunMapTickDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FKuroRunMapTickDelegate.__FKuroRunMapTickDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroRunMapTickDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->X = X;
			ptr->Y = Y;
			ptr->Z = Z;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600B25E RID: 45662 RVA: 0x000FDBE4 File Offset: 0x000FBDE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float, float, float> action = target as Action<float, float, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroRunMapTickDelegate.__FKuroRunMapTickDelegate_DelegateParams*)__Parameters)->X, ((FKuroRunMapTickDelegate.__FKuroRunMapTickDelegate_DelegateParams*)__Parameters)->Y, ((FKuroRunMapTickDelegate.__FKuroRunMapTickDelegate_DelegateParams*)__Parameters)->Z);
		}

		// Token: 0x04005D8A RID: 23946
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005D8B RID: 23947
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KuroRunMapTickDelegate__DelegateSignature";

		// Token: 0x04005D8C RID: 23948
		private static int RegisterId;

		// Token: 0x02002D37 RID: 11575
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FKuroRunMapTickDelegate_DelegateParams
		{
			// Token: 0x04016737 RID: 91959
			[FieldOffset(0)]
			public float X;

			// Token: 0x04016738 RID: 91960
			[FieldOffset(4)]
			public float Y;

			// Token: 0x04016739 RID: 91961
			[FieldOffset(8)]
			public float Z;
		}

		// Token: 0x02002D38 RID: 11576
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401673A RID: 91962
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
