using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200069E RID: 1694
	[UnrealObjectPath("/Script/ControlRig.RigUnit_NameTruncate")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_NameTruncate : FRigUnit_NameBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060059EB RID: 23019 RVA: 0x0008119A File Offset: 0x0007F39A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_NameTruncate._ScriptStructPtr != 0) ? FRigUnit_NameTruncate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_NameTruncate", ref FRigUnit_NameTruncate._ScriptStructPtr);
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x060059EC RID: 23020 RVA: 0x000811BE File Offset: 0x0007F3BE
		// (set) Token: 0x060059ED RID: 23021 RVA: 0x000811D2 File Offset: 0x0007F3D2
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NameTruncate.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NameTruncate.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x060059EE RID: 23022 RVA: 0x000811E7 File Offset: 0x0007F3E7
		// (set) Token: 0x060059EF RID: 23023 RVA: 0x000811F7 File Offset: 0x0007F3F7
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NameTruncate.__PropertyOffset_Count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NameTruncate.__PropertyOffset_Count) = value;
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x060059F0 RID: 23024 RVA: 0x00081208 File Offset: 0x0007F408
		// (set) Token: 0x060059F1 RID: 23025 RVA: 0x00081218 File Offset: 0x0007F418
		public unsafe bool FromEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NameTruncate.__PropertyOffset_FromEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NameTruncate.__PropertyOffset_FromEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x060059F2 RID: 23026 RVA: 0x00081229 File Offset: 0x0007F429
		// (set) Token: 0x060059F3 RID: 23027 RVA: 0x0008123D File Offset: 0x0007F43D
		public unsafe FName Remainder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NameTruncate.__PropertyOffset_Remainder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NameTruncate.__PropertyOffset_Remainder) = value;
			}
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x060059F4 RID: 23028 RVA: 0x00081252 File Offset: 0x0007F452
		// (set) Token: 0x060059F5 RID: 23029 RVA: 0x00081266 File Offset: 0x0007F466
		public unsafe FName Chopped
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NameTruncate.__PropertyOffset_Chopped);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NameTruncate.__PropertyOffset_Chopped) = value;
			}
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x0008127B File Offset: 0x0007F47B
		public FRigUnit_NameTruncate()
		{
		}

		// Token: 0x060059F7 RID: 23031 RVA: 0x00081283 File Offset: 0x0007F483
		public FRigUnit_NameTruncate(FName Name, int Count, bool FromEnd, FName Remainder, FName Chopped)
		{
			this.Name = Name;
			this.Count = Count;
			this.FromEnd = FromEnd;
			this.Remainder = Remainder;
			this.Chopped = Chopped;
		}

		// Token: 0x060059F8 RID: 23032 RVA: 0x000812B0 File Offset: 0x0007F4B0
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_NameTruncate.StaticStruct();
		}

		// Token: 0x060059F9 RID: 23033 RVA: 0x000812BC File Offset: 0x0007F4BC
		[NullableContext(2)]
		public FRigUnit_NameTruncate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060059FA RID: 23034 RVA: 0x000812C6 File Offset: 0x0007F4C6
		public FRigUnit_NameTruncate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060059FB RID: 23035 RVA: 0x000812D1 File Offset: 0x0007F4D1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_NameTruncate(Pointer, false, true);
		}

		// Token: 0x060059FC RID: 23036 RVA: 0x000812DB File Offset: 0x0007F4DB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_NameTruncate(Pointer, MemoryOwner);
		}

		// Token: 0x04002A18 RID: 10776
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_NameTruncate";

		// Token: 0x04002A19 RID: 10777
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A1A RID: 10778
		internal static int __PropertyOffset_Name;

		// Token: 0x04002A1B RID: 10779
		internal static int __PropertyOffset_Count;

		// Token: 0x04002A1C RID: 10780
		internal static int __PropertyOffset_FromEnd;

		// Token: 0x04002A1D RID: 10781
		internal static int __PropertyOffset_Remainder;

		// Token: 0x04002A1E RID: 10782
		internal static int __PropertyOffset_Chopped;
	}
}
