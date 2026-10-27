using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023D2 RID: 9170
	[UnrealObjectPath("/Script/MovieScene.GeneratedMovieSceneKeyStruct")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FGeneratedMovieSceneKeyStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022721 RID: 141089 RVA: 0x0032F0EA File Offset: 0x0032D2EA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGeneratedMovieSceneKeyStruct._ScriptStructPtr != 0) ? FGeneratedMovieSceneKeyStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.GeneratedMovieSceneKeyStruct", ref FGeneratedMovieSceneKeyStruct._ScriptStructPtr);
		}

		// Token: 0x06022722 RID: 141090 RVA: 0x0032F10E File Offset: 0x0032D30E
		public FGeneratedMovieSceneKeyStruct()
		{
		}

		// Token: 0x06022723 RID: 141091 RVA: 0x0032F116 File Offset: 0x0032D316
		protected override IntPtr GetUStructPtr()
		{
			return FGeneratedMovieSceneKeyStruct.StaticStruct();
		}

		// Token: 0x06022724 RID: 141092 RVA: 0x0032F122 File Offset: 0x0032D322
		[NullableContext(2)]
		public FGeneratedMovieSceneKeyStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022725 RID: 141093 RVA: 0x0032F12C File Offset: 0x0032D32C
		public FGeneratedMovieSceneKeyStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022726 RID: 141094 RVA: 0x0032F137 File Offset: 0x0032D337
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGeneratedMovieSceneKeyStruct(Pointer, false, true);
		}

		// Token: 0x06022727 RID: 141095 RVA: 0x0032F141 File Offset: 0x0032D341
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGeneratedMovieSceneKeyStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0401268E RID: 75406
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.GeneratedMovieSceneKeyStruct";

		// Token: 0x0401268F RID: 75407
		private static IntPtr _ScriptStructPtr;
	}
}
