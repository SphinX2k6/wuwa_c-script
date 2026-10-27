using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200191B RID: 6427
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FLightUpPointLightSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017D9A RID: 97690 RVA: 0x0022ECCD File Offset: 0x0022CECD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLightUpPointLightSignature.StaticFunctionPtr();
		}

		// Token: 0x06017D9B RID: 97691 RVA: 0x0022ECD9 File Offset: 0x0022CED9
		private static IntPtr StaticFunctionPtr()
		{
			if (FLightUpPointLightSignature._FunctionPtr == IntPtr.Zero)
			{
				FLightUpPointLightSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.LightUpPointLightSignature__DelegateSignature");
			}
			return FLightUpPointLightSignature._FunctionPtr;
		}

		// Token: 0x06017D9C RID: 97692 RVA: 0x0022ECFC File Offset: 0x0022CEFC
		public FLightUpPointLightSignature()
		{
		}

		// Token: 0x06017D9D RID: 97693 RVA: 0x0022ED04 File Offset: 0x0022CF04
		[NullableContext(2)]
		public FLightUpPointLightSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017D9E RID: 97694 RVA: 0x0022ED0E File Offset: 0x0022CF0E
		public FLightUpPointLightSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017D9F RID: 97695 RVA: 0x0022ED19 File Offset: 0x0022CF19
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017DA0 RID: 97696 RVA: 0x0022ED4B File Offset: 0x0022CF4B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06017DA1 RID: 97697 RVA: 0x0022ED85 File Offset: 0x0022CF85
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06017DA2 RID: 97698 RVA: 0x0022ED90 File Offset: 0x0022CF90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int Source, int Target)
		{
			FLightUpPointLightSignature.__FLightUpPointLightSignature_DelegateParams* ptr = stackalloc FLightUpPointLightSignature.__FLightUpPointLightSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLightUpPointLightSignature.__FLightUpPointLightSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLightUpPointLightSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Source = Source;
			ptr->Target = Target;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06017DA3 RID: 97699 RVA: 0x0022EDD4 File Offset: 0x0022CFD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLightUpPointLightSignature.__FLightUpPointLightSignature_DelegateParams*)__Parameters)->Source, ((FLightUpPointLightSignature.__FLightUpPointLightSignature_DelegateParams*)__Parameters)->Target);
		}

		// Token: 0x0400CEC2 RID: 52930
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CEC3 RID: 52931
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.LightUpPointLightSignature__DelegateSignature";

		// Token: 0x0400CEC4 RID: 52932
		private static int RegisterId;

		// Token: 0x02002FDF RID: 12255
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLightUpPointLightSignature_DelegateParams
		{
			// Token: 0x04016BD8 RID: 93144
			[FieldOffset(0)]
			public int Source;

			// Token: 0x04016BD9 RID: 93145
			[FieldOffset(4)]
			public int Target;
		}

		// Token: 0x02002FE0 RID: 12256
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016BDA RID: 93146
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
