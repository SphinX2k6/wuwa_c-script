using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200236F RID: 9071
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventPtrs")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FMovieSceneEventPtrs : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060223BE RID: 140222 RVA: 0x00329F53 File Offset: 0x00328153
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEventPtrs._ScriptStructPtr != 0) ? FMovieSceneEventPtrs._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneEventPtrs", ref FMovieSceneEventPtrs._ScriptStructPtr);
		}

		// Token: 0x1700841A RID: 33818
		// (get) Token: 0x060223BF RID: 140223 RVA: 0x00329F77 File Offset: 0x00328177
		// (set) Token: 0x060223C0 RID: 140224 RVA: 0x00329F8B File Offset: 0x0032818B
		[Nullable(2)]
		public unsafe UFunction Function
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFunction>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneEventPtrs.__PropertyOffset_Function);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneEventPtrs.__PropertyOffset_Function, value);
			}
		}

		// Token: 0x1700841B RID: 33819
		// (get) Token: 0x060223C1 RID: 140225 RVA: 0x00329FA0 File Offset: 0x003281A0
		// (set) Token: 0x060223C2 RID: 140226 RVA: 0x00329FB0 File Offset: 0x003281B0
		public unsafe Unusable BoundObjectProperty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEventPtrs.__PropertyOffset_BoundObjectProperty);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEventPtrs.__PropertyOffset_BoundObjectProperty) = value;
			}
		}

		// Token: 0x060223C3 RID: 140227 RVA: 0x00329FC1 File Offset: 0x003281C1
		public FMovieSceneEventPtrs()
		{
		}

		// Token: 0x060223C4 RID: 140228 RVA: 0x00329FC9 File Offset: 0x003281C9
		public FMovieSceneEventPtrs(UFunction Function, Unusable BoundObjectProperty)
		{
			this.Function = Function;
			this.BoundObjectProperty = BoundObjectProperty;
		}

		// Token: 0x060223C5 RID: 140229 RVA: 0x00329FDF File Offset: 0x003281DF
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEventPtrs.StaticStruct();
		}

		// Token: 0x060223C6 RID: 140230 RVA: 0x00329FEB File Offset: 0x003281EB
		[NullableContext(2)]
		public FMovieSceneEventPtrs(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060223C7 RID: 140231 RVA: 0x00329FF5 File Offset: 0x003281F5
		public FMovieSceneEventPtrs(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060223C8 RID: 140232 RVA: 0x0032A000 File Offset: 0x00328200
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEventPtrs(Pointer, false, true);
		}

		// Token: 0x060223C9 RID: 140233 RVA: 0x0032A00A File Offset: 0x0032820A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEventPtrs(Pointer, MemoryOwner);
		}

		// Token: 0x0401245E RID: 74846
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventPtrs";

		// Token: 0x0401245F RID: 74847
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012460 RID: 74848
		internal static int __PropertyOffset_Function;

		// Token: 0x04012461 RID: 74849
		internal static int __PropertyOffset_BoundObjectProperty;
	}
}
