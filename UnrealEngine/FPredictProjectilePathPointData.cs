using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001030 RID: 4144
	[UnrealObjectPath("/Script/Engine.PredictProjectilePathPointData")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FPredictProjectilePathPointData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E92F RID: 59695 RVA: 0x0015A6D0 File Offset: 0x001588D0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPredictProjectilePathPointData._ScriptStructPtr != 0) ? FPredictProjectilePathPointData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PredictProjectilePathPointData", ref FPredictProjectilePathPointData._ScriptStructPtr);
		}

		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x0600E930 RID: 59696 RVA: 0x0015A6F4 File Offset: 0x001588F4
		// (set) Token: 0x0600E931 RID: 59697 RVA: 0x0015A708 File Offset: 0x00158908
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathPointData.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathPointData.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x0600E932 RID: 59698 RVA: 0x0015A71D File Offset: 0x0015891D
		// (set) Token: 0x0600E933 RID: 59699 RVA: 0x0015A731 File Offset: 0x00158931
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathPointData.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathPointData.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x1700387C RID: 14460
		// (get) Token: 0x0600E934 RID: 59700 RVA: 0x0015A746 File Offset: 0x00158946
		// (set) Token: 0x0600E935 RID: 59701 RVA: 0x0015A756 File Offset: 0x00158956
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathPointData.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathPointData.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x0600E936 RID: 59702 RVA: 0x0015A767 File Offset: 0x00158967
		public FPredictProjectilePathPointData()
		{
		}

		// Token: 0x0600E937 RID: 59703 RVA: 0x0015A76F File Offset: 0x0015896F
		public FPredictProjectilePathPointData(FVector Location, FVector Velocity, float Time)
		{
			this.Location = Location;
			this.Velocity = Velocity;
			this.Time = Time;
		}

		// Token: 0x0600E938 RID: 59704 RVA: 0x0015A78C File Offset: 0x0015898C
		protected override IntPtr GetUStructPtr()
		{
			return FPredictProjectilePathPointData.StaticStruct();
		}

		// Token: 0x0600E939 RID: 59705 RVA: 0x0015A798 File Offset: 0x00158998
		[NullableContext(2)]
		public FPredictProjectilePathPointData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E93A RID: 59706 RVA: 0x0015A7A2 File Offset: 0x001589A2
		public FPredictProjectilePathPointData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E93B RID: 59707 RVA: 0x0015A7AD File Offset: 0x001589AD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPredictProjectilePathPointData(Pointer, false, true);
		}

		// Token: 0x0600E93C RID: 59708 RVA: 0x0015A7B7 File Offset: 0x001589B7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPredictProjectilePathPointData(Pointer, MemoryOwner);
		}

		// Token: 0x04007E99 RID: 32409
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PredictProjectilePathPointData";

		// Token: 0x04007E9A RID: 32410
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007E9B RID: 32411
		internal static int __PropertyOffset_Location;

		// Token: 0x04007E9C RID: 32412
		internal static int __PropertyOffset_Velocity;

		// Token: 0x04007E9D RID: 32413
		internal static int __PropertyOffset_Time;
	}
}
