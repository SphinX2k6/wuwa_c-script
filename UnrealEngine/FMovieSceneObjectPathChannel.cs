using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200241C RID: 9244
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneObjectPathChannel")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class FMovieSceneObjectPathChannel : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022A47 RID: 141895 RVA: 0x00333ACC File Offset: 0x00331CCC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneObjectPathChannel._ScriptStructPtr != 0) ? FMovieSceneObjectPathChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneObjectPathChannel", ref FMovieSceneObjectPathChannel._ScriptStructPtr);
		}

		// Token: 0x1700854C RID: 34124
		// (get) Token: 0x06022A48 RID: 141896 RVA: 0x00333AF0 File Offset: 0x00331CF0
		// (set) Token: 0x06022A49 RID: 141897 RVA: 0x00333B04 File Offset: 0x00331D04
		public unsafe UClassStackOnlyPtr PropertyClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneObjectPathChannel.__PropertyOffset_PropertyClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneObjectPathChannel.__PropertyOffset_PropertyClass) = value;
			}
		}

		// Token: 0x1700854D RID: 34125
		// (get) Token: 0x06022A4A RID: 141898 RVA: 0x00333B1C File Offset: 0x00331D1C
		// (set) Token: 0x06022A4B RID: 141899 RVA: 0x00333B5F File Offset: 0x00331D5F
		public TArray<FFrameNumber> Times
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFrameNumber> result;
				if ((result = this._Times) == null)
				{
					result = (this._Times = new TArray<FFrameNumber>(base.NativePtr + (IntPtr)FMovieSceneObjectPathChannel.__PropertyOffset_Times, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Times.CopyAssign(value);
			}
		}

		// Token: 0x1700854E RID: 34126
		// (get) Token: 0x06022A4C RID: 141900 RVA: 0x00333B70 File Offset: 0x00331D70
		// (set) Token: 0x06022A4D RID: 141901 RVA: 0x00333BB3 File Offset: 0x00331DB3
		public TArray<FMovieSceneObjectPathChannelKeyValue> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneObjectPathChannelKeyValue> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<FMovieSceneObjectPathChannelKeyValue>(base.NativePtr + (IntPtr)FMovieSceneObjectPathChannel.__PropertyOffset_Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x1700854F RID: 34127
		// (get) Token: 0x06022A4E RID: 141902 RVA: 0x00333BC4 File Offset: 0x00331DC4
		// (set) Token: 0x06022A4F RID: 141903 RVA: 0x00333C07 File Offset: 0x00331E07
		public FMovieSceneObjectPathChannelKeyValue DefaultValue
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneObjectPathChannelKeyValue result;
				if ((result = this._DefaultValue) == null)
				{
					result = (this._DefaultValue = new FMovieSceneObjectPathChannelKeyValue(base.NativePtr + (IntPtr)FMovieSceneObjectPathChannel.__PropertyOffset_DefaultValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectPathChannelKeyValue.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneObjectPathChannel.__PropertyOffset_DefaultValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022A50 RID: 141904 RVA: 0x00333C28 File Offset: 0x00331E28
		public FMovieSceneObjectPathChannel()
		{
		}

		// Token: 0x06022A51 RID: 141905 RVA: 0x00333C30 File Offset: 0x00331E30
		public FMovieSceneObjectPathChannel(UClassStackOnlyPtr PropertyClass, TArray<FFrameNumber> Times, TArray<FMovieSceneObjectPathChannelKeyValue> Values, FMovieSceneObjectPathChannelKeyValue DefaultValue)
		{
			this.PropertyClass = PropertyClass;
			this.Times = Times;
			this.Values = Values;
			this.DefaultValue = DefaultValue;
		}

		// Token: 0x06022A52 RID: 141906 RVA: 0x00333C55 File Offset: 0x00331E55
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneObjectPathChannel.StaticStruct();
		}

		// Token: 0x06022A53 RID: 141907 RVA: 0x00333C61 File Offset: 0x00331E61
		[NullableContext(2)]
		public FMovieSceneObjectPathChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022A54 RID: 141908 RVA: 0x00333C6B File Offset: 0x00331E6B
		public FMovieSceneObjectPathChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022A55 RID: 141909 RVA: 0x00333C76 File Offset: 0x00331E76
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneObjectPathChannel(Pointer, false, true);
		}

		// Token: 0x06022A56 RID: 141910 RVA: 0x00333C80 File Offset: 0x00331E80
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneObjectPathChannel(Pointer, MemoryOwner);
		}

		// Token: 0x04012825 RID: 75813
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneObjectPathChannel";

		// Token: 0x04012826 RID: 75814
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012827 RID: 75815
		internal static int __PropertyOffset_PropertyClass;

		// Token: 0x04012828 RID: 75816
		internal static int __PropertyOffset_Times;

		// Token: 0x04012829 RID: 75817
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _Times;

		// Token: 0x0401282A RID: 75818
		internal static int __PropertyOffset_Values;

		// Token: 0x0401282B RID: 75819
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneObjectPathChannelKeyValue> _Values;

		// Token: 0x0401282C RID: 75820
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x0401282D RID: 75821
		[Nullable(2)]
		private FMovieSceneObjectPathChannelKeyValue _DefaultValue;
	}
}
