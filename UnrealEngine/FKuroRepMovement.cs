using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D07 RID: 3335
	[UnrealObjectPath("/Script/Engine.KuroRepMovement")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FKuroRepMovement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B18C RID: 45452 RVA: 0x000FC07A File Offset: 0x000FA27A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRepMovement._ScriptStructPtr != 0) ? FKuroRepMovement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroRepMovement", ref FKuroRepMovement._ScriptStructPtr);
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x0600B18D RID: 45453 RVA: 0x000FC09E File Offset: 0x000FA29E
		// (set) Token: 0x0600B18E RID: 45454 RVA: 0x000FC0B2 File Offset: 0x000FA2B2
		public unsafe FVector LinearVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_LinearVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_LinearVelocity) = value;
			}
		}

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x0600B18F RID: 45455 RVA: 0x000FC0C7 File Offset: 0x000FA2C7
		// (set) Token: 0x0600B190 RID: 45456 RVA: 0x000FC0DB File Offset: 0x000FA2DB
		public unsafe FVector AngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_AngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_AngularVelocity) = value;
			}
		}

		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x0600B191 RID: 45457 RVA: 0x000FC0F0 File Offset: 0x000FA2F0
		// (set) Token: 0x0600B192 RID: 45458 RVA: 0x000FC104 File Offset: 0x000FA304
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17002844 RID: 10308
		// (get) Token: 0x0600B193 RID: 45459 RVA: 0x000FC119 File Offset: 0x000FA319
		// (set) Token: 0x0600B194 RID: 45460 RVA: 0x000FC12D File Offset: 0x000FA32D
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17002845 RID: 10309
		// (get) Token: 0x0600B195 RID: 45461 RVA: 0x000FC142 File Offset: 0x000FA342
		// (set) Token: 0x0600B196 RID: 45462 RVA: 0x000FC15B File Offset: 0x000FA35B
		public unsafe bool bSimulatedPhysicSleep
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_bSimulatedPhysicSleep) & FKuroRepMovement.__PropertyMask_bSimulatedPhysicSleep) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_bSimulatedPhysicSleep) = ((*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_bSimulatedPhysicSleep) & ~FKuroRepMovement.__PropertyMask_bSimulatedPhysicSleep) | (value ? FKuroRepMovement.__PropertyMask_bSimulatedPhysicSleep : 0));
			}
		}

		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x0600B197 RID: 45463 RVA: 0x000FC18B File Offset: 0x000FA38B
		// (set) Token: 0x0600B198 RID: 45464 RVA: 0x000FC1A4 File Offset: 0x000FA3A4
		public unsafe bool bRepPhysics
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_bRepPhysics) & FKuroRepMovement.__PropertyMask_bRepPhysics) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_bRepPhysics) = ((*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_bRepPhysics) & ~FKuroRepMovement.__PropertyMask_bRepPhysics) | (value ? FKuroRepMovement.__PropertyMask_bRepPhysics : 0));
			}
		}

		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x0600B199 RID: 45465 RVA: 0x000FC1D4 File Offset: 0x000FA3D4
		// (set) Token: 0x0600B19A RID: 45466 RVA: 0x000FC1ED File Offset: 0x000FA3ED
		public unsafe bool bResetMeshOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_bResetMeshOffset) & FKuroRepMovement.__PropertyMask_bResetMeshOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_bResetMeshOffset) = ((*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_bResetMeshOffset) & ~FKuroRepMovement.__PropertyMask_bResetMeshOffset) | (value ? FKuroRepMovement.__PropertyMask_bResetMeshOffset : 0));
			}
		}

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x0600B19B RID: 45467 RVA: 0x000FC21D File Offset: 0x000FA41D
		// (set) Token: 0x0600B19C RID: 45468 RVA: 0x000FC22D File Offset: 0x000FA42D
		public unsafe EVectorQuantization LocationQuantizationLevel
		{
			get
			{
				return (EVectorQuantization)(*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_LocationQuantizationLevel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_LocationQuantizationLevel) = (byte)value;
			}
		}

		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x0600B19D RID: 45469 RVA: 0x000FC23E File Offset: 0x000FA43E
		// (set) Token: 0x0600B19E RID: 45470 RVA: 0x000FC24E File Offset: 0x000FA44E
		public unsafe EVectorQuantization VelocityQuantizationLevel
		{
			get
			{
				return (EVectorQuantization)(*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_VelocityQuantizationLevel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_VelocityQuantizationLevel) = (byte)value;
			}
		}

		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x0600B19F RID: 45471 RVA: 0x000FC25F File Offset: 0x000FA45F
		// (set) Token: 0x0600B1A0 RID: 45472 RVA: 0x000FC26F File Offset: 0x000FA46F
		public unsafe ERotatorQuantization RotationQuantizationLevel
		{
			get
			{
				return (ERotatorQuantization)(*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_RotationQuantizationLevel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRepMovement.__PropertyOffset_RotationQuantizationLevel) = (byte)value;
			}
		}

		// Token: 0x0600B1A1 RID: 45473 RVA: 0x000FC280 File Offset: 0x000FA480
		public FKuroRepMovement()
		{
		}

		// Token: 0x0600B1A2 RID: 45474 RVA: 0x000FC288 File Offset: 0x000FA488
		public FKuroRepMovement(FVector LinearVelocity, FVector AngularVelocity, FVector Location, FRotator Rotation, bool bSimulatedPhysicSleep, bool bRepPhysics, bool bResetMeshOffset, EVectorQuantization LocationQuantizationLevel, EVectorQuantization VelocityQuantizationLevel, ERotatorQuantization RotationQuantizationLevel)
		{
			this.LinearVelocity = LinearVelocity;
			this.AngularVelocity = AngularVelocity;
			this.Location = Location;
			this.Rotation = Rotation;
			this.bSimulatedPhysicSleep = bSimulatedPhysicSleep;
			this.bRepPhysics = bRepPhysics;
			this.bResetMeshOffset = bResetMeshOffset;
			this.LocationQuantizationLevel = LocationQuantizationLevel;
			this.VelocityQuantizationLevel = VelocityQuantizationLevel;
			this.RotationQuantizationLevel = RotationQuantizationLevel;
		}

		// Token: 0x0600B1A3 RID: 45475 RVA: 0x000FC2E8 File Offset: 0x000FA4E8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRepMovement.StaticStruct();
		}

		// Token: 0x0600B1A4 RID: 45476 RVA: 0x000FC2F4 File Offset: 0x000FA4F4
		[NullableContext(2)]
		public FKuroRepMovement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B1A5 RID: 45477 RVA: 0x000FC2FE File Offset: 0x000FA4FE
		public FKuroRepMovement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B1A6 RID: 45478 RVA: 0x000FC309 File Offset: 0x000FA509
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRepMovement(Pointer, false, true);
		}

		// Token: 0x0600B1A7 RID: 45479 RVA: 0x000FC313 File Offset: 0x000FA513
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRepMovement(Pointer, MemoryOwner);
		}

		// Token: 0x04005CF8 RID: 23800
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KuroRepMovement";

		// Token: 0x04005CF9 RID: 23801
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005CFA RID: 23802
		internal static int __PropertyOffset_LinearVelocity;

		// Token: 0x04005CFB RID: 23803
		internal static int __PropertyOffset_AngularVelocity;

		// Token: 0x04005CFC RID: 23804
		internal static int __PropertyOffset_Location;

		// Token: 0x04005CFD RID: 23805
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04005CFE RID: 23806
		internal static int __PropertyOffset_bSimulatedPhysicSleep;

		// Token: 0x04005CFF RID: 23807
		internal static byte __PropertyMask_bSimulatedPhysicSleep;

		// Token: 0x04005D00 RID: 23808
		internal static int __PropertyOffset_bRepPhysics;

		// Token: 0x04005D01 RID: 23809
		internal static byte __PropertyMask_bRepPhysics;

		// Token: 0x04005D02 RID: 23810
		internal static int __PropertyOffset_bResetMeshOffset;

		// Token: 0x04005D03 RID: 23811
		internal static byte __PropertyMask_bResetMeshOffset;

		// Token: 0x04005D04 RID: 23812
		internal static int __PropertyOffset_LocationQuantizationLevel;

		// Token: 0x04005D05 RID: 23813
		internal static int __PropertyOffset_VelocityQuantizationLevel;

		// Token: 0x04005D06 RID: 23814
		internal static int __PropertyOffset_RotationQuantizationLevel;
	}
}
