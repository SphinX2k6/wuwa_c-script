using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005D5 RID: 1493
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_KalmanVector")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_KalmanVector : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060050AE RID: 20654 RVA: 0x00077153 File Offset: 0x00075353
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_KalmanVector._ScriptStructPtr != 0) ? FRigUnit_KalmanVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_KalmanVector", ref FRigUnit_KalmanVector._ScriptStructPtr);
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x060050AF RID: 20655 RVA: 0x00077177 File Offset: 0x00075377
		// (set) Token: 0x060050B0 RID: 20656 RVA: 0x0007718B File Offset: 0x0007538B
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_KalmanVector.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_KalmanVector.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x060050B1 RID: 20657 RVA: 0x000771A0 File Offset: 0x000753A0
		// (set) Token: 0x060050B2 RID: 20658 RVA: 0x000771B0 File Offset: 0x000753B0
		public unsafe int BufferSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_KalmanVector.__PropertyOffset_BufferSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_KalmanVector.__PropertyOffset_BufferSize) = value;
			}
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x060050B3 RID: 20659 RVA: 0x000771C1 File Offset: 0x000753C1
		// (set) Token: 0x060050B4 RID: 20660 RVA: 0x000771D5 File Offset: 0x000753D5
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_KalmanVector.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_KalmanVector.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x060050B5 RID: 20661 RVA: 0x000771EC File Offset: 0x000753EC
		// (set) Token: 0x060050B6 RID: 20662 RVA: 0x0007722F File Offset: 0x0007542F
		public TArray<FVector> Buffer
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Buffer) == null)
				{
					result = (this._Buffer = new TArray<FVector>(base.NativePtr + (IntPtr)FRigUnit_KalmanVector.__PropertyOffset_Buffer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Buffer.CopyAssign(value);
			}
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x060050B7 RID: 20663 RVA: 0x0007723D File Offset: 0x0007543D
		// (set) Token: 0x060050B8 RID: 20664 RVA: 0x0007724D File Offset: 0x0007544D
		public unsafe int LastInsertIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_KalmanVector.__PropertyOffset_LastInsertIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_KalmanVector.__PropertyOffset_LastInsertIndex) = value;
			}
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x0007725E File Offset: 0x0007545E
		public FRigUnit_KalmanVector()
		{
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x00077266 File Offset: 0x00075466
		public FRigUnit_KalmanVector(FVector Value, int BufferSize, FVector Result, TArray<FVector> Buffer, int LastInsertIndex)
		{
			this.Value = Value;
			this.BufferSize = BufferSize;
			this.Result = Result;
			this.Buffer = Buffer;
			this.LastInsertIndex = LastInsertIndex;
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x00077293 File Offset: 0x00075493
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_KalmanVector.StaticStruct();
		}

		// Token: 0x060050BC RID: 20668 RVA: 0x0007729F File Offset: 0x0007549F
		[NullableContext(2)]
		public FRigUnit_KalmanVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060050BD RID: 20669 RVA: 0x000772A9 File Offset: 0x000754A9
		public FRigUnit_KalmanVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060050BE RID: 20670 RVA: 0x000772B4 File Offset: 0x000754B4
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_KalmanVector(Pointer, false, true);
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x000772BE File Offset: 0x000754BE
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_KalmanVector(Pointer, MemoryOwner);
		}

		// Token: 0x040026EB RID: 9963
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_KalmanVector";

		// Token: 0x040026EC RID: 9964
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040026ED RID: 9965
		internal static int __PropertyOffset_Value;

		// Token: 0x040026EE RID: 9966
		internal static int __PropertyOffset_BufferSize;

		// Token: 0x040026EF RID: 9967
		internal static int __PropertyOffset_Result;

		// Token: 0x040026F0 RID: 9968
		internal static int __PropertyOffset_Buffer;

		// Token: 0x040026F1 RID: 9969
		[Nullable(2)]
		private TArray<FVector> _Buffer;

		// Token: 0x040026F2 RID: 9970
		internal static int __PropertyOffset_LastInsertIndex;
	}
}
