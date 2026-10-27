using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001914 RID: 6420
	[UnrealObjectPath("/Script/KuroGameplay.KuroSplineVolumeGenerator")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class AKuroSplineVolumeGenerator : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017D2F RID: 97583 RVA: 0x0022E47C File Offset: 0x0022C67C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSplineVolumeGenerator._ClassPtr;
		}

		// Token: 0x06017D30 RID: 97584 RVA: 0x0022E488 File Offset: 0x0022C688
		public AKuroSplineVolumeGenerator() : this(BuiltinUtils.AllocNativeUObject(AKuroSplineVolumeGenerator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017D31 RID: 97585 RVA: 0x0022E4B0 File Offset: 0x0022C6B0
		[NullableContext(1)]
		public AKuroSplineVolumeGenerator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSplineVolumeGenerator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017D32 RID: 97586 RVA: 0x0022E4E3 File Offset: 0x0022C6E3
		[NullableContext(2)]
		public void GeneratePolyhedron(USplineComponent InSplineComponent, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<ABrush> InVolumeClass, float LowerBoundsHeight, float UpperBoundsHeight)
		{
			AKuroSplineVolumeGenerator.__GeneratePolyhedron_Internal(base.NativePtr, (InSplineComponent != null) ? InSplineComponent.NativePtr : IntPtr.Zero, InVolumeClass._NativePtr, LowerBoundsHeight, UpperBoundsHeight);
		}

		// Token: 0x06017D33 RID: 97587 RVA: 0x0022E509 File Offset: 0x0022C709
		[NullableContext(2)]
		public void Generate(USplineComponent InSplineComponent, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<ABrush> InVolumeClass, UKuroSplineVolumeBuilder InSplineVolumeBuilder)
		{
			AKuroSplineVolumeGenerator.__Generate_Internal(base.NativePtr, (InSplineComponent != null) ? InSplineComponent.NativePtr : IntPtr.Zero, InVolumeClass._NativePtr, (InSplineVolumeBuilder != null) ? InSplineVolumeBuilder.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017D34 RID: 97588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GeneratePolyhedron_Internal(IntPtr @this, IntPtr InSplineComponent, IntPtr InVolumeClass, float LowerBoundsHeight, float UpperBoundsHeight);

		// Token: 0x06017D35 RID: 97589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Generate_Internal(IntPtr @this, IntPtr InSplineComponent, IntPtr InVolumeClass, IntPtr InSplineVolumeBuilder);

		// Token: 0x06017D36 RID: 97590 RVA: 0x0022E53C File Offset: 0x0022C73C
		static AKuroSplineVolumeGenerator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroSplineVolumeGenerator");
		}

		// Token: 0x06017D37 RID: 97591 RVA: 0x0022E54A File Offset: 0x0022C74A
		protected AKuroSplineVolumeGenerator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE9D RID: 52893
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroSplineVolumeGenerator";

		// Token: 0x0400CE9E RID: 52894
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE9F RID: 52895
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
