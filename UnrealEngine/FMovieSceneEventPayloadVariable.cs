using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000766 RID: 1894
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventPayloadVariable")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneEventPayloadVariable : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A496 RID: 42134 RVA: 0x000F3161 File Offset: 0x000F1361
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEventPayloadVariable._ScriptStructPtr != 0) ? FMovieSceneEventPayloadVariable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneEventPayloadVariable", ref FMovieSceneEventPayloadVariable._ScriptStructPtr);
		}

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x0600A497 RID: 42135 RVA: 0x000F3185 File Offset: 0x000F1385
		// (set) Token: 0x0600A498 RID: 42136 RVA: 0x000F3199 File Offset: 0x000F1399
		public unsafe string Value
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneEventPayloadVariable.__PropertyOffset_Value)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneEventPayloadVariable.__PropertyOffset_Value)), value);
			}
		}

		// Token: 0x0600A499 RID: 42137 RVA: 0x000F31AE File Offset: 0x000F13AE
		public FMovieSceneEventPayloadVariable()
		{
		}

		// Token: 0x0600A49A RID: 42138 RVA: 0x000F31B6 File Offset: 0x000F13B6
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEventPayloadVariable.StaticStruct();
		}

		// Token: 0x0600A49B RID: 42139 RVA: 0x000F31C2 File Offset: 0x000F13C2
		[NullableContext(2)]
		public FMovieSceneEventPayloadVariable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A49C RID: 42140 RVA: 0x000F31CC File Offset: 0x000F13CC
		public FMovieSceneEventPayloadVariable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A49D RID: 42141 RVA: 0x000F31D7 File Offset: 0x000F13D7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEventPayloadVariable(Pointer, false, true);
		}

		// Token: 0x0600A49E RID: 42142 RVA: 0x000F31E1 File Offset: 0x000F13E1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEventPayloadVariable(Pointer, MemoryOwner);
		}

		// Token: 0x04004633 RID: 17971
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventPayloadVariable";

		// Token: 0x04004634 RID: 17972
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004635 RID: 17973
		internal static int __PropertyOffset_Value;
	}
}
