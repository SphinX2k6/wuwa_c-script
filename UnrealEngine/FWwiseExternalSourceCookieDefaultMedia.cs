using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A98 RID: 10904
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WwiseSimpleExternalSource.WwiseExternalSourceCookieDefaultMedia")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FWwiseExternalSourceCookieDefaultMedia : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028310 RID: 164624 RVA: 0x003D250E File Offset: 0x003D070E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseExternalSourceCookieDefaultMedia._ScriptStructPtr != 0) ? FWwiseExternalSourceCookieDefaultMedia._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseSimpleExternalSource.WwiseExternalSourceCookieDefaultMedia", ref FWwiseExternalSourceCookieDefaultMedia._ScriptStructPtr);
		}

		// Token: 0x17009955 RID: 39253
		// (get) Token: 0x06028311 RID: 164625 RVA: 0x003D2532 File Offset: 0x003D0732
		// (set) Token: 0x06028312 RID: 164626 RVA: 0x003D2542 File Offset: 0x003D0742
		public unsafe int ExternalSourceCookie
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseExternalSourceCookieDefaultMedia.__PropertyOffset_ExternalSourceCookie);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseExternalSourceCookieDefaultMedia.__PropertyOffset_ExternalSourceCookie) = value;
			}
		}

		// Token: 0x17009956 RID: 39254
		// (get) Token: 0x06028313 RID: 164627 RVA: 0x003D2553 File Offset: 0x003D0753
		// (set) Token: 0x06028314 RID: 164628 RVA: 0x003D2567 File Offset: 0x003D0767
		public unsafe string ExternalSourceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FWwiseExternalSourceCookieDefaultMedia.__PropertyOffset_ExternalSourceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FWwiseExternalSourceCookieDefaultMedia.__PropertyOffset_ExternalSourceName)), value);
			}
		}

		// Token: 0x17009957 RID: 39255
		// (get) Token: 0x06028315 RID: 164629 RVA: 0x003D257C File Offset: 0x003D077C
		// (set) Token: 0x06028316 RID: 164630 RVA: 0x003D258C File Offset: 0x003D078C
		public unsafe int MediaInfoId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseExternalSourceCookieDefaultMedia.__PropertyOffset_MediaInfoId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseExternalSourceCookieDefaultMedia.__PropertyOffset_MediaInfoId) = value;
			}
		}

		// Token: 0x17009958 RID: 39256
		// (get) Token: 0x06028317 RID: 164631 RVA: 0x003D259D File Offset: 0x003D079D
		// (set) Token: 0x06028318 RID: 164632 RVA: 0x003D25B1 File Offset: 0x003D07B1
		public unsafe string MediaName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FWwiseExternalSourceCookieDefaultMedia.__PropertyOffset_MediaName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FWwiseExternalSourceCookieDefaultMedia.__PropertyOffset_MediaName)), value);
			}
		}

		// Token: 0x06028319 RID: 164633 RVA: 0x003D25C6 File Offset: 0x003D07C6
		public FWwiseExternalSourceCookieDefaultMedia()
		{
		}

		// Token: 0x0602831A RID: 164634 RVA: 0x003D25CE File Offset: 0x003D07CE
		public FWwiseExternalSourceCookieDefaultMedia(int ExternalSourceCookie, string ExternalSourceName, int MediaInfoId, string MediaName)
		{
			this.ExternalSourceCookie = ExternalSourceCookie;
			this.ExternalSourceName = ExternalSourceName;
			this.MediaInfoId = MediaInfoId;
			this.MediaName = MediaName;
		}

		// Token: 0x0602831B RID: 164635 RVA: 0x003D25F3 File Offset: 0x003D07F3
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseExternalSourceCookieDefaultMedia.StaticStruct();
		}

		// Token: 0x0602831C RID: 164636 RVA: 0x003D25FF File Offset: 0x003D07FF
		[NullableContext(2)]
		public FWwiseExternalSourceCookieDefaultMedia(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602831D RID: 164637 RVA: 0x003D2609 File Offset: 0x003D0809
		public FWwiseExternalSourceCookieDefaultMedia(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602831E RID: 164638 RVA: 0x003D2614 File Offset: 0x003D0814
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseExternalSourceCookieDefaultMedia(Pointer, false, true);
		}

		// Token: 0x0602831F RID: 164639 RVA: 0x003D261E File Offset: 0x003D081E
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseExternalSourceCookieDefaultMedia(Pointer, MemoryOwner);
		}

		// Token: 0x040160A1 RID: 90273
		public new const string __ObjectPath = "/Script/WwiseSimpleExternalSource.WwiseExternalSourceCookieDefaultMedia";

		// Token: 0x040160A2 RID: 90274
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040160A3 RID: 90275
		internal static int __PropertyOffset_ExternalSourceCookie;

		// Token: 0x040160A4 RID: 90276
		internal static int __PropertyOffset_ExternalSourceName;

		// Token: 0x040160A5 RID: 90277
		internal static int __PropertyOffset_MediaInfoId;

		// Token: 0x040160A6 RID: 90278
		internal static int __PropertyOffset_MediaName;
	}
}
