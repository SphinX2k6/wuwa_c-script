using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012D1 RID: 4817
	[UnrealObjectPath("/Script/Foliage.InteractiveFoliageActor")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1152)]
	public class AInteractiveFoliageActor : AStaticMeshActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011AAF RID: 72367 RVA: 0x0019F140 File Offset: 0x0019D340
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AInteractiveFoliageActor._ClassPtr;
		}

		// Token: 0x06011AB0 RID: 72368 RVA: 0x0019F14C File Offset: 0x0019D34C
		public AInteractiveFoliageActor() : this(BuiltinUtils.AllocNativeUObject(AInteractiveFoliageActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011AB1 RID: 72369 RVA: 0x0019F174 File Offset: 0x0019D374
		[NullableContext(1)]
		public AInteractiveFoliageActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AInteractiveFoliageActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004521 RID: 17697
		// (get) Token: 0x06011AB2 RID: 72370 RVA: 0x0019F1A7 File Offset: 0x0019D3A7
		// (set) Token: 0x06011AB3 RID: 72371 RVA: 0x0019F1BB File Offset: 0x0019D3BB
		[Nullable(2)]
		public unsafe UCapsuleComponent CapsuleComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AInteractiveFoliageActor.__PropertyOffset_CapsuleComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AInteractiveFoliageActor.__PropertyOffset_CapsuleComponent, value);
			}
		}

		// Token: 0x17004522 RID: 17698
		// (get) Token: 0x06011AB4 RID: 72372 RVA: 0x0019F1D0 File Offset: 0x0019D3D0
		// (set) Token: 0x06011AB5 RID: 72373 RVA: 0x0019F1E4 File Offset: 0x0019D3E4
		public unsafe FVector TouchingActorEntryPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_TouchingActorEntryPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_TouchingActorEntryPosition) = value;
			}
		}

		// Token: 0x17004523 RID: 17699
		// (get) Token: 0x06011AB6 RID: 72374 RVA: 0x0019F1F9 File Offset: 0x0019D3F9
		// (set) Token: 0x06011AB7 RID: 72375 RVA: 0x0019F20D File Offset: 0x0019D40D
		public unsafe FVector FoliageVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliageVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliageVelocity) = value;
			}
		}

		// Token: 0x17004524 RID: 17700
		// (get) Token: 0x06011AB8 RID: 72376 RVA: 0x0019F222 File Offset: 0x0019D422
		// (set) Token: 0x06011AB9 RID: 72377 RVA: 0x0019F236 File Offset: 0x0019D436
		public unsafe FVector FoliageForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliageForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliageForce) = value;
			}
		}

		// Token: 0x17004525 RID: 17701
		// (get) Token: 0x06011ABA RID: 72378 RVA: 0x0019F24B File Offset: 0x0019D44B
		// (set) Token: 0x06011ABB RID: 72379 RVA: 0x0019F25F File Offset: 0x0019D45F
		public unsafe FVector FoliagePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliagePosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliagePosition) = value;
			}
		}

		// Token: 0x17004526 RID: 17702
		// (get) Token: 0x06011ABC RID: 72380 RVA: 0x0019F274 File Offset: 0x0019D474
		// (set) Token: 0x06011ABD RID: 72381 RVA: 0x0019F284 File Offset: 0x0019D484
		public unsafe float FoliageDamageImpulseScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliageDamageImpulseScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliageDamageImpulseScale) = value;
			}
		}

		// Token: 0x17004527 RID: 17703
		// (get) Token: 0x06011ABE RID: 72382 RVA: 0x0019F295 File Offset: 0x0019D495
		// (set) Token: 0x06011ABF RID: 72383 RVA: 0x0019F2A5 File Offset: 0x0019D4A5
		public unsafe float FoliageTouchImpulseScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliageTouchImpulseScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliageTouchImpulseScale) = value;
			}
		}

		// Token: 0x17004528 RID: 17704
		// (get) Token: 0x06011AC0 RID: 72384 RVA: 0x0019F2B6 File Offset: 0x0019D4B6
		// (set) Token: 0x06011AC1 RID: 72385 RVA: 0x0019F2C6 File Offset: 0x0019D4C6
		public unsafe float FoliageStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliageStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliageStiffness) = value;
			}
		}

		// Token: 0x17004529 RID: 17705
		// (get) Token: 0x06011AC2 RID: 72386 RVA: 0x0019F2D7 File Offset: 0x0019D4D7
		// (set) Token: 0x06011AC3 RID: 72387 RVA: 0x0019F2E7 File Offset: 0x0019D4E7
		public unsafe float FoliageStiffnessQuadratic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliageStiffnessQuadratic);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliageStiffnessQuadratic) = value;
			}
		}

		// Token: 0x1700452A RID: 17706
		// (get) Token: 0x06011AC4 RID: 72388 RVA: 0x0019F2F8 File Offset: 0x0019D4F8
		// (set) Token: 0x06011AC5 RID: 72389 RVA: 0x0019F308 File Offset: 0x0019D508
		public unsafe float FoliageDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliageDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_FoliageDamping) = value;
			}
		}

		// Token: 0x1700452B RID: 17707
		// (get) Token: 0x06011AC6 RID: 72390 RVA: 0x0019F319 File Offset: 0x0019D519
		// (set) Token: 0x06011AC7 RID: 72391 RVA: 0x0019F329 File Offset: 0x0019D529
		public unsafe float MaxDamageImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_MaxDamageImpulse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_MaxDamageImpulse) = value;
			}
		}

		// Token: 0x1700452C RID: 17708
		// (get) Token: 0x06011AC8 RID: 72392 RVA: 0x0019F33A File Offset: 0x0019D53A
		// (set) Token: 0x06011AC9 RID: 72393 RVA: 0x0019F34A File Offset: 0x0019D54A
		public unsafe float MaxTouchImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_MaxTouchImpulse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_MaxTouchImpulse) = value;
			}
		}

		// Token: 0x1700452D RID: 17709
		// (get) Token: 0x06011ACA RID: 72394 RVA: 0x0019F35B File Offset: 0x0019D55B
		// (set) Token: 0x06011ACB RID: 72395 RVA: 0x0019F36B File Offset: 0x0019D56B
		public unsafe float MaxForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_MaxForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_MaxForce) = value;
			}
		}

		// Token: 0x1700452E RID: 17710
		// (get) Token: 0x06011ACC RID: 72396 RVA: 0x0019F37C File Offset: 0x0019D57C
		// (set) Token: 0x06011ACD RID: 72397 RVA: 0x0019F38C File Offset: 0x0019D58C
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_Mass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AInteractiveFoliageActor.__PropertyOffset_Mass) = value;
			}
		}

		// Token: 0x06011ACE RID: 72398 RVA: 0x0019F3A0 File Offset: 0x0019D5A0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void CapsuleTouched(UPrimitiveComponent OverlappedComp, AActor Other, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult OverlapInfo)
		{
			AInteractiveFoliageActor.__CapsuleTouched_FunctionParams* ptr = stackalloc AInteractiveFoliageActor.__CapsuleTouched_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(AInteractiveFoliageActor.__CapsuleTouched_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AInteractiveFoliageActor.__CapsuleTouched_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComp = ((OverlappedComp != null) ? OverlappedComp.NativePtr : IntPtr.Zero);
			ptr->Other = ((Other != null) ? Other.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (OverlapInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->OverlapInfo, OverlapInfo.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AInteractiveFoliageActor.__CapsuleTouched_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06011ACF RID: 72399 RVA: 0x0019F45B File Offset: 0x0019D65B
		static AInteractiveFoliageActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Foliage.InteractiveFoliageActor");
		}

		// Token: 0x06011AD0 RID: 72400 RVA: 0x0019F469 File Offset: 0x0019D669
		protected AInteractiveFoliageActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040097A4 RID: 38820
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Foliage.InteractiveFoliageActor";

		// Token: 0x040097A5 RID: 38821
		private static IntPtr _ClassPtr;

		// Token: 0x040097A6 RID: 38822
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040097A7 RID: 38823
		internal static int __PropertyOffset_CapsuleComponent;

		// Token: 0x040097A8 RID: 38824
		internal static int __PropertyOffset_TouchingActorEntryPosition;

		// Token: 0x040097A9 RID: 38825
		internal static int __PropertyOffset_FoliageVelocity;

		// Token: 0x040097AA RID: 38826
		internal static int __PropertyOffset_FoliageForce;

		// Token: 0x040097AB RID: 38827
		internal static int __PropertyOffset_FoliagePosition;

		// Token: 0x040097AC RID: 38828
		internal static int __PropertyOffset_FoliageDamageImpulseScale;

		// Token: 0x040097AD RID: 38829
		internal static int __PropertyOffset_FoliageTouchImpulseScale;

		// Token: 0x040097AE RID: 38830
		internal static int __PropertyOffset_FoliageStiffness;

		// Token: 0x040097AF RID: 38831
		internal static int __PropertyOffset_FoliageStiffnessQuadratic;

		// Token: 0x040097B0 RID: 38832
		internal static int __PropertyOffset_FoliageDamping;

		// Token: 0x040097B1 RID: 38833
		internal static int __PropertyOffset_MaxDamageImpulse;

		// Token: 0x040097B2 RID: 38834
		internal static int __PropertyOffset_MaxTouchImpulse;

		// Token: 0x040097B3 RID: 38835
		internal static int __PropertyOffset_MaxForce;

		// Token: 0x040097B4 RID: 38836
		internal static int __PropertyOffset_Mass;

		// Token: 0x040097B5 RID: 38837
		private static IntPtr __CapsuleTouched_NativeFunctionPtr;

		// Token: 0x02002E1F RID: 11807
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __CapsuleTouched_FunctionParams
		{
			// Token: 0x040168AF RID: 92335
			[FieldOffset(0)]
			public IntPtr OverlappedComp;

			// Token: 0x040168B0 RID: 92336
			[FieldOffset(8)]
			public IntPtr Other;

			// Token: 0x040168B1 RID: 92337
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040168B2 RID: 92338
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040168B3 RID: 92339
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040168B4 RID: 92340
			[FieldOffset(32)]
			public byte OverlapInfo;
		}
	}
}
