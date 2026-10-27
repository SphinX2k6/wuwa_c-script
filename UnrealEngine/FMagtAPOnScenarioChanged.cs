using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200226B RID: 8811
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FMagtAPOnScenarioChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060217C4 RID: 137156 RVA: 0x00317746 File Offset: 0x00315946
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMagtAPOnScenarioChanged.StaticFunctionPtr();
		}

		// Token: 0x060217C5 RID: 137157 RVA: 0x00317752 File Offset: 0x00315952
		private static IntPtr StaticFunctionPtr()
		{
			if (FMagtAPOnScenarioChanged._FunctionPtr == IntPtr.Zero)
			{
				FMagtAPOnScenarioChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MagtModule.MagtAPOnScenarioChanged__DelegateSignature");
			}
			return FMagtAPOnScenarioChanged._FunctionPtr;
		}

		// Token: 0x060217C6 RID: 137158 RVA: 0x00317775 File Offset: 0x00315975
		public FMagtAPOnScenarioChanged()
		{
		}

		// Token: 0x060217C7 RID: 137159 RVA: 0x0031777D File Offset: 0x0031597D
		[NullableContext(2)]
		public FMagtAPOnScenarioChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060217C8 RID: 137160 RVA: 0x00317787 File Offset: 0x00315987
		public FMagtAPOnScenarioChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060217C9 RID: 137161 RVA: 0x00317792 File Offset: 0x00315992
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<EMagtAPScenario, EMagtAPScenario>) ?? ((Action<EMagtAPScenario, EMagtAPScenario>)Delegate.CreateDelegate(typeof(Action<EMagtAPScenario, EMagtAPScenario>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060217CA RID: 137162 RVA: 0x003177C4 File Offset: 0x003159C4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<EMagtAPScenario, EMagtAPScenario> Callback)
		{
			if (FMagtAPOnScenarioChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMagtAPOnScenarioChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMagtAPOnScenarioChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMagtAPOnScenarioChanged.OnScriptCallback));
				}
				FMagtAPOnScenarioChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FMagtAPOnScenarioChanged.RegisterId);
		}

		// Token: 0x060217CB RID: 137163 RVA: 0x003177FE File Offset: 0x003159FE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<EMagtAPScenario, EMagtAPScenario> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060217CC RID: 137164 RVA: 0x00317808 File Offset: 0x00315A08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(EMagtAPScenario OldScenario, EMagtAPScenario NewScenario)
		{
			FMagtAPOnScenarioChanged.__FMagtAPOnScenarioChanged_DelegateParams* ptr = stackalloc FMagtAPOnScenarioChanged.__FMagtAPOnScenarioChanged_DelegateParams[(UIntPtr)17] + 15L / (long)sizeof(FMagtAPOnScenarioChanged.__FMagtAPOnScenarioChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMagtAPOnScenarioChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OldScenario = OldScenario;
			ptr->NewScenario = NewScenario;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060217CD RID: 137165 RVA: 0x0031784C File Offset: 0x00315A4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EMagtAPScenario, EMagtAPScenario> action = target as Action<EMagtAPScenario, EMagtAPScenario>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FMagtAPOnScenarioChanged.__FMagtAPOnScenarioChanged_DelegateParams*)__Parameters)->OldScenario, ((FMagtAPOnScenarioChanged.__FMagtAPOnScenarioChanged_DelegateParams*)__Parameters)->NewScenario);
		}

		// Token: 0x04011E0E RID: 73230
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011E0F RID: 73231
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.MagtAPOnScenarioChanged__DelegateSignature";

		// Token: 0x04011E10 RID: 73232
		private static int RegisterId;

		// Token: 0x020035AD RID: 13741
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __FMagtAPOnScenarioChanged_DelegateParams
		{
			// Token: 0x040175EC RID: 95724
			[FieldOffset(0)]
			public EMagtAPScenario OldScenario;

			// Token: 0x040175ED RID: 95725
			[FieldOffset(1)]
			public EMagtAPScenario NewScenario;
		}

		// Token: 0x020035AE RID: 13742
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040175EE RID: 95726
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
