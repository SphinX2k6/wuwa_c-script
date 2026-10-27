using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023B9 RID: 9145
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneVectorPropertySectionTemplate")]
	[UnrealStructLayout(712, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 712)]
	public class FMovieSceneVectorPropertySectionTemplate : FMovieScenePropertySectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060226AC RID: 140972 RVA: 0x0032E61B File Offset: 0x0032C81B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneVectorPropertySectionTemplate._ScriptStructPtr != 0) ? FMovieSceneVectorPropertySectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneVectorPropertySectionTemplate", ref FMovieSceneVectorPropertySectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17008498 RID: 33944
		// (get) Token: 0x060226AD RID: 140973 RVA: 0x0032E640 File Offset: 0x0032C840
		// (set) Token: 0x060226AE RID: 140974 RVA: 0x0032E684 File Offset: 0x0032C884
		public TFixedArray<FMovieSceneFloatChannel> ComponentCurves
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._ComponentCurves) == null)
				{
					result = (this._ComponentCurves = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)FMovieSceneVectorPropertySectionTemplate.__PropertyOffset_ComponentCurves, 4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ComponentCurves.CopyAssign(value);
			}
		}

		// Token: 0x17008499 RID: 33945
		// (get) Token: 0x060226AF RID: 140975 RVA: 0x0032E692 File Offset: 0x0032C892
		// (set) Token: 0x060226B0 RID: 140976 RVA: 0x0032E6A2 File Offset: 0x0032C8A2
		public unsafe int NumChannelsUsed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneVectorPropertySectionTemplate.__PropertyOffset_NumChannelsUsed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneVectorPropertySectionTemplate.__PropertyOffset_NumChannelsUsed) = value;
			}
		}

		// Token: 0x1700849A RID: 33946
		// (get) Token: 0x060226B1 RID: 140977 RVA: 0x0032E6B3 File Offset: 0x0032C8B3
		// (set) Token: 0x060226B2 RID: 140978 RVA: 0x0032E6C3 File Offset: 0x0032C8C3
		public unsafe EMovieSceneBlendType BlendType
		{
			get
			{
				return (EMovieSceneBlendType)(*(base.NativePtr + (IntPtr)FMovieSceneVectorPropertySectionTemplate.__PropertyOffset_BlendType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneVectorPropertySectionTemplate.__PropertyOffset_BlendType) = (byte)value;
			}
		}

		// Token: 0x060226B3 RID: 140979 RVA: 0x0032E6D4 File Offset: 0x0032C8D4
		public FMovieSceneVectorPropertySectionTemplate()
		{
		}

		// Token: 0x060226B4 RID: 140980 RVA: 0x0032E6DC File Offset: 0x0032C8DC
		public FMovieSceneVectorPropertySectionTemplate(TFixedArray<FMovieSceneFloatChannel> ComponentCurves, int NumChannelsUsed, EMovieSceneBlendType BlendType, FMovieScenePropertySectionData PropertyData, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.ComponentCurves = ComponentCurves;
			this.NumChannelsUsed = NumChannelsUsed;
			this.BlendType = BlendType;
			base.PropertyData = PropertyData;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060226B5 RID: 140981 RVA: 0x0032E711 File Offset: 0x0032C911
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneVectorPropertySectionTemplate.StaticStruct();
		}

		// Token: 0x060226B6 RID: 140982 RVA: 0x0032E71D File Offset: 0x0032C91D
		[NullableContext(2)]
		public FMovieSceneVectorPropertySectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060226B7 RID: 140983 RVA: 0x0032E727 File Offset: 0x0032C927
		public FMovieSceneVectorPropertySectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060226B8 RID: 140984 RVA: 0x0032E732 File Offset: 0x0032C932
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneVectorPropertySectionTemplate(Pointer, false, true);
		}

		// Token: 0x060226B9 RID: 140985 RVA: 0x0032E73C File Offset: 0x0032C93C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneVectorPropertySectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040125F2 RID: 75250
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneVectorPropertySectionTemplate";

		// Token: 0x040125F3 RID: 75251
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040125F4 RID: 75252
		internal static int __PropertyOffset_ComponentCurves;

		// Token: 0x040125F5 RID: 75253
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _ComponentCurves;

		// Token: 0x040125F6 RID: 75254
		internal static int __PropertyOffset_NumChannelsUsed;

		// Token: 0x040125F7 RID: 75255
		internal static int __PropertyOffset_BlendType;
	}
}
