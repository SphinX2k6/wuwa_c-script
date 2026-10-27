using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200061E RID: 1566
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntersectPlane")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FRigUnit_MathIntersectPlane : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060053CD RID: 21453 RVA: 0x0007A2C7 File Offset: 0x000784C7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntersectPlane._ScriptStructPtr != 0) ? FRigUnit_MathIntersectPlane._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntersectPlane", ref FRigUnit_MathIntersectPlane._ScriptStructPtr);
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x060053CE RID: 21454 RVA: 0x0007A2EB File Offset: 0x000784EB
		// (set) Token: 0x060053CF RID: 21455 RVA: 0x0007A2FF File Offset: 0x000784FF
		public unsafe FVector Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntersectPlane.__PropertyOffset_Start);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntersectPlane.__PropertyOffset_Start) = value;
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x060053D0 RID: 21456 RVA: 0x0007A314 File Offset: 0x00078514
		// (set) Token: 0x060053D1 RID: 21457 RVA: 0x0007A328 File Offset: 0x00078528
		public unsafe FVector Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntersectPlane.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntersectPlane.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x060053D2 RID: 21458 RVA: 0x0007A33D File Offset: 0x0007853D
		// (set) Token: 0x060053D3 RID: 21459 RVA: 0x0007A351 File Offset: 0x00078551
		public unsafe FVector PlanePoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntersectPlane.__PropertyOffset_PlanePoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntersectPlane.__PropertyOffset_PlanePoint) = value;
			}
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x060053D4 RID: 21460 RVA: 0x0007A366 File Offset: 0x00078566
		// (set) Token: 0x060053D5 RID: 21461 RVA: 0x0007A37A File Offset: 0x0007857A
		public unsafe FVector PlaneNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntersectPlane.__PropertyOffset_PlaneNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntersectPlane.__PropertyOffset_PlaneNormal) = value;
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x060053D6 RID: 21462 RVA: 0x0007A38F File Offset: 0x0007858F
		// (set) Token: 0x060053D7 RID: 21463 RVA: 0x0007A3A3 File Offset: 0x000785A3
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntersectPlane.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntersectPlane.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x060053D8 RID: 21464 RVA: 0x0007A3B8 File Offset: 0x000785B8
		// (set) Token: 0x060053D9 RID: 21465 RVA: 0x0007A3C8 File Offset: 0x000785C8
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntersectPlane.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntersectPlane.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x0007A3D9 File Offset: 0x000785D9
		public FRigUnit_MathIntersectPlane()
		{
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x0007A3E1 File Offset: 0x000785E1
		public FRigUnit_MathIntersectPlane(FVector Start, FVector Direction, FVector PlanePoint, FVector PlaneNormal, FVector Result, float Distance)
		{
			this.Start = Start;
			this.Direction = Direction;
			this.PlanePoint = PlanePoint;
			this.PlaneNormal = PlaneNormal;
			this.Result = Result;
			this.Distance = Distance;
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x0007A416 File Offset: 0x00078616
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntersectPlane.StaticStruct();
		}

		// Token: 0x060053DD RID: 21469 RVA: 0x0007A422 File Offset: 0x00078622
		[NullableContext(2)]
		public FRigUnit_MathIntersectPlane(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x0007A42C File Offset: 0x0007862C
		public FRigUnit_MathIntersectPlane(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x0007A437 File Offset: 0x00078637
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntersectPlane(Pointer, false, true);
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x0007A441 File Offset: 0x00078641
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntersectPlane(Pointer, MemoryOwner);
		}

		// Token: 0x040027EC RID: 10220
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntersectPlane";

		// Token: 0x040027ED RID: 10221
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040027EE RID: 10222
		internal static int __PropertyOffset_Start;

		// Token: 0x040027EF RID: 10223
		internal static int __PropertyOffset_Direction;

		// Token: 0x040027F0 RID: 10224
		internal static int __PropertyOffset_PlanePoint;

		// Token: 0x040027F1 RID: 10225
		internal static int __PropertyOffset_PlaneNormal;

		// Token: 0x040027F2 RID: 10226
		internal static int __PropertyOffset_Result;

		// Token: 0x040027F3 RID: 10227
		internal static int __PropertyOffset_Distance;
	}
}
