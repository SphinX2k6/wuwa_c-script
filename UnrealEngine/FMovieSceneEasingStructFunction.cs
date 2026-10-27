using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023E6 RID: 9190
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEasingStructFunction")]
	[UnrealStructLayout(2, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2)]
	public class FMovieSceneEasingStructFunction : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602280C RID: 141324 RVA: 0x003309A4 File Offset: 0x0032EBA4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEasingStructFunction._ScriptStructPtr != 0) ? FMovieSceneEasingStructFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEasingStructFunction", ref FMovieSceneEasingStructFunction._ScriptStructPtr);
		}

		// Token: 0x170084E7 RID: 34023
		// (get) Token: 0x0602280D RID: 141325 RVA: 0x003309C8 File Offset: 0x0032EBC8
		// (set) Token: 0x0602280E RID: 141326 RVA: 0x003309D8 File Offset: 0x0032EBD8
		public unsafe EMovieSceneBuiltInEasing Type
		{
			get
			{
				return (EMovieSceneBuiltInEasing)(*(base.NativePtr + (IntPtr)FMovieSceneEasingStructFunction.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEasingStructFunction.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x170084E8 RID: 34024
		// (get) Token: 0x0602280F RID: 141327 RVA: 0x003309E9 File Offset: 0x0032EBE9
		// (set) Token: 0x06022810 RID: 141328 RVA: 0x003309F9 File Offset: 0x0032EBF9
		public unsafe bool bHasSetType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEasingStructFunction.__PropertyOffset_bHasSetType) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEasingStructFunction.__PropertyOffset_bHasSetType) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022811 RID: 141329 RVA: 0x00330A0A File Offset: 0x0032EC0A
		public FMovieSceneEasingStructFunction()
		{
		}

		// Token: 0x06022812 RID: 141330 RVA: 0x00330A12 File Offset: 0x0032EC12
		public FMovieSceneEasingStructFunction(EMovieSceneBuiltInEasing Type, bool bHasSetType)
		{
			this.Type = Type;
			this.bHasSetType = bHasSetType;
		}

		// Token: 0x06022813 RID: 141331 RVA: 0x00330A28 File Offset: 0x0032EC28
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEasingStructFunction.StaticStruct();
		}

		// Token: 0x06022814 RID: 141332 RVA: 0x00330A34 File Offset: 0x0032EC34
		[NullableContext(2)]
		public FMovieSceneEasingStructFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022815 RID: 141333 RVA: 0x00330A3E File Offset: 0x0032EC3E
		public FMovieSceneEasingStructFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022816 RID: 141334 RVA: 0x00330A49 File Offset: 0x0032EC49
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEasingStructFunction(Pointer, false, true);
		}

		// Token: 0x06022817 RID: 141335 RVA: 0x00330A53 File Offset: 0x0032EC53
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEasingStructFunction(Pointer, MemoryOwner);
		}

		// Token: 0x04012719 RID: 75545
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEasingStructFunction";

		// Token: 0x0401271A RID: 75546
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401271B RID: 75547
		internal static int __PropertyOffset_Type;

		// Token: 0x0401271C RID: 75548
		internal static int __PropertyOffset_bHasSetType;
	}
}
