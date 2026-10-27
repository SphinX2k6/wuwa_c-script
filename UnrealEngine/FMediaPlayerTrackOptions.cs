using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022B2 RID: 8882
	[UnrealObjectPath("/Script/MediaUtils.MediaPlayerTrackOptions")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FMediaPlayerTrackOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021C17 RID: 138263 RVA: 0x0031E917 File Offset: 0x0031CB17
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMediaPlayerTrackOptions._ScriptStructPtr != 0) ? FMediaPlayerTrackOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MediaUtils.MediaPlayerTrackOptions", ref FMediaPlayerTrackOptions._ScriptStructPtr);
		}

		// Token: 0x170082F1 RID: 33521
		// (get) Token: 0x06021C18 RID: 138264 RVA: 0x0031E93B File Offset: 0x0031CB3B
		// (set) Token: 0x06021C19 RID: 138265 RVA: 0x0031E94B File Offset: 0x0031CB4B
		public unsafe int Audio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMediaPlayerTrackOptions.__PropertyOffset_Audio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMediaPlayerTrackOptions.__PropertyOffset_Audio) = value;
			}
		}

		// Token: 0x170082F2 RID: 33522
		// (get) Token: 0x06021C1A RID: 138266 RVA: 0x0031E95C File Offset: 0x0031CB5C
		// (set) Token: 0x06021C1B RID: 138267 RVA: 0x0031E96C File Offset: 0x0031CB6C
		public unsafe int Caption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMediaPlayerTrackOptions.__PropertyOffset_Caption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMediaPlayerTrackOptions.__PropertyOffset_Caption) = value;
			}
		}

		// Token: 0x170082F3 RID: 33523
		// (get) Token: 0x06021C1C RID: 138268 RVA: 0x0031E97D File Offset: 0x0031CB7D
		// (set) Token: 0x06021C1D RID: 138269 RVA: 0x0031E98D File Offset: 0x0031CB8D
		public unsafe int Metadata
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMediaPlayerTrackOptions.__PropertyOffset_Metadata);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMediaPlayerTrackOptions.__PropertyOffset_Metadata) = value;
			}
		}

		// Token: 0x170082F4 RID: 33524
		// (get) Token: 0x06021C1E RID: 138270 RVA: 0x0031E99E File Offset: 0x0031CB9E
		// (set) Token: 0x06021C1F RID: 138271 RVA: 0x0031E9AE File Offset: 0x0031CBAE
		public unsafe int Script
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMediaPlayerTrackOptions.__PropertyOffset_Script);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMediaPlayerTrackOptions.__PropertyOffset_Script) = value;
			}
		}

		// Token: 0x170082F5 RID: 33525
		// (get) Token: 0x06021C20 RID: 138272 RVA: 0x0031E9BF File Offset: 0x0031CBBF
		// (set) Token: 0x06021C21 RID: 138273 RVA: 0x0031E9CF File Offset: 0x0031CBCF
		public unsafe int Subtitle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMediaPlayerTrackOptions.__PropertyOffset_Subtitle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMediaPlayerTrackOptions.__PropertyOffset_Subtitle) = value;
			}
		}

		// Token: 0x170082F6 RID: 33526
		// (get) Token: 0x06021C22 RID: 138274 RVA: 0x0031E9E0 File Offset: 0x0031CBE0
		// (set) Token: 0x06021C23 RID: 138275 RVA: 0x0031E9F0 File Offset: 0x0031CBF0
		public unsafe int Text
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMediaPlayerTrackOptions.__PropertyOffset_Text);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMediaPlayerTrackOptions.__PropertyOffset_Text) = value;
			}
		}

		// Token: 0x170082F7 RID: 33527
		// (get) Token: 0x06021C24 RID: 138276 RVA: 0x0031EA01 File Offset: 0x0031CC01
		// (set) Token: 0x06021C25 RID: 138277 RVA: 0x0031EA11 File Offset: 0x0031CC11
		public unsafe int Video
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMediaPlayerTrackOptions.__PropertyOffset_Video);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMediaPlayerTrackOptions.__PropertyOffset_Video) = value;
			}
		}

		// Token: 0x06021C26 RID: 138278 RVA: 0x0031EA22 File Offset: 0x0031CC22
		public FMediaPlayerTrackOptions()
		{
		}

		// Token: 0x06021C27 RID: 138279 RVA: 0x0031EA2A File Offset: 0x0031CC2A
		public FMediaPlayerTrackOptions(int Audio, int Caption, int Metadata, int Script, int Subtitle, int Text, int Video)
		{
			this.Audio = Audio;
			this.Caption = Caption;
			this.Metadata = Metadata;
			this.Script = Script;
			this.Subtitle = Subtitle;
			this.Text = Text;
			this.Video = Video;
		}

		// Token: 0x06021C28 RID: 138280 RVA: 0x0031EA67 File Offset: 0x0031CC67
		protected override IntPtr GetUStructPtr()
		{
			return FMediaPlayerTrackOptions.StaticStruct();
		}

		// Token: 0x06021C29 RID: 138281 RVA: 0x0031EA73 File Offset: 0x0031CC73
		[NullableContext(2)]
		public FMediaPlayerTrackOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021C2A RID: 138282 RVA: 0x0031EA7D File Offset: 0x0031CC7D
		public FMediaPlayerTrackOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021C2B RID: 138283 RVA: 0x0031EA88 File Offset: 0x0031CC88
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMediaPlayerTrackOptions(Pointer, false, true);
		}

		// Token: 0x06021C2C RID: 138284 RVA: 0x0031EA92 File Offset: 0x0031CC92
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMediaPlayerTrackOptions(Pointer, MemoryOwner);
		}

		// Token: 0x04012032 RID: 73778
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MediaUtils.MediaPlayerTrackOptions";

		// Token: 0x04012033 RID: 73779
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012034 RID: 73780
		internal static int __PropertyOffset_Audio;

		// Token: 0x04012035 RID: 73781
		internal static int __PropertyOffset_Caption;

		// Token: 0x04012036 RID: 73782
		internal static int __PropertyOffset_Metadata;

		// Token: 0x04012037 RID: 73783
		internal static int __PropertyOffset_Script;

		// Token: 0x04012038 RID: 73784
		internal static int __PropertyOffset_Subtitle;

		// Token: 0x04012039 RID: 73785
		internal static int __PropertyOffset_Text;

		// Token: 0x0401203A RID: 73786
		internal static int __PropertyOffset_Video;
	}
}
