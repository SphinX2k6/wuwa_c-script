using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005A3 RID: 1443
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_EndProfilingTimer")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FRigUnit_EndProfilingTimer : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D67 RID: 19815 RVA: 0x00072551 File Offset: 0x00070751
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_EndProfilingTimer._ScriptStructPtr != 0) ? FRigUnit_EndProfilingTimer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_EndProfilingTimer", ref FRigUnit_EndProfilingTimer._ScriptStructPtr);
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06004D68 RID: 19816 RVA: 0x00072575 File Offset: 0x00070775
		// (set) Token: 0x06004D69 RID: 19817 RVA: 0x00072585 File Offset: 0x00070785
		public unsafe int NumberOfMeasurements
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_EndProfilingTimer.__PropertyOffset_NumberOfMeasurements);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_EndProfilingTimer.__PropertyOffset_NumberOfMeasurements) = value;
			}
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06004D6A RID: 19818 RVA: 0x00072596 File Offset: 0x00070796
		// (set) Token: 0x06004D6B RID: 19819 RVA: 0x000725AA File Offset: 0x000707AA
		public unsafe string Prefix
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FRigUnit_EndProfilingTimer.__PropertyOffset_Prefix)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FRigUnit_EndProfilingTimer.__PropertyOffset_Prefix)), value);
			}
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06004D6C RID: 19820 RVA: 0x000725BF File Offset: 0x000707BF
		// (set) Token: 0x06004D6D RID: 19821 RVA: 0x000725CF File Offset: 0x000707CF
		public unsafe float AccumulatedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_EndProfilingTimer.__PropertyOffset_AccumulatedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_EndProfilingTimer.__PropertyOffset_AccumulatedTime) = value;
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06004D6E RID: 19822 RVA: 0x000725E0 File Offset: 0x000707E0
		// (set) Token: 0x06004D6F RID: 19823 RVA: 0x000725F0 File Offset: 0x000707F0
		public unsafe int MeasurementsLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_EndProfilingTimer.__PropertyOffset_MeasurementsLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_EndProfilingTimer.__PropertyOffset_MeasurementsLeft) = value;
			}
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x00072601 File Offset: 0x00070801
		public FRigUnit_EndProfilingTimer()
		{
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x00072609 File Offset: 0x00070809
		public FRigUnit_EndProfilingTimer(int NumberOfMeasurements, string Prefix, float AccumulatedTime, int MeasurementsLeft, FControlRigExecuteContext ExecuteContext)
		{
			this.NumberOfMeasurements = NumberOfMeasurements;
			this.Prefix = Prefix;
			this.AccumulatedTime = AccumulatedTime;
			this.MeasurementsLeft = MeasurementsLeft;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x00072636 File Offset: 0x00070836
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_EndProfilingTimer.StaticStruct();
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x00072642 File Offset: 0x00070842
		[NullableContext(2)]
		public FRigUnit_EndProfilingTimer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x0007264C File Offset: 0x0007084C
		public FRigUnit_EndProfilingTimer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004D75 RID: 19829 RVA: 0x00072657 File Offset: 0x00070857
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_EndProfilingTimer(Pointer, false, true);
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x00072661 File Offset: 0x00070861
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_EndProfilingTimer(Pointer, MemoryOwner);
		}

		// Token: 0x04002562 RID: 9570
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_EndProfilingTimer";

		// Token: 0x04002563 RID: 9571
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002564 RID: 9572
		internal static int __PropertyOffset_NumberOfMeasurements;

		// Token: 0x04002565 RID: 9573
		internal static int __PropertyOffset_Prefix;

		// Token: 0x04002566 RID: 9574
		internal static int __PropertyOffset_AccumulatedTime;

		// Token: 0x04002567 RID: 9575
		internal static int __PropertyOffset_MeasurementsLeft;
	}
}
