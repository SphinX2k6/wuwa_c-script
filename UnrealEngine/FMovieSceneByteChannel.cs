using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023DD RID: 9181
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneByteChannel")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FMovieSceneByteChannel : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602279D RID: 141213 RVA: 0x0032FCC7 File Offset: 0x0032DEC7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneByteChannel._ScriptStructPtr != 0) ? FMovieSceneByteChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneByteChannel", ref FMovieSceneByteChannel._ScriptStructPtr);
		}

		// Token: 0x170084C9 RID: 33993
		// (get) Token: 0x0602279E RID: 141214 RVA: 0x0032FCEC File Offset: 0x0032DEEC
		// (set) Token: 0x0602279F RID: 141215 RVA: 0x0032FD2F File Offset: 0x0032DF2F
		public TArray<FFrameNumber> Times
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFrameNumber> result;
				if ((result = this._Times) == null)
				{
					result = (this._Times = new TArray<FFrameNumber>(base.NativePtr + (IntPtr)FMovieSceneByteChannel.__PropertyOffset_Times, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Times.CopyAssign(value);
			}
		}

		// Token: 0x170084CA RID: 33994
		// (get) Token: 0x060227A0 RID: 141216 RVA: 0x0032FD3D File Offset: 0x0032DF3D
		// (set) Token: 0x060227A1 RID: 141217 RVA: 0x0032FD4D File Offset: 0x0032DF4D
		public unsafe byte DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneByteChannel.__PropertyOffset_DefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneByteChannel.__PropertyOffset_DefaultValue) = value;
			}
		}

		// Token: 0x170084CB RID: 33995
		// (get) Token: 0x060227A2 RID: 141218 RVA: 0x0032FD5E File Offset: 0x0032DF5E
		// (set) Token: 0x060227A3 RID: 141219 RVA: 0x0032FD6E File Offset: 0x0032DF6E
		public unsafe bool bHasDefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneByteChannel.__PropertyOffset_bHasDefaultValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneByteChannel.__PropertyOffset_bHasDefaultValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x170084CC RID: 33996
		// (get) Token: 0x060227A4 RID: 141220 RVA: 0x0032FD80 File Offset: 0x0032DF80
		// (set) Token: 0x060227A5 RID: 141221 RVA: 0x0032FDC3 File Offset: 0x0032DFC3
		public TArray<byte> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<byte>(base.NativePtr + (IntPtr)FMovieSceneByteChannel.__PropertyOffset_Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x170084CD RID: 33997
		// (get) Token: 0x060227A6 RID: 141222 RVA: 0x0032FDD1 File Offset: 0x0032DFD1
		// (set) Token: 0x060227A7 RID: 141223 RVA: 0x0032FDE5 File Offset: 0x0032DFE5
		[Nullable(2)]
		public unsafe UEnum Enum
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEnum>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneByteChannel.__PropertyOffset_Enum);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneByteChannel.__PropertyOffset_Enum, value);
			}
		}

		// Token: 0x060227A8 RID: 141224 RVA: 0x0032FDFA File Offset: 0x0032DFFA
		public FMovieSceneByteChannel()
		{
		}

		// Token: 0x060227A9 RID: 141225 RVA: 0x0032FE02 File Offset: 0x0032E002
		public FMovieSceneByteChannel(TArray<FFrameNumber> Times, byte DefaultValue, bool bHasDefaultValue, TArray<byte> Values, UEnum Enum)
		{
			this.Times = Times;
			this.DefaultValue = DefaultValue;
			this.bHasDefaultValue = bHasDefaultValue;
			this.Values = Values;
			this.Enum = Enum;
		}

		// Token: 0x060227AA RID: 141226 RVA: 0x0032FE2F File Offset: 0x0032E02F
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneByteChannel.StaticStruct();
		}

		// Token: 0x060227AB RID: 141227 RVA: 0x0032FE3B File Offset: 0x0032E03B
		[NullableContext(2)]
		public FMovieSceneByteChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060227AC RID: 141228 RVA: 0x0032FE45 File Offset: 0x0032E045
		public FMovieSceneByteChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060227AD RID: 141229 RVA: 0x0032FE50 File Offset: 0x0032E050
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneByteChannel(Pointer, false, true);
		}

		// Token: 0x060227AE RID: 141230 RVA: 0x0032FE5A File Offset: 0x0032E05A
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneByteChannel(Pointer, MemoryOwner);
		}

		// Token: 0x040126D7 RID: 75479
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneByteChannel";

		// Token: 0x040126D8 RID: 75480
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040126D9 RID: 75481
		internal static int __PropertyOffset_Times;

		// Token: 0x040126DA RID: 75482
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _Times;

		// Token: 0x040126DB RID: 75483
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x040126DC RID: 75484
		internal static int __PropertyOffset_bHasDefaultValue;

		// Token: 0x040126DD RID: 75485
		internal static int __PropertyOffset_Values;

		// Token: 0x040126DE RID: 75486
		[Nullable(2)]
		private TArray<byte> _Values;

		// Token: 0x040126DF RID: 75487
		internal static int __PropertyOffset_Enum;
	}
}
