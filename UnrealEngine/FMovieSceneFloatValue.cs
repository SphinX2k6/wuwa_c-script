using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200240A RID: 9226
	[UnrealObjectPath("/Script/MovieScene.MovieSceneFloatValue")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FMovieSceneFloatValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060229A6 RID: 141734 RVA: 0x00332DA4 File Offset: 0x00330FA4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneFloatValue._ScriptStructPtr != 0) ? FMovieSceneFloatValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneFloatValue", ref FMovieSceneFloatValue._ScriptStructPtr);
		}

		// Token: 0x17008535 RID: 34101
		// (get) Token: 0x060229A7 RID: 141735 RVA: 0x00332DC8 File Offset: 0x00330FC8
		// (set) Token: 0x060229A8 RID: 141736 RVA: 0x00332DD8 File Offset: 0x00330FD8
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatValue.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatValue.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17008536 RID: 34102
		// (get) Token: 0x060229A9 RID: 141737 RVA: 0x00332DE9 File Offset: 0x00330FE9
		// (set) Token: 0x060229AA RID: 141738 RVA: 0x00332DFD File Offset: 0x00330FFD
		public unsafe FMovieSceneTangentData Tangent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatValue.__PropertyOffset_Tangent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatValue.__PropertyOffset_Tangent) = value;
			}
		}

		// Token: 0x17008537 RID: 34103
		// (get) Token: 0x060229AB RID: 141739 RVA: 0x00332E12 File Offset: 0x00331012
		// (set) Token: 0x060229AC RID: 141740 RVA: 0x00332E26 File Offset: 0x00331026
		public unsafe TEnumAsByte<ERichCurveInterpMode> InterpMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatValue.__PropertyOffset_InterpMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatValue.__PropertyOffset_InterpMode) = value;
			}
		}

		// Token: 0x17008538 RID: 34104
		// (get) Token: 0x060229AD RID: 141741 RVA: 0x00332E3B File Offset: 0x0033103B
		// (set) Token: 0x060229AE RID: 141742 RVA: 0x00332E4F File Offset: 0x0033104F
		public unsafe TEnumAsByte<ERichCurveTangentMode> TangentMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatValue.__PropertyOffset_TangentMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatValue.__PropertyOffset_TangentMode) = value;
			}
		}

		// Token: 0x17008539 RID: 34105
		// (get) Token: 0x060229AF RID: 141743 RVA: 0x00332E64 File Offset: 0x00331064
		// (set) Token: 0x060229B0 RID: 141744 RVA: 0x00332E74 File Offset: 0x00331074
		public unsafe byte PaddingByte
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatValue.__PropertyOffset_PaddingByte);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatValue.__PropertyOffset_PaddingByte) = value;
			}
		}

		// Token: 0x060229B1 RID: 141745 RVA: 0x00332E85 File Offset: 0x00331085
		public FMovieSceneFloatValue()
		{
		}

		// Token: 0x060229B2 RID: 141746 RVA: 0x00332E8D File Offset: 0x0033108D
		public FMovieSceneFloatValue(float Value, FMovieSceneTangentData Tangent, TEnumAsByte<ERichCurveInterpMode> InterpMode, TEnumAsByte<ERichCurveTangentMode> TangentMode, byte PaddingByte)
		{
			this.Value = Value;
			this.Tangent = Tangent;
			this.InterpMode = InterpMode;
			this.TangentMode = TangentMode;
			this.PaddingByte = PaddingByte;
		}

		// Token: 0x060229B3 RID: 141747 RVA: 0x00332EBA File Offset: 0x003310BA
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneFloatValue.StaticStruct();
		}

		// Token: 0x060229B4 RID: 141748 RVA: 0x00332EC6 File Offset: 0x003310C6
		[NullableContext(2)]
		public FMovieSceneFloatValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060229B5 RID: 141749 RVA: 0x00332ED0 File Offset: 0x003310D0
		public FMovieSceneFloatValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060229B6 RID: 141750 RVA: 0x00332EDB File Offset: 0x003310DB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneFloatValue(Pointer, false, true);
		}

		// Token: 0x060229B7 RID: 141751 RVA: 0x00332EE5 File Offset: 0x003310E5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneFloatValue(Pointer, MemoryOwner);
		}

		// Token: 0x040127DA RID: 75738
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneFloatValue";

		// Token: 0x040127DB RID: 75739
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040127DC RID: 75740
		internal static int __PropertyOffset_Value;

		// Token: 0x040127DD RID: 75741
		internal static int __PropertyOffset_Tangent;

		// Token: 0x040127DE RID: 75742
		internal static int __PropertyOffset_InterpMode;

		// Token: 0x040127DF RID: 75743
		internal static int __PropertyOffset_TangentMode;

		// Token: 0x040127E0 RID: 75744
		internal static int __PropertyOffset_PaddingByte;
	}
}
