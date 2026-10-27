using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002713 RID: 10003
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.VectorNameAndCurve")]
	[UnrealStructLayout(520, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 520)]
	public class FVectorNameAndCurve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025150 RID: 151888 RVA: 0x0036E8EE File Offset: 0x0036CAEE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVectorNameAndCurve._ScriptStructPtr != 0) ? FVectorNameAndCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.VectorNameAndCurve", ref FVectorNameAndCurve._ScriptStructPtr);
		}

		// Token: 0x17008F0D RID: 36621
		// (get) Token: 0x06025151 RID: 151889 RVA: 0x0036E912 File Offset: 0x0036CB12
		// (set) Token: 0x06025152 RID: 151890 RVA: 0x0036E926 File Offset: 0x0036CB26
		public unsafe FName Group
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVectorNameAndCurve.__PropertyOffset_Group);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVectorNameAndCurve.__PropertyOffset_Group) = value;
			}
		}

		// Token: 0x17008F0E RID: 36622
		// (get) Token: 0x06025153 RID: 151891 RVA: 0x0036E93B File Offset: 0x0036CB3B
		// (set) Token: 0x06025154 RID: 151892 RVA: 0x0036E94F File Offset: 0x0036CB4F
		public unsafe FName DisplayName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVectorNameAndCurve.__PropertyOffset_DisplayName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVectorNameAndCurve.__PropertyOffset_DisplayName) = value;
			}
		}

		// Token: 0x17008F0F RID: 36623
		// (get) Token: 0x06025155 RID: 151893 RVA: 0x0036E964 File Offset: 0x0036CB64
		// (set) Token: 0x06025156 RID: 151894 RVA: 0x0036E978 File Offset: 0x0036CB78
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVectorNameAndCurve.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVectorNameAndCurve.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17008F10 RID: 36624
		// (get) Token: 0x06025157 RID: 151895 RVA: 0x0036E98D File Offset: 0x0036CB8D
		// (set) Token: 0x06025158 RID: 151896 RVA: 0x0036E99D File Offset: 0x0036CB9D
		public unsafe bool bCustom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVectorNameAndCurve.__PropertyOffset_bCustom) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVectorNameAndCurve.__PropertyOffset_bCustom) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008F11 RID: 36625
		// (get) Token: 0x06025159 RID: 151897 RVA: 0x0036E9B0 File Offset: 0x0036CBB0
		// (set) Token: 0x0602515A RID: 151898 RVA: 0x0036E9F3 File Offset: 0x0036CBF3
		public FMovieSceneFloatChannel XCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._XCurve) == null)
				{
					result = (this._XCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FVectorNameAndCurve.__PropertyOffset_XCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FVectorNameAndCurve.__PropertyOffset_XCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008F12 RID: 36626
		// (get) Token: 0x0602515B RID: 151899 RVA: 0x0036EA14 File Offset: 0x0036CC14
		// (set) Token: 0x0602515C RID: 151900 RVA: 0x0036EA57 File Offset: 0x0036CC57
		public FMovieSceneFloatChannel YCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._YCurve) == null)
				{
					result = (this._YCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FVectorNameAndCurve.__PropertyOffset_YCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FVectorNameAndCurve.__PropertyOffset_YCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008F13 RID: 36627
		// (get) Token: 0x0602515D RID: 151901 RVA: 0x0036EA78 File Offset: 0x0036CC78
		// (set) Token: 0x0602515E RID: 151902 RVA: 0x0036EABB File Offset: 0x0036CCBB
		public FMovieSceneFloatChannel ZCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._ZCurve) == null)
				{
					result = (this._ZCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FVectorNameAndCurve.__PropertyOffset_ZCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FVectorNameAndCurve.__PropertyOffset_ZCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602515F RID: 151903 RVA: 0x0036EADC File Offset: 0x0036CCDC
		public FVectorNameAndCurve()
		{
		}

		// Token: 0x06025160 RID: 151904 RVA: 0x0036EAE4 File Offset: 0x0036CCE4
		public FVectorNameAndCurve(FName Group, FName DisplayName, FName ParameterName, bool bCustom, FMovieSceneFloatChannel XCurve, FMovieSceneFloatChannel YCurve, FMovieSceneFloatChannel ZCurve)
		{
			this.Group = Group;
			this.DisplayName = DisplayName;
			this.ParameterName = ParameterName;
			this.bCustom = bCustom;
			this.XCurve = XCurve;
			this.YCurve = YCurve;
			this.ZCurve = ZCurve;
		}

		// Token: 0x06025161 RID: 151905 RVA: 0x0036EB21 File Offset: 0x0036CD21
		protected override IntPtr GetUStructPtr()
		{
			return FVectorNameAndCurve.StaticStruct();
		}

		// Token: 0x06025162 RID: 151906 RVA: 0x0036EB2D File Offset: 0x0036CD2D
		[NullableContext(2)]
		public FVectorNameAndCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025163 RID: 151907 RVA: 0x0036EB37 File Offset: 0x0036CD37
		public FVectorNameAndCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025164 RID: 151908 RVA: 0x0036EB42 File Offset: 0x0036CD42
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVectorNameAndCurve(Pointer, false, true);
		}

		// Token: 0x06025165 RID: 151909 RVA: 0x0036EB4C File Offset: 0x0036CD4C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVectorNameAndCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04013F8F RID: 81807
		public const string __ObjectPath = "/Script/SequenceDialogue.VectorNameAndCurve";

		// Token: 0x04013F90 RID: 81808
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013F91 RID: 81809
		internal static int __PropertyOffset_Group;

		// Token: 0x04013F92 RID: 81810
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x04013F93 RID: 81811
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04013F94 RID: 81812
		internal static int __PropertyOffset_bCustom;

		// Token: 0x04013F95 RID: 81813
		internal static int __PropertyOffset_XCurve;

		// Token: 0x04013F96 RID: 81814
		[Nullable(2)]
		private FMovieSceneFloatChannel _XCurve;

		// Token: 0x04013F97 RID: 81815
		internal static int __PropertyOffset_YCurve;

		// Token: 0x04013F98 RID: 81816
		[Nullable(2)]
		private FMovieSceneFloatChannel _YCurve;

		// Token: 0x04013F99 RID: 81817
		internal static int __PropertyOffset_ZCurve;

		// Token: 0x04013F9A RID: 81818
		[Nullable(2)]
		private FMovieSceneFloatChannel _ZCurve;
	}
}
