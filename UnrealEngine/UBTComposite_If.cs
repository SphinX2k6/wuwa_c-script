using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015F1 RID: 5617
	[UnrealObjectPath("/Script/KuroAI.BTComposite_If")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public abstract class UBTComposite_If : UBTCompositeNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060143BD RID: 82877 RVA: 0x001DB5CC File Offset: 0x001D97CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTComposite_If._ClassPtr;
		}

		// Token: 0x060143BE RID: 82878 RVA: 0x001DB5D8 File Offset: 0x001D97D8
		[NullableContext(2)]
		public virtual bool PerformConditionCheckAI(AAIController OwnerController, APawn ControlledPawn)
		{
			return UBTComposite_If.__PerformConditionCheckAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060143BF RID: 82879 RVA: 0x001DB605 File Offset: 0x001D9805
		[NullableContext(2)]
		protected virtual bool PerformConditionCheckAI_Implementation(AAIController OwnerController, APawn ControlledPawn)
		{
			return UBTComposite_If.__PerformConditionCheckAI_Implementation_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060143C0 RID: 82880 RVA: 0x001DB632 File Offset: 0x001D9832
		[NullableContext(2)]
		public virtual bool PerformConditionCheck(AActor OwnerActor)
		{
			return UBTComposite_If.__PerformConditionCheck_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060143C1 RID: 82881 RVA: 0x001DB64F File Offset: 0x001D984F
		[NullableContext(2)]
		protected virtual bool PerformConditionCheck_Implementation(AActor OwnerActor)
		{
			return UBTComposite_If.__PerformConditionCheck_Implementation_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060143C2 RID: 82882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PerformConditionCheckAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x060143C3 RID: 82883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PerformConditionCheckAI_Implementation_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x060143C4 RID: 82884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PerformConditionCheck_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x060143C5 RID: 82885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PerformConditionCheck_Implementation_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x060143C6 RID: 82886 RVA: 0x001DB66C File Offset: 0x001D986C
		static UBTComposite_If()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAI.BTComposite_If");
		}

		// Token: 0x060143C7 RID: 82887 RVA: 0x001DB67C File Offset: 0x001D987C
		protected UBTComposite_If() : this(BuiltinUtils.AllocNativeUObject(UBTComposite_If.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060143C8 RID: 82888 RVA: 0x001DB6A4 File Offset: 0x001D98A4
		protected UBTComposite_If(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B01F RID: 45087
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAI.BTComposite_If";

		// Token: 0x0400B020 RID: 45088
		private static IntPtr _ClassPtr;

		// Token: 0x0400B021 RID: 45089
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x02002ECB RID: 11979
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __PerformConditionCheckAI_FunctionParams
		{
			// Token: 0x040169D0 RID: 92624
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040169D1 RID: 92625
			[FieldOffset(8)]
			public IntPtr ControlledPawn;

			// Token: 0x040169D2 RID: 92626
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02002ECC RID: 11980
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __PerformConditionCheck_FunctionParams
		{
			// Token: 0x040169D3 RID: 92627
			[FieldOffset(0)]
			public IntPtr OwnerActor;

			// Token: 0x040169D4 RID: 92628
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
