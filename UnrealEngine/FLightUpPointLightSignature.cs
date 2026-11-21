using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000409 RID: 1033
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FLightUpPointLightSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006510 RID: 25872 RVA: 0x000902CD File Offset: 0x0008E4CD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLightUpPointLightSignature.StaticFunctionPtr();
		}

		// Token: 0x06006511 RID: 25873 RVA: 0x000902D9 File Offset: 0x0008E4D9
		private static IntPtr StaticFunctionPtr()
		{
			if (FLightUpPointLightSignature._FunctionPtr == IntPtr.Zero)
			{
				FLightUpPointLightSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.LightUpPointLightSignature__DelegateSignature");
			}
			return FLightUpPointLightSignature._FunctionPtr;
		}

		// Token: 0x06006512 RID: 25874 RVA: 0x000902FC File Offset: 0x0008E4FC
		public FLightUpPointLightSignature()
		{
		}

		// Token: 0x06006513 RID: 25875 RVA: 0x00090304 File Offset: 0x0008E504
		[NullableContext(2)]
		public FLightUpPointLightSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x0009030E File Offset: 0x0008E50E
		public FLightUpPointLightSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x00090319 File Offset: 0x0008E519
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006516 RID: 25878 RVA: 0x0009034B File Offset: 0x0008E54B
		[NullableContext(1)]
		public void Add(Action<int, int> Callback)
		{
			if (FLightUpPointLightSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLightUpPointLightSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLightUpPointLightSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLightUpPointLightSignature.OnScriptCallback));
				}
				FLightUpPointLightSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FLightUpPointLightSignature.RegisterId);
		}

		// Token: 0x06006517 RID: 25879 RVA: 0x00090385 File Offset: 0x0008E585
		[NullableContext(1)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006518 RID: 25880 RVA: 0x00090390 File Offset: 0x0008E590
		[SkipLocalsInit]
		public unsafe void Broadcast(int Source, int Target)
		{
			FLightUpPointLightSignature.__FLightUpPointLightSignature_DelegateParams* ptr = stackalloc FLightUpPointLightSignature.__FLightUpPointLightSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLightUpPointLightSignature.__FLightUpPointLightSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLightUpPointLightSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Source = Source;
			ptr->Target = Target;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06006519 RID: 25881 RVA: 0x000903D4 File Offset: 0x0008E5D4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLightUpPointLightSignature.__FLightUpPointLightSignature_DelegateParams*)__Parameters)->Source, ((FLightUpPointLightSignature.__FLightUpPointLightSignature_DelegateParams*)__Parameters)->Target);
		}

		// Token: 0x04002A87 RID: 10887
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002A88 RID: 10888
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.LightUpPointLightSignature__DelegateSignature";

		// Token: 0x04002A89 RID: 10889
		private static int RegisterId;

		// Token: 0x02000AF3 RID: 2803
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLightUpPointLightSignature_DelegateParams
		{
			// Token: 0x04005B81 RID: 23425
			[FieldOffset(0)]
			public int Source;

			// Token: 0x04005B82 RID: 23426
			[FieldOffset(4)]
			public int Target;
		}

		// Token: 0x02000AF4 RID: 2804
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B83 RID: 23427
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
