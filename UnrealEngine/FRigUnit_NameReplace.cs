using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200069D RID: 1693
	[UnrealObjectPath("/Script/ControlRig.RigUnit_NameReplace")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_NameReplace : FRigUnit_NameBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060059DB RID: 23003 RVA: 0x00081071 File Offset: 0x0007F271
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_NameReplace._ScriptStructPtr != 0) ? FRigUnit_NameReplace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_NameReplace", ref FRigUnit_NameReplace._ScriptStructPtr);
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x060059DC RID: 23004 RVA: 0x00081095 File Offset: 0x0007F295
		// (set) Token: 0x060059DD RID: 23005 RVA: 0x000810A9 File Offset: 0x0007F2A9
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NameReplace.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NameReplace.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x060059DE RID: 23006 RVA: 0x000810BE File Offset: 0x0007F2BE
		// (set) Token: 0x060059DF RID: 23007 RVA: 0x000810D2 File Offset: 0x0007F2D2
		public unsafe FName Old
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NameReplace.__PropertyOffset_Old);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NameReplace.__PropertyOffset_Old) = value;
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x060059E0 RID: 23008 RVA: 0x000810E7 File Offset: 0x0007F2E7
		// (set) Token: 0x060059E1 RID: 23009 RVA: 0x000810FB File Offset: 0x0007F2FB
		public unsafe FName New
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NameReplace.__PropertyOffset_New);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NameReplace.__PropertyOffset_New) = value;
			}
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x060059E2 RID: 23010 RVA: 0x00081110 File Offset: 0x0007F310
		// (set) Token: 0x060059E3 RID: 23011 RVA: 0x00081124 File Offset: 0x0007F324
		public unsafe FName Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NameReplace.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NameReplace.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060059E4 RID: 23012 RVA: 0x00081139 File Offset: 0x0007F339
		public FRigUnit_NameReplace()
		{
		}

		// Token: 0x060059E5 RID: 23013 RVA: 0x00081141 File Offset: 0x0007F341
		public FRigUnit_NameReplace(FName Name, FName Old, FName New, FName Result)
		{
			this.Name = Name;
			this.Old = Old;
			this.New = New;
			this.Result = Result;
		}

		// Token: 0x060059E6 RID: 23014 RVA: 0x00081166 File Offset: 0x0007F366
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_NameReplace.StaticStruct();
		}

		// Token: 0x060059E7 RID: 23015 RVA: 0x00081172 File Offset: 0x0007F372
		[NullableContext(2)]
		public FRigUnit_NameReplace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060059E8 RID: 23016 RVA: 0x0008117C File Offset: 0x0007F37C
		public FRigUnit_NameReplace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060059E9 RID: 23017 RVA: 0x00081187 File Offset: 0x0007F387
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_NameReplace(Pointer, false, true);
		}

		// Token: 0x060059EA RID: 23018 RVA: 0x00081191 File Offset: 0x0007F391
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_NameReplace(Pointer, MemoryOwner);
		}

		// Token: 0x04002A12 RID: 10770
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_NameReplace";

		// Token: 0x04002A13 RID: 10771
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A14 RID: 10772
		internal static int __PropertyOffset_Name;

		// Token: 0x04002A15 RID: 10773
		internal static int __PropertyOffset_Old;

		// Token: 0x04002A16 RID: 10774
		internal static int __PropertyOffset_New;

		// Token: 0x04002A17 RID: 10775
		internal static int __PropertyOffset_Result;
	}
}
