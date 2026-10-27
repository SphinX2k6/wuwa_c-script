using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000288 RID: 648
	[UnrealObjectPath("/Script/AkAudio.MovieSceneFloatChannelSerializationHelper")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMovieSceneFloatChannelSerializationHelper : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002459 RID: 9305 RVA: 0x00035E75 File Offset: 0x00034075
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneFloatChannelSerializationHelper._ScriptStructPtr != 0) ? FMovieSceneFloatChannelSerializationHelper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.MovieSceneFloatChannelSerializationHelper", ref FMovieSceneFloatChannelSerializationHelper._ScriptStructPtr);
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x00035E99 File Offset: 0x00034099
		// (set) Token: 0x0600245B RID: 9307 RVA: 0x00035EAD File Offset: 0x000340AD
		public unsafe TEnumAsByte<ERichCurveExtrapolation> PreInfinityExtrap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatChannelSerializationHelper.__PropertyOffset_PreInfinityExtrap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatChannelSerializationHelper.__PropertyOffset_PreInfinityExtrap) = value;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x00035EC2 File Offset: 0x000340C2
		// (set) Token: 0x0600245D RID: 9309 RVA: 0x00035ED6 File Offset: 0x000340D6
		public unsafe TEnumAsByte<ERichCurveExtrapolation> PostInfinityExtrap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatChannelSerializationHelper.__PropertyOffset_PostInfinityExtrap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatChannelSerializationHelper.__PropertyOffset_PostInfinityExtrap) = value;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x00035EEC File Offset: 0x000340EC
		// (set) Token: 0x0600245F RID: 9311 RVA: 0x00035F2F File Offset: 0x0003412F
		[Nullable(1)]
		public TArray<int> Times
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Times) == null)
				{
					result = (this._Times = new TArray<int>(base.NativePtr + (IntPtr)FMovieSceneFloatChannelSerializationHelper.__PropertyOffset_Times, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Times.CopyAssign(value);
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x00035F40 File Offset: 0x00034140
		// (set) Token: 0x06002461 RID: 9313 RVA: 0x00035F83 File Offset: 0x00034183
		[Nullable(1)]
		public TArray<FMovieSceneFloatValueSerializationHelper> Values
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneFloatValueSerializationHelper> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<FMovieSceneFloatValueSerializationHelper>(base.NativePtr + (IntPtr)FMovieSceneFloatChannelSerializationHelper.__PropertyOffset_Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06002462 RID: 9314 RVA: 0x00035F91 File Offset: 0x00034191
		// (set) Token: 0x06002463 RID: 9315 RVA: 0x00035FA1 File Offset: 0x000341A1
		public unsafe float DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatChannelSerializationHelper.__PropertyOffset_DefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatChannelSerializationHelper.__PropertyOffset_DefaultValue) = value;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x00035FB2 File Offset: 0x000341B2
		// (set) Token: 0x06002465 RID: 9317 RVA: 0x00035FC2 File Offset: 0x000341C2
		public unsafe bool bHasDefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatChannelSerializationHelper.__PropertyOffset_bHasDefaultValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatChannelSerializationHelper.__PropertyOffset_bHasDefaultValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x00035FD3 File Offset: 0x000341D3
		public FMovieSceneFloatChannelSerializationHelper()
		{
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x00035FDB File Offset: 0x000341DB
		public FMovieSceneFloatChannelSerializationHelper(TEnumAsByte<ERichCurveExtrapolation> PreInfinityExtrap, TEnumAsByte<ERichCurveExtrapolation> PostInfinityExtrap, [Nullable(1)] TArray<int> Times, [Nullable(1)] TArray<FMovieSceneFloatValueSerializationHelper> Values, float DefaultValue, bool bHasDefaultValue)
		{
			this.PreInfinityExtrap = PreInfinityExtrap;
			this.PostInfinityExtrap = PostInfinityExtrap;
			this.Times = Times;
			this.Values = Values;
			this.DefaultValue = DefaultValue;
			this.bHasDefaultValue = bHasDefaultValue;
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x00036010 File Offset: 0x00034210
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneFloatChannelSerializationHelper.StaticStruct();
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x0003601C File Offset: 0x0003421C
		[NullableContext(2)]
		public FMovieSceneFloatChannelSerializationHelper(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x00036026 File Offset: 0x00034226
		public FMovieSceneFloatChannelSerializationHelper(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x00036031 File Offset: 0x00034231
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneFloatChannelSerializationHelper(Pointer, false, true);
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x0003603B File Offset: 0x0003423B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneFloatChannelSerializationHelper(Pointer, MemoryOwner);
		}

		// Token: 0x04000DD3 RID: 3539
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.MovieSceneFloatChannelSerializationHelper";

		// Token: 0x04000DD4 RID: 3540
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000DD5 RID: 3541
		internal static int __PropertyOffset_PreInfinityExtrap;

		// Token: 0x04000DD6 RID: 3542
		internal static int __PropertyOffset_PostInfinityExtrap;

		// Token: 0x04000DD7 RID: 3543
		internal static int __PropertyOffset_Times;

		// Token: 0x04000DD8 RID: 3544
		[Nullable(2)]
		private TArray<int> _Times;

		// Token: 0x04000DD9 RID: 3545
		internal static int __PropertyOffset_Values;

		// Token: 0x04000DDA RID: 3546
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneFloatValueSerializationHelper> _Values;

		// Token: 0x04000DDB RID: 3547
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x04000DDC RID: 3548
		internal static int __PropertyOffset_bHasDefaultValue;
	}
}
