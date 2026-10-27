using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001762 RID: 5986
	[UnrealObjectPath("/Script/KuroComponent.KuroSceneItemGuidePathComponent")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UKuroSceneItemGuidePathComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601583E RID: 88126 RVA: 0x001F9DAB File Offset: 0x001F7FAB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneItemGuidePathComponent._ClassPtr;
		}

		// Token: 0x0601583F RID: 88127 RVA: 0x001F9DB8 File Offset: 0x001F7FB8
		public UKuroSceneItemGuidePathComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneItemGuidePathComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015840 RID: 88128 RVA: 0x001F9DE0 File Offset: 0x001F7FE0
		[NullableContext(1)]
		public UKuroSceneItemGuidePathComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneItemGuidePathComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054F5 RID: 21749
		// (get) Token: 0x06015841 RID: 88129 RVA: 0x001F9E13 File Offset: 0x001F8013
		// (set) Token: 0x06015842 RID: 88130 RVA: 0x001F9E23 File Offset: 0x001F8023
		public unsafe bool HasFinishTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneItemGuidePathComponent.__PropertyOffset_HasFinishTag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneItemGuidePathComponent.__PropertyOffset_HasFinishTag) = (value ? 1 : 0);
			}
		}

		// Token: 0x170054F6 RID: 21750
		// (get) Token: 0x06015843 RID: 88131 RVA: 0x001F9E34 File Offset: 0x001F8034
		// (set) Token: 0x06015844 RID: 88132 RVA: 0x001F9E44 File Offset: 0x001F8044
		public unsafe bool HasActiveTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneItemGuidePathComponent.__PropertyOffset_HasActiveTag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneItemGuidePathComponent.__PropertyOffset_HasActiveTag) = (value ? 1 : 0);
			}
		}

		// Token: 0x170054F7 RID: 21751
		// (get) Token: 0x06015845 RID: 88133 RVA: 0x001F9E55 File Offset: 0x001F8055
		// (set) Token: 0x06015846 RID: 88134 RVA: 0x001F9E69 File Offset: 0x001F8069
		[Nullable(2)]
		public unsafe UNiagaraComponent NiagaraComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSceneItemGuidePathComponent.__PropertyOffset_NiagaraComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSceneItemGuidePathComponent.__PropertyOffset_NiagaraComponent, value);
			}
		}

		// Token: 0x06015847 RID: 88135 RVA: 0x001F9E80 File Offset: 0x001F8080
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void StartTick(FLinearColor Normal, FLinearColor ChangeCoefficient, FLinearColor Finish, FName ParameterName, float TotalCountDown, float CurCountDown)
		{
			UKuroSceneItemGuidePathComponent.__StartTick_FunctionParams* ptr = stackalloc UKuroSceneItemGuidePathComponent.__StartTick_FunctionParams[(UIntPtr)83] + 15L / (long)sizeof(UKuroSceneItemGuidePathComponent.__StartTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemGuidePathComponent.__StartTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Normal = Normal;
			ptr->ChangeCoefficient = ChangeCoefficient;
			ptr->Finish = Finish;
			ptr->ParameterName = ParameterName;
			ptr->TotalCountDown = TotalCountDown;
			ptr->CurCountDown = CurCountDown;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemGuidePathComponent.__StartTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06015848 RID: 88136 RVA: 0x001F9EED File Offset: 0x001F80ED
		static UKuroSceneItemGuidePathComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroSceneItemGuidePathComponent");
		}

		// Token: 0x06015849 RID: 88137 RVA: 0x001F9EFB File Offset: 0x001F80FB
		protected UKuroSceneItemGuidePathComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BBD1 RID: 48081
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroSceneItemGuidePathComponent";

		// Token: 0x0400BBD2 RID: 48082
		private static IntPtr _ClassPtr;

		// Token: 0x0400BBD3 RID: 48083
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BBD4 RID: 48084
		internal static int __PropertyOffset_HasFinishTag;

		// Token: 0x0400BBD5 RID: 48085
		internal static int __PropertyOffset_HasActiveTag;

		// Token: 0x0400BBD6 RID: 48086
		internal static int __PropertyOffset_NiagaraComponent;

		// Token: 0x0400BBD7 RID: 48087
		private static IntPtr __StartTick_NativeFunctionPtr;

		// Token: 0x02002F0A RID: 12042
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 68)]
		protected ref struct __StartTick_FunctionParams
		{
			// Token: 0x04016A4E RID: 92750
			[FieldOffset(0)]
			public FLinearColor Normal;

			// Token: 0x04016A4F RID: 92751
			[FieldOffset(16)]
			public FLinearColor ChangeCoefficient;

			// Token: 0x04016A50 RID: 92752
			[FieldOffset(32)]
			public FLinearColor Finish;

			// Token: 0x04016A51 RID: 92753
			[FieldOffset(48)]
			public FName ParameterName;

			// Token: 0x04016A52 RID: 92754
			[FieldOffset(60)]
			public float TotalCountDown;

			// Token: 0x04016A53 RID: 92755
			[FieldOffset(64)]
			public float CurCountDown;
		}
	}
}
