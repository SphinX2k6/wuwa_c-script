using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002377 RID: 9079
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventTriggerData")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FMovieSceneEventTriggerData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602240D RID: 140301 RVA: 0x0032A752 File Offset: 0x00328952
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEventTriggerData._ScriptStructPtr != 0) ? FMovieSceneEventTriggerData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneEventTriggerData", ref FMovieSceneEventTriggerData._ScriptStructPtr);
		}

		// Token: 0x17008428 RID: 33832
		// (get) Token: 0x0602240E RID: 140302 RVA: 0x0032A778 File Offset: 0x00328978
		// (set) Token: 0x0602240F RID: 140303 RVA: 0x0032A7BB File Offset: 0x003289BB
		public FMovieSceneEventPtrs Ptrs
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEventPtrs result;
				if ((result = this._Ptrs) == null)
				{
					result = (this._Ptrs = new FMovieSceneEventPtrs(base.NativePtr + (IntPtr)FMovieSceneEventTriggerData.__PropertyOffset_Ptrs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEventPtrs.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEventTriggerData.__PropertyOffset_Ptrs, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008429 RID: 33833
		// (get) Token: 0x06022410 RID: 140304 RVA: 0x0032A7DC File Offset: 0x003289DC
		// (set) Token: 0x06022411 RID: 140305 RVA: 0x0032A7F0 File Offset: 0x003289F0
		public unsafe FGuid ObjectBindingID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEventTriggerData.__PropertyOffset_ObjectBindingID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEventTriggerData.__PropertyOffset_ObjectBindingID) = value;
			}
		}

		// Token: 0x06022412 RID: 140306 RVA: 0x0032A805 File Offset: 0x00328A05
		public FMovieSceneEventTriggerData()
		{
		}

		// Token: 0x06022413 RID: 140307 RVA: 0x0032A80D File Offset: 0x00328A0D
		public FMovieSceneEventTriggerData(FMovieSceneEventPtrs Ptrs, FGuid ObjectBindingID)
		{
			this.Ptrs = Ptrs;
			this.ObjectBindingID = ObjectBindingID;
		}

		// Token: 0x06022414 RID: 140308 RVA: 0x0032A823 File Offset: 0x00328A23
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEventTriggerData.StaticStruct();
		}

		// Token: 0x06022415 RID: 140309 RVA: 0x0032A82F File Offset: 0x00328A2F
		[NullableContext(2)]
		public FMovieSceneEventTriggerData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022416 RID: 140310 RVA: 0x0032A839 File Offset: 0x00328A39
		public FMovieSceneEventTriggerData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022417 RID: 140311 RVA: 0x0032A844 File Offset: 0x00328A44
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEventTriggerData(Pointer, false, true);
		}

		// Token: 0x06022418 RID: 140312 RVA: 0x0032A84E File Offset: 0x00328A4E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEventTriggerData(Pointer, MemoryOwner);
		}

		// Token: 0x0401248E RID: 74894
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventTriggerData";

		// Token: 0x0401248F RID: 74895
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012490 RID: 74896
		internal static int __PropertyOffset_Ptrs;

		// Token: 0x04012491 RID: 74897
		[Nullable(2)]
		private FMovieSceneEventPtrs _Ptrs;

		// Token: 0x04012492 RID: 74898
		internal static int __PropertyOffset_ObjectBindingID;
	}
}
