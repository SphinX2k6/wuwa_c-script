using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200028A RID: 650
	[UnrealObjectPath("/Script/Engine.SplinePoint")]
	[UnrealStructLayout(68, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 68)]
	public class FSplinePoint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600476C RID: 18284 RVA: 0x00064061 File Offset: 0x00062261
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSplinePoint._ScriptStructPtr != 0) ? FSplinePoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SplinePoint", ref FSplinePoint._ScriptStructPtr);
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x0600476D RID: 18285 RVA: 0x00064085 File Offset: 0x00062285
		// (set) Token: 0x0600476E RID: 18286 RVA: 0x00064095 File Offset: 0x00062295
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

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x0600476F RID: 18287 RVA: 0x000640A6 File Offset: 0x000622A6
		// (set) Token: 0x06004770 RID: 18288 RVA: 0x000640BA File Offset: 0x000622BA
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

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06004771 RID: 18289 RVA: 0x000640CF File Offset: 0x000622CF
		// (set) Token: 0x06004772 RID: 18290 RVA: 0x000640E3 File Offset: 0x000622E3
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

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06004773 RID: 18291 RVA: 0x000640F8 File Offset: 0x000622F8
		// (set) Token: 0x06004774 RID: 18292 RVA: 0x0006410C File Offset: 0x0006230C
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

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06004775 RID: 18293 RVA: 0x00064121 File Offset: 0x00062321
		// (set) Token: 0x06004776 RID: 18294 RVA: 0x00064135 File Offset: 0x00062335
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

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06004777 RID: 18295 RVA: 0x0006414A File Offset: 0x0006234A
		// (set) Token: 0x06004778 RID: 18296 RVA: 0x0006415E File Offset: 0x0006235E
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

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06004779 RID: 18297 RVA: 0x00064173 File Offset: 0x00062373
		// (set) Token: 0x0600477A RID: 18298 RVA: 0x00064187 File Offset: 0x00062387
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

		// Token: 0x0600477B RID: 18299 RVA: 0x0006419C File Offset: 0x0006239C
		public FSplinePoint()
		{
		}

		// Token: 0x0600477C RID: 18300 RVA: 0x000641A4 File Offset: 0x000623A4
		protected override IntPtr GetUStructPtr()
		{
			return FSplinePoint.StaticStruct();
		}

		// Token: 0x0600477D RID: 18301 RVA: 0x000641B0 File Offset: 0x000623B0
		[NullableContext(2)]
		public FSplinePoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x000641BA File Offset: 0x000623BA
		public FSplinePoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x000641C5 File Offset: 0x000623C5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSplinePoint(Pointer, false, true);
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x000641CF File Offset: 0x000623CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSplinePoint(Pointer, MemoryOwner);
		}

		// Token: 0x04001B76 RID: 7030
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SplinePoint";

		// Token: 0x04001B77 RID: 7031
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001B78 RID: 7032
		internal static int __PropertyOffset_InputKey;

		// Token: 0x04001B79 RID: 7033
		internal static int __PropertyOffset_Position;

		// Token: 0x04001B7A RID: 7034
		internal static int __PropertyOffset_ArriveTangent;

		// Token: 0x04001B7B RID: 7035
		internal static int __PropertyOffset_LeaveTangent;

		// Token: 0x04001B7C RID: 7036
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04001B7D RID: 7037
		internal static int __PropertyOffset_Scale;

		// Token: 0x04001B7E RID: 7038
		internal static int __PropertyOffset_Type;
	}
}
