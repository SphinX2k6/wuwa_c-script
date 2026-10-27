using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023F7 RID: 9207
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationFieldEntityKey")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FMovieSceneEvaluationFieldEntityKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060228B0 RID: 141488 RVA: 0x003317D7 File Offset: 0x0032F9D7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationFieldEntityKey._ScriptStructPtr != 0) ? FMovieSceneEvaluationFieldEntityKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationFieldEntityKey", ref FMovieSceneEvaluationFieldEntityKey._ScriptStructPtr);
		}

		// Token: 0x17008502 RID: 34050
		// (get) Token: 0x060228B1 RID: 141489 RVA: 0x003317FB File Offset: 0x0032F9FB
		// (set) Token: 0x060228B2 RID: 141490 RVA: 0x0033180F File Offset: 0x0032FA0F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UObject> EntityOwner
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntityKey.__PropertyOffset_EntityOwner);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntityKey.__PropertyOffset_EntityOwner) = value;
			}
		}

		// Token: 0x17008503 RID: 34051
		// (get) Token: 0x060228B3 RID: 141491 RVA: 0x00331824 File Offset: 0x0032FA24
		// (set) Token: 0x060228B4 RID: 141492 RVA: 0x00331834 File Offset: 0x0032FA34
		public unsafe uint EntityID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntityKey.__PropertyOffset_EntityID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntityKey.__PropertyOffset_EntityID) = (int)value;
			}
		}

		// Token: 0x060228B5 RID: 141493 RVA: 0x00331845 File Offset: 0x0032FA45
		public FMovieSceneEvaluationFieldEntityKey()
		{
		}

		// Token: 0x060228B6 RID: 141494 RVA: 0x0033184D File Offset: 0x0032FA4D
		public FMovieSceneEvaluationFieldEntityKey([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UObject> EntityOwner, uint EntityID)
		{
			this.EntityOwner = EntityOwner;
			this.EntityID = EntityID;
		}

		// Token: 0x060228B7 RID: 141495 RVA: 0x00331863 File Offset: 0x0032FA63
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationFieldEntityKey.StaticStruct();
		}

		// Token: 0x060228B8 RID: 141496 RVA: 0x0033186F File Offset: 0x0032FA6F
		[NullableContext(2)]
		public FMovieSceneEvaluationFieldEntityKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060228B9 RID: 141497 RVA: 0x00331879 File Offset: 0x0032FA79
		public FMovieSceneEvaluationFieldEntityKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060228BA RID: 141498 RVA: 0x00331884 File Offset: 0x0032FA84
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationFieldEntityKey(Pointer, false, true);
		}

		// Token: 0x060228BB RID: 141499 RVA: 0x0033188E File Offset: 0x0032FA8E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationFieldEntityKey(Pointer, MemoryOwner);
		}

		// Token: 0x04012767 RID: 75623
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationFieldEntityKey";

		// Token: 0x04012768 RID: 75624
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012769 RID: 75625
		internal static int __PropertyOffset_EntityOwner;

		// Token: 0x0401276A RID: 75626
		internal static int __PropertyOffset_EntityID;
	}
}
