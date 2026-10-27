using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002442 RID: 9282
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSubSectionData")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FMovieSceneSubSectionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022CD5 RID: 142549 RVA: 0x0033752C File Offset: 0x0033572C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSubSectionData._ScriptStructPtr != 0) ? FMovieSceneSubSectionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSubSectionData", ref FMovieSceneSubSectionData._ScriptStructPtr);
		}

		// Token: 0x170085D2 RID: 34258
		// (get) Token: 0x06022CD6 RID: 142550 RVA: 0x00337550 File Offset: 0x00335750
		// (set) Token: 0x06022CD7 RID: 142551 RVA: 0x00337564 File Offset: 0x00335764
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UMovieSceneSubSection> Section
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSubSectionData.__PropertyOffset_Section);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSubSectionData.__PropertyOffset_Section) = value;
			}
		}

		// Token: 0x170085D3 RID: 34259
		// (get) Token: 0x06022CD8 RID: 142552 RVA: 0x00337579 File Offset: 0x00335779
		// (set) Token: 0x06022CD9 RID: 142553 RVA: 0x0033758D File Offset: 0x0033578D
		public unsafe FGuid ObjectBindingId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSubSectionData.__PropertyOffset_ObjectBindingId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSubSectionData.__PropertyOffset_ObjectBindingId) = value;
			}
		}

		// Token: 0x170085D4 RID: 34260
		// (get) Token: 0x06022CDA RID: 142554 RVA: 0x003375A2 File Offset: 0x003357A2
		// (set) Token: 0x06022CDB RID: 142555 RVA: 0x003375B2 File Offset: 0x003357B2
		public unsafe ESectionEvaluationFlags Flags
		{
			get
			{
				return (ESectionEvaluationFlags)(*(base.NativePtr + (IntPtr)FMovieSceneSubSectionData.__PropertyOffset_Flags));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSubSectionData.__PropertyOffset_Flags) = (byte)value;
			}
		}

		// Token: 0x06022CDC RID: 142556 RVA: 0x003375C3 File Offset: 0x003357C3
		public FMovieSceneSubSectionData()
		{
		}

		// Token: 0x06022CDD RID: 142557 RVA: 0x003375CB File Offset: 0x003357CB
		public FMovieSceneSubSectionData([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSubSection> Section, FGuid ObjectBindingId, ESectionEvaluationFlags Flags)
		{
			this.Section = Section;
			this.ObjectBindingId = ObjectBindingId;
			this.Flags = Flags;
		}

		// Token: 0x06022CDE RID: 142558 RVA: 0x003375E8 File Offset: 0x003357E8
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSubSectionData.StaticStruct();
		}

		// Token: 0x06022CDF RID: 142559 RVA: 0x003375F4 File Offset: 0x003357F4
		[NullableContext(2)]
		public FMovieSceneSubSectionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022CE0 RID: 142560 RVA: 0x003375FE File Offset: 0x003357FE
		public FMovieSceneSubSectionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022CE1 RID: 142561 RVA: 0x00337609 File Offset: 0x00335809
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSubSectionData(Pointer, false, true);
		}

		// Token: 0x06022CE2 RID: 142562 RVA: 0x00337613 File Offset: 0x00335813
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSubSectionData(Pointer, MemoryOwner);
		}

		// Token: 0x0401294F RID: 76111
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSubSectionData";

		// Token: 0x04012950 RID: 76112
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012951 RID: 76113
		internal static int __PropertyOffset_Section;

		// Token: 0x04012952 RID: 76114
		internal static int __PropertyOffset_ObjectBindingId;

		// Token: 0x04012953 RID: 76115
		internal static int __PropertyOffset_Flags;
	}
}
