using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002423 RID: 9251
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieScenePropertySectionData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieScenePropertySectionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022A91 RID: 141969 RVA: 0x003340D1 File Offset: 0x003322D1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieScenePropertySectionData._ScriptStructPtr != 0) ? FMovieScenePropertySectionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieScenePropertySectionData", ref FMovieScenePropertySectionData._ScriptStructPtr);
		}

		// Token: 0x1700855C RID: 34140
		// (get) Token: 0x06022A92 RID: 141970 RVA: 0x003340F5 File Offset: 0x003322F5
		// (set) Token: 0x06022A93 RID: 141971 RVA: 0x00334109 File Offset: 0x00332309
		public unsafe FName PropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScenePropertySectionData.__PropertyOffset_PropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScenePropertySectionData.__PropertyOffset_PropertyName) = value;
			}
		}

		// Token: 0x1700855D RID: 34141
		// (get) Token: 0x06022A94 RID: 141972 RVA: 0x0033411E File Offset: 0x0033231E
		// (set) Token: 0x06022A95 RID: 141973 RVA: 0x00334132 File Offset: 0x00332332
		public unsafe string PropertyPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMovieScenePropertySectionData.__PropertyOffset_PropertyPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMovieScenePropertySectionData.__PropertyOffset_PropertyPath)), value);
			}
		}

		// Token: 0x06022A96 RID: 141974 RVA: 0x00334147 File Offset: 0x00332347
		public FMovieScenePropertySectionData()
		{
		}

		// Token: 0x06022A97 RID: 141975 RVA: 0x0033414F File Offset: 0x0033234F
		public FMovieScenePropertySectionData(FName PropertyName, string PropertyPath)
		{
			this.PropertyName = PropertyName;
			this.PropertyPath = PropertyPath;
		}

		// Token: 0x06022A98 RID: 141976 RVA: 0x00334165 File Offset: 0x00332365
		protected override IntPtr GetUStructPtr()
		{
			return FMovieScenePropertySectionData.StaticStruct();
		}

		// Token: 0x06022A99 RID: 141977 RVA: 0x00334171 File Offset: 0x00332371
		[NullableContext(2)]
		public FMovieScenePropertySectionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022A9A RID: 141978 RVA: 0x0033417B File Offset: 0x0033237B
		public FMovieScenePropertySectionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022A9B RID: 141979 RVA: 0x00334186 File Offset: 0x00332386
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieScenePropertySectionData(Pointer, false, true);
		}

		// Token: 0x06022A9C RID: 141980 RVA: 0x00334190 File Offset: 0x00332390
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieScenePropertySectionData(Pointer, MemoryOwner);
		}

		// Token: 0x04012846 RID: 75846
		public const string __ObjectPath = "/Script/MovieScene.MovieScenePropertySectionData";

		// Token: 0x04012847 RID: 75847
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012848 RID: 75848
		internal static int __PropertyOffset_PropertyName;

		// Token: 0x04012849 RID: 75849
		internal static int __PropertyOffset_PropertyPath;
	}
}
