using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200035C RID: 860
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiManagerProxyActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class AKuroCrowdAiManagerProxyActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060057F3 RID: 22515 RVA: 0x0007BB90 File Offset: 0x00079D90
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCrowdAiManagerProxyActor._ClassPtr;
		}

		// Token: 0x060057F4 RID: 22516 RVA: 0x0007BB9C File Offset: 0x00079D9C
		public AKuroCrowdAiManagerProxyActor() : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiManagerProxyActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060057F5 RID: 22517 RVA: 0x0007BBC4 File Offset: 0x00079DC4
		[NullableContext(1)]
		public AKuroCrowdAiManagerProxyActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiManagerProxyActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x060057F6 RID: 22518 RVA: 0x0007BBF7 File Offset: 0x00079DF7
		// (set) Token: 0x060057F7 RID: 22519 RVA: 0x0007BC0B File Offset: 0x00079E0B
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

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x060057F8 RID: 22520 RVA: 0x0007BC20 File Offset: 0x00079E20
		// (set) Token: 0x060057F9 RID: 22521 RVA: 0x0007BC30 File Offset: 0x00079E30
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

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x060057FA RID: 22522 RVA: 0x0007BC41 File Offset: 0x00079E41
		// (set) Token: 0x060057FB RID: 22523 RVA: 0x0007BC51 File Offset: 0x00079E51
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

		// Token: 0x060057FC RID: 22524 RVA: 0x0007BC64 File Offset: 0x00079E64
		[SkipLocalsInit]
		public unsafe void SetEnableParallelUpdate(bool bEnable)
		{
			AKuroCrowdAiManagerProxyActor.__SetEnableParallelUpdate_FunctionParams* ptr = stackalloc AKuroCrowdAiManagerProxyActor.__SetEnableParallelUpdate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AKuroCrowdAiManagerProxyActor.__SetEnableParallelUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroCrowdAiManagerProxyActor.__SetEnableParallelUpdate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroCrowdAiManagerProxyActor.__SetEnableParallelUpdate_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060057FD RID: 22525 RVA: 0x0007BCAA File Offset: 0x00079EAA
		static AKuroCrowdAiManagerProxyActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCrowdAi.KuroCrowdAiManagerProxyActor");
		}

		// Token: 0x060057FE RID: 22526 RVA: 0x0007BCB8 File Offset: 0x00079EB8
		protected AKuroCrowdAiManagerProxyActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002443 RID: 9283
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiManagerProxyActor";

		// Token: 0x04002444 RID: 9284
		private static IntPtr _ClassPtr;

		// Token: 0x04002445 RID: 9285
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002446 RID: 9286
		internal static int __PropertyOffset_RootSceneComponent;

		// Token: 0x04002447 RID: 9287
		internal static int __PropertyOffset_MaxSimulationIterations;

		// Token: 0x04002448 RID: 9288
		internal static int __PropertyOffset_MaxSimulationTimeStep;

		// Token: 0x04002449 RID: 9289
		private static IntPtr __SetEnableParallelUpdate_NativeFunctionPtr;

		// Token: 0x02000A65 RID: 2661
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnableParallelUpdate_FunctionParams
		{
			// Token: 0x04005A80 RID: 23168
			[FieldOffset(0)]
			public bool bEnable;
		}
	}
}
