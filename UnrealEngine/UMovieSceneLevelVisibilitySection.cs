using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002385 RID: 9093
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UMovieSceneLevelVisibilitySection : UMovieSceneSection, IUnrealUObject, IUnrealObject, IMovieSceneEntityProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602247A RID: 140410 RVA: 0x0032B24A File Offset: 0x0032944A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneLevelVisibilitySection._ClassPtr;
		}

		// Token: 0x0602247B RID: 140411 RVA: 0x0032B256 File Offset: 0x00329456
		int IMovieSceneEntityProvider.InterfaceOffset()
		{
			return UMovieSceneLevelVisibilitySection.__InterfaceOffset_IMovieSceneEntityProvider;
		}

		// Token: 0x0602247C RID: 140412 RVA: 0x0032B260 File Offset: 0x00329460
		public UMovieSceneLevelVisibilitySection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneLevelVisibilitySection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602247D RID: 140413 RVA: 0x0032B288 File Offset: 0x00329488
		[NullableContext(1)]
		public UMovieSceneLevelVisibilitySection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneLevelVisibilitySection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008435 RID: 33845
		// (get) Token: 0x0602247E RID: 140414 RVA: 0x0032B2BB File Offset: 0x003294BB
		// (set) Token: 0x0602247F RID: 140415 RVA: 0x0032B2CB File Offset: 0x003294CB
		public unsafe ELevelVisibility Visibility
		{
			get
			{
				return (ELevelVisibility)(*(base.NativePtr + (IntPtr)UMovieSceneLevelVisibilitySection.__PropertyOffset_Visibility));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneLevelVisibilitySection.__PropertyOffset_Visibility) = (byte)value;
			}
		}

		// Token: 0x17008436 RID: 33846
		// (get) Token: 0x06022480 RID: 140416 RVA: 0x0032B2DC File Offset: 0x003294DC
		// (set) Token: 0x06022481 RID: 140417 RVA: 0x0032B315 File Offset: 0x00329515
		[Nullable(1)]
		public TArray<FName> LevelNames
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._LevelNames) == null)
				{
					result = (this._LevelNames = new TArray<FName>(base.NativePtr + (IntPtr)UMovieSceneLevelVisibilitySection.__PropertyOffset_LevelNames, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LevelNames.CopyAssign(value);
			}
		}

		// Token: 0x06022482 RID: 140418 RVA: 0x0032B323 File Offset: 0x00329523
		public void SetVisibility(ELevelVisibility InVisibility)
		{
			UMovieSceneLevelVisibilitySection.__SetVisibility_Internal(base.NativePtr, InVisibility);
		}

		// Token: 0x06022483 RID: 140419 RVA: 0x0032B331 File Offset: 0x00329531
		[NullableContext(2)]
		public void SetLevelNames(in TArray<FName> InLevelNames)
		{
			UMovieSceneLevelVisibilitySection.__SetLevelNames_Internal(base.NativePtr, (InLevelNames ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x06022484 RID: 140420 RVA: 0x0032B34E File Offset: 0x0032954E
		public ELevelVisibility GetVisibility()
		{
			return UMovieSceneLevelVisibilitySection.__GetVisibility_Internal(base.NativePtr);
		}

		// Token: 0x06022485 RID: 140421 RVA: 0x0032B35B File Offset: 0x0032955B
		[NullableContext(1)]
		public TArray<FName> GetLevelNames()
		{
			return new TArray<FName>(UMovieSceneLevelVisibilitySection.__GetLevelNames_Internal(base.NativePtr), null);
		}

		// Token: 0x06022486 RID: 140422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVisibility_Internal(IntPtr @this, ELevelVisibility InVisibility);

		// Token: 0x06022487 RID: 140423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLevelNames_Internal(IntPtr @this, IntPtr InLevelNames);

		// Token: 0x06022488 RID: 140424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELevelVisibility __GetVisibility_Internal(IntPtr @this);

		// Token: 0x06022489 RID: 140425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLevelNames_Internal(IntPtr @this);

		// Token: 0x0602248A RID: 140426 RVA: 0x0032B36E File Offset: 0x0032956E
		static UMovieSceneLevelVisibilitySection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection");
		}

		// Token: 0x0602248B RID: 140427 RVA: 0x0032B37C File Offset: 0x0032957C
		protected UMovieSceneLevelVisibilitySection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124CF RID: 74959
		internal static int __InterfaceOffset_IMovieSceneEntityProvider;

		// Token: 0x040124D0 RID: 74960
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection";

		// Token: 0x040124D1 RID: 74961
		private static IntPtr _ClassPtr;

		// Token: 0x040124D2 RID: 74962
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124D3 RID: 74963
		internal static int __PropertyOffset_Visibility;

		// Token: 0x040124D4 RID: 74964
		internal static int __PropertyOffset_LevelNames;

		// Token: 0x040124D5 RID: 74965
		[Nullable(2)]
		private TArray<FName> _LevelNames;
	}
}
