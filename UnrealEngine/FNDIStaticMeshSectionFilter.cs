using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200253D RID: 9533
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NDIStaticMeshSectionFilter")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNDIStaticMeshSectionFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023626 RID: 144934 RVA: 0x003453D8 File Offset: 0x003435D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNDIStaticMeshSectionFilter._ScriptStructPtr != 0) ? FNDIStaticMeshSectionFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NDIStaticMeshSectionFilter", ref FNDIStaticMeshSectionFilter._ScriptStructPtr);
		}

		// Token: 0x17008801 RID: 34817
		// (get) Token: 0x06023627 RID: 144935 RVA: 0x003453FC File Offset: 0x003435FC
		// (set) Token: 0x06023628 RID: 144936 RVA: 0x0034543F File Offset: 0x0034363F
		public TArray<int> AllowedMaterialSlots
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._AllowedMaterialSlots) == null)
				{
					result = (this._AllowedMaterialSlots = new TArray<int>(base.NativePtr + (IntPtr)FNDIStaticMeshSectionFilter.__PropertyOffset_AllowedMaterialSlots, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AllowedMaterialSlots.CopyAssign(value);
			}
		}

		// Token: 0x06023629 RID: 144937 RVA: 0x0034544D File Offset: 0x0034364D
		public FNDIStaticMeshSectionFilter()
		{
		}

		// Token: 0x0602362A RID: 144938 RVA: 0x00345455 File Offset: 0x00343655
		public FNDIStaticMeshSectionFilter(TArray<int> AllowedMaterialSlots)
		{
			this.AllowedMaterialSlots = AllowedMaterialSlots;
		}

		// Token: 0x0602362B RID: 144939 RVA: 0x00345464 File Offset: 0x00343664
		protected override IntPtr GetUStructPtr()
		{
			return FNDIStaticMeshSectionFilter.StaticStruct();
		}

		// Token: 0x0602362C RID: 144940 RVA: 0x00345470 File Offset: 0x00343670
		[NullableContext(2)]
		public FNDIStaticMeshSectionFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602362D RID: 144941 RVA: 0x0034547A File Offset: 0x0034367A
		public FNDIStaticMeshSectionFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602362E RID: 144942 RVA: 0x00345485 File Offset: 0x00343685
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNDIStaticMeshSectionFilter(Pointer, false, true);
		}

		// Token: 0x0602362F RID: 144943 RVA: 0x0034548F File Offset: 0x0034368F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNDIStaticMeshSectionFilter(Pointer, MemoryOwner);
		}

		// Token: 0x04012FDC RID: 77788
		public const string __ObjectPath = "/Script/Niagara.NDIStaticMeshSectionFilter";

		// Token: 0x04012FDD RID: 77789
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FDE RID: 77790
		internal static int __PropertyOffset_AllowedMaterialSlots;

		// Token: 0x04012FDF RID: 77791
		[Nullable(2)]
		private TArray<int> _AllowedMaterialSlots;
	}
}
