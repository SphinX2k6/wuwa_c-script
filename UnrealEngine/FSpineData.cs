using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007E1 RID: 2017
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.SpineData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSpineData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AD60 RID: 44384 RVA: 0x001006A1 File Offset: 0x000FE8A1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpineData._ScriptStructPtr != 0) ? FSpineData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.SpineData", ref FSpineData._ScriptStructPtr);
		}

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x0600AD61 RID: 44385 RVA: 0x001006C5 File Offset: 0x000FE8C5
		// (set) Token: 0x0600AD62 RID: 44386 RVA: 0x001006D9 File Offset: 0x000FE8D9
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSpineData.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSpineData.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x0600AD63 RID: 44387 RVA: 0x001006EE File Offset: 0x000FE8EE
		// (set) Token: 0x0600AD64 RID: 44388 RVA: 0x001006FE File Offset: 0x000FE8FE
		public unsafe bool NeedLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpineData.__PropertyOffset_NeedLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpineData.__PropertyOffset_NeedLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600AD65 RID: 44389 RVA: 0x0010070F File Offset: 0x000FE90F
		public FSpineData()
		{
		}

		// Token: 0x0600AD66 RID: 44390 RVA: 0x00100717 File Offset: 0x000FE917
		protected override IntPtr GetUStructPtr()
		{
			return FSpineData.StaticStruct();
		}

		// Token: 0x0600AD67 RID: 44391 RVA: 0x00100723 File Offset: 0x000FE923
		[NullableContext(2)]
		public FSpineData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AD68 RID: 44392 RVA: 0x0010072D File Offset: 0x000FE92D
		public FSpineData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AD69 RID: 44393 RVA: 0x00100738 File Offset: 0x000FE938
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpineData(Pointer, false, true);
		}

		// Token: 0x0600AD6A RID: 44394 RVA: 0x00100742 File Offset: 0x000FE942
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpineData(Pointer, MemoryOwner);
		}

		// Token: 0x04004AC1 RID: 19137
		public const string __ObjectPath = "/Script/SequenceDialogue.SpineData";

		// Token: 0x04004AC2 RID: 19138
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004AC3 RID: 19139
		internal static int __PropertyOffset_Name;

		// Token: 0x04004AC4 RID: 19140
		internal static int __PropertyOffset_NeedLoop;
	}
}
