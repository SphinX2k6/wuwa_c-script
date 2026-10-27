using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002392 RID: 9106
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneParticleChannel")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FMovieSceneParticleChannel : FMovieSceneByteChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022526 RID: 140582 RVA: 0x0032C200 File Offset: 0x0032A400
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneParticleChannel._ScriptStructPtr != 0) ? FMovieSceneParticleChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneParticleChannel", ref FMovieSceneParticleChannel._ScriptStructPtr);
		}

		// Token: 0x06022527 RID: 140583 RVA: 0x0032C224 File Offset: 0x0032A424
		public FMovieSceneParticleChannel()
		{
		}

		// Token: 0x06022528 RID: 140584 RVA: 0x0032C22C File Offset: 0x0032A42C
		[NullableContext(1)]
		public FMovieSceneParticleChannel(TArray<FFrameNumber> Times, byte DefaultValue, bool bHasDefaultValue, TArray<byte> Values, UEnum Enum)
		{
			base.Times = Times;
			base.DefaultValue = DefaultValue;
			base.bHasDefaultValue = bHasDefaultValue;
			base.Values = Values;
			base.Enum = Enum;
		}

		// Token: 0x06022529 RID: 140585 RVA: 0x0032C259 File Offset: 0x0032A459
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneParticleChannel.StaticStruct();
		}

		// Token: 0x0602252A RID: 140586 RVA: 0x0032C265 File Offset: 0x0032A465
		[NullableContext(2)]
		public FMovieSceneParticleChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602252B RID: 140587 RVA: 0x0032C26F File Offset: 0x0032A46F
		public FMovieSceneParticleChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602252C RID: 140588 RVA: 0x0032C27A File Offset: 0x0032A47A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneParticleChannel(Pointer, false, true);
		}

		// Token: 0x0602252D RID: 140589 RVA: 0x0032C284 File Offset: 0x0032A484
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneParticleChannel(Pointer, MemoryOwner);
		}

		// Token: 0x04012523 RID: 75043
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneParticleChannel";

		// Token: 0x04012524 RID: 75044
		private static IntPtr _ScriptStructPtr;
	}
}
