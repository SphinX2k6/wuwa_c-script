using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000A58 RID: 2648
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EditorMapPerformanceTestDefinition")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FEditorMapPerformanceTestDefinition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008FD3 RID: 36819 RVA: 0x000CDDB3 File Offset: 0x000CBFB3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEditorMapPerformanceTestDefinition._ScriptStructPtr != 0) ? FEditorMapPerformanceTestDefinition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EditorMapPerformanceTestDefinition", ref FEditorMapPerformanceTestDefinition._ScriptStructPtr);
		}

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x06008FD4 RID: 36820 RVA: 0x000CDDD8 File Offset: 0x000CBFD8
		// (set) Token: 0x06008FD5 RID: 36821 RVA: 0x000CDE1B File Offset: 0x000CC01B
		public FSoftObjectPath PerformanceTestmap
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._PerformanceTestmap) == null)
				{
					result = (this._PerformanceTestmap = new FSoftObjectPath(base.NativePtr + (IntPtr)FEditorMapPerformanceTestDefinition.__PropertyOffset_PerformanceTestmap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FEditorMapPerformanceTestDefinition.__PropertyOffset_PerformanceTestmap, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x06008FD6 RID: 36822 RVA: 0x000CDE3C File Offset: 0x000CC03C
		// (set) Token: 0x06008FD7 RID: 36823 RVA: 0x000CDE4C File Offset: 0x000CC04C
		public unsafe int TestTimer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEditorMapPerformanceTestDefinition.__PropertyOffset_TestTimer);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEditorMapPerformanceTestDefinition.__PropertyOffset_TestTimer) = value;
			}
		}

		// Token: 0x06008FD8 RID: 36824 RVA: 0x000CDE5D File Offset: 0x000CC05D
		public FEditorMapPerformanceTestDefinition()
		{
		}

		// Token: 0x06008FD9 RID: 36825 RVA: 0x000CDE65 File Offset: 0x000CC065
		public FEditorMapPerformanceTestDefinition(FSoftObjectPath PerformanceTestmap, int TestTimer)
		{
			this.PerformanceTestmap = PerformanceTestmap;
			this.TestTimer = TestTimer;
		}

		// Token: 0x06008FDA RID: 36826 RVA: 0x000CDE7B File Offset: 0x000CC07B
		protected override IntPtr GetUStructPtr()
		{
			return FEditorMapPerformanceTestDefinition.StaticStruct();
		}

		// Token: 0x06008FDB RID: 36827 RVA: 0x000CDE87 File Offset: 0x000CC087
		[NullableContext(2)]
		public FEditorMapPerformanceTestDefinition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008FDC RID: 36828 RVA: 0x000CDE91 File Offset: 0x000CC091
		public FEditorMapPerformanceTestDefinition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008FDD RID: 36829 RVA: 0x000CDE9C File Offset: 0x000CC09C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEditorMapPerformanceTestDefinition(Pointer, false, true);
		}

		// Token: 0x06008FDE RID: 36830 RVA: 0x000CDEA6 File Offset: 0x000CC0A6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEditorMapPerformanceTestDefinition(Pointer, MemoryOwner);
		}

		// Token: 0x04004717 RID: 18199
		public const string __ObjectPath = "/Script/Engine.EditorMapPerformanceTestDefinition";

		// Token: 0x04004718 RID: 18200
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004719 RID: 18201
		internal static int __PropertyOffset_PerformanceTestmap;

		// Token: 0x0400471A RID: 18202
		[Nullable(2)]
		private FSoftObjectPath _PerformanceTestmap;

		// Token: 0x0400471B RID: 18203
		internal static int __PropertyOffset_TestTimer;
	}
}
