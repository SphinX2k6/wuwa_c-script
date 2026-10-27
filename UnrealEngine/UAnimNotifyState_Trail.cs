using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200082D RID: 2093
	[UnrealObjectPath("/Script/Engine.AnimNotifyState_Trail")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UAnimNotifyState_Trail : UAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060070B2 RID: 28850 RVA: 0x000A192F File Offset: 0x0009FB2F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotifyState_Trail._ClassPtr;
		}

		// Token: 0x060070B3 RID: 28851 RVA: 0x000A193C File Offset: 0x0009FB3C
		public UAnimNotifyState_Trail() : this(BuiltinUtils.AllocNativeUObject(UAnimNotifyState_Trail.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060070B4 RID: 28852 RVA: 0x000A1964 File Offset: 0x0009FB64
		[NullableContext(1)]
		public UAnimNotifyState_Trail(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimNotifyState_Trail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x060070B5 RID: 28853 RVA: 0x000A1997 File Offset: 0x0009FB97
		// (set) Token: 0x060070B6 RID: 28854 RVA: 0x000A19AB File Offset: 0x0009FBAB
		[Nullable(2)]
		public unsafe UParticleSystem PSTemplate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimNotifyState_Trail.__PropertyOffset_PSTemplate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimNotifyState_Trail.__PropertyOffset_PSTemplate, value);
			}
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x060070B7 RID: 28855 RVA: 0x000A19C0 File Offset: 0x0009FBC0
		// (set) Token: 0x060070B8 RID: 28856 RVA: 0x000A19D4 File Offset: 0x0009FBD4
		public unsafe FName FirstSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState_Trail.__PropertyOffset_FirstSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState_Trail.__PropertyOffset_FirstSocketName) = value;
			}
		}

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x060070B9 RID: 28857 RVA: 0x000A19E9 File Offset: 0x0009FBE9
		// (set) Token: 0x060070BA RID: 28858 RVA: 0x000A19FD File Offset: 0x0009FBFD
		public unsafe FName SecondSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState_Trail.__PropertyOffset_SecondSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState_Trail.__PropertyOffset_SecondSocketName) = value;
			}
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x060070BB RID: 28859 RVA: 0x000A1A12 File Offset: 0x0009FC12
		// (set) Token: 0x060070BC RID: 28860 RVA: 0x000A1A26 File Offset: 0x0009FC26
		public unsafe TEnumAsByte<ETrailWidthMode> WidthScaleMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState_Trail.__PropertyOffset_WidthScaleMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState_Trail.__PropertyOffset_WidthScaleMode) = value;
			}
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x060070BD RID: 28861 RVA: 0x000A1A3B File Offset: 0x0009FC3B
		// (set) Token: 0x060070BE RID: 28862 RVA: 0x000A1A4F File Offset: 0x0009FC4F
		public unsafe FName WidthScaleCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState_Trail.__PropertyOffset_WidthScaleCurve);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState_Trail.__PropertyOffset_WidthScaleCurve) = value;
			}
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x060070BF RID: 28863 RVA: 0x000A1A64 File Offset: 0x0009FC64
		// (set) Token: 0x060070C0 RID: 28864 RVA: 0x000A1A7D File Offset: 0x0009FC7D
		public unsafe bool bRecycleSpawnedSystems
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimNotifyState_Trail.__PropertyOffset_bRecycleSpawnedSystems) & UAnimNotifyState_Trail.__PropertyMask_bRecycleSpawnedSystems) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimNotifyState_Trail.__PropertyOffset_bRecycleSpawnedSystems) = ((*(base.NativePtr + (IntPtr)UAnimNotifyState_Trail.__PropertyOffset_bRecycleSpawnedSystems) & ~UAnimNotifyState_Trail.__PropertyMask_bRecycleSpawnedSystems) | (value ? UAnimNotifyState_Trail.__PropertyMask_bRecycleSpawnedSystems : 0));
			}
		}

		// Token: 0x060070C1 RID: 28865 RVA: 0x000A1AAD File Offset: 0x0009FCAD
		[NullableContext(2)]
		public virtual UParticleSystem OverridePSTemplate(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UParticleSystem>(UAnimNotifyState_Trail.__OverridePSTemplate_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060070C2 RID: 28866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OverridePSTemplate_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x060070C3 RID: 28867 RVA: 0x000A1ADF File Offset: 0x0009FCDF
		static UAnimNotifyState_Trail()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimNotifyState_Trail");
		}

		// Token: 0x060070C4 RID: 28868 RVA: 0x000A1AED File Offset: 0x0009FCED
		protected UAnimNotifyState_Trail(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003617 RID: 13847
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNotifyState_Trail";

		// Token: 0x04003618 RID: 13848
		private static IntPtr _ClassPtr;

		// Token: 0x04003619 RID: 13849
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400361A RID: 13850
		internal static int __PropertyOffset_PSTemplate;

		// Token: 0x0400361B RID: 13851
		internal static int __PropertyOffset_FirstSocketName;

		// Token: 0x0400361C RID: 13852
		internal static int __PropertyOffset_SecondSocketName;

		// Token: 0x0400361D RID: 13853
		internal static int __PropertyOffset_WidthScaleMode;

		// Token: 0x0400361E RID: 13854
		internal static int __PropertyOffset_WidthScaleCurve;

		// Token: 0x0400361F RID: 13855
		internal static int __PropertyOffset_bRecycleSpawnedSystems;

		// Token: 0x04003620 RID: 13856
		internal static byte __PropertyMask_bRecycleSpawnedSystems;

		// Token: 0x02002C8B RID: 11403
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OverridePSTemplate_FunctionParams
		{
			// Token: 0x040165CE RID: 91598
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x040165CF RID: 91599
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x040165D0 RID: 91600
			[FieldOffset(16)]
			public IntPtr __Result;
		}
	}
}
