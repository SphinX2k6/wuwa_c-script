using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002342 RID: 9026
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneBytePropertySectionTemplate")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FMovieSceneBytePropertySectionTemplate : FMovieScenePropertySectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022200 RID: 139776 RVA: 0x003274EE File Offset: 0x003256EE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneBytePropertySectionTemplate._ScriptStructPtr != 0) ? FMovieSceneBytePropertySectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneBytePropertySectionTemplate", ref FMovieSceneBytePropertySectionTemplate._ScriptStructPtr);
		}

		// Token: 0x170083CF RID: 33743
		// (get) Token: 0x06022201 RID: 139777 RVA: 0x00327514 File Offset: 0x00325714
		// (set) Token: 0x06022202 RID: 139778 RVA: 0x00327557 File Offset: 0x00325757
		public FMovieSceneByteChannel ByteCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneByteChannel result;
				if ((result = this._ByteCurve) == null)
				{
					result = (this._ByteCurve = new FMovieSceneByteChannel(base.NativePtr + (IntPtr)FMovieSceneBytePropertySectionTemplate.__PropertyOffset_ByteCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneByteChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneBytePropertySectionTemplate.__PropertyOffset_ByteCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022203 RID: 139779 RVA: 0x00327578 File Offset: 0x00325778
		public FMovieSceneBytePropertySectionTemplate()
		{
		}

		// Token: 0x06022204 RID: 139780 RVA: 0x00327580 File Offset: 0x00325780
		public FMovieSceneBytePropertySectionTemplate(FMovieSceneByteChannel ByteCurve, FMovieScenePropertySectionData PropertyData, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.ByteCurve = ByteCurve;
			base.PropertyData = PropertyData;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06022205 RID: 139781 RVA: 0x003275A5 File Offset: 0x003257A5
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneBytePropertySectionTemplate.StaticStruct();
		}

		// Token: 0x06022206 RID: 139782 RVA: 0x003275B1 File Offset: 0x003257B1
		[NullableContext(2)]
		public FMovieSceneBytePropertySectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022207 RID: 139783 RVA: 0x003275BB File Offset: 0x003257BB
		public FMovieSceneBytePropertySectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022208 RID: 139784 RVA: 0x003275C6 File Offset: 0x003257C6
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneBytePropertySectionTemplate(Pointer, false, true);
		}

		// Token: 0x06022209 RID: 139785 RVA: 0x003275D0 File Offset: 0x003257D0
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneBytePropertySectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x0401236B RID: 74603
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneBytePropertySectionTemplate";

		// Token: 0x0401236C RID: 74604
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401236D RID: 74605
		internal static int __PropertyOffset_ByteCurve;

		// Token: 0x0401236E RID: 74606
		[Nullable(2)]
		private FMovieSceneByteChannel _ByteCurve;
	}
}
