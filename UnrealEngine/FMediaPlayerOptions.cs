using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022B1 RID: 8881
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaUtils.MediaPlayerOptions")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMediaPlayerOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021C07 RID: 138247 RVA: 0x0031E786 File Offset: 0x0031C986
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMediaPlayerOptions._ScriptStructPtr != 0) ? FMediaPlayerOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MediaUtils.MediaPlayerOptions", ref FMediaPlayerOptions._ScriptStructPtr);
		}

		// Token: 0x170082ED RID: 33517
		// (get) Token: 0x06021C08 RID: 138248 RVA: 0x0031E7AC File Offset: 0x0031C9AC
		// (set) Token: 0x06021C09 RID: 138249 RVA: 0x0031E7EF File Offset: 0x0031C9EF
		public FMediaPlayerTrackOptions Tracks
		{
			get
			{
				base.FastCheckIsValid();
				FMediaPlayerTrackOptions result;
				if ((result = this._Tracks) == null)
				{
					result = (this._Tracks = new FMediaPlayerTrackOptions(base.NativePtr + (IntPtr)FMediaPlayerOptions.__PropertyOffset_Tracks, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMediaPlayerTrackOptions.StaticStruct(), base.NativePtr + (IntPtr)FMediaPlayerOptions.__PropertyOffset_Tracks, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170082EE RID: 33518
		// (get) Token: 0x06021C0A RID: 138250 RVA: 0x0031E810 File Offset: 0x0031CA10
		// (set) Token: 0x06021C0B RID: 138251 RVA: 0x0031E853 File Offset: 0x0031CA53
		public FTimespan SeekTime
		{
			get
			{
				base.FastCheckIsValid();
				FTimespan result;
				if ((result = this._SeekTime) == null)
				{
					result = (this._SeekTime = new FTimespan(base.NativePtr + (IntPtr)FMediaPlayerOptions.__PropertyOffset_SeekTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimespan.StaticStruct(), base.NativePtr + (IntPtr)FMediaPlayerOptions.__PropertyOffset_SeekTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170082EF RID: 33519
		// (get) Token: 0x06021C0C RID: 138252 RVA: 0x0031E874 File Offset: 0x0031CA74
		// (set) Token: 0x06021C0D RID: 138253 RVA: 0x0031E884 File Offset: 0x0031CA84
		public unsafe EMediaPlayerOptionBooleanOverride PlayOnOpen
		{
			get
			{
				return (EMediaPlayerOptionBooleanOverride)(*(base.NativePtr + (IntPtr)FMediaPlayerOptions.__PropertyOffset_PlayOnOpen));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMediaPlayerOptions.__PropertyOffset_PlayOnOpen) = (byte)value;
			}
		}

		// Token: 0x170082F0 RID: 33520
		// (get) Token: 0x06021C0E RID: 138254 RVA: 0x0031E895 File Offset: 0x0031CA95
		// (set) Token: 0x06021C0F RID: 138255 RVA: 0x0031E8A5 File Offset: 0x0031CAA5
		public unsafe EMediaPlayerOptionBooleanOverride Loop
		{
			get
			{
				return (EMediaPlayerOptionBooleanOverride)(*(base.NativePtr + (IntPtr)FMediaPlayerOptions.__PropertyOffset_Loop));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMediaPlayerOptions.__PropertyOffset_Loop) = (byte)value;
			}
		}

		// Token: 0x06021C10 RID: 138256 RVA: 0x0031E8B6 File Offset: 0x0031CAB6
		public FMediaPlayerOptions()
		{
		}

		// Token: 0x06021C11 RID: 138257 RVA: 0x0031E8BE File Offset: 0x0031CABE
		public FMediaPlayerOptions(FMediaPlayerTrackOptions Tracks, FTimespan SeekTime, EMediaPlayerOptionBooleanOverride PlayOnOpen, EMediaPlayerOptionBooleanOverride Loop)
		{
			this.Tracks = Tracks;
			this.SeekTime = SeekTime;
			this.PlayOnOpen = PlayOnOpen;
			this.Loop = Loop;
		}

		// Token: 0x06021C12 RID: 138258 RVA: 0x0031E8E3 File Offset: 0x0031CAE3
		protected override IntPtr GetUStructPtr()
		{
			return FMediaPlayerOptions.StaticStruct();
		}

		// Token: 0x06021C13 RID: 138259 RVA: 0x0031E8EF File Offset: 0x0031CAEF
		[NullableContext(2)]
		public FMediaPlayerOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021C14 RID: 138260 RVA: 0x0031E8F9 File Offset: 0x0031CAF9
		public FMediaPlayerOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021C15 RID: 138261 RVA: 0x0031E904 File Offset: 0x0031CB04
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMediaPlayerOptions(Pointer, false, true);
		}

		// Token: 0x06021C16 RID: 138262 RVA: 0x0031E90E File Offset: 0x0031CB0E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMediaPlayerOptions(Pointer, MemoryOwner);
		}

		// Token: 0x0401202A RID: 73770
		public const string __ObjectPath = "/Script/MediaUtils.MediaPlayerOptions";

		// Token: 0x0401202B RID: 73771
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401202C RID: 73772
		internal static int __PropertyOffset_Tracks;

		// Token: 0x0401202D RID: 73773
		[Nullable(2)]
		private FMediaPlayerTrackOptions _Tracks;

		// Token: 0x0401202E RID: 73774
		internal static int __PropertyOffset_SeekTime;

		// Token: 0x0401202F RID: 73775
		[Nullable(2)]
		private FTimespan _SeekTime;

		// Token: 0x04012030 RID: 73776
		internal static int __PropertyOffset_PlayOnOpen;

		// Token: 0x04012031 RID: 73777
		internal static int __PropertyOffset_Loop;
	}
}
