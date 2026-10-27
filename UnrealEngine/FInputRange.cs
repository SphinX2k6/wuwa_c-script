using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C5C RID: 3164
	[UnrealObjectPath("/Script/Engine.InputRange")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FInputRange : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A063 RID: 41059 RVA: 0x000E3E0E File Offset: 0x000E200E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputRange._ScriptStructPtr != 0) ? FInputRange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InputRange", ref FInputRange._ScriptStructPtr);
		}

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x0600A064 RID: 41060 RVA: 0x000E3E32 File Offset: 0x000E2032
		// (set) Token: 0x0600A065 RID: 41061 RVA: 0x000E3E42 File Offset: 0x000E2042
		public unsafe float Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputRange.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputRange.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x17002630 RID: 9776
		// (get) Token: 0x0600A066 RID: 41062 RVA: 0x000E3E53 File Offset: 0x000E2053
		// (set) Token: 0x0600A067 RID: 41063 RVA: 0x000E3E63 File Offset: 0x000E2063
		public unsafe float Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputRange.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputRange.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x0600A068 RID: 41064 RVA: 0x000E3E74 File Offset: 0x000E2074
		public FInputRange()
		{
		}

		// Token: 0x0600A069 RID: 41065 RVA: 0x000E3E7C File Offset: 0x000E207C
		public FInputRange(float Min, float Max)
		{
			this.Min = Min;
			this.Max = Max;
		}

		// Token: 0x0600A06A RID: 41066 RVA: 0x000E3E92 File Offset: 0x000E2092
		protected override IntPtr GetUStructPtr()
		{
			return FInputRange.StaticStruct();
		}

		// Token: 0x0600A06B RID: 41067 RVA: 0x000E3E9E File Offset: 0x000E209E
		[NullableContext(2)]
		public FInputRange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A06C RID: 41068 RVA: 0x000E3EA8 File Offset: 0x000E20A8
		public FInputRange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A06D RID: 41069 RVA: 0x000E3EB3 File Offset: 0x000E20B3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputRange(Pointer, false, true);
		}

		// Token: 0x0600A06E RID: 41070 RVA: 0x000E3EBD File Offset: 0x000E20BD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputRange(Pointer, MemoryOwner);
		}

		// Token: 0x04005832 RID: 22578
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InputRange";

		// Token: 0x04005833 RID: 22579
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005834 RID: 22580
		internal static int __PropertyOffset_Min;

		// Token: 0x04005835 RID: 22581
		internal static int __PropertyOffset_Max;
	}
}
