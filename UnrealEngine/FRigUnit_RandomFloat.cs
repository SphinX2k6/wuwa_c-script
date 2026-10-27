using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006AD RID: 1709
	[UnrealObjectPath("/Script/ControlRig.RigUnit_RandomFloat")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_RandomFloat : FRigUnit_MathBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005B0F RID: 23311 RVA: 0x00082C89 File Offset: 0x00080E89
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_RandomFloat._ScriptStructPtr != 0) ? FRigUnit_RandomFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_RandomFloat", ref FRigUnit_RandomFloat._ScriptStructPtr);
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06005B10 RID: 23312 RVA: 0x00082CAD File Offset: 0x00080EAD
		// (set) Token: 0x06005B11 RID: 23313 RVA: 0x00082CBD File Offset: 0x00080EBD
		public unsafe int Seed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_Seed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_Seed) = value;
			}
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06005B12 RID: 23314 RVA: 0x00082CCE File Offset: 0x00080ECE
		// (set) Token: 0x06005B13 RID: 23315 RVA: 0x00082CDE File Offset: 0x00080EDE
		public unsafe float Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06005B14 RID: 23316 RVA: 0x00082CEF File Offset: 0x00080EEF
		// (set) Token: 0x06005B15 RID: 23317 RVA: 0x00082CFF File Offset: 0x00080EFF
		public unsafe float Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06005B16 RID: 23318 RVA: 0x00082D10 File Offset: 0x00080F10
		// (set) Token: 0x06005B17 RID: 23319 RVA: 0x00082D20 File Offset: 0x00080F20
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06005B18 RID: 23320 RVA: 0x00082D31 File Offset: 0x00080F31
		// (set) Token: 0x06005B19 RID: 23321 RVA: 0x00082D41 File Offset: 0x00080F41
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06005B1A RID: 23322 RVA: 0x00082D52 File Offset: 0x00080F52
		// (set) Token: 0x06005B1B RID: 23323 RVA: 0x00082D62 File Offset: 0x00080F62
		public unsafe float LastResult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_LastResult);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_LastResult) = value;
			}
		}

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06005B1C RID: 23324 RVA: 0x00082D73 File Offset: 0x00080F73
		// (set) Token: 0x06005B1D RID: 23325 RVA: 0x00082D83 File Offset: 0x00080F83
		public unsafe int LastSeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_LastSeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_LastSeed) = value;
			}
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06005B1E RID: 23326 RVA: 0x00082D94 File Offset: 0x00080F94
		// (set) Token: 0x06005B1F RID: 23327 RVA: 0x00082DA4 File Offset: 0x00080FA4
		public unsafe float TimeLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_TimeLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomFloat.__PropertyOffset_TimeLeft) = value;
			}
		}

		// Token: 0x06005B20 RID: 23328 RVA: 0x00082DB5 File Offset: 0x00080FB5
		public FRigUnit_RandomFloat()
		{
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x00082DC0 File Offset: 0x00080FC0
		public FRigUnit_RandomFloat(int Seed, float Minimum, float Maximum, float Duration, float Result, float LastResult, int LastSeed, float TimeLeft)
		{
			this.Seed = Seed;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.Duration = Duration;
			this.Result = Result;
			this.LastResult = LastResult;
			this.LastSeed = LastSeed;
			this.TimeLeft = TimeLeft;
		}

		// Token: 0x06005B22 RID: 23330 RVA: 0x00082E10 File Offset: 0x00081010
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_RandomFloat.StaticStruct();
		}

		// Token: 0x06005B23 RID: 23331 RVA: 0x00082E1C File Offset: 0x0008101C
		[NullableContext(2)]
		public FRigUnit_RandomFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005B24 RID: 23332 RVA: 0x00082E26 File Offset: 0x00081026
		public FRigUnit_RandomFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005B25 RID: 23333 RVA: 0x00082E31 File Offset: 0x00081031
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_RandomFloat(Pointer, false, true);
		}

		// Token: 0x06005B26 RID: 23334 RVA: 0x00082E3B File Offset: 0x0008103B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_RandomFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04002AA5 RID: 10917
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_RandomFloat";

		// Token: 0x04002AA6 RID: 10918
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002AA7 RID: 10919
		internal static int __PropertyOffset_Seed;

		// Token: 0x04002AA8 RID: 10920
		internal static int __PropertyOffset_Minimum;

		// Token: 0x04002AA9 RID: 10921
		internal static int __PropertyOffset_Maximum;

		// Token: 0x04002AAA RID: 10922
		internal static int __PropertyOffset_Duration;

		// Token: 0x04002AAB RID: 10923
		internal static int __PropertyOffset_Result;

		// Token: 0x04002AAC RID: 10924
		internal static int __PropertyOffset_LastResult;

		// Token: 0x04002AAD RID: 10925
		internal static int __PropertyOffset_LastSeed;

		// Token: 0x04002AAE RID: 10926
		internal static int __PropertyOffset_TimeLeft;
	}
}
