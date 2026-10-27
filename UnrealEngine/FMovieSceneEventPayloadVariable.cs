using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200236E RID: 9070
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventPayloadVariable")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneEventPayloadVariable : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060223B4 RID: 140212 RVA: 0x00329EBB File Offset: 0x003280BB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEventPayloadVariable._ScriptStructPtr != 0) ? FMovieSceneEventPayloadVariable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneEventPayloadVariable", ref FMovieSceneEventPayloadVariable._ScriptStructPtr);
		}

		// Token: 0x17008419 RID: 33817
		// (get) Token: 0x060223B5 RID: 140213 RVA: 0x00329EDF File Offset: 0x003280DF
		// (set) Token: 0x060223B6 RID: 140214 RVA: 0x00329EF3 File Offset: 0x003280F3
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

		// Token: 0x060223B7 RID: 140215 RVA: 0x00329F08 File Offset: 0x00328108
		public FMovieSceneEventPayloadVariable()
		{
		}

		// Token: 0x060223B8 RID: 140216 RVA: 0x00329F10 File Offset: 0x00328110
		public FMovieSceneEventPayloadVariable(string Value)
		{
			this.Value = Value;
		}

		// Token: 0x060223B9 RID: 140217 RVA: 0x00329F1F File Offset: 0x0032811F
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEventPayloadVariable.StaticStruct();
		}

		// Token: 0x060223BA RID: 140218 RVA: 0x00329F2B File Offset: 0x0032812B
		[NullableContext(2)]
		public FMovieSceneEventPayloadVariable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060223BB RID: 140219 RVA: 0x00329F35 File Offset: 0x00328135
		public FMovieSceneEventPayloadVariable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060223BC RID: 140220 RVA: 0x00329F40 File Offset: 0x00328140
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEventPayloadVariable(Pointer, false, true);
		}

		// Token: 0x060223BD RID: 140221 RVA: 0x00329F4A File Offset: 0x0032814A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEventPayloadVariable(Pointer, MemoryOwner);
		}

		// Token: 0x0401245B RID: 74843
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventPayloadVariable";

		// Token: 0x0401245C RID: 74844
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401245D RID: 74845
		internal static int __PropertyOffset_Value;
	}
}
