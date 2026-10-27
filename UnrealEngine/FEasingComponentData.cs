using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023C3 RID: 9155
	[UnrealObjectPath("/Script/MovieScene.EasingComponentData")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FEasingComponentData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022717 RID: 141079 RVA: 0x0032F052 File Offset: 0x0032D252
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEasingComponentData._ScriptStructPtr != 0) ? FEasingComponentData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.EasingComponentData", ref FEasingComponentData._ScriptStructPtr);
		}

		// Token: 0x170084AB RID: 33963
		// (get) Token: 0x06022718 RID: 141080 RVA: 0x0032F076 File Offset: 0x0032D276
		// (set) Token: 0x06022719 RID: 141081 RVA: 0x0032F08A File Offset: 0x0032D28A
		[Nullable(2)]
		public unsafe UMovieSceneSection Section
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneSection>(base.NativePtr / (IntPtr)sizeof(void*) + FEasingComponentData.__PropertyOffset_Section);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FEasingComponentData.__PropertyOffset_Section, value);
			}
		}

		// Token: 0x0602271A RID: 141082 RVA: 0x0032F09F File Offset: 0x0032D29F
		public FEasingComponentData()
		{
		}

		// Token: 0x0602271B RID: 141083 RVA: 0x0032F0A7 File Offset: 0x0032D2A7
		[NullableContext(1)]
		public FEasingComponentData(UMovieSceneSection Section)
		{
			this.Section = Section;
		}

		// Token: 0x0602271C RID: 141084 RVA: 0x0032F0B6 File Offset: 0x0032D2B6
		protected override IntPtr GetUStructPtr()
		{
			return FEasingComponentData.StaticStruct();
		}

		// Token: 0x0602271D RID: 141085 RVA: 0x0032F0C2 File Offset: 0x0032D2C2
		[NullableContext(2)]
		public FEasingComponentData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602271E RID: 141086 RVA: 0x0032F0CC File Offset: 0x0032D2CC
		public FEasingComponentData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602271F RID: 141087 RVA: 0x0032F0D7 File Offset: 0x0032D2D7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEasingComponentData(Pointer, false, true);
		}

		// Token: 0x06022720 RID: 141088 RVA: 0x0032F0E1 File Offset: 0x0032D2E1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEasingComponentData(Pointer, MemoryOwner);
		}

		// Token: 0x04012629 RID: 75305
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.EasingComponentData";

		// Token: 0x0401262A RID: 75306
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401262B RID: 75307
		internal static int __PropertyOffset_Section;
	}
}
