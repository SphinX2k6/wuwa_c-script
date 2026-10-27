using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002422 RID: 9250
	[UnrealObjectPath("/Script/MovieScene.MovieScenePropertyBinding")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FMovieScenePropertyBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022A83 RID: 141955 RVA: 0x00333FE1 File Offset: 0x003321E1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieScenePropertyBinding._ScriptStructPtr != 0) ? FMovieScenePropertyBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieScenePropertyBinding", ref FMovieScenePropertyBinding._ScriptStructPtr);
		}

		// Token: 0x17008559 RID: 34137
		// (get) Token: 0x06022A84 RID: 141956 RVA: 0x00334005 File Offset: 0x00332205
		// (set) Token: 0x06022A85 RID: 141957 RVA: 0x00334019 File Offset: 0x00332219
		public unsafe FName PropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScenePropertyBinding.__PropertyOffset_PropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScenePropertyBinding.__PropertyOffset_PropertyName) = value;
			}
		}

		// Token: 0x1700855A RID: 34138
		// (get) Token: 0x06022A86 RID: 141958 RVA: 0x0033402E File Offset: 0x0033222E
		// (set) Token: 0x06022A87 RID: 141959 RVA: 0x00334042 File Offset: 0x00332242
		public unsafe FName PropertyPath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScenePropertyBinding.__PropertyOffset_PropertyPath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScenePropertyBinding.__PropertyOffset_PropertyPath) = value;
			}
		}

		// Token: 0x1700855B RID: 34139
		// (get) Token: 0x06022A88 RID: 141960 RVA: 0x00334057 File Offset: 0x00332257
		// (set) Token: 0x06022A89 RID: 141961 RVA: 0x00334067 File Offset: 0x00332267
		public unsafe bool bCanUseClassLookup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScenePropertyBinding.__PropertyOffset_bCanUseClassLookup) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScenePropertyBinding.__PropertyOffset_bCanUseClassLookup) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022A8A RID: 141962 RVA: 0x00334078 File Offset: 0x00332278
		public FMovieScenePropertyBinding()
		{
		}

		// Token: 0x06022A8B RID: 141963 RVA: 0x00334080 File Offset: 0x00332280
		public FMovieScenePropertyBinding(FName PropertyName, FName PropertyPath, bool bCanUseClassLookup)
		{
			this.PropertyName = PropertyName;
			this.PropertyPath = PropertyPath;
			this.bCanUseClassLookup = bCanUseClassLookup;
		}

		// Token: 0x06022A8C RID: 141964 RVA: 0x0033409D File Offset: 0x0033229D
		protected override IntPtr GetUStructPtr()
		{
			return FMovieScenePropertyBinding.StaticStruct();
		}

		// Token: 0x06022A8D RID: 141965 RVA: 0x003340A9 File Offset: 0x003322A9
		[NullableContext(2)]
		public FMovieScenePropertyBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022A8E RID: 141966 RVA: 0x003340B3 File Offset: 0x003322B3
		public FMovieScenePropertyBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022A8F RID: 141967 RVA: 0x003340BE File Offset: 0x003322BE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieScenePropertyBinding(Pointer, false, true);
		}

		// Token: 0x06022A90 RID: 141968 RVA: 0x003340C8 File Offset: 0x003322C8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieScenePropertyBinding(Pointer, MemoryOwner);
		}

		// Token: 0x04012841 RID: 75841
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieScenePropertyBinding";

		// Token: 0x04012842 RID: 75842
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012843 RID: 75843
		internal static int __PropertyOffset_PropertyName;

		// Token: 0x04012844 RID: 75844
		internal static int __PropertyOffset_PropertyPath;

		// Token: 0x04012845 RID: 75845
		internal static int __PropertyOffset_bCanUseClassLookup;
	}
}
