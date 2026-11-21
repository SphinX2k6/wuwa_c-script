using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000307 RID: 775
	public sealed class FUpdateAnimInfoDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005315 RID: 21269 RVA: 0x0007420E File Offset: 0x0007240E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUpdateAnimInfoDelegate.StaticFunctionPtr();
		}

		// Token: 0x06005316 RID: 21270 RVA: 0x0007421A File Offset: 0x0007241A
		private static IntPtr StaticFunctionPtr()
		{
			if (FUpdateAnimInfoDelegate._FunctionPtr == IntPtr.Zero)
			{
				FUpdateAnimInfoDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroAnim.UpdateAnimInfoDelegate__DelegateSignature");
			}
			return FUpdateAnimInfoDelegate._FunctionPtr;
		}

		// Token: 0x06005317 RID: 21271 RVA: 0x0007423D File Offset: 0x0007243D
		public FUpdateAnimInfoDelegate()
		{
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x00074245 File Offset: 0x00072445
		[NullableContext(2)]
		public FUpdateAnimInfoDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005319 RID: 21273 RVA: 0x0007424F File Offset: 0x0007244F
		public FUpdateAnimInfoDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600531A RID: 21274 RVA: 0x0007425A File Offset: 0x0007245A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x0007428C File Offset: 0x0007248C
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FUpdateAnimInfoDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUpdateAnimInfoDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUpdateAnimInfoDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUpdateAnimInfoDelegate.OnScriptCallback));
				}
				FUpdateAnimInfoDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FUpdateAnimInfoDelegate.RegisterId);
		}

		// Token: 0x0600531C RID: 21276 RVA: 0x000742C8 File Offset: 0x000724C8
		[SkipLocalsInit]
		public unsafe void Execute(int EntityId)
		{
			FUpdateAnimInfoDelegate.__FUpdateAnimInfoDelegate_DelegateParams* ptr = stackalloc FUpdateAnimInfoDelegate.__FUpdateAnimInfoDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FUpdateAnimInfoDelegate.__FUpdateAnimInfoDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUpdateAnimInfoDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x00074308 File Offset: 0x00072508
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FUpdateAnimInfoDelegate.__FUpdateAnimInfoDelegate_DelegateParams*)__Parameters)->EntityId);
		}

		// Token: 0x040021EB RID: 8683
		internal static IntPtr _FunctionPtr;

		// Token: 0x040021EC RID: 8684
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.UpdateAnimInfoDelegate__DelegateSignature";

		// Token: 0x040021ED RID: 8685
		private static int RegisterId;

		// Token: 0x02000A14 RID: 2580
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FUpdateAnimInfoDelegate_DelegateParams
		{
			// Token: 0x040059D4 RID: 22996
			[FieldOffset(0)]
			public int EntityId;
		}

		// Token: 0x02000A15 RID: 2581
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040059D5 RID: 22997
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
