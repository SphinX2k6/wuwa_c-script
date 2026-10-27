using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002430 RID: 9264
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequenceHierarchy")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 280)]
	public class FMovieSceneSequenceHierarchy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022B64 RID: 142180 RVA: 0x00335615 File Offset: 0x00333815
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSequenceHierarchy._ScriptStructPtr != 0) ? FMovieSceneSequenceHierarchy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSequenceHierarchy", ref FMovieSceneSequenceHierarchy._ScriptStructPtr);
		}

		// Token: 0x17008589 RID: 34185
		// (get) Token: 0x06022B65 RID: 142181 RVA: 0x0033563C File Offset: 0x0033383C
		// (set) Token: 0x06022B66 RID: 142182 RVA: 0x0033567F File Offset: 0x0033387F
		public FMovieSceneSequenceHierarchyNode RootNode
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequenceHierarchyNode result;
				if ((result = this._RootNode) == null)
				{
					result = (this._RootNode = new FMovieSceneSequenceHierarchyNode(base.NativePtr + (IntPtr)FMovieSceneSequenceHierarchy.__PropertyOffset_RootNode, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequenceHierarchyNode.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSequenceHierarchy.__PropertyOffset_RootNode, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700858A RID: 34186
		// (get) Token: 0x06022B67 RID: 142183 RVA: 0x003356A0 File Offset: 0x003338A0
		// (set) Token: 0x06022B68 RID: 142184 RVA: 0x003356E3 File Offset: 0x003338E3
		public FMovieSceneSubSequenceTree Tree
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSubSequenceTree result;
				if ((result = this._Tree) == null)
				{
					result = (this._Tree = new FMovieSceneSubSequenceTree(base.NativePtr + (IntPtr)FMovieSceneSequenceHierarchy.__PropertyOffset_Tree, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSubSequenceTree.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSequenceHierarchy.__PropertyOffset_Tree, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700858B RID: 34187
		// (get) Token: 0x06022B69 RID: 142185 RVA: 0x00335704 File Offset: 0x00333904
		// (set) Token: 0x06022B6A RID: 142186 RVA: 0x00335747 File Offset: 0x00333947
		public TMap<FMovieSceneSequenceID, FMovieSceneSubSequenceData> SubSequences
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FMovieSceneSequenceID, FMovieSceneSubSequenceData> result;
				if ((result = this._SubSequences) == null)
				{
					result = (this._SubSequences = new TMap<FMovieSceneSequenceID, FMovieSceneSubSequenceData>(base.NativePtr + (IntPtr)FMovieSceneSequenceHierarchy.__PropertyOffset_SubSequences, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SubSequences.CopyAssign(value);
			}
		}

		// Token: 0x1700858C RID: 34188
		// (get) Token: 0x06022B6B RID: 142187 RVA: 0x00335758 File Offset: 0x00333958
		// (set) Token: 0x06022B6C RID: 142188 RVA: 0x0033579B File Offset: 0x0033399B
		public TMap<FMovieSceneSequenceID, FMovieSceneSequenceHierarchyNode> Hierarchy
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FMovieSceneSequenceID, FMovieSceneSequenceHierarchyNode> result;
				if ((result = this._Hierarchy) == null)
				{
					result = (this._Hierarchy = new TMap<FMovieSceneSequenceID, FMovieSceneSequenceHierarchyNode>(base.NativePtr + (IntPtr)FMovieSceneSequenceHierarchy.__PropertyOffset_Hierarchy, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Hierarchy.CopyAssign(value);
			}
		}

		// Token: 0x06022B6D RID: 142189 RVA: 0x003357A9 File Offset: 0x003339A9
		public FMovieSceneSequenceHierarchy()
		{
		}

		// Token: 0x06022B6E RID: 142190 RVA: 0x003357B1 File Offset: 0x003339B1
		public FMovieSceneSequenceHierarchy(FMovieSceneSequenceHierarchyNode RootNode, FMovieSceneSubSequenceTree Tree, TMap<FMovieSceneSequenceID, FMovieSceneSubSequenceData> SubSequences, TMap<FMovieSceneSequenceID, FMovieSceneSequenceHierarchyNode> Hierarchy)
		{
			this.RootNode = RootNode;
			this.Tree = Tree;
			this.SubSequences = SubSequences;
			this.Hierarchy = Hierarchy;
		}

		// Token: 0x06022B6F RID: 142191 RVA: 0x003357D6 File Offset: 0x003339D6
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSequenceHierarchy.StaticStruct();
		}

		// Token: 0x06022B70 RID: 142192 RVA: 0x003357E2 File Offset: 0x003339E2
		[NullableContext(2)]
		public FMovieSceneSequenceHierarchy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022B71 RID: 142193 RVA: 0x003357EC File Offset: 0x003339EC
		public FMovieSceneSequenceHierarchy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022B72 RID: 142194 RVA: 0x003357F7 File Offset: 0x003339F7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSequenceHierarchy(Pointer, false, true);
		}

		// Token: 0x06022B73 RID: 142195 RVA: 0x00335801 File Offset: 0x00333A01
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSequenceHierarchy(Pointer, MemoryOwner);
		}

		// Token: 0x040128B3 RID: 75955
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSequenceHierarchy";

		// Token: 0x040128B4 RID: 75956
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040128B5 RID: 75957
		internal static int __PropertyOffset_RootNode;

		// Token: 0x040128B6 RID: 75958
		[Nullable(2)]
		private FMovieSceneSequenceHierarchyNode _RootNode;

		// Token: 0x040128B7 RID: 75959
		internal static int __PropertyOffset_Tree;

		// Token: 0x040128B8 RID: 75960
		[Nullable(2)]
		private FMovieSceneSubSequenceTree _Tree;

		// Token: 0x040128B9 RID: 75961
		internal static int __PropertyOffset_SubSequences;

		// Token: 0x040128BA RID: 75962
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FMovieSceneSequenceID, FMovieSceneSubSequenceData> _SubSequences;

		// Token: 0x040128BB RID: 75963
		internal static int __PropertyOffset_Hierarchy;

		// Token: 0x040128BC RID: 75964
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FMovieSceneSequenceID, FMovieSceneSequenceHierarchyNode> _Hierarchy;
	}
}
