using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018DD RID: 6365
	[UnrealObjectPath("/Script/KuroGameplay.KuroInputDelegateManager")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKuroInputDelegateManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017945 RID: 96581 RVA: 0x0022831C File Offset: 0x0022651C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInputDelegateManager._ClassPtr;
		}

		// Token: 0x06017946 RID: 96582 RVA: 0x00228328 File Offset: 0x00226528
		public UKuroInputDelegateManager() : this(BuiltinUtils.AllocNativeUObject(UKuroInputDelegateManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017947 RID: 96583 RVA: 0x00228350 File Offset: 0x00226550
		[NullableContext(1)]
		public UKuroInputDelegateManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInputDelegateManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017948 RID: 96584 RVA: 0x00228384 File Offset: 0x00226584
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnActorDestroy(AActor Actor)
		{
			UKuroInputDelegateManager.__OnActorDestroy_FunctionParams* ptr = stackalloc UKuroInputDelegateManager.__OnActorDestroy_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroInputDelegateManager.__OnActorDestroy_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroInputDelegateManager.__OnActorDestroy_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroInputDelegateManager.__OnActorDestroy_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017949 RID: 96585 RVA: 0x002283DA File Offset: 0x002265DA
		static UKuroInputDelegateManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroInputDelegateManager");
		}

		// Token: 0x0601794A RID: 96586 RVA: 0x002283E8 File Offset: 0x002265E8
		protected UKuroInputDelegateManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CCBE RID: 52414
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroInputDelegateManager";

		// Token: 0x0400CCBF RID: 52415
		private static IntPtr _ClassPtr;

		// Token: 0x0400CCC0 RID: 52416
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CCC1 RID: 52417
		private static IntPtr __OnActorDestroy_NativeFunctionPtr;

		// Token: 0x02002FBB RID: 12219
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnActorDestroy_FunctionParams
		{
			// Token: 0x04016B9F RID: 93087
			[FieldOffset(0)]
			public IntPtr Actor;
		}
	}
}
