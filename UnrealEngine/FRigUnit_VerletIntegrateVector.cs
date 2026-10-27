using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006F9 RID: 1785
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_VerletIntegrateVector")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_VerletIntegrateVector : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006080 RID: 24704 RVA: 0x0008A720 File Offset: 0x00088920
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_VerletIntegrateVector._ScriptStructPtr != 0) ? FRigUnit_VerletIntegrateVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_VerletIntegrateVector", ref FRigUnit_VerletIntegrateVector._ScriptStructPtr);
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06006081 RID: 24705 RVA: 0x0008A744 File Offset: 0x00088944
		// (set) Token: 0x06006082 RID: 24706 RVA: 0x0008A758 File Offset: 0x00088958
		public unsafe FVector Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x06006083 RID: 24707 RVA: 0x0008A76D File Offset: 0x0008896D
		// (set) Token: 0x06006084 RID: 24708 RVA: 0x0008A77D File Offset: 0x0008897D
		public unsafe float Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Strength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Strength) = value;
			}
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x06006085 RID: 24709 RVA: 0x0008A78E File Offset: 0x0008898E
		// (set) Token: 0x06006086 RID: 24710 RVA: 0x0008A79E File Offset: 0x0008899E
		public unsafe float Damp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Damp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Damp) = value;
			}
		}

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x06006087 RID: 24711 RVA: 0x0008A7AF File Offset: 0x000889AF
		// (set) Token: 0x06006088 RID: 24712 RVA: 0x0008A7BF File Offset: 0x000889BF
		public unsafe float Blend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Blend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Blend) = value;
			}
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x06006089 RID: 24713 RVA: 0x0008A7D0 File Offset: 0x000889D0
		// (set) Token: 0x0600608A RID: 24714 RVA: 0x0008A7E4 File Offset: 0x000889E4
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x0600608B RID: 24715 RVA: 0x0008A7F9 File Offset: 0x000889F9
		// (set) Token: 0x0600608C RID: 24716 RVA: 0x0008A80D File Offset: 0x00088A0D
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x0600608D RID: 24717 RVA: 0x0008A822 File Offset: 0x00088A22
		// (set) Token: 0x0600608E RID: 24718 RVA: 0x0008A836 File Offset: 0x00088A36
		public unsafe FVector Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x0600608F RID: 24719 RVA: 0x0008A84C File Offset: 0x00088A4C
		// (set) Token: 0x06006090 RID: 24720 RVA: 0x0008A88F File Offset: 0x00088A8F
		public FCRSimPoint Point
		{
			get
			{
				base.FastCheckIsValid();
				FCRSimPoint result;
				if ((result = this._Point) == null)
				{
					result = (this._Point = new FCRSimPoint(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Point, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCRSimPoint.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_Point, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06006091 RID: 24721 RVA: 0x0008A8B0 File Offset: 0x00088AB0
		// (set) Token: 0x06006092 RID: 24722 RVA: 0x0008A8C0 File Offset: 0x00088AC0
		public unsafe bool bInitialized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_bInitialized) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VerletIntegrateVector.__PropertyOffset_bInitialized) = (value ? 1 : 0);
			}
		}

		// Token: 0x06006093 RID: 24723 RVA: 0x0008A8D1 File Offset: 0x00088AD1
		public FRigUnit_VerletIntegrateVector()
		{
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x0008A8DC File Offset: 0x00088ADC
		public FRigUnit_VerletIntegrateVector(FVector Target, float Strength, float Damp, float Blend, FVector Position, FVector Velocity, FVector Acceleration, FCRSimPoint Point, bool bInitialized)
		{
			this.Target = Target;
			this.Strength = Strength;
			this.Damp = Damp;
			this.Blend = Blend;
			this.Position = Position;
			this.Velocity = Velocity;
			this.Acceleration = Acceleration;
			this.Point = Point;
			this.bInitialized = bInitialized;
		}

		// Token: 0x06006095 RID: 24725 RVA: 0x0008A934 File Offset: 0x00088B34
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_VerletIntegrateVector.StaticStruct();
		}

		// Token: 0x06006096 RID: 24726 RVA: 0x0008A940 File Offset: 0x00088B40
		[NullableContext(2)]
		public FRigUnit_VerletIntegrateVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006097 RID: 24727 RVA: 0x0008A94A File Offset: 0x00088B4A
		public FRigUnit_VerletIntegrateVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006098 RID: 24728 RVA: 0x0008A955 File Offset: 0x00088B55
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_VerletIntegrateVector(Pointer, false, true);
		}

		// Token: 0x06006099 RID: 24729 RVA: 0x0008A95F File Offset: 0x00088B5F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_VerletIntegrateVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002D25 RID: 11557
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_VerletIntegrateVector";

		// Token: 0x04002D26 RID: 11558
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D27 RID: 11559
		internal static int __PropertyOffset_Target;

		// Token: 0x04002D28 RID: 11560
		internal static int __PropertyOffset_Strength;

		// Token: 0x04002D29 RID: 11561
		internal static int __PropertyOffset_Damp;

		// Token: 0x04002D2A RID: 11562
		internal static int __PropertyOffset_Blend;

		// Token: 0x04002D2B RID: 11563
		internal static int __PropertyOffset_Position;

		// Token: 0x04002D2C RID: 11564
		internal static int __PropertyOffset_Velocity;

		// Token: 0x04002D2D RID: 11565
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x04002D2E RID: 11566
		internal static int __PropertyOffset_Point;

		// Token: 0x04002D2F RID: 11567
		[Nullable(2)]
		private FCRSimPoint _Point;

		// Token: 0x04002D30 RID: 11568
		internal static int __PropertyOffset_bInitialized;
	}
}
