using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017EF RID: 6127
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiManagerProxyActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class AKuroCrowdAiManagerProxyActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016A4B RID: 92747 RVA: 0x00210790 File Offset: 0x0020E990
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCrowdAiManagerProxyActor._ClassPtr;
		}

		// Token: 0x06016A4C RID: 92748 RVA: 0x0021079C File Offset: 0x0020E99C
		public AKuroCrowdAiManagerProxyActor() : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiManagerProxyActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016A4D RID: 92749 RVA: 0x002107C4 File Offset: 0x0020E9C4
		[NullableContext(1)]
		public AKuroCrowdAiManagerProxyActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiManagerProxyActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B8D RID: 23437
		// (get) Token: 0x06016A4E RID: 92750 RVA: 0x002107F7 File Offset: 0x0020E9F7
		// (set) Token: 0x06016A4F RID: 92751 RVA: 0x0021080B File Offset: 0x0020EA0B
		[Nullable(2)]
		public unsafe USceneComponent RootSceneComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCrowdAiManagerProxyActor.__PropertyOffset_RootSceneComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCrowdAiManagerProxyActor.__PropertyOffset_RootSceneComponent, value);
			}
		}

		// Token: 0x17005B8E RID: 23438
		// (get) Token: 0x06016A50 RID: 92752 RVA: 0x00210820 File Offset: 0x0020EA20
		// (set) Token: 0x06016A51 RID: 92753 RVA: 0x00210830 File Offset: 0x0020EA30
		public unsafe int MaxSimulationIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiManagerProxyActor.__PropertyOffset_MaxSimulationIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiManagerProxyActor.__PropertyOffset_MaxSimulationIterations) = value;
			}
		}

		// Token: 0x17005B8F RID: 23439
		// (get) Token: 0x06016A52 RID: 92754 RVA: 0x00210841 File Offset: 0x0020EA41
		// (set) Token: 0x06016A53 RID: 92755 RVA: 0x00210851 File Offset: 0x0020EA51
		public unsafe float MaxSimulationTimeStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiManagerProxyActor.__PropertyOffset_MaxSimulationTimeStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiManagerProxyActor.__PropertyOffset_MaxSimulationTimeStep) = value;
			}
		}

		// Token: 0x06016A54 RID: 92756 RVA: 0x00210864 File Offset: 0x0020EA64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnableParallelUpdate(bool bEnable)
		{
			AKuroCrowdAiManagerProxyActor.__SetEnableParallelUpdate_FunctionParams* ptr = stackalloc AKuroCrowdAiManagerProxyActor.__SetEnableParallelUpdate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AKuroCrowdAiManagerProxyActor.__SetEnableParallelUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroCrowdAiManagerProxyActor.__SetEnableParallelUpdate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroCrowdAiManagerProxyActor.__SetEnableParallelUpdate_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06016A55 RID: 92757 RVA: 0x002108AB File Offset: 0x0020EAAB
		static AKuroCrowdAiManagerProxyActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCrowdAi.KuroCrowdAiManagerProxyActor");
		}

		// Token: 0x06016A56 RID: 92758 RVA: 0x002108B9 File Offset: 0x0020EAB9
		protected AKuroCrowdAiManagerProxyActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C4B6 RID: 50358
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiManagerProxyActor";

		// Token: 0x0400C4B7 RID: 50359
		private static IntPtr _ClassPtr;

		// Token: 0x0400C4B8 RID: 50360
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C4B9 RID: 50361
		internal static int __PropertyOffset_RootSceneComponent;

		// Token: 0x0400C4BA RID: 50362
		internal static int __PropertyOffset_MaxSimulationIterations;

		// Token: 0x0400C4BB RID: 50363
		internal static int __PropertyOffset_MaxSimulationTimeStep;

		// Token: 0x0400C4BC RID: 50364
		private static IntPtr __SetEnableParallelUpdate_NativeFunctionPtr;

		// Token: 0x02002F34 RID: 12084
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnableParallelUpdate_FunctionParams
		{
			// Token: 0x04016AB1 RID: 92849
			[FieldOffset(0)]
			public bool bEnable;
		}
	}
}
