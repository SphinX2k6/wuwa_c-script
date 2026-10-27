using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200151A RID: 5402
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ImageWriteQueue.ImageWriteOptions")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FImageWriteOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013AB7 RID: 80567 RVA: 0x001CE43F File Offset: 0x001CC63F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FImageWriteOptions._ScriptStructPtr != 0) ? FImageWriteOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ImageWriteQueue.ImageWriteOptions", ref FImageWriteOptions._ScriptStructPtr);
		}

		// Token: 0x17004D03 RID: 19715
		// (get) Token: 0x06013AB8 RID: 80568 RVA: 0x001CE463 File Offset: 0x001CC663
		// (set) Token: 0x06013AB9 RID: 80569 RVA: 0x001CE473 File Offset: 0x001CC673
		public unsafe EDesiredImageFormat Format
		{
			get
			{
				return (EDesiredImageFormat)(*(base.NativePtr + (IntPtr)FImageWriteOptions.__PropertyOffset_Format));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FImageWriteOptions.__PropertyOffset_Format) = (byte)value;
			}
		}

		// Token: 0x17004D04 RID: 19716
		// (get) Token: 0x06013ABA RID: 80570 RVA: 0x001CE484 File Offset: 0x001CC684
		// (set) Token: 0x06013ABB RID: 80571 RVA: 0x001CE4C7 File Offset: 0x001CC6C7
		public FOnImageWriteComplete OnComplete
		{
			get
			{
				base.FastCheckIsValid();
				FOnImageWriteComplete result;
				if ((result = this._OnComplete) == null)
				{
					result = (this._OnComplete = new FOnImageWriteComplete(base.NativePtr + (IntPtr)FImageWriteOptions.__PropertyOffset_OnComplete, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)FImageWriteOptions.__PropertyOffset_OnComplete, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004D05 RID: 19717
		// (get) Token: 0x06013ABC RID: 80572 RVA: 0x001CE4E8 File Offset: 0x001CC6E8
		// (set) Token: 0x06013ABD RID: 80573 RVA: 0x001CE4F8 File Offset: 0x001CC6F8
		public unsafe int CompressionQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FImageWriteOptions.__PropertyOffset_CompressionQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FImageWriteOptions.__PropertyOffset_CompressionQuality) = value;
			}
		}

		// Token: 0x17004D06 RID: 19718
		// (get) Token: 0x06013ABE RID: 80574 RVA: 0x001CE509 File Offset: 0x001CC709
		// (set) Token: 0x06013ABF RID: 80575 RVA: 0x001CE519 File Offset: 0x001CC719
		public unsafe bool bOverwriteFile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FImageWriteOptions.__PropertyOffset_bOverwriteFile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FImageWriteOptions.__PropertyOffset_bOverwriteFile) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D07 RID: 19719
		// (get) Token: 0x06013AC0 RID: 80576 RVA: 0x001CE52A File Offset: 0x001CC72A
		// (set) Token: 0x06013AC1 RID: 80577 RVA: 0x001CE53A File Offset: 0x001CC73A
		public unsafe bool bAsync
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FImageWriteOptions.__PropertyOffset_bAsync) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FImageWriteOptions.__PropertyOffset_bAsync) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013AC2 RID: 80578 RVA: 0x001CE54B File Offset: 0x001CC74B
		public FImageWriteOptions()
		{
		}

		// Token: 0x06013AC3 RID: 80579 RVA: 0x001CE553 File Offset: 0x001CC753
		public FImageWriteOptions(EDesiredImageFormat Format, FOnImageWriteComplete OnComplete, int CompressionQuality, bool bOverwriteFile, bool bAsync)
		{
			this.Format = Format;
			this.OnComplete = OnComplete;
			this.CompressionQuality = CompressionQuality;
			this.bOverwriteFile = bOverwriteFile;
			this.bAsync = bAsync;
		}

		// Token: 0x06013AC4 RID: 80580 RVA: 0x001CE580 File Offset: 0x001CC780
		protected override IntPtr GetUStructPtr()
		{
			return FImageWriteOptions.StaticStruct();
		}

		// Token: 0x06013AC5 RID: 80581 RVA: 0x001CE58C File Offset: 0x001CC78C
		[NullableContext(2)]
		public FImageWriteOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013AC6 RID: 80582 RVA: 0x001CE596 File Offset: 0x001CC796
		public FImageWriteOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013AC7 RID: 80583 RVA: 0x001CE5A1 File Offset: 0x001CC7A1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FImageWriteOptions(Pointer, false, true);
		}

		// Token: 0x06013AC8 RID: 80584 RVA: 0x001CE5AB File Offset: 0x001CC7AB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FImageWriteOptions(Pointer, MemoryOwner);
		}

		// Token: 0x0400A9EB RID: 43499
		public const string __ObjectPath = "/Script/ImageWriteQueue.ImageWriteOptions";

		// Token: 0x0400A9EC RID: 43500
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A9ED RID: 43501
		internal static int __PropertyOffset_Format;

		// Token: 0x0400A9EE RID: 43502
		internal static int __PropertyOffset_OnComplete;

		// Token: 0x0400A9EF RID: 43503
		[Nullable(2)]
		private FOnImageWriteComplete _OnComplete;

		// Token: 0x0400A9F0 RID: 43504
		internal static int __PropertyOffset_CompressionQuality;

		// Token: 0x0400A9F1 RID: 43505
		internal static int __PropertyOffset_bOverwriteFile;

		// Token: 0x0400A9F2 RID: 43506
		internal static int __PropertyOffset_bAsync;
	}
}
