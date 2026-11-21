using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007DF RID: 2015
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.QteProgressSpineSegment")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FQteProgressSpineSegment : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AD34 RID: 44340 RVA: 0x0010025F File Offset: 0x000FE45F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQteProgressSpineSegment._ScriptStructPtr != 0) ? FQteProgressSpineSegment._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.QteProgressSpineSegment", ref FQteProgressSpineSegment._ScriptStructPtr);
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x0600AD35 RID: 44341 RVA: 0x00100284 File Offset: 0x000FE484
		// (set) Token: 0x0600AD36 RID: 44342 RVA: 0x001002C7 File Offset: 0x000FE4C7
		public TArray<FSpineData> Spines
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpineData> result;
				if ((result = this._Spines) == null)
				{
					result = (this._Spines = new TArray<FSpineData>(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_Spines, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Spines.CopyAssign(value);
			}
		}

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x0600AD37 RID: 44343 RVA: 0x001002D5 File Offset: 0x000FE4D5
		// (set) Token: 0x0600AD38 RID: 44344 RVA: 0x001002E5 File Offset: 0x000FE4E5
		public unsafe float QteStartPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_QteStartPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_QteStartPercent) = value;
			}
		}

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x0600AD39 RID: 44345 RVA: 0x001002F6 File Offset: 0x000FE4F6
		// (set) Token: 0x0600AD3A RID: 44346 RVA: 0x00100306 File Offset: 0x000FE506
		public unsafe float QteEndPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_QteEndPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_QteEndPercent) = value;
			}
		}

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x0600AD3B RID: 44347 RVA: 0x00100317 File Offset: 0x000FE517
		// (set) Token: 0x0600AD3C RID: 44348 RVA: 0x00100327 File Offset: 0x000FE527
		public unsafe float SpineStartPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_SpineStartPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_SpineStartPercent) = value;
			}
		}

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x0600AD3D RID: 44349 RVA: 0x00100338 File Offset: 0x000FE538
		// (set) Token: 0x0600AD3E RID: 44350 RVA: 0x00100348 File Offset: 0x000FE548
		public unsafe float SpineEndPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_SpineEndPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_SpineEndPercent) = value;
			}
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x0600AD3F RID: 44351 RVA: 0x00100359 File Offset: 0x000FE559
		// (set) Token: 0x0600AD40 RID: 44352 RVA: 0x00100369 File Offset: 0x000FE569
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x0600AD41 RID: 44353 RVA: 0x0010037A File Offset: 0x000FE57A
		// (set) Token: 0x0600AD42 RID: 44354 RVA: 0x0010038A File Offset: 0x000FE58A
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_BlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_BlendOutTime) = value;
			}
		}

		// Token: 0x0600AD43 RID: 44355 RVA: 0x0010039B File Offset: 0x000FE59B
		public FQteProgressSpineSegment()
		{
		}

		// Token: 0x0600AD44 RID: 44356 RVA: 0x001003A3 File Offset: 0x000FE5A3
		protected override IntPtr GetUStructPtr()
		{
			return FQteProgressSpineSegment.StaticStruct();
		}

		// Token: 0x0600AD45 RID: 44357 RVA: 0x001003AF File Offset: 0x000FE5AF
		[NullableContext(2)]
		public FQteProgressSpineSegment(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AD46 RID: 44358 RVA: 0x001003B9 File Offset: 0x000FE5B9
		public FQteProgressSpineSegment(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AD47 RID: 44359 RVA: 0x001003C4 File Offset: 0x000FE5C4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FQteProgressSpineSegment(Pointer, false, true);
		}

		// Token: 0x0600AD48 RID: 44360 RVA: 0x001003CE File Offset: 0x000FE5CE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FQteProgressSpineSegment(Pointer, MemoryOwner);
		}

		// Token: 0x04004AA6 RID: 19110
		public const string __ObjectPath = "/Script/SequenceDialogue.QteProgressSpineSegment";

		// Token: 0x04004AA7 RID: 19111
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004AA8 RID: 19112
		internal static int __PropertyOffset_Spines;

		// Token: 0x04004AA9 RID: 19113
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpineData> _Spines;

		// Token: 0x04004AAA RID: 19114
		internal static int __PropertyOffset_QteStartPercent;

		// Token: 0x04004AAB RID: 19115
		internal static int __PropertyOffset_QteEndPercent;

		// Token: 0x04004AAC RID: 19116
		internal static int __PropertyOffset_SpineStartPercent;

		// Token: 0x04004AAD RID: 19117
		internal static int __PropertyOffset_SpineEndPercent;

		// Token: 0x04004AAE RID: 19118
		internal static int __PropertyOffset_BlendInTime;

		// Token: 0x04004AAF RID: 19119
		internal static int __PropertyOffset_BlendOutTime;
	}
}
