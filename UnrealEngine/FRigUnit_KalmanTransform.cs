using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005D4 RID: 1492
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_KalmanTransform")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_KalmanTransform : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600509C RID: 20636 RVA: 0x00076FDF File Offset: 0x000751DF
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_KalmanTransform._ScriptStructPtr != 0) ? FRigUnit_KalmanTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_KalmanTransform", ref FRigUnit_KalmanTransform._ScriptStructPtr);
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x0600509D RID: 20637 RVA: 0x00077003 File Offset: 0x00075203
		// (set) Token: 0x0600509E RID: 20638 RVA: 0x00077017 File Offset: 0x00075217
		public unsafe FTransform Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_KalmanTransform.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_KalmanTransform.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x0600509F RID: 20639 RVA: 0x0007702C File Offset: 0x0007522C
		// (set) Token: 0x060050A0 RID: 20640 RVA: 0x0007703C File Offset: 0x0007523C
		public unsafe int BufferSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_KalmanTransform.__PropertyOffset_BufferSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_KalmanTransform.__PropertyOffset_BufferSize) = value;
			}
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x060050A1 RID: 20641 RVA: 0x0007704D File Offset: 0x0007524D
		// (set) Token: 0x060050A2 RID: 20642 RVA: 0x00077061 File Offset: 0x00075261
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_KalmanTransform.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_KalmanTransform.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x060050A3 RID: 20643 RVA: 0x00077078 File Offset: 0x00075278
		// (set) Token: 0x060050A4 RID: 20644 RVA: 0x000770BB File Offset: 0x000752BB
		public TArray<FTransform> Buffer
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Buffer) == null)
				{
					result = (this._Buffer = new TArray<FTransform>(base.NativePtr + (IntPtr)FRigUnit_KalmanTransform.__PropertyOffset_Buffer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Buffer.CopyAssign(value);
			}
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x060050A5 RID: 20645 RVA: 0x000770C9 File Offset: 0x000752C9
		// (set) Token: 0x060050A6 RID: 20646 RVA: 0x000770D9 File Offset: 0x000752D9
		public unsafe int LastInsertIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_KalmanTransform.__PropertyOffset_LastInsertIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_KalmanTransform.__PropertyOffset_LastInsertIndex) = value;
			}
		}

		// Token: 0x060050A7 RID: 20647 RVA: 0x000770EA File Offset: 0x000752EA
		public FRigUnit_KalmanTransform()
		{
		}

		// Token: 0x060050A8 RID: 20648 RVA: 0x000770F2 File Offset: 0x000752F2
		public FRigUnit_KalmanTransform(FTransform Value, int BufferSize, FTransform Result, TArray<FTransform> Buffer, int LastInsertIndex)
		{
			this.Value = Value;
			this.BufferSize = BufferSize;
			this.Result = Result;
			this.Buffer = Buffer;
			this.LastInsertIndex = LastInsertIndex;
		}

		// Token: 0x060050A9 RID: 20649 RVA: 0x0007711F File Offset: 0x0007531F
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_KalmanTransform.StaticStruct();
		}

		// Token: 0x060050AA RID: 20650 RVA: 0x0007712B File Offset: 0x0007532B
		[NullableContext(2)]
		public FRigUnit_KalmanTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x00077135 File Offset: 0x00075335
		public FRigUnit_KalmanTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060050AC RID: 20652 RVA: 0x00077140 File Offset: 0x00075340
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_KalmanTransform(Pointer, false, true);
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x0007714A File Offset: 0x0007534A
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_KalmanTransform(Pointer, MemoryOwner);
		}

		// Token: 0x040026E3 RID: 9955
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_KalmanTransform";

		// Token: 0x040026E4 RID: 9956
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040026E5 RID: 9957
		internal static int __PropertyOffset_Value;

		// Token: 0x040026E6 RID: 9958
		internal static int __PropertyOffset_BufferSize;

		// Token: 0x040026E7 RID: 9959
		internal static int __PropertyOffset_Result;

		// Token: 0x040026E8 RID: 9960
		internal static int __PropertyOffset_Buffer;

		// Token: 0x040026E9 RID: 9961
		[Nullable(2)]
		private TArray<FTransform> _Buffer;

		// Token: 0x040026EA RID: 9962
		internal static int __PropertyOffset_LastInsertIndex;
	}
}
