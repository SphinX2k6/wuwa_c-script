using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019E5 RID: 6629
	[UnrealObjectPath("/Script/KuroMovement.KuroMoveTrigger")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AKuroMoveTrigger : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601898C RID: 100748 RVA: 0x00243C07 File Offset: 0x00241E07
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroMoveTrigger._ClassPtr;
		}

		// Token: 0x0601898D RID: 100749 RVA: 0x00243C14 File Offset: 0x00241E14
		public AKuroMoveTrigger() : this(BuiltinUtils.AllocNativeUObject(AKuroMoveTrigger.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601898E RID: 100750 RVA: 0x00243C3C File Offset: 0x00241E3C
		[NullableContext(1)]
		public AKuroMoveTrigger(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroMoveTrigger.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061F2 RID: 25074
		// (get) Token: 0x0601898F RID: 100751 RVA: 0x00243C6F File Offset: 0x00241E6F
		// (set) Token: 0x06018990 RID: 100752 RVA: 0x00243C7F File Offset: 0x00241E7F
		public unsafe ETriggerAreaType AreaType
		{
			get
			{
				return (ETriggerAreaType)(*(base.NativePtr + (IntPtr)AKuroMoveTrigger.__PropertyOffset_AreaType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveTrigger.__PropertyOffset_AreaType) = (byte)value;
			}
		}

		// Token: 0x06018991 RID: 100753 RVA: 0x00243C90 File Offset: 0x00241E90
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnEnterOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			AKuroMoveTrigger.__OnEnterOverlap_FunctionParams* ptr = stackalloc AKuroMoveTrigger.__OnEnterOverlap_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(AKuroMoveTrigger.__OnEnterOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroMoveTrigger.__OnEnterOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroMoveTrigger.__OnEnterOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06018992 RID: 100754 RVA: 0x00243D4C File Offset: 0x00241F4C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			AKuroMoveTrigger.__OnEndOverlap_FunctionParams* ptr = stackalloc AKuroMoveTrigger.__OnEndOverlap_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(AKuroMoveTrigger.__OnEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroMoveTrigger.__OnEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroMoveTrigger.__OnEndOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06018993 RID: 100755 RVA: 0x00243DD6 File Offset: 0x00241FD6
		static AKuroMoveTrigger()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMovement.KuroMoveTrigger");
		}

		// Token: 0x06018994 RID: 100756 RVA: 0x00243DE4 File Offset: 0x00241FE4
		protected AKuroMoveTrigger(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D4B7 RID: 54455
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMovement.KuroMoveTrigger";

		// Token: 0x0400D4B8 RID: 54456
		private static IntPtr _ClassPtr;

		// Token: 0x0400D4B9 RID: 54457
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D4BA RID: 54458
		internal static int __PropertyOffset_AreaType;

		// Token: 0x0400D4BB RID: 54459
		private static IntPtr __OnEnterOverlap_NativeFunctionPtr;

		// Token: 0x0400D4BC RID: 54460
		private static IntPtr __OnEndOverlap_NativeFunctionPtr;

		// Token: 0x02003093 RID: 12435
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __OnEnterOverlap_FunctionParams
		{
			// Token: 0x04016DB1 RID: 93617
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04016DB2 RID: 93618
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04016DB3 RID: 93619
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04016DB4 RID: 93620
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04016DB5 RID: 93621
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04016DB6 RID: 93622
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02003094 RID: 12436
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnEndOverlap_FunctionParams
		{
			// Token: 0x04016DB7 RID: 93623
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04016DB8 RID: 93624
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04016DB9 RID: 93625
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04016DBA RID: 93626
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
