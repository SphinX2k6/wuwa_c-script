using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002420 RID: 9248
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieScenePossessable")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FMovieScenePossessable : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022A72 RID: 141938 RVA: 0x00333E8F File Offset: 0x0033208F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieScenePossessable._ScriptStructPtr != 0) ? FMovieScenePossessable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieScenePossessable", ref FMovieScenePossessable._ScriptStructPtr);
		}

		// Token: 0x17008555 RID: 34133
		// (get) Token: 0x06022A73 RID: 141939 RVA: 0x00333EB4 File Offset: 0x003320B4
		// (set) Token: 0x06022A74 RID: 141940 RVA: 0x00333EF7 File Offset: 0x003320F7
		public TArray<FName> Tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new TArray<FName>(base.NativePtr + (IntPtr)FMovieScenePossessable.__PropertyOffset_Tags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Tags.CopyAssign(value);
			}
		}

		// Token: 0x17008556 RID: 34134
		// (get) Token: 0x06022A75 RID: 141941 RVA: 0x00333F05 File Offset: 0x00332105
		// (set) Token: 0x06022A76 RID: 141942 RVA: 0x00333F19 File Offset: 0x00332119
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScenePossessable.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScenePossessable.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x17008557 RID: 34135
		// (get) Token: 0x06022A77 RID: 141943 RVA: 0x00333F2E File Offset: 0x0033212E
		// (set) Token: 0x06022A78 RID: 141944 RVA: 0x00333F42 File Offset: 0x00332142
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMovieScenePossessable.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMovieScenePossessable.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17008558 RID: 34136
		// (get) Token: 0x06022A79 RID: 141945 RVA: 0x00333F57 File Offset: 0x00332157
		// (set) Token: 0x06022A7A RID: 141946 RVA: 0x00333F6B File Offset: 0x0033216B
		public unsafe FGuid ParentGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScenePossessable.__PropertyOffset_ParentGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScenePossessable.__PropertyOffset_ParentGuid) = value;
			}
		}

		// Token: 0x06022A7B RID: 141947 RVA: 0x00333F80 File Offset: 0x00332180
		public FMovieScenePossessable()
		{
		}

		// Token: 0x06022A7C RID: 141948 RVA: 0x00333F88 File Offset: 0x00332188
		public FMovieScenePossessable(TArray<FName> Tags, FGuid Guid, string Name, TSoftClassPtr<UObject> PossessedObjectClass, FGuid ParentGuid)
		{
			this.Tags = Tags;
			this.Guid = Guid;
			this.Name = Name;
			this.ParentGuid = ParentGuid;
		}

		// Token: 0x06022A7D RID: 141949 RVA: 0x00333FAD File Offset: 0x003321AD
		protected override IntPtr GetUStructPtr()
		{
			return FMovieScenePossessable.StaticStruct();
		}

		// Token: 0x06022A7E RID: 141950 RVA: 0x00333FB9 File Offset: 0x003321B9
		[NullableContext(2)]
		public FMovieScenePossessable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022A7F RID: 141951 RVA: 0x00333FC3 File Offset: 0x003321C3
		public FMovieScenePossessable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022A80 RID: 141952 RVA: 0x00333FCE File Offset: 0x003321CE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieScenePossessable(Pointer, false, true);
		}

		// Token: 0x06022A81 RID: 141953 RVA: 0x00333FD8 File Offset: 0x003321D8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieScenePossessable(Pointer, MemoryOwner);
		}

		// Token: 0x04012839 RID: 75833
		public const string __ObjectPath = "/Script/MovieScene.MovieScenePossessable";

		// Token: 0x0401283A RID: 75834
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401283B RID: 75835
		internal static int __PropertyOffset_Tags;

		// Token: 0x0401283C RID: 75836
		[Nullable(2)]
		private TArray<FName> _Tags;

		// Token: 0x0401283D RID: 75837
		internal static int __PropertyOffset_Guid;

		// Token: 0x0401283E RID: 75838
		internal static int __PropertyOffset_Name;

		// Token: 0x0401283F RID: 75839
		internal static int __PropertyOffset_ParentGuid;
	}
}
