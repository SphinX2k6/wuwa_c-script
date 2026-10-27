using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021AB RID: 8619
	[UnrealObjectPath("/Script/LGUI.UISelectableStateHolder")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UUISelectableStateHolder : UUISelectableTransitionComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020C6D RID: 134253 RVA: 0x0030725E File Offset: 0x0030545E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISelectableStateHolder._ClassPtr;
		}

		// Token: 0x06020C6E RID: 134254 RVA: 0x0030726C File Offset: 0x0030546C
		public UUISelectableStateHolder() : this(BuiltinUtils.AllocNativeUObject(UUISelectableStateHolder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020C6F RID: 134255 RVA: 0x00307294 File Offset: 0x00305494
		[NullableContext(1)]
		public UUISelectableStateHolder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISelectableStateHolder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008007 RID: 32775
		// (get) Token: 0x06020C70 RID: 134256 RVA: 0x003072C7 File Offset: 0x003054C7
		// (set) Token: 0x06020C71 RID: 134257 RVA: 0x003072D7 File Offset: 0x003054D7
		public unsafe EStateTransitionType TransitionType
		{
			get
			{
				return (EStateTransitionType)(*(base.NativePtr + (IntPtr)UUISelectableStateHolder.__PropertyOffset_TransitionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableStateHolder.__PropertyOffset_TransitionType) = (byte)value;
			}
		}

		// Token: 0x06020C72 RID: 134258 RVA: 0x003072E8 File Offset: 0x003054E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetAllTransitionsEnable(bool bEnable)
		{
			UUISelectableStateHolder.__SetAllTransitionsEnable_FunctionParams* ptr = stackalloc UUISelectableStateHolder.__SetAllTransitionsEnable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UUISelectableStateHolder.__SetAllTransitionsEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UUISelectableStateHolder.__SetAllTransitionsEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UUISelectableStateHolder.__SetAllTransitionsEnable_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020C73 RID: 134259 RVA: 0x0030732F File Offset: 0x0030552F
		static UUISelectableStateHolder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISelectableStateHolder");
		}

		// Token: 0x06020C74 RID: 134260 RVA: 0x0030733D File Offset: 0x0030553D
		protected UUISelectableStateHolder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401182E RID: 71726
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISelectableStateHolder";

		// Token: 0x0401182F RID: 71727
		private static IntPtr _ClassPtr;

		// Token: 0x04011830 RID: 71728
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011831 RID: 71729
		internal static int __PropertyOffset_TransitionType;

		// Token: 0x04011832 RID: 71730
		private static IntPtr __SetAllTransitionsEnable_NativeFunctionPtr;

		// Token: 0x02003502 RID: 13570
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetAllTransitionsEnable_FunctionParams
		{
			// Token: 0x0401752B RID: 95531
			[FieldOffset(0)]
			public bool bEnable;
		}
	}
}
