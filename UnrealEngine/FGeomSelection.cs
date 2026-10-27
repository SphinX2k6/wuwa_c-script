using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C0A RID: 3082
	[UnrealObjectPath("/Script/Engine.GeomSelection")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FGeomSelection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009B42 RID: 39746 RVA: 0x000DC9FE File Offset: 0x000DABFE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGeomSelection._ScriptStructPtr != 0) ? FGeomSelection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.GeomSelection", ref FGeomSelection._ScriptStructPtr);
		}

		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x06009B43 RID: 39747 RVA: 0x000DCA22 File Offset: 0x000DAC22
		// (set) Token: 0x06009B44 RID: 39748 RVA: 0x000DCA32 File Offset: 0x000DAC32
		public unsafe int Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomSelection.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomSelection.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x06009B45 RID: 39749 RVA: 0x000DCA43 File Offset: 0x000DAC43
		// (set) Token: 0x06009B46 RID: 39750 RVA: 0x000DCA53 File Offset: 0x000DAC53
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomSelection.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomSelection.__PropertyOffset_Index) = value;
			}
		}

		// Token: 0x170024EB RID: 9451
		// (get) Token: 0x06009B47 RID: 39751 RVA: 0x000DCA64 File Offset: 0x000DAC64
		// (set) Token: 0x06009B48 RID: 39752 RVA: 0x000DCA74 File Offset: 0x000DAC74
		public unsafe int SelectionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomSelection.__PropertyOffset_SelectionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomSelection.__PropertyOffset_SelectionIndex) = value;
			}
		}

		// Token: 0x06009B49 RID: 39753 RVA: 0x000DCA85 File Offset: 0x000DAC85
		public FGeomSelection()
		{
		}

		// Token: 0x06009B4A RID: 39754 RVA: 0x000DCA8D File Offset: 0x000DAC8D
		public FGeomSelection(int Type, int Index, int SelectionIndex)
		{
			this.Type = Type;
			this.Index = Index;
			this.SelectionIndex = SelectionIndex;
		}

		// Token: 0x06009B4B RID: 39755 RVA: 0x000DCAAA File Offset: 0x000DACAA
		protected override IntPtr GetUStructPtr()
		{
			return FGeomSelection.StaticStruct();
		}

		// Token: 0x06009B4C RID: 39756 RVA: 0x000DCAB6 File Offset: 0x000DACB6
		[NullableContext(2)]
		public FGeomSelection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009B4D RID: 39757 RVA: 0x000DCAC0 File Offset: 0x000DACC0
		public FGeomSelection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009B4E RID: 39758 RVA: 0x000DCACB File Offset: 0x000DACCB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGeomSelection(Pointer, false, true);
		}

		// Token: 0x06009B4F RID: 39759 RVA: 0x000DCAD5 File Offset: 0x000DACD5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGeomSelection(Pointer, MemoryOwner);
		}

		// Token: 0x040055B5 RID: 21941
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.GeomSelection";

		// Token: 0x040055B6 RID: 21942
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040055B7 RID: 21943
		internal static int __PropertyOffset_Type;

		// Token: 0x040055B8 RID: 21944
		internal static int __PropertyOffset_Index;

		// Token: 0x040055B9 RID: 21945
		internal static int __PropertyOffset_SelectionIndex;
	}
}
