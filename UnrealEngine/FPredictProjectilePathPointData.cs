using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200026C RID: 620
	[UnrealObjectPath("/Script/Engine.PredictProjectilePathPointData")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FPredictProjectilePathPointData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003D9D RID: 15773 RVA: 0x00058D64 File Offset: 0x00056F64
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPredictProjectilePathPointData._ScriptStructPtr != 0) ? FPredictProjectilePathPointData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PredictProjectilePathPointData", ref FPredictProjectilePathPointData._ScriptStructPtr);
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06003D9E RID: 15774 RVA: 0x00058D88 File Offset: 0x00056F88
		// (set) Token: 0x06003D9F RID: 15775 RVA: 0x00058D9C File Offset: 0x00056F9C
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

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06003DA0 RID: 15776 RVA: 0x00058DB1 File Offset: 0x00056FB1
		// (set) Token: 0x06003DA1 RID: 15777 RVA: 0x00058DC5 File Offset: 0x00056FC5
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

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06003DA2 RID: 15778 RVA: 0x00058DDA File Offset: 0x00056FDA
		// (set) Token: 0x06003DA3 RID: 15779 RVA: 0x00058DEA File Offset: 0x00056FEA
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

		// Token: 0x06003DA4 RID: 15780 RVA: 0x00058DFB File Offset: 0x00056FFB
		public FPredictProjectilePathPointData()
		{
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x00058E03 File Offset: 0x00057003
		protected override IntPtr GetUStructPtr()
		{
			return FPredictProjectilePathPointData.StaticStruct();
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x00058E0F File Offset: 0x0005700F
		[NullableContext(2)]
		public FPredictProjectilePathPointData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x00058E19 File Offset: 0x00057019
		public FPredictProjectilePathPointData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x00058E24 File Offset: 0x00057024
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPredictProjectilePathPointData(Pointer, false, true);
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x00058E2E File Offset: 0x0005702E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPredictProjectilePathPointData(Pointer, MemoryOwner);
		}

		// Token: 0x0400180E RID: 6158
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PredictProjectilePathPointData";

		// Token: 0x0400180F RID: 6159
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001810 RID: 6160
		internal static int __PropertyOffset_Location;

		// Token: 0x04001811 RID: 6161
		internal static int __PropertyOffset_Velocity;

		// Token: 0x04001812 RID: 6162
		internal static int __PropertyOffset_Time;
	}
}
