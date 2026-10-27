using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002366 RID: 9062
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEnumPropertySectionTemplate")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FMovieSceneEnumPropertySectionTemplate : FMovieScenePropertySectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022374 RID: 140148 RVA: 0x003298F6 File Offset: 0x00327AF6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEnumPropertySectionTemplate._ScriptStructPtr != 0) ? FMovieSceneEnumPropertySectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneEnumPropertySectionTemplate", ref FMovieSceneEnumPropertySectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17008413 RID: 33811
		// (get) Token: 0x06022375 RID: 140149 RVA: 0x0032991C File Offset: 0x00327B1C
		// (set) Token: 0x06022376 RID: 140150 RVA: 0x0032995F File Offset: 0x00327B5F
		public FMovieSceneByteChannel EnumCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneByteChannel result;
				if ((result = this._EnumCurve) == null)
				{
					result = (this._EnumCurve = new FMovieSceneByteChannel(base.NativePtr + (IntPtr)FMovieSceneEnumPropertySectionTemplate.__PropertyOffset_EnumCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneByteChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEnumPropertySectionTemplate.__PropertyOffset_EnumCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022377 RID: 140151 RVA: 0x00329980 File Offset: 0x00327B80
		public FMovieSceneEnumPropertySectionTemplate()
		{
		}

		// Token: 0x06022378 RID: 140152 RVA: 0x00329988 File Offset: 0x00327B88
		public FMovieSceneEnumPropertySectionTemplate(FMovieSceneByteChannel EnumCurve, FMovieScenePropertySectionData PropertyData, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.EnumCurve = EnumCurve;
			base.PropertyData = PropertyData;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06022379 RID: 140153 RVA: 0x003299AD File Offset: 0x00327BAD
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEnumPropertySectionTemplate.StaticStruct();
		}

		// Token: 0x0602237A RID: 140154 RVA: 0x003299B9 File Offset: 0x00327BB9
		[NullableContext(2)]
		public FMovieSceneEnumPropertySectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602237B RID: 140155 RVA: 0x003299C3 File Offset: 0x00327BC3
		public FMovieSceneEnumPropertySectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602237C RID: 140156 RVA: 0x003299CE File Offset: 0x00327BCE
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEnumPropertySectionTemplate(Pointer, false, true);
		}

		// Token: 0x0602237D RID: 140157 RVA: 0x003299D8 File Offset: 0x00327BD8
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEnumPropertySectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x0401243B RID: 74811
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEnumPropertySectionTemplate";

		// Token: 0x0401243C RID: 74812
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401243D RID: 74813
		internal static int __PropertyOffset_EnumCurve;

		// Token: 0x0401243E RID: 74814
		[Nullable(2)]
		private FMovieSceneByteChannel _EnumCurve;
	}
}
