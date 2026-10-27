using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001108 RID: 4360
	[UnrealObjectPath("/Script/Engine.SkeletalMeshSamplingRegionMaterialFilter")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FSkeletalMeshSamplingRegionMaterialFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FD04 RID: 64772 RVA: 0x00175A7E File Offset: 0x00173C7E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMeshSamplingRegionMaterialFilter._ScriptStructPtr != 0) ? FSkeletalMeshSamplingRegionMaterialFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMeshSamplingRegionMaterialFilter", ref FSkeletalMeshSamplingRegionMaterialFilter._ScriptStructPtr);
		}

		// Token: 0x17003DB9 RID: 15801
		// (get) Token: 0x0600FD05 RID: 64773 RVA: 0x00175AA2 File Offset: 0x00173CA2
		// (set) Token: 0x0600FD06 RID: 64774 RVA: 0x00175AB6 File Offset: 0x00173CB6
		public unsafe FName MaterialName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegionMaterialFilter.__PropertyOffset_MaterialName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegionMaterialFilter.__PropertyOffset_MaterialName) = value;
			}
		}

		// Token: 0x0600FD07 RID: 64775 RVA: 0x00175ACB File Offset: 0x00173CCB
		public FSkeletalMeshSamplingRegionMaterialFilter()
		{
		}

		// Token: 0x0600FD08 RID: 64776 RVA: 0x00175AD3 File Offset: 0x00173CD3
		public FSkeletalMeshSamplingRegionMaterialFilter(FName MaterialName)
		{
			this.MaterialName = MaterialName;
		}

		// Token: 0x0600FD09 RID: 64777 RVA: 0x00175AE2 File Offset: 0x00173CE2
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMeshSamplingRegionMaterialFilter.StaticStruct();
		}

		// Token: 0x0600FD0A RID: 64778 RVA: 0x00175AEE File Offset: 0x00173CEE
		[NullableContext(2)]
		public FSkeletalMeshSamplingRegionMaterialFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FD0B RID: 64779 RVA: 0x00175AF8 File Offset: 0x00173CF8
		public FSkeletalMeshSamplingRegionMaterialFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FD0C RID: 64780 RVA: 0x00175B03 File Offset: 0x00173D03
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMeshSamplingRegionMaterialFilter(Pointer, false, true);
		}

		// Token: 0x0600FD0D RID: 64781 RVA: 0x00175B0D File Offset: 0x00173D0D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMeshSamplingRegionMaterialFilter(Pointer, MemoryOwner);
		}

		// Token: 0x04008861 RID: 34913
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SkeletalMeshSamplingRegionMaterialFilter";

		// Token: 0x04008862 RID: 34914
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008863 RID: 34915
		internal static int __PropertyOffset_MaterialName;
	}
}
