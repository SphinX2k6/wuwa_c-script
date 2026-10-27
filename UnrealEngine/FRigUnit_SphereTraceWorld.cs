using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006D9 RID: 1753
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SphereTraceWorld")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FRigUnit_SphereTraceWorld : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005DE4 RID: 24036 RVA: 0x00086C5A File Offset: 0x00084E5A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SphereTraceWorld._ScriptStructPtr != 0) ? FRigUnit_SphereTraceWorld._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SphereTraceWorld", ref FRigUnit_SphereTraceWorld._ScriptStructPtr);
		}

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x06005DE5 RID: 24037 RVA: 0x00086C7E File Offset: 0x00084E7E
		// (set) Token: 0x06005DE6 RID: 24038 RVA: 0x00086C92 File Offset: 0x00084E92
		public unsafe FVector Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SphereTraceWorld.__PropertyOffset_Start);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SphereTraceWorld.__PropertyOffset_Start) = value;
			}
		}

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x06005DE7 RID: 24039 RVA: 0x00086CA7 File Offset: 0x00084EA7
		// (set) Token: 0x06005DE8 RID: 24040 RVA: 0x00086CBB File Offset: 0x00084EBB
		public unsafe FVector End
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SphereTraceWorld.__PropertyOffset_End);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SphereTraceWorld.__PropertyOffset_End) = value;
			}
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x06005DE9 RID: 24041 RVA: 0x00086CD0 File Offset: 0x00084ED0
		// (set) Token: 0x06005DEA RID: 24042 RVA: 0x00086CE4 File Offset: 0x00084EE4
		public unsafe TEnumAsByte<ECollisionChannel> Channel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SphereTraceWorld.__PropertyOffset_Channel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SphereTraceWorld.__PropertyOffset_Channel) = value;
			}
		}

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x06005DEB RID: 24043 RVA: 0x00086CF9 File Offset: 0x00084EF9
		// (set) Token: 0x06005DEC RID: 24044 RVA: 0x00086D09 File Offset: 0x00084F09
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SphereTraceWorld.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SphereTraceWorld.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x06005DED RID: 24045 RVA: 0x00086D1A File Offset: 0x00084F1A
		// (set) Token: 0x06005DEE RID: 24046 RVA: 0x00086D2A File Offset: 0x00084F2A
		public unsafe bool bHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SphereTraceWorld.__PropertyOffset_bHit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SphereTraceWorld.__PropertyOffset_bHit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x06005DEF RID: 24047 RVA: 0x00086D3B File Offset: 0x00084F3B
		// (set) Token: 0x06005DF0 RID: 24048 RVA: 0x00086D4F File Offset: 0x00084F4F
		public unsafe FVector HitLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SphereTraceWorld.__PropertyOffset_HitLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SphereTraceWorld.__PropertyOffset_HitLocation) = value;
			}
		}

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x06005DF1 RID: 24049 RVA: 0x00086D64 File Offset: 0x00084F64
		// (set) Token: 0x06005DF2 RID: 24050 RVA: 0x00086D78 File Offset: 0x00084F78
		public unsafe FVector HitNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SphereTraceWorld.__PropertyOffset_HitNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SphereTraceWorld.__PropertyOffset_HitNormal) = value;
			}
		}

		// Token: 0x06005DF3 RID: 24051 RVA: 0x00086D8D File Offset: 0x00084F8D
		public FRigUnit_SphereTraceWorld()
		{
		}

		// Token: 0x06005DF4 RID: 24052 RVA: 0x00086D95 File Offset: 0x00084F95
		public FRigUnit_SphereTraceWorld(FVector Start, FVector End, TEnumAsByte<ECollisionChannel> Channel, float Radius, bool bHit, FVector HitLocation, FVector HitNormal)
		{
			this.Start = Start;
			this.End = End;
			this.Channel = Channel;
			this.Radius = Radius;
			this.bHit = bHit;
			this.HitLocation = HitLocation;
			this.HitNormal = HitNormal;
		}

		// Token: 0x06005DF5 RID: 24053 RVA: 0x00086DD2 File Offset: 0x00084FD2
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SphereTraceWorld.StaticStruct();
		}

		// Token: 0x06005DF6 RID: 24054 RVA: 0x00086DDE File Offset: 0x00084FDE
		[NullableContext(2)]
		public FRigUnit_SphereTraceWorld(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005DF7 RID: 24055 RVA: 0x00086DE8 File Offset: 0x00084FE8
		public FRigUnit_SphereTraceWorld(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005DF8 RID: 24056 RVA: 0x00086DF3 File Offset: 0x00084FF3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SphereTraceWorld(Pointer, false, true);
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x00086DFD File Offset: 0x00084FFD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SphereTraceWorld(Pointer, MemoryOwner);
		}

		// Token: 0x04002BEF RID: 11247
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SphereTraceWorld";

		// Token: 0x04002BF0 RID: 11248
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002BF1 RID: 11249
		internal static int __PropertyOffset_Start;

		// Token: 0x04002BF2 RID: 11250
		internal static int __PropertyOffset_End;

		// Token: 0x04002BF3 RID: 11251
		internal static int __PropertyOffset_Channel;

		// Token: 0x04002BF4 RID: 11252
		internal static int __PropertyOffset_Radius;

		// Token: 0x04002BF5 RID: 11253
		internal static int __PropertyOffset_bHit;

		// Token: 0x04002BF6 RID: 11254
		internal static int __PropertyOffset_HitLocation;

		// Token: 0x04002BF7 RID: 11255
		internal static int __PropertyOffset_HitNormal;
	}
}
