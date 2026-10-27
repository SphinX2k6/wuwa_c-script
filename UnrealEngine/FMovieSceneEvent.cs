using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200236B RID: 9067
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEvent")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FMovieSceneEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022397 RID: 140183 RVA: 0x00329C6A File Offset: 0x00327E6A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvent._ScriptStructPtr != 0) ? FMovieSceneEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneEvent", ref FMovieSceneEvent._ScriptStructPtr);
		}

		// Token: 0x17008416 RID: 33814
		// (get) Token: 0x06022398 RID: 140184 RVA: 0x00329C90 File Offset: 0x00327E90
		// (set) Token: 0x06022399 RID: 140185 RVA: 0x00329CD3 File Offset: 0x00327ED3
		public FMovieSceneEventPtrs Ptrs
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEventPtrs result;
				if ((result = this._Ptrs) == null)
				{
					result = (this._Ptrs = new FMovieSceneEventPtrs(base.NativePtr + (IntPtr)FMovieSceneEvent.__PropertyOffset_Ptrs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEventPtrs.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEvent.__PropertyOffset_Ptrs, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602239A RID: 140186 RVA: 0x00329CF4 File Offset: 0x00327EF4
		public FMovieSceneEvent()
		{
		}

		// Token: 0x0602239B RID: 140187 RVA: 0x00329CFC File Offset: 0x00327EFC
		public FMovieSceneEvent(FMovieSceneEventPtrs Ptrs, TMap<FName, FMovieSceneEventPayloadVariable> PayloadVariables, FName CompiledFunctionName, FName BoundObjectPinName, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UObject> WeakEndpoint, FGuid GraphGuid_DEPRECATED, FGuid NodeGuid_DEPRECATED, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UObject> FunctionEntry_DEPRECATED)
		{
			this.Ptrs = Ptrs;
		}

		// Token: 0x0602239C RID: 140188 RVA: 0x00329D0B File Offset: 0x00327F0B
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvent.StaticStruct();
		}

		// Token: 0x0602239D RID: 140189 RVA: 0x00329D17 File Offset: 0x00327F17
		[NullableContext(2)]
		public FMovieSceneEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602239E RID: 140190 RVA: 0x00329D21 File Offset: 0x00327F21
		public FMovieSceneEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602239F RID: 140191 RVA: 0x00329D2C File Offset: 0x00327F2C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvent(Pointer, false, true);
		}

		// Token: 0x060223A0 RID: 140192 RVA: 0x00329D36 File Offset: 0x00327F36
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvent(Pointer, MemoryOwner);
		}

		// Token: 0x0401244F RID: 74831
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEvent";

		// Token: 0x04012450 RID: 74832
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012451 RID: 74833
		internal static int __PropertyOffset_Ptrs;

		// Token: 0x04012452 RID: 74834
		[Nullable(2)]
		private FMovieSceneEventPtrs _Ptrs;
	}
}
