using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001088 RID: 4232
	[UnrealObjectPath("/Script/Engine.RepMovement")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FRepMovement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F1DB RID: 61915 RVA: 0x00166E66 File Offset: 0x00165066
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRepMovement._ScriptStructPtr != 0) ? FRepMovement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RepMovement", ref FRepMovement._ScriptStructPtr);
		}

		// Token: 0x17003ADD RID: 15069
		// (get) Token: 0x0600F1DC RID: 61916 RVA: 0x00166E8A File Offset: 0x0016508A
		// (set) Token: 0x0600F1DD RID: 61917 RVA: 0x00166E9E File Offset: 0x0016509E
		public unsafe FVector LinearVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_LinearVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_LinearVelocity) = value;
			}
		}

		// Token: 0x17003ADE RID: 15070
		// (get) Token: 0x0600F1DE RID: 61918 RVA: 0x00166EB3 File Offset: 0x001650B3
		// (set) Token: 0x0600F1DF RID: 61919 RVA: 0x00166EC7 File Offset: 0x001650C7
		public unsafe FVector AngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_AngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_AngularVelocity) = value;
			}
		}

		// Token: 0x17003ADF RID: 15071
		// (get) Token: 0x0600F1E0 RID: 61920 RVA: 0x00166EDC File Offset: 0x001650DC
		// (set) Token: 0x0600F1E1 RID: 61921 RVA: 0x00166EF0 File Offset: 0x001650F0
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17003AE0 RID: 15072
		// (get) Token: 0x0600F1E2 RID: 61922 RVA: 0x00166F05 File Offset: 0x00165105
		// (set) Token: 0x0600F1E3 RID: 61923 RVA: 0x00166F19 File Offset: 0x00165119
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17003AE1 RID: 15073
		// (get) Token: 0x0600F1E4 RID: 61924 RVA: 0x00166F2E File Offset: 0x0016512E
		// (set) Token: 0x0600F1E5 RID: 61925 RVA: 0x00166F47 File Offset: 0x00165147
		public unsafe bool bSimulatedPhysicSleep
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_bSimulatedPhysicSleep) & FRepMovement.__PropertyMask_bSimulatedPhysicSleep) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRepMovement.__PropertyOffset_bSimulatedPhysicSleep) = ((*(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_bSimulatedPhysicSleep) & ~FRepMovement.__PropertyMask_bSimulatedPhysicSleep) | (value ? FRepMovement.__PropertyMask_bSimulatedPhysicSleep : 0));
			}
		}

		// Token: 0x17003AE2 RID: 15074
		// (get) Token: 0x0600F1E6 RID: 61926 RVA: 0x00166F77 File Offset: 0x00165177
		// (set) Token: 0x0600F1E7 RID: 61927 RVA: 0x00166F90 File Offset: 0x00165190
		public unsafe bool bRepPhysics
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_bRepPhysics) & FRepMovement.__PropertyMask_bRepPhysics) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRepMovement.__PropertyOffset_bRepPhysics) = ((*(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_bRepPhysics) & ~FRepMovement.__PropertyMask_bRepPhysics) | (value ? FRepMovement.__PropertyMask_bRepPhysics : 0));
			}
		}

		// Token: 0x17003AE3 RID: 15075
		// (get) Token: 0x0600F1E8 RID: 61928 RVA: 0x00166FC0 File Offset: 0x001651C0
		// (set) Token: 0x0600F1E9 RID: 61929 RVA: 0x00166FD0 File Offset: 0x001651D0
		public unsafe EVectorQuantization LocationQuantizationLevel
		{
			get
			{
				return (EVectorQuantization)(*(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_LocationQuantizationLevel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_LocationQuantizationLevel) = (byte)value;
			}
		}

		// Token: 0x17003AE4 RID: 15076
		// (get) Token: 0x0600F1EA RID: 61930 RVA: 0x00166FE1 File Offset: 0x001651E1
		// (set) Token: 0x0600F1EB RID: 61931 RVA: 0x00166FF1 File Offset: 0x001651F1
		public unsafe EVectorQuantization VelocityQuantizationLevel
		{
			get
			{
				return (EVectorQuantization)(*(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_VelocityQuantizationLevel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_VelocityQuantizationLevel) = (byte)value;
			}
		}

		// Token: 0x17003AE5 RID: 15077
		// (get) Token: 0x0600F1EC RID: 61932 RVA: 0x00167002 File Offset: 0x00165202
		// (set) Token: 0x0600F1ED RID: 61933 RVA: 0x00167012 File Offset: 0x00165212
		public unsafe ERotatorQuantization RotationQuantizationLevel
		{
			get
			{
				return (ERotatorQuantization)(*(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_RotationQuantizationLevel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepMovement.__PropertyOffset_RotationQuantizationLevel) = (byte)value;
			}
		}

		// Token: 0x0600F1EE RID: 61934 RVA: 0x00167023 File Offset: 0x00165223
		public FRepMovement()
		{
		}

		// Token: 0x0600F1EF RID: 61935 RVA: 0x0016702C File Offset: 0x0016522C
		public FRepMovement(FVector LinearVelocity, FVector AngularVelocity, FVector Location, FRotator Rotation, bool bSimulatedPhysicSleep, bool bRepPhysics, EVectorQuantization LocationQuantizationLevel, EVectorQuantization VelocityQuantizationLevel, ERotatorQuantization RotationQuantizationLevel)
		{
			this.LinearVelocity = LinearVelocity;
			this.AngularVelocity = AngularVelocity;
			this.Location = Location;
			this.Rotation = Rotation;
			this.bSimulatedPhysicSleep = bSimulatedPhysicSleep;
			this.bRepPhysics = bRepPhysics;
			this.LocationQuantizationLevel = LocationQuantizationLevel;
			this.VelocityQuantizationLevel = VelocityQuantizationLevel;
			this.RotationQuantizationLevel = RotationQuantizationLevel;
		}

		// Token: 0x0600F1F0 RID: 61936 RVA: 0x00167084 File Offset: 0x00165284
		protected override IntPtr GetUStructPtr()
		{
			return FRepMovement.StaticStruct();
		}

		// Token: 0x0600F1F1 RID: 61937 RVA: 0x00167090 File Offset: 0x00165290
		[NullableContext(2)]
		public FRepMovement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F1F2 RID: 61938 RVA: 0x0016709A File Offset: 0x0016529A
		public FRepMovement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F1F3 RID: 61939 RVA: 0x001670A5 File Offset: 0x001652A5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRepMovement(Pointer, false, true);
		}

		// Token: 0x0600F1F4 RID: 61940 RVA: 0x001670AF File Offset: 0x001652AF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRepMovement(Pointer, MemoryOwner);
		}

		// Token: 0x04008324 RID: 33572
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RepMovement";

		// Token: 0x04008325 RID: 33573
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008326 RID: 33574
		internal static int __PropertyOffset_LinearVelocity;

		// Token: 0x04008327 RID: 33575
		internal static int __PropertyOffset_AngularVelocity;

		// Token: 0x04008328 RID: 33576
		internal static int __PropertyOffset_Location;

		// Token: 0x04008329 RID: 33577
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400832A RID: 33578
		internal static int __PropertyOffset_bSimulatedPhysicSleep;

		// Token: 0x0400832B RID: 33579
		internal static byte __PropertyMask_bSimulatedPhysicSleep;

		// Token: 0x0400832C RID: 33580
		internal static int __PropertyOffset_bRepPhysics;

		// Token: 0x0400832D RID: 33581
		internal static byte __PropertyMask_bRepPhysics;

		// Token: 0x0400832E RID: 33582
		internal static int __PropertyOffset_LocationQuantizationLevel;

		// Token: 0x0400832F RID: 33583
		internal static int __PropertyOffset_VelocityQuantizationLevel;

		// Token: 0x04008330 RID: 33584
		internal static int __PropertyOffset_RotationQuantizationLevel;
	}
}
