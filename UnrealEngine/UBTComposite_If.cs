using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002D7 RID: 727
	[UnrealObjectPath("/Script/KuroAI.BTComposite_If")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public abstract class UBTComposite_If : UBTCompositeNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004EA5 RID: 20133 RVA: 0x0006DE0E File Offset: 0x0006C00E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTComposite_If._ClassPtr;
		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x0006DE1A File Offset: 0x0006C01A
		[NullableContext(2)]
		public virtual bool PerformConditionCheckAI(AAIController OwnerController, APawn ControlledPawn)
		{
			return UBTComposite_If.__PerformConditionCheckAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06004EA7 RID: 20135 RVA: 0x0006DE47 File Offset: 0x0006C047
		[NullableContext(2)]
		protected virtual bool PerformConditionCheckAI_Implementation(AAIController OwnerController, APawn ControlledPawn)
		{
			return UBTComposite_If.__PerformConditionCheckAI_Implementation_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x0006DE74 File Offset: 0x0006C074
		[NullableContext(2)]
		public virtual bool PerformConditionCheck(AActor OwnerActor)
		{
			return UBTComposite_If.__PerformConditionCheck_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06004EA9 RID: 20137 RVA: 0x0006DE91 File Offset: 0x0006C091
		[NullableContext(2)]
		protected virtual bool PerformConditionCheck_Implementation(AActor OwnerActor)
		{
			return UBTComposite_If.__PerformConditionCheck_Implementation_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06004EAA RID: 20138
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PerformConditionCheckAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06004EAB RID: 20139
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PerformConditionCheckAI_Implementation_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06004EAC RID: 20140
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PerformConditionCheck_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06004EAD RID: 20141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PerformConditionCheck_Implementation_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06004EAE RID: 20142 RVA: 0x0006DEAE File Offset: 0x0006C0AE
		static UBTComposite_If()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAI.BTComposite_If");
		}

		// Token: 0x06004EAF RID: 20143 RVA: 0x0006DEBC File Offset: 0x0006C0BC
		protected UBTComposite_If() : this(BuiltinUtils.AllocNativeUObject(UBTComposite_If.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004EB0 RID: 20144 RVA: 0x0006DEE4 File Offset: 0x0006C0E4
		protected UBTComposite_If(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F72 RID: 8050
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAI.BTComposite_If";

		// Token: 0x04001F73 RID: 8051
		private static IntPtr _ClassPtr;

		// Token: 0x04001F74 RID: 8052
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x02000A04 RID: 2564
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __PerformConditionCheckAI_FunctionParams
		{
			// Token: 0x040059AB RID: 22955
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040059AC RID: 22956
			[FieldOffset(8)]
			public IntPtr ControlledPawn;

			// Token: 0x040059AD RID: 22957
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000A05 RID: 2565
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __PerformConditionCheck_FunctionParams
		{
			// Token: 0x040059AE RID: 22958
			[FieldOffset(0)]
			public IntPtr OwnerActor;

			// Token: 0x040059AF RID: 22959
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
