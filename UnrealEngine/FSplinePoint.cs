using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200117F RID: 4479
	[UnrealObjectPath("/Script/Engine.SplinePoint")]
	[UnrealStructLayout(68, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 68)]
	public class FSplinePoint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601074E RID: 67406 RVA: 0x00182AA5 File Offset: 0x00180CA5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSplinePoint._ScriptStructPtr != 0) ? FSplinePoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SplinePoint", ref FSplinePoint._ScriptStructPtr);
		}

		// Token: 0x17004027 RID: 16423
		// (get) Token: 0x0601074F RID: 67407 RVA: 0x00182AC9 File Offset: 0x00180CC9
		// (set) Token: 0x06010750 RID: 67408 RVA: 0x00182AD9 File Offset: 0x00180CD9
		public unsafe float InputKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplinePoint.__PropertyOffset_InputKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplinePoint.__PropertyOffset_InputKey) = value;
			}
		}

		// Token: 0x17004028 RID: 16424
		// (get) Token: 0x06010751 RID: 67409 RVA: 0x00182AEA File Offset: 0x00180CEA
		// (set) Token: 0x06010752 RID: 67410 RVA: 0x00182AFE File Offset: 0x00180CFE
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplinePoint.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplinePoint.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17004029 RID: 16425
		// (get) Token: 0x06010753 RID: 67411 RVA: 0x00182B13 File Offset: 0x00180D13
		// (set) Token: 0x06010754 RID: 67412 RVA: 0x00182B27 File Offset: 0x00180D27
		public unsafe FVector ArriveTangent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplinePoint.__PropertyOffset_ArriveTangent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplinePoint.__PropertyOffset_ArriveTangent) = value;
			}
		}

		// Token: 0x1700402A RID: 16426
		// (get) Token: 0x06010755 RID: 67413 RVA: 0x00182B3C File Offset: 0x00180D3C
		// (set) Token: 0x06010756 RID: 67414 RVA: 0x00182B50 File Offset: 0x00180D50
		public unsafe FVector LeaveTangent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplinePoint.__PropertyOffset_LeaveTangent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplinePoint.__PropertyOffset_LeaveTangent) = value;
			}
		}

		// Token: 0x1700402B RID: 16427
		// (get) Token: 0x06010757 RID: 67415 RVA: 0x00182B65 File Offset: 0x00180D65
		// (set) Token: 0x06010758 RID: 67416 RVA: 0x00182B79 File Offset: 0x00180D79
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplinePoint.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplinePoint.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x1700402C RID: 16428
		// (get) Token: 0x06010759 RID: 67417 RVA: 0x00182B8E File Offset: 0x00180D8E
		// (set) Token: 0x0601075A RID: 67418 RVA: 0x00182BA2 File Offset: 0x00180DA2
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplinePoint.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplinePoint.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x1700402D RID: 16429
		// (get) Token: 0x0601075B RID: 67419 RVA: 0x00182BB7 File Offset: 0x00180DB7
		// (set) Token: 0x0601075C RID: 67420 RVA: 0x00182BCB File Offset: 0x00180DCB
		public unsafe TEnumAsByte<ESplinePointType> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplinePoint.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplinePoint.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x0601075D RID: 67421 RVA: 0x00182BE0 File Offset: 0x00180DE0
		public FSplinePoint()
		{
		}

		// Token: 0x0601075E RID: 67422 RVA: 0x00182BE8 File Offset: 0x00180DE8
		public FSplinePoint(float InputKey, FVector Position, FVector ArriveTangent, FVector LeaveTangent, FRotator Rotation, FVector Scale, TEnumAsByte<ESplinePointType> Type)
		{
			this.InputKey = InputKey;
			this.Position = Position;
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.Rotation = Rotation;
			this.Scale = Scale;
			this.Type = Type;
		}

		// Token: 0x0601075F RID: 67423 RVA: 0x00182C25 File Offset: 0x00180E25
		protected override IntPtr GetUStructPtr()
		{
			return FSplinePoint.StaticStruct();
		}

		// Token: 0x06010760 RID: 67424 RVA: 0x00182C31 File Offset: 0x00180E31
		[NullableContext(2)]
		public FSplinePoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010761 RID: 67425 RVA: 0x00182C3B File Offset: 0x00180E3B
		public FSplinePoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010762 RID: 67426 RVA: 0x00182C46 File Offset: 0x00180E46
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSplinePoint(Pointer, false, true);
		}

		// Token: 0x06010763 RID: 67427 RVA: 0x00182C50 File Offset: 0x00180E50
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSplinePoint(Pointer, MemoryOwner);
		}

		// Token: 0x04008CD6 RID: 36054
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SplinePoint";

		// Token: 0x04008CD7 RID: 36055
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008CD8 RID: 36056
		internal static int __PropertyOffset_InputKey;

		// Token: 0x04008CD9 RID: 36057
		internal static int __PropertyOffset_Position;

		// Token: 0x04008CDA RID: 36058
		internal static int __PropertyOffset_ArriveTangent;

		// Token: 0x04008CDB RID: 36059
		internal static int __PropertyOffset_LeaveTangent;

		// Token: 0x04008CDC RID: 36060
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04008CDD RID: 36061
		internal static int __PropertyOffset_Scale;

		// Token: 0x04008CDE RID: 36062
		internal static int __PropertyOffset_Type;
	}
}
