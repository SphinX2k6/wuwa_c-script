using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200226A RID: 8810
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FMagtAPOnQualityGroupChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060217BA RID: 137146 RVA: 0x003175E0 File Offset: 0x003157E0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMagtAPOnQualityGroupChanged.StaticFunctionPtr();
		}

		// Token: 0x060217BB RID: 137147 RVA: 0x003175EC File Offset: 0x003157EC
		private static IntPtr StaticFunctionPtr()
		{
			if (FMagtAPOnQualityGroupChanged._FunctionPtr == IntPtr.Zero)
			{
				FMagtAPOnQualityGroupChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MagtModule.MagtAPOnQualityGroupChanged__DelegateSignature");
			}
			return FMagtAPOnQualityGroupChanged._FunctionPtr;
		}

		// Token: 0x060217BC RID: 137148 RVA: 0x0031760F File Offset: 0x0031580F
		public FMagtAPOnQualityGroupChanged()
		{
		}

		// Token: 0x060217BD RID: 137149 RVA: 0x00317617 File Offset: 0x00315817
		[NullableContext(2)]
		public FMagtAPOnQualityGroupChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060217BE RID: 137150 RVA: 0x00317621 File Offset: 0x00315821
		public FMagtAPOnQualityGroupChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060217BF RID: 137151 RVA: 0x0031762C File Offset: 0x0031582C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName, int, int>) ?? ((Action<FName, int, int>)Delegate.CreateDelegate(typeof(Action<FName, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060217C0 RID: 137152 RVA: 0x0031765E File Offset: 0x0031585E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FName, int, int> Callback)
		{
			if (FMagtAPOnQualityGroupChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMagtAPOnQualityGroupChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMagtAPOnQualityGroupChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMagtAPOnQualityGroupChanged.OnScriptCallback));
				}
				FMagtAPOnQualityGroupChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FMagtAPOnQualityGroupChanged.RegisterId);
		}

		// Token: 0x060217C1 RID: 137153 RVA: 0x00317698 File Offset: 0x00315898
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FName, int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060217C2 RID: 137154 RVA: 0x003176A4 File Offset: 0x003158A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FName GroupName, int OldLevel, int NewLevel)
		{
			FMagtAPOnQualityGroupChanged.__FMagtAPOnQualityGroupChanged_DelegateParams* ptr = stackalloc FMagtAPOnQualityGroupChanged.__FMagtAPOnQualityGroupChanged_DelegateParams[(UIntPtr)35] + 15L / (long)sizeof(FMagtAPOnQualityGroupChanged.__FMagtAPOnQualityGroupChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMagtAPOnQualityGroupChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->GroupName = GroupName;
			ptr->OldLevel = OldLevel;
			ptr->NewLevel = NewLevel;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060217C3 RID: 137155 RVA: 0x003176F0 File Offset: 0x003158F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName, int, int> action = target as Action<FName, int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FMagtAPOnQualityGroupChanged.__FMagtAPOnQualityGroupChanged_DelegateParams*)__Parameters)->GroupName, ((FMagtAPOnQualityGroupChanged.__FMagtAPOnQualityGroupChanged_DelegateParams*)__Parameters)->OldLevel, ((FMagtAPOnQualityGroupChanged.__FMagtAPOnQualityGroupChanged_DelegateParams*)__Parameters)->NewLevel);
		}

		// Token: 0x04011E0B RID: 73227
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011E0C RID: 73228
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.MagtAPOnQualityGroupChanged__DelegateSignature";

		// Token: 0x04011E0D RID: 73229
		private static int RegisterId;

		// Token: 0x020035AB RID: 13739
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __FMagtAPOnQualityGroupChanged_DelegateParams
		{
			// Token: 0x040175E8 RID: 95720
			[FieldOffset(0)]
			public FName GroupName;

			// Token: 0x040175E9 RID: 95721
			[FieldOffset(12)]
			public int OldLevel;

			// Token: 0x040175EA RID: 95722
			[FieldOffset(16)]
			public int NewLevel;
		}

		// Token: 0x020035AC RID: 13740
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040175EB RID: 95723
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
