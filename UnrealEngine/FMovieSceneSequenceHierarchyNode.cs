using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002431 RID: 9265
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequenceHierarchyNode")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMovieSceneSequenceHierarchyNode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022B74 RID: 142196 RVA: 0x0033580A File Offset: 0x00333A0A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSequenceHierarchyNode._ScriptStructPtr != 0) ? FMovieSceneSequenceHierarchyNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSequenceHierarchyNode", ref FMovieSceneSequenceHierarchyNode._ScriptStructPtr);
		}

		// Token: 0x1700858D RID: 34189
		// (get) Token: 0x06022B75 RID: 142197 RVA: 0x00335830 File Offset: 0x00333A30
		// (set) Token: 0x06022B76 RID: 142198 RVA: 0x00335873 File Offset: 0x00333A73
		public FMovieSceneSequenceID ParentID
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequenceID result;
				if ((result = this._ParentID) == null)
				{
					result = (this._ParentID = new FMovieSceneSequenceID(base.NativePtr + (IntPtr)FMovieSceneSequenceHierarchyNode.__PropertyOffset_ParentID, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequenceID.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSequenceHierarchyNode.__PropertyOffset_ParentID, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700858E RID: 34190
		// (get) Token: 0x06022B77 RID: 142199 RVA: 0x00335894 File Offset: 0x00333A94
		// (set) Token: 0x06022B78 RID: 142200 RVA: 0x003358D7 File Offset: 0x00333AD7
		public TArray<FMovieSceneSequenceID> Children
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneSequenceID> result;
				if ((result = this._Children) == null)
				{
					result = (this._Children = new TArray<FMovieSceneSequenceID>(base.NativePtr + (IntPtr)FMovieSceneSequenceHierarchyNode.__PropertyOffset_Children, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Children.CopyAssign(value);
			}
		}

		// Token: 0x06022B79 RID: 142201 RVA: 0x003358E5 File Offset: 0x00333AE5
		public FMovieSceneSequenceHierarchyNode()
		{
		}

		// Token: 0x06022B7A RID: 142202 RVA: 0x003358ED File Offset: 0x00333AED
		public FMovieSceneSequenceHierarchyNode(FMovieSceneSequenceID ParentID, TArray<FMovieSceneSequenceID> Children)
		{
			this.ParentID = ParentID;
			this.Children = Children;
		}

		// Token: 0x06022B7B RID: 142203 RVA: 0x00335903 File Offset: 0x00333B03
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSequenceHierarchyNode.StaticStruct();
		}

		// Token: 0x06022B7C RID: 142204 RVA: 0x0033590F File Offset: 0x00333B0F
		[NullableContext(2)]
		public FMovieSceneSequenceHierarchyNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022B7D RID: 142205 RVA: 0x00335919 File Offset: 0x00333B19
		public FMovieSceneSequenceHierarchyNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022B7E RID: 142206 RVA: 0x00335924 File Offset: 0x00333B24
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSequenceHierarchyNode(Pointer, false, true);
		}

		// Token: 0x06022B7F RID: 142207 RVA: 0x0033592E File Offset: 0x00333B2E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSequenceHierarchyNode(Pointer, MemoryOwner);
		}

		// Token: 0x040128BD RID: 75965
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSequenceHierarchyNode";

		// Token: 0x040128BE RID: 75966
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040128BF RID: 75967
		internal static int __PropertyOffset_ParentID;

		// Token: 0x040128C0 RID: 75968
		[Nullable(2)]
		private FMovieSceneSequenceID _ParentID;

		// Token: 0x040128C1 RID: 75969
		internal static int __PropertyOffset_Children;

		// Token: 0x040128C2 RID: 75970
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneSequenceID> _Children;
	}
}
