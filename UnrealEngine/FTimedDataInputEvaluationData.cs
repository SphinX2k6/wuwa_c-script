using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002917 RID: 10519
	[UnrealObjectPath("/Script/TimeManagement.TimedDataInputEvaluationData")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FTimedDataInputEvaluationData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026FA9 RID: 159657 RVA: 0x003B7285 File Offset: 0x003B5485
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTimedDataInputEvaluationData._ScriptStructPtr != 0) ? FTimedDataInputEvaluationData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TimeManagement.TimedDataInputEvaluationData", ref FTimedDataInputEvaluationData._ScriptStructPtr);
		}

		// Token: 0x17009611 RID: 38417
		// (get) Token: 0x06026FAA RID: 159658 RVA: 0x003B72A9 File Offset: 0x003B54A9
		// (set) Token: 0x06026FAB RID: 159659 RVA: 0x003B72B9 File Offset: 0x003B54B9
		public unsafe float DistanceToNewestSampleSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimedDataInputEvaluationData.__PropertyOffset_DistanceToNewestSampleSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimedDataInputEvaluationData.__PropertyOffset_DistanceToNewestSampleSeconds) = value;
			}
		}

		// Token: 0x17009612 RID: 38418
		// (get) Token: 0x06026FAC RID: 159660 RVA: 0x003B72CA File Offset: 0x003B54CA
		// (set) Token: 0x06026FAD RID: 159661 RVA: 0x003B72DA File Offset: 0x003B54DA
		public unsafe float DistanceToOldestSampleSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimedDataInputEvaluationData.__PropertyOffset_DistanceToOldestSampleSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimedDataInputEvaluationData.__PropertyOffset_DistanceToOldestSampleSeconds) = value;
			}
		}

		// Token: 0x06026FAE RID: 159662 RVA: 0x003B72EB File Offset: 0x003B54EB
		public FTimedDataInputEvaluationData()
		{
		}

		// Token: 0x06026FAF RID: 159663 RVA: 0x003B72F3 File Offset: 0x003B54F3
		public FTimedDataInputEvaluationData(float DistanceToNewestSampleSeconds, float DistanceToOldestSampleSeconds)
		{
			this.DistanceToNewestSampleSeconds = DistanceToNewestSampleSeconds;
			this.DistanceToOldestSampleSeconds = DistanceToOldestSampleSeconds;
		}

		// Token: 0x06026FB0 RID: 159664 RVA: 0x003B7309 File Offset: 0x003B5509
		protected override IntPtr GetUStructPtr()
		{
			return FTimedDataInputEvaluationData.StaticStruct();
		}

		// Token: 0x06026FB1 RID: 159665 RVA: 0x003B7315 File Offset: 0x003B5515
		[NullableContext(2)]
		public FTimedDataInputEvaluationData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026FB2 RID: 159666 RVA: 0x003B731F File Offset: 0x003B551F
		public FTimedDataInputEvaluationData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026FB3 RID: 159667 RVA: 0x003B732A File Offset: 0x003B552A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTimedDataInputEvaluationData(Pointer, false, true);
		}

		// Token: 0x06026FB4 RID: 159668 RVA: 0x003B7334 File Offset: 0x003B5534
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTimedDataInputEvaluationData(Pointer, MemoryOwner);
		}

		// Token: 0x04015660 RID: 87648
		[Nullable(1)]
		public const string __ObjectPath = "/Script/TimeManagement.TimedDataInputEvaluationData";

		// Token: 0x04015661 RID: 87649
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015662 RID: 87650
		internal static int __PropertyOffset_DistanceToNewestSampleSeconds;

		// Token: 0x04015663 RID: 87651
		internal static int __PropertyOffset_DistanceToOldestSampleSeconds;
	}
}
