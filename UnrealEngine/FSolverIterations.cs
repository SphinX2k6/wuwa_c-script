using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001121 RID: 4385
	[UnrealObjectPath("/Script/Engine.SolverIterations")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FSolverIterations : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010026 RID: 65574 RVA: 0x0017928C File Offset: 0x0017748C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSolverIterations._ScriptStructPtr != 0) ? FSolverIterations._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SolverIterations", ref FSolverIterations._ScriptStructPtr);
		}

		// Token: 0x17003E7A RID: 15994
		// (get) Token: 0x06010027 RID: 65575 RVA: 0x001792B0 File Offset: 0x001774B0
		// (set) Token: 0x06010028 RID: 65576 RVA: 0x001792C0 File Offset: 0x001774C0
		public unsafe float FixedTimeStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverIterations.__PropertyOffset_FixedTimeStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverIterations.__PropertyOffset_FixedTimeStep) = value;
			}
		}

		// Token: 0x17003E7B RID: 15995
		// (get) Token: 0x06010029 RID: 65577 RVA: 0x001792D1 File Offset: 0x001774D1
		// (set) Token: 0x0601002A RID: 65578 RVA: 0x001792E1 File Offset: 0x001774E1
		public unsafe int SolverIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverIterations.__PropertyOffset_SolverIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverIterations.__PropertyOffset_SolverIterations) = value;
			}
		}

		// Token: 0x17003E7C RID: 15996
		// (get) Token: 0x0601002B RID: 65579 RVA: 0x001792F2 File Offset: 0x001774F2
		// (set) Token: 0x0601002C RID: 65580 RVA: 0x00179302 File Offset: 0x00177502
		public unsafe int JointIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverIterations.__PropertyOffset_JointIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverIterations.__PropertyOffset_JointIterations) = value;
			}
		}

		// Token: 0x17003E7D RID: 15997
		// (get) Token: 0x0601002D RID: 65581 RVA: 0x00179313 File Offset: 0x00177513
		// (set) Token: 0x0601002E RID: 65582 RVA: 0x00179323 File Offset: 0x00177523
		public unsafe int CollisionIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverIterations.__PropertyOffset_CollisionIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverIterations.__PropertyOffset_CollisionIterations) = value;
			}
		}

		// Token: 0x17003E7E RID: 15998
		// (get) Token: 0x0601002F RID: 65583 RVA: 0x00179334 File Offset: 0x00177534
		// (set) Token: 0x06010030 RID: 65584 RVA: 0x00179344 File Offset: 0x00177544
		public unsafe int SolverPushOutIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverIterations.__PropertyOffset_SolverPushOutIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverIterations.__PropertyOffset_SolverPushOutIterations) = value;
			}
		}

		// Token: 0x17003E7F RID: 15999
		// (get) Token: 0x06010031 RID: 65585 RVA: 0x00179355 File Offset: 0x00177555
		// (set) Token: 0x06010032 RID: 65586 RVA: 0x00179365 File Offset: 0x00177565
		public unsafe int JointPushOutIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverIterations.__PropertyOffset_JointPushOutIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverIterations.__PropertyOffset_JointPushOutIterations) = value;
			}
		}

		// Token: 0x17003E80 RID: 16000
		// (get) Token: 0x06010033 RID: 65587 RVA: 0x00179376 File Offset: 0x00177576
		// (set) Token: 0x06010034 RID: 65588 RVA: 0x00179386 File Offset: 0x00177586
		public unsafe int CollisionPushOutIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverIterations.__PropertyOffset_CollisionPushOutIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverIterations.__PropertyOffset_CollisionPushOutIterations) = value;
			}
		}

		// Token: 0x06010035 RID: 65589 RVA: 0x00179397 File Offset: 0x00177597
		public FSolverIterations()
		{
		}

		// Token: 0x06010036 RID: 65590 RVA: 0x0017939F File Offset: 0x0017759F
		public FSolverIterations(float FixedTimeStep, int SolverIterations, int JointIterations, int CollisionIterations, int SolverPushOutIterations, int JointPushOutIterations, int CollisionPushOutIterations)
		{
			this.FixedTimeStep = FixedTimeStep;
			this.SolverIterations = SolverIterations;
			this.JointIterations = JointIterations;
			this.CollisionIterations = CollisionIterations;
			this.SolverPushOutIterations = SolverPushOutIterations;
			this.JointPushOutIterations = JointPushOutIterations;
			this.CollisionPushOutIterations = CollisionPushOutIterations;
		}

		// Token: 0x06010037 RID: 65591 RVA: 0x001793DC File Offset: 0x001775DC
		protected override IntPtr GetUStructPtr()
		{
			return FSolverIterations.StaticStruct();
		}

		// Token: 0x06010038 RID: 65592 RVA: 0x001793E8 File Offset: 0x001775E8
		[NullableContext(2)]
		public FSolverIterations(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010039 RID: 65593 RVA: 0x001793F2 File Offset: 0x001775F2
		public FSolverIterations(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601003A RID: 65594 RVA: 0x001793FD File Offset: 0x001775FD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSolverIterations(Pointer, false, true);
		}

		// Token: 0x0601003B RID: 65595 RVA: 0x00179407 File Offset: 0x00177607
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSolverIterations(Pointer, MemoryOwner);
		}

		// Token: 0x0400899B RID: 35227
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SolverIterations";

		// Token: 0x0400899C RID: 35228
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400899D RID: 35229
		internal static int __PropertyOffset_FixedTimeStep;

		// Token: 0x0400899E RID: 35230
		internal static int __PropertyOffset_SolverIterations;

		// Token: 0x0400899F RID: 35231
		internal static int __PropertyOffset_JointIterations;

		// Token: 0x040089A0 RID: 35232
		internal static int __PropertyOffset_CollisionIterations;

		// Token: 0x040089A1 RID: 35233
		internal static int __PropertyOffset_SolverPushOutIterations;

		// Token: 0x040089A2 RID: 35234
		internal static int __PropertyOffset_JointPushOutIterations;

		// Token: 0x040089A3 RID: 35235
		internal static int __PropertyOffset_CollisionPushOutIterations;
	}
}
