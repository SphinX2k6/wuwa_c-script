using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200011F RID: 287
	[UnrealObjectPath("/Script/CoreUObject.InterpCurvePointQuat")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FInterpCurvePointQuat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060011BC RID: 4540 RVA: 0x0001C13E File Offset: 0x0001A33E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurvePointQuat._ScriptStructPtr != 0) ? FInterpCurvePointQuat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurvePointQuat", ref FInterpCurvePointQuat._ScriptStructPtr);
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x0001C162 File Offset: 0x0001A362
		// (set) Token: 0x060011BE RID: 4542 RVA: 0x0001C172 File Offset: 0x0001A372
		public unsafe float InVal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurvePointQuat.__PropertyOffset_InVal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurvePointQuat.__PropertyOffset_InVal) = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x0001C183 File Offset: 0x0001A383
		// (set) Token: 0x060011C0 RID: 4544 RVA: 0x0001C197 File Offset: 0x0001A397
		public unsafe FQuat OutVal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurvePointQuat.__PropertyOffset_OutVal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurvePointQuat.__PropertyOffset_OutVal) = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x0001C1AC File Offset: 0x0001A3AC
		// (set) Token: 0x060011C2 RID: 4546 RVA: 0x0001C1C0 File Offset: 0x0001A3C0
		public unsafe FQuat ArriveTangent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurvePointQuat.__PropertyOffset_ArriveTangent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurvePointQuat.__PropertyOffset_ArriveTangent) = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x0001C1D5 File Offset: 0x0001A3D5
		// (set) Token: 0x060011C4 RID: 4548 RVA: 0x0001C1E9 File Offset: 0x0001A3E9
		public unsafe FQuat LeaveTangent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurvePointQuat.__PropertyOffset_LeaveTangent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurvePointQuat.__PropertyOffset_LeaveTangent) = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x0001C1FE File Offset: 0x0001A3FE
		// (set) Token: 0x060011C6 RID: 4550 RVA: 0x0001C212 File Offset: 0x0001A412
		public unsafe TEnumAsByte<EInterpCurveMode> InterpMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurvePointQuat.__PropertyOffset_InterpMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurvePointQuat.__PropertyOffset_InterpMode) = value;
			}
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0001C227 File Offset: 0x0001A427
		public FInterpCurvePointQuat()
		{
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0001C22F File Offset: 0x0001A42F
		protected override IntPtr GetUStructPtr()
		{
			return FInterpCurvePointQuat.StaticStruct();
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0001C23B File Offset: 0x0001A43B
		[NullableContext(2)]
		public FInterpCurvePointQuat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0001C245 File Offset: 0x0001A445
		public FInterpCurvePointQuat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0001C250 File Offset: 0x0001A450
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpCurvePointQuat(Pointer, false, true);
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0001C25A File Offset: 0x0001A45A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpCurvePointQuat(Pointer, MemoryOwner);
		}

		// Token: 0x04000536 RID: 1334
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurvePointQuat";

		// Token: 0x04000537 RID: 1335
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000538 RID: 1336
		internal static int __PropertyOffset_InVal;

		// Token: 0x04000539 RID: 1337
		internal static int __PropertyOffset_OutVal;

		// Token: 0x0400053A RID: 1338
		internal static int __PropertyOffset_ArriveTangent;

		// Token: 0x0400053B RID: 1339
		internal static int __PropertyOffset_LeaveTangent;

		// Token: 0x0400053C RID: 1340
		internal static int __PropertyOffset_InterpMode;
	}
}
