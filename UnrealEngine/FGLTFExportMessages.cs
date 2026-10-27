using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001446 RID: 5190
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GLTFExporter.GLTFExportMessages")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FGLTFExportMessages : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012F7D RID: 77693 RVA: 0x001BE3F5 File Offset: 0x001BC5F5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGLTFExportMessages._ScriptStructPtr != 0) ? FGLTFExportMessages._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GLTFExporter.GLTFExportMessages", ref FGLTFExportMessages._ScriptStructPtr);
		}

		// Token: 0x170049B6 RID: 18870
		// (get) Token: 0x06012F7E RID: 77694 RVA: 0x001BE41C File Offset: 0x001BC61C
		// (set) Token: 0x06012F7F RID: 77695 RVA: 0x001BE45F File Offset: 0x001BC65F
		public TArray<string> Suggestions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Suggestions) == null)
				{
					result = (this._Suggestions = new TArray<string>(base.NativePtr + (IntPtr)FGLTFExportMessages.__PropertyOffset_Suggestions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Suggestions.CopyAssign(value);
			}
		}

		// Token: 0x170049B7 RID: 18871
		// (get) Token: 0x06012F80 RID: 77696 RVA: 0x001BE470 File Offset: 0x001BC670
		// (set) Token: 0x06012F81 RID: 77697 RVA: 0x001BE4B3 File Offset: 0x001BC6B3
		public TArray<string> Warnings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Warnings) == null)
				{
					result = (this._Warnings = new TArray<string>(base.NativePtr + (IntPtr)FGLTFExportMessages.__PropertyOffset_Warnings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Warnings.CopyAssign(value);
			}
		}

		// Token: 0x170049B8 RID: 18872
		// (get) Token: 0x06012F82 RID: 77698 RVA: 0x001BE4C4 File Offset: 0x001BC6C4
		// (set) Token: 0x06012F83 RID: 77699 RVA: 0x001BE507 File Offset: 0x001BC707
		public TArray<string> Errors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Errors) == null)
				{
					result = (this._Errors = new TArray<string>(base.NativePtr + (IntPtr)FGLTFExportMessages.__PropertyOffset_Errors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Errors.CopyAssign(value);
			}
		}

		// Token: 0x06012F84 RID: 77700 RVA: 0x001BE515 File Offset: 0x001BC715
		public FGLTFExportMessages()
		{
		}

		// Token: 0x06012F85 RID: 77701 RVA: 0x001BE51D File Offset: 0x001BC71D
		public FGLTFExportMessages(TArray<string> Suggestions, TArray<string> Warnings, TArray<string> Errors)
		{
			this.Suggestions = Suggestions;
			this.Warnings = Warnings;
			this.Errors = Errors;
		}

		// Token: 0x06012F86 RID: 77702 RVA: 0x001BE53A File Offset: 0x001BC73A
		protected override IntPtr GetUStructPtr()
		{
			return FGLTFExportMessages.StaticStruct();
		}

		// Token: 0x06012F87 RID: 77703 RVA: 0x001BE546 File Offset: 0x001BC746
		[NullableContext(2)]
		public FGLTFExportMessages(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012F88 RID: 77704 RVA: 0x001BE550 File Offset: 0x001BC750
		public FGLTFExportMessages(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012F89 RID: 77705 RVA: 0x001BE55B File Offset: 0x001BC75B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGLTFExportMessages(Pointer, false, true);
		}

		// Token: 0x06012F8A RID: 77706 RVA: 0x001BE565 File Offset: 0x001BC765
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGLTFExportMessages(Pointer, MemoryOwner);
		}

		// Token: 0x0400A24D RID: 41549
		public const string __ObjectPath = "/Script/GLTFExporter.GLTFExportMessages";

		// Token: 0x0400A24E RID: 41550
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A24F RID: 41551
		internal static int __PropertyOffset_Suggestions;

		// Token: 0x0400A250 RID: 41552
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Suggestions;

		// Token: 0x0400A251 RID: 41553
		internal static int __PropertyOffset_Warnings;

		// Token: 0x0400A252 RID: 41554
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Warnings;

		// Token: 0x0400A253 RID: 41555
		internal static int __PropertyOffset_Errors;

		// Token: 0x0400A254 RID: 41556
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Errors;
	}
}
