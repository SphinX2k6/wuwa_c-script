using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200077F RID: 1919
	[UnrealObjectPath("/Script/MovieScene.MovieSceneFloatValue")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FMovieSceneFloatValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A5BE RID: 42430 RVA: 0x000F4CA4 File Offset: 0x000F2EA4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneFloatValue._ScriptStructPtr != 0) ? FMovieSceneFloatValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneFloatValue", ref FMovieSceneFloatValue._ScriptStructPtr);
		}

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x0600A5BF RID: 42431 RVA: 0x000F4CC8 File Offset: 0x000F2EC8
		// (set) Token: 0x0600A5C0 RID: 42432 RVA: 0x000F4CD8 File Offset: 0x000F2ED8
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

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x0600A5C1 RID: 42433 RVA: 0x000F4CE9 File Offset: 0x000F2EE9
		// (set) Token: 0x0600A5C2 RID: 42434 RVA: 0x000F4CFD File Offset: 0x000F2EFD
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

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x0600A5C3 RID: 42435 RVA: 0x000F4D12 File Offset: 0x000F2F12
		// (set) Token: 0x0600A5C4 RID: 42436 RVA: 0x000F4D26 File Offset: 0x000F2F26
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

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x0600A5C5 RID: 42437 RVA: 0x000F4D3B File Offset: 0x000F2F3B
		// (set) Token: 0x0600A5C6 RID: 42438 RVA: 0x000F4D4B File Offset: 0x000F2F4B
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

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x000F4D5C File Offset: 0x000F2F5C
		public FMovieSceneFloatValue()
		{
		}

		// Token: 0x0600A5C8 RID: 42440 RVA: 0x000F4D64 File Offset: 0x000F2F64
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneFloatValue.StaticStruct();
		}

		// Token: 0x0600A5C9 RID: 42441 RVA: 0x000F4D70 File Offset: 0x000F2F70
		[NullableContext(2)]
		public FMovieSceneFloatValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A5CA RID: 42442 RVA: 0x000F4D7A File Offset: 0x000F2F7A
		public FMovieSceneFloatValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A5CB RID: 42443 RVA: 0x000F4D85 File Offset: 0x000F2F85
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneFloatValue(Pointer, false, true);
		}

		// Token: 0x0600A5CC RID: 42444 RVA: 0x000F4D8F File Offset: 0x000F2F8F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneFloatValue(Pointer, MemoryOwner);
		}

		// Token: 0x040046F4 RID: 18164
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneFloatValue";

		// Token: 0x040046F5 RID: 18165
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040046F6 RID: 18166
		internal static int __PropertyOffset_Value;

		// Token: 0x040046F7 RID: 18167
		internal static int __PropertyOffset_InterpMode;

		// Token: 0x040046F8 RID: 18168
		internal static int __PropertyOffset_TangentMode;

		// Token: 0x040046F9 RID: 18169
		internal static int __PropertyOffset_PaddingByte;
	}
}
