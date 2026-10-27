using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000739 RID: 1849
	[UnrealObjectPath("/Script/CoreUObject.InterpCurvePointQuat")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FInterpCurvePointQuat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600625B RID: 25179 RVA: 0x0008D122 File Offset: 0x0008B322
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurvePointQuat._ScriptStructPtr != 0) ? FInterpCurvePointQuat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurvePointQuat", ref FInterpCurvePointQuat._ScriptStructPtr);
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x0600625C RID: 25180 RVA: 0x0008D146 File Offset: 0x0008B346
		// (set) Token: 0x0600625D RID: 25181 RVA: 0x0008D156 File Offset: 0x0008B356
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

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x0600625E RID: 25182 RVA: 0x0008D167 File Offset: 0x0008B367
		// (set) Token: 0x0600625F RID: 25183 RVA: 0x0008D17B File Offset: 0x0008B37B
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

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06006260 RID: 25184 RVA: 0x0008D190 File Offset: 0x0008B390
		// (set) Token: 0x06006261 RID: 25185 RVA: 0x0008D1A4 File Offset: 0x0008B3A4
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

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06006262 RID: 25186 RVA: 0x0008D1B9 File Offset: 0x0008B3B9
		// (set) Token: 0x06006263 RID: 25187 RVA: 0x0008D1CD File Offset: 0x0008B3CD
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

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x06006264 RID: 25188 RVA: 0x0008D1E2 File Offset: 0x0008B3E2
		// (set) Token: 0x06006265 RID: 25189 RVA: 0x0008D1F6 File Offset: 0x0008B3F6
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

		// Token: 0x06006266 RID: 25190 RVA: 0x0008D20B File Offset: 0x0008B40B
		public FInterpCurvePointQuat()
		{
		}

		// Token: 0x06006267 RID: 25191 RVA: 0x0008D213 File Offset: 0x0008B413
		public FInterpCurvePointQuat(float InVal, FQuat OutVal, FQuat ArriveTangent, FQuat LeaveTangent, TEnumAsByte<EInterpCurveMode> InterpMode)
		{
			this.InVal = InVal;
			this.OutVal = OutVal;
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.InterpMode = InterpMode;
		}

		// Token: 0x06006268 RID: 25192 RVA: 0x0008D240 File Offset: 0x0008B440
		protected override IntPtr GetUStructPtr()
		{
			return FInterpCurvePointQuat.StaticStruct();
		}

		// Token: 0x06006269 RID: 25193 RVA: 0x0008D24C File Offset: 0x0008B44C
		[NullableContext(2)]
		public FInterpCurvePointQuat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600626A RID: 25194 RVA: 0x0008D256 File Offset: 0x0008B456
		public FInterpCurvePointQuat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600626B RID: 25195 RVA: 0x0008D261 File Offset: 0x0008B461
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpCurvePointQuat(Pointer, false, true);
		}

		// Token: 0x0600626C RID: 25196 RVA: 0x0008D26B File Offset: 0x0008B46B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpCurvePointQuat(Pointer, MemoryOwner);
		}

		// Token: 0x04002F00 RID: 12032
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurvePointQuat";

		// Token: 0x04002F01 RID: 12033
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002F02 RID: 12034
		internal static int __PropertyOffset_InVal;

		// Token: 0x04002F03 RID: 12035
		internal static int __PropertyOffset_OutVal;

		// Token: 0x04002F04 RID: 12036
		internal static int __PropertyOffset_ArriveTangent;

		// Token: 0x04002F05 RID: 12037
		internal static int __PropertyOffset_LeaveTangent;

		// Token: 0x04002F06 RID: 12038
		internal static int __PropertyOffset_InterpMode;
	}
}
