using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002324 RID: 8996
	[UnrealObjectPath("/Script/MovieSceneTracks.LevelVisibilityComponentData")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FLevelVisibilityComponentData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022091 RID: 139409 RVA: 0x00325106 File Offset: 0x00323306
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelVisibilityComponentData._ScriptStructPtr != 0) ? FLevelVisibilityComponentData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.LevelVisibilityComponentData", ref FLevelVisibilityComponentData._ScriptStructPtr);
		}

		// Token: 0x1700837D RID: 33661
		// (get) Token: 0x06022092 RID: 139410 RVA: 0x0032512A File Offset: 0x0032332A
		// (set) Token: 0x06022093 RID: 139411 RVA: 0x0032513E File Offset: 0x0032333E
		[Nullable(2)]
		public unsafe UMovieSceneLevelVisibilitySection Section
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneLevelVisibilitySection>(base.NativePtr / (IntPtr)sizeof(void*) + FLevelVisibilityComponentData.__PropertyOffset_Section);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLevelVisibilityComponentData.__PropertyOffset_Section, value);
			}
		}

		// Token: 0x06022094 RID: 139412 RVA: 0x00325153 File Offset: 0x00323353
		public FLevelVisibilityComponentData()
		{
		}

		// Token: 0x06022095 RID: 139413 RVA: 0x0032515B File Offset: 0x0032335B
		[NullableContext(1)]
		public FLevelVisibilityComponentData(UMovieSceneLevelVisibilitySection Section)
		{
			this.Section = Section;
		}

		// Token: 0x06022096 RID: 139414 RVA: 0x0032516A File Offset: 0x0032336A
		protected override IntPtr GetUStructPtr()
		{
			return FLevelVisibilityComponentData.StaticStruct();
		}

		// Token: 0x06022097 RID: 139415 RVA: 0x00325176 File Offset: 0x00323376
		[NullableContext(2)]
		public FLevelVisibilityComponentData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022098 RID: 139416 RVA: 0x00325180 File Offset: 0x00323380
		public FLevelVisibilityComponentData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022099 RID: 139417 RVA: 0x0032518B File Offset: 0x0032338B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelVisibilityComponentData(Pointer, false, true);
		}

		// Token: 0x0602209A RID: 139418 RVA: 0x00325195 File Offset: 0x00323395
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelVisibilityComponentData(Pointer, MemoryOwner);
		}

		// Token: 0x04012296 RID: 74390
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieSceneTracks.LevelVisibilityComponentData";

		// Token: 0x04012297 RID: 74391
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012298 RID: 74392
		internal static int __PropertyOffset_Section;
	}
}
