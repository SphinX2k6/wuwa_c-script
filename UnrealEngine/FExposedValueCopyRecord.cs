using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BCA RID: 3018
	[UnrealObjectPath("/Script/Engine.ExposedValueCopyRecord")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FExposedValueCopyRecord : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600945C RID: 37980 RVA: 0x000D3D61 File Offset: 0x000D1F61
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExposedValueCopyRecord._ScriptStructPtr != 0) ? FExposedValueCopyRecord._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ExposedValueCopyRecord", ref FExposedValueCopyRecord._ScriptStructPtr);
		}

		// Token: 0x17002388 RID: 9096
		// (get) Token: 0x0600945D RID: 37981 RVA: 0x000D3D85 File Offset: 0x000D1F85
		// (set) Token: 0x0600945E RID: 37982 RVA: 0x000D3D95 File Offset: 0x000D1F95
		public unsafe int CopyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExposedValueCopyRecord.__PropertyOffset_CopyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExposedValueCopyRecord.__PropertyOffset_CopyIndex) = value;
			}
		}

		// Token: 0x17002389 RID: 9097
		// (get) Token: 0x0600945F RID: 37983 RVA: 0x000D3DA6 File Offset: 0x000D1FA6
		// (set) Token: 0x06009460 RID: 37984 RVA: 0x000D3DB6 File Offset: 0x000D1FB6
		public unsafe EPostCopyOperation PostCopyOperation
		{
			get
			{
				return (EPostCopyOperation)(*(base.NativePtr + (IntPtr)FExposedValueCopyRecord.__PropertyOffset_PostCopyOperation));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExposedValueCopyRecord.__PropertyOffset_PostCopyOperation) = (byte)value;
			}
		}

		// Token: 0x06009461 RID: 37985 RVA: 0x000D3DC7 File Offset: 0x000D1FC7
		public FExposedValueCopyRecord()
		{
		}

		// Token: 0x06009462 RID: 37986 RVA: 0x000D3DCF File Offset: 0x000D1FCF
		public FExposedValueCopyRecord(int CopyIndex, EPostCopyOperation PostCopyOperation)
		{
			this.CopyIndex = CopyIndex;
			this.PostCopyOperation = PostCopyOperation;
		}

		// Token: 0x06009463 RID: 37987 RVA: 0x000D3DE5 File Offset: 0x000D1FE5
		protected override IntPtr GetUStructPtr()
		{
			return FExposedValueCopyRecord.StaticStruct();
		}

		// Token: 0x06009464 RID: 37988 RVA: 0x000D3DF1 File Offset: 0x000D1FF1
		[NullableContext(2)]
		public FExposedValueCopyRecord(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009465 RID: 37989 RVA: 0x000D3DFB File Offset: 0x000D1FFB
		public FExposedValueCopyRecord(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009466 RID: 37990 RVA: 0x000D3E06 File Offset: 0x000D2006
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExposedValueCopyRecord(Pointer, false, true);
		}

		// Token: 0x06009467 RID: 37991 RVA: 0x000D3E10 File Offset: 0x000D2010
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExposedValueCopyRecord(Pointer, MemoryOwner);
		}

		// Token: 0x04005363 RID: 21347
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ExposedValueCopyRecord";

		// Token: 0x04005364 RID: 21348
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005365 RID: 21349
		internal static int __PropertyOffset_CopyIndex;

		// Token: 0x04005366 RID: 21350
		internal static int __PropertyOffset_PostCopyOperation;
	}
}
