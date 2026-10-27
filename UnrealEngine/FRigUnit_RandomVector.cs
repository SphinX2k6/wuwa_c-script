using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006AE RID: 1710
	[UnrealObjectPath("/Script/ControlRig.RigUnit_RandomVector")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_RandomVector : FRigUnit_MathBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005B27 RID: 23335 RVA: 0x00082E44 File Offset: 0x00081044
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_RandomVector._ScriptStructPtr != 0) ? FRigUnit_RandomVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_RandomVector", ref FRigUnit_RandomVector._ScriptStructPtr);
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x06005B28 RID: 23336 RVA: 0x00082E68 File Offset: 0x00081068
		// (set) Token: 0x06005B29 RID: 23337 RVA: 0x00082E78 File Offset: 0x00081078
		public unsafe int Seed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_Seed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_Seed) = value;
			}
		}

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x06005B2A RID: 23338 RVA: 0x00082E89 File Offset: 0x00081089
		// (set) Token: 0x06005B2B RID: 23339 RVA: 0x00082E99 File Offset: 0x00081099
		public unsafe float Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06005B2C RID: 23340 RVA: 0x00082EAA File Offset: 0x000810AA
		// (set) Token: 0x06005B2D RID: 23341 RVA: 0x00082EBA File Offset: 0x000810BA
		public unsafe float Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06005B2E RID: 23342 RVA: 0x00082ECB File Offset: 0x000810CB
		// (set) Token: 0x06005B2F RID: 23343 RVA: 0x00082EDB File Offset: 0x000810DB
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06005B30 RID: 23344 RVA: 0x00082EEC File Offset: 0x000810EC
		// (set) Token: 0x06005B31 RID: 23345 RVA: 0x00082F00 File Offset: 0x00081100
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06005B32 RID: 23346 RVA: 0x00082F15 File Offset: 0x00081115
		// (set) Token: 0x06005B33 RID: 23347 RVA: 0x00082F29 File Offset: 0x00081129
		public unsafe FVector LastResult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_LastResult);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_LastResult) = value;
			}
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06005B34 RID: 23348 RVA: 0x00082F3E File Offset: 0x0008113E
		// (set) Token: 0x06005B35 RID: 23349 RVA: 0x00082F4E File Offset: 0x0008114E
		public unsafe int LastSeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_LastSeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_LastSeed) = value;
			}
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06005B36 RID: 23350 RVA: 0x00082F5F File Offset: 0x0008115F
		// (set) Token: 0x06005B37 RID: 23351 RVA: 0x00082F6F File Offset: 0x0008116F
		public unsafe float TimeLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_TimeLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_RandomVector.__PropertyOffset_TimeLeft) = value;
			}
		}

		// Token: 0x06005B38 RID: 23352 RVA: 0x00082F80 File Offset: 0x00081180
		public FRigUnit_RandomVector()
		{
		}

		// Token: 0x06005B39 RID: 23353 RVA: 0x00082F88 File Offset: 0x00081188
		public FRigUnit_RandomVector(int Seed, float Minimum, float Maximum, float Duration, FVector Result, FVector LastResult, int LastSeed, float TimeLeft)
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

		// Token: 0x06005B3A RID: 23354 RVA: 0x00082FD8 File Offset: 0x000811D8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_RandomVector.StaticStruct();
		}

		// Token: 0x06005B3B RID: 23355 RVA: 0x00082FE4 File Offset: 0x000811E4
		[NullableContext(2)]
		public FRigUnit_RandomVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005B3C RID: 23356 RVA: 0x00082FEE File Offset: 0x000811EE
		public FRigUnit_RandomVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005B3D RID: 23357 RVA: 0x00082FF9 File Offset: 0x000811F9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_RandomVector(Pointer, false, true);
		}

		// Token: 0x06005B3E RID: 23358 RVA: 0x00083003 File Offset: 0x00081203
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_RandomVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002AAF RID: 10927
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_RandomVector";

		// Token: 0x04002AB0 RID: 10928
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002AB1 RID: 10929
		internal static int __PropertyOffset_Seed;

		// Token: 0x04002AB2 RID: 10930
		internal static int __PropertyOffset_Minimum;

		// Token: 0x04002AB3 RID: 10931
		internal static int __PropertyOffset_Maximum;

		// Token: 0x04002AB4 RID: 10932
		internal static int __PropertyOffset_Duration;

		// Token: 0x04002AB5 RID: 10933
		internal static int __PropertyOffset_Result;

		// Token: 0x04002AB6 RID: 10934
		internal static int __PropertyOffset_LastResult;

		// Token: 0x04002AB7 RID: 10935
		internal static int __PropertyOffset_LastSeed;

		// Token: 0x04002AB8 RID: 10936
		internal static int __PropertyOffset_TimeLeft;
	}
}
