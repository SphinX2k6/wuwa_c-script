using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200108B RID: 4235
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RepRootMotionMontage")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FRepRootMotionMontage : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F1FE RID: 61950 RVA: 0x00167186 File Offset: 0x00165386
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRepRootMotionMontage._ScriptStructPtr != 0) ? FRepRootMotionMontage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RepRootMotionMontage", ref FRepRootMotionMontage._ScriptStructPtr);
		}

		// Token: 0x17003AE6 RID: 15078
		// (get) Token: 0x0600F1FF RID: 61951 RVA: 0x001671AA File Offset: 0x001653AA
		// (set) Token: 0x0600F200 RID: 61952 RVA: 0x001671BA File Offset: 0x001653BA
		public unsafe bool bIsActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_bIsActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_bIsActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003AE7 RID: 15079
		// (get) Token: 0x0600F201 RID: 61953 RVA: 0x001671CB File Offset: 0x001653CB
		// (set) Token: 0x0600F202 RID: 61954 RVA: 0x001671DF File Offset: 0x001653DF
		public unsafe UAnimMontage AnimMontage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + FRepRootMotionMontage.__PropertyOffset_AnimMontage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRepRootMotionMontage.__PropertyOffset_AnimMontage, value);
			}
		}

		// Token: 0x17003AE8 RID: 15080
		// (get) Token: 0x0600F203 RID: 61955 RVA: 0x001671F4 File Offset: 0x001653F4
		// (set) Token: 0x0600F204 RID: 61956 RVA: 0x00167204 File Offset: 0x00165404
		public unsafe float Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17003AE9 RID: 15081
		// (get) Token: 0x0600F205 RID: 61957 RVA: 0x00167215 File Offset: 0x00165415
		// (set) Token: 0x0600F206 RID: 61958 RVA: 0x00167229 File Offset: 0x00165429
		public unsafe FVector_NetQuantize100 Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17003AEA RID: 15082
		// (get) Token: 0x0600F207 RID: 61959 RVA: 0x0016723E File Offset: 0x0016543E
		// (set) Token: 0x0600F208 RID: 61960 RVA: 0x00167252 File Offset: 0x00165452
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17003AEB RID: 15083
		// (get) Token: 0x0600F209 RID: 61961 RVA: 0x00167267 File Offset: 0x00165467
		// (set) Token: 0x0600F20A RID: 61962 RVA: 0x0016727B File Offset: 0x0016547B
		public unsafe UPrimitiveComponent MovementBase
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FRepRootMotionMontage.__PropertyOffset_MovementBase);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRepRootMotionMontage.__PropertyOffset_MovementBase, value);
			}
		}

		// Token: 0x17003AEC RID: 15084
		// (get) Token: 0x0600F20B RID: 61963 RVA: 0x00167290 File Offset: 0x00165490
		// (set) Token: 0x0600F20C RID: 61964 RVA: 0x001672A4 File Offset: 0x001654A4
		public unsafe FName MovementBaseBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_MovementBaseBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_MovementBaseBoneName) = value;
			}
		}

		// Token: 0x17003AED RID: 15085
		// (get) Token: 0x0600F20D RID: 61965 RVA: 0x001672B9 File Offset: 0x001654B9
		// (set) Token: 0x0600F20E RID: 61966 RVA: 0x001672C9 File Offset: 0x001654C9
		public unsafe bool bRelativePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_bRelativePosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_bRelativePosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003AEE RID: 15086
		// (get) Token: 0x0600F20F RID: 61967 RVA: 0x001672DA File Offset: 0x001654DA
		// (set) Token: 0x0600F210 RID: 61968 RVA: 0x001672EA File Offset: 0x001654EA
		public unsafe bool bRelativeRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_bRelativeRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_bRelativeRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003AEF RID: 15087
		// (get) Token: 0x0600F211 RID: 61969 RVA: 0x001672FC File Offset: 0x001654FC
		// (set) Token: 0x0600F212 RID: 61970 RVA: 0x0016733F File Offset: 0x0016553F
		[Nullable(1)]
		public FRootMotionSourceGroup AuthoritativeRootMotion
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRootMotionSourceGroup result;
				if ((result = this._AuthoritativeRootMotion) == null)
				{
					result = (this._AuthoritativeRootMotion = new FRootMotionSourceGroup(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_AuthoritativeRootMotion, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRootMotionSourceGroup.StaticStruct(), base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_AuthoritativeRootMotion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AF0 RID: 15088
		// (get) Token: 0x0600F213 RID: 61971 RVA: 0x00167360 File Offset: 0x00165560
		// (set) Token: 0x0600F214 RID: 61972 RVA: 0x00167374 File Offset: 0x00165574
		public unsafe FVector_NetQuantize10 Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x17003AF1 RID: 15089
		// (get) Token: 0x0600F215 RID: 61973 RVA: 0x00167389 File Offset: 0x00165589
		// (set) Token: 0x0600F216 RID: 61974 RVA: 0x0016739D File Offset: 0x0016559D
		public unsafe FVector_NetQuantize10 LinearVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_LinearVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepRootMotionMontage.__PropertyOffset_LinearVelocity) = value;
			}
		}

		// Token: 0x0600F217 RID: 61975 RVA: 0x001673B2 File Offset: 0x001655B2
		public FRepRootMotionMontage()
		{
		}

		// Token: 0x0600F218 RID: 61976 RVA: 0x001673BC File Offset: 0x001655BC
		[NullableContext(1)]
		public FRepRootMotionMontage(bool bIsActive, UAnimMontage AnimMontage, float Position, FVector_NetQuantize100 Location, FRotator Rotation, UPrimitiveComponent MovementBase, FName MovementBaseBoneName, bool bRelativePosition, bool bRelativeRotation, FRootMotionSourceGroup AuthoritativeRootMotion, FVector_NetQuantize10 Acceleration, FVector_NetQuantize10 LinearVelocity)
		{
			this.bIsActive = bIsActive;
			this.AnimMontage = AnimMontage;
			this.Position = Position;
			this.Location = Location;
			this.Rotation = Rotation;
			this.MovementBase = MovementBase;
			this.MovementBaseBoneName = MovementBaseBoneName;
			this.bRelativePosition = bRelativePosition;
			this.bRelativeRotation = bRelativeRotation;
			this.AuthoritativeRootMotion = AuthoritativeRootMotion;
			this.Acceleration = Acceleration;
			this.LinearVelocity = LinearVelocity;
		}

		// Token: 0x0600F219 RID: 61977 RVA: 0x0016742C File Offset: 0x0016562C
		protected override IntPtr GetUStructPtr()
		{
			return FRepRootMotionMontage.StaticStruct();
		}

		// Token: 0x0600F21A RID: 61978 RVA: 0x00167438 File Offset: 0x00165638
		public FRepRootMotionMontage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F21B RID: 61979 RVA: 0x00167442 File Offset: 0x00165642
		public FRepRootMotionMontage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F21C RID: 61980 RVA: 0x0016744D File Offset: 0x0016564D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRepRootMotionMontage(Pointer, false, true);
		}

		// Token: 0x0600F21D RID: 61981 RVA: 0x00167457 File Offset: 0x00165657
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRepRootMotionMontage(Pointer, MemoryOwner);
		}

		// Token: 0x04008337 RID: 33591
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RepRootMotionMontage";

		// Token: 0x04008338 RID: 33592
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008339 RID: 33593
		internal static int __PropertyOffset_bIsActive;

		// Token: 0x0400833A RID: 33594
		internal static int __PropertyOffset_AnimMontage;

		// Token: 0x0400833B RID: 33595
		internal static int __PropertyOffset_Position;

		// Token: 0x0400833C RID: 33596
		internal static int __PropertyOffset_Location;

		// Token: 0x0400833D RID: 33597
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400833E RID: 33598
		internal static int __PropertyOffset_MovementBase;

		// Token: 0x0400833F RID: 33599
		internal static int __PropertyOffset_MovementBaseBoneName;

		// Token: 0x04008340 RID: 33600
		internal static int __PropertyOffset_bRelativePosition;

		// Token: 0x04008341 RID: 33601
		internal static int __PropertyOffset_bRelativeRotation;

		// Token: 0x04008342 RID: 33602
		internal static int __PropertyOffset_AuthoritativeRootMotion;

		// Token: 0x04008343 RID: 33603
		private FRootMotionSourceGroup _AuthoritativeRootMotion;

		// Token: 0x04008344 RID: 33604
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x04008345 RID: 33605
		internal static int __PropertyOffset_LinearVelocity;
	}
}
