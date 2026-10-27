using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000E94 RID: 3732
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.MaterialParameterInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FMaterialParameterInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600C8BE RID: 51390 RVA: 0x0012439F File Offset: 0x0012259F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialParameterInfo._ScriptStructPtr != 0) ? FMaterialParameterInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialParameterInfo", ref FMaterialParameterInfo._ScriptStructPtr);
		}

		// Token: 0x17002EF2 RID: 12018
		// (get) Token: 0x0600C8BF RID: 51391 RVA: 0x001243C3 File Offset: 0x001225C3
		// (set) Token: 0x0600C8C0 RID: 51392 RVA: 0x001243D7 File Offset: 0x001225D7
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialParameterInfo.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialParameterInfo.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17002EF3 RID: 12019
		// (get) Token: 0x0600C8C1 RID: 51393 RVA: 0x001243EC File Offset: 0x001225EC
		// (set) Token: 0x0600C8C2 RID: 51394 RVA: 0x00124400 File Offset: 0x00122600
		public unsafe TEnumAsByte<EMaterialParameterAssociation> Association
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialParameterInfo.__PropertyOffset_Association);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialParameterInfo.__PropertyOffset_Association) = value;
			}
		}

		// Token: 0x17002EF4 RID: 12020
		// (get) Token: 0x0600C8C3 RID: 51395 RVA: 0x00124415 File Offset: 0x00122615
		// (set) Token: 0x0600C8C4 RID: 51396 RVA: 0x00124425 File Offset: 0x00122625
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialParameterInfo.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialParameterInfo.__PropertyOffset_Index) = value;
			}
		}

		// Token: 0x17002EF5 RID: 12021
		// (get) Token: 0x0600C8C5 RID: 51397 RVA: 0x00124436 File Offset: 0x00122636
		// (set) Token: 0x0600C8C6 RID: 51398 RVA: 0x00124446 File Offset: 0x00122646
		public unsafe uint Flags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialParameterInfo.__PropertyOffset_Flags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialParameterInfo.__PropertyOffset_Flags) = (int)value;
			}
		}

		// Token: 0x0600C8C7 RID: 51399 RVA: 0x00124457 File Offset: 0x00122657
		public FMaterialParameterInfo()
		{
		}

		// Token: 0x0600C8C8 RID: 51400 RVA: 0x0012445F File Offset: 0x0012265F
		public FMaterialParameterInfo(FName Name, TEnumAsByte<EMaterialParameterAssociation> Association, int Index, uint Flags, [Nullable(1)] FSoftObjectPath ParameterLocation)
		{
			this.Name = Name;
			this.Association = Association;
			this.Index = Index;
			this.Flags = Flags;
		}

		// Token: 0x0600C8C9 RID: 51401 RVA: 0x00124484 File Offset: 0x00122684
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialParameterInfo.StaticStruct();
		}

		// Token: 0x0600C8CA RID: 51402 RVA: 0x00124490 File Offset: 0x00122690
		[NullableContext(2)]
		public FMaterialParameterInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600C8CB RID: 51403 RVA: 0x0012449A File Offset: 0x0012269A
		public FMaterialParameterInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600C8CC RID: 51404 RVA: 0x001244A5 File Offset: 0x001226A5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialParameterInfo(Pointer, false, true);
		}

		// Token: 0x0600C8CD RID: 51405 RVA: 0x001244AF File Offset: 0x001226AF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialParameterInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04006C05 RID: 27653
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MaterialParameterInfo";

		// Token: 0x04006C06 RID: 27654
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006C07 RID: 27655
		internal static int __PropertyOffset_Name;

		// Token: 0x04006C08 RID: 27656
		internal static int __PropertyOffset_Association;

		// Token: 0x04006C09 RID: 27657
		internal static int __PropertyOffset_Index;

		// Token: 0x04006C0A RID: 27658
		internal static int __PropertyOffset_Flags;
	}
}
