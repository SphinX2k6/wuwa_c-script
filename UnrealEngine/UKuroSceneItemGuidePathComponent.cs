using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200034B RID: 843
	[UnrealObjectPath("/Script/KuroComponent.KuroSceneItemGuidePathComponent")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UKuroSceneItemGuidePathComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005654 RID: 22100 RVA: 0x0007903B File Offset: 0x0007723B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneItemGuidePathComponent._ClassPtr;
		}

		// Token: 0x06005655 RID: 22101 RVA: 0x00079048 File Offset: 0x00077248
		public UKuroSceneItemGuidePathComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneItemGuidePathComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x00079070 File Offset: 0x00077270
		[NullableContext(1)]
		public UKuroSceneItemGuidePathComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneItemGuidePathComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06005657 RID: 22103 RVA: 0x000790A3 File Offset: 0x000772A3
		// (set) Token: 0x06005658 RID: 22104 RVA: 0x000790B3 File Offset: 0x000772B3
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

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06005659 RID: 22105 RVA: 0x000790C4 File Offset: 0x000772C4
		// (set) Token: 0x0600565A RID: 22106 RVA: 0x000790D4 File Offset: 0x000772D4
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

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x0600565B RID: 22107 RVA: 0x000790E5 File Offset: 0x000772E5
		// (set) Token: 0x0600565C RID: 22108 RVA: 0x000790F9 File Offset: 0x000772F9
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

		// Token: 0x0600565D RID: 22109 RVA: 0x00079110 File Offset: 0x00077310
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemGuidePathComponent.__StartTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600565E RID: 22110 RVA: 0x0007917C File Offset: 0x0007737C
		static UKuroSceneItemGuidePathComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroSceneItemGuidePathComponent");
		}

		// Token: 0x0600565F RID: 22111 RVA: 0x0007918A File Offset: 0x0007738A
		protected UKuroSceneItemGuidePathComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400236B RID: 9067
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroSceneItemGuidePathComponent";

		// Token: 0x0400236C RID: 9068
		private static IntPtr _ClassPtr;

		// Token: 0x0400236D RID: 9069
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400236E RID: 9070
		internal static int __PropertyOffset_HasFinishTag;

		// Token: 0x0400236F RID: 9071
		internal static int __PropertyOffset_HasActiveTag;

		// Token: 0x04002370 RID: 9072
		internal static int __PropertyOffset_NiagaraComponent;

		// Token: 0x04002371 RID: 9073
		private static IntPtr __StartTick_NativeFunctionPtr;

		// Token: 0x02000A3F RID: 2623
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 68)]
		protected ref struct __StartTick_FunctionParams
		{
			// Token: 0x04005A22 RID: 23074
			[FieldOffset(0)]
			public FLinearColor Normal;

			// Token: 0x04005A23 RID: 23075
			[FieldOffset(16)]
			public FLinearColor ChangeCoefficient;

			// Token: 0x04005A24 RID: 23076
			[FieldOffset(32)]
			public FLinearColor Finish;

			// Token: 0x04005A25 RID: 23077
			[FieldOffset(48)]
			public FName ParameterName;

			// Token: 0x04005A26 RID: 23078
			[FieldOffset(60)]
			public float TotalCountDown;

			// Token: 0x04005A27 RID: 23079
			[FieldOffset(64)]
			public float CurCountDown;
		}
	}
}
